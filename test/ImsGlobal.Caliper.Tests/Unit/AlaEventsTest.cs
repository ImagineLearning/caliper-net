using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Events;
using Microsoft.AspNetCore.Http;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;

namespace ImsGlobal.Caliper.Tests.Unit
{
    /// <summary>
    /// Acceptance tests to verify that the caliper spec can meet edgenuity application requirements
    /// https://edgenuity.app.box.com/file/704475824607?s=qc4cipptebdxr4t1zx507gq6f7jsxmp8
    /// </summary>
    public class AlaEventsTest
    {
        const string USER_AGENT_HEADER = "User-Agent";

        /// <summary>
        /// Sample information from an ALA Lti Tool Launch
        /// </summary>
        IDictionary<string, object> AlaLaunchInfo { get; set; }

        /// <summary>
        /// Sample user request which triggers an event
        /// </summary>
        HttpRequest Request { get; set; }


        [OneTimeSetUp]
        public void Init()
        {
            FixtureCoverageChecker.Initialize();

            AlaLaunchInfo = TestUtils.LoadJson<ExpandoObject>(@"Mocks/Ala/launch-info.json");

            var requestConnectionMock = new Mock<ConnectionInfo>();
            requestConnectionMock.Setup(_ => _.RemoteIpAddress).Returns(IPAddress.Parse("192.168.0.1"));

            var requestContextMock = new Mock<HttpContext>();
            requestContextMock.Setup(_ => _.Connection).Returns(requestConnectionMock.Object);

            var requestHeadersMock = new Mock<IHeaderDictionary>();
            requestHeadersMock.Setup(_ => _[USER_AGENT_HEADER])
                .Returns("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:81.0) Gecko/20100101 Firefox/81.0");

            var requestMock = new Mock<HttpRequest>();
            requestMock.Setup(_ => _.Headers).Returns(requestHeadersMock.Object);
            requestMock.Setup(_ => _.HttpContext).Returns(requestContextMock.Object);

            Request = requestMock.Object;
        }

        [OneTimeTearDown]
        public void Dispose()
        {
        }



        [Test]
        public void LogOnEvent()
        {
            var model = new SessionEvent(Guid.NewGuid(), CaliperAction.LoggedIn)
            {
                // the user that logged on
                Actor = new Person(new Uri("https://app.edgenuity.com/users/12345")),

                // the application that the user logged into
                EdApp = new SoftwareApplication(new Uri("https://app.edgenuity.com")),

                // information about a user's standing in an organization
                Membership = new Membership()
                {
                    Organization = new Organization(new Uri("https://app.lms.com")), // the user's organization
                    Roles = new List<Role> { Role.Learner }, // the user's role in the organization
                    Status = Status.Active,
                },

                // logins are usually handled via an Lti tool launch? 
                FederatedSession = new LtiSession(new Uri("https://lms.app.com"))
                {
                    MessageParameters = AlaLaunchInfo,
                },

                Extensions = new
                {
                    UserAgent = Request.Headers[USER_AGENT_HEADER], // Browser and OS
                    IPAddress = Request.HttpContext.Connection.RemoteIpAddress, // User's public IP
                }
            };
        }
    }
}

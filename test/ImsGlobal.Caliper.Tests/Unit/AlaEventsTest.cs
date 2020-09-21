using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Events;
using NUnit.Framework;
using System;


namespace ImsGlobal.Caliper.Tests.Unit
{
    public class AlaEventsTest
    {
        [OneTimeSetUp]
        public void Init()
        {
            FixtureCoverageChecker.Initialize();
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
                Actor = new Person(new Uri("https://foo.bar/users/12345"))
                {

                },
                Object = new SoftwareApplication(new Uri("https://myapp.com")),

            };

        }
    }
}

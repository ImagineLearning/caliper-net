using ImsGlobal.Caliper.Entities.Agent;
using ImsGlobal.Caliper.Events;
using ImsGlobal.Caliper.Events.Session;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImsGlobal.Caliper.Tests.Unit
{
    using Action = Events.Action;

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
            var asd = new { id = new Uri("https://foo.bar/users/12345") };
            var dfg = JsonConvert.SerializeObject(asd);


            var model = new SessionEvent(Guid.NewGuid(), Action.LoggedIn)
            {
                Actor = new Person(new Uri("https://foo.bar/users/12345")),
                Object = new SoftwareApplication(new Uri("https://myapp.com")),

            };

        }
    }
}

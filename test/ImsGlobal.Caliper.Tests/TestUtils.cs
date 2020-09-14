using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ImsGlobal.Caliper.Tests
{
    internal static class TestUtils
    {
        private static string fixturesPath = GetFixturesPath();

        /// <summary>
        /// Loads a reference json file from the caliper-common-fixtures project. The
        /// fixtures project must be a sibling to the caliper-net project on the filesystem.
        /// </summary>
        /// <returns>The reference json file content as a string.</returns>
        /// <param name="refJsonName">Reference json name, without extension.</param>
        public static string LoadReferenceJsonFixture(string refJsonName)
        {
            FixtureCoverageChecker.Add(refJsonName);

            string content = null;
            var stream = new FileStream($"{fixturesPath}/{refJsonName}.json", FileMode.Open);
            using (StreamReader reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }

            return content;
        }

        public static string GetFixturesPath()
        {
            //get the parent dir of the caliper-net dir
            var startDir = new DirectoryInfo(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //given different IDEs and runtime modes, we don't know exactly 
            //where we are, so iterate upwards
            while (startDir.Parent != null)
            {
                startDir = startDir.Parent;
                if (startDir.Name.Equals("caliper-net"))
                    break;
            }

            return Path.Combine(new[]
            {
                startDir.FullName,
                "test",
                "ImsGlobal.Caliper.Tests",
                "caliper-common-fixtures",
                "resources",
                "fixtures"
            });
        }
    }

    internal static class FixtureCoverageChecker
    {
        private static string fixturesPath = TestUtils.GetFixturesPath();
        private static string[] fixtures = Directory.GetFiles(fixturesPath);
        private static HashSet<string> used;

        public static void Initialize()
        {
            used = new HashSet<string>();
        }

        public static void Add(string reference)
        {
            used.Add($"{fixturesPath}/{reference}.json");
        }

        public static bool Compare()
        {
            if (used.Count == fixtures.Length)
                return true;

            Console.WriteLine("Fixture entries used: " + used.Count);
            Console.WriteLine("Fixture entries in fixtures dir: " + fixtures.Length);
            Console.WriteLine("Unused: ");

            foreach (string fixture in fixtures)
            {
                if (!used.Contains(fixture))
                {
                    Console.WriteLine(fixture);
                }
            }
            return false;
        }
    }

}

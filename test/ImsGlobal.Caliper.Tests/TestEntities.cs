using System;
using System.Collections.Generic;
using ImsGlobal.Caliper.Entities;
using ImsGlobal.Caliper.Entities.Agent;
using ImsGlobal.Caliper.Entities.Assessment;
using ImsGlobal.Caliper.Entities.Assignable;
using ImsGlobal.Caliper.Entities.Forum;
using ImsGlobal.Caliper.Entities.Lis;
using ImsGlobal.Caliper.Entities.Media;
using ImsGlobal.Caliper.Entities.Outcome;
using ImsGlobal.Caliper.Entities.Reading;
using ImsGlobal.Caliper.Entities.Session;
using ImsGlobal.Caliper.Events.Outcome;
using NodaTime;


namespace ImsGlobal.Caliper.Tests
{
    internal static class Caliper11TestEntities
    {
        public static DateTime EnvelopeDefaultSendTime { get; } = Instant.FromUtc(2016, 11, 15, 11, 05, 01).ToDateTimeUtc();

        public static string EnvelopeDefaultSensorId { get; } = "https://example.edu/sensors/1";

        public static DateTime Instant20160801060000 { get; } = Instant.FromUtc(2016, 08, 01, 06, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20160902113000 { get; } = Instant.FromUtc(2016, 09, 02, 11, 30, 00).ToDateTimeUtc();
        public static DateTime Instant20161001060000 { get; } = Instant.FromUtc(2016, 10, 01, 06, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20161112100000 { get; } = Instant.FromUtc(2016, 11, 12, 10, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20161112101500 { get; } = Instant.FromUtc(2016, 11, 12, 10, 15, 00).ToDateTimeUtc();
        public static DateTime Instant20161112101000 { get; } = Instant.FromUtc(2016, 11, 12, 10, 10, 00).ToDateTimeUtc();
        public static DateTime Instant20161115101500 { get; } = Instant.FromUtc(2016, 11, 15, 10, 15, 00).ToDateTimeUtc();
        public static DateTime Instant20161115101530 { get; } = Instant.FromUtc(2016, 11, 15, 10, 15, 30).ToDateTimeUtc();
        public static DateTime Instant20161115100000 { get; } = Instant.FromUtc(2016, 11, 15, 10, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20161115101512 { get; } = Instant.FromUtc(2016, 11, 15, 10, 15, 12).ToDateTimeUtc();
        public static DateTime Instant20161115101502 { get; } = Instant.FromUtc(2016, 11, 15, 10, 15, 02).ToDateTimeUtc();
        public static DateTime Instant20161114050000 { get; } = Instant.FromUtc(2016, 11, 14, 05, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20161115101430 { get; } = Instant.FromUtc(2016, 11, 15, 10, 14, 30).ToDateTimeUtc();
        public static DateTime Instant20161115102530 { get; } = Instant.FromUtc(2016, 11, 15, 10, 25, 30).ToDateTimeUtc();
        public static DateTime Instant20161118115959 { get; } = Instant.FromUtc(2016, 11, 18, 11, 59, 59).ToDateTimeUtc();
        public static DateTime Instant20161112071500 { get; } = Instant.FromUtc(2016, 11, 12, 07, 15, 00).ToDateTimeUtc();
        public static DateTime Instant20161113110000 { get; } = Instant.FromUtc(2016, 11, 13, 11, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20160914110000 { get; } = Instant.FromUtc(2016, 09, 14, 11, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20161115101600 { get; } = Instant.FromUtc(2016, 11, 15, 10, 16, 00).ToDateTimeUtc();
        public static DateTime Instant20161115101200 { get; } = Instant.FromUtc(2016, 11, 15, 10, 12, 00).ToDateTimeUtc();
        public static DateTime Instant20160801090000 { get; } = Instant.FromUtc(2016, 08, 01, 09, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20161115105706 { get; } = Instant.FromUtc(2016, 11, 15, 10, 57, 06).ToDateTimeUtc();
        public static DateTime Instant20161115105505 { get; } = Instant.FromUtc(2016, 11, 15, 10, 55, 05).ToDateTimeUtc();
        public static DateTime Instant20161115100500 { get; } = Instant.FromUtc(2016, 11, 15, 10, 05, 00).ToDateTimeUtc();
        public static DateTime Instant20161115105512 { get; } = Instant.FromUtc(2016, 11, 15, 10, 55, 12).ToDateTimeUtc();
        public static DateTime Instant20161115201115 { get; } = Instant.FromUtc(2016, 11, 15, 20, 11, 15).ToDateTimeUtc();
        public static DateTime Instant20161115111500 { get; } = Instant.FromUtc(2016, 11, 15, 11, 15, 00).ToDateTimeUtc();
        public static DateTime Instant20161115110500 { get; } = Instant.FromUtc(2016, 11, 15, 11, 05, 00).ToDateTimeUtc();
        public static DateTime Instant20161115102000 { get; } = Instant.FromUtc(2016, 11, 15, 10, 20, 00).ToDateTimeUtc();
        public static DateTime Instant20161115102100 { get; } = Instant.FromUtc(2016, 11, 15, 10, 21, 00).ToDateTimeUtc();
        public static DateTime Instant20160815093000 { get; } = Instant.FromUtc(2016, 08, 15, 09, 30, 00).ToDateTimeUtc();
        public static DateTime Instant20160816050000 { get; } = Instant.FromUtc(2016, 08, 16, 05, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20160928115959 { get; } = Instant.FromUtc(2016, 09, 28, 11, 59, 59).ToDateTimeUtc();
        public static DateTime Instant20161115105600 { get; } = Instant.FromUtc(2016, 11, 15, 10, 56, 00).ToDateTimeUtc();
        public static DateTime Instant20161101060000 { get; } = Instant.FromUtc(2016, 11, 01, 06, 00, 00).ToDateTimeUtc();
        public static DateTime Instant20161115101546 { get; } = Instant.FromUtc(2016, 11, 15, 10, 15, 46).ToDateTimeUtc();
        public static DateTime Instant20161115101720 { get; } = Instant.FromUtc(2016, 11, 15, 10, 17, 20).ToDateTimeUtc();


        public static Person Person778899 { get; } = new Person(new Uri("https://example.edu/users/778899"));
        public static Person Person554433 { get; } = new Person(new Uri("https://example.edu/users/554433"));
        public static Person Person112233 { get; } = new Person(new Uri("https://example.edu/users/112233"));
        public static Person Person554433dates { get; } = new Person(new Uri("https://example.edu/users/554433"))
        {
            DateCreated = Instant20160801060000,
            DateModified = Instant20160902113000
        };


        public static Membership EntityMembership554433Learner { get; }
            = new Membership(new Uri("https://example.edu/terms/201601/courses/7/sections/1/rosters/1"))
            {
                Member = new Person(new Uri("https://example.edu/users/554433")),
                Organization = new Organization(new Uri("https://example.edu/terms/201601/courses/7/sections/1")),
                Roles = new List<Role> { Role.Learner },
                Status = Status.Active,
                DateCreated = Instant20160801060000
            };

        public static Membership EntityMembership778899Learner { get; }
            = new Membership(new Uri("https://example.edu/terms/201601/courses/7/sections/1/rosters/1"))
            {
                Member = new Person(new Uri("https://example.edu/users/778899")),
                Organization = new Organization(new Uri("https://example.edu/terms/201601/courses/7/sections/1")),
                Roles = new List<Role> { Role.Learner },
                Status = Status.Active,
                DateCreated = Instant20160801060000
            };

        public static Membership EntityMembership112233Instructor { get; }
            = new Membership(new Uri("https://example.edu/terms/201601/courses/7/sections/1/rosters/1"))
            {
                Member = new Person(new Uri("https://example.edu/users/112233")),
                Organization = new Organization(new Uri("https://example.edu/terms/201601/courses/7/sections/1")),
                Roles = new List<Role> { Role.Instructor },
                Status = Status.Active,
                DateCreated = Instant20160801060000
            };

        public static CourseSection CourseSectionCPS43501Fall16 { get; }
            = new CourseSection(new Uri("https://example.edu/terms/201601/courses/7/sections/1"))
            {
                CourseNumber = "CPS 435-01",
                AcademicSession = "Fall 2016"
            };

        public static CourseSection CourseSectionCPS43501Fall16b { get; }
            = new CourseSection(new Uri("https://example.edu/terms/201601/courses/7/sections/1"))
            {
                Extensions = new
                {
                    edu_example_course_section_instructor = "https://example.edu/faculty/1234"
                }
            };

        public static Session Session6259 { get; }
            = new Session(new Uri("https://example.com/sessions/1f6442a482de72ea6ad134943812bff564a76259"))
            {
                StartedAtTime = Instant20161115100000
            };

        public static Session Session6259b { get; }
            = new Session(new Uri("https://example.edu/sessions/1f6442a482de72ea6ad134943812bff564a76259"))
            {
                StartedAtTime = Instant20161115100000,
                DateCreated = Instant20161115100000,
                User = Person554433
            };

        public static Session Session6259c { get; }
            = new Session(new Uri("https://example.edu/sessions/1f6442a482de72ea6ad134943812bff564a76259"))
            {
                StartedAtTime = Instant20161115201115,
                DateCreated = Instant20161115201115,
                User = Person554433
            };

        public static Session Session6259d { get; }
            = new Session(new Uri("https://example.edu/sessions/1f6442a482de72ea6ad134943812bff564a76259"))
            {
                StartedAtTime = Instant20161115100000,
                DateCreated = Instant20161115100000,
                EndedAtTime = Instant20161115110500,
                User = Person554433,
                Duration = TimeSpan.FromSeconds(3000)
            };


        public static Session Session6259edu { get; }
            = new Session(new Uri("https://example.edu/sessions/1f6442a482de72ea6ad134943812bff564a76259"))
            {
                StartedAtTime = Instant20161115100000
            };

        public static Session Session6259edu2 { get; }
            = new Session(new Uri("https://example.edu/sessions/f095bbd391ea4a5dd639724a40b606e98a631823"))
            {
                StartedAtTime = Instant20161112100000
            };

        public static Session SessionCd50 { get; }
            = new Session(new Uri("https://example.edu/sessions/1d6fa9adf16f4892650e4305f6cf16610905cd50"))
            {
                StartedAtTime = Instant20161115101200
            };

        public static Session Session1241 { get; }
            = new Session(new Uri("https://example.com/sessions/c25fd3da-87fa-45f5-8875-b682113fa5ee"))
            {
                StartedAtTime = Instant20161115102000,
                DateCreated = Instant20161115102000
            };


        public static SoftwareApplication EpubReader123 { get; }
            = new SoftwareApplication(new Uri("https://example.com/reader"))
            {
                Name = "ePub Reader",
                Version = "1.2.3"
            };

        public static SoftwareApplication SoftwareAppV2 { get; }
            = new SoftwareApplication(new Uri("https://example.edu"))
            {
                Version = "v2"
            };

        public static SoftwareApplication ForumAppV2 { get; }
            = new SoftwareApplication(new Uri("https://example.edu/forums"))
            {
                Version = "v2"
            };

        public static AssessmentItem AssessmentItem2 { get; }
            = new AssessmentItem(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/2"))
            {
                Name = "Assessment Item 2",
                IsPartOf = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1")),
                DateToStartOn = Instant20161114050000,
                DateToSubmit = Instant20161118115959,
                MaxAttempts = 2,
                MaxSubmits = 2,
                MaxScore = 1.0,
                IsTimeDependent = false,
                Version = "1.0"
            };

        public static AssessmentItem AssessmentItem3 { get; }
            = new AssessmentItem(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/3"))
            {
                Name = "Assessment Item 3",
                IsPartOf = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1"))
            };

        public static AssessmentItem AssessmentItem6 { get; }
            = new AssessmentItem(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/6"))
            {
                IsPartOf = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1")),
                DateCreated = Instant20160801060000,
                DatePublished = Instant20160815093000,
                IsTimeDependent = false,
                MaxAttempts = 2,
                MaxScore = 5.0,
                MaxSubmits = 2,
                Extensions = new { questionType = "Short Answer", questionText = "Define a Caliper Event and provide examples." }
            };

        public static AssessmentItem AssessmentItem3b { get; }
            = new AssessmentItem(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/3"))
            {
                Name = "Assessment Item 3",
                IsPartOf = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1")),
                DateToStartOn = Instant20161114050000,
                DateToSubmit = Instant20161118115959,
                MaxAttempts = 2,
                MaxSubmits = 2,
                MaxScore = 1.0,
                IsTimeDependent = false,
                Version = "1.0"
            };

        public static Assessment AssessmentQuizOne { get; }
            = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1"))
            {
                Name = "Quiz One",
                DateToStartOn = Instant20161114050000,
                DateToSubmit = Instant20161118115959,
                MaxAttempts = 2,
                MaxSubmits = 2,
                MaxScore = 25.0,
                Version = "1.0"
            };

        public static Assessment AssessmentQuizOneB { get; }
            = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1"))
            {
                Name = "Quiz One",
                DateCreated = Instant20160801060000,
                DateToStartOn = Instant20161114050000,
                DateToSubmit = Instant20161118115959,
                DateModified = Instant20160902113000,
                DatePublished = Instant20161112101000,
                DateToActivate = Instant20161112101500,
                MaxAttempts = 2,
                MaxSubmits = 2,
                MaxScore = 25.0,
                Version = "1.0"
            };

        public static Attempt Attempt1 { get; }
            = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/3/users/554433/attempts/1"))
            {
                Assignee = Person554433,
                Assignable = AssessmentItem3,
                IsPartOf = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1")),
                Count = 1,
                DateCreated = Instant20161115101502,
                StartedAtTime = Instant20161115101502,
                EndedAtTime = Instant20161115101512
            };

        public static Attempt Attempt2 { get; }
            = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1"))
            {
                Assignee = Person554433,
                Assignable = AssessmentQuizOne,
                Count = 1,
                DateCreated = Instant20161115101500,
                StartedAtTime = Instant20161115101500,
                EndedAtTime = Instant20161115102530,
                Duration = TimeSpan.FromMinutes(10) + TimeSpan.FromSeconds(30)
            };

        public static Attempt Attempt1b { get; }
            = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/3/users/554433/attempts/1"))
            {
                Assignee = Person554433,
                Assignable = AssessmentItem3,
                IsPartOf = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1")),
                Count = 1,
                DateCreated = Instant20161115101500,
                StartedAtTime = Instant20161115101500
            };

        public static Attempt Attempt1c { get; }
            = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1"))
            {
                Assignee = Person554433,
                Assignable = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1")),
                Count = 1,
                DateCreated = Instant20161115101500,
                StartedAtTime = Instant20161115101500
            };

        public static Attempt Attempt1d { get; }
            = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1"))
            {
                Assignee = Person554433,
                Assignable = new Assessment(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1")),
                Count = 1,
                DateCreated = Instant20161115100500,
                StartedAtTime = Instant20161115100500,
                EndedAtTime = Instant20161115105512,
                Duration = TimeSpan.FromMinutes(50) + TimeSpan.FromSeconds(12)
            };

        public static SoftwareApplication AutoGraderV2 { get; }
            = new SoftwareApplication(new Uri("https://example.edu/autograder"))
            {
                Version = "v2"
            };

        public static Result Result1 { get; }
            = new Result(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/results/1"))
            {
                Attempt = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1")),
                MaxResultScore = 15.0,
                ResultScore = 10.0,
                ScoredBy = AutoGraderV2,
                Comment = "Consider retaking the assessment.",
                DateCreated = Instant20161115105505
            };

        public static Score Score1 { get; }
            = new Score(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1/scores/1"))
            {
                Attempt = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1")),
                MaxScore = 15.0,
                ScoreGiven = 10.0,
                ScoredBy = AutoGraderV2,
                Comment = "auto-graded exam",
                DateCreated = Instant20161115105600
            };

        public static GradeEvent GradeEvent1 { get; }
            = new GradeEvent("urn:uuid:a50ca17f-5971-47bb-8fca-4e6e6879001d", Events.Action.Graded)
            {
                Actor = AutoGraderV2,
                Object = Attempt1d,
                Generated = Score1,
                EventTime = Instant20161115105706,
                EdApp = new SoftwareApplication(new Uri("https://example.edu")),
                Group = CourseSectionCPS43501Fall16
            };

        public static Forum Forum1Caliper { get; }
            = new Forum(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/1"))
            {
                Name = "Caliper Forum",
                IsPartOf = new CourseSection(new Uri("https://example.edu/terms/201601/courses/7/sections/1")),
                DateCreated = Instant20160914110000
            };

        public static VideoObject VideoObject1 { get; }
            = new VideoObject(new Uri("https://example.edu/UQVK-dsU7-Y"))
            {
                Name = "Information and Welcome",
                MediaType = "video/ogg",
                Duration = TimeSpan.FromMinutes(20) + TimeSpan.FromSeconds(20)
            };

        public static Message Message2 { get; }
            = new Message(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/2/topics/1/messages/2"))
            {
                Creators = new List<Agent> { Person554433 },
                Body = "Are the Caliper Sensor reference implementations production-ready?",
                IsPartOf = new Thread(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/2/topics/1"))
                {
                    Name = "Caliper Adoption",
                    IsPartOf = new Forum(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/2"))
                    {
                        Name = "Caliper Forum"
                    }
                },
                DateCreated = Instant20161115101500

            };

        public static Message Message3 { get; }
            = new Message(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/2/topics/1/messages/3"))
            {
                Creators = new List<Agent> { new Person(new Uri("https://example.edu/users/778899")) },
                ReplyTo = new Message(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/2/topics/1/messages/2")),
                IsPartOf = new Thread(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/2/topics/1"))
                {
                    IsPartOf = new Forum(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/2"))
                },
                DateCreated = Instant20161115101530
            };

        public static WebPage WebPage2 { get; }
            = new WebPage(new Uri("https://example.edu/terms/201601/courses/7/sections/1/pages/2"))
            {
                Name = "Learning Analytics Specifications",
                Description = "Overview of Learning Analytics Specifications with particular emphasis on IMS Caliper.",
                DateCreated = Instant20160801090000
            };

        public static Document Epub202 { get; }
            = new Document(new Uri("https://example.com/lti/reader/202.epub"))
            {
                Name = "Caliper Case Studies",
                MediaType = "application/epub+zip",
                DateCreated = Instant20160801090000
            };

        public static Document Epub201 { get; }
            = new Document(new Uri("https://example.edu/etexts/201.epub"))
            {
                Name = "IMS Caliper Implementation Guide",
                DateCreated = Instant20160801060000,
                DatePublished = Instant20161001060000,
                Version = "1.1"
            };

        public static Document Epub200 { get; }
            = new Document(new Uri("https://example.edu/etexts/200.epub"))
            {
                Name = "IMS Caliper Specification",
                Version = "1.1"
            };

        public static Result Result1b { get; }
            = new Result(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/3/users/554433/results/1"))
            {
                Attempt = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/3/users/554433/attempts/1")),
                ResultScore = 1.0,
                MaxResultScore = 1.0,
                ScoredBy = new SoftwareApplication(new Uri("https://example.edu/autograder")),
                DateCreated = Instant20161115105505
            };

        public static Score Score1b { get; }
            = new Score(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/items/3/users/554433/attempts/1/scores/1"))
            {
                Attempt = new Attempt(new Uri("https://example.edu/terms/201601/courses/7/sections/1/assess/1/users/554433/attempts/1")),
                MaxScore = 5.0,
                ScoreGiven = 5.0,
                ScoredBy = new SoftwareApplication(new Uri("https://example.edu/autograder")),
                Comment = "auto-graded exam",
                DateCreated = Instant20161115105505
            };

        public static Thread Thread1 { get; }
            = new Thread(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/1/topics/1"))
            {
                Name = "Caliper Information Model",
                IsPartOf = new Forum(new Uri("https://example.edu/terms/201601/courses/7/sections/1/forums/1"))
                {
                    Name = "Caliper Forum",
                    DateCreated = Instant20161115101500
                },
                DateCreated = Instant20161115101600
            };

        public static VideoObject VideoObject_1 { get; }
            = new VideoObject(new Uri("https://example.edu/videos/1225"))
            {
                MediaType = "video/ogg",
                Name = "Introduction to IMS Caliper",
                DateCreated = Instant20160801060000,
                Duration = TimeSpan.FromHours(1) + TimeSpan.FromMinutes(12) + TimeSpan.FromSeconds(27),
                Version = "1.1"
            };


        public static VideoObject VideoObject_2 { get; }
            = new VideoObject(new Uri("https://example.edu/videos/5629"))
            {
                MediaType = "video/ogg",
                Name = "IMS Caliper Activity Profiles",
                DateCreated = Instant20160801060000,
                Duration = TimeSpan.FromMinutes(55) + TimeSpan.FromSeconds(13),
                Version = "1.1.1"
            };

        public static DigitalResource DigitalResourceSyllabusPDF { get; }
            = new DigitalResource(new Uri("https://example.edu/terms/201601/courses/7/sections/1/resources/1/syllabus.pdf"))
            {
                Name = "Course Syllabus",
                MediaType = "application/pdf",
                Creators = new List<Agent> { new Person(new Uri("https://example.edu/users/223344")) },
                IsPartOf = new DigitalResourceCollection(new Uri("https://example.edu/terms/201601/courses/7/sections/1/resources/1"))
                {
                    Name = "Course Assets",
                    IsPartOf = new CourseSection(new Uri("https://example.edu/terms/201601/courses/7/sections/1"))
                },
                DateCreated = Instant.FromUtc(2016, 08, 02, 11, 32, 00).ToDateTimeUtc()
            };

        public class LtiParams
        {
            public string lti_message_type = "basic-lti-launch-request";

            public string lti_version = "LTI-2p0";

            public string context_id = "4f1a161f-59c3-43e5-be37-445ad09e3f76";

            public string context_type = "CourseSection";

            public string resource_link_id = "6b37a950-42c9-4117-8f4f-03e6e5c88d24";

            public string[] roles = new[] { "Learner" };

            public string user_id = "0ae836b9-7fc9-4060-006f-27b2066ac545";

            public object custom = new
            {
                caliper_profile_url = "https://example.edu/lti/tc/cps",
                caliper_session_id = "1c519ff7-3dfa-4764-be48-d2fb35a2925a",
                tool_consumer_instance_url = "https://example.edu"
            };

            public object ext = new
            {
                edu_example_course_section = "https://example.edu/terms/201601/courses/7/sections/1",
                edu_example_course_section_roster = "https://example.edu/terms/201601/courses/7/sections/1/rosters/1",
                edu_example_course_section_learner = "https://example.edu/users/554433",
                edu_example_course_section_instructor = "https://example.edu/faculty/1234"
            };
        };
    }
}

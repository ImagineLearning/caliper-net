using System;

namespace ImsGlobal.Caliper.Entities.Assignable
{
    public interface IAssignable
    {
        DateTime? DateToActivate { get; }

        DateTime? DateToShow { get; }

        DateTime? DateToStartOn { get; }

        DateTime? DateToSubmit { get; }

        uint? MaxAttempts { get; }

        uint? MaxSubmits { get; }

        double MaxScore { get; }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// Represents menstrual cycle phases.
    /// </summary>
    public enum MenstrualPhase
    {
        /// <summary>
        /// 
        /// </summary>
        Fertile,
        /// <summary>
        /// 
        /// </summary>
        FirstTrimester,
        /// <summary>
        /// 
        /// </summary>
        Follicular,
        /// <summary>
        /// 
        /// </summary>
        Luteal,
        /// <summary>
        /// 
        /// </summary>
        Menstrual,
        /// <summary>
        /// 
        /// </summary>
        Ovulation,
        /// <summary>
        /// 
        /// </summary>
        Pms,
        /// <summary>
        /// 
        /// </summary>
        SecondTrimester,
        /// <summary>
        /// 
        /// </summary>
        ThirdTrimester,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MenstrualPhaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MenstrualPhase value)
        {
            return value switch
            {
                MenstrualPhase.Fertile => "fertile",
                MenstrualPhase.FirstTrimester => "first_trimester",
                MenstrualPhase.Follicular => "follicular",
                MenstrualPhase.Luteal => "luteal",
                MenstrualPhase.Menstrual => "menstrual",
                MenstrualPhase.Ovulation => "ovulation",
                MenstrualPhase.Pms => "pms",
                MenstrualPhase.SecondTrimester => "second_trimester",
                MenstrualPhase.ThirdTrimester => "third_trimester",
                MenstrualPhase.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MenstrualPhase? ToEnum(string value)
        {
            return value switch
            {
                "fertile" => MenstrualPhase.Fertile,
                "first_trimester" => MenstrualPhase.FirstTrimester,
                "follicular" => MenstrualPhase.Follicular,
                "luteal" => MenstrualPhase.Luteal,
                "menstrual" => MenstrualPhase.Menstrual,
                "ovulation" => MenstrualPhase.Ovulation,
                "pms" => MenstrualPhase.Pms,
                "second_trimester" => MenstrualPhase.SecondTrimester,
                "third_trimester" => MenstrualPhase.ThirdTrimester,
                "unknown" => MenstrualPhase.Unknown,
                _ => null,
            };
        }
    }
}
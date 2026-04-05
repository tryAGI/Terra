
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum AthleteEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Athlete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AthleteEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AthleteEventType value)
        {
            return value switch
            {
                AthleteEventType.Athlete => "athlete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AthleteEventType? ToEnum(string value)
        {
            return value switch
            {
                "athlete" => AthleteEventType.Athlete,
                _ => null,
            };
        }
    }
}
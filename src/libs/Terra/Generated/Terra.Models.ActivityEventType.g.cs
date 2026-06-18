
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActivityEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Activity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityEventType value)
        {
            return value switch
            {
                ActivityEventType.Activity => "activity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityEventType? ToEnum(string value)
        {
            return value switch
            {
                "activity" => ActivityEventType.Activity,
                _ => null,
            };
        }
    }
}
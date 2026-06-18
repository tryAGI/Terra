
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SleepEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Sleep,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SleepEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SleepEventType value)
        {
            return value switch
            {
                SleepEventType.Sleep => "sleep",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SleepEventType? ToEnum(string value)
        {
            return value switch
            {
                "sleep" => SleepEventType.Sleep,
                _ => null,
            };
        }
    }
}
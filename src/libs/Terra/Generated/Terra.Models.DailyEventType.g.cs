
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum DailyEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Daily,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DailyEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DailyEventType value)
        {
            return value switch
            {
                DailyEventType.Daily => "daily",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DailyEventType? ToEnum(string value)
        {
            return value switch
            {
                "daily" => DailyEventType.Daily,
                _ => null,
            };
        }
    }
}
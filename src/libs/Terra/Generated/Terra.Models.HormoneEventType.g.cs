
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum HormoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Hormone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HormoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HormoneEventType value)
        {
            return value switch
            {
                HormoneEventType.Hormone => "hormone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HormoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "hormone" => HormoneEventType.Hormone,
                _ => null,
            };
        }
    }
}
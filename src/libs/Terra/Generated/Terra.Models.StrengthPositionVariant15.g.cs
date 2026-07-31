
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        Seated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant15 value)
        {
            return value switch
            {
                StrengthPositionVariant15.Seated => "seated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant15? ToEnum(string value)
        {
            return value switch
            {
                "seated" => StrengthPositionVariant15.Seated,
                _ => null,
            };
        }
    }
}
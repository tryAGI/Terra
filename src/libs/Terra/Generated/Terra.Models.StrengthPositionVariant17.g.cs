
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant17
    {
        /// <summary>
        ///
        /// </summary>
        Standing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant17 value)
        {
            return value switch
            {
                StrengthPositionVariant17.Standing => "standing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant17? ToEnum(string value)
        {
            return value switch
            {
                "standing" => StrengthPositionVariant17.Standing,
                _ => null,
            };
        }
    }
}
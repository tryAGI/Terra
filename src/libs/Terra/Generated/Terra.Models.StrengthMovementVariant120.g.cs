
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant120
    {
        /// <summary>
        ///
        /// </summary>
        RussianTwist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant120Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant120 value)
        {
            return value switch
            {
                StrengthMovementVariant120.RussianTwist => "russian_twist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant120? ToEnum(string value)
        {
            return value switch
            {
                "russian_twist" => StrengthMovementVariant120.RussianTwist,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant139
    {
        /// <summary>
        ///
        /// </summary>
        Squat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant139Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant139 value)
        {
            return value switch
            {
                StrengthMovementVariant139.Squat => "squat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant139? ToEnum(string value)
        {
            return value switch
            {
                "squat" => StrengthMovementVariant139.Squat,
                _ => null,
            };
        }
    }
}
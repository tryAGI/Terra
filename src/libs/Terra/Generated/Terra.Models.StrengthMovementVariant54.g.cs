
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant54
    {
        /// <summary>
        ///
        /// </summary>
        HeelSlide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant54Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant54 value)
        {
            return value switch
            {
                StrengthMovementVariant54.HeelSlide => "heel_slide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant54? ToEnum(string value)
        {
            return value switch
            {
                "heel_slide" => StrengthMovementVariant54.HeelSlide,
                _ => null,
            };
        }
    }
}
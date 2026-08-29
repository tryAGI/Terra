
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant158
    {
        /// <summary>
        ///
        /// </summary>
        ToeTap,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant158Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant158 value)
        {
            return value switch
            {
                StrengthMovementVariant158.ToeTap => "toe_tap",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant158? ToEnum(string value)
        {
            return value switch
            {
                "toe_tap" => StrengthMovementVariant158.ToeTap,
                _ => null,
            };
        }
    }
}
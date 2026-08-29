
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant14
    {
        /// <summary>
        ///
        /// </summary>
        BoxJump,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant14 value)
        {
            return value switch
            {
                StrengthMovementVariant14.BoxJump => "box_jump",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant14? ToEnum(string value)
        {
            return value switch
            {
                "box_jump" => StrengthMovementVariant14.BoxJump,
                _ => null,
            };
        }
    }
}
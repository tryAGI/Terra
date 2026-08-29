
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant78
    {
        /// <summary>
        ///
        /// </summary>
        KneelToStand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant78Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant78 value)
        {
            return value switch
            {
                StrengthMovementVariant78.KneelToStand => "kneel_to_stand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant78? ToEnum(string value)
        {
            return value switch
            {
                "kneel_to_stand" => StrengthMovementVariant78.KneelToStand,
                _ => null,
            };
        }
    }
}
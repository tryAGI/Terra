
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant98
    {
        /// <summary>
        ///
        /// </summary>
        ObliqueCrunch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant98Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant98 value)
        {
            return value switch
            {
                StrengthMovementVariant98.ObliqueCrunch => "oblique_crunch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant98? ToEnum(string value)
        {
            return value switch
            {
                "oblique_crunch" => StrengthMovementVariant98.ObliqueCrunch,
                _ => null,
            };
        }
    }
}
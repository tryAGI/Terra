
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant9
    {
        /// <summary>
        ///
        /// </summary>
        BicycleCrunch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant9 value)
        {
            return value switch
            {
                StrengthMovementVariant9.BicycleCrunch => "bicycle_crunch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant9? ToEnum(string value)
        {
            return value switch
            {
                "bicycle_crunch" => StrengthMovementVariant9.BicycleCrunch,
                _ => null,
            };
        }
    }
}
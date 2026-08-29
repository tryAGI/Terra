
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant86
    {
        /// <summary>
        ///
        /// </summary>
        LegExtension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant86Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant86 value)
        {
            return value switch
            {
                StrengthMovementVariant86.LegExtension => "leg_extension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant86? ToEnum(string value)
        {
            return value switch
            {
                "leg_extension" => StrengthMovementVariant86.LegExtension,
                _ => null,
            };
        }
    }
}
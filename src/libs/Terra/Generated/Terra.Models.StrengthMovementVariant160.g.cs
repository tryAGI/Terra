
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant160
    {
        /// <summary>
        ///
        /// </summary>
        TricepExtension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant160Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant160 value)
        {
            return value switch
            {
                StrengthMovementVariant160.TricepExtension => "tricep_extension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant160? ToEnum(string value)
        {
            return value switch
            {
                "tricep_extension" => StrengthMovementVariant160.TricepExtension,
                _ => null,
            };
        }
    }
}
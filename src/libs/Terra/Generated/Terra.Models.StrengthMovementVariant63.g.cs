
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant63
    {
        /// <summary>
        ///
        /// </summary>
        HipExtension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant63Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant63 value)
        {
            return value switch
            {
                StrengthMovementVariant63.HipExtension => "hip_extension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant63? ToEnum(string value)
        {
            return value switch
            {
                "hip_extension" => StrengthMovementVariant63.HipExtension,
                _ => null,
            };
        }
    }
}
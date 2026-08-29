
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant95
    {
        /// <summary>
        ///
        /// </summary>
        NeckExtension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant95Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant95 value)
        {
            return value switch
            {
                StrengthMovementVariant95.NeckExtension => "neck_extension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant95? ToEnum(string value)
        {
            return value switch
            {
                "neck_extension" => StrengthMovementVariant95.NeckExtension,
                _ => null,
            };
        }
    }
}
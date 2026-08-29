
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant114
    {
        /// <summary>
        ///
        /// </summary>
        ReverseHyperextension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant114Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant114 value)
        {
            return value switch
            {
                StrengthMovementVariant114.ReverseHyperextension => "reverse_hyperextension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant114? ToEnum(string value)
        {
            return value switch
            {
                "reverse_hyperextension" => StrengthMovementVariant114.ReverseHyperextension,
                _ => null,
            };
        }
    }
}
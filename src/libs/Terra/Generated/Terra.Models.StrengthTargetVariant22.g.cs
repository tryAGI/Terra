
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant22
    {
        /// <summary>
        ///
        /// </summary>
        ThoracicSpine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant22 value)
        {
            return value switch
            {
                StrengthTargetVariant22.ThoracicSpine => "thoracic_spine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant22? ToEnum(string value)
        {
            return value switch
            {
                "thoracic_spine" => StrengthTargetVariant22.ThoracicSpine,
                _ => null,
            };
        }
    }
}
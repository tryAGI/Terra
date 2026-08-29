
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant16
    {
        /// <summary>
        ///
        /// </summary>
        MiniBand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant16 value)
        {
            return value switch
            {
                StrengthImplementVariant16.MiniBand => "mini_band",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant16? ToEnum(string value)
        {
            return value switch
            {
                "mini_band" => StrengthImplementVariant16.MiniBand,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant6
    {
        /// <summary>
        ///
        /// </summary>
        Cable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant6 value)
        {
            return value switch
            {
                StrengthImplementVariant6.Cable => "cable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant6? ToEnum(string value)
        {
            return value switch
            {
                "cable" => StrengthImplementVariant6.Cable,
                _ => null,
            };
        }
    }
}
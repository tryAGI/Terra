
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        HandleBand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant9 value)
        {
            return value switch
            {
                StrengthImplementVariant9.HandleBand => "handle_band",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant9? ToEnum(string value)
        {
            return value switch
            {
                "handle_band" => StrengthImplementVariant9.HandleBand,
                _ => null,
            };
        }
    }
}
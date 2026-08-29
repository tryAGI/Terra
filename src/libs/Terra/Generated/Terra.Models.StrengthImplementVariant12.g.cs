
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant12
    {
        /// <summary>
        ///
        /// </summary>
        LoopBand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant12 value)
        {
            return value switch
            {
                StrengthImplementVariant12.LoopBand => "loop_band",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant12? ToEnum(string value)
        {
            return value switch
            {
                "loop_band" => StrengthImplementVariant12.LoopBand,
                _ => null,
            };
        }
    }
}
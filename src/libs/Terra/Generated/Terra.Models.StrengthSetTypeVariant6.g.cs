
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthSetTypeVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Warmup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSetTypeVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSetTypeVariant6 value)
        {
            return value switch
            {
                StrengthSetTypeVariant6.Warmup => "warmup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSetTypeVariant6? ToEnum(string value)
        {
            return value switch
            {
                "warmup" => StrengthSetTypeVariant6.Warmup,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthSetTypeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Warmup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSetTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSetTypeVariant3 value)
        {
            return value switch
            {
                StrengthSetTypeVariant3.Warmup => "warmup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSetTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "warmup" => StrengthSetTypeVariant3.Warmup,
                _ => null,
            };
        }
    }
}
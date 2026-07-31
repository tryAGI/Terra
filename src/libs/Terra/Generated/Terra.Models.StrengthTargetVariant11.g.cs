
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        Hip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant11 value)
        {
            return value switch
            {
                StrengthTargetVariant11.Hip => "hip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant11? ToEnum(string value)
        {
            return value switch
            {
                "hip" => StrengthTargetVariant11.Hip,
                _ => null,
            };
        }
    }
}
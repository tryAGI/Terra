
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        Hip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant10 value)
        {
            return value switch
            {
                StrengthTargetVariant10.Hip => "hip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant10? ToEnum(string value)
        {
            return value switch
            {
                "hip" => StrengthTargetVariant10.Hip,
                _ => null,
            };
        }
    }
}
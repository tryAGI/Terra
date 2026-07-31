
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthRangeOfMotionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        FromBlocks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthRangeOfMotionVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthRangeOfMotionVariant2 value)
        {
            return value switch
            {
                StrengthRangeOfMotionVariant2.FromBlocks => "from_blocks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthRangeOfMotionVariant2? ToEnum(string value)
        {
            return value switch
            {
                "from_blocks" => StrengthRangeOfMotionVariant2.FromBlocks,
                _ => null,
            };
        }
    }
}
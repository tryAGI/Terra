
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthBarPositionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        BehindNeck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthBarPositionVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthBarPositionVariant2 value)
        {
            return value switch
            {
                StrengthBarPositionVariant2.BehindNeck => "behind_neck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthBarPositionVariant2? ToEnum(string value)
        {
            return value switch
            {
                "behind_neck" => StrengthBarPositionVariant2.BehindNeck,
                _ => null,
            };
        }
    }
}
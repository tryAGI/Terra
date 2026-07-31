
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthRangeOfMotionVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        ToBench,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthRangeOfMotionVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthRangeOfMotionVariant6 value)
        {
            return value switch
            {
                StrengthRangeOfMotionVariant6.ToBench => "to_bench",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthRangeOfMotionVariant6? ToEnum(string value)
        {
            return value switch
            {
                "to_bench" => StrengthRangeOfMotionVariant6.ToBench,
                _ => null,
            };
        }
    }
}
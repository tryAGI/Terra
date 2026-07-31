
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthRangeOfMotionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Deficit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthRangeOfMotionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthRangeOfMotionVariant1 value)
        {
            return value switch
            {
                StrengthRangeOfMotionVariant1.Deficit => "deficit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthRangeOfMotionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "deficit" => StrengthRangeOfMotionVariant1.Deficit,
                _ => null,
            };
        }
    }
}
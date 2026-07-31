
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant15
    {
        /// <summary>
        /// 
        /// </summary>
        LowerBack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant15 value)
        {
            return value switch
            {
                StrengthTargetVariant15.LowerBack => "lower_back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant15? ToEnum(string value)
        {
            return value switch
            {
                "lower_back" => StrengthTargetVariant15.LowerBack,
                _ => null,
            };
        }
    }
}
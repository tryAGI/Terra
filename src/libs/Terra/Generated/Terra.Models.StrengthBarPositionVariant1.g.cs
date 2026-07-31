
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthBarPositionVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        BehindBack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthBarPositionVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthBarPositionVariant1 value)
        {
            return value switch
            {
                StrengthBarPositionVariant1.BehindBack => "behind_back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthBarPositionVariant1? ToEnum(string value)
        {
            return value switch
            {
                "behind_back" => StrengthBarPositionVariant1.BehindBack,
                _ => null,
            };
        }
    }
}
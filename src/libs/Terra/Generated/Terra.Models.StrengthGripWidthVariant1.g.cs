
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthGripWidthVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Close,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripWidthVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripWidthVariant1 value)
        {
            return value switch
            {
                StrengthGripWidthVariant1.Close => "close",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripWidthVariant1? ToEnum(string value)
        {
            return value switch
            {
                "close" => StrengthGripWidthVariant1.Close,
                _ => null,
            };
        }
    }
}
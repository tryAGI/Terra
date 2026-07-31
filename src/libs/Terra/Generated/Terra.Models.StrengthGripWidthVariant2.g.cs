
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthGripWidthVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Wide,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripWidthVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripWidthVariant2 value)
        {
            return value switch
            {
                StrengthGripWidthVariant2.Wide => "wide",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripWidthVariant2? ToEnum(string value)
        {
            return value switch
            {
                "wide" => StrengthGripWidthVariant2.Wide,
                _ => null,
            };
        }
    }
}
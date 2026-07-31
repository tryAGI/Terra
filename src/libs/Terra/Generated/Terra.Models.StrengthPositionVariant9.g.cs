
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        Inverted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant9 value)
        {
            return value switch
            {
                StrengthPositionVariant9.Inverted => "inverted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant9? ToEnum(string value)
        {
            return value switch
            {
                "inverted" => StrengthPositionVariant9.Inverted,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant12
    {
        /// <summary>
        /// 
        /// </summary>
        Pike,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant12 value)
        {
            return value switch
            {
                StrengthPositionVariant12.Pike => "pike",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant12? ToEnum(string value)
        {
            return value switch
            {
                "pike" => StrengthPositionVariant12.Pike,
                _ => null,
            };
        }
    }
}
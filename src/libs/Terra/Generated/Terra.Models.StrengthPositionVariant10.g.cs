
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        Kneeling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant10 value)
        {
            return value switch
            {
                StrengthPositionVariant10.Kneeling => "kneeling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant10? ToEnum(string value)
        {
            return value switch
            {
                "kneeling" => StrengthPositionVariant10.Kneeling,
                _ => null,
            };
        }
    }
}
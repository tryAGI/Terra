
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Decline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant2 value)
        {
            return value switch
            {
                StrengthPositionVariant2.Decline => "decline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant2? ToEnum(string value)
        {
            return value switch
            {
                "decline" => StrengthPositionVariant2.Decline,
                _ => null,
            };
        }
    }
}
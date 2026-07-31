
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant56
    {
        /// <summary>
        /// 
        /// </summary>
        HighKnee,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant56Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant56 value)
        {
            return value switch
            {
                StrengthMovementVariant56.HighKnee => "high_knee",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant56? ToEnum(string value)
        {
            return value switch
            {
                "high_knee" => StrengthMovementVariant56.HighKnee,
                _ => null,
            };
        }
    }
}
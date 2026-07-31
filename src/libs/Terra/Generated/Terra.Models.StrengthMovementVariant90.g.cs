
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant90
    {
        /// <summary>
        /// 
        /// </summary>
        Lunge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant90Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant90 value)
        {
            return value switch
            {
                StrengthMovementVariant90.Lunge => "lunge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant90? ToEnum(string value)
        {
            return value switch
            {
                "lunge" => StrengthMovementVariant90.Lunge,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant157
    {
        /// <summary>
        /// 
        /// </summary>
        TireFlip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant157Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant157 value)
        {
            return value switch
            {
                StrengthMovementVariant157.TireFlip => "tire_flip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant157? ToEnum(string value)
        {
            return value switch
            {
                "tire_flip" => StrengthMovementVariant157.TireFlip,
                _ => null,
            };
        }
    }
}
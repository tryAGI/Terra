
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant103
    {
        /// <summary>
        /// 
        /// </summary>
        PlateFlip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant103Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant103 value)
        {
            return value switch
            {
                StrengthMovementVariant103.PlateFlip => "plate_flip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant103? ToEnum(string value)
        {
            return value switch
            {
                "plate_flip" => StrengthMovementVariant103.PlateFlip,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant41
    {
        /// <summary>
        /// 
        /// </summary>
        FireHydrant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant41Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant41 value)
        {
            return value switch
            {
                StrengthMovementVariant41.FireHydrant => "fire_hydrant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant41? ToEnum(string value)
        {
            return value switch
            {
                "fire_hydrant" => StrengthMovementVariant41.FireHydrant,
                _ => null,
            };
        }
    }
}
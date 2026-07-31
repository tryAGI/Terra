
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant172
    {
        /// <summary>
        /// 
        /// </summary>
        WoodChop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant172Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant172 value)
        {
            return value switch
            {
                StrengthMovementVariant172.WoodChop => "wood_chop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant172? ToEnum(string value)
        {
            return value switch
            {
                "wood_chop" => StrengthMovementVariant172.WoodChop,
                _ => null,
            };
        }
    }
}
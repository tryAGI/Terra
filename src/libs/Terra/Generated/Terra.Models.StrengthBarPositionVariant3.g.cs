
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthBarPositionVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        FrontRack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthBarPositionVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthBarPositionVariant3 value)
        {
            return value switch
            {
                StrengthBarPositionVariant3.FrontRack => "front_rack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthBarPositionVariant3? ToEnum(string value)
        {
            return value switch
            {
                "front_rack" => StrengthBarPositionVariant3.FrontRack,
                _ => null,
            };
        }
    }
}
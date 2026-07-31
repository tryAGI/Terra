
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant166
    {
        /// <summary>
        /// 
        /// </summary>
        VUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant166Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant166 value)
        {
            return value switch
            {
                StrengthMovementVariant166.VUp => "v_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant166? ToEnum(string value)
        {
            return value switch
            {
                "v_up" => StrengthMovementVariant166.VUp,
                _ => null,
            };
        }
    }
}
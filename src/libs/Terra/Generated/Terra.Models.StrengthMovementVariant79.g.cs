
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant79
    {
        /// <summary>
        /// 
        /// </summary>
        LSit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant79Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant79 value)
        {
            return value switch
            {
                StrengthMovementVariant79.LSit => "l_sit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant79? ToEnum(string value)
        {
            return value switch
            {
                "l_sit" => StrengthMovementVariant79.LSit,
                _ => null,
            };
        }
    }
}
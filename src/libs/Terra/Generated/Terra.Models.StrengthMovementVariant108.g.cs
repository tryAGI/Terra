
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant108
    {
        /// <summary>
        /// 
        /// </summary>
        Pullover,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant108Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant108 value)
        {
            return value switch
            {
                StrengthMovementVariant108.Pullover => "pullover",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant108? ToEnum(string value)
        {
            return value switch
            {
                "pullover" => StrengthMovementVariant108.Pullover,
                _ => null,
            };
        }
    }
}
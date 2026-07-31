
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant127
    {
        /// <summary>
        /// 
        /// </summary>
        Shrug,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant127Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant127 value)
        {
            return value switch
            {
                StrengthMovementVariant127.Shrug => "shrug",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant127? ToEnum(string value)
        {
            return value switch
            {
                "shrug" => StrengthMovementVariant127.Shrug,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant91
    {
        /// <summary>
        /// 
        /// </summary>
        March,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant91Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant91 value)
        {
            return value switch
            {
                StrengthMovementVariant91.March => "march",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant91? ToEnum(string value)
        {
            return value switch
            {
                "march" => StrengthMovementVariant91.March,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant168
    {
        /// <summary>
        /// 
        /// </summary>
        Walk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant168Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant168 value)
        {
            return value switch
            {
                StrengthMovementVariant168.Walk => "walk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant168? ToEnum(string value)
        {
            return value switch
            {
                "walk" => StrengthMovementVariant168.Walk,
                _ => null,
            };
        }
    }
}
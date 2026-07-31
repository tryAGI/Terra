
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant150
    {
        /// <summary>
        /// 
        /// </summary>
        Swim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant150Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant150 value)
        {
            return value switch
            {
                StrengthMovementVariant150.Swim => "swim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant150? ToEnum(string value)
        {
            return value switch
            {
                "swim" => StrengthMovementVariant150.Swim,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant72
    {
        /// <summary>
        /// 
        /// </summary>
        Jerk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant72Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant72 value)
        {
            return value switch
            {
                StrengthMovementVariant72.Jerk => "jerk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant72? ToEnum(string value)
        {
            return value switch
            {
                "jerk" => StrengthMovementVariant72.Jerk,
                _ => null,
            };
        }
    }
}
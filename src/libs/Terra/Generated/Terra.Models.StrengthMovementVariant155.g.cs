
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant155
    {
        /// <summary>
        /// 
        /// </summary>
        Thruster,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant155Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant155 value)
        {
            return value switch
            {
                StrengthMovementVariant155.Thruster => "thruster",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant155? ToEnum(string value)
        {
            return value switch
            {
                "thruster" => StrengthMovementVariant155.Thruster,
                _ => null,
            };
        }
    }
}
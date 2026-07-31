
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant70
    {
        /// <summary>
        /// 
        /// </summary>
        IRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant70Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant70 value)
        {
            return value switch
            {
                StrengthMovementVariant70.IRaise => "i_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant70? ToEnum(string value)
        {
            return value switch
            {
                "i_raise" => StrengthMovementVariant70.IRaise,
                _ => null,
            };
        }
    }
}
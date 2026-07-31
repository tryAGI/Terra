
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant167
    {
        /// <summary>
        /// 
        /// </summary>
        WRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant167Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant167 value)
        {
            return value switch
            {
                StrengthMovementVariant167.WRaise => "w_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant167? ToEnum(string value)
        {
            return value switch
            {
                "w_raise" => StrengthMovementVariant167.WRaise,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant153
    {
        /// <summary>
        /// 
        /// </summary>
        TRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant153Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant153 value)
        {
            return value switch
            {
                StrengthMovementVariant153.TRaise => "t_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant153? ToEnum(string value)
        {
            return value switch
            {
                "t_raise" => StrengthMovementVariant153.TRaise,
                _ => null,
            };
        }
    }
}
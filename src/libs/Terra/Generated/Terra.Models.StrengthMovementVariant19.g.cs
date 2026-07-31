
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        CalfRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant19Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant19 value)
        {
            return value switch
            {
                StrengthMovementVariant19.CalfRaise => "calf_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant19? ToEnum(string value)
        {
            return value switch
            {
                "calf_raise" => StrengthMovementVariant19.CalfRaise,
                _ => null,
            };
        }
    }
}
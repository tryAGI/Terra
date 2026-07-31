
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant144
    {
        /// <summary>
        /// 
        /// </summary>
        StepUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant144Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant144 value)
        {
            return value switch
            {
                StrengthMovementVariant144.StepUp => "step_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant144? ToEnum(string value)
        {
            return value switch
            {
                "step_up" => StrengthMovementVariant144.StepUp,
                _ => null,
            };
        }
    }
}
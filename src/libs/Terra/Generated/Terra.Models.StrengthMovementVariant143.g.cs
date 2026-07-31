
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant143
    {
        /// <summary>
        /// 
        /// </summary>
        StepOver,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant143Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant143 value)
        {
            return value switch
            {
                StrengthMovementVariant143.StepOver => "step_over",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant143? ToEnum(string value)
        {
            return value switch
            {
                "step_over" => StrengthMovementVariant143.StepOver,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant142
    {
        /// <summary>
        ///
        /// </summary>
        StepDown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant142Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant142 value)
        {
            return value switch
            {
                StrengthMovementVariant142.StepDown => "step_down",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant142? ToEnum(string value)
        {
            return value switch
            {
                "step_down" => StrengthMovementVariant142.StepDown,
                _ => null,
            };
        }
    }
}
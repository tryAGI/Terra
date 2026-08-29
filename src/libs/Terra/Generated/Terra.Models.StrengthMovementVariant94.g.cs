
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant94
    {
        /// <summary>
        ///
        /// </summary>
        MuscleUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant94Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant94 value)
        {
            return value switch
            {
                StrengthMovementVariant94.MuscleUp => "muscle_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant94? ToEnum(string value)
        {
            return value switch
            {
                "muscle_up" => StrengthMovementVariant94.MuscleUp,
                _ => null,
            };
        }
    }
}
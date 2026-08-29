
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant93
    {
        /// <summary>
        ///
        /// </summary>
        MountainClimber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant93Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant93 value)
        {
            return value switch
            {
                StrengthMovementVariant93.MountainClimber => "mountain_climber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant93? ToEnum(string value)
        {
            return value switch
            {
                "mountain_climber" => StrengthMovementVariant93.MountainClimber,
                _ => null,
            };
        }
    }
}
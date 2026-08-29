
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant57
    {
        /// <summary>
        ///
        /// </summary>
        HighPull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant57Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant57 value)
        {
            return value switch
            {
                StrengthMovementVariant57.HighPull => "high_pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant57? ToEnum(string value)
        {
            return value switch
            {
                "high_pull" => StrengthMovementVariant57.HighPull,
                _ => null,
            };
        }
    }
}
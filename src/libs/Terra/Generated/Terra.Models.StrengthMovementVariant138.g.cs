
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant138
    {
        /// <summary>
        ///
        /// </summary>
        SnatchPull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant138Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant138 value)
        {
            return value switch
            {
                StrengthMovementVariant138.SnatchPull => "snatch_pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant138? ToEnum(string value)
        {
            return value switch
            {
                "snatch_pull" => StrengthMovementVariant138.SnatchPull,
                _ => null,
            };
        }
    }
}
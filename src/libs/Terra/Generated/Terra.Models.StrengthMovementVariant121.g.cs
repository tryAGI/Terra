
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant121
    {
        /// <summary>
        ///
        /// </summary>
        ScapularPullUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant121Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant121 value)
        {
            return value switch
            {
                StrengthMovementVariant121.ScapularPullUp => "scapular_pull_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant121? ToEnum(string value)
        {
            return value switch
            {
                "scapular_pull_up" => StrengthMovementVariant121.ScapularPullUp,
                _ => null,
            };
        }
    }
}
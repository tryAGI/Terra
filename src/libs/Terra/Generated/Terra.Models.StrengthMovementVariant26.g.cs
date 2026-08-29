
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant26
    {
        /// <summary>
        ///
        /// </summary>
        Clean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant26Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant26 value)
        {
            return value switch
            {
                StrengthMovementVariant26.Clean => "clean",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant26? ToEnum(string value)
        {
            return value switch
            {
                "clean" => StrengthMovementVariant26.Clean,
                _ => null,
            };
        }
    }
}
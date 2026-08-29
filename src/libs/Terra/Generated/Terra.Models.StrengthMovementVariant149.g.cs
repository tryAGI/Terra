
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant149
    {
        /// <summary>
        ///
        /// </summary>
        Superman,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant149Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant149 value)
        {
            return value switch
            {
                StrengthMovementVariant149.Superman => "superman",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant149? ToEnum(string value)
        {
            return value switch
            {
                "superman" => StrengthMovementVariant149.Superman,
                _ => null,
            };
        }
    }
}
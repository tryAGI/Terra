
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant102
    {
        /// <summary>
        ///
        /// </summary>
        Plank,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant102Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant102 value)
        {
            return value switch
            {
                StrengthMovementVariant102.Plank => "plank",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant102? ToEnum(string value)
        {
            return value switch
            {
                "plank" => StrengthMovementVariant102.Plank,
                _ => null,
            };
        }
    }
}
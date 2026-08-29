
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant136
    {
        /// <summary>
        ///
        /// </summary>
        Snatch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant136Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant136 value)
        {
            return value switch
            {
                StrengthMovementVariant136.Snatch => "snatch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant136? ToEnum(string value)
        {
            return value switch
            {
                "snatch" => StrengthMovementVariant136.Snatch,
                _ => null,
            };
        }
    }
}
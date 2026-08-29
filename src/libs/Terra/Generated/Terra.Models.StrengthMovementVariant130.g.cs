
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant130
    {
        /// <summary>
        ///
        /// </summary>
        SitUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant130Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant130 value)
        {
            return value switch
            {
                StrengthMovementVariant130.SitUp => "sit_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant130? ToEnum(string value)
        {
            return value switch
            {
                "sit_up" => StrengthMovementVariant130.SitUp,
                _ => null,
            };
        }
    }
}
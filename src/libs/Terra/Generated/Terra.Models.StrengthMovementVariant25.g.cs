
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant25
    {
        /// <summary>
        ///
        /// </summary>
        Clamshell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant25Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant25 value)
        {
            return value switch
            {
                StrengthMovementVariant25.Clamshell => "clamshell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant25? ToEnum(string value)
        {
            return value switch
            {
                "clamshell" => StrengthMovementVariant25.Clamshell,
                _ => null,
            };
        }
    }
}
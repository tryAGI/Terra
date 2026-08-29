
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant174
    {
        /// <summary>
        ///
        /// </summary>
        YRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant174Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant174 value)
        {
            return value switch
            {
                StrengthMovementVariant174.YRaise => "y_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant174? ToEnum(string value)
        {
            return value switch
            {
                "y_raise" => StrengthMovementVariant174.YRaise,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant117
    {
        /// <summary>
        ///
        /// </summary>
        Row,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant117Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant117 value)
        {
            return value switch
            {
                StrengthMovementVariant117.Row => "row",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant117? ToEnum(string value)
        {
            return value switch
            {
                "row" => StrengthMovementVariant117.Row,
                _ => null,
            };
        }
    }
}
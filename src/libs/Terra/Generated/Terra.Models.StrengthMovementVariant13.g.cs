
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant13
    {
        /// <summary>
        ///
        /// </summary>
        Bound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant13 value)
        {
            return value switch
            {
                StrengthMovementVariant13.Bound => "bound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant13? ToEnum(string value)
        {
            return value switch
            {
                "bound" => StrengthMovementVariant13.Bound,
                _ => null,
            };
        }
    }
}
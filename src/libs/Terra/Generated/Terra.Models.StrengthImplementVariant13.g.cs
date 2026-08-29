
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant13
    {
        /// <summary>
        ///
        /// </summary>
        Machine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant13 value)
        {
            return value switch
            {
                StrengthImplementVariant13.Machine => "machine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant13? ToEnum(string value)
        {
            return value switch
            {
                "machine" => StrengthImplementVariant13.Machine,
                _ => null,
            };
        }
    }
}
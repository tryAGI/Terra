
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant20
    {
        /// <summary>
        ///
        /// </summary>
        Sled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant20Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant20 value)
        {
            return value switch
            {
                StrengthImplementVariant20.Sled => "sled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant20? ToEnum(string value)
        {
            return value switch
            {
                "sled" => StrengthImplementVariant20.Sled,
                _ => null,
            };
        }
    }
}
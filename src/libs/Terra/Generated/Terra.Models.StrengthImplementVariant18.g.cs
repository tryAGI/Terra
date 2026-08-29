
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant18
    {
        /// <summary>
        ///
        /// </summary>
        Pvc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant18 value)
        {
            return value switch
            {
                StrengthImplementVariant18.Pvc => "pvc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant18? ToEnum(string value)
        {
            return value switch
            {
                "pvc" => StrengthImplementVariant18.Pvc,
                _ => null,
            };
        }
    }
}
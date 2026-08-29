
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Belt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant4 value)
        {
            return value switch
            {
                StrengthImplementVariant4.Belt => "belt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant4? ToEnum(string value)
        {
            return value switch
            {
                "belt" => StrengthImplementVariant4.Belt,
                _ => null,
            };
        }
    }
}
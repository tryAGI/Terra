
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant19
    {
        /// <summary>
        ///
        /// </summary>
        SafetyBar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant19Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant19 value)
        {
            return value switch
            {
                StrengthImplementVariant19.SafetyBar => "safety_bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant19? ToEnum(string value)
        {
            return value switch
            {
                "safety_bar" => StrengthImplementVariant19.SafetyBar,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant7
    {
        /// <summary>
        ///
        /// </summary>
        Dumbbell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant7 value)
        {
            return value switch
            {
                StrengthImplementVariant7.Dumbbell => "dumbbell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant7? ToEnum(string value)
        {
            return value switch
            {
                "dumbbell" => StrengthImplementVariant7.Dumbbell,
                _ => null,
            };
        }
    }
}
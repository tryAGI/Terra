
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant23
    {
        /// <summary>
        ///
        /// </summary>
        TrapBar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant23Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant23 value)
        {
            return value switch
            {
                StrengthImplementVariant23.TrapBar => "trap_bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant23? ToEnum(string value)
        {
            return value switch
            {
                "trap_bar" => StrengthImplementVariant23.TrapBar,
                _ => null,
            };
        }
    }
}
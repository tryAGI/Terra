
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant14
    {
        /// <summary>
        ///
        /// </summary>
        MachineAssisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant14 value)
        {
            return value switch
            {
                StrengthImplementVariant14.MachineAssisted => "machine_assisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant14? ToEnum(string value)
        {
            return value switch
            {
                "machine_assisted" => StrengthImplementVariant14.MachineAssisted,
                _ => null,
            };
        }
    }
}
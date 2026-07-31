
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
        SmithMachine,
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
                StrengthImplementVariant20.SmithMachine => "smith_machine",
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
                "smith_machine" => StrengthImplementVariant20.SmithMachine,
                _ => null,
            };
        }
    }
}
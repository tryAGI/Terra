
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant22
    {
        /// <summary>
        /// 
        /// </summary>
        Suspension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant22Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant22 value)
        {
            return value switch
            {
                StrengthImplementVariant22.Suspension => "suspension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant22? ToEnum(string value)
        {
            return value switch
            {
                "suspension" => StrengthImplementVariant22.Suspension,
                _ => null,
            };
        }
    }
}
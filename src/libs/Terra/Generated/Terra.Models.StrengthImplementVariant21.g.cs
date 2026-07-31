
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant21
    {
        /// <summary>
        /// 
        /// </summary>
        Suspension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant21Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant21 value)
        {
            return value switch
            {
                StrengthImplementVariant21.Suspension => "suspension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant21? ToEnum(string value)
        {
            return value switch
            {
                "suspension" => StrengthImplementVariant21.Suspension,
                _ => null,
            };
        }
    }
}
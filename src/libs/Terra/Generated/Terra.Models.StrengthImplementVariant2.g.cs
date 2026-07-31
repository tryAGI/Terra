
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Barbell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant2 value)
        {
            return value switch
            {
                StrengthImplementVariant2.Barbell => "barbell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant2? ToEnum(string value)
        {
            return value switch
            {
                "barbell" => StrengthImplementVariant2.Barbell,
                _ => null,
            };
        }
    }
}
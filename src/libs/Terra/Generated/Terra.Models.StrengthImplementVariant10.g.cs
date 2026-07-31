
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant10
    {
        /// <summary>
        /// 
        /// </summary>
        Kettlebell,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant10 value)
        {
            return value switch
            {
                StrengthImplementVariant10.Kettlebell => "kettlebell",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant10? ToEnum(string value)
        {
            return value switch
            {
                "kettlebell" => StrengthImplementVariant10.Kettlebell,
                _ => null,
            };
        }
    }
}
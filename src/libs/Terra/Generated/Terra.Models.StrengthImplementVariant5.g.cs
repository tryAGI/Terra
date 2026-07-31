
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Bodyweight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant5 value)
        {
            return value switch
            {
                StrengthImplementVariant5.Bodyweight => "bodyweight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant5? ToEnum(string value)
        {
            return value switch
            {
                "bodyweight" => StrengthImplementVariant5.Bodyweight,
                _ => null,
            };
        }
    }
}
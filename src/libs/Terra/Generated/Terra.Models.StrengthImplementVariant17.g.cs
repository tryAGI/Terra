
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        Partner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant17 value)
        {
            return value switch
            {
                StrengthImplementVariant17.Partner => "partner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant17? ToEnum(string value)
        {
            return value switch
            {
                "partner" => StrengthImplementVariant17.Partner,
                _ => null,
            };
        }
    }
}
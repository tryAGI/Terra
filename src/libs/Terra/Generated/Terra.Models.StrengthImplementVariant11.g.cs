
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthImplementVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        Landmine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant11 value)
        {
            return value switch
            {
                StrengthImplementVariant11.Landmine => "landmine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant11? ToEnum(string value)
        {
            return value switch
            {
                "landmine" => StrengthImplementVariant11.Landmine,
                _ => null,
            };
        }
    }
}
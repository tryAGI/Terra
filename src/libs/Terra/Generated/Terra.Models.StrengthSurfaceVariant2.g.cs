
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthSurfaceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Bosu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant2 value)
        {
            return value switch
            {
                StrengthSurfaceVariant2.Bosu => "bosu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant2? ToEnum(string value)
        {
            return value switch
            {
                "bosu" => StrengthSurfaceVariant2.Bosu,
                _ => null,
            };
        }
    }
}
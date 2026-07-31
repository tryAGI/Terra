
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant131
    {
        /// <summary>
        /// 
        /// </summary>
        SkiErg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant131Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant131 value)
        {
            return value switch
            {
                StrengthMovementVariant131.SkiErg => "ski_erg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant131? ToEnum(string value)
        {
            return value switch
            {
                "ski_erg" => StrengthMovementVariant131.SkiErg,
                _ => null,
            };
        }
    }
}
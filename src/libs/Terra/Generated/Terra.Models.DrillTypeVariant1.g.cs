
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum DrillTypeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Kick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DrillTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DrillTypeVariant1 value)
        {
            return value switch
            {
                DrillTypeVariant1.Kick => "kick",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DrillTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "kick" => DrillTypeVariant1.Kick,
                _ => null,
            };
        }
    }
}
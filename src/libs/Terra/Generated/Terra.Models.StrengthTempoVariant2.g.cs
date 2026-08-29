
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTempoVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Explosive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTempoVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTempoVariant2 value)
        {
            return value switch
            {
                StrengthTempoVariant2.Explosive => "explosive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTempoVariant2? ToEnum(string value)
        {
            return value switch
            {
                "explosive" => StrengthTempoVariant2.Explosive,
                _ => null,
            };
        }
    }
}
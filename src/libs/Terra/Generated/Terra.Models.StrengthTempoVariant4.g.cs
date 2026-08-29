
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTempoVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Kipping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTempoVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTempoVariant4 value)
        {
            return value switch
            {
                StrengthTempoVariant4.Kipping => "kipping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTempoVariant4? ToEnum(string value)
        {
            return value switch
            {
                "kipping" => StrengthTempoVariant4.Kipping,
                _ => null,
            };
        }
    }
}
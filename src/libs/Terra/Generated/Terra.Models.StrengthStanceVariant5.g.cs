
#nullable enable

namespace Terra
{
    /// <summary>
    /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
    /// </summary>
    public enum StrengthStanceVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthStanceVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthStanceVariant5 value)
        {
            return value switch
            {
                StrengthStanceVariant5.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthStanceVariant5? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => StrengthStanceVariant5.Unknown,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
    /// </summary>
    public enum StrengthTargetVariant24
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant24Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant24 value)
        {
            return value switch
            {
                StrengthTargetVariant24.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant24? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => StrengthTargetVariant24.Unknown,
                _ => null,
            };
        }
    }
}
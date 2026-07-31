
#nullable enable

namespace Terra
{
    /// <summary>
    /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
    /// </summary>
    public enum StrengthLateralityVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLateralityVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLateralityVariant4 value)
        {
            return value switch
            {
                StrengthLateralityVariant4.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLateralityVariant4? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => StrengthLateralityVariant4.Unknown,
                _ => null,
            };
        }
    }
}
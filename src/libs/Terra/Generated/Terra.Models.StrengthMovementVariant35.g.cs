
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant35
    {
        /// <summary>
        /// 
        /// </summary>
        DiaphragmaticBreathing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant35Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant35 value)
        {
            return value switch
            {
                StrengthMovementVariant35.DiaphragmaticBreathing => "diaphragmatic_breathing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant35? ToEnum(string value)
        {
            return value switch
            {
                "diaphragmatic_breathing" => StrengthMovementVariant35.DiaphragmaticBreathing,
                _ => null,
            };
        }
    }
}
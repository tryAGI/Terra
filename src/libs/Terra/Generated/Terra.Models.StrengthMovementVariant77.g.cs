
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant77
    {
        /// <summary>
        /// 
        /// </summary>
        KneeRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant77Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant77 value)
        {
            return value switch
            {
                StrengthMovementVariant77.KneeRaise => "knee_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant77? ToEnum(string value)
        {
            return value switch
            {
                "knee_raise" => StrengthMovementVariant77.KneeRaise,
                _ => null,
            };
        }
    }
}
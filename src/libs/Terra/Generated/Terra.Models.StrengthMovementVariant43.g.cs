
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant43
    {
        /// <summary>
        /// 
        /// </summary>
        FoamRoll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant43Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant43 value)
        {
            return value switch
            {
                StrengthMovementVariant43.FoamRoll => "foam_roll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant43? ToEnum(string value)
        {
            return value switch
            {
                "foam_roll" => StrengthMovementVariant43.FoamRoll,
                _ => null,
            };
        }
    }
}
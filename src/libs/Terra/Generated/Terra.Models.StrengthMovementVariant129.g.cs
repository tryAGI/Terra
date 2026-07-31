
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant129
    {
        /// <summary>
        /// 
        /// </summary>
        SissySquat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant129Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant129 value)
        {
            return value switch
            {
                StrengthMovementVariant129.SissySquat => "sissy_squat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant129? ToEnum(string value)
        {
            return value switch
            {
                "sissy_squat" => StrengthMovementVariant129.SissySquat,
                _ => null,
            };
        }
    }
}
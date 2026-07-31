
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant30
    {
        /// <summary>
        /// 
        /// </summary>
        CossackSquat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant30Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant30 value)
        {
            return value switch
            {
                StrengthMovementVariant30.CossackSquat => "cossack_squat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant30? ToEnum(string value)
        {
            return value switch
            {
                "cossack_squat" => StrengthMovementVariant30.CossackSquat,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        AbRollout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant1 value)
        {
            return value switch
            {
                StrengthMovementVariant1.AbRollout => "ab_rollout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant1? ToEnum(string value)
        {
            return value switch
            {
                "ab_rollout" => StrengthMovementVariant1.AbRollout,
                _ => null,
            };
        }
    }
}
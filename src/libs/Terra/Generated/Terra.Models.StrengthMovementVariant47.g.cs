
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant47
    {
        /// <summary>
        /// 
        /// </summary>
        GluteHamRaise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant47Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant47 value)
        {
            return value switch
            {
                StrengthMovementVariant47.GluteHamRaise => "glute_ham_raise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant47? ToEnum(string value)
        {
            return value switch
            {
                "glute_ham_raise" => StrengthMovementVariant47.GluteHamRaise,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthLateralityVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Unilateral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLateralityVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLateralityVariant3 value)
        {
            return value switch
            {
                StrengthLateralityVariant3.Unilateral => "unilateral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLateralityVariant3? ToEnum(string value)
        {
            return value switch
            {
                "unilateral" => StrengthLateralityVariant3.Unilateral,
                _ => null,
            };
        }
    }
}
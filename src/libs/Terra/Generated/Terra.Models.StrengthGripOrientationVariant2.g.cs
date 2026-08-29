
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthGripOrientationVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Mixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripOrientationVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripOrientationVariant2 value)
        {
            return value switch
            {
                StrengthGripOrientationVariant2.Mixed => "mixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripOrientationVariant2? ToEnum(string value)
        {
            return value switch
            {
                "mixed" => StrengthGripOrientationVariant2.Mixed,
                _ => null,
            };
        }
    }
}
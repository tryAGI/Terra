
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Ankle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant3 value)
        {
            return value switch
            {
                StrengthTargetVariant3.Ankle => "ankle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant3? ToEnum(string value)
        {
            return value switch
            {
                "ankle" => StrengthTargetVariant3.Ankle,
                _ => null,
            };
        }
    }
}
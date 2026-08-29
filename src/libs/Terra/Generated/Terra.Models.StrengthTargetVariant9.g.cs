
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant9
    {
        /// <summary>
        ///
        /// </summary>
        Glutes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant9 value)
        {
            return value switch
            {
                StrengthTargetVariant9.Glutes => "glutes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant9? ToEnum(string value)
        {
            return value switch
            {
                "glutes" => StrengthTargetVariant9.Glutes,
                _ => null,
            };
        }
    }
}
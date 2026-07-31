
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant17
    {
        /// <summary>
        /// 
        /// </summary>
        Obliques,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant17Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant17 value)
        {
            return value switch
            {
                StrengthTargetVariant17.Obliques => "obliques",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant17? ToEnum(string value)
        {
            return value switch
            {
                "obliques" => StrengthTargetVariant17.Obliques,
                _ => null,
            };
        }
    }
}
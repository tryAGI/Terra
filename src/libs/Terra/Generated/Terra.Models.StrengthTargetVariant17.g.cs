
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
        Neck,
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
                StrengthTargetVariant17.Neck => "neck",
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
                "neck" => StrengthTargetVariant17.Neck,
                _ => null,
            };
        }
    }
}
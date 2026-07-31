
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        Neck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant16 value)
        {
            return value switch
            {
                StrengthTargetVariant16.Neck => "neck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant16? ToEnum(string value)
        {
            return value switch
            {
                "neck" => StrengthTargetVariant16.Neck,
                _ => null,
            };
        }
    }
}
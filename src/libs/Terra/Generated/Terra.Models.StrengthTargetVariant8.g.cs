
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        Glutes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant8 value)
        {
            return value switch
            {
                StrengthTargetVariant8.Glutes => "glutes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant8? ToEnum(string value)
        {
            return value switch
            {
                "glutes" => StrengthTargetVariant8.Glutes,
                _ => null,
            };
        }
    }
}
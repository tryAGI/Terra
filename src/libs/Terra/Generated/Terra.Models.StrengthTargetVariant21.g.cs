
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant21
    {
        /// <summary>
        /// 
        /// </summary>
        ThoracicSpine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant21Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant21 value)
        {
            return value switch
            {
                StrengthTargetVariant21.ThoracicSpine => "thoracic_spine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant21? ToEnum(string value)
        {
            return value switch
            {
                "thoracic_spine" => StrengthTargetVariant21.ThoracicSpine,
                _ => null,
            };
        }
    }
}
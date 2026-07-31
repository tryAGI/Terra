
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant23
    {
        /// <summary>
        /// 
        /// </summary>
        UpperBack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant23Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant23 value)
        {
            return value switch
            {
                StrengthTargetVariant23.UpperBack => "upper_back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant23? ToEnum(string value)
        {
            return value switch
            {
                "upper_back" => StrengthTargetVariant23.UpperBack,
                _ => null,
            };
        }
    }
}
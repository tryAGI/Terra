
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant19
    {
        /// <summary>
        /// 
        /// </summary>
        Shoulders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant19Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant19 value)
        {
            return value switch
            {
                StrengthTargetVariant19.Shoulders => "shoulders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant19? ToEnum(string value)
        {
            return value switch
            {
                "shoulders" => StrengthTargetVariant19.Shoulders,
                _ => null,
            };
        }
    }
}
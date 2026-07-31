
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        Neck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant13 value)
        {
            return value switch
            {
                StrengthMuscleVariant13.Neck => "neck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant13? ToEnum(string value)
        {
            return value switch
            {
                "neck" => StrengthMuscleVariant13.Neck,
                _ => null,
            };
        }
    }
}
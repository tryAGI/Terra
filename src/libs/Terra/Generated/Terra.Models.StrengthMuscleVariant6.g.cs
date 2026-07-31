
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Calves,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant6 value)
        {
            return value switch
            {
                StrengthMuscleVariant6.Calves => "calves",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant6? ToEnum(string value)
        {
            return value switch
            {
                "calves" => StrengthMuscleVariant6.Calves,
                _ => null,
            };
        }
    }
}
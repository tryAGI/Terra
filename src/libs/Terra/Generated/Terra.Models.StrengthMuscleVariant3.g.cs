
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Adductors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant3 value)
        {
            return value switch
            {
                StrengthMuscleVariant3.Adductors => "adductors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant3? ToEnum(string value)
        {
            return value switch
            {
                "adductors" => StrengthMuscleVariant3.Adductors,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Chest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant7 value)
        {
            return value switch
            {
                StrengthMuscleVariant7.Chest => "chest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant7? ToEnum(string value)
        {
            return value switch
            {
                "chest" => StrengthMuscleVariant7.Chest,
                _ => null,
            };
        }
    }
}
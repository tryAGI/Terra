
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMuscleVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        Obliques,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant14 value)
        {
            return value switch
            {
                StrengthMuscleVariant14.Obliques => "obliques",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant14? ToEnum(string value)
        {
            return value switch
            {
                "obliques" => StrengthMuscleVariant14.Obliques,
                _ => null,
            };
        }
    }
}
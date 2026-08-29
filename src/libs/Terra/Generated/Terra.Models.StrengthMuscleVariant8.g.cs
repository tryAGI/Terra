
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMuscleVariant8
    {
        /// <summary>
        ///
        /// </summary>
        Forearms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant8 value)
        {
            return value switch
            {
                StrengthMuscleVariant8.Forearms => "forearms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant8? ToEnum(string value)
        {
            return value switch
            {
                "forearms" => StrengthMuscleVariant8.Forearms,
                _ => null,
            };
        }
    }
}
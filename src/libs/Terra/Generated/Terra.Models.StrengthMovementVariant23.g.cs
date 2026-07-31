
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant23
    {
        /// <summary>
        /// 
        /// </summary>
        ChestPress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant23Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant23 value)
        {
            return value switch
            {
                StrengthMovementVariant23.ChestPress => "chest_press",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant23? ToEnum(string value)
        {
            return value switch
            {
                "chest_press" => StrengthMovementVariant23.ChestPress,
                _ => null,
            };
        }
    }
}
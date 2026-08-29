
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant99
    {
        /// <summary>
        ///
        /// </summary>
        OverheadPress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant99Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant99 value)
        {
            return value switch
            {
                StrengthMovementVariant99.OverheadPress => "overhead_press",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant99? ToEnum(string value)
        {
            return value switch
            {
                "overhead_press" => StrengthMovementVariant99.OverheadPress,
                _ => null,
            };
        }
    }
}
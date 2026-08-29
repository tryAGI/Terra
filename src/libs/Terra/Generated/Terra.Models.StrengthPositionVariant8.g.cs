
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant8
    {
        /// <summary>
        ///
        /// </summary>
        Incline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant8 value)
        {
            return value switch
            {
                StrengthPositionVariant8.Incline => "incline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant8? ToEnum(string value)
        {
            return value switch
            {
                "incline" => StrengthPositionVariant8.Incline,
                _ => null,
            };
        }
    }
}
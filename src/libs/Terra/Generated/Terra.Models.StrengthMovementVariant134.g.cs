
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant134
    {
        /// <summary>
        ///
        /// </summary>
        SledDrag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant134Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant134 value)
        {
            return value switch
            {
                StrengthMovementVariant134.SledDrag => "sled_drag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant134? ToEnum(string value)
        {
            return value switch
            {
                "sled_drag" => StrengthMovementVariant134.SledDrag,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant110
    {
        /// <summary>
        /// 
        /// </summary>
        PushPress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant110Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant110 value)
        {
            return value switch
            {
                StrengthMovementVariant110.PushPress => "push_press",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant110? ToEnum(string value)
        {
            return value switch
            {
                "push_press" => StrengthMovementVariant110.PushPress,
                _ => null,
            };
        }
    }
}
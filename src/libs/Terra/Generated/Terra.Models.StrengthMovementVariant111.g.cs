
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant111
    {
        /// <summary>
        /// 
        /// </summary>
        PushUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant111Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant111 value)
        {
            return value switch
            {
                StrengthMovementVariant111.PushUp => "push_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant111? ToEnum(string value)
        {
            return value switch
            {
                "push_up" => StrengthMovementVariant111.PushUp,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant55
    {
        /// <summary>
        /// 
        /// </summary>
        HeelTouch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant55Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant55 value)
        {
            return value switch
            {
                StrengthMovementVariant55.HeelTouch => "heel_touch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant55? ToEnum(string value)
        {
            return value switch
            {
                "heel_touch" => StrengthMovementVariant55.HeelTouch,
                _ => null,
            };
        }
    }
}
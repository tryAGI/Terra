
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Hanging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant7 value)
        {
            return value switch
            {
                StrengthPositionVariant7.Hanging => "hanging",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant7? ToEnum(string value)
        {
            return value switch
            {
                "hanging" => StrengthPositionVariant7.Hanging,
                _ => null,
            };
        }
    }
}
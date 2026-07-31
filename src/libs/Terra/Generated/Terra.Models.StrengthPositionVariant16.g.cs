
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant16
    {
        /// <summary>
        /// 
        /// </summary>
        SideLying,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant16 value)
        {
            return value switch
            {
                StrengthPositionVariant16.SideLying => "side_lying",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant16? ToEnum(string value)
        {
            return value switch
            {
                "side_lying" => StrengthPositionVariant16.SideLying,
                _ => null,
            };
        }
    }
}
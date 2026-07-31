
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthPositionVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        Quadruped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant14 value)
        {
            return value switch
            {
                StrengthPositionVariant14.Quadruped => "quadruped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant14? ToEnum(string value)
        {
            return value switch
            {
                "quadruped" => StrengthPositionVariant14.Quadruped,
                _ => null,
            };
        }
    }
}
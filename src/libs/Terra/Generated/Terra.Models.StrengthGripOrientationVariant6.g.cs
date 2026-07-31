
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthGripOrientationVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        Reverse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripOrientationVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripOrientationVariant6 value)
        {
            return value switch
            {
                StrengthGripOrientationVariant6.Reverse => "reverse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripOrientationVariant6? ToEnum(string value)
        {
            return value switch
            {
                "reverse" => StrengthGripOrientationVariant6.Reverse,
                _ => null,
            };
        }
    }
}
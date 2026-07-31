
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthRangeOfMotionVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Full,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthRangeOfMotionVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthRangeOfMotionVariant4 value)
        {
            return value switch
            {
                StrengthRangeOfMotionVariant4.Full => "full",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthRangeOfMotionVariant4? ToEnum(string value)
        {
            return value switch
            {
                "full" => StrengthRangeOfMotionVariant4.Full,
                _ => null,
            };
        }
    }
}
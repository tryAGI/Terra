
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthBarPositionVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Overhead,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthBarPositionVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthBarPositionVariant5 value)
        {
            return value switch
            {
                StrengthBarPositionVariant5.Overhead => "overhead",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthBarPositionVariant5? ToEnum(string value)
        {
            return value switch
            {
                "overhead" => StrengthBarPositionVariant5.Overhead,
                _ => null,
            };
        }
    }
}
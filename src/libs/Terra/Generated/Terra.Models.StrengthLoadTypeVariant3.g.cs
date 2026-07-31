
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthLoadTypeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        BodyweightPlus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLoadTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLoadTypeVariant3 value)
        {
            return value switch
            {
                StrengthLoadTypeVariant3.BodyweightPlus => "bodyweight_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLoadTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "bodyweight_plus" => StrengthLoadTypeVariant3.BodyweightPlus,
                _ => null,
            };
        }
    }
}
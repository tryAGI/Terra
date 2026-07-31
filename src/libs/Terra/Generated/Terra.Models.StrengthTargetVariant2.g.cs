
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Adductors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant2 value)
        {
            return value switch
            {
                StrengthTargetVariant2.Adductors => "adductors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant2? ToEnum(string value)
        {
            return value switch
            {
                "adductors" => StrengthTargetVariant2.Adductors,
                _ => null,
            };
        }
    }
}
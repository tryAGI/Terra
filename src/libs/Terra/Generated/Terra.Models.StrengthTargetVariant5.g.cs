
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        Calves,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant5 value)
        {
            return value switch
            {
                StrengthTargetVariant5.Calves => "calves",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant5? ToEnum(string value)
        {
            return value switch
            {
                "calves" => StrengthTargetVariant5.Calves,
                _ => null,
            };
        }
    }
}
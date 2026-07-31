
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant18
    {
        /// <summary>
        /// 
        /// </summary>
        Quadriceps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant18 value)
        {
            return value switch
            {
                StrengthTargetVariant18.Quadriceps => "quadriceps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant18? ToEnum(string value)
        {
            return value switch
            {
                "quadriceps" => StrengthTargetVariant18.Quadriceps,
                _ => null,
            };
        }
    }
}
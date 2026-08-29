
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant6
    {
        /// <summary>
        ///
        /// </summary>
        Calves,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant6 value)
        {
            return value switch
            {
                StrengthTargetVariant6.Calves => "calves",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant6? ToEnum(string value)
        {
            return value switch
            {
                "calves" => StrengthTargetVariant6.Calves,
                _ => null,
            };
        }
    }
}
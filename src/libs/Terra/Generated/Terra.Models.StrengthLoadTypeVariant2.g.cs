
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthLoadTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Bodyweight,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLoadTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLoadTypeVariant2 value)
        {
            return value switch
            {
                StrengthLoadTypeVariant2.Bodyweight => "bodyweight",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLoadTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "bodyweight" => StrengthLoadTypeVariant2.Bodyweight,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant18
    {
        /// <summary>
        ///
        /// </summary>
        Supine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant18 value)
        {
            return value switch
            {
                StrengthPositionVariant18.Supine => "supine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant18? ToEnum(string value)
        {
            return value switch
            {
                "supine" => StrengthPositionVariant18.Supine,
                _ => null,
            };
        }
    }
}
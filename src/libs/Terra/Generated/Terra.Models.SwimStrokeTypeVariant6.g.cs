
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum SwimStrokeTypeVariant6
    {
        /// <summary>
        ///
        /// </summary>
        Mixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimStrokeTypeVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokeTypeVariant6 value)
        {
            return value switch
            {
                SwimStrokeTypeVariant6.Mixed => "mixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokeTypeVariant6? ToEnum(string value)
        {
            return value switch
            {
                "mixed" => SwimStrokeTypeVariant6.Mixed,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum SwimStrokeTypeVariant5
    {
        /// <summary>
        ///
        /// </summary>
        Freestyle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimStrokeTypeVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokeTypeVariant5 value)
        {
            return value switch
            {
                SwimStrokeTypeVariant5.Freestyle => "freestyle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokeTypeVariant5? ToEnum(string value)
        {
            return value switch
            {
                "freestyle" => SwimStrokeTypeVariant5.Freestyle,
                _ => null,
            };
        }
    }
}
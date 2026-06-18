
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SwimStrokeTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Breaststroke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimStrokeTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokeTypeVariant2 value)
        {
            return value switch
            {
                SwimStrokeTypeVariant2.Breaststroke => "breaststroke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokeTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "breaststroke" => SwimStrokeTypeVariant2.Breaststroke,
                _ => null,
            };
        }
    }
}
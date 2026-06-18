
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SwimStrokeTypeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Drill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimStrokeTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokeTypeVariant3 value)
        {
            return value switch
            {
                SwimStrokeTypeVariant3.Drill => "drill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokeTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "drill" => SwimStrokeTypeVariant3.Drill,
                _ => null,
            };
        }
    }
}
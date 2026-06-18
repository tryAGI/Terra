
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SwimStrokeTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Backstroke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimStrokeTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokeTypeVariant1 value)
        {
            return value switch
            {
                SwimStrokeTypeVariant1.Backstroke => "backstroke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokeTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "backstroke" => SwimStrokeTypeVariant1.Backstroke,
                _ => null,
            };
        }
    }
}
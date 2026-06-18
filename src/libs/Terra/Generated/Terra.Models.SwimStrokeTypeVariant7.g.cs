
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SwimStrokeTypeVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        Im,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimStrokeTypeVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokeTypeVariant7 value)
        {
            return value switch
            {
                SwimStrokeTypeVariant7.Im => "im",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokeTypeVariant7? ToEnum(string value)
        {
            return value switch
            {
                "im" => SwimStrokeTypeVariant7.Im,
                _ => null,
            };
        }
    }
}
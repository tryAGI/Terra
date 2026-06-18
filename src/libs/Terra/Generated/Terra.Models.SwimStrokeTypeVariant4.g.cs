
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SwimStrokeTypeVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Butterfly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimStrokeTypeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimStrokeTypeVariant4 value)
        {
            return value switch
            {
                SwimStrokeTypeVariant4.Butterfly => "butterfly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimStrokeTypeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "butterfly" => SwimStrokeTypeVariant4.Butterfly,
                _ => null,
            };
        }
    }
}
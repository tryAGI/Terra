
#nullable enable

namespace Terra
{
    /// <summary>
    /// Stroke type used for the workout step (e.g. breaststroke)
    /// </summary>
    public enum StrokeType
    {
        /// <summary>
        /// 
        /// </summary>
        Backstroke,
        /// <summary>
        /// 
        /// </summary>
        Breaststroke,
        /// <summary>
        /// 
        /// </summary>
        Butterfly,
        /// <summary>
        /// 
        /// </summary>
        Freestyle,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrokeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrokeType value)
        {
            return value switch
            {
                StrokeType.Backstroke => "backstroke",
                StrokeType.Breaststroke => "breaststroke",
                StrokeType.Butterfly => "butterfly",
                StrokeType.Freestyle => "freestyle",
                StrokeType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrokeType? ToEnum(string value)
        {
            return value switch
            {
                "backstroke" => StrokeType.Backstroke,
                "breaststroke" => StrokeType.Breaststroke,
                "butterfly" => StrokeType.Butterfly,
                "freestyle" => StrokeType.Freestyle,
                "other" => StrokeType.Other,
                _ => null,
            };
        }
    }
}
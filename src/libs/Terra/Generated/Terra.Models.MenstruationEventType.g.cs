
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum MenstruationEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Menstruation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MenstruationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MenstruationEventType value)
        {
            return value switch
            {
                MenstruationEventType.Menstruation => "menstruation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MenstruationEventType? ToEnum(string value)
        {
            return value switch
            {
                "menstruation" => MenstruationEventType.Menstruation,
                _ => null,
            };
        }
    }
}
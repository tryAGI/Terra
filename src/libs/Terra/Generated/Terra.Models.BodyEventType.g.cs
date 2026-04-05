
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Body,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyEventType value)
        {
            return value switch
            {
                BodyEventType.Body => "body",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyEventType? ToEnum(string value)
        {
            return value switch
            {
                "body" => BodyEventType.Body,
                _ => null,
            };
        }
    }
}
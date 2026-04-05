
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProcessingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingEventType value)
        {
            return value switch
            {
                ProcessingEventType.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingEventType? ToEnum(string value)
        {
            return value switch
            {
                "processing" => ProcessingEventType.Processing,
                _ => null,
            };
        }
    }
}
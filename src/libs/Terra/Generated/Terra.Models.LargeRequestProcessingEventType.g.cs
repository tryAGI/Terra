
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum LargeRequestProcessingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        LargeRequestProcessing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LargeRequestProcessingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LargeRequestProcessingEventType value)
        {
            return value switch
            {
                LargeRequestProcessingEventType.LargeRequestProcessing => "large_request_processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LargeRequestProcessingEventType? ToEnum(string value)
        {
            return value switch
            {
                "large_request_processing" => LargeRequestProcessingEventType.LargeRequestProcessing,
                _ => null,
            };
        }
    }
}
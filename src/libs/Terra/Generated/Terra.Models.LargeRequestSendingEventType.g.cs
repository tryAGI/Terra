
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum LargeRequestSendingEventType
    {
        /// <summary>
        /// 
        /// </summary>
        LargeRequestSending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LargeRequestSendingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LargeRequestSendingEventType value)
        {
            return value switch
            {
                LargeRequestSendingEventType.LargeRequestSending => "large_request_sending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LargeRequestSendingEventType? ToEnum(string value)
        {
            return value switch
            {
                "large_request_sending" => LargeRequestSendingEventType.LargeRequestSending,
                _ => null,
            };
        }
    }
}
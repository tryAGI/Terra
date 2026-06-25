
#nullable enable

namespace Terra
{
    /// <summary>
    /// Example: success
    /// </summary>
    public enum WebhooksResendPayloadResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksResendPayloadResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksResendPayloadResponseStatus value)
        {
            return value switch
            {
                WebhooksResendPayloadResponseStatus.Error => "error",
                WebhooksResendPayloadResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksResendPayloadResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => WebhooksResendPayloadResponseStatus.Error,
                "success" => WebhooksResendPayloadResponseStatus.Success,
                _ => null,
            };
        }
    }
}
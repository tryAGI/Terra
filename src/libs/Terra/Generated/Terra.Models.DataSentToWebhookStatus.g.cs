
#nullable enable

namespace Terra
{
    /// <summary>
    /// Example: success
    /// </summary>
    public enum DataSentToWebhookStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataSentToWebhookStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataSentToWebhookStatus value)
        {
            return value switch
            {
                DataSentToWebhookStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataSentToWebhookStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => DataSentToWebhookStatus.Success,
                _ => null,
            };
        }
    }
}
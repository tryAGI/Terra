
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum S3PayloadEventType
    {
        /// <summary>
        /// 
        /// </summary>
        S3Payload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class S3PayloadEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this S3PayloadEventType value)
        {
            return value switch
            {
                S3PayloadEventType.S3Payload => "s3_payload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static S3PayloadEventType? ToEnum(string value)
        {
            return value switch
            {
                "s3_payload" => S3PayloadEventType.S3Payload,
                _ => null,
            };
        }
    }
}
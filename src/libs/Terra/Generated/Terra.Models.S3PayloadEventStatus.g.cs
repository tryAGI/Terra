
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the upload
    /// </summary>
    public enum S3PayloadEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class S3PayloadEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this S3PayloadEventStatus value)
        {
            return value switch
            {
                S3PayloadEventStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static S3PayloadEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => S3PayloadEventStatus.Success,
                _ => null,
            };
        }
    }
}
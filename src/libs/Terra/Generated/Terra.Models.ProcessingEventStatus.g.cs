
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the processing
    /// </summary>
    public enum ProcessingEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingEventStatus value)
        {
            return value switch
            {
                ProcessingEventStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => ProcessingEventStatus.Success,
                _ => null,
            };
        }
    }
}
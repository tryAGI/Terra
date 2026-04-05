
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the processing
    /// </summary>
    public enum LargeRequestProcessingEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LargeRequestProcessingEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LargeRequestProcessingEventStatus value)
        {
            return value switch
            {
                LargeRequestProcessingEventStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LargeRequestProcessingEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "processing" => LargeRequestProcessingEventStatus.Processing,
                _ => null,
            };
        }
    }
}
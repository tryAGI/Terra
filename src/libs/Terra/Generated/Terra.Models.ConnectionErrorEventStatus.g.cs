
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the event
    /// </summary>
    public enum ConnectionErrorEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectionErrorEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectionErrorEventStatus value)
        {
            return value switch
            {
                ConnectionErrorEventStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectionErrorEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "warning" => ConnectionErrorEventStatus.Warning,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConnectionErrorEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ConnectionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConnectionErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConnectionErrorEventType value)
        {
            return value switch
            {
                ConnectionErrorEventType.ConnectionError => "connection_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConnectionErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "connection_error" => ConnectionErrorEventType.ConnectionError,
                _ => null,
            };
        }
    }
}
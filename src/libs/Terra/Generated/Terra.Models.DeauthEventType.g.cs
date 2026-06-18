
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeauthEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Deauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeauthEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeauthEventType value)
        {
            return value switch
            {
                DeauthEventType.Deauth => "deauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeauthEventType? ToEnum(string value)
        {
            return value switch
            {
                "deauth" => DeauthEventType.Deauth,
                _ => null,
            };
        }
    }
}
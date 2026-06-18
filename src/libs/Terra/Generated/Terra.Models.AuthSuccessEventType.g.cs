
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthSuccessEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Auth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthSuccessEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthSuccessEventType value)
        {
            return value switch
            {
                AuthSuccessEventType.Auth => "auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthSuccessEventType? ToEnum(string value)
        {
            return value switch
            {
                "auth" => AuthSuccessEventType.Auth,
                _ => null,
            };
        }
    }
}
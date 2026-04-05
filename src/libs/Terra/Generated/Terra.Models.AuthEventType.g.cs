
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Auth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthEventType value)
        {
            return value switch
            {
                AuthEventType.Auth => "auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthEventType? ToEnum(string value)
        {
            return value switch
            {
                "auth" => AuthEventType.Auth,
                _ => null,
            };
        }
    }
}
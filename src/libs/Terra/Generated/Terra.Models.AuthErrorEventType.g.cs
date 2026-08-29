
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum AuthErrorEventType
    {
        /// <summary>
        ///
        /// </summary>
        AuthCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthErrorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthErrorEventType value)
        {
            return value switch
            {
                AuthErrorEventType.AuthCancelled => "auth_cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthErrorEventType? ToEnum(string value)
        {
            return value switch
            {
                "auth_cancelled" => AuthErrorEventType.AuthCancelled,
                _ => null,
            };
        }
    }
}
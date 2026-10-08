
#nullable enable

namespace Terra
{
    /// <summary>
    /// Which Terra reference app an SDK authentication link hands the end user to. For APPLE_HEALTH, omit to use Terra Avengers. For HEALTH_CONNECT and SAMSUNG, "grip" is required; any other value or omitting it is rejected with a 400. The link carries a resource query parameter (APPLE, HEALTH_CONNECT or SAMSUNG) naming the connection the app opens. Sending this for any other resource has no effect.
    /// </summary>
    public enum AuthenticationAuthenticateUserRequestSdkApp
    {
        /// <summary>
        ///
        /// </summary>
        Avengers,
        /// <summary>
        ///
        /// </summary>
        Grip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationAuthenticateUserRequestSdkAppExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationAuthenticateUserRequestSdkApp value)
        {
            return value switch
            {
                AuthenticationAuthenticateUserRequestSdkApp.Avengers => "avengers",
                AuthenticationAuthenticateUserRequestSdkApp.Grip => "grip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationAuthenticateUserRequestSdkApp? ToEnum(string value)
        {
            return value switch
            {
                "avengers" => AuthenticationAuthenticateUserRequestSdkApp.Avengers,
                "grip" => AuthenticationAuthenticateUserRequestSdkApp.Grip,
                _ => null,
            };
        }
    }
}
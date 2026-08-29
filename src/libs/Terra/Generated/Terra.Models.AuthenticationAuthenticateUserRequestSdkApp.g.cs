
#nullable enable

namespace Terra
{
    /// <summary>
    /// Which Terra reference app an APPLE_HEALTH authentication link hands the end user to. Omit to use Terra Avengers. Sending this for any other resource has no effect.
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
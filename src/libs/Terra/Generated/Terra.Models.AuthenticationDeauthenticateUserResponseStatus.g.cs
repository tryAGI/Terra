
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that the deauthentication was successful (value is success)
    /// </summary>
    public enum AuthenticationDeauthenticateUserResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationDeauthenticateUserResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationDeauthenticateUserResponseStatus value)
        {
            return value switch
            {
                AuthenticationDeauthenticateUserResponseStatus.Error => "error",
                AuthenticationDeauthenticateUserResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationDeauthenticateUserResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthenticationDeauthenticateUserResponseStatus.Error,
                "success" => AuthenticationDeauthenticateUserResponseStatus.Success,
                _ => null,
            };
        }
    }
}
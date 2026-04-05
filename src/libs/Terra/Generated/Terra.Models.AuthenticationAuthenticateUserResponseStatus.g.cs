
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that the request was successful<br/>
    /// Example: success
    /// </summary>
    public enum AuthenticationAuthenticateUserResponseStatus
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
    public static class AuthenticationAuthenticateUserResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationAuthenticateUserResponseStatus value)
        {
            return value switch
            {
                AuthenticationAuthenticateUserResponseStatus.Error => "error",
                AuthenticationAuthenticateUserResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationAuthenticateUserResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthenticationAuthenticateUserResponseStatus.Error,
                "success" => AuthenticationAuthenticateUserResponseStatus.Success,
                _ => null,
            };
        }
    }
}
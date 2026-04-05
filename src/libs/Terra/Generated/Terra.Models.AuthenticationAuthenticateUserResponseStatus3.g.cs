
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum AuthenticationAuthenticateUserResponseStatus3
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
    public static class AuthenticationAuthenticateUserResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationAuthenticateUserResponseStatus3 value)
        {
            return value switch
            {
                AuthenticationAuthenticateUserResponseStatus3.Error => "error",
                AuthenticationAuthenticateUserResponseStatus3.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationAuthenticateUserResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthenticationAuthenticateUserResponseStatus3.Error,
                "success" => AuthenticationAuthenticateUserResponseStatus3.Success,
                _ => null,
            };
        }
    }
}
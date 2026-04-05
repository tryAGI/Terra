
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum AuthenticationDeauthenticateUserResponseStatus2
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
    public static class AuthenticationDeauthenticateUserResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationDeauthenticateUserResponseStatus2 value)
        {
            return value switch
            {
                AuthenticationDeauthenticateUserResponseStatus2.Error => "error",
                AuthenticationDeauthenticateUserResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationDeauthenticateUserResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthenticationDeauthenticateUserResponseStatus2.Error,
                "success" => AuthenticationDeauthenticateUserResponseStatus2.Success,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum AuthenticationAuthenticateUserResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationAuthenticateUserResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationAuthenticateUserResponseStatus2 value)
        {
            return value switch
            {
                AuthenticationAuthenticateUserResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationAuthenticateUserResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthenticationAuthenticateUserResponseStatus2.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserReauthEventType
    {
        /// <summary>
        /// 
        /// </summary>
        UserReauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserReauthEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserReauthEventType value)
        {
            return value switch
            {
                UserReauthEventType.UserReauth => "user_reauth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserReauthEventType? ToEnum(string value)
        {
            return value switch
            {
                "user_reauth" => UserReauthEventType.UserReauth,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the re-authentication
    /// </summary>
    public enum UserReauthEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserReauthEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserReauthEventStatus value)
        {
            return value switch
            {
                UserReauthEventStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserReauthEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "warning" => UserReauthEventStatus.Warning,
                _ => null,
            };
        }
    }
}
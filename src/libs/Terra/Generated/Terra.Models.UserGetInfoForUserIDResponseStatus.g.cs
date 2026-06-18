
#nullable enable

namespace Terra
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum UserGetInfoForUserIDResponseStatus
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
    public static class UserGetInfoForUserIDResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGetInfoForUserIDResponseStatus value)
        {
            return value switch
            {
                UserGetInfoForUserIDResponseStatus.Error => "error",
                UserGetInfoForUserIDResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGetInfoForUserIDResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserGetInfoForUserIDResponseStatus.Error,
                "success" => UserGetInfoForUserIDResponseStatus.Success,
                _ => null,
            };
        }
    }
}
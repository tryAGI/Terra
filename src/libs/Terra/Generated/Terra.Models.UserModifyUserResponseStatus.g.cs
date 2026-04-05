
#nullable enable

namespace Terra
{
    /// <summary>
    /// Indicates that the request was successful<br/>
    /// Example: success
    /// </summary>
    public enum UserModifyUserResponseStatus
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
    public static class UserModifyUserResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserModifyUserResponseStatus value)
        {
            return value switch
            {
                UserModifyUserResponseStatus.Error => "error",
                UserModifyUserResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserModifyUserResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserModifyUserResponseStatus.Error,
                "success" => UserModifyUserResponseStatus.Success,
                _ => null,
            };
        }
    }
}
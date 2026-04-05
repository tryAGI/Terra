
#nullable enable

namespace Terra
{
    /// <summary>
    /// Indicates that an error occurred (value is `error`)
    /// </summary>
    public enum UserGetAllUserIDsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserGetAllUserIDsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGetAllUserIDsResponseStatus value)
        {
            return value switch
            {
                UserGetAllUserIDsResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGetAllUserIDsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserGetAllUserIDsResponseStatus.Error,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum UserGetInfoForMultipleUserIDsResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserGetInfoForMultipleUserIDsResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGetInfoForMultipleUserIDsResponseStatus value)
        {
            return value switch
            {
                UserGetInfoForMultipleUserIDsResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGetInfoForMultipleUserIDsResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserGetInfoForMultipleUserIDsResponseStatus.Error,
                _ => null,
            };
        }
    }
}
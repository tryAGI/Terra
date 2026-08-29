
#nullable enable

namespace Terra
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum UserListResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserListResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserListResponseStatus value)
        {
            return value switch
            {
                UserListResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserListResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => UserListResponseStatus.Success,
                _ => null,
            };
        }
    }
}
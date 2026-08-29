
#nullable enable

namespace Terra
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum UserGetResponseStatus
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
    public static class UserGetResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserGetResponseStatus value)
        {
            return value switch
            {
                UserGetResponseStatus.Error => "error",
                UserGetResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserGetResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserGetResponseStatus.Error,
                "success" => UserGetResponseStatus.Success,
                _ => null,
            };
        }
    }
}
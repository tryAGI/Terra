
#nullable enable

namespace Terra
{
    /// <summary>
    /// Indicates an error happened
    /// </summary>
    public enum UserModifyUserResponseStatus2
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
    public static class UserModifyUserResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserModifyUserResponseStatus2 value)
        {
            return value switch
            {
                UserModifyUserResponseStatus2.Error => "error",
                UserModifyUserResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserModifyUserResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => UserModifyUserResponseStatus2.Error,
                "success" => UserModifyUserResponseStatus2.Success,
                _ => null,
            };
        }
    }
}
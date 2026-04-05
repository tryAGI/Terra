
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of authentication
    /// </summary>
    public enum AuthSuccessEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthSuccessEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthSuccessEventStatus value)
        {
            return value switch
            {
                AuthSuccessEventStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthSuccessEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => AuthSuccessEventStatus.Success,
                _ => null,
            };
        }
    }
}
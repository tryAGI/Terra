
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of authentication
    /// </summary>
    public enum AuthErrorEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthErrorEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthErrorEventStatus value)
        {
            return value switch
            {
                AuthErrorEventStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthErrorEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthErrorEventStatus.Error,
                _ => null,
            };
        }
    }
}
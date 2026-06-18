
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that the request was successful (value is success)<br/>
    /// Example: success
    /// </summary>
    public enum AuthenticationGenerateWidgetSessionResponseStatus
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
    public static class AuthenticationGenerateWidgetSessionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationGenerateWidgetSessionResponseStatus value)
        {
            return value switch
            {
                AuthenticationGenerateWidgetSessionResponseStatus.Error => "error",
                AuthenticationGenerateWidgetSessionResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationGenerateWidgetSessionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthenticationGenerateWidgetSessionResponseStatus.Error,
                "success" => AuthenticationGenerateWidgetSessionResponseStatus.Success,
                _ => null,
            };
        }
    }
}
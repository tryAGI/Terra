
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum AuthenticationGenerateWidgetSessionResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthenticationGenerateWidgetSessionResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthenticationGenerateWidgetSessionResponseStatus2 value)
        {
            return value switch
            {
                AuthenticationGenerateWidgetSessionResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthenticationGenerateWidgetSessionResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => AuthenticationGenerateWidgetSessionResponseStatus2.Error,
                _ => null,
            };
        }
    }
}
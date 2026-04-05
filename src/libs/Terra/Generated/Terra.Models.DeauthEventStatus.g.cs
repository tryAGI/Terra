
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of deauthentication
    /// </summary>
    public enum DeauthEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeauthEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeauthEventStatus value)
        {
            return value switch
            {
                DeauthEventStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeauthEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => DeauthEventStatus.Success,
                _ => null,
            };
        }
    }
}
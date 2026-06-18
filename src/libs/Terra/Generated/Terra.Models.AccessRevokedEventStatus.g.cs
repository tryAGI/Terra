
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the event
    /// </summary>
    public enum AccessRevokedEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessRevokedEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessRevokedEventStatus value)
        {
            return value switch
            {
                AccessRevokedEventStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessRevokedEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "warning" => AccessRevokedEventStatus.Warning,
                _ => null,
            };
        }
    }
}
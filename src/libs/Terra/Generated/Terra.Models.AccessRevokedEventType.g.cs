
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum AccessRevokedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        AccessRevoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessRevokedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessRevokedEventType value)
        {
            return value switch
            {
                AccessRevokedEventType.AccessRevoked => "access_revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessRevokedEventType? ToEnum(string value)
        {
            return value switch
            {
                "access_revoked" => AccessRevokedEventType.AccessRevoked,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum PermissionChangeEventType
    {
        /// <summary>
        /// 
        /// </summary>
        PermissionChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionChangeEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionChangeEventType value)
        {
            return value switch
            {
                PermissionChangeEventType.PermissionChange => "permission_change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionChangeEventType? ToEnum(string value)
        {
            return value switch
            {
                "permission_change" => PermissionChangeEventType.PermissionChange,
                _ => null,
            };
        }
    }
}
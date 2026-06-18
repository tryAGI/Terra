
#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the event
    /// </summary>
    public enum PermissionChangeEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PermissionChangeEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PermissionChangeEventStatus value)
        {
            return value switch
            {
                PermissionChangeEventStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PermissionChangeEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "warning" => PermissionChangeEventStatus.Warning,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// Status of the event
    /// </summary>
    public enum GoogleNoDatasourceEventStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleNoDatasourceEventStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleNoDatasourceEventStatus value)
        {
            return value switch
            {
                GoogleNoDatasourceEventStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleNoDatasourceEventStatus? ToEnum(string value)
        {
            return value switch
            {
                "warning" => GoogleNoDatasourceEventStatus.Warning,
                _ => null,
            };
        }
    }
}
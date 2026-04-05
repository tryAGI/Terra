
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum GoogleNoDatasourceEventType
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleNoDatasource,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleNoDatasourceEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleNoDatasourceEventType value)
        {
            return value switch
            {
                GoogleNoDatasourceEventType.GoogleNoDatasource => "google_no_datasource",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleNoDatasourceEventType? ToEnum(string value)
        {
            return value switch
            {
                "google_no_datasource" => GoogleNoDatasourceEventType.GoogleNoDatasource,
                _ => null,
            };
        }
    }
}
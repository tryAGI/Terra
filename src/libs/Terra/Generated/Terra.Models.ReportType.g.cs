
#nullable enable

namespace Terra
{
    /// <summary>
    /// Returned by the upload endpoint. A single upload may fan out to multiple sessions.
    /// </summary>
    public enum ReportType
    {
        /// <summary>
        ///
        /// </summary>
        Dexa,
        /// <summary>
        ///
        /// </summary>
        Lab,
        /// <summary>
        ///
        /// </summary>
        Unspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportType value)
        {
            return value switch
            {
                ReportType.Dexa => "dexa",
                ReportType.Lab => "lab",
                ReportType.Unspecified => "unspecified",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportType? ToEnum(string value)
        {
            return value switch
            {
                "dexa" => ReportType.Dexa,
                "lab" => ReportType.Lab,
                "unspecified" => ReportType.Unspecified,
                _ => null,
            };
        }
    }
}
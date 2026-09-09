
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum ReportsListReportType
    {
        /// <summary>
        ///
        /// </summary>
        Dexa,
        /// <summary>
        ///
        /// </summary>
        Lab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReportsListReportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReportsListReportType value)
        {
            return value switch
            {
                ReportsListReportType.Dexa => "dexa",
                ReportsListReportType.Lab => "lab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReportsListReportType? ToEnum(string value)
        {
            return value switch
            {
                "dexa" => ReportsListReportType.Dexa,
                "lab" => ReportsListReportType.Lab,
                _ => null,
            };
        }
    }
}
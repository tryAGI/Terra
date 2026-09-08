
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum LabReportsListReportType
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
    public static class LabReportsListReportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LabReportsListReportType value)
        {
            return value switch
            {
                LabReportsListReportType.Dexa => "dexa",
                LabReportsListReportType.Lab => "lab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LabReportsListReportType? ToEnum(string value)
        {
            return value switch
            {
                "dexa" => LabReportsListReportType.Dexa,
                "lab" => LabReportsListReportType.Lab,
                _ => null,
            };
        }
    }
}
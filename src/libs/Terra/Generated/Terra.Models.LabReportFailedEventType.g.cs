
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum LabReportFailedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        LabReportFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LabReportFailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LabReportFailedEventType value)
        {
            return value switch
            {
                LabReportFailedEventType.LabReportFailed => "lab_report.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LabReportFailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "lab_report.failed" => LabReportFailedEventType.LabReportFailed,
                _ => null,
            };
        }
    }
}
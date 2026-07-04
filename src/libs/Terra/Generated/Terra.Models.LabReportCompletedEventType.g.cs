
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum LabReportCompletedEventType
    {
        /// <summary>
        /// 
        /// </summary>
        LabReportCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LabReportCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LabReportCompletedEventType value)
        {
            return value switch
            {
                LabReportCompletedEventType.LabReportCompleted => "lab_report.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LabReportCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "lab_report.completed" => LabReportCompletedEventType.LabReportCompleted,
                _ => null,
            };
        }
    }
}
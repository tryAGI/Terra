
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum PlannedWorkoutUpdateResultStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Skipped,
        /// <summary>
        ///
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedWorkoutUpdateResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedWorkoutUpdateResultStatus value)
        {
            return value switch
            {
                PlannedWorkoutUpdateResultStatus.Failed => "failed",
                PlannedWorkoutUpdateResultStatus.Skipped => "skipped",
                PlannedWorkoutUpdateResultStatus.Updated => "updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedWorkoutUpdateResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "failed" => PlannedWorkoutUpdateResultStatus.Failed,
                "skipped" => PlannedWorkoutUpdateResultStatus.Skipped,
                "updated" => PlannedWorkoutUpdateResultStatus.Updated,
                _ => null,
            };
        }
    }
}
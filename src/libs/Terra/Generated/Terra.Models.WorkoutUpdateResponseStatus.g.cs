
#nullable enable

namespace Terra
{
    /// <summary>
    /// Present when every reachable planned workout was updated (200).
    /// </summary>
    public enum WorkoutUpdateResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkoutUpdateResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkoutUpdateResponseStatus value)
        {
            return value switch
            {
                WorkoutUpdateResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkoutUpdateResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "success" => WorkoutUpdateResponseStatus.Success,
                _ => null,
            };
        }
    }
}
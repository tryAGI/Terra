
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSurfaceVariant7
    {
        /// <summary>
        ///
        /// </summary>
        PreacherBench,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant7 value)
        {
            return value switch
            {
                StrengthSurfaceVariant7.PreacherBench => "preacher_bench",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant7? ToEnum(string value)
        {
            return value switch
            {
                "preacher_bench" => StrengthSurfaceVariant7.PreacherBench,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// Example: error
    /// </summary>
    public enum NoDataReturnedStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NoDataReturnedStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NoDataReturnedStatus value)
        {
            return value switch
            {
                NoDataReturnedStatus.Error => "error",
                NoDataReturnedStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NoDataReturnedStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => NoDataReturnedStatus.Error,
                "success" => NoDataReturnedStatus.Success,
                _ => null,
            };
        }
    }
}
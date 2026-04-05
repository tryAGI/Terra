
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum BodyFetchResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyFetchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyFetchResponseStatus value)
        {
            return value switch
            {
                BodyFetchResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyFetchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => BodyFetchResponseStatus.Error,
                _ => null,
            };
        }
    }
}
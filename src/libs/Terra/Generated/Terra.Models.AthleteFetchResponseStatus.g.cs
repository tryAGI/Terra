
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum AthleteFetchResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AthleteFetchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AthleteFetchResponseStatus value)
        {
            return value switch
            {
                AthleteFetchResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AthleteFetchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => AthleteFetchResponseStatus.Error,
                _ => null,
            };
        }
    }
}
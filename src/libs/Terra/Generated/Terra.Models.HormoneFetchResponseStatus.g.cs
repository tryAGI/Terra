
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum HormoneFetchResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HormoneFetchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HormoneFetchResponseStatus value)
        {
            return value switch
            {
                HormoneFetchResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HormoneFetchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => HormoneFetchResponseStatus.Error,
                _ => null,
            };
        }
    }
}
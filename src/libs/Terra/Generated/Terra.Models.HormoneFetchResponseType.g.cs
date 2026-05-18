
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum HormoneFetchResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Hormone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HormoneFetchResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HormoneFetchResponseType value)
        {
            return value switch
            {
                HormoneFetchResponseType.Hormone => "hormone",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HormoneFetchResponseType? ToEnum(string value)
        {
            return value switch
            {
                "hormone" => HormoneFetchResponseType.Hormone,
                _ => null,
            };
        }
    }
}
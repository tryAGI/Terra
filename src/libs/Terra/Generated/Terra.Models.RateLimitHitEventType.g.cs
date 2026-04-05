
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum RateLimitHitEventType
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitHit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitHitEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitHitEventType value)
        {
            return value switch
            {
                RateLimitHitEventType.RateLimitHit => "rate_limit_hit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitHitEventType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limit_hit" => RateLimitHitEventType.RateLimitHit,
                _ => null,
            };
        }
    }
}
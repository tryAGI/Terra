
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum HealthcheckEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Healthcheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HealthcheckEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HealthcheckEventType value)
        {
            return value switch
            {
                HealthcheckEventType.Healthcheck => "healthcheck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HealthcheckEventType? ToEnum(string value)
        {
            return value switch
            {
                "healthcheck" => HealthcheckEventType.Healthcheck,
                _ => null,
            };
        }
    }
}
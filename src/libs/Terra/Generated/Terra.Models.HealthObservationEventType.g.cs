
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum HealthObservationEventType
    {
        /// <summary>
        /// 
        /// </summary>
        HealthObservation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HealthObservationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HealthObservationEventType value)
        {
            return value switch
            {
                HealthObservationEventType.HealthObservation => "health_observation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HealthObservationEventType? ToEnum(string value)
        {
            return value switch
            {
                "health_observation" => HealthObservationEventType.HealthObservation,
                _ => null,
            };
        }
    }
}
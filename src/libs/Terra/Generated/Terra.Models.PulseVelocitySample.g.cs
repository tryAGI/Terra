
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PulseVelocitySample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public string? Timestamp { get; set; }

        /// <summary>
        /// User's Pulse Wave Velocity measurement - velocity at which the blood pressure pulse propagates through the circulatory system<br/>
        /// Example: 7.2
        /// </summary>
        /// <example>7.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pulse_wave_velocity_meters_per_second")]
        public double? PulseWaveVelocityMetersPerSecond { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PulseVelocitySample" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="pulseWaveVelocityMetersPerSecond">
        /// User's Pulse Wave Velocity measurement - velocity at which the blood pressure pulse propagates through the circulatory system<br/>
        /// Example: 7.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PulseVelocitySample(
            string? timestamp,
            double? pulseWaveVelocityMetersPerSecond)
        {
            this.Timestamp = timestamp;
            this.PulseWaveVelocityMetersPerSecond = pulseWaveVelocityMetersPerSecond;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PulseVelocitySample" /> class.
        /// </summary>
        public PulseVelocitySample()
        {
        }
    }
}
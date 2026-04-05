
#nullable enable

namespace Terra
{
    /// <summary>
    /// Athlete data event
    /// </summary>
    public sealed partial class AthleteEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AthleteEventTypeJsonConverter))]
        public global::Terra.AthleteEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.Athlete Athlete { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.TerraUser User { get; set; }

        /// <summary>
        /// API version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AthleteEvent" /> class.
        /// </summary>
        /// <param name="athlete"></param>
        /// <param name="user"></param>
        /// <param name="version">
        /// API version
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AthleteEvent(
            global::Terra.Athlete athlete,
            global::Terra.TerraUser user,
            string version,
            global::Terra.AthleteEventType type)
        {
            this.Type = type;
            this.Athlete = athlete ?? throw new global::System.ArgumentNullException(nameof(athlete));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AthleteEvent" /> class.
        /// </summary>
        public AthleteEvent()
        {
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// Activity data event
    /// </summary>
    public sealed partial class ActivityEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.ActivityEventTypeJsonConverter))]
        public global::Terra.ActivityEventType Type { get; set; }

        /// <summary>
        /// Array of activity data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.Activity> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="ActivityEvent" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of activity data
        /// </param>
        /// <param name="user"></param>
        /// <param name="version">
        /// API version
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityEvent(
            global::System.Collections.Generic.IList<global::Terra.Activity> data,
            global::Terra.TerraUser user,
            string version,
            global::Terra.ActivityEventType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityEvent" /> class.
        /// </summary>
        public ActivityEvent()
        {
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NoDataReturned
    {
        /// <summary>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.NoDataReturnedStatusJsonConverter))]
        public global::Terra.NoDataReturnedStatus? Status { get; set; }

        /// <summary>
        /// Example: No data available for specified time range
        /// </summary>
        /// <example>No data available for specified time range</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: no_data
        /// </summary>
        /// <example>no_data</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Terra User object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataReturned" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: error
        /// </param>
        /// <param name="message">
        /// Example: No data available for specified time range
        /// </param>
        /// <param name="type">
        /// Example: no_data
        /// </param>
        /// <param name="user">
        /// Terra User object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NoDataReturned(
            global::Terra.NoDataReturnedStatus? status,
            string? message,
            string? type,
            global::Terra.TerraUser? user)
        {
            this.Status = status;
            this.Message = message;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NoDataReturned" /> class.
        /// </summary>
        public NoDataReturned()
        {
        }
    }
}
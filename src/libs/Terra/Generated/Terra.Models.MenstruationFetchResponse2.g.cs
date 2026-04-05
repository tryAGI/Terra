
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MenstruationFetchResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Terra.Menstruation>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationFetchResponse2" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MenstruationFetchResponse2(
            global::Terra.TerraUser? user,
            global::System.Collections.Generic.IList<global::Terra.Menstruation>? data,
            string? type)
        {
            this.User = user;
            this.Data = data;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationFetchResponse2" /> class.
        /// </summary>
        public MenstruationFetchResponse2()
        {
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// User information for one connection (single User object)
    /// </summary>
    public sealed partial class UserGetResponse2
    {
        /// <summary>
        /// The connection. In addition to the base User fields, this endpoint also returns polling metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AllOfJsonConverter<global::Terra.TerraUser, global::Terra.UserGetResponseUser>))]
        public global::Terra.AllOf<global::Terra.TerraUser, global::Terra.UserGetResponseUser>? User { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.UserGetResponseStatusJsonConverter))]
        public global::Terra.UserGetResponseStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_authenticated")]
        public bool? IsAuthenticated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetResponse2" /> class.
        /// </summary>
        /// <param name="user">
        /// The connection. In addition to the base User fields, this endpoint also returns polling metadata.
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="isAuthenticated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetResponse2(
            global::Terra.AllOf<global::Terra.TerraUser, global::Terra.UserGetResponseUser>? user,
            global::Terra.UserGetResponseStatus? status,
            bool? isAuthenticated)
        {
            this.User = user;
            this.Status = status;
            this.IsAuthenticated = isAuthenticated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetResponse2" /> class.
        /// </summary>
        public UserGetResponse2()
        {
        }

    }
}
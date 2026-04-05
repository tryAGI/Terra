
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserModifyUserResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// Indicates that the request was successful<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.UserModifyUserResponseStatusJsonConverter))]
        public global::Terra.UserModifyUserResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModifyUserResponse" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="status">
        /// Indicates that the request was successful<br/>
        /// Example: success
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserModifyUserResponse(
            global::Terra.TerraUser? user,
            global::Terra.UserModifyUserResponseStatus? status)
        {
            this.User = user;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModifyUserResponse" /> class.
        /// </summary>
        public UserModifyUserResponse()
        {
        }
    }
}
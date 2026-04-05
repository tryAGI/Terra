
#nullable enable

namespace Terra
{
    /// <summary>
    /// User information for one connection (single User object)
    /// </summary>
    public sealed partial class UserGetInfoForUserIDResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::Terra.TerraUser? User { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatusJsonConverter))]
        public global::Terra.UserGetInfoForUserIDResponseStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="UserGetInfoForUserIDResponse2" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="isAuthenticated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetInfoForUserIDResponse2(
            global::Terra.TerraUser? user,
            global::Terra.UserGetInfoForUserIDResponseStatus? status,
            bool? isAuthenticated)
        {
            this.User = user;
            this.Status = status;
            this.IsAuthenticated = isAuthenticated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetInfoForUserIDResponse2" /> class.
        /// </summary>
        public UserGetInfoForUserIDResponse2()
        {
        }
    }
}
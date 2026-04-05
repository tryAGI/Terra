
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetAllUserIDsResponse2
    {
        /// <summary>
        /// A detailed message describing the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Indicates that an error occurred (value is `error`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.UserGetAllUserIDsResponseStatusJsonConverter))]
        public global::Terra.UserGetAllUserIDsResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetAllUserIDsResponse2" /> class.
        /// </summary>
        /// <param name="message">
        /// A detailed message describing the error
        /// </param>
        /// <param name="status">
        /// Indicates that an error occurred (value is `error`)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetAllUserIDsResponse2(
            string? message,
            global::Terra.UserGetAllUserIDsResponseStatus? status)
        {
            this.Message = message;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetAllUserIDsResponse2" /> class.
        /// </summary>
        public UserGetAllUserIDsResponse2()
        {
        }
    }
}
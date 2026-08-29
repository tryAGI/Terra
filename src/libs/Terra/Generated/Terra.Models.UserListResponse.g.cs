
#nullable enable

namespace Terra
{
    /// <summary>
    /// If `page` is omitted, `users` contains every user. If `page` is provided, `results`, `max_page`, and `next` contain the paginated response.
    /// </summary>
    public sealed partial class UserListResponse
    {
        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.UserListResponseStatusJsonConverter))]
        public global::Terra.UserListResponseStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Terra.TerraUser>? Users { get; set; }

        /// <summary>
        /// The next page number, or null if there is no next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public int? Next { get; set; }

        /// <summary>
        /// Total number of pages available for the requested page size
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_page")]
        public int? MaxPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Terra.TerraUser>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="users"></param>
        /// <param name="next">
        /// The next page number, or null if there is no next page
        /// </param>
        /// <param name="maxPage">
        /// Total number of pages available for the requested page size
        /// </param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserListResponse(
            global::Terra.UserListResponseStatus? status,
            global::System.Collections.Generic.IList<global::Terra.TerraUser>? users,
            int? next,
            int? maxPage,
            global::System.Collections.Generic.IList<global::Terra.TerraUser>? results)
        {
            this.Status = status;
            this.Users = users;
            this.Next = next;
            this.MaxPage = maxPage;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResponse" /> class.
        /// </summary>
        public UserListResponse()
        {
        }

    }
}
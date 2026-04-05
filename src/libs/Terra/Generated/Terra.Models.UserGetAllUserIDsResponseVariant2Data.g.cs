
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserGetAllUserIDsResponseVariant2Data
    {
        /// <summary>
        /// The next page number, or null if there is no next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public int? Next { get; set; }

        /// <summary>
        /// The maximum page index
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
        /// Initializes a new instance of the <see cref="UserGetAllUserIDsResponseVariant2Data" /> class.
        /// </summary>
        /// <param name="next">
        /// The next page number, or null if there is no next page
        /// </param>
        /// <param name="maxPage">
        /// The maximum page index
        /// </param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGetAllUserIDsResponseVariant2Data(
            int? next,
            int? maxPage,
            global::System.Collections.Generic.IList<global::Terra.TerraUser>? results)
        {
            this.Next = next;
            this.MaxPage = maxPage;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGetAllUserIDsResponseVariant2Data" /> class.
        /// </summary>
        public UserGetAllUserIDsResponseVariant2Data()
        {
        }
    }
}
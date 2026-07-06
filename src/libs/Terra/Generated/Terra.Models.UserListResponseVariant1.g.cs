
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserListResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Terra.TerraUser>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResponseVariant1" /> class.
        /// </summary>
        /// <param name="users"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserListResponseVariant1(
            global::System.Collections.Generic.IList<global::Terra.TerraUser>? users)
        {
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResponseVariant1" /> class.
        /// </summary>
        public UserListResponseVariant1()
        {
        }

    }
}
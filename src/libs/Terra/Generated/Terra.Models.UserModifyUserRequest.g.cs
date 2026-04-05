
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserModifyUserRequest
    {
        /// <summary>
        /// Identifier on your system to associate with this user<br/>
        /// Example: updatedUser123
        /// </summary>
        /// <example>updatedUser123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_id")]
        public string? ReferenceId { get; set; }

        /// <summary>
        /// Whether the user should remain active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModifyUserRequest" /> class.
        /// </summary>
        /// <param name="referenceId">
        /// Identifier on your system to associate with this user<br/>
        /// Example: updatedUser123
        /// </param>
        /// <param name="active">
        /// Whether the user should remain active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserModifyUserRequest(
            string? referenceId,
            bool? active)
        {
            this.ReferenceId = referenceId;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModifyUserRequest" /> class.
        /// </summary>
        public UserModifyUserRequest()
        {
        }
    }
}
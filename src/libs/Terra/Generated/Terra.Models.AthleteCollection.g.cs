
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AthleteCollection
    {
        /// <summary>
        /// Object containing the user's information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("athlete")]
        public global::Terra.Athlete? Athlete { get; set; }

        /// <summary>
        /// Example: athlete
        /// </summary>
        /// <example>athlete</example>
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
        /// Initializes a new instance of the <see cref="AthleteCollection" /> class.
        /// </summary>
        /// <param name="athlete">
        /// Object containing the user's information
        /// </param>
        /// <param name="type">
        /// Example: athlete
        /// </param>
        /// <param name="user">
        /// Terra User object
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AthleteCollection(
            global::Terra.Athlete? athlete,
            string? type,
            global::Terra.TerraUser? user)
        {
            this.Athlete = athlete;
            this.Type = type;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AthleteCollection" /> class.
        /// </summary>
        public AthleteCollection()
        {
        }
    }
}
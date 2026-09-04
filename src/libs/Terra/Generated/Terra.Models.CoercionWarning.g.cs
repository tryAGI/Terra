
#nullable enable

namespace Terra
{
    /// <summary>
    /// A non-fatal adjustment made while converting a workout between Terra's template model and a provider's
    /// </summary>
    public sealed partial class CoercionWarning
    {
        /// <summary>
        /// JSON path within the workout template of the element that could not be represented exactly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// What was changed or dropped, and why
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CoercionWarning" /> class.
        /// </summary>
        /// <param name="path">
        /// JSON path within the workout template of the element that could not be represented exactly
        /// </param>
        /// <param name="message">
        /// What was changed or dropped, and why
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CoercionWarning(
            string path,
            string message)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CoercionWarning" /> class.
        /// </summary>
        public CoercionWarning()
        {
        }

    }
}
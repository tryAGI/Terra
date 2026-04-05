
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StrainData
    {
        /// <summary>
        /// Level of cardiovascular strain imposed on the user during the day.<br/>
        /// Example: 14.5
        /// </summary>
        /// <example>14.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("strain_level")]
        public double? StrainLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrainData" /> class.
        /// </summary>
        /// <param name="strainLevel">
        /// Level of cardiovascular strain imposed on the user during the day.<br/>
        /// Example: 14.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrainData(
            double? strainLevel)
        {
            this.StrainLevel = strainLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrainData" /> class.
        /// </summary>
        public StrainData()
        {
        }
    }
}
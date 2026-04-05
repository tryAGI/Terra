
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasurementsData
    {
        /// <summary>
        /// List of body metrics &amp; measurements taken throughout the associated day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurements")]
        public global::System.Collections.Generic.IList<global::Terra.MeasurementDataSample>? Measurements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsData" /> class.
        /// </summary>
        /// <param name="measurements">
        /// List of body metrics &amp; measurements taken throughout the associated day.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasurementsData(
            global::System.Collections.Generic.IList<global::Terra.MeasurementDataSample>? measurements)
        {
            this.Measurements = measurements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsData" /> class.
        /// </summary>
        public MeasurementsData()
        {
        }
    }
}
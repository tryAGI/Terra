
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabReportDeliveriesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Terra.LabReportDelivery> Deliveries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportDeliveriesResponse" /> class.
        /// </summary>
        /// <param name="deliveries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabReportDeliveriesResponse(
            global::System.Collections.Generic.IList<global::Terra.LabReportDelivery> deliveries)
        {
            this.Deliveries = deliveries ?? throw new global::System.ArgumentNullException(nameof(deliveries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabReportDeliveriesResponse" /> class.
        /// </summary>
        public LabReportDeliveriesResponse()
        {
        }

    }
}
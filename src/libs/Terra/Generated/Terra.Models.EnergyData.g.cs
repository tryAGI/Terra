
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnergyData
    {
        /// <summary>
        /// Total number of kiloJoules expended during the workout<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("energy_kilojoules")]
        public double? EnergyKilojoules { get; set; }

        /// <summary>
        /// Total number of kiloJoules planned to be expended during the workout - represents the user's predefined goal for the workout<br/>
        /// Example: 1150
        /// </summary>
        /// <example>1150</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("energy_planned_kilojoules")]
        public double? EnergyPlannedKilojoules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyData" /> class.
        /// </summary>
        /// <param name="energyKilojoules">
        /// Total number of kiloJoules expended during the workout<br/>
        /// Example: 1200
        /// </param>
        /// <param name="energyPlannedKilojoules">
        /// Total number of kiloJoules planned to be expended during the workout - represents the user's predefined goal for the workout<br/>
        /// Example: 1150
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnergyData(
            double? energyKilojoules,
            double? energyPlannedKilojoules)
        {
            this.EnergyKilojoules = energyKilojoules;
            this.EnergyPlannedKilojoules = energyPlannedKilojoules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyData" /> class.
        /// </summary>
        public EnergyData()
        {
        }
    }
}
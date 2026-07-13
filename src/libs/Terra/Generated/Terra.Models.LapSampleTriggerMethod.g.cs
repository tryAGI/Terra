
#nullable enable

namespace Terra
{
    /// <summary>
    /// What caused the lap to be recorded, where the device reports it: one of MANUAL, TIME, DISTANCE, POSITION_START, POSITION_LAP, POSITION_WAYPOINT, POSITION_MARKED, SESSION_END, FITNESS_EQUIPMENT, or UNSPECIFIED where the device reported a trigger we do not recognise. Devices commonly record automatic splits (DISTANCE, TIME) in the same activity as the laps the athlete pressed for (MANUAL), so filter on this to isolate one stream rather than treating every lap as equivalent. Null for providers that do not report a lap trigger.<br/>
    /// Example: MANUAL
    /// </summary>
    public sealed partial class LapSampleTriggerMethod
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
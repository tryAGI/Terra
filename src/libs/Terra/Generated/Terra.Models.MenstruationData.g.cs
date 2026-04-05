
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MenstruationData
    {
        /// <summary>
        /// Total length of period (i.e. menstrual bleeding).<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_length_days")]
        public int? PeriodLengthDays { get; set; }

        /// <summary>
        /// Represents menstrual cycle phases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.MenstrualPhaseJsonConverter))]
        public global::Terra.MenstrualPhase? CurrentPhase { get; set; }

        /// <summary>
        /// Length of current phase.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("length_of_current_phase_days")]
        public int? LengthOfCurrentPhaseDays { get; set; }

        /// <summary>
        /// Number of days to reach the next phase (predicted).<br/>
        /// Example: 23
        /// </summary>
        /// <example>23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("days_until_next_phase")]
        public int? DaysUntilNextPhase { get; set; }

        /// <summary>
        /// Start date of menstrual cycle, in ISO8601 format.<br/>
        /// Example: 2022-11-28
        /// </summary>
        /// <example>2022-11-28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_start_date")]
        public string? PeriodStartDate { get; set; }

        /// <summary>
        /// Prediction of the cycle's total length.<br/>
        /// Example: 28
        /// </summary>
        /// <example>28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("predicted_cycle_length_days")]
        public int? PredictedCycleLengthDays { get; set; }

        /// <summary>
        /// Number of day in cycle this object is associated with.<br/>
        /// Example: 24
        /// </summary>
        /// <example>24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_in_cycle")]
        public int? DayInCycle { get; set; }

        /// <summary>
        /// Last time when the user recorded information regarding their cycle, in ISO8601 format, with microseconds precision.<br/>
        /// Example: 2022-12-12T14:03:05.000000-05:00
        /// </summary>
        /// <example>2022-12-12T14:03:05.000000-05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_time")]
        public string? LastUpdatedTime { get; set; }

        /// <summary>
        /// Total cycle length in days.<br/>
        /// Example: 28
        /// </summary>
        /// <example>28</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cycle_length_days")]
        public string? CycleLengthDays { get; set; }

        /// <summary>
        /// Flag indicating whether associated object is a prediction or user-logged information.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_predicted_cycle")]
        public string? IsPredictedCycle { get; set; }

        /// <summary>
        /// List of user logs of information related to the strength of user's menstrual flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("menstruation_flow")]
        public global::System.Collections.Generic.IList<global::Terra.MenstruationFlowSample>? MenstruationFlow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationData" /> class.
        /// </summary>
        /// <param name="periodLengthDays">
        /// Total length of period (i.e. menstrual bleeding).<br/>
        /// Example: 5
        /// </param>
        /// <param name="currentPhase">
        /// Represents menstrual cycle phases.
        /// </param>
        /// <param name="lengthOfCurrentPhaseDays">
        /// Length of current phase.<br/>
        /// Example: 5
        /// </param>
        /// <param name="daysUntilNextPhase">
        /// Number of days to reach the next phase (predicted).<br/>
        /// Example: 23
        /// </param>
        /// <param name="periodStartDate">
        /// Start date of menstrual cycle, in ISO8601 format.<br/>
        /// Example: 2022-11-28
        /// </param>
        /// <param name="predictedCycleLengthDays">
        /// Prediction of the cycle's total length.<br/>
        /// Example: 28
        /// </param>
        /// <param name="dayInCycle">
        /// Number of day in cycle this object is associated with.<br/>
        /// Example: 24
        /// </param>
        /// <param name="lastUpdatedTime">
        /// Last time when the user recorded information regarding their cycle, in ISO8601 format, with microseconds precision.<br/>
        /// Example: 2022-12-12T14:03:05.000000-05:00
        /// </param>
        /// <param name="cycleLengthDays">
        /// Total cycle length in days.<br/>
        /// Example: 28
        /// </param>
        /// <param name="isPredictedCycle">
        /// Flag indicating whether associated object is a prediction or user-logged information.<br/>
        /// Example: true
        /// </param>
        /// <param name="menstruationFlow">
        /// List of user logs of information related to the strength of user's menstrual flow.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MenstruationData(
            int? periodLengthDays,
            global::Terra.MenstrualPhase? currentPhase,
            int? lengthOfCurrentPhaseDays,
            int? daysUntilNextPhase,
            string? periodStartDate,
            int? predictedCycleLengthDays,
            int? dayInCycle,
            string? lastUpdatedTime,
            string? cycleLengthDays,
            string? isPredictedCycle,
            global::System.Collections.Generic.IList<global::Terra.MenstruationFlowSample>? menstruationFlow)
        {
            this.PeriodLengthDays = periodLengthDays;
            this.CurrentPhase = currentPhase;
            this.LengthOfCurrentPhaseDays = lengthOfCurrentPhaseDays;
            this.DaysUntilNextPhase = daysUntilNextPhase;
            this.PeriodStartDate = periodStartDate;
            this.PredictedCycleLengthDays = predictedCycleLengthDays;
            this.DayInCycle = dayInCycle;
            this.LastUpdatedTime = lastUpdatedTime;
            this.CycleLengthDays = cycleLengthDays;
            this.IsPredictedCycle = isPredictedCycle;
            this.MenstruationFlow = menstruationFlow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenstruationData" /> class.
        /// </summary>
        public MenstruationData()
        {
        }
    }
}
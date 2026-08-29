
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StrengthSet
    {
        /// <summary>
        /// Distance covered, for loaded carries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance_meters")]
        public double? DistanceMeters { get; set; }

        /// <summary>
        /// Duration of the set, for timed holds and carries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_seconds")]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// End of the set, ISO 8601. Null when the source does not timestamp sets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// How to read weight_kg for this set. Open enum — handle unknown values gracefully.<br/>
        /// Example: assisted
        /// </summary>
        /// <example>assisted</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("load_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.StrengthLoadTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Terra.StrengthLoadType LoadType { get; set; }

        /// <summary>
        /// The user's note on this specific set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Repetitions performed, exactly as the source recorded them. For unilateral movements this is per side.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reps")]
        public int? Reps { get; set; }

        /// <summary>
        /// Rest taken after this set, within its exercise. Rest between exercises is not represented.<br/>
        /// Example: 120
        /// </summary>
        /// <example>120</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rest_after_seconds")]
        public int? RestAfterSeconds { get; set; }

        /// <summary>
        /// Reps in reserve. Never converted to or from rpe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rir")]
        public double? Rir { get; set; }

        /// <summary>
        /// Rate of perceived exertion, on a 0-10 scale.<br/>
        /// Example: 8.5
        /// </summary>
        /// <example>8.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpe")]
        public double? Rpe { get; set; }

        /// <summary>
        /// The type of set as reported by the source, such as normal, warmup, dropset or failure. Open enum — handle unknown values gracefully. unknown when the source does not classify the set.<br/>
        /// Example: normal
        /// </summary>
        /// <example>normal</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_type")]
        public global::Terra.StrengthSetType? SetType { get; set; }

        /// <summary>
        /// Start of the set, ISO 8601. Null when the source does not timestamp sets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// Load as the source logged it: a barbell's total, or one dumbbell. Never negative. Null when load_type is unknown, and may also be null for a load_type you do not recognise.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_kg")]
        public double? WeightKg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthSet" /> class.
        /// </summary>
        /// <param name="loadType">
        /// How to read weight_kg for this set. Open enum — handle unknown values gracefully.<br/>
        /// Example: assisted
        /// </param>
        /// <param name="distanceMeters">
        /// Distance covered, for loaded carries.
        /// </param>
        /// <param name="durationSeconds">
        /// Duration of the set, for timed holds and carries.
        /// </param>
        /// <param name="endTime">
        /// End of the set, ISO 8601. Null when the source does not timestamp sets.
        /// </param>
        /// <param name="notes">
        /// The user's note on this specific set.
        /// </param>
        /// <param name="reps">
        /// Repetitions performed, exactly as the source recorded them. For unilateral movements this is per side.<br/>
        /// Example: 5
        /// </param>
        /// <param name="restAfterSeconds">
        /// Rest taken after this set, within its exercise. Rest between exercises is not represented.<br/>
        /// Example: 120
        /// </param>
        /// <param name="rir">
        /// Reps in reserve. Never converted to or from rpe.
        /// </param>
        /// <param name="rpe">
        /// Rate of perceived exertion, on a 0-10 scale.<br/>
        /// Example: 8.5
        /// </param>
        /// <param name="setType">
        /// The type of set as reported by the source, such as normal, warmup, dropset or failure. Open enum — handle unknown values gracefully. unknown when the source does not classify the set.<br/>
        /// Example: normal
        /// </param>
        /// <param name="startTime">
        /// Start of the set, ISO 8601. Null when the source does not timestamp sets.
        /// </param>
        /// <param name="weightKg">
        /// Load as the source logged it: a barbell's total, or one dumbbell. Never negative. Null when load_type is unknown, and may also be null for a load_type you do not recognise.<br/>
        /// Example: 100
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrengthSet(
            global::Terra.StrengthLoadType loadType,
            double? distanceMeters,
            double? durationSeconds,
            string? endTime,
            string? notes,
            int? reps,
            int? restAfterSeconds,
            double? rir,
            double? rpe,
            global::Terra.StrengthSetType? setType,
            string? startTime,
            double? weightKg)
        {
            this.DistanceMeters = distanceMeters;
            this.DurationSeconds = durationSeconds;
            this.EndTime = endTime;
            this.LoadType = loadType;
            this.Notes = notes;
            this.Reps = reps;
            this.RestAfterSeconds = restAfterSeconds;
            this.Rir = rir;
            this.Rpe = rpe;
            this.SetType = setType;
            this.StartTime = startTime;
            this.WeightKg = weightKg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthSet" /> class.
        /// </summary>
        public StrengthSet()
        {
        }

    }
}
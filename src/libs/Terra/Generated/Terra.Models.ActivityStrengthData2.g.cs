
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityStrengthData2
    {
        /// <summary>
        /// The user's bodyweight at the time of the workout, when the source records it. Needed to value bodyweight-based sets, and frequently absent.<br/>
        /// Example: 78.2
        /// </summary>
        /// <example>78.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_weight_kg")]
        public double? BodyWeightKg { get; set; }

        /// <summary>
        /// The exercises performed, in the order they were started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercises")]
        public global::System.Collections.Generic.IList<global::Terra.StrengthExercise>? Exercises { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStrengthData2" /> class.
        /// </summary>
        /// <param name="bodyWeightKg">
        /// The user's bodyweight at the time of the workout, when the source records it. Needed to value bodyweight-based sets, and frequently absent.<br/>
        /// Example: 78.2
        /// </param>
        /// <param name="exercises">
        /// The exercises performed, in the order they were started.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityStrengthData2(
            double? bodyWeightKg,
            global::System.Collections.Generic.IList<global::Terra.StrengthExercise>? exercises)
        {
            this.BodyWeightKg = bodyWeightKg;
            this.Exercises = exercises;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStrengthData2" /> class.
        /// </summary>
        public ActivityStrengthData2()
        {
        }

    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StrengthExercise
    {
        /// <summary>
        /// The source's own label for the exercise, passed through verbatim. Present whenever the source names the exercise, whether or not it resolved to a movement. Intended for display.<br/>
        /// Example: Close Grip Bench Press
        /// </summary>
        /// <example>Close Grip Bench Press</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exercise_name")]
        public string? ExerciseName { get; set; }

        /// <summary>
        /// The joint actions performed, in the order one repetition performs them, with implement, grip, stance, tempo and position all carried in modifiers. Usually one; a clean and jerk is [clean, jerk]. This is the rollup axis, and membership is what to test: a clean and jerk belongs in both clean volume and jerk volume, so ask whether movements contains the value rather than equals it. Open enum — handle unknown values gracefully. Empty when the exercise could not be resolved, in which case exercise_name still says what the source called it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("movements")]
        public global::System.Collections.Generic.IList<global::Terra.StrengthMovement>? Movements { get; set; }

        /// <summary>
        /// The body part a stretch or mobility drill targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::Terra.StrengthTarget? Target { get; set; }

        /// <summary>
        /// The axes that qualify the exercise. An axis that is absent was not reported by the source — it does NOT mean a default applies, so a squat with no implement is not the same as a bodyweight squat. Axes describe the exercise as performed rather than each movement separately: in a step up to a deficit reverse lunge only the lunge is at a deficit, but the axis describes the whole exercise and exercise_name carries the detail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiers")]
        public global::Terra.StrengthExerciseModifiers? Modifiers { get; set; }

        /// <summary>
        /// The muscles the exercise primarily works, as reported by the source. A list because providers differ: some name exactly one, some name several for the same exercise, and some name none. Empty means the source did not say, not that no muscle is worked. Open enum — handle unknown values gracefully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primary_muscles")]
        public global::System.Collections.Generic.IList<global::Terra.StrengthMuscle>? PrimaryMuscles { get; set; }

        /// <summary>
        /// The muscles the exercise works without being the focus, as reported by the source. Kept apart from primary_muscles because the distinction drives recovery and volume-per-muscle, which merging the two would lose. Empty means the source did not say. Open enum — handle unknown values gracefully.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondary_muscles")]
        public global::System.Collections.Generic.IList<global::Terra.StrengthMuscle>? SecondaryMuscles { get; set; }

        /// <summary>
        /// Exercises sharing a value were performed together, as a superset or circuit. Unique within this activity only.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// The user's note on the exercise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Effort for the exercise as a whole, on a 0-10 scale, when the source records it once per exercise rather than per set.<br/>
        /// Example: 8.5
        /// </summary>
        /// <example>8.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rpe")]
        public double? Rpe { get; set; }

        /// <summary>
        /// Where the exercise came from. Open enum — handle unknown values gracefully; the values in use today are user_logged, device_detected and unknown. Only user_logged is user-confirmed. Test for user_logged rather than testing against device_detected, so that a value added later is not trusted by default: anything that is not user_logged may have been inferred by a wearable and may be wrong, rep counts included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Terra.StrengthSource? Source { get; set; }

        /// <summary>
        /// The performed sets, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sets")]
        public global::System.Collections.Generic.IList<global::Terra.StrengthSet>? Sets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthExercise" /> class.
        /// </summary>
        /// <param name="exerciseName">
        /// The source's own label for the exercise, passed through verbatim. Present whenever the source names the exercise, whether or not it resolved to a movement. Intended for display.<br/>
        /// Example: Close Grip Bench Press
        /// </param>
        /// <param name="movements">
        /// The joint actions performed, in the order one repetition performs them, with implement, grip, stance, tempo and position all carried in modifiers. Usually one; a clean and jerk is [clean, jerk]. This is the rollup axis, and membership is what to test: a clean and jerk belongs in both clean volume and jerk volume, so ask whether movements contains the value rather than equals it. Open enum — handle unknown values gracefully. Empty when the exercise could not be resolved, in which case exercise_name still says what the source called it.
        /// </param>
        /// <param name="target">
        /// The body part a stretch or mobility drill targets.
        /// </param>
        /// <param name="modifiers">
        /// The axes that qualify the exercise. An axis that is absent was not reported by the source — it does NOT mean a default applies, so a squat with no implement is not the same as a bodyweight squat. Axes describe the exercise as performed rather than each movement separately: in a step up to a deficit reverse lunge only the lunge is at a deficit, but the axis describes the whole exercise and exercise_name carries the detail.
        /// </param>
        /// <param name="primaryMuscles">
        /// The muscles the exercise primarily works, as reported by the source. A list because providers differ: some name exactly one, some name several for the same exercise, and some name none. Empty means the source did not say, not that no muscle is worked. Open enum — handle unknown values gracefully.
        /// </param>
        /// <param name="secondaryMuscles">
        /// The muscles the exercise works without being the focus, as reported by the source. Kept apart from primary_muscles because the distinction drives recovery and volume-per-muscle, which merging the two would lose. Empty means the source did not say. Open enum — handle unknown values gracefully.
        /// </param>
        /// <param name="groupId">
        /// Exercises sharing a value were performed together, as a superset or circuit. Unique within this activity only.<br/>
        /// Example: 1
        /// </param>
        /// <param name="notes">
        /// The user's note on the exercise.
        /// </param>
        /// <param name="rpe">
        /// Effort for the exercise as a whole, on a 0-10 scale, when the source records it once per exercise rather than per set.<br/>
        /// Example: 8.5
        /// </param>
        /// <param name="source">
        /// Where the exercise came from. Open enum — handle unknown values gracefully; the values in use today are user_logged, device_detected and unknown. Only user_logged is user-confirmed. Test for user_logged rather than testing against device_detected, so that a value added later is not trusted by default: anything that is not user_logged may have been inferred by a wearable and may be wrong, rep counts included.
        /// </param>
        /// <param name="sets">
        /// The performed sets, in order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrengthExercise(
            string? exerciseName,
            global::System.Collections.Generic.IList<global::Terra.StrengthMovement>? movements,
            global::Terra.StrengthTarget? target,
            global::Terra.StrengthExerciseModifiers? modifiers,
            global::System.Collections.Generic.IList<global::Terra.StrengthMuscle>? primaryMuscles,
            global::System.Collections.Generic.IList<global::Terra.StrengthMuscle>? secondaryMuscles,
            int? groupId,
            string? notes,
            double? rpe,
            global::Terra.StrengthSource? source,
            global::System.Collections.Generic.IList<global::Terra.StrengthSet>? sets)
        {
            this.ExerciseName = exerciseName;
            this.Movements = movements;
            this.Target = target;
            this.Modifiers = modifiers;
            this.PrimaryMuscles = primaryMuscles;
            this.SecondaryMuscles = secondaryMuscles;
            this.GroupId = groupId;
            this.Notes = notes;
            this.Rpe = rpe;
            this.Source = source;
            this.Sets = sets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthExercise" /> class.
        /// </summary>
        public StrengthExercise()
        {
        }

    }
}
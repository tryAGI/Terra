
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StrengthExerciseModifiers
    {
        /// <summary>
        /// What provides the load. Open enum — handle unknown values gracefully; the published vocabulary lists the values in use, and a value outside it must pass through rather than be rejected.<br/>
        /// Example: barbell
        /// </summary>
        /// <example>barbell</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("implement")]
        public global::Terra.StrengthImplement? Implement { get; set; }

        /// <summary>
        /// What the body is supported on, when it is not the floor. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("surface")]
        public global::Terra.StrengthSurface? Surface { get; set; }

        /// <summary>
        /// How far apart the hands are. Open enum.<br/>
        /// Example: close
        /// </summary>
        /// <example>close</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grip_width")]
        public global::Terra.StrengthGripWidth? GripWidth { get; set; }

        /// <summary>
        /// Which way the hands face. Open enum. Separate from grip_width because the two combine — a close-grip underhand pulldown needs both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grip_orientation")]
        public global::Terra.StrengthGripOrientation? GripOrientation { get; set; }

        /// <summary>
        /// Whether both limbs work together, alternately, or one at a time. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("laterality")]
        public global::Terra.StrengthLaterality? Laterality { get; set; }

        /// <summary>
        /// Foot arrangement. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stance")]
        public global::Terra.StrengthStance? Stance { get; set; }

        /// <summary>
        /// Orientation of the body or bench. Open enum.<br/>
        /// Example: incline
        /// </summary>
        /// <example>incline</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::Terra.StrengthPosition? Position { get; set; }

        /// <summary>
        /// Where the implement is carried. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bar_position")]
        public global::Terra.StrengthBarPosition? BarPosition { get; set; }

        /// <summary>
        /// How the repetition is paced. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempo")]
        public global::Terra.StrengthTempo? Tempo { get; set; }

        /// <summary>
        /// How much of the movement is performed, or where it starts. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rom")]
        public global::Terra.StrengthRangeOfMotion? Rom { get; set; }

        /// <summary>
        /// Bands or chains added to another implement — not a second implement. The reported weight_kg is the bar alone, since band tension is not expressed in kg, so this also signals that the recorded load understates the real resistance. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accommodating_resistance")]
        public string? AccommodatingResistance { get; set; }

        /// <summary>
        /// What makes the movement easier and how: machine, band, partner, balance_support. Names the source of assistance, not the fact of it. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistance")]
        public string? Assistance { get; set; }

        /// <summary>
        /// A programme or population the variant belongs to. Describes context, not a different movement, so it does not distinguish one exercise from another. Open enum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("programme")]
        public global::Terra.StrengthProgramme? Programme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthExerciseModifiers" /> class.
        /// </summary>
        /// <param name="implement">
        /// What provides the load. Open enum — handle unknown values gracefully; the published vocabulary lists the values in use, and a value outside it must pass through rather than be rejected.<br/>
        /// Example: barbell
        /// </param>
        /// <param name="surface">
        /// What the body is supported on, when it is not the floor. Open enum.
        /// </param>
        /// <param name="gripWidth">
        /// How far apart the hands are. Open enum.<br/>
        /// Example: close
        /// </param>
        /// <param name="gripOrientation">
        /// Which way the hands face. Open enum. Separate from grip_width because the two combine — a close-grip underhand pulldown needs both.
        /// </param>
        /// <param name="laterality">
        /// Whether both limbs work together, alternately, or one at a time. Open enum.
        /// </param>
        /// <param name="stance">
        /// Foot arrangement. Open enum.
        /// </param>
        /// <param name="position">
        /// Orientation of the body or bench. Open enum.<br/>
        /// Example: incline
        /// </param>
        /// <param name="barPosition">
        /// Where the implement is carried. Open enum.
        /// </param>
        /// <param name="tempo">
        /// How the repetition is paced. Open enum.
        /// </param>
        /// <param name="rom">
        /// How much of the movement is performed, or where it starts. Open enum.
        /// </param>
        /// <param name="accommodatingResistance">
        /// Bands or chains added to another implement — not a second implement. The reported weight_kg is the bar alone, since band tension is not expressed in kg, so this also signals that the recorded load understates the real resistance. Open enum.
        /// </param>
        /// <param name="assistance">
        /// What makes the movement easier and how: machine, band, partner, balance_support. Names the source of assistance, not the fact of it. Open enum.
        /// </param>
        /// <param name="programme">
        /// A programme or population the variant belongs to. Describes context, not a different movement, so it does not distinguish one exercise from another. Open enum.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StrengthExerciseModifiers(
            global::Terra.StrengthImplement? implement,
            global::Terra.StrengthSurface? surface,
            global::Terra.StrengthGripWidth? gripWidth,
            global::Terra.StrengthGripOrientation? gripOrientation,
            global::Terra.StrengthLaterality? laterality,
            global::Terra.StrengthStance? stance,
            global::Terra.StrengthPosition? position,
            global::Terra.StrengthBarPosition? barPosition,
            global::Terra.StrengthTempo? tempo,
            global::Terra.StrengthRangeOfMotion? rom,
            string? accommodatingResistance,
            string? assistance,
            global::Terra.StrengthProgramme? programme)
        {
            this.Implement = implement;
            this.Surface = surface;
            this.GripWidth = gripWidth;
            this.GripOrientation = gripOrientation;
            this.Laterality = laterality;
            this.Stance = stance;
            this.Position = position;
            this.BarPosition = barPosition;
            this.Tempo = tempo;
            this.Rom = rom;
            this.AccommodatingResistance = accommodatingResistance;
            this.Assistance = assistance;
            this.Programme = programme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StrengthExerciseModifiers" /> class.
        /// </summary>
        public StrengthExerciseModifiers()
        {
        }

    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// Summary metadata of a provider-side planned workout
    /// </summary>
    public sealed partial class PlannedWorkoutDetailsMetadata
    {
        /// <summary>
        /// Identifier of the workout on the provider's side
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Provider the workout was fetched from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Workout title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Workout description, when the provider exposes one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Numeric activity type of the workout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public int? Type { get; set; }

        /// <summary>
        /// Scheduled date (YYYY-MM-DD), matching the list item's planned_date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planned_date")]
        public string? PlannedDate { get; set; }

        /// <summary>
        /// Creation time on the provider's side (RFC 3339)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public string? CreatedDate { get; set; }

        /// <summary>
        /// Planned Training Stress Score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_tss")]
        public double? EstimatedTss { get; set; }

        /// <summary>
        /// Planned Intensity Factor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_if")]
        public double? EstimatedIf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_duration_seconds")]
        public double? EstimatedDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_distance_meters")]
        public double? EstimatedDistanceMeters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_calories")]
        public double? EstimatedCalories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_elevation_gain_meters")]
        public double? EstimatedElevationGainMeters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_energy_kj")]
        public double? EstimatedEnergyKj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_speed_meters_per_second")]
        public double? EstimatedSpeedMetersPerSecond { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool_length_meters")]
        public double? PoolLengthMeters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsMetadata" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the workout on the provider's side
        /// </param>
        /// <param name="provider">
        /// Provider the workout was fetched from
        /// </param>
        /// <param name="name">
        /// Workout title
        /// </param>
        /// <param name="description">
        /// Workout description, when the provider exposes one
        /// </param>
        /// <param name="type">
        /// Numeric activity type of the workout
        /// </param>
        /// <param name="plannedDate">
        /// Scheduled date (YYYY-MM-DD), matching the list item's planned_date
        /// </param>
        /// <param name="createdDate">
        /// Creation time on the provider's side (RFC 3339)
        /// </param>
        /// <param name="estimatedTss">
        /// Planned Training Stress Score
        /// </param>
        /// <param name="estimatedIf">
        /// Planned Intensity Factor
        /// </param>
        /// <param name="estimatedDurationSeconds"></param>
        /// <param name="estimatedDistanceMeters"></param>
        /// <param name="estimatedCalories"></param>
        /// <param name="estimatedElevationGainMeters"></param>
        /// <param name="estimatedEnergyKj"></param>
        /// <param name="estimatedSpeedMetersPerSecond"></param>
        /// <param name="poolLengthMeters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDetailsMetadata(
            string? id,
            string? provider,
            string? name,
            string? description,
            int? type,
            string? plannedDate,
            string? createdDate,
            double? estimatedTss,
            double? estimatedIf,
            double? estimatedDurationSeconds,
            double? estimatedDistanceMeters,
            double? estimatedCalories,
            double? estimatedElevationGainMeters,
            double? estimatedEnergyKj,
            double? estimatedSpeedMetersPerSecond,
            double? poolLengthMeters)
        {
            this.Id = id;
            this.Provider = provider;
            this.Name = name;
            this.Description = description;
            this.Type = type;
            this.PlannedDate = plannedDate;
            this.CreatedDate = createdDate;
            this.EstimatedTss = estimatedTss;
            this.EstimatedIf = estimatedIf;
            this.EstimatedDurationSeconds = estimatedDurationSeconds;
            this.EstimatedDistanceMeters = estimatedDistanceMeters;
            this.EstimatedCalories = estimatedCalories;
            this.EstimatedElevationGainMeters = estimatedElevationGainMeters;
            this.EstimatedEnergyKj = estimatedEnergyKj;
            this.EstimatedSpeedMetersPerSecond = estimatedSpeedMetersPerSecond;
            this.PoolLengthMeters = poolLengthMeters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsMetadata" /> class.
        /// </summary>
        public PlannedWorkoutDetailsMetadata()
        {
        }

    }
}
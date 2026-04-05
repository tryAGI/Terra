
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityMetadata
    {
        /// <summary>
        /// The City in which the workout was performed.<br/>
        /// Example: San Francisco
        /// </summary>
        /// <example>San Francisco</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The Country in which the workout was performed.<br/>
        /// Example: United States
        /// </summary>
        /// <example>United States</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The end time of the associated workout, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </summary>
        /// <example>2022-10-28T10:00:00.000000+01:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTime { get; set; }

        /// <summary>
        /// The name - either user-entered or given by the fitness data provider - of the associated workout.<br/>
        /// Example: Morning Run
        /// </summary>
        /// <example>Morning Run</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The start time of the associated workout, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>1999-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTime { get; set; }

        /// <summary>
        /// The State in which the workout was performed.<br/>
        /// Example: California
        /// </summary>
        /// <example>California</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// A unique identifier for the workout - note that this is unique for the given user, and may not be globally unique.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SummaryId { get; set; }

        /// <summary>
        /// Indicates whether the timestamps in this payload are localized (LOCAL) or in UTC.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_localization")]
        public double? TimestampLocalization { get; set; }

        /// <summary>
        /// The type of activity performed for the associated workout.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Type { get; set; }

        /// <summary>
        /// The type of upload for the associated workout, providing information on how the workout data was recorded or entered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UploadType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMetadata" /> class.
        /// </summary>
        /// <param name="endTime">
        /// The end time of the associated workout, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-10-28T10:00:00.000000+01:00
        /// </param>
        /// <param name="startTime">
        /// The start time of the associated workout, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 1999-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="summaryId">
        /// A unique identifier for the workout - note that this is unique for the given user, and may not be globally unique.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="type">
        /// The type of activity performed for the associated workout.
        /// </param>
        /// <param name="uploadType">
        /// The type of upload for the associated workout, providing information on how the workout data was recorded or entered
        /// </param>
        /// <param name="city">
        /// The City in which the workout was performed.<br/>
        /// Example: San Francisco
        /// </param>
        /// <param name="country">
        /// The Country in which the workout was performed.<br/>
        /// Example: United States
        /// </param>
        /// <param name="name">
        /// The name - either user-entered or given by the fitness data provider - of the associated workout.<br/>
        /// Example: Morning Run
        /// </param>
        /// <param name="state">
        /// The State in which the workout was performed.<br/>
        /// Example: California
        /// </param>
        /// <param name="timestampLocalization">
        /// Indicates whether the timestamps in this payload are localized (LOCAL) or in UTC.<br/>
        /// Example: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityMetadata(
            string endTime,
            string startTime,
            string summaryId,
            double type,
            double uploadType,
            string? city,
            string? country,
            string? name,
            string? state,
            double? timestampLocalization)
        {
            this.City = city;
            this.Country = country;
            this.EndTime = endTime ?? throw new global::System.ArgumentNullException(nameof(endTime));
            this.Name = name;
            this.StartTime = startTime ?? throw new global::System.ArgumentNullException(nameof(startTime));
            this.State = state;
            this.SummaryId = summaryId ?? throw new global::System.ArgumentNullException(nameof(summaryId));
            this.TimestampLocalization = timestampLocalization;
            this.Type = type;
            this.UploadType = uploadType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMetadata" /> class.
        /// </summary>
        public ActivityMetadata()
        {
        }
    }
}
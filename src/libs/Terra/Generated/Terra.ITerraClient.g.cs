
#nullable enable

namespace Terra
{
    /// <summary>
    /// The Terra API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITerraClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ActivityClient Activity { get; }

        /// <summary>
        /// 
        /// </summary>
        public AthleteClient Athlete { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuthenticationClient Authentication { get; }

        /// <summary>
        /// 
        /// </summary>
        public BodyClient Body { get; }

        /// <summary>
        /// 
        /// </summary>
        public DailyClient Daily { get; }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsClient Integrations { get; }

        /// <summary>
        /// 
        /// </summary>
        public MenstruationClient Menstruation { get; }

        /// <summary>
        /// 
        /// </summary>
        public NutritionClient Nutrition { get; }

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutClient PlannedWorkout { get; }

        /// <summary>
        /// 
        /// </summary>
        public SleepClient Sleep { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

    }
}
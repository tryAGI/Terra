
#nullable enable

namespace Terra
{
    /// <summary>
    /// The Terra API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class TerraClient : global::Terra.ITerraClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.tryterra.co/v2";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Terra.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Terra.JsonConverters.NoDataReturnedStatusJsonConverter(),
                    new global::Terra.JsonConverters.NoDataReturnedStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.CadencePlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.CadencePlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.HRPlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.HRPlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PowerPlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.PowerPlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.SpeedPlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.SpeedPlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PacePlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.PacePlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.TSSPlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.TSSPlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.IFPlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.IFPlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.RepetitionPlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.RepetitionPlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.SwimStrokePlannedWorkoutStepTargetTargetTypeJsonConverter(),
                    new global::Terra.JsonConverters.SwimStrokePlannedWorkoutStepTargetTargetTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepTargetsDiscriminatorTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepTargetsDiscriminatorTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.TimePlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.TimePlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PowerAbovePlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.PowerAbovePlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PowerBelowPlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.PowerBelowPlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.FixedRestPlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.FixedRestPlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.CaloriesPlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.CaloriesPlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.HRAbovePlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.HRAbovePlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.HRBelowPlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.HRBelowPlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.RepsPlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.RepsPlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.DistancePlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.DistancePlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.StepsPlannedWorkoutStepDurationDurationTypeJsonConverter(),
                    new global::Terra.JsonConverters.StepsPlannedWorkoutStepDurationDurationTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepDurationsDiscriminatorTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepDurationsDiscriminatorTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepIntensityJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepIntensityNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutRepeatStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutRepeatStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.SwimmingPlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.SwimmingPlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.SwimmingPlannedWorkoutStepEquipmentTypeJsonConverter(),
                    new global::Terra.JsonConverters.SwimmingPlannedWorkoutStepEquipmentTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.SwimmingPlannedWorkoutStepStrokeTypeJsonConverter(),
                    new global::Terra.JsonConverters.SwimmingPlannedWorkoutStepStrokeTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.CardioPlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.CardioPlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.CardioPlannedWorkoutStepExerciseCategoryJsonConverter(),
                    new global::Terra.JsonConverters.CardioPlannedWorkoutStepExerciseCategoryNullableJsonConverter(),
                    new global::Terra.JsonConverters.StrengthPlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.StrengthPlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.StrengthPlannedWorkoutStepExerciseCategoryJsonConverter(),
                    new global::Terra.JsonConverters.StrengthPlannedWorkoutStepExerciseCategoryNullableJsonConverter(),
                    new global::Terra.JsonConverters.YogaPlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.YogaPlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PilatesPlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.PilatesPlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.RunningPlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.RunningPlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.CyclingPlannedWorkoutStepTypeJsonConverter(),
                    new global::Terra.JsonConverters.CyclingPlannedWorkoutStepTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepsDiscriminatorTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepsDiscriminatorTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutMetadataTypeJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutMetadataTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.DeviceDataTypeJsonConverter(),
                    new global::Terra.JsonConverters.DeviceDataTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.StrokeTypeJsonConverter(),
                    new global::Terra.JsonConverters.StrokeTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.LargeRequestProcessingEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.LargeRequestProcessingEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.LargeRequestProcessingEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.LargeRequestProcessingEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.MenstrualPhaseJsonConverter(),
                    new global::Terra.JsonConverters.MenstrualPhaseNullableJsonConverter(),
                    new global::Terra.JsonConverters.HealthcheckEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.HealthcheckEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.AuthEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthSuccessEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.AuthSuccessEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthErrorEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.AuthErrorEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.DeauthEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.DeauthEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.DeauthEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.DeauthEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.UserReauthEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.UserReauthEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.UserReauthEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.UserReauthEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.AccessRevokedEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.AccessRevokedEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.AccessRevokedEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.AccessRevokedEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.ConnectionErrorEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.ConnectionErrorEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.ConnectionErrorEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.ConnectionErrorEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.GoogleNoDatasourceEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.GoogleNoDatasourceEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.GoogleNoDatasourceEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.GoogleNoDatasourceEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.ProcessingEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.ProcessingEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.ProcessingEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.ProcessingEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.LargeRequestSendingEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.LargeRequestSendingEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.RateLimitHitEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.RateLimitHitEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.S3PayloadEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.S3PayloadEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.S3PayloadEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.S3PayloadEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.ActivityEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.ActivityEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.AthleteEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.AthleteEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.NutritionEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.NutritionEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.DailyEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.DailyEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.SleepEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.SleepEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.MenstruationEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.MenstruationEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.BodyEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.BodyEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PermissionChangeEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.PermissionChangeEventTypeNullableJsonConverter(),
                    new global::Terra.JsonConverters.PermissionChangeEventStatusJsonConverter(),
                    new global::Terra.JsonConverters.PermissionChangeEventStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus3JsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus3NullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.UserModifyUserResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.UserModifyUserResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.UserModifyUserResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.UserModifyUserResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.ActivityFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.ActivityFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.ActivityFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.ActivityFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.ActivityWriteResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.ActivityWriteResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.ActivityWriteResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.ActivityWriteResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.AthleteFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.AthleteFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.AthleteFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.AthleteFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.BodyFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.BodyFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.BodyFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.BodyFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.BodyWriteResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.BodyWriteResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.BodyWriteResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.BodyWriteResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.BodyDeleteResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.BodyDeleteResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.BodyDeleteResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.BodyDeleteResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.DailyFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.DailyFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.DailyFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.DailyFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.MenstruationFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.MenstruationFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.MenstruationFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.MenstruationFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.NutritionFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.NutritionFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.NutritionFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.NutritionFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.NutritionWriteResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.NutritionWriteResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.NutritionWriteResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.NutritionWriteResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.NutritionDeleteResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.NutritionDeleteResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.NutritionDeleteResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.NutritionDeleteResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.SleepFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.SleepFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.SleepFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.SleepFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus3JsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus3NullableJsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus3JsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus3NullableJsonConverter(),
                    new global::Terra.JsonConverters.UserGetAllUserIDsResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.UserGetAllUserIDsResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatus2JsonConverter(),
                    new global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatus2NullableJsonConverter(),
                    new global::Terra.JsonConverters.IntegrationsFetchResponseStatusJsonConverter(),
                    new global::Terra.JsonConverters.IntegrationsFetchResponseStatusNullableJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepTargetsJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepDurationsJsonConverter(),
                    new global::Terra.JsonConverters.PlannedWorkoutStepsJsonConverter(),
                    new global::Terra.JsonConverters.WebhookEventTypeJsonConverter(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.ActivityFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.AthleteCollection, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.BodyFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.DailyFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.MenstruationFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.NutritionFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.SleepFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.PlannedWorkoutFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>(),
                    new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.UserGetAllUserIDsResponseVariant1, global::Terra.UserGetAllUserIDsResponseVariant2>(),
                    new global::Terra.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public ActivityClient Activity => new ActivityClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AthleteClient Athlete => new AthleteClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuthenticationClient Authentication => new AuthenticationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BodyClient Body => new BodyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DailyClient Daily => new DailyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsClient Integrations => new IntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MenstruationClient Menstruation => new MenstruationClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public NutritionClient Nutrition => new NutritionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutClient PlannedWorkout => new PlannedWorkoutClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SleepClient Sleep => new SleepClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the TerraClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public TerraClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Terra.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Terra.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}
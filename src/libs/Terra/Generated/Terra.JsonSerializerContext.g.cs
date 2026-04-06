
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Terra.JsonConverters.NoDataReturnedStatusJsonConverter),

            typeof(global::Terra.JsonConverters.NoDataReturnedStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.CadencePlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.CadencePlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.HRPlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.HRPlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PowerPlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PowerPlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.SpeedPlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.SpeedPlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PacePlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PacePlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.TSSPlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.TSSPlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.IFPlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.IFPlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.RepetitionPlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.RepetitionPlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokePlannedWorkoutStepTargetTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokePlannedWorkoutStepTargetTargetTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepTargetsDiscriminatorTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepTargetsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.TimePlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.TimePlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PowerAbovePlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PowerAbovePlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PowerBelowPlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PowerBelowPlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.FixedRestPlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.FixedRestPlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.CaloriesPlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.CaloriesPlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.HRAbovePlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.HRAbovePlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.HRBelowPlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.HRBelowPlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.RepsPlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.RepsPlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.DistancePlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.DistancePlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.StepsPlannedWorkoutStepDurationDurationTypeJsonConverter),

            typeof(global::Terra.JsonConverters.StepsPlannedWorkoutStepDurationDurationTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepDurationsDiscriminatorTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepDurationsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepIntensityJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepIntensityNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutRepeatStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutRepeatStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepEquipmentTypeJsonConverter),

            typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepEquipmentTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepStrokeTypeJsonConverter),

            typeof(global::Terra.JsonConverters.SwimmingPlannedWorkoutStepStrokeTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.CardioPlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.CardioPlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.CardioPlannedWorkoutStepExerciseCategoryJsonConverter),

            typeof(global::Terra.JsonConverters.CardioPlannedWorkoutStepExerciseCategoryNullableJsonConverter),

            typeof(global::Terra.JsonConverters.StrengthPlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.StrengthPlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.StrengthPlannedWorkoutStepExerciseCategoryJsonConverter),

            typeof(global::Terra.JsonConverters.StrengthPlannedWorkoutStepExerciseCategoryNullableJsonConverter),

            typeof(global::Terra.JsonConverters.YogaPlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.YogaPlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PilatesPlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PilatesPlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.RunningPlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.RunningPlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.CyclingPlannedWorkoutStepTypeJsonConverter),

            typeof(global::Terra.JsonConverters.CyclingPlannedWorkoutStepTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepsDiscriminatorTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepsDiscriminatorTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutMetadataTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutMetadataTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.DeviceDataTypeJsonConverter),

            typeof(global::Terra.JsonConverters.DeviceDataTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.StrokeTypeJsonConverter),

            typeof(global::Terra.JsonConverters.StrokeTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.MenstrualPhaseJsonConverter),

            typeof(global::Terra.JsonConverters.MenstrualPhaseNullableJsonConverter),

            typeof(global::Terra.JsonConverters.HealthcheckEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.HealthcheckEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.AuthEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthSuccessEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthSuccessEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthErrorEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthErrorEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.DeauthEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.DeauthEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.DeauthEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.DeauthEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserReauthEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.UserReauthEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserReauthEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.UserReauthEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AccessRevokedEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.AccessRevokedEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AccessRevokedEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AccessRevokedEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.GoogleNoDatasourceEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.GoogleNoDatasourceEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.GoogleNoDatasourceEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.GoogleNoDatasourceEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ProcessingEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.ProcessingEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ProcessingEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.ProcessingEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestSendingEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestSendingEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.RateLimitHitEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.RateLimitHitEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.S3PayloadEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.S3PayloadEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.S3PayloadEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.S3PayloadEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AthleteEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.AthleteEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.DailyEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.DailyEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.SleepEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.SleepEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.MenstruationEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.MenstruationEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.BodyEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.BodyEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PermissionChangeEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PermissionChangeEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PermissionChangeEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.PermissionChangeEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus3JsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatus3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserModifyUserResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.UserModifyUserResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserModifyUserResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.UserModifyUserResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.ActivityFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityWriteResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityWriteResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ActivityWriteResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.ActivityWriteResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.AthleteFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AthleteFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AthleteFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.AthleteFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.BodyFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.BodyFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.BodyFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.BodyFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.BodyWriteResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.BodyWriteResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.BodyWriteResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.BodyWriteResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.BodyDeleteResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.BodyDeleteResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.BodyDeleteResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.BodyDeleteResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.DailyFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.DailyFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.DailyFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.DailyFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.MenstruationFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.MenstruationFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.MenstruationFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.MenstruationFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.NutritionFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionWriteResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionWriteResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionWriteResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.NutritionWriteResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionDeleteResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionDeleteResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.NutritionDeleteResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.NutritionDeleteResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SleepFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.SleepFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.SleepFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.SleepFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutWriteResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutFetchResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus3JsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutDeleteResponseStatus3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus3JsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatus3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetAllUserIDsResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetAllUserIDsResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatus2JsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForMultipleUserIDsResponseStatus2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.IntegrationsFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.IntegrationsFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepTargetsJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepDurationsJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutStepsJsonConverter),

            typeof(global::Terra.JsonConverters.WebhookEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.ActivityFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.AthleteCollection, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.BodyFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.DailyFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.MenstruationFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.NutritionFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.SleepFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.PlannedWorkoutFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.UserGetAllUserIDsResponseVariant1, global::Terra.UserGetAllUserIDsResponseVariant2>),

            typeof(global::Terra.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WidgetSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TerraUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NoDataReturned))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NoDataReturnedStatus), TypeInfoPropertyName = "NoDataReturnedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RequestProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RateLimitRequestProcessing))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Activity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActiveDurationsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CaloriesData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeviceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DistanceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnergyData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LapData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.METData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MovementData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OxygenData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PolylineMapData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PositionData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrainData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TSSData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Athlete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DeviceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Body))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BloodPressureData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HydrationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.KetoneData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MeasurementsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TemperatureData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.GlucoseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Daily))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyDataEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyDistanceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ScoresData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StressData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TagData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Menstruation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Nutrition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DrinkSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrinkSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Meal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Meal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Sleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepDataEnrichment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReadinessData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RespirationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepScores))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepDurationsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepTemperatureData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "PlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CadencePlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CadencePlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "CadencePlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HRPlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HRPlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "HRPlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerPlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerPlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "PowerPlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SpeedPlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SpeedPlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "SpeedPlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PacePlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PacePlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "PacePlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TSSPlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TSSPlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "TSSPlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IFPlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IFPlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "IFPlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RepetitionPlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RepetitionPlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "RepetitionPlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokePlannedWorkoutStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokePlannedWorkoutStepTargetTargetType), TypeInfoPropertyName = "SwimStrokePlannedWorkoutStepTargetTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepTargets), TypeInfoPropertyName = "PlannedWorkoutStepTargets2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepTargetsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepTargetsDiscriminatorType), TypeInfoPropertyName = "PlannedWorkoutStepTargetsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "PlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TimePlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TimePlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "TimePlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerAbovePlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerAbovePlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "PowerAbovePlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerBelowPlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerBelowPlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "PowerBelowPlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.FixedRestPlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.FixedRestPlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "FixedRestPlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CaloriesPlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CaloriesPlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "CaloriesPlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HRAbovePlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HRAbovePlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "HRAbovePlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HRBelowPlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HRBelowPlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "HRBelowPlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RepsPlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RepsPlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "RepsPlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DistancePlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DistancePlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "DistancePlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepsPlannedWorkoutStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepsPlannedWorkoutStepDurationDurationType), TypeInfoPropertyName = "StepsPlannedWorkoutStepDurationDurationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepDurations), TypeInfoPropertyName = "PlannedWorkoutStepDurations2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepDurationsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepDurationsDiscriminatorType), TypeInfoPropertyName = "PlannedWorkoutStepDurationsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTargets>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepType), TypeInfoPropertyName = "PlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepIntensity), TypeInfoPropertyName = "PlannedWorkoutStepIntensity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepDurations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutRepeatStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutRepeatStepType), TypeInfoPropertyName = "PlannedWorkoutRepeatStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutStepDuration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimmingPlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimmingPlannedWorkoutStepType), TypeInfoPropertyName = "SwimmingPlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimmingPlannedWorkoutStepEquipmentType), TypeInfoPropertyName = "SwimmingPlannedWorkoutStepEquipmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimmingPlannedWorkoutStepStrokeType), TypeInfoPropertyName = "SwimmingPlannedWorkoutStepStrokeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CardioPlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CardioPlannedWorkoutStepType), TypeInfoPropertyName = "CardioPlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CardioPlannedWorkoutStepExerciseCategory), TypeInfoPropertyName = "CardioPlannedWorkoutStepExerciseCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPlannedWorkoutStepType), TypeInfoPropertyName = "StrengthPlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPlannedWorkoutStepExerciseCategory), TypeInfoPropertyName = "StrengthPlannedWorkoutStepExerciseCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.YogaPlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.YogaPlannedWorkoutStepType), TypeInfoPropertyName = "YogaPlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PilatesPlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PilatesPlannedWorkoutStepType), TypeInfoPropertyName = "PilatesPlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RunningPlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RunningPlannedWorkoutStepType), TypeInfoPropertyName = "RunningPlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CyclingPlannedWorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CyclingPlannedWorkoutStepType), TypeInfoPropertyName = "CyclingPlannedWorkoutStepType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutSteps), TypeInfoPropertyName = "PlannedWorkoutSteps2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutStepsDiscriminatorType), TypeInfoPropertyName = "PlannedWorkoutStepsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutMetadataType), TypeInfoPropertyName = "PlannedWorkoutMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutSteps>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ProcessingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthSuccessEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.GoogleNoDatasourceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestSendingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthcheckEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RateLimitHitEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.S3PayloadEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.IntegrationProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationProviderTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhookEventType), TypeInfoPropertyName = "WebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityLevelSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.ActivityLevelSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CalorieSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.CalorieSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeviceDataType), TypeInfoPropertyName = "DeviceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OtherDeviceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DeviceDataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.OtherDeviceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DistanceSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ElevationSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.FloorsClimbedSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DistanceDataDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DistanceSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.ElevationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.FloorsClimbedSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StepSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ElevationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimmingData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DistanceDataSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateDataSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateVariabilityDataSampleRMSSD))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateVariabilityDataSampleSDNN))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateDataDetailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleRMSSD>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleSDNN>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateZoneData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HeartRateDataSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HeartRateZoneData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrokeType), TypeInfoPropertyName = "StrokeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LapSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LapSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.METSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.METSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CadenceSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SpeedSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TorqueSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.CadenceSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.SpeedSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TorqueSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OxygenSaturationSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Vo2MaxSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.OxygenSaturationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Vo2MaxSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PositionSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PositionSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PowerSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PowerSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TSSSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TSSSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhookEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEventType), TypeInfoPropertyName = "LargeRequestProcessingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEventStatus), TypeInfoPropertyName = "LargeRequestProcessingEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BloodPressureSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.BloodPressureSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AFibClassificationSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RawECGSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ECGReading))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.RawECGSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PulseVelocitySample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RRIntervalSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.AFibClassificationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.ECGReading>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PulseVelocitySample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.RRIntervalSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HydrationMeasurementSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HydrationMeasurementSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.KetoneSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.KetoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MeasurementDataSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.MeasurementDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TemperatureSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TemperatureSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.GlucoseDataSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyPatternSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.GlucoseDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DailyPatternSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataContributor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DataContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StressSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyBatterySample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StressSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.BodyBatterySample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TagEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TagEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstrualPhase), TypeInfoPropertyName = "MenstrualPhase2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFlowSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.MenstruationFlowSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionMicros))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionQuantity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionMacros))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BreathSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BreathsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.BreathSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OxygenSaturationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SnoringSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SnoringData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.SnoringSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AsleepDurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AwakeDurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepHypnogramSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OtherSleepDurations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.SleepHypnogramSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthcheckEventType), TypeInfoPropertyName = "HealthcheckEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthEventType), TypeInfoPropertyName = "AuthEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthSuccessEventStatus), TypeInfoPropertyName = "AuthSuccessEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthErrorEventStatus), TypeInfoPropertyName = "AuthErrorEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEventType), TypeInfoPropertyName = "DeauthEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEventStatus), TypeInfoPropertyName = "DeauthEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEventType), TypeInfoPropertyName = "UserReauthEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEventStatus), TypeInfoPropertyName = "UserReauthEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEventType), TypeInfoPropertyName = "AccessRevokedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEventStatus), TypeInfoPropertyName = "AccessRevokedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEventType), TypeInfoPropertyName = "ConnectionErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEventStatus), TypeInfoPropertyName = "ConnectionErrorEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.GoogleNoDatasourceEventType), TypeInfoPropertyName = "GoogleNoDatasourceEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.GoogleNoDatasourceEventStatus), TypeInfoPropertyName = "GoogleNoDatasourceEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ProcessingEventType), TypeInfoPropertyName = "ProcessingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ProcessingEventStatus), TypeInfoPropertyName = "ProcessingEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestSendingEventType), TypeInfoPropertyName = "LargeRequestSendingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RateLimitHitEventType), TypeInfoPropertyName = "RateLimitHitEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.S3PayloadEventType), TypeInfoPropertyName = "S3PayloadEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.S3PayloadEventStatus), TypeInfoPropertyName = "S3PayloadEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityEventType), TypeInfoPropertyName = "ActivityEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Activity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteEventType), TypeInfoPropertyName = "AthleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionEventType), TypeInfoPropertyName = "NutritionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Nutrition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyEventType), TypeInfoPropertyName = "DailyEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Daily>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepEventType), TypeInfoPropertyName = "SleepEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationEventType), TypeInfoPropertyName = "MenstruationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Menstruation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyEventType), TypeInfoPropertyName = "BodyEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Body>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEventType), TypeInfoPropertyName = "PermissionChangeEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEventStatus), TypeInfoPropertyName = "PermissionChangeEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserModifyUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutWriteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<int?, global::System.DateTime?>), TypeInfoPropertyName = "OneOfInt32DateTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus), TypeInfoPropertyName = "AuthenticationAuthenticateUserResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus2), TypeInfoPropertyName = "AuthenticationAuthenticateUserResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus3), TypeInfoPropertyName = "AuthenticationAuthenticateUserResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus), TypeInfoPropertyName = "AuthenticationGenerateWidgetSessionResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus2), TypeInfoPropertyName = "AuthenticationGenerateWidgetSessionResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserModifyUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserModifyUserResponseStatus), TypeInfoPropertyName = "UserModifyUserResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserModifyUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserModifyUserResponseStatus2), TypeInfoPropertyName = "UserModifyUserResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus), TypeInfoPropertyName = "AuthenticationDeauthenticateUserResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus2), TypeInfoPropertyName = "AuthenticationDeauthenticateUserResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateAuthTokenResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.ActivityFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>), TypeInfoPropertyName = "LargeRequestProcessingEvent_160e490f67b5f8bd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityFetchResponseStatus), TypeInfoPropertyName = "ActivityFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityFetchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityFetchResponseStatus2), TypeInfoPropertyName = "ActivityFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityWriteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityWriteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityWriteResponseStatus), TypeInfoPropertyName = "ActivityWriteResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityWriteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityWriteResponseStatus2), TypeInfoPropertyName = "ActivityWriteResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfAthleteCollectionNoDataReturnedDataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteFetchResponseStatus), TypeInfoPropertyName = "AthleteFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteFetchResponseStatus2), TypeInfoPropertyName = "AthleteFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.BodyFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>), TypeInfoPropertyName = "LargeRequestProcessingEvent_859eb0d6d287fa1e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyFetchResponseStatus), TypeInfoPropertyName = "BodyFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyFetchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyFetchResponseStatus2), TypeInfoPropertyName = "BodyFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyWriteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyWriteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyWriteResponseStatus), TypeInfoPropertyName = "BodyWriteResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyWriteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyWriteResponseStatus2), TypeInfoPropertyName = "BodyWriteResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.BodyDeleteResponseProcessedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponseProcessedDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.BodyDeleteResponseProcessedDataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponseProcessedDataItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponseStatus), TypeInfoPropertyName = "BodyDeleteResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyDeleteResponseStatus2), TypeInfoPropertyName = "BodyDeleteResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.DailyFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>), TypeInfoPropertyName = "LargeRequestProcessingEvent_71739c85a1a0e61f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyFetchResponseStatus), TypeInfoPropertyName = "DailyFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyFetchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyFetchResponseStatus2), TypeInfoPropertyName = "DailyFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.MenstruationFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>), TypeInfoPropertyName = "LargeRequestProcessingEvent_44c5bbf6d5c3495e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFetchResponseStatus), TypeInfoPropertyName = "MenstruationFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFetchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFetchResponseStatus2), TypeInfoPropertyName = "MenstruationFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.NutritionFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>), TypeInfoPropertyName = "LargeRequestProcessingEvent_2f9c54c640e61d2d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionFetchResponseStatus), TypeInfoPropertyName = "NutritionFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionFetchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionFetchResponseStatus2), TypeInfoPropertyName = "NutritionFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionWriteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionWriteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionWriteResponseStatus), TypeInfoPropertyName = "NutritionWriteResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionWriteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionWriteResponseStatus2), TypeInfoPropertyName = "NutritionWriteResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.NutritionDeleteResponseProcessedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponseProcessedDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.NutritionDeleteResponseProcessedDataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponseProcessedDataItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponseStatus), TypeInfoPropertyName = "NutritionDeleteResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionDeleteResponseStatus2), TypeInfoPropertyName = "NutritionDeleteResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.SleepFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook, global::Terra.RequestProcessing, global::Terra.RateLimitRequestProcessing, global::Terra.LargeRequestProcessingEvent>), TypeInfoPropertyName = "LargeRequestProcessingEvent_18a68eb15e2dbc91")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepFetchResponseStatus), TypeInfoPropertyName = "SleepFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepFetchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepFetchResponseStatus2), TypeInfoPropertyName = "SleepFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutWriteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutWriteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutWriteResponseStatus), TypeInfoPropertyName = "PlannedWorkoutWriteResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutWriteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutWriteResponseStatus2), TypeInfoPropertyName = "PlannedWorkoutWriteResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.PlannedWorkoutFetchResponse2, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfPlannedWorkoutFetchResponse2NoDataReturnedDataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutFetchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutFetchResponseStatus), TypeInfoPropertyName = "PlannedWorkoutFetchResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutFetchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutFetchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutFetchResponseStatus2), TypeInfoPropertyName = "PlannedWorkoutFetchResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDeleteResponseProcessedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponseProcessedDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponseProcessedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponseStatus), TypeInfoPropertyName = "PlannedWorkoutDeleteResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponseStatus2), TypeInfoPropertyName = "PlannedWorkoutDeleteResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDeleteResponseStatus3), TypeInfoPropertyName = "PlannedWorkoutDeleteResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>), TypeInfoPropertyName = "OneOfUserGetInfoForUserIDResponse2IListTerraUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponseStatus), TypeInfoPropertyName = "UserGetInfoForUserIDResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TerraUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponseStatus2), TypeInfoPropertyName = "UserGetInfoForUserIDResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponseStatus3), TypeInfoPropertyName = "UserGetInfoForUserIDResponseStatus32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetAllUserIDsResponseVariant1, global::Terra.UserGetAllUserIDsResponseVariant2>), TypeInfoPropertyName = "OneOfUserGetAllUserIDsResponseVariant1UserGetAllUserIDsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponseVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponseStatus), TypeInfoPropertyName = "UserGetAllUserIDsResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForMultipleUserIDsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForMultipleUserIDsResponseStatus), TypeInfoPropertyName = "UserGetInfoForMultipleUserIDsResponseStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForMultipleUserIDsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForMultipleUserIDsResponseStatus2), TypeInfoPropertyName = "UserGetInfoForMultipleUserIDsResponseStatus22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsFetchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsFetchResponseStatus), TypeInfoPropertyName = "IntegrationsFetchResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DeviceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DrinkSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Meal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutStepTargets>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutStepDurations>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutStepTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutStepDuration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutSteps>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.IntegrationProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.ActivityLevelSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.CalorieSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DeviceDataType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.OtherDeviceData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DistanceSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.ElevationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.FloorsClimbedSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StepSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateVariabilityDataSampleRMSSD>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateVariabilityDataSampleSDNN>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HeartRateZoneData>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LapSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.METSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.CadenceSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SpeedSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TorqueSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.OxygenSaturationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Vo2MaxSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PositionSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PowerSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TSSSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BloodPressureSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.RawECGSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.AFibClassificationSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.ECGReading>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PulseVelocitySample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.RRIntervalSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HydrationMeasurementSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.KetoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.MeasurementDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TemperatureSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.GlucoseDataSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DailyPatternSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DataContributor>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StressSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BodyBatterySample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TagEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.MenstruationFlowSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BreathSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SnoringSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SleepHypnogramSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Activity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Nutrition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Daily>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Menstruation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Body>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BodyDeleteResponseProcessedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BodyDeleteResponseProcessedDataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.NutritionDeleteResponseProcessedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.NutritionDeleteResponseProcessedDataItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutDeleteResponseProcessedDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.List<global::Terra.TerraUser>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TerraUser>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
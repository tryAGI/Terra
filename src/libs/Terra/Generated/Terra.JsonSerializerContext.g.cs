
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
            typeof(global::Terra.JsonConverters.DataSentToWebhookStatusJsonConverter),

            typeof(global::Terra.JsonConverters.DataSentToWebhookStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.DeviceDataTypeJsonConverter),

            typeof(global::Terra.JsonConverters.DeviceDataTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant4JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant4NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant5JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant5NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant6JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant6NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant7JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant7NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant8JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant8NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant9JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant9NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant10JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant10NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant11JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant11NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant12JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant12NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant13JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant13NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant14JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant14NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant15JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportVariant15NullableJsonConverter),

            typeof(global::Terra.JsonConverters.EnvironmentTypeVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.EnvironmentTypeVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.EnvironmentTypeVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.EnvironmentTypeVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.EnvironmentTypeVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.EnvironmentTypeVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant4JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant4NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant5JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant5NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant6JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant6NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant7JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant7NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant8JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant8NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant9JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant9NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant10JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant10NullableJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant11JsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeVariant11NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant4JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant4NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant5JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant5NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant6JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant6NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant7JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant7NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant8JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant8NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant9JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant9NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant10JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant10NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant11JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeVariant11NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant4JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant4NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant5JsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityVariant5NullableJsonConverter),

            typeof(global::Terra.JsonConverters.StepControlTypeVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.StepControlTypeVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.StepControlTypeVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.StepControlTypeVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WeightUnitVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.WeightUnitVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.WeightUnitVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.WeightUnitVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant4JsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant4NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant5JsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant5NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant6JsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant6NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant7JsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeVariant7NullableJsonConverter),

            typeof(global::Terra.JsonConverters.DrillTypeVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.DrillTypeVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.DrillTypeVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.DrillTypeVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.DrillTypeVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.DrillTypeVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant1JsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant1NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant2JsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant2NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant3JsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant3NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant4JsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant4NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant5JsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant5NullableJsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant6JsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeVariant6NullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthSuccessEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.AuthSuccessEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthSuccessEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthSuccessEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthErrorEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.AuthErrorEventTypeNullableJsonConverter),

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

            typeof(global::Terra.JsonConverters.PermissionChangeEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PermissionChangeEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.PermissionChangeEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.PermissionChangeEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.ConnectionErrorEventStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestSendingEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestSendingEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventStatusJsonConverter),

            typeof(global::Terra.JsonConverters.LargeRequestProcessingEventStatusNullableJsonConverter),

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

            typeof(global::Terra.JsonConverters.PlannedWorkoutEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.PlannedWorkoutEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.HormoneEventTypeJsonConverter),

            typeof(global::Terra.JsonConverters.HormoneEventTypeNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutsCreateWorkoutResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutsCreateWorkoutResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutsPlanWorkoutResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutsPlanWorkoutResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.UserGetInfoForUserIDResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.WebhooksResendPayloadResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.WebhooksResendPayloadResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.IntegrationsFetchResponseStatusJsonConverter),

            typeof(global::Terra.JsonConverters.IntegrationsFetchResponseStatusNullableJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutSportJsonConverter),

            typeof(global::Terra.JsonConverters.EnvironmentTypeJsonConverter),

            typeof(global::Terra.JsonConverters.CompletionConditionTypeJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepTargetTypeJsonConverter),

            typeof(global::Terra.JsonConverters.WorkoutStepIntensityJsonConverter),

            typeof(global::Terra.JsonConverters.StepControlTypeJsonConverter),

            typeof(global::Terra.JsonConverters.WeightUnitJsonConverter),

            typeof(global::Terra.JsonConverters.SwimStrokeTypeJsonConverter),

            typeof(global::Terra.JsonConverters.DrillTypeJsonConverter),

            typeof(global::Terra.JsonConverters.SwimEquipmentTypeJsonConverter),

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

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.ActivityFetchResponse2, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.BodyFetchResponse2, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.DailyFetchResponse2, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.MenstruationFetchResponse2, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.NutritionFetchResponse2, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.SleepFetchResponse2, global::Terra.DataSentToWebhook>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>),

            typeof(global::Terra.JsonConverters.AllOfJsonConverter<global::Terra.TerraUser, global::Terra.UserGetInfoForUserIDResponseUser>),

            typeof(global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.UserGetAllUserIDsResponseVariant1, global::Terra.UserGetAllUserIDsResponseVariant2>),

            typeof(global::Terra.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSport), TypeInfoPropertyName = "WorkoutSport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StepBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Problem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WidgetSessionParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TerraUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhookStatus), TypeInfoPropertyName = "DataSentToWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhookUser))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyDataEnrichment2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyDistanceData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ScoresData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StressData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TagData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Menstruation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HormoneSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Connection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Nutrition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.DrinkSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrinkSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.Meal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Meal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionSummary2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.Sleep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepDataEnrichment2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ReadinessData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RespirationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepScores2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepDurationsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepTemperatureData2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthSuccessEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestSendingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.S3PayloadEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HormoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.IntegrationProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationProviderTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhookEventType), TypeInfoPropertyName = "WebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportReprocessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportStatusEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportStatusEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportPanel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportPanel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportResultSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportBiomarker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportMeasurement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportInterpretation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportReferenceRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportReferenceRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportBoundedValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportQualitativeValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportAppliedRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportRangeContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportDeliveriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportDelivery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFilesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportArtifactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityLevelSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.ActivityLevelSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CalorieSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.CalorieSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.RecordFloat))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StressSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyBatterySample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StressSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.BodyBatterySample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.TagEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TagEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFlowSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationIntervalSample))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.MenstruationFlowSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.MenstruationIntervalSample>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant1), TypeInfoPropertyName = "WorkoutSportVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant2), TypeInfoPropertyName = "WorkoutSportVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant3), TypeInfoPropertyName = "WorkoutSportVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant4), TypeInfoPropertyName = "WorkoutSportVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant5), TypeInfoPropertyName = "WorkoutSportVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant6), TypeInfoPropertyName = "WorkoutSportVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant7), TypeInfoPropertyName = "WorkoutSportVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant8), TypeInfoPropertyName = "WorkoutSportVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant9), TypeInfoPropertyName = "WorkoutSportVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant10), TypeInfoPropertyName = "WorkoutSportVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant11), TypeInfoPropertyName = "WorkoutSportVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant12), TypeInfoPropertyName = "WorkoutSportVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant13), TypeInfoPropertyName = "WorkoutSportVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant14), TypeInfoPropertyName = "WorkoutSportVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant15), TypeInfoPropertyName = "WorkoutSportVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant1), TypeInfoPropertyName = "EnvironmentTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant2), TypeInfoPropertyName = "EnvironmentTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant3), TypeInfoPropertyName = "EnvironmentTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionType), TypeInfoPropertyName = "CompletionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant1), TypeInfoPropertyName = "CompletionConditionTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant2), TypeInfoPropertyName = "CompletionConditionTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant3), TypeInfoPropertyName = "CompletionConditionTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant4), TypeInfoPropertyName = "CompletionConditionTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant5), TypeInfoPropertyName = "CompletionConditionTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant6), TypeInfoPropertyName = "CompletionConditionTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant7), TypeInfoPropertyName = "CompletionConditionTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant8), TypeInfoPropertyName = "CompletionConditionTypeVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant9), TypeInfoPropertyName = "CompletionConditionTypeVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant10), TypeInfoPropertyName = "CompletionConditionTypeVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant11), TypeInfoPropertyName = "CompletionConditionTypeVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetType), TypeInfoPropertyName = "WorkoutStepTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant1), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant2), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant3), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant4), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant5), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant6), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant7), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant8), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant9), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant10), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant11), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntensityTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensity), TypeInfoPropertyName = "WorkoutStepIntensity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant1), TypeInfoPropertyName = "WorkoutStepIntensityVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant2), TypeInfoPropertyName = "WorkoutStepIntensityVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant3), TypeInfoPropertyName = "WorkoutStepIntensityVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant4), TypeInfoPropertyName = "WorkoutStepIntensityVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant5), TypeInfoPropertyName = "WorkoutStepIntensityVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepControlType), TypeInfoPropertyName = "StepControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepControlTypeVariant1), TypeInfoPropertyName = "StepControlTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepControlTypeVariant2), TypeInfoPropertyName = "StepControlTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WeightUnit), TypeInfoPropertyName = "WeightUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WeightUnitVariant1), TypeInfoPropertyName = "WeightUnitVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WeightUnitVariant2), TypeInfoPropertyName = "WeightUnitVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeType), TypeInfoPropertyName = "SwimStrokeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant1), TypeInfoPropertyName = "SwimStrokeTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant2), TypeInfoPropertyName = "SwimStrokeTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant3), TypeInfoPropertyName = "SwimStrokeTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant4), TypeInfoPropertyName = "SwimStrokeTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant5), TypeInfoPropertyName = "SwimStrokeTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant6), TypeInfoPropertyName = "SwimStrokeTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant7), TypeInfoPropertyName = "SwimStrokeTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillType), TypeInfoPropertyName = "DrillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillTypeVariant1), TypeInfoPropertyName = "DrillTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillTypeVariant2), TypeInfoPropertyName = "DrillTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillTypeVariant3), TypeInfoPropertyName = "DrillTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentType), TypeInfoPropertyName = "SwimEquipmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant1), TypeInfoPropertyName = "SwimEquipmentTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant2), TypeInfoPropertyName = "SwimEquipmentTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant3), TypeInfoPropertyName = "SwimEquipmentTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant4), TypeInfoPropertyName = "SwimEquipmentTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant5), TypeInfoPropertyName = "SwimEquipmentTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant6), TypeInfoPropertyName = "SwimEquipmentTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStepData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.SwimEquipmentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.IntensityTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StepControl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.WorkoutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhookEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthSuccessEventType), TypeInfoPropertyName = "AuthSuccessEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthSuccessEventStatus), TypeInfoPropertyName = "AuthSuccessEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthErrorEventType), TypeInfoPropertyName = "AuthErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthErrorEventStatus), TypeInfoPropertyName = "AuthErrorEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEventType), TypeInfoPropertyName = "DeauthEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEventStatus), TypeInfoPropertyName = "DeauthEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEventType), TypeInfoPropertyName = "UserReauthEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEventStatus), TypeInfoPropertyName = "UserReauthEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEventType), TypeInfoPropertyName = "AccessRevokedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEventStatus), TypeInfoPropertyName = "AccessRevokedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEventType), TypeInfoPropertyName = "PermissionChangeEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEventStatus), TypeInfoPropertyName = "PermissionChangeEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEventType), TypeInfoPropertyName = "ConnectionErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEventStatus), TypeInfoPropertyName = "ConnectionErrorEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestSendingEventType), TypeInfoPropertyName = "LargeRequestSendingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEventType), TypeInfoPropertyName = "LargeRequestProcessingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEventStatus), TypeInfoPropertyName = "LargeRequestProcessingEventStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutEventType), TypeInfoPropertyName = "PlannedWorkoutEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HormoneEventType), TypeInfoPropertyName = "HormoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HormoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsPlanWorkoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsUpdatePlannedWorkoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhooksResendPayloadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportsUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<int?, global::System.DateTime?>), TypeInfoPropertyName = "OneOfInt32DateTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus), TypeInfoPropertyName = "AuthenticationAuthenticateUserResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus), TypeInfoPropertyName = "AuthenticationGenerateWidgetSessionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus), TypeInfoPropertyName = "AuthenticationDeauthenticateUserResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.ActivityFetchResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfActivityFetchResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfAthleteCollectionDataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.BodyFetchResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfBodyFetchResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.DailyFetchResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfDailyFetchResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.MenstruationFetchResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfMenstruationFetchResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.NutritionFetchResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfNutritionFetchResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.SleepFetchResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfSleepFetchResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepFetchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsCreateWorkoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsCreateWorkoutResponseStatus), TypeInfoPropertyName = "WorkoutsCreateWorkoutResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.WorkoutTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsDeleteWorkoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsPlanWorkoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsPlanWorkoutResponseStatus), TypeInfoPropertyName = "WorkoutsPlanWorkoutResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>), TypeInfoPropertyName = "OneOfUserGetInfoForUserIDResponse2IListTerraUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AllOf<global::Terra.TerraUser, global::Terra.UserGetInfoForUserIDResponseUser>), TypeInfoPropertyName = "AllOfTerraUserUserGetInfoForUserIDResponseUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetInfoForUserIDResponseStatus), TypeInfoPropertyName = "UserGetInfoForUserIDResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TerraUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetAllUserIDsResponseVariant1, global::Terra.UserGetAllUserIDsResponseVariant2>), TypeInfoPropertyName = "OneOfUserGetAllUserIDsResponseVariant1UserGetAllUserIDsResponseVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponseVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetAllUserIDsResponseVariant2Data))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhooksResendPayloadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhooksResendPayloadResponseStatus), TypeInfoPropertyName = "WebhooksResendPayloadResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsFetchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsFetchResponseStatus), TypeInfoPropertyName = "IntegrationsFetchResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StepBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.DrinkSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Meal>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.IntegrationProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportSession>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportStatusEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportPanel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportReferenceRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportFile>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StressSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BodyBatterySample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TagEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.MenstruationFlowSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.MenstruationIntervalSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.BreathSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SnoringSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SleepHypnogramSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.SwimEquipmentType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.IntensityTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StepControl>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.WorkoutStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Activity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Nutrition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Daily>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Menstruation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Body>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HormoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.WorkoutTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetInfoForUserIDResponse2, global::System.Collections.Generic.List<global::Terra.TerraUser>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TerraUser>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
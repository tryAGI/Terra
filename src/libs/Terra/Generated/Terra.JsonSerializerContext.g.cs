
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StepBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSport), TypeInfoPropertyName = "WorkoutSport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.CoercionWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CoercionWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutSport), TypeInfoPropertyName = "PlannedWorkoutSport2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityStrengthData2))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthObservationEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportWebhook), TypeInfoPropertyName = "LabReportWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFailedEvent))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovement), TypeInfoPropertyName = "StrengthMovement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant1), TypeInfoPropertyName = "StrengthMovementVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant2), TypeInfoPropertyName = "StrengthMovementVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant3), TypeInfoPropertyName = "StrengthMovementVariant32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant4), TypeInfoPropertyName = "StrengthMovementVariant42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant5), TypeInfoPropertyName = "StrengthMovementVariant52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant6), TypeInfoPropertyName = "StrengthMovementVariant62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant7), TypeInfoPropertyName = "StrengthMovementVariant72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant8), TypeInfoPropertyName = "StrengthMovementVariant82_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant9), TypeInfoPropertyName = "StrengthMovementVariant92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant10), TypeInfoPropertyName = "StrengthMovementVariant102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant11), TypeInfoPropertyName = "StrengthMovementVariant112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant12), TypeInfoPropertyName = "StrengthMovementVariant122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant13), TypeInfoPropertyName = "StrengthMovementVariant132_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant14), TypeInfoPropertyName = "StrengthMovementVariant142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant15), TypeInfoPropertyName = "StrengthMovementVariant152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant16), TypeInfoPropertyName = "StrengthMovementVariant162_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant17), TypeInfoPropertyName = "StrengthMovementVariant172_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant18), TypeInfoPropertyName = "StrengthMovementVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant19), TypeInfoPropertyName = "StrengthMovementVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant20), TypeInfoPropertyName = "StrengthMovementVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant21), TypeInfoPropertyName = "StrengthMovementVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant22), TypeInfoPropertyName = "StrengthMovementVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant23), TypeInfoPropertyName = "StrengthMovementVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant24), TypeInfoPropertyName = "StrengthMovementVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant25), TypeInfoPropertyName = "StrengthMovementVariant252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant26), TypeInfoPropertyName = "StrengthMovementVariant262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant27), TypeInfoPropertyName = "StrengthMovementVariant272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant28), TypeInfoPropertyName = "StrengthMovementVariant282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant29), TypeInfoPropertyName = "StrengthMovementVariant292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant30), TypeInfoPropertyName = "StrengthMovementVariant302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant31), TypeInfoPropertyName = "StrengthMovementVariant312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant32), TypeInfoPropertyName = "StrengthMovementVariant322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant33), TypeInfoPropertyName = "StrengthMovementVariant332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant34), TypeInfoPropertyName = "StrengthMovementVariant342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant35), TypeInfoPropertyName = "StrengthMovementVariant352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant36), TypeInfoPropertyName = "StrengthMovementVariant362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant37), TypeInfoPropertyName = "StrengthMovementVariant372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant38), TypeInfoPropertyName = "StrengthMovementVariant382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant39), TypeInfoPropertyName = "StrengthMovementVariant392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant40), TypeInfoPropertyName = "StrengthMovementVariant402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant41), TypeInfoPropertyName = "StrengthMovementVariant412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant42), TypeInfoPropertyName = "StrengthMovementVariant422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant43), TypeInfoPropertyName = "StrengthMovementVariant432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant44), TypeInfoPropertyName = "StrengthMovementVariant442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant45), TypeInfoPropertyName = "StrengthMovementVariant452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant46), TypeInfoPropertyName = "StrengthMovementVariant462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant47), TypeInfoPropertyName = "StrengthMovementVariant472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant48), TypeInfoPropertyName = "StrengthMovementVariant482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant49), TypeInfoPropertyName = "StrengthMovementVariant492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant50), TypeInfoPropertyName = "StrengthMovementVariant502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant51), TypeInfoPropertyName = "StrengthMovementVariant512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant52), TypeInfoPropertyName = "StrengthMovementVariant522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant53), TypeInfoPropertyName = "StrengthMovementVariant532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant54), TypeInfoPropertyName = "StrengthMovementVariant542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant55), TypeInfoPropertyName = "StrengthMovementVariant552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant56), TypeInfoPropertyName = "StrengthMovementVariant562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant57), TypeInfoPropertyName = "StrengthMovementVariant572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant58), TypeInfoPropertyName = "StrengthMovementVariant582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant59), TypeInfoPropertyName = "StrengthMovementVariant592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant60), TypeInfoPropertyName = "StrengthMovementVariant602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant61), TypeInfoPropertyName = "StrengthMovementVariant612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant62), TypeInfoPropertyName = "StrengthMovementVariant622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant63), TypeInfoPropertyName = "StrengthMovementVariant632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant64), TypeInfoPropertyName = "StrengthMovementVariant642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant65), TypeInfoPropertyName = "StrengthMovementVariant652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant66), TypeInfoPropertyName = "StrengthMovementVariant662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant67), TypeInfoPropertyName = "StrengthMovementVariant672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant68), TypeInfoPropertyName = "StrengthMovementVariant682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant69), TypeInfoPropertyName = "StrengthMovementVariant692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant70), TypeInfoPropertyName = "StrengthMovementVariant702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant71), TypeInfoPropertyName = "StrengthMovementVariant712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant72), TypeInfoPropertyName = "StrengthMovementVariant722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant73), TypeInfoPropertyName = "StrengthMovementVariant732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant74), TypeInfoPropertyName = "StrengthMovementVariant742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant75), TypeInfoPropertyName = "StrengthMovementVariant752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant76), TypeInfoPropertyName = "StrengthMovementVariant762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant77), TypeInfoPropertyName = "StrengthMovementVariant772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant78), TypeInfoPropertyName = "StrengthMovementVariant782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant79), TypeInfoPropertyName = "StrengthMovementVariant792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant80), TypeInfoPropertyName = "StrengthMovementVariant802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant81), TypeInfoPropertyName = "StrengthMovementVariant812")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant82), TypeInfoPropertyName = "StrengthMovementVariant822")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant83), TypeInfoPropertyName = "StrengthMovementVariant832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant84), TypeInfoPropertyName = "StrengthMovementVariant842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant85), TypeInfoPropertyName = "StrengthMovementVariant852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant86), TypeInfoPropertyName = "StrengthMovementVariant862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant87), TypeInfoPropertyName = "StrengthMovementVariant872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant88), TypeInfoPropertyName = "StrengthMovementVariant882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant89), TypeInfoPropertyName = "StrengthMovementVariant892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant90), TypeInfoPropertyName = "StrengthMovementVariant902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant91), TypeInfoPropertyName = "StrengthMovementVariant912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant92), TypeInfoPropertyName = "StrengthMovementVariant922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant93), TypeInfoPropertyName = "StrengthMovementVariant932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant94), TypeInfoPropertyName = "StrengthMovementVariant942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant95), TypeInfoPropertyName = "StrengthMovementVariant952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant96), TypeInfoPropertyName = "StrengthMovementVariant962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant97), TypeInfoPropertyName = "StrengthMovementVariant972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant98), TypeInfoPropertyName = "StrengthMovementVariant982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant99), TypeInfoPropertyName = "StrengthMovementVariant992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant100), TypeInfoPropertyName = "StrengthMovementVariant1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant101), TypeInfoPropertyName = "StrengthMovementVariant1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant102), TypeInfoPropertyName = "StrengthMovementVariant1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant103), TypeInfoPropertyName = "StrengthMovementVariant1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant104), TypeInfoPropertyName = "StrengthMovementVariant1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant105), TypeInfoPropertyName = "StrengthMovementVariant1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant106), TypeInfoPropertyName = "StrengthMovementVariant1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant107), TypeInfoPropertyName = "StrengthMovementVariant1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant108), TypeInfoPropertyName = "StrengthMovementVariant1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant109), TypeInfoPropertyName = "StrengthMovementVariant1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant110), TypeInfoPropertyName = "StrengthMovementVariant1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant111), TypeInfoPropertyName = "StrengthMovementVariant1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant112), TypeInfoPropertyName = "StrengthMovementVariant1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant113), TypeInfoPropertyName = "StrengthMovementVariant1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant114), TypeInfoPropertyName = "StrengthMovementVariant1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant115), TypeInfoPropertyName = "StrengthMovementVariant1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant116), TypeInfoPropertyName = "StrengthMovementVariant1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant117), TypeInfoPropertyName = "StrengthMovementVariant1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant118), TypeInfoPropertyName = "StrengthMovementVariant1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant119), TypeInfoPropertyName = "StrengthMovementVariant1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant120), TypeInfoPropertyName = "StrengthMovementVariant1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant121), TypeInfoPropertyName = "StrengthMovementVariant1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant122), TypeInfoPropertyName = "StrengthMovementVariant1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant123), TypeInfoPropertyName = "StrengthMovementVariant1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant124), TypeInfoPropertyName = "StrengthMovementVariant1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant125), TypeInfoPropertyName = "StrengthMovementVariant1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant126), TypeInfoPropertyName = "StrengthMovementVariant1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant127), TypeInfoPropertyName = "StrengthMovementVariant1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant128), TypeInfoPropertyName = "StrengthMovementVariant1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant129), TypeInfoPropertyName = "StrengthMovementVariant1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant130), TypeInfoPropertyName = "StrengthMovementVariant1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant131), TypeInfoPropertyName = "StrengthMovementVariant1312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant132), TypeInfoPropertyName = "StrengthMovementVariant1322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant133), TypeInfoPropertyName = "StrengthMovementVariant1332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant134), TypeInfoPropertyName = "StrengthMovementVariant1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant135), TypeInfoPropertyName = "StrengthMovementVariant1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant136), TypeInfoPropertyName = "StrengthMovementVariant1362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant137), TypeInfoPropertyName = "StrengthMovementVariant1372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant138), TypeInfoPropertyName = "StrengthMovementVariant1382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant139), TypeInfoPropertyName = "StrengthMovementVariant1392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant140), TypeInfoPropertyName = "StrengthMovementVariant1402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant141), TypeInfoPropertyName = "StrengthMovementVariant1412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant142), TypeInfoPropertyName = "StrengthMovementVariant1422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant143), TypeInfoPropertyName = "StrengthMovementVariant1432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant144), TypeInfoPropertyName = "StrengthMovementVariant1442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant145), TypeInfoPropertyName = "StrengthMovementVariant1452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant146), TypeInfoPropertyName = "StrengthMovementVariant1462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant147), TypeInfoPropertyName = "StrengthMovementVariant1472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant148), TypeInfoPropertyName = "StrengthMovementVariant1482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant149), TypeInfoPropertyName = "StrengthMovementVariant1492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant150), TypeInfoPropertyName = "StrengthMovementVariant1502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant151), TypeInfoPropertyName = "StrengthMovementVariant1512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant152), TypeInfoPropertyName = "StrengthMovementVariant1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant153), TypeInfoPropertyName = "StrengthMovementVariant1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant154), TypeInfoPropertyName = "StrengthMovementVariant1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant155), TypeInfoPropertyName = "StrengthMovementVariant1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant156), TypeInfoPropertyName = "StrengthMovementVariant1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant157), TypeInfoPropertyName = "StrengthMovementVariant1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant158), TypeInfoPropertyName = "StrengthMovementVariant1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant159), TypeInfoPropertyName = "StrengthMovementVariant1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant160), TypeInfoPropertyName = "StrengthMovementVariant1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant161), TypeInfoPropertyName = "StrengthMovementVariant1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant162), TypeInfoPropertyName = "StrengthMovementVariant1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant163), TypeInfoPropertyName = "StrengthMovementVariant1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant164), TypeInfoPropertyName = "StrengthMovementVariant1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant165), TypeInfoPropertyName = "StrengthMovementVariant1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant166), TypeInfoPropertyName = "StrengthMovementVariant1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant167), TypeInfoPropertyName = "StrengthMovementVariant1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant168), TypeInfoPropertyName = "StrengthMovementVariant1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant169), TypeInfoPropertyName = "StrengthMovementVariant1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant170), TypeInfoPropertyName = "StrengthMovementVariant1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant171), TypeInfoPropertyName = "StrengthMovementVariant1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant172), TypeInfoPropertyName = "StrengthMovementVariant1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant173), TypeInfoPropertyName = "StrengthMovementVariant1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant174), TypeInfoPropertyName = "StrengthMovementVariant1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant175), TypeInfoPropertyName = "StrengthMovementVariant1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTarget), TypeInfoPropertyName = "StrengthTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant1), TypeInfoPropertyName = "StrengthTargetVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant2), TypeInfoPropertyName = "StrengthTargetVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant3), TypeInfoPropertyName = "StrengthTargetVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant4), TypeInfoPropertyName = "StrengthTargetVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant5), TypeInfoPropertyName = "StrengthTargetVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant6), TypeInfoPropertyName = "StrengthTargetVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant7), TypeInfoPropertyName = "StrengthTargetVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant8), TypeInfoPropertyName = "StrengthTargetVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant9), TypeInfoPropertyName = "StrengthTargetVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant10), TypeInfoPropertyName = "StrengthTargetVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant11), TypeInfoPropertyName = "StrengthTargetVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant12), TypeInfoPropertyName = "StrengthTargetVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant13), TypeInfoPropertyName = "StrengthTargetVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant14), TypeInfoPropertyName = "StrengthTargetVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant15), TypeInfoPropertyName = "StrengthTargetVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant16), TypeInfoPropertyName = "StrengthTargetVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant17), TypeInfoPropertyName = "StrengthTargetVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant18), TypeInfoPropertyName = "StrengthTargetVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant19), TypeInfoPropertyName = "StrengthTargetVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant20), TypeInfoPropertyName = "StrengthTargetVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant21), TypeInfoPropertyName = "StrengthTargetVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant22), TypeInfoPropertyName = "StrengthTargetVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant23), TypeInfoPropertyName = "StrengthTargetVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant24), TypeInfoPropertyName = "StrengthTargetVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant25), TypeInfoPropertyName = "StrengthTargetVariant252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplement), TypeInfoPropertyName = "StrengthImplement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant1), TypeInfoPropertyName = "StrengthImplementVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant2), TypeInfoPropertyName = "StrengthImplementVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant3), TypeInfoPropertyName = "StrengthImplementVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant4), TypeInfoPropertyName = "StrengthImplementVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant5), TypeInfoPropertyName = "StrengthImplementVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant6), TypeInfoPropertyName = "StrengthImplementVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant7), TypeInfoPropertyName = "StrengthImplementVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant8), TypeInfoPropertyName = "StrengthImplementVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant9), TypeInfoPropertyName = "StrengthImplementVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant10), TypeInfoPropertyName = "StrengthImplementVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant11), TypeInfoPropertyName = "StrengthImplementVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant12), TypeInfoPropertyName = "StrengthImplementVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant13), TypeInfoPropertyName = "StrengthImplementVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant14), TypeInfoPropertyName = "StrengthImplementVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant15), TypeInfoPropertyName = "StrengthImplementVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant16), TypeInfoPropertyName = "StrengthImplementVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant17), TypeInfoPropertyName = "StrengthImplementVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant18), TypeInfoPropertyName = "StrengthImplementVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant19), TypeInfoPropertyName = "StrengthImplementVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant20), TypeInfoPropertyName = "StrengthImplementVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant21), TypeInfoPropertyName = "StrengthImplementVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant22), TypeInfoPropertyName = "StrengthImplementVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant23), TypeInfoPropertyName = "StrengthImplementVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant24), TypeInfoPropertyName = "StrengthImplementVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant25), TypeInfoPropertyName = "StrengthImplementVariant252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurface), TypeInfoPropertyName = "StrengthSurface2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant1), TypeInfoPropertyName = "StrengthSurfaceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant2), TypeInfoPropertyName = "StrengthSurfaceVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant3), TypeInfoPropertyName = "StrengthSurfaceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant4), TypeInfoPropertyName = "StrengthSurfaceVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant5), TypeInfoPropertyName = "StrengthSurfaceVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant6), TypeInfoPropertyName = "StrengthSurfaceVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant7), TypeInfoPropertyName = "StrengthSurfaceVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant8), TypeInfoPropertyName = "StrengthSurfaceVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant9), TypeInfoPropertyName = "StrengthSurfaceVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant10), TypeInfoPropertyName = "StrengthSurfaceVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant11), TypeInfoPropertyName = "StrengthSurfaceVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidth), TypeInfoPropertyName = "StrengthGripWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidthVariant1), TypeInfoPropertyName = "StrengthGripWidthVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidthVariant2), TypeInfoPropertyName = "StrengthGripWidthVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidthVariant3), TypeInfoPropertyName = "StrengthGripWidthVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientation), TypeInfoPropertyName = "StrengthGripOrientation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant1), TypeInfoPropertyName = "StrengthGripOrientationVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant2), TypeInfoPropertyName = "StrengthGripOrientationVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant3), TypeInfoPropertyName = "StrengthGripOrientationVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant4), TypeInfoPropertyName = "StrengthGripOrientationVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant5), TypeInfoPropertyName = "StrengthGripOrientationVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant6), TypeInfoPropertyName = "StrengthGripOrientationVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant7), TypeInfoPropertyName = "StrengthGripOrientationVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant8), TypeInfoPropertyName = "StrengthGripOrientationVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLaterality), TypeInfoPropertyName = "StrengthLaterality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant1), TypeInfoPropertyName = "StrengthLateralityVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant2), TypeInfoPropertyName = "StrengthLateralityVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant3), TypeInfoPropertyName = "StrengthLateralityVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant4), TypeInfoPropertyName = "StrengthLateralityVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStance), TypeInfoPropertyName = "StrengthStance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant1), TypeInfoPropertyName = "StrengthStanceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant2), TypeInfoPropertyName = "StrengthStanceVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant3), TypeInfoPropertyName = "StrengthStanceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant4), TypeInfoPropertyName = "StrengthStanceVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant5), TypeInfoPropertyName = "StrengthStanceVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPosition), TypeInfoPropertyName = "StrengthPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant1), TypeInfoPropertyName = "StrengthPositionVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant2), TypeInfoPropertyName = "StrengthPositionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant3), TypeInfoPropertyName = "StrengthPositionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant4), TypeInfoPropertyName = "StrengthPositionVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant5), TypeInfoPropertyName = "StrengthPositionVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant6), TypeInfoPropertyName = "StrengthPositionVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant7), TypeInfoPropertyName = "StrengthPositionVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant8), TypeInfoPropertyName = "StrengthPositionVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant9), TypeInfoPropertyName = "StrengthPositionVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant10), TypeInfoPropertyName = "StrengthPositionVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant11), TypeInfoPropertyName = "StrengthPositionVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant12), TypeInfoPropertyName = "StrengthPositionVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant13), TypeInfoPropertyName = "StrengthPositionVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant14), TypeInfoPropertyName = "StrengthPositionVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant15), TypeInfoPropertyName = "StrengthPositionVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant16), TypeInfoPropertyName = "StrengthPositionVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant17), TypeInfoPropertyName = "StrengthPositionVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant18), TypeInfoPropertyName = "StrengthPositionVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant19), TypeInfoPropertyName = "StrengthPositionVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPosition), TypeInfoPropertyName = "StrengthBarPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant1), TypeInfoPropertyName = "StrengthBarPositionVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant2), TypeInfoPropertyName = "StrengthBarPositionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant3), TypeInfoPropertyName = "StrengthBarPositionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant4), TypeInfoPropertyName = "StrengthBarPositionVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant5), TypeInfoPropertyName = "StrengthBarPositionVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant6), TypeInfoPropertyName = "StrengthBarPositionVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant7), TypeInfoPropertyName = "StrengthBarPositionVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempo), TypeInfoPropertyName = "StrengthTempo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant1), TypeInfoPropertyName = "StrengthTempoVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant2), TypeInfoPropertyName = "StrengthTempoVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant3), TypeInfoPropertyName = "StrengthTempoVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant4), TypeInfoPropertyName = "StrengthTempoVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant5), TypeInfoPropertyName = "StrengthTempoVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant6), TypeInfoPropertyName = "StrengthTempoVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant7), TypeInfoPropertyName = "StrengthTempoVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant8), TypeInfoPropertyName = "StrengthTempoVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotion), TypeInfoPropertyName = "StrengthRangeOfMotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant1), TypeInfoPropertyName = "StrengthRangeOfMotionVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant2), TypeInfoPropertyName = "StrengthRangeOfMotionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant3), TypeInfoPropertyName = "StrengthRangeOfMotionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant4), TypeInfoPropertyName = "StrengthRangeOfMotionVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant5), TypeInfoPropertyName = "StrengthRangeOfMotionVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant6), TypeInfoPropertyName = "StrengthRangeOfMotionVariant62")]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant7), TypeInfoPropertyName = "StrengthRangeOfMotionVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthProgramme), TypeInfoPropertyName = "StrengthProgramme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthProgrammeVariant1), TypeInfoPropertyName = "StrengthProgrammeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthProgrammeVariant2), TypeInfoPropertyName = "StrengthProgrammeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthExerciseModifiers))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscle), TypeInfoPropertyName = "StrengthMuscle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant1), TypeInfoPropertyName = "StrengthMuscleVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant2), TypeInfoPropertyName = "StrengthMuscleVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant3), TypeInfoPropertyName = "StrengthMuscleVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant4), TypeInfoPropertyName = "StrengthMuscleVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant5), TypeInfoPropertyName = "StrengthMuscleVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant6), TypeInfoPropertyName = "StrengthMuscleVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant7), TypeInfoPropertyName = "StrengthMuscleVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant8), TypeInfoPropertyName = "StrengthMuscleVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant9), TypeInfoPropertyName = "StrengthMuscleVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant10), TypeInfoPropertyName = "StrengthMuscleVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant11), TypeInfoPropertyName = "StrengthMuscleVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant12), TypeInfoPropertyName = "StrengthMuscleVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant13), TypeInfoPropertyName = "StrengthMuscleVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant14), TypeInfoPropertyName = "StrengthMuscleVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant15), TypeInfoPropertyName = "StrengthMuscleVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant16), TypeInfoPropertyName = "StrengthMuscleVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant17), TypeInfoPropertyName = "StrengthMuscleVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant18), TypeInfoPropertyName = "StrengthMuscleVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant19), TypeInfoPropertyName = "StrengthMuscleVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant20), TypeInfoPropertyName = "StrengthMuscleVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant21), TypeInfoPropertyName = "StrengthMuscleVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant22), TypeInfoPropertyName = "StrengthMuscleVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant23), TypeInfoPropertyName = "StrengthMuscleVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSource), TypeInfoPropertyName = "StrengthSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSourceVariant1), TypeInfoPropertyName = "StrengthSourceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSourceVariant2), TypeInfoPropertyName = "StrengthSourceVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSourceVariant3), TypeInfoPropertyName = "StrengthSourceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadType), TypeInfoPropertyName = "StrengthLoadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant1), TypeInfoPropertyName = "StrengthLoadTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant2), TypeInfoPropertyName = "StrengthLoadTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant3), TypeInfoPropertyName = "StrengthLoadTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant4), TypeInfoPropertyName = "StrengthLoadTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant5), TypeInfoPropertyName = "StrengthLoadTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetType), TypeInfoPropertyName = "StrengthSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant1), TypeInfoPropertyName = "StrengthSetTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant2), TypeInfoPropertyName = "StrengthSetTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant3), TypeInfoPropertyName = "StrengthSetTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant4), TypeInfoPropertyName = "StrengthSetTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant5), TypeInfoPropertyName = "StrengthSetTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant6), TypeInfoPropertyName = "StrengthSetTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant7), TypeInfoPropertyName = "StrengthSetTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthExercise))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StrengthMovement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StrengthMuscle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StrengthSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.StrengthExercise>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant1), TypeInfoPropertyName = "EnvironmentTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant2), TypeInfoPropertyName = "EnvironmentTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant3), TypeInfoPropertyName = "EnvironmentTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionType), TypeInfoPropertyName = "CompletionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant1), TypeInfoPropertyName = "CompletionConditionTypeVariant12_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant12), TypeInfoPropertyName = "CompletionConditionTypeVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant13), TypeInfoPropertyName = "CompletionConditionTypeVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant14), TypeInfoPropertyName = "CompletionConditionTypeVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant15), TypeInfoPropertyName = "CompletionConditionTypeVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant16), TypeInfoPropertyName = "CompletionConditionTypeVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant17), TypeInfoPropertyName = "CompletionConditionTypeVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetType), TypeInfoPropertyName = "WorkoutStepTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant1), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant12_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant12), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant13), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant14), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant15), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant16), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant17), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant18), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant19), TypeInfoPropertyName = "WorkoutStepTargetTypeVariant192")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutSportEnum), TypeInfoPropertyName = "PlannedWorkoutSportEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDetailsMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDetailsStepDuration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDetailsStepTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDetailsStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepDuration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutDetails))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportEventResultSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportEventResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportEventData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.LabReportEventResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportCompletedEventType), TypeInfoPropertyName = "LabReportCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportEventError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFailureData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFailedEventType), TypeInfoPropertyName = "LabReportFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutEventType), TypeInfoPropertyName = "PlannedWorkoutEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HormoneEventType), TypeInfoPropertyName = "HormoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HormoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthObservationMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ObservationCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ObservationValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ObservationComponent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthObservationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.ObservationCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.ObservationComponent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthObservation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthObservationEventType), TypeInfoPropertyName = "HealthObservationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.HealthObservation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserRequestSdkApp), TypeInfoPropertyName = "AuthenticationAuthenticateUserRequestSdkApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsPlanWorkoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsUpdatePlannedWorkoutRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportsUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<int?, global::System.DateTime?>), TypeInfoPropertyName = "OneOfInt32DateTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus), TypeInfoPropertyName = "AuthenticationAuthenticateUserResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus), TypeInfoPropertyName = "AuthenticationGenerateWidgetSessionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus), TypeInfoPropertyName = "AuthenticationDeauthenticateUserResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationCreateAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateAuthTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.ActivityGetResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfActivityGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfAthleteCollectionDataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.BodyGetResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfBodyGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.DailyGetResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfDailyGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.MenstruationGetResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfMenstruationGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.NutritionGetResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfNutritionGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.SleepGetResponse2, global::Terra.DataSentToWebhook>), TypeInfoPropertyName = "OneOfSleepGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsCreateWorkoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsCreateWorkoutResponseStatus), TypeInfoPropertyName = "WorkoutsCreateWorkoutResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.WorkoutTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsDeleteWorkoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsPlanWorkoutResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsPlanWorkoutResponseStatus), TypeInfoPropertyName = "WorkoutsPlanWorkoutResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>), TypeInfoPropertyName = "OneOfUserGetResponse2IListTerraUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AllOf<global::Terra.TerraUser, global::Terra.UserGetResponseUser>), TypeInfoPropertyName = "AllOfTerraUserUserGetResponseUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetResponseUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetResponseStatus), TypeInfoPropertyName = "UserGetResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Terra.TerraUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserListResponseStatus), TypeInfoPropertyName = "UserListResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsListResponseStatus), TypeInfoPropertyName = "IntegrationsListResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSport?), TypeInfoPropertyName = "NullableWorkoutSport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutSport?), TypeInfoPropertyName = "NullablePlannedWorkoutSport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DataSentToWebhookStatus?), TypeInfoPropertyName = "NullableDataSentToWebhookStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportWebhook?), TypeInfoPropertyName = "NullableLabReportWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WebhookEventType?), TypeInfoPropertyName = "NullableWebhookEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeviceDataType?), TypeInfoPropertyName = "NullableDeviceDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovement?), TypeInfoPropertyName = "NullableStrengthMovement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant1?), TypeInfoPropertyName = "NullableStrengthMovementVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant2?), TypeInfoPropertyName = "NullableStrengthMovementVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant3?), TypeInfoPropertyName = "NullableStrengthMovementVariant32_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant4?), TypeInfoPropertyName = "NullableStrengthMovementVariant42_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant5?), TypeInfoPropertyName = "NullableStrengthMovementVariant52_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant6?), TypeInfoPropertyName = "NullableStrengthMovementVariant62_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant7?), TypeInfoPropertyName = "NullableStrengthMovementVariant72_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant8?), TypeInfoPropertyName = "NullableStrengthMovementVariant82_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant9?), TypeInfoPropertyName = "NullableStrengthMovementVariant92_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant10?), TypeInfoPropertyName = "NullableStrengthMovementVariant102_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant11?), TypeInfoPropertyName = "NullableStrengthMovementVariant112_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant12?), TypeInfoPropertyName = "NullableStrengthMovementVariant122_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant13?), TypeInfoPropertyName = "NullableStrengthMovementVariant132_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant14?), TypeInfoPropertyName = "NullableStrengthMovementVariant142_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant15?), TypeInfoPropertyName = "NullableStrengthMovementVariant152_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant16?), TypeInfoPropertyName = "NullableStrengthMovementVariant162_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant17?), TypeInfoPropertyName = "NullableStrengthMovementVariant172_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant18?), TypeInfoPropertyName = "NullableStrengthMovementVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant19?), TypeInfoPropertyName = "NullableStrengthMovementVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant20?), TypeInfoPropertyName = "NullableStrengthMovementVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant21?), TypeInfoPropertyName = "NullableStrengthMovementVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant22?), TypeInfoPropertyName = "NullableStrengthMovementVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant23?), TypeInfoPropertyName = "NullableStrengthMovementVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant24?), TypeInfoPropertyName = "NullableStrengthMovementVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant25?), TypeInfoPropertyName = "NullableStrengthMovementVariant252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant26?), TypeInfoPropertyName = "NullableStrengthMovementVariant262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant27?), TypeInfoPropertyName = "NullableStrengthMovementVariant272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant28?), TypeInfoPropertyName = "NullableStrengthMovementVariant282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant29?), TypeInfoPropertyName = "NullableStrengthMovementVariant292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant30?), TypeInfoPropertyName = "NullableStrengthMovementVariant302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant31?), TypeInfoPropertyName = "NullableStrengthMovementVariant312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant32?), TypeInfoPropertyName = "NullableStrengthMovementVariant322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant33?), TypeInfoPropertyName = "NullableStrengthMovementVariant332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant34?), TypeInfoPropertyName = "NullableStrengthMovementVariant342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant35?), TypeInfoPropertyName = "NullableStrengthMovementVariant352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant36?), TypeInfoPropertyName = "NullableStrengthMovementVariant362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant37?), TypeInfoPropertyName = "NullableStrengthMovementVariant372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant38?), TypeInfoPropertyName = "NullableStrengthMovementVariant382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant39?), TypeInfoPropertyName = "NullableStrengthMovementVariant392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant40?), TypeInfoPropertyName = "NullableStrengthMovementVariant402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant41?), TypeInfoPropertyName = "NullableStrengthMovementVariant412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant42?), TypeInfoPropertyName = "NullableStrengthMovementVariant422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant43?), TypeInfoPropertyName = "NullableStrengthMovementVariant432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant44?), TypeInfoPropertyName = "NullableStrengthMovementVariant442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant45?), TypeInfoPropertyName = "NullableStrengthMovementVariant452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant46?), TypeInfoPropertyName = "NullableStrengthMovementVariant462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant47?), TypeInfoPropertyName = "NullableStrengthMovementVariant472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant48?), TypeInfoPropertyName = "NullableStrengthMovementVariant482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant49?), TypeInfoPropertyName = "NullableStrengthMovementVariant492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant50?), TypeInfoPropertyName = "NullableStrengthMovementVariant502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant51?), TypeInfoPropertyName = "NullableStrengthMovementVariant512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant52?), TypeInfoPropertyName = "NullableStrengthMovementVariant522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant53?), TypeInfoPropertyName = "NullableStrengthMovementVariant532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant54?), TypeInfoPropertyName = "NullableStrengthMovementVariant542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant55?), TypeInfoPropertyName = "NullableStrengthMovementVariant552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant56?), TypeInfoPropertyName = "NullableStrengthMovementVariant562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant57?), TypeInfoPropertyName = "NullableStrengthMovementVariant572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant58?), TypeInfoPropertyName = "NullableStrengthMovementVariant582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant59?), TypeInfoPropertyName = "NullableStrengthMovementVariant592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant60?), TypeInfoPropertyName = "NullableStrengthMovementVariant602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant61?), TypeInfoPropertyName = "NullableStrengthMovementVariant612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant62?), TypeInfoPropertyName = "NullableStrengthMovementVariant622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant63?), TypeInfoPropertyName = "NullableStrengthMovementVariant632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant64?), TypeInfoPropertyName = "NullableStrengthMovementVariant642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant65?), TypeInfoPropertyName = "NullableStrengthMovementVariant652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant66?), TypeInfoPropertyName = "NullableStrengthMovementVariant662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant67?), TypeInfoPropertyName = "NullableStrengthMovementVariant672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant68?), TypeInfoPropertyName = "NullableStrengthMovementVariant682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant69?), TypeInfoPropertyName = "NullableStrengthMovementVariant692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant70?), TypeInfoPropertyName = "NullableStrengthMovementVariant702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant71?), TypeInfoPropertyName = "NullableStrengthMovementVariant712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant72?), TypeInfoPropertyName = "NullableStrengthMovementVariant722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant73?), TypeInfoPropertyName = "NullableStrengthMovementVariant732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant74?), TypeInfoPropertyName = "NullableStrengthMovementVariant742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant75?), TypeInfoPropertyName = "NullableStrengthMovementVariant752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant76?), TypeInfoPropertyName = "NullableStrengthMovementVariant762")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant77?), TypeInfoPropertyName = "NullableStrengthMovementVariant772")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant78?), TypeInfoPropertyName = "NullableStrengthMovementVariant782")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant79?), TypeInfoPropertyName = "NullableStrengthMovementVariant792")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant80?), TypeInfoPropertyName = "NullableStrengthMovementVariant802")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant81?), TypeInfoPropertyName = "NullableStrengthMovementVariant812")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant82?), TypeInfoPropertyName = "NullableStrengthMovementVariant822")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant83?), TypeInfoPropertyName = "NullableStrengthMovementVariant832")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant84?), TypeInfoPropertyName = "NullableStrengthMovementVariant842")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant85?), TypeInfoPropertyName = "NullableStrengthMovementVariant852")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant86?), TypeInfoPropertyName = "NullableStrengthMovementVariant862")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant87?), TypeInfoPropertyName = "NullableStrengthMovementVariant872")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant88?), TypeInfoPropertyName = "NullableStrengthMovementVariant882")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant89?), TypeInfoPropertyName = "NullableStrengthMovementVariant892")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant90?), TypeInfoPropertyName = "NullableStrengthMovementVariant902")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant91?), TypeInfoPropertyName = "NullableStrengthMovementVariant912")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant92?), TypeInfoPropertyName = "NullableStrengthMovementVariant922")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant93?), TypeInfoPropertyName = "NullableStrengthMovementVariant932")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant94?), TypeInfoPropertyName = "NullableStrengthMovementVariant942")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant95?), TypeInfoPropertyName = "NullableStrengthMovementVariant952")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant96?), TypeInfoPropertyName = "NullableStrengthMovementVariant962")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant97?), TypeInfoPropertyName = "NullableStrengthMovementVariant972")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant98?), TypeInfoPropertyName = "NullableStrengthMovementVariant982")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant99?), TypeInfoPropertyName = "NullableStrengthMovementVariant992")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant100?), TypeInfoPropertyName = "NullableStrengthMovementVariant1002")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant101?), TypeInfoPropertyName = "NullableStrengthMovementVariant1012")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant102?), TypeInfoPropertyName = "NullableStrengthMovementVariant1022")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant103?), TypeInfoPropertyName = "NullableStrengthMovementVariant1032")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant104?), TypeInfoPropertyName = "NullableStrengthMovementVariant1042")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant105?), TypeInfoPropertyName = "NullableStrengthMovementVariant1052")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant106?), TypeInfoPropertyName = "NullableStrengthMovementVariant1062")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant107?), TypeInfoPropertyName = "NullableStrengthMovementVariant1072")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant108?), TypeInfoPropertyName = "NullableStrengthMovementVariant1082")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant109?), TypeInfoPropertyName = "NullableStrengthMovementVariant1092")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant110?), TypeInfoPropertyName = "NullableStrengthMovementVariant1102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant111?), TypeInfoPropertyName = "NullableStrengthMovementVariant1112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant112?), TypeInfoPropertyName = "NullableStrengthMovementVariant1122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant113?), TypeInfoPropertyName = "NullableStrengthMovementVariant1132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant114?), TypeInfoPropertyName = "NullableStrengthMovementVariant1142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant115?), TypeInfoPropertyName = "NullableStrengthMovementVariant1152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant116?), TypeInfoPropertyName = "NullableStrengthMovementVariant1162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant117?), TypeInfoPropertyName = "NullableStrengthMovementVariant1172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant118?), TypeInfoPropertyName = "NullableStrengthMovementVariant1182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant119?), TypeInfoPropertyName = "NullableStrengthMovementVariant1192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant120?), TypeInfoPropertyName = "NullableStrengthMovementVariant1202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant121?), TypeInfoPropertyName = "NullableStrengthMovementVariant1212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant122?), TypeInfoPropertyName = "NullableStrengthMovementVariant1222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant123?), TypeInfoPropertyName = "NullableStrengthMovementVariant1232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant124?), TypeInfoPropertyName = "NullableStrengthMovementVariant1242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant125?), TypeInfoPropertyName = "NullableStrengthMovementVariant1252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant126?), TypeInfoPropertyName = "NullableStrengthMovementVariant1262")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant127?), TypeInfoPropertyName = "NullableStrengthMovementVariant1272")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant128?), TypeInfoPropertyName = "NullableStrengthMovementVariant1282")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant129?), TypeInfoPropertyName = "NullableStrengthMovementVariant1292")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant130?), TypeInfoPropertyName = "NullableStrengthMovementVariant1302")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant131?), TypeInfoPropertyName = "NullableStrengthMovementVariant1312")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant132?), TypeInfoPropertyName = "NullableStrengthMovementVariant1322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant133?), TypeInfoPropertyName = "NullableStrengthMovementVariant1332")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant134?), TypeInfoPropertyName = "NullableStrengthMovementVariant1342")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant135?), TypeInfoPropertyName = "NullableStrengthMovementVariant1352")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant136?), TypeInfoPropertyName = "NullableStrengthMovementVariant1362")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant137?), TypeInfoPropertyName = "NullableStrengthMovementVariant1372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant138?), TypeInfoPropertyName = "NullableStrengthMovementVariant1382")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant139?), TypeInfoPropertyName = "NullableStrengthMovementVariant1392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant140?), TypeInfoPropertyName = "NullableStrengthMovementVariant1402")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant141?), TypeInfoPropertyName = "NullableStrengthMovementVariant1412")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant142?), TypeInfoPropertyName = "NullableStrengthMovementVariant1422")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant143?), TypeInfoPropertyName = "NullableStrengthMovementVariant1432")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant144?), TypeInfoPropertyName = "NullableStrengthMovementVariant1442")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant145?), TypeInfoPropertyName = "NullableStrengthMovementVariant1452")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant146?), TypeInfoPropertyName = "NullableStrengthMovementVariant1462")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant147?), TypeInfoPropertyName = "NullableStrengthMovementVariant1472")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant148?), TypeInfoPropertyName = "NullableStrengthMovementVariant1482")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant149?), TypeInfoPropertyName = "NullableStrengthMovementVariant1492")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant150?), TypeInfoPropertyName = "NullableStrengthMovementVariant1502")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant151?), TypeInfoPropertyName = "NullableStrengthMovementVariant1512")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant152?), TypeInfoPropertyName = "NullableStrengthMovementVariant1522")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant153?), TypeInfoPropertyName = "NullableStrengthMovementVariant1532")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant154?), TypeInfoPropertyName = "NullableStrengthMovementVariant1542")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant155?), TypeInfoPropertyName = "NullableStrengthMovementVariant1552")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant156?), TypeInfoPropertyName = "NullableStrengthMovementVariant1562")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant157?), TypeInfoPropertyName = "NullableStrengthMovementVariant1572")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant158?), TypeInfoPropertyName = "NullableStrengthMovementVariant1582")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant159?), TypeInfoPropertyName = "NullableStrengthMovementVariant1592")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant160?), TypeInfoPropertyName = "NullableStrengthMovementVariant1602")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant161?), TypeInfoPropertyName = "NullableStrengthMovementVariant1612")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant162?), TypeInfoPropertyName = "NullableStrengthMovementVariant1622")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant163?), TypeInfoPropertyName = "NullableStrengthMovementVariant1632")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant164?), TypeInfoPropertyName = "NullableStrengthMovementVariant1642")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant165?), TypeInfoPropertyName = "NullableStrengthMovementVariant1652")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant166?), TypeInfoPropertyName = "NullableStrengthMovementVariant1662")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant167?), TypeInfoPropertyName = "NullableStrengthMovementVariant1672")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant168?), TypeInfoPropertyName = "NullableStrengthMovementVariant1682")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant169?), TypeInfoPropertyName = "NullableStrengthMovementVariant1692")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant170?), TypeInfoPropertyName = "NullableStrengthMovementVariant1702")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant171?), TypeInfoPropertyName = "NullableStrengthMovementVariant1712")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant172?), TypeInfoPropertyName = "NullableStrengthMovementVariant1722")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant173?), TypeInfoPropertyName = "NullableStrengthMovementVariant1732")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant174?), TypeInfoPropertyName = "NullableStrengthMovementVariant1742")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMovementVariant175?), TypeInfoPropertyName = "NullableStrengthMovementVariant1752")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTarget?), TypeInfoPropertyName = "NullableStrengthTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant1?), TypeInfoPropertyName = "NullableStrengthTargetVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant2?), TypeInfoPropertyName = "NullableStrengthTargetVariant22_3")]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant3?), TypeInfoPropertyName = "NullableStrengthTargetVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant4?), TypeInfoPropertyName = "NullableStrengthTargetVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant5?), TypeInfoPropertyName = "NullableStrengthTargetVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant6?), TypeInfoPropertyName = "NullableStrengthTargetVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant7?), TypeInfoPropertyName = "NullableStrengthTargetVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant8?), TypeInfoPropertyName = "NullableStrengthTargetVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant9?), TypeInfoPropertyName = "NullableStrengthTargetVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant10?), TypeInfoPropertyName = "NullableStrengthTargetVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant11?), TypeInfoPropertyName = "NullableStrengthTargetVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant12?), TypeInfoPropertyName = "NullableStrengthTargetVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant13?), TypeInfoPropertyName = "NullableStrengthTargetVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant14?), TypeInfoPropertyName = "NullableStrengthTargetVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant15?), TypeInfoPropertyName = "NullableStrengthTargetVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant16?), TypeInfoPropertyName = "NullableStrengthTargetVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant17?), TypeInfoPropertyName = "NullableStrengthTargetVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant18?), TypeInfoPropertyName = "NullableStrengthTargetVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant19?), TypeInfoPropertyName = "NullableStrengthTargetVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant20?), TypeInfoPropertyName = "NullableStrengthTargetVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant21?), TypeInfoPropertyName = "NullableStrengthTargetVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant22?), TypeInfoPropertyName = "NullableStrengthTargetVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant23?), TypeInfoPropertyName = "NullableStrengthTargetVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant24?), TypeInfoPropertyName = "NullableStrengthTargetVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTargetVariant25?), TypeInfoPropertyName = "NullableStrengthTargetVariant252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplement?), TypeInfoPropertyName = "NullableStrengthImplement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant1?), TypeInfoPropertyName = "NullableStrengthImplementVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant2?), TypeInfoPropertyName = "NullableStrengthImplementVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant3?), TypeInfoPropertyName = "NullableStrengthImplementVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant4?), TypeInfoPropertyName = "NullableStrengthImplementVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant5?), TypeInfoPropertyName = "NullableStrengthImplementVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant6?), TypeInfoPropertyName = "NullableStrengthImplementVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant7?), TypeInfoPropertyName = "NullableStrengthImplementVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant8?), TypeInfoPropertyName = "NullableStrengthImplementVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant9?), TypeInfoPropertyName = "NullableStrengthImplementVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant10?), TypeInfoPropertyName = "NullableStrengthImplementVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant11?), TypeInfoPropertyName = "NullableStrengthImplementVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant12?), TypeInfoPropertyName = "NullableStrengthImplementVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant13?), TypeInfoPropertyName = "NullableStrengthImplementVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant14?), TypeInfoPropertyName = "NullableStrengthImplementVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant15?), TypeInfoPropertyName = "NullableStrengthImplementVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant16?), TypeInfoPropertyName = "NullableStrengthImplementVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant17?), TypeInfoPropertyName = "NullableStrengthImplementVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant18?), TypeInfoPropertyName = "NullableStrengthImplementVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant19?), TypeInfoPropertyName = "NullableStrengthImplementVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant20?), TypeInfoPropertyName = "NullableStrengthImplementVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant21?), TypeInfoPropertyName = "NullableStrengthImplementVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant22?), TypeInfoPropertyName = "NullableStrengthImplementVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant23?), TypeInfoPropertyName = "NullableStrengthImplementVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant24?), TypeInfoPropertyName = "NullableStrengthImplementVariant242")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthImplementVariant25?), TypeInfoPropertyName = "NullableStrengthImplementVariant252")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurface?), TypeInfoPropertyName = "NullableStrengthSurface2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant1?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant2?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant3?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant4?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant5?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant6?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant7?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant8?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant9?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant10?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSurfaceVariant11?), TypeInfoPropertyName = "NullableStrengthSurfaceVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidth?), TypeInfoPropertyName = "NullableStrengthGripWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidthVariant1?), TypeInfoPropertyName = "NullableStrengthGripWidthVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidthVariant2?), TypeInfoPropertyName = "NullableStrengthGripWidthVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripWidthVariant3?), TypeInfoPropertyName = "NullableStrengthGripWidthVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientation?), TypeInfoPropertyName = "NullableStrengthGripOrientation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant1?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant2?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant3?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant4?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant5?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant6?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant7?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthGripOrientationVariant8?), TypeInfoPropertyName = "NullableStrengthGripOrientationVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLaterality?), TypeInfoPropertyName = "NullableStrengthLaterality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant1?), TypeInfoPropertyName = "NullableStrengthLateralityVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant2?), TypeInfoPropertyName = "NullableStrengthLateralityVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant3?), TypeInfoPropertyName = "NullableStrengthLateralityVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLateralityVariant4?), TypeInfoPropertyName = "NullableStrengthLateralityVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStance?), TypeInfoPropertyName = "NullableStrengthStance2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant1?), TypeInfoPropertyName = "NullableStrengthStanceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant2?), TypeInfoPropertyName = "NullableStrengthStanceVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant3?), TypeInfoPropertyName = "NullableStrengthStanceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant4?), TypeInfoPropertyName = "NullableStrengthStanceVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthStanceVariant5?), TypeInfoPropertyName = "NullableStrengthStanceVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPosition?), TypeInfoPropertyName = "NullableStrengthPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant1?), TypeInfoPropertyName = "NullableStrengthPositionVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant2?), TypeInfoPropertyName = "NullableStrengthPositionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant3?), TypeInfoPropertyName = "NullableStrengthPositionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant4?), TypeInfoPropertyName = "NullableStrengthPositionVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant5?), TypeInfoPropertyName = "NullableStrengthPositionVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant6?), TypeInfoPropertyName = "NullableStrengthPositionVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant7?), TypeInfoPropertyName = "NullableStrengthPositionVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant8?), TypeInfoPropertyName = "NullableStrengthPositionVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant9?), TypeInfoPropertyName = "NullableStrengthPositionVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant10?), TypeInfoPropertyName = "NullableStrengthPositionVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant11?), TypeInfoPropertyName = "NullableStrengthPositionVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant12?), TypeInfoPropertyName = "NullableStrengthPositionVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant13?), TypeInfoPropertyName = "NullableStrengthPositionVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant14?), TypeInfoPropertyName = "NullableStrengthPositionVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant15?), TypeInfoPropertyName = "NullableStrengthPositionVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant16?), TypeInfoPropertyName = "NullableStrengthPositionVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant17?), TypeInfoPropertyName = "NullableStrengthPositionVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant18?), TypeInfoPropertyName = "NullableStrengthPositionVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthPositionVariant19?), TypeInfoPropertyName = "NullableStrengthPositionVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPosition?), TypeInfoPropertyName = "NullableStrengthBarPosition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant1?), TypeInfoPropertyName = "NullableStrengthBarPositionVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant2?), TypeInfoPropertyName = "NullableStrengthBarPositionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant3?), TypeInfoPropertyName = "NullableStrengthBarPositionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant4?), TypeInfoPropertyName = "NullableStrengthBarPositionVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant5?), TypeInfoPropertyName = "NullableStrengthBarPositionVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant6?), TypeInfoPropertyName = "NullableStrengthBarPositionVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthBarPositionVariant7?), TypeInfoPropertyName = "NullableStrengthBarPositionVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempo?), TypeInfoPropertyName = "NullableStrengthTempo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant1?), TypeInfoPropertyName = "NullableStrengthTempoVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant2?), TypeInfoPropertyName = "NullableStrengthTempoVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant3?), TypeInfoPropertyName = "NullableStrengthTempoVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant4?), TypeInfoPropertyName = "NullableStrengthTempoVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant5?), TypeInfoPropertyName = "NullableStrengthTempoVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant6?), TypeInfoPropertyName = "NullableStrengthTempoVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant7?), TypeInfoPropertyName = "NullableStrengthTempoVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthTempoVariant8?), TypeInfoPropertyName = "NullableStrengthTempoVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotion?), TypeInfoPropertyName = "NullableStrengthRangeOfMotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant1?), TypeInfoPropertyName = "NullableStrengthRangeOfMotionVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant2?), TypeInfoPropertyName = "NullableStrengthRangeOfMotionVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant3?), TypeInfoPropertyName = "NullableStrengthRangeOfMotionVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant4?), TypeInfoPropertyName = "NullableStrengthRangeOfMotionVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant5?), TypeInfoPropertyName = "NullableStrengthRangeOfMotionVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant6?), TypeInfoPropertyName = "NullableStrengthRangeOfMotionVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthRangeOfMotionVariant7?), TypeInfoPropertyName = "NullableStrengthRangeOfMotionVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthProgramme?), TypeInfoPropertyName = "NullableStrengthProgramme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthProgrammeVariant1?), TypeInfoPropertyName = "NullableStrengthProgrammeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthProgrammeVariant2?), TypeInfoPropertyName = "NullableStrengthProgrammeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscle?), TypeInfoPropertyName = "NullableStrengthMuscle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant1?), TypeInfoPropertyName = "NullableStrengthMuscleVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant2?), TypeInfoPropertyName = "NullableStrengthMuscleVariant22_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant3?), TypeInfoPropertyName = "NullableStrengthMuscleVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant4?), TypeInfoPropertyName = "NullableStrengthMuscleVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant5?), TypeInfoPropertyName = "NullableStrengthMuscleVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant6?), TypeInfoPropertyName = "NullableStrengthMuscleVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant7?), TypeInfoPropertyName = "NullableStrengthMuscleVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant8?), TypeInfoPropertyName = "NullableStrengthMuscleVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant9?), TypeInfoPropertyName = "NullableStrengthMuscleVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant10?), TypeInfoPropertyName = "NullableStrengthMuscleVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant11?), TypeInfoPropertyName = "NullableStrengthMuscleVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant12?), TypeInfoPropertyName = "NullableStrengthMuscleVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant13?), TypeInfoPropertyName = "NullableStrengthMuscleVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant14?), TypeInfoPropertyName = "NullableStrengthMuscleVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant15?), TypeInfoPropertyName = "NullableStrengthMuscleVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant16?), TypeInfoPropertyName = "NullableStrengthMuscleVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant17?), TypeInfoPropertyName = "NullableStrengthMuscleVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant18?), TypeInfoPropertyName = "NullableStrengthMuscleVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant19?), TypeInfoPropertyName = "NullableStrengthMuscleVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant20?), TypeInfoPropertyName = "NullableStrengthMuscleVariant202")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant21?), TypeInfoPropertyName = "NullableStrengthMuscleVariant212")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant22?), TypeInfoPropertyName = "NullableStrengthMuscleVariant222")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthMuscleVariant23?), TypeInfoPropertyName = "NullableStrengthMuscleVariant232")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSource?), TypeInfoPropertyName = "NullableStrengthSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSourceVariant1?), TypeInfoPropertyName = "NullableStrengthSourceVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSourceVariant2?), TypeInfoPropertyName = "NullableStrengthSourceVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSourceVariant3?), TypeInfoPropertyName = "NullableStrengthSourceVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadType?), TypeInfoPropertyName = "NullableStrengthLoadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant1?), TypeInfoPropertyName = "NullableStrengthLoadTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant2?), TypeInfoPropertyName = "NullableStrengthLoadTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant3?), TypeInfoPropertyName = "NullableStrengthLoadTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant4?), TypeInfoPropertyName = "NullableStrengthLoadTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthLoadTypeVariant5?), TypeInfoPropertyName = "NullableStrengthLoadTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetType?), TypeInfoPropertyName = "NullableStrengthSetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant1?), TypeInfoPropertyName = "NullableStrengthSetTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant2?), TypeInfoPropertyName = "NullableStrengthSetTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant3?), TypeInfoPropertyName = "NullableStrengthSetTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant4?), TypeInfoPropertyName = "NullableStrengthSetTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant5?), TypeInfoPropertyName = "NullableStrengthSetTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant6?), TypeInfoPropertyName = "NullableStrengthSetTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StrengthSetTypeVariant7?), TypeInfoPropertyName = "NullableStrengthSetTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant1?), TypeInfoPropertyName = "NullableEnvironmentTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant2?), TypeInfoPropertyName = "NullableEnvironmentTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.EnvironmentTypeVariant3?), TypeInfoPropertyName = "NullableEnvironmentTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionType?), TypeInfoPropertyName = "NullableCompletionConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant1?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant2?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant3?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant4?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant5?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant6?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant7?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant8?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant9?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant10?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant11?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant12?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant13?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant14?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant15?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant16?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.CompletionConditionTypeVariant17?), TypeInfoPropertyName = "NullableCompletionConditionTypeVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetType?), TypeInfoPropertyName = "NullableWorkoutStepTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant1?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant2?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant3?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant4?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant5?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant6?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant7?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant8?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant9?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant10?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant11?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant12?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant13?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant14?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant15?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant16?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant162")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant17?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant172")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant18?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant182")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepTargetTypeVariant19?), TypeInfoPropertyName = "NullableWorkoutStepTargetTypeVariant192")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensity?), TypeInfoPropertyName = "NullableWorkoutStepIntensity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant1?), TypeInfoPropertyName = "NullableWorkoutStepIntensityVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant2?), TypeInfoPropertyName = "NullableWorkoutStepIntensityVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant3?), TypeInfoPropertyName = "NullableWorkoutStepIntensityVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant4?), TypeInfoPropertyName = "NullableWorkoutStepIntensityVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutStepIntensityVariant5?), TypeInfoPropertyName = "NullableWorkoutStepIntensityVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepControlType?), TypeInfoPropertyName = "NullableStepControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepControlTypeVariant1?), TypeInfoPropertyName = "NullableStepControlTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.StepControlTypeVariant2?), TypeInfoPropertyName = "NullableStepControlTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WeightUnit?), TypeInfoPropertyName = "NullableWeightUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WeightUnitVariant1?), TypeInfoPropertyName = "NullableWeightUnitVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WeightUnitVariant2?), TypeInfoPropertyName = "NullableWeightUnitVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeType?), TypeInfoPropertyName = "NullableSwimStrokeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant1?), TypeInfoPropertyName = "NullableSwimStrokeTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant2?), TypeInfoPropertyName = "NullableSwimStrokeTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant3?), TypeInfoPropertyName = "NullableSwimStrokeTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant4?), TypeInfoPropertyName = "NullableSwimStrokeTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant5?), TypeInfoPropertyName = "NullableSwimStrokeTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant6?), TypeInfoPropertyName = "NullableSwimStrokeTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimStrokeTypeVariant7?), TypeInfoPropertyName = "NullableSwimStrokeTypeVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillType?), TypeInfoPropertyName = "NullableDrillType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillTypeVariant1?), TypeInfoPropertyName = "NullableDrillTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillTypeVariant2?), TypeInfoPropertyName = "NullableDrillTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DrillTypeVariant3?), TypeInfoPropertyName = "NullableDrillTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentType?), TypeInfoPropertyName = "NullableSwimEquipmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant1?), TypeInfoPropertyName = "NullableSwimEquipmentTypeVariant12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant2?), TypeInfoPropertyName = "NullableSwimEquipmentTypeVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant3?), TypeInfoPropertyName = "NullableSwimEquipmentTypeVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant4?), TypeInfoPropertyName = "NullableSwimEquipmentTypeVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant5?), TypeInfoPropertyName = "NullableSwimEquipmentTypeVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SwimEquipmentTypeVariant6?), TypeInfoPropertyName = "NullableSwimEquipmentTypeVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant1?), TypeInfoPropertyName = "NullableWorkoutSportVariant12_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant2?), TypeInfoPropertyName = "NullableWorkoutSportVariant22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant3?), TypeInfoPropertyName = "NullableWorkoutSportVariant32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant4?), TypeInfoPropertyName = "NullableWorkoutSportVariant42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant5?), TypeInfoPropertyName = "NullableWorkoutSportVariant52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant6?), TypeInfoPropertyName = "NullableWorkoutSportVariant62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant7?), TypeInfoPropertyName = "NullableWorkoutSportVariant72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant8?), TypeInfoPropertyName = "NullableWorkoutSportVariant82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant9?), TypeInfoPropertyName = "NullableWorkoutSportVariant92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant10?), TypeInfoPropertyName = "NullableWorkoutSportVariant102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant11?), TypeInfoPropertyName = "NullableWorkoutSportVariant112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant12?), TypeInfoPropertyName = "NullableWorkoutSportVariant122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant13?), TypeInfoPropertyName = "NullableWorkoutSportVariant132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant14?), TypeInfoPropertyName = "NullableWorkoutSportVariant142")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutSportVariant15?), TypeInfoPropertyName = "NullableWorkoutSportVariant152")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutSportEnum?), TypeInfoPropertyName = "NullablePlannedWorkoutSportEnum2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthSuccessEventType?), TypeInfoPropertyName = "NullableAuthSuccessEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthSuccessEventStatus?), TypeInfoPropertyName = "NullableAuthSuccessEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthErrorEventType?), TypeInfoPropertyName = "NullableAuthErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthErrorEventStatus?), TypeInfoPropertyName = "NullableAuthErrorEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEventType?), TypeInfoPropertyName = "NullableDeauthEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DeauthEventStatus?), TypeInfoPropertyName = "NullableDeauthEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEventType?), TypeInfoPropertyName = "NullableUserReauthEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserReauthEventStatus?), TypeInfoPropertyName = "NullableUserReauthEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEventType?), TypeInfoPropertyName = "NullableAccessRevokedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AccessRevokedEventStatus?), TypeInfoPropertyName = "NullableAccessRevokedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEventType?), TypeInfoPropertyName = "NullablePermissionChangeEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PermissionChangeEventStatus?), TypeInfoPropertyName = "NullablePermissionChangeEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEventType?), TypeInfoPropertyName = "NullableConnectionErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ConnectionErrorEventStatus?), TypeInfoPropertyName = "NullableConnectionErrorEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestSendingEventType?), TypeInfoPropertyName = "NullableLargeRequestSendingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEventType?), TypeInfoPropertyName = "NullableLargeRequestProcessingEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LargeRequestProcessingEventStatus?), TypeInfoPropertyName = "NullableLargeRequestProcessingEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.S3PayloadEventType?), TypeInfoPropertyName = "NullableS3PayloadEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.S3PayloadEventStatus?), TypeInfoPropertyName = "NullableS3PayloadEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.ActivityEventType?), TypeInfoPropertyName = "NullableActivityEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AthleteEventType?), TypeInfoPropertyName = "NullableAthleteEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.NutritionEventType?), TypeInfoPropertyName = "NullableNutritionEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.DailyEventType?), TypeInfoPropertyName = "NullableDailyEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.SleepEventType?), TypeInfoPropertyName = "NullableSleepEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.MenstruationEventType?), TypeInfoPropertyName = "NullableMenstruationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.BodyEventType?), TypeInfoPropertyName = "NullableBodyEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportCompletedEventType?), TypeInfoPropertyName = "NullableLabReportCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.LabReportFailedEventType?), TypeInfoPropertyName = "NullableLabReportFailedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.PlannedWorkoutEventType?), TypeInfoPropertyName = "NullablePlannedWorkoutEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HormoneEventType?), TypeInfoPropertyName = "NullableHormoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.HealthObservationEventType?), TypeInfoPropertyName = "NullableHealthObservationEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserRequestSdkApp?), TypeInfoPropertyName = "NullableAuthenticationAuthenticateUserRequestSdkApp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<int?, global::System.DateTime?>?), TypeInfoPropertyName = "NullableOneOfInt32DateTime2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus?), TypeInfoPropertyName = "NullableAuthenticationAuthenticateUserResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus?), TypeInfoPropertyName = "NullableAuthenticationGenerateWidgetSessionResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus?), TypeInfoPropertyName = "NullableAuthenticationDeauthenticateUserResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.ActivityGetResponse2, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfActivityGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfAthleteCollectionDataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.BodyGetResponse2, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfBodyGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.DailyGetResponse2, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfDailyGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.MenstruationGetResponse2, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfMenstruationGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.NutritionGetResponse2, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfNutritionGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.SleepGetResponse2, global::Terra.DataSentToWebhook>?), TypeInfoPropertyName = "NullableOneOfSleepGetResponse2DataSentToWebhook2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsCreateWorkoutResponseStatus?), TypeInfoPropertyName = "NullableWorkoutsCreateWorkoutResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.WorkoutsPlanWorkoutResponseStatus?), TypeInfoPropertyName = "NullableWorkoutsPlanWorkoutResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>?), TypeInfoPropertyName = "NullableOneOfUserGetResponse2IListTerraUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.AllOf<global::Terra.TerraUser, global::Terra.UserGetResponseUser>?), TypeInfoPropertyName = "NullableAllOfTerraUserUserGetResponseUser2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserGetResponseStatus?), TypeInfoPropertyName = "NullableUserGetResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.UserListResponseStatus?), TypeInfoPropertyName = "NullableUserListResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.IntegrationsListResponseStatus?), TypeInfoPropertyName = "NullableIntegrationsListResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StepBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.CoercionWarning>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StrengthMovement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StrengthMuscle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StrengthSet>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.StrengthExercise>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutDetailsStepDuration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutDetailsStepTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkoutDetailsStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Activity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Nutrition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Daily>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Sleep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Menstruation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.Body>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.LabReportEventResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.PlannedWorkout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HormoneSample>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.ObservationCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.ObservationComponent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.HealthObservation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.WorkoutTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Terra.OneOf<global::Terra.UserGetResponse2, global::System.Collections.Generic.List<global::Terra.TerraUser>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Terra.TerraUser>))]
    internal sealed partial class SourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

         static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Terra.JsonConverters.LabReportWebhookJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthMovementJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthTargetJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthImplementJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthSurfaceJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthGripWidthJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthGripOrientationJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthLateralityJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthStanceJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthPositionJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthBarPositionJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthTempoJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthRangeOfMotionJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthProgrammeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthMuscleJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthSourceJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthLoadTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StrengthSetTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.EnvironmentTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.CompletionConditionTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.WorkoutStepTargetTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.WorkoutStepIntensityJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.StepControlTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.WeightUnitJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.SwimStrokeTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.DrillTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.SwimEquipmentTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.WorkoutSportJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.PlannedWorkoutSportJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.WebhookEventTypeJsonConverter());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<int?, global::System.DateTime?>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.ActivityGetResponse2, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.BodyGetResponse2, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.DailyGetResponse2, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.MenstruationGetResponse2, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.NutritionGetResponse2, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.SleepGetResponse2, global::Terra.DataSentToWebhook>());
            options.Converters.Add(new global::Terra.JsonConverters.OneOfJsonConverter<global::Terra.UserGetResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>());
            options.Converters.Add(new global::Terra.JsonConverters.AllOfJsonConverter<global::Terra.TerraUser, global::Terra.UserGetResponseUser>());
            options.Converters.Add(new global::Terra.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Terra.DataSentToWebhookStatus)

                    || typeToConvert == typeof(global::Terra.DataSentToWebhookStatus?)

                    || typeToConvert == typeof(global::Terra.DeviceDataType)

                    || typeToConvert == typeof(global::Terra.DeviceDataType?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant9)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant9?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant10)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant10?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant11)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant11?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant12)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant12?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant13)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant13?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant14)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant14?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant15)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant15?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant16)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant16?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant17)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant17?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant18)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant18?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant19)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant19?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant20)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant20?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant21)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant21?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant22)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant22?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant23)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant23?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant24)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant24?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant25)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant25?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant26)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant26?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant27)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant27?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant28)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant28?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant29)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant29?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant30)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant30?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant31)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant31?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant32)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant32?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant33)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant33?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant34)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant34?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant35)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant35?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant36)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant36?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant37)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant37?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant38)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant38?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant39)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant39?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant40)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant40?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant41)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant41?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant42)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant42?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant43)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant43?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant44)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant44?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant45)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant45?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant46)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant46?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant47)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant47?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant48)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant48?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant49)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant49?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant50)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant50?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant51)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant51?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant52)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant52?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant53)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant53?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant54)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant54?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant55)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant55?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant56)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant56?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant57)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant57?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant58)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant58?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant59)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant59?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant60)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant60?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant61)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant61?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant62)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant62?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant63)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant63?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant64)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant64?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant65)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant65?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant66)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant66?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant67)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant67?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant68)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant68?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant69)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant69?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant70)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant70?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant71)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant71?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant72)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant72?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant73)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant73?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant74)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant74?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant75)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant75?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant76)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant76?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant77)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant77?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant78)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant78?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant79)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant79?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant80)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant80?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant81)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant81?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant82)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant82?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant83)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant83?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant84)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant84?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant85)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant85?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant86)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant86?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant87)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant87?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant88)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant88?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant89)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant89?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant90)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant90?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant91)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant91?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant92)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant92?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant93)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant93?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant94)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant94?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant95)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant95?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant96)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant96?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant97)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant97?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant98)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant98?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant99)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant99?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant100)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant100?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant101)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant101?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant102)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant102?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant103)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant103?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant104)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant104?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant105)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant105?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant106)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant106?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant107)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant107?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant108)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant108?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant109)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant109?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant110)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant110?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant111)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant111?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant112)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant112?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant113)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant113?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant114)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant114?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant115)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant115?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant116)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant116?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant117)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant117?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant118)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant118?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant119)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant119?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant120)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant120?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant121)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant121?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant122)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant122?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant123)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant123?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant124)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant124?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant125)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant125?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant126)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant126?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant127)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant127?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant128)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant128?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant129)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant129?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant130)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant130?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant131)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant131?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant132)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant132?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant133)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant133?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant134)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant134?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant135)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant135?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant136)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant136?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant137)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant137?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant138)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant138?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant139)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant139?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant140)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant140?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant141)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant141?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant142)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant142?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant143)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant143?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant144)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant144?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant145)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant145?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant146)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant146?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant147)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant147?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant148)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant148?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant149)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant149?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant150)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant150?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant151)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant151?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant152)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant152?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant153)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant153?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant154)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant154?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant155)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant155?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant156)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant156?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant157)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant157?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant158)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant158?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant159)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant159?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant160)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant160?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant161)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant161?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant162)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant162?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant163)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant163?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant164)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant164?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant165)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant165?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant166)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant166?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant167)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant167?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant168)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant168?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant169)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant169?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant170)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant170?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant171)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant171?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant172)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant172?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant173)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant173?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant174)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant174?)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant175)

                    || typeToConvert == typeof(global::Terra.StrengthMovementVariant175?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant9)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant9?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant10)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant10?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant11)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant11?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant12)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant12?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant13)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant13?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant14)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant14?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant15)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant15?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant16)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant16?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant17)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant17?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant18)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant18?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant19)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant19?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant20)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant20?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant21)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant21?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant22)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant22?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant23)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant23?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant24)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant24?)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant25)

                    || typeToConvert == typeof(global::Terra.StrengthTargetVariant25?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant9)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant9?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant10)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant10?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant11)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant11?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant12)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant12?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant13)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant13?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant14)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant14?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant15)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant15?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant16)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant16?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant17)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant17?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant18)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant18?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant19)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant19?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant20)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant20?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant21)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant21?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant22)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant22?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant23)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant23?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant24)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant24?)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant25)

                    || typeToConvert == typeof(global::Terra.StrengthImplementVariant25?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant9)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant9?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant10)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant10?)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant11)

                    || typeToConvert == typeof(global::Terra.StrengthSurfaceVariant11?)

                    || typeToConvert == typeof(global::Terra.StrengthGripWidthVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthGripWidthVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthGripWidthVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthGripWidthVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthGripWidthVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthGripWidthVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthLateralityVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthStanceVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant9)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant9?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant10)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant10?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant11)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant11?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant12)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant12?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant13)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant13?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant14)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant14?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant15)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant15?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant16)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant16?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant17)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant17?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant18)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant18?)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant19)

                    || typeToConvert == typeof(global::Terra.StrengthPositionVariant19?)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthBarPositionVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthTempoVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthProgrammeVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthProgrammeVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthProgrammeVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthProgrammeVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant7?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant8)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant8?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant9)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant9?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant10)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant10?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant11)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant11?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant12)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant12?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant13)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant13?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant14)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant14?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant15)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant15?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant16)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant16?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant17)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant17?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant18)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant18?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant19)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant19?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant20)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant20?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant21)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant21?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant22)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant22?)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant23)

                    || typeToConvert == typeof(global::Terra.StrengthMuscleVariant23?)

                    || typeToConvert == typeof(global::Terra.StrengthSourceVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthSourceVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthSourceVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthSourceVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthSourceVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthSourceVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant1)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant2)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant3)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant4)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant4?)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant5)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant5?)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant6)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant6?)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant7)

                    || typeToConvert == typeof(global::Terra.StrengthSetTypeVariant7?)

                    || typeToConvert == typeof(global::Terra.EnvironmentTypeVariant1)

                    || typeToConvert == typeof(global::Terra.EnvironmentTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.EnvironmentTypeVariant2)

                    || typeToConvert == typeof(global::Terra.EnvironmentTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.EnvironmentTypeVariant3)

                    || typeToConvert == typeof(global::Terra.EnvironmentTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant1)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant2)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant3)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant4)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant4?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant5)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant5?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant6)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant6?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant7)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant7?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant8)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant8?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant9)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant9?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant10)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant10?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant11)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant11?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant12)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant12?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant13)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant13?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant14)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant14?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant15)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant15?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant16)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant16?)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant17)

                    || typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant17?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant1)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant2)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant3)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant4)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant4?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant5)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant5?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant6)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant6?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant7)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant7?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant8)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant8?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant9)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant9?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant10)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant10?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant11)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant11?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant12)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant12?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant13)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant13?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant14)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant14?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant15)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant15?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant16)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant16?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant17)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant17?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant18)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant18?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant19)

                    || typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant19?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant1)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant1?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant2)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant2?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant3)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant3?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant4)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant4?)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant5)

                    || typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant5?)

                    || typeToConvert == typeof(global::Terra.StepControlTypeVariant1)

                    || typeToConvert == typeof(global::Terra.StepControlTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.StepControlTypeVariant2)

                    || typeToConvert == typeof(global::Terra.StepControlTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.WeightUnitVariant1)

                    || typeToConvert == typeof(global::Terra.WeightUnitVariant1?)

                    || typeToConvert == typeof(global::Terra.WeightUnitVariant2)

                    || typeToConvert == typeof(global::Terra.WeightUnitVariant2?)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant1)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant2)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant3)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant4)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant4?)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant5)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant5?)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant6)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant6?)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant7)

                    || typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant7?)

                    || typeToConvert == typeof(global::Terra.DrillTypeVariant1)

                    || typeToConvert == typeof(global::Terra.DrillTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.DrillTypeVariant2)

                    || typeToConvert == typeof(global::Terra.DrillTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.DrillTypeVariant3)

                    || typeToConvert == typeof(global::Terra.DrillTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant1)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant1?)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant2)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant2?)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant3)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant3?)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant4)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant4?)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant5)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant5?)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant6)

                    || typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant6?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant1)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant1?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant2)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant2?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant3)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant3?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant4)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant4?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant5)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant5?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant6)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant6?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant7)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant7?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant8)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant8?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant9)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant9?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant10)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant10?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant11)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant11?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant12)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant12?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant13)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant13?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant14)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant14?)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant15)

                    || typeToConvert == typeof(global::Terra.WorkoutSportVariant15?)

                    || typeToConvert == typeof(global::Terra.PlannedWorkoutSportEnum)

                    || typeToConvert == typeof(global::Terra.PlannedWorkoutSportEnum?)

                    || typeToConvert == typeof(global::Terra.AuthSuccessEventType)

                    || typeToConvert == typeof(global::Terra.AuthSuccessEventType?)

                    || typeToConvert == typeof(global::Terra.AuthSuccessEventStatus)

                    || typeToConvert == typeof(global::Terra.AuthSuccessEventStatus?)

                    || typeToConvert == typeof(global::Terra.AuthErrorEventType)

                    || typeToConvert == typeof(global::Terra.AuthErrorEventType?)

                    || typeToConvert == typeof(global::Terra.AuthErrorEventStatus)

                    || typeToConvert == typeof(global::Terra.AuthErrorEventStatus?)

                    || typeToConvert == typeof(global::Terra.DeauthEventType)

                    || typeToConvert == typeof(global::Terra.DeauthEventType?)

                    || typeToConvert == typeof(global::Terra.DeauthEventStatus)

                    || typeToConvert == typeof(global::Terra.DeauthEventStatus?)

                    || typeToConvert == typeof(global::Terra.UserReauthEventType)

                    || typeToConvert == typeof(global::Terra.UserReauthEventType?)

                    || typeToConvert == typeof(global::Terra.UserReauthEventStatus)

                    || typeToConvert == typeof(global::Terra.UserReauthEventStatus?)

                    || typeToConvert == typeof(global::Terra.AccessRevokedEventType)

                    || typeToConvert == typeof(global::Terra.AccessRevokedEventType?)

                    || typeToConvert == typeof(global::Terra.AccessRevokedEventStatus)

                    || typeToConvert == typeof(global::Terra.AccessRevokedEventStatus?)

                    || typeToConvert == typeof(global::Terra.PermissionChangeEventType)

                    || typeToConvert == typeof(global::Terra.PermissionChangeEventType?)

                    || typeToConvert == typeof(global::Terra.PermissionChangeEventStatus)

                    || typeToConvert == typeof(global::Terra.PermissionChangeEventStatus?)

                    || typeToConvert == typeof(global::Terra.ConnectionErrorEventType)

                    || typeToConvert == typeof(global::Terra.ConnectionErrorEventType?)

                    || typeToConvert == typeof(global::Terra.ConnectionErrorEventStatus)

                    || typeToConvert == typeof(global::Terra.ConnectionErrorEventStatus?)

                    || typeToConvert == typeof(global::Terra.LargeRequestSendingEventType)

                    || typeToConvert == typeof(global::Terra.LargeRequestSendingEventType?)

                    || typeToConvert == typeof(global::Terra.LargeRequestProcessingEventType)

                    || typeToConvert == typeof(global::Terra.LargeRequestProcessingEventType?)

                    || typeToConvert == typeof(global::Terra.LargeRequestProcessingEventStatus)

                    || typeToConvert == typeof(global::Terra.LargeRequestProcessingEventStatus?)

                    || typeToConvert == typeof(global::Terra.S3PayloadEventType)

                    || typeToConvert == typeof(global::Terra.S3PayloadEventType?)

                    || typeToConvert == typeof(global::Terra.S3PayloadEventStatus)

                    || typeToConvert == typeof(global::Terra.S3PayloadEventStatus?)

                    || typeToConvert == typeof(global::Terra.ActivityEventType)

                    || typeToConvert == typeof(global::Terra.ActivityEventType?)

                    || typeToConvert == typeof(global::Terra.AthleteEventType)

                    || typeToConvert == typeof(global::Terra.AthleteEventType?)

                    || typeToConvert == typeof(global::Terra.NutritionEventType)

                    || typeToConvert == typeof(global::Terra.NutritionEventType?)

                    || typeToConvert == typeof(global::Terra.DailyEventType)

                    || typeToConvert == typeof(global::Terra.DailyEventType?)

                    || typeToConvert == typeof(global::Terra.SleepEventType)

                    || typeToConvert == typeof(global::Terra.SleepEventType?)

                    || typeToConvert == typeof(global::Terra.MenstruationEventType)

                    || typeToConvert == typeof(global::Terra.MenstruationEventType?)

                    || typeToConvert == typeof(global::Terra.BodyEventType)

                    || typeToConvert == typeof(global::Terra.BodyEventType?)

                    || typeToConvert == typeof(global::Terra.LabReportCompletedEventType)

                    || typeToConvert == typeof(global::Terra.LabReportCompletedEventType?)

                    || typeToConvert == typeof(global::Terra.LabReportFailedEventType)

                    || typeToConvert == typeof(global::Terra.LabReportFailedEventType?)

                    || typeToConvert == typeof(global::Terra.PlannedWorkoutEventType)

                    || typeToConvert == typeof(global::Terra.PlannedWorkoutEventType?)

                    || typeToConvert == typeof(global::Terra.HormoneEventType)

                    || typeToConvert == typeof(global::Terra.HormoneEventType?)

                    || typeToConvert == typeof(global::Terra.HealthObservationEventType)

                    || typeToConvert == typeof(global::Terra.HealthObservationEventType?)

                    || typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserRequestSdkApp)

                    || typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserRequestSdkApp?)

                    || typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus)

                    || typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus?)

                    || typeToConvert == typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus)

                    || typeToConvert == typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus?)

                    || typeToConvert == typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus)

                    || typeToConvert == typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus?)

                    || typeToConvert == typeof(global::Terra.WorkoutsCreateWorkoutResponseStatus)

                    || typeToConvert == typeof(global::Terra.WorkoutsCreateWorkoutResponseStatus?)

                    || typeToConvert == typeof(global::Terra.WorkoutsPlanWorkoutResponseStatus)

                    || typeToConvert == typeof(global::Terra.WorkoutsPlanWorkoutResponseStatus?)

                    || typeToConvert == typeof(global::Terra.UserGetResponseStatus)

                    || typeToConvert == typeof(global::Terra.UserGetResponseStatus?)

                    || typeToConvert == typeof(global::Terra.UserListResponseStatus)

                    || typeToConvert == typeof(global::Terra.UserListResponseStatus?)

                    || typeToConvert == typeof(global::Terra.IntegrationsListResponseStatus)

                    || typeToConvert == typeof(global::Terra.IntegrationsListResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Terra.DataSentToWebhookStatus))
                {
                    return new global::Terra.JsonConverters.DataSentToWebhookStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DataSentToWebhookStatus?))
                {
                    return new global::Terra.JsonConverters.DataSentToWebhookStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeviceDataType))
                {
                    return new global::Terra.JsonConverters.DeviceDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeviceDataType?))
                {
                    return new global::Terra.JsonConverters.DeviceDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant9))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant9?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant10))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant10?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant11))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant11?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant12))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant12?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant13))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant13?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant14))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant14?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant15))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant15?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant16))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant16JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant16?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant16NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant17))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant17JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant17?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant17NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant18))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant18JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant18?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant18NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant19))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant19JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant19?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant19NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant20))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant20JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant20?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant20NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant21))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant21JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant21?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant21NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant22))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant22JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant22?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant22NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant23))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant23JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant23?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant23NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant24))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant24JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant24?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant24NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant25))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant25JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant25?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant25NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant26))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant26JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant26?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant26NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant27))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant27JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant27?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant27NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant28))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant28JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant28?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant28NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant29))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant29JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant29?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant29NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant30))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant30JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant30?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant30NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant31))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant31JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant31?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant31NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant32))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant32JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant32?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant32NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant33))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant33JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant33?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant33NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant34))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant34JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant34?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant34NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant35))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant35JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant35?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant35NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant36))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant36JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant36?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant36NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant37))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant37JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant37?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant37NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant38))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant38JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant38?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant38NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant39))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant39JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant39?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant39NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant40))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant40JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant40?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant40NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant41))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant41JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant41?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant41NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant42))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant42JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant42?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant42NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant43))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant43JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant43?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant43NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant44))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant44JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant44?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant44NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant45))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant45JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant45?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant45NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant46))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant46JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant46?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant46NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant47))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant47JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant47?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant47NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant48))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant48JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant48?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant48NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant49))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant49JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant49?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant49NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant50))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant50JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant50?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant50NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant51))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant51JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant51?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant51NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant52))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant52JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant52?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant52NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant53))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant53JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant53?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant53NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant54))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant54JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant54?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant54NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant55))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant55JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant55?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant55NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant56))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant56JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant56?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant56NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant57))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant57JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant57?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant57NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant58))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant58JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant58?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant58NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant59))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant59JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant59?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant59NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant60))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant60JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant60?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant60NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant61))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant61JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant61?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant61NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant62))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant62JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant62?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant62NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant63))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant63JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant63?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant63NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant64))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant64JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant64?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant64NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant65))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant65JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant65?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant65NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant66))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant66JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant66?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant66NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant67))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant67JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant67?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant67NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant68))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant68JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant68?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant68NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant69))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant69JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant69?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant69NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant70))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant70JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant70?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant70NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant71))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant71JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant71?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant71NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant72))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant72JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant72?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant72NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant73))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant73JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant73?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant73NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant74))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant74JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant74?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant74NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant75))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant75JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant75?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant75NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant76))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant76JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant76?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant76NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant77))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant77JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant77?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant77NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant78))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant78JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant78?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant78NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant79))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant79JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant79?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant79NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant80))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant80JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant80?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant80NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant81))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant81JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant81?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant81NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant82))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant82JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant82?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant82NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant83))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant83JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant83?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant83NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant84))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant84JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant84?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant84NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant85))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant85JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant85?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant85NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant86))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant86JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant86?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant86NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant87))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant87JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant87?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant87NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant88))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant88JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant88?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant88NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant89))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant89JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant89?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant89NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant90))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant90JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant90?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant90NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant91))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant91JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant91?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant91NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant92))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant92JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant92?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant92NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant93))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant93JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant93?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant93NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant94))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant94JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant94?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant94NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant95))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant95JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant95?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant95NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant96))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant96JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant96?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant96NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant97))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant97JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant97?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant97NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant98))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant98JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant98?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant98NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant99))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant99JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant99?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant99NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant100))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant100JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant100?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant100NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant101))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant101JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant101?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant101NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant102))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant102JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant102?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant102NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant103))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant103JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant103?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant103NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant104))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant104JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant104?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant104NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant105))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant105JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant105?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant105NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant106))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant106JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant106?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant106NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant107))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant107JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant107?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant107NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant108))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant108JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant108?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant108NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant109))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant109JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant109?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant109NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant110))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant110JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant110?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant110NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant111))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant111JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant111?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant111NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant112))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant112JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant112?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant112NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant113))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant113JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant113?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant113NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant114))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant114JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant114?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant114NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant115))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant115JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant115?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant115NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant116))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant116JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant116?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant116NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant117))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant117JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant117?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant117NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant118))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant118JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant118?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant118NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant119))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant119JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant119?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant119NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant120))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant120JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant120?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant120NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant121))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant121JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant121?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant121NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant122))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant122JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant122?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant122NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant123))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant123JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant123?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant123NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant124))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant124JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant124?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant124NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant125))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant125JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant125?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant125NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant126))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant126JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant126?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant126NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant127))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant127JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant127?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant127NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant128))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant128JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant128?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant128NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant129))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant129JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant129?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant129NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant130))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant130JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant130?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant130NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant131))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant131JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant131?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant131NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant132))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant132JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant132?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant132NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant133))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant133JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant133?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant133NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant134))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant134JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant134?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant134NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant135))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant135JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant135?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant135NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant136))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant136JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant136?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant136NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant137))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant137JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant137?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant137NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant138))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant138JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant138?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant138NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant139))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant139JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant139?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant139NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant140))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant140JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant140?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant140NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant141))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant141JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant141?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant141NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant142))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant142JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant142?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant142NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant143))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant143JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant143?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant143NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant144))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant144JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant144?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant144NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant145))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant145JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant145?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant145NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant146))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant146JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant146?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant146NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant147))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant147JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant147?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant147NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant148))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant148JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant148?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant148NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant149))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant149JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant149?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant149NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant150))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant150JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant150?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant150NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant151))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant151JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant151?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant151NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant152))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant152JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant152?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant152NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant153))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant153JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant153?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant153NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant154))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant154JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant154?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant154NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant155))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant155JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant155?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant155NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant156))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant156JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant156?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant156NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant157))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant157JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant157?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant157NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant158))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant158JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant158?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant158NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant159))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant159JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant159?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant159NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant160))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant160JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant160?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant160NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant161))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant161JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant161?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant161NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant162))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant162JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant162?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant162NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant163))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant163JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant163?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant163NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant164))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant164JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant164?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant164NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant165))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant165JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant165?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant165NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant166))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant166JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant166?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant166NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant167))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant167JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant167?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant167NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant168))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant168JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant168?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant168NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant169))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant169JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant169?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant169NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant170))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant170JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant170?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant170NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant171))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant171JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant171?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant171NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant172))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant172JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant172?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant172NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant173))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant173JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant173?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant173NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant174))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant174JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant174?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant174NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant175))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant175JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMovementVariant175?))
                {
                    return new global::Terra.JsonConverters.StrengthMovementVariant175NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant9))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant9?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant10))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant10?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant11))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant11?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant12))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant12?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant13))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant13?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant14))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant14?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant15))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant15?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant16))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant16JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant16?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant16NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant17))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant17JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant17?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant17NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant18))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant18JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant18?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant18NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant19))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant19JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant19?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant19NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant20))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant20JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant20?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant20NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant21))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant21JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant21?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant21NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant22))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant22JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant22?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant22NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant23))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant23JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant23?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant23NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant24))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant24JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant24?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant24NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant25))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant25JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTargetVariant25?))
                {
                    return new global::Terra.JsonConverters.StrengthTargetVariant25NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant9))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant9?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant10))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant10?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant11))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant11?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant12))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant12?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant13))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant13?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant14))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant14?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant15))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant15?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant16))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant16JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant16?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant16NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant17))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant17JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant17?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant17NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant18))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant18JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant18?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant18NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant19))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant19JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant19?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant19NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant20))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant20JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant20?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant20NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant21))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant21JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant21?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant21NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant22))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant22JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant22?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant22NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant23))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant23JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant23?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant23NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant24))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant24JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant24?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant24NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant25))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant25JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthImplementVariant25?))
                {
                    return new global::Terra.JsonConverters.StrengthImplementVariant25NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant9))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant9?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant10))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant10?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant11))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSurfaceVariant11?))
                {
                    return new global::Terra.JsonConverters.StrengthSurfaceVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripWidthVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthGripWidthVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripWidthVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthGripWidthVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripWidthVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthGripWidthVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripWidthVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthGripWidthVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripWidthVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthGripWidthVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripWidthVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthGripWidthVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthGripOrientationVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthGripOrientationVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLateralityVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthLateralityVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthStanceVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthStanceVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant9))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant9?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant10))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant10?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant11))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant11?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant12))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant12?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant13))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant13?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant14))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant14?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant15))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant15?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant16))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant16JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant16?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant16NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant17))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant17JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant17?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant17NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant18))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant18JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant18?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant18NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant19))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant19JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthPositionVariant19?))
                {
                    return new global::Terra.JsonConverters.StrengthPositionVariant19NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthBarPositionVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthBarPositionVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthTempoVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthTempoVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthRangeOfMotionVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthRangeOfMotionVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthProgrammeVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthProgrammeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthProgrammeVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthProgrammeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthProgrammeVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthProgrammeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthProgrammeVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthProgrammeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant8))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant8?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant9))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant9?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant10))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant10?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant11))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant11?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant12))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant12?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant13))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant13?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant14))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant14?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant15))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant15?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant16))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant16JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant16?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant16NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant17))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant17JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant17?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant17NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant18))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant18JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant18?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant18NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant19))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant19JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant19?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant19NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant20))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant20JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant20?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant20NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant21))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant21JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant21?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant21NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant22))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant22JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant22?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant22NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant23))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant23JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthMuscleVariant23?))
                {
                    return new global::Terra.JsonConverters.StrengthMuscleVariant23NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSourceVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthSourceVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSourceVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthSourceVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSourceVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthSourceVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSourceVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthSourceVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSourceVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthSourceVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSourceVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthSourceVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthLoadTypeVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthLoadTypeVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant1))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant2))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant3))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant4))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant4?))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant5))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant5?))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant6))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant6?))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant7))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StrengthSetTypeVariant7?))
                {
                    return new global::Terra.JsonConverters.StrengthSetTypeVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.EnvironmentTypeVariant1))
                {
                    return new global::Terra.JsonConverters.EnvironmentTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.EnvironmentTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.EnvironmentTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.EnvironmentTypeVariant2))
                {
                    return new global::Terra.JsonConverters.EnvironmentTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.EnvironmentTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.EnvironmentTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.EnvironmentTypeVariant3))
                {
                    return new global::Terra.JsonConverters.EnvironmentTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.EnvironmentTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.EnvironmentTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant1))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant2))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant3))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant4))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant4?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant5))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant5?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant6))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant6?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant7))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant7?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant8))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant8?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant9))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant9?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant10))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant10?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant11))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant11?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant12))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant12?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant13))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant13?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant14))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant14?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant15))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant15?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant16))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant16JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant16?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant16NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant17))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant17JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.CompletionConditionTypeVariant17?))
                {
                    return new global::Terra.JsonConverters.CompletionConditionTypeVariant17NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant1))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant2))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant3))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant4))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant4?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant5))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant5?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant6))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant6?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant7))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant7?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant8))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant8?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant9))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant9?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant10))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant10?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant11))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant11?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant12))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant12?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant13))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant13?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant14))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant14?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant15))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant15?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant16))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant16JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant16?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant16NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant17))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant17JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant17?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant17NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant18))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant18JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant18?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant18NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant19))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant19JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepTargetTypeVariant19?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepTargetTypeVariant19NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant1))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant1?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant2))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant2?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant3))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant3?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant4))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant4?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant5))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutStepIntensityVariant5?))
                {
                    return new global::Terra.JsonConverters.WorkoutStepIntensityVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StepControlTypeVariant1))
                {
                    return new global::Terra.JsonConverters.StepControlTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StepControlTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.StepControlTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StepControlTypeVariant2))
                {
                    return new global::Terra.JsonConverters.StepControlTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.StepControlTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.StepControlTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WeightUnitVariant1))
                {
                    return new global::Terra.JsonConverters.WeightUnitVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WeightUnitVariant1?))
                {
                    return new global::Terra.JsonConverters.WeightUnitVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WeightUnitVariant2))
                {
                    return new global::Terra.JsonConverters.WeightUnitVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WeightUnitVariant2?))
                {
                    return new global::Terra.JsonConverters.WeightUnitVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant1))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant2))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant3))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant4))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant4?))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant5))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant5?))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant6))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant6?))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant7))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimStrokeTypeVariant7?))
                {
                    return new global::Terra.JsonConverters.SwimStrokeTypeVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DrillTypeVariant1))
                {
                    return new global::Terra.JsonConverters.DrillTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DrillTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.DrillTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DrillTypeVariant2))
                {
                    return new global::Terra.JsonConverters.DrillTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DrillTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.DrillTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DrillTypeVariant3))
                {
                    return new global::Terra.JsonConverters.DrillTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DrillTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.DrillTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant1))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant1?))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant2))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant2?))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant3))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant3?))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant4))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant4?))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant5))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant5?))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant6))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SwimEquipmentTypeVariant6?))
                {
                    return new global::Terra.JsonConverters.SwimEquipmentTypeVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant1))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant1JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant1?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant2))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant2JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant2?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant3))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant3JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant3?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant3NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant4))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant4JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant4?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant4NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant5))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant5JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant5?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant5NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant6))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant6JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant6?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant6NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant7))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant7JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant7?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant7NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant8))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant8JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant8?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant8NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant9))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant9JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant9?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant9NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant10))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant10JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant10?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant10NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant11))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant11JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant11?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant11NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant12))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant12JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant12?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant12NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant13))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant13JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant13?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant13NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant14))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant14JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant14?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant14NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant15))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant15JsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutSportVariant15?))
                {
                    return new global::Terra.JsonConverters.WorkoutSportVariant15NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PlannedWorkoutSportEnum))
                {
                    return new global::Terra.JsonConverters.PlannedWorkoutSportEnumJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PlannedWorkoutSportEnum?))
                {
                    return new global::Terra.JsonConverters.PlannedWorkoutSportEnumNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthSuccessEventType))
                {
                    return new global::Terra.JsonConverters.AuthSuccessEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthSuccessEventType?))
                {
                    return new global::Terra.JsonConverters.AuthSuccessEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthSuccessEventStatus))
                {
                    return new global::Terra.JsonConverters.AuthSuccessEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthSuccessEventStatus?))
                {
                    return new global::Terra.JsonConverters.AuthSuccessEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthErrorEventType))
                {
                    return new global::Terra.JsonConverters.AuthErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthErrorEventType?))
                {
                    return new global::Terra.JsonConverters.AuthErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthErrorEventStatus))
                {
                    return new global::Terra.JsonConverters.AuthErrorEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthErrorEventStatus?))
                {
                    return new global::Terra.JsonConverters.AuthErrorEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeauthEventType))
                {
                    return new global::Terra.JsonConverters.DeauthEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeauthEventType?))
                {
                    return new global::Terra.JsonConverters.DeauthEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeauthEventStatus))
                {
                    return new global::Terra.JsonConverters.DeauthEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DeauthEventStatus?))
                {
                    return new global::Terra.JsonConverters.DeauthEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserReauthEventType))
                {
                    return new global::Terra.JsonConverters.UserReauthEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserReauthEventType?))
                {
                    return new global::Terra.JsonConverters.UserReauthEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserReauthEventStatus))
                {
                    return new global::Terra.JsonConverters.UserReauthEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserReauthEventStatus?))
                {
                    return new global::Terra.JsonConverters.UserReauthEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AccessRevokedEventType))
                {
                    return new global::Terra.JsonConverters.AccessRevokedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AccessRevokedEventType?))
                {
                    return new global::Terra.JsonConverters.AccessRevokedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AccessRevokedEventStatus))
                {
                    return new global::Terra.JsonConverters.AccessRevokedEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AccessRevokedEventStatus?))
                {
                    return new global::Terra.JsonConverters.AccessRevokedEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PermissionChangeEventType))
                {
                    return new global::Terra.JsonConverters.PermissionChangeEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PermissionChangeEventType?))
                {
                    return new global::Terra.JsonConverters.PermissionChangeEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PermissionChangeEventStatus))
                {
                    return new global::Terra.JsonConverters.PermissionChangeEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PermissionChangeEventStatus?))
                {
                    return new global::Terra.JsonConverters.PermissionChangeEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ConnectionErrorEventType))
                {
                    return new global::Terra.JsonConverters.ConnectionErrorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ConnectionErrorEventType?))
                {
                    return new global::Terra.JsonConverters.ConnectionErrorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ConnectionErrorEventStatus))
                {
                    return new global::Terra.JsonConverters.ConnectionErrorEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ConnectionErrorEventStatus?))
                {
                    return new global::Terra.JsonConverters.ConnectionErrorEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LargeRequestSendingEventType))
                {
                    return new global::Terra.JsonConverters.LargeRequestSendingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LargeRequestSendingEventType?))
                {
                    return new global::Terra.JsonConverters.LargeRequestSendingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LargeRequestProcessingEventType))
                {
                    return new global::Terra.JsonConverters.LargeRequestProcessingEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LargeRequestProcessingEventType?))
                {
                    return new global::Terra.JsonConverters.LargeRequestProcessingEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LargeRequestProcessingEventStatus))
                {
                    return new global::Terra.JsonConverters.LargeRequestProcessingEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LargeRequestProcessingEventStatus?))
                {
                    return new global::Terra.JsonConverters.LargeRequestProcessingEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.S3PayloadEventType))
                {
                    return new global::Terra.JsonConverters.S3PayloadEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.S3PayloadEventType?))
                {
                    return new global::Terra.JsonConverters.S3PayloadEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.S3PayloadEventStatus))
                {
                    return new global::Terra.JsonConverters.S3PayloadEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.S3PayloadEventStatus?))
                {
                    return new global::Terra.JsonConverters.S3PayloadEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ActivityEventType))
                {
                    return new global::Terra.JsonConverters.ActivityEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.ActivityEventType?))
                {
                    return new global::Terra.JsonConverters.ActivityEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AthleteEventType))
                {
                    return new global::Terra.JsonConverters.AthleteEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AthleteEventType?))
                {
                    return new global::Terra.JsonConverters.AthleteEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.NutritionEventType))
                {
                    return new global::Terra.JsonConverters.NutritionEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.NutritionEventType?))
                {
                    return new global::Terra.JsonConverters.NutritionEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DailyEventType))
                {
                    return new global::Terra.JsonConverters.DailyEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.DailyEventType?))
                {
                    return new global::Terra.JsonConverters.DailyEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SleepEventType))
                {
                    return new global::Terra.JsonConverters.SleepEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.SleepEventType?))
                {
                    return new global::Terra.JsonConverters.SleepEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.MenstruationEventType))
                {
                    return new global::Terra.JsonConverters.MenstruationEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.MenstruationEventType?))
                {
                    return new global::Terra.JsonConverters.MenstruationEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.BodyEventType))
                {
                    return new global::Terra.JsonConverters.BodyEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.BodyEventType?))
                {
                    return new global::Terra.JsonConverters.BodyEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LabReportCompletedEventType))
                {
                    return new global::Terra.JsonConverters.LabReportCompletedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LabReportCompletedEventType?))
                {
                    return new global::Terra.JsonConverters.LabReportCompletedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LabReportFailedEventType))
                {
                    return new global::Terra.JsonConverters.LabReportFailedEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.LabReportFailedEventType?))
                {
                    return new global::Terra.JsonConverters.LabReportFailedEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PlannedWorkoutEventType))
                {
                    return new global::Terra.JsonConverters.PlannedWorkoutEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.PlannedWorkoutEventType?))
                {
                    return new global::Terra.JsonConverters.PlannedWorkoutEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.HormoneEventType))
                {
                    return new global::Terra.JsonConverters.HormoneEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.HormoneEventType?))
                {
                    return new global::Terra.JsonConverters.HormoneEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.HealthObservationEventType))
                {
                    return new global::Terra.JsonConverters.HealthObservationEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.HealthObservationEventType?))
                {
                    return new global::Terra.JsonConverters.HealthObservationEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserRequestSdkApp))
                {
                    return new global::Terra.JsonConverters.AuthenticationAuthenticateUserRequestSdkAppJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserRequestSdkApp?))
                {
                    return new global::Terra.JsonConverters.AuthenticationAuthenticateUserRequestSdkAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus))
                {
                    return new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationAuthenticateUserResponseStatus?))
                {
                    return new global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus))
                {
                    return new global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationGenerateWidgetSessionResponseStatus?))
                {
                    return new global::Terra.JsonConverters.AuthenticationGenerateWidgetSessionResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus))
                {
                    return new global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.AuthenticationDeauthenticateUserResponseStatus?))
                {
                    return new global::Terra.JsonConverters.AuthenticationDeauthenticateUserResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutsCreateWorkoutResponseStatus))
                {
                    return new global::Terra.JsonConverters.WorkoutsCreateWorkoutResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutsCreateWorkoutResponseStatus?))
                {
                    return new global::Terra.JsonConverters.WorkoutsCreateWorkoutResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutsPlanWorkoutResponseStatus))
                {
                    return new global::Terra.JsonConverters.WorkoutsPlanWorkoutResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.WorkoutsPlanWorkoutResponseStatus?))
                {
                    return new global::Terra.JsonConverters.WorkoutsPlanWorkoutResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserGetResponseStatus))
                {
                    return new global::Terra.JsonConverters.UserGetResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserGetResponseStatus?))
                {
                    return new global::Terra.JsonConverters.UserGetResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserListResponseStatus))
                {
                    return new global::Terra.JsonConverters.UserListResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.UserListResponseStatus?))
                {
                    return new global::Terra.JsonConverters.UserListResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.IntegrationsListResponseStatus))
                {
                    return new global::Terra.JsonConverters.IntegrationsListResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Terra.IntegrationsListResponseStatus?))
                {
                    return new global::Terra.JsonConverters.IntegrationsListResponseStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[3];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
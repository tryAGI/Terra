
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutTemplate? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.EnvironmentType? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StepBlock>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepBlock? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSport? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkout? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutSummary? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.CoercionWarning>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CoercionWarning? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutBody? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutUpdateResponse? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutUpdateResponseStatus? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutUpdateResult>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutUpdateResult? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutUpdateResultStatus? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutSport? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Problem? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WidgetSessionParams? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TerraUser? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DataSentToWebhook? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DataSentToWebhookStatus? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DataSentToWebhookUser? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Activity? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ActiveDurationsData? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CaloriesData? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DataEnrichment? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DeviceData? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DistanceData? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.EnergyData? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartRateData? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LapData? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.METData? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ActivityMetadata? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MovementData? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OxygenData? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PolylineMapData? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PositionData? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ActivityStrengthData? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PowerData? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrainData? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TSSData? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkData? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Athlete? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AthleteCollection? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Body? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BloodPressureData? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartData? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HydrationData? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.KetoneData? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MeasurementsData? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BodyMetadata? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TemperatureData? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.GlucoseData? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Daily? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DailyDataEnrichment? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TrendsData? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DailyDistanceData? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DailyMetadata? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ScoresData? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StressData? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TagData? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Menstruation? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MenstruationMetadata? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MenstruationData? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HormoneSample? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Connection? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Nutrition? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.DrinkSample>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrinkSample? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Meal>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Meal? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionMetadata? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionSummary? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Sleep? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepDataEnrichment? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepMetadata? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ReadinessData? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.RespirationData? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepScores? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepDurationsData? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepTemperatureData? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthSuccessEvent? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthErrorEvent? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PermissionChangeEvent? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserReauthEvent? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DeauthEvent? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AccessRevokedEvent? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ConnectionErrorEvent? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LargeRequestSendingEvent? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LargeRequestProcessingEvent? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.S3PayloadEvent? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ActivityEvent? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DailyEvent? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionEvent? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AthleteEvent? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepEvent? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MenstruationEvent? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BodyEvent? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutEvent? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HormoneEvent? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HealthObservationEvent? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportWebhook? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportCompletedEvent? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportFailedEvent? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.IntegrationsResponse? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.IntegrationProvider>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.IntegrationProvider? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.IntegrationProviderTypes? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WebhookEventType? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportUploadResponse? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportReprocessResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportListResponse? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportSession>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportSession? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportListPage? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ReportType? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportStatusEntry>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportStatusEntry? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportResult>? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportResult? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportPanel>? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportPanel? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportEventError? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportResultSource? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportBiomarker? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportMeasurement? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportInterpretation? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportReferenceRange>? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportReferenceRange? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AnatomicalRegion? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportBoundedValue? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportQualitativeValue? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportAppliedRange? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportRangeContext? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportDeliveriesResponse? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportDelivery>? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportDelivery? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportFilesResponse? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportFile>? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportFile? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportArtifactsResponse? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UnauthorizedProblem? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ActivityLevelSample? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.ActivityLevelSample>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CalorieSample? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.CalorieSample>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.RecordFloat? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DeviceDataType? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OtherDeviceData? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.DeviceDataType>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.OtherDeviceData>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DistanceSample? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ElevationSample? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.FloorsClimbedSample? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepSample? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DistanceDataDetailed? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.DistanceSample>? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.ElevationSample>? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.FloorsClimbedSample>? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StepSample>? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ElevationData? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimmingData? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DistanceDataSummary? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartRateDataSample? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartRateVariabilityDataSampleRMSSD? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartRateVariabilityDataSampleSDNN? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartRateDataDetailed? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.HeartRateDataSample>? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleRMSSD>? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.HeartRateVariabilityDataSampleSDNN>? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartRateZoneData? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HeartRateDataSummary? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.HeartRateZoneData>? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LapSample? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LapSample>? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.METSample? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.METSample>? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CadenceSample? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SpeedSample? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TorqueSample? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.CadenceSample>? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.SpeedSample>? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.TorqueSample>? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OxygenSaturationSample? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.Vo2MaxSample? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.OxygenSaturationSample>? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Vo2MaxSample>? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PositionSample? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PositionSample>? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovement? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant1? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant2? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant3? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant4? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant5? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant6? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant7? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant8? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant9? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant10? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant11? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant12? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant13? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant14? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant15? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant16? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant17? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant18? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant19? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant20? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant21? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant22? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant23? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant24? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant25? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant26? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant27? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant28? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant29? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant30? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant31? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant32? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant33? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant34? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant35? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant36? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant37? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant38? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant39? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant40? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant41? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant42? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant43? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant44? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant45? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant46? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant47? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant48? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant49? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant50? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant51? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant52? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant53? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant54? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant55? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant56? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant57? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant58? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant59? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant60? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant61? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant62? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant63? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant64? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant65? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant66? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant67? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant68? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant69? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant70? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant71? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant72? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant73? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant74? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant75? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant76? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant77? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant78? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant79? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant80? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant81? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant82? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant83? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant84? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant85? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant86? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant87? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant88? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant89? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant90? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant91? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant92? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant93? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant94? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant95? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant96? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant97? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant98? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant99? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant100? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant101? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant102? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant103? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant104? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant105? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant106? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant107? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant108? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant109? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant110? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant111? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant112? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant113? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant114? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant115? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant116? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant117? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant118? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant119? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant120? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant121? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant122? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant123? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant124? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant125? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant126? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant127? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant128? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant129? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant130? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant131? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant132? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant133? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant134? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant135? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant136? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant137? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant138? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant139? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant140? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant141? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant142? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant143? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant144? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant145? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant146? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant147? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant148? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant149? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant150? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant151? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant152? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant153? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant154? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant155? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant156? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant157? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant158? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant159? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant160? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant161? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant162? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant163? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant164? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant165? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant166? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant167? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant168? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant169? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant170? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant171? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant172? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant173? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant174? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant175? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTarget? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant1? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant2? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant3? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant4? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant5? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant6? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant7? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant8? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant9? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant10? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant11? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant12? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant13? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant14? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant15? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant16? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant17? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant18? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant19? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant20? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant21? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant22? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant23? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant24? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTargetVariant25? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplement? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant1? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant2? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant3? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant4? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant5? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant6? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant7? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant8? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant9? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant10? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant11? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant12? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant13? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant14? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant15? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant16? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant17? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant18? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant19? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant20? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant21? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant22? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant23? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant24? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthImplementVariant25? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurface? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant1? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant2? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant3? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant4? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant5? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant6? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant7? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant8? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant9? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant10? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant11? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripWidth? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripWidthVariant1? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripWidthVariant2? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripWidthVariant3? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientation? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant1? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant2? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant3? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant4? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant5? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant6? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant7? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant8? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLaterality? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant1? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant2? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant3? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant4? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStance? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant1? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant2? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant3? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant4? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant5? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPosition? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant1? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant2? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant3? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant4? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant5? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant6? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant7? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant8? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant9? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant10? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant11? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant12? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant13? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant14? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant15? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant16? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant17? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant18? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant19? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPosition? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant1? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant2? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant3? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant4? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant5? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant6? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant7? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempo? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant1? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant2? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant3? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant4? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant5? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant6? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant7? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthTempoVariant8? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotion? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant1? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant2? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant3? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant4? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant5? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant6? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant7? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthProgramme? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthProgrammeVariant1? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthProgrammeVariant2? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthExerciseModifiers? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscle? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant1? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant2? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant3? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant4? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant5? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant6? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant7? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant8? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant9? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant10? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant11? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant12? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant13? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant14? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant15? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant16? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant17? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant18? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant19? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant20? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant21? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant22? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant23? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSource? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSourceVariant1? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSourceVariant2? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSourceVariant3? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLoadType? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant1? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant2? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant3? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant4? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant5? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetType? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant1? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant2? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant3? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant4? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant5? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant6? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant7? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSet? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthExercise? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StrengthMovement>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StrengthMuscle>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StrengthSet>? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StrengthExercise>? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PowerSample? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PowerSample>? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TSSSample? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.TSSSample>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BloodPressureSample? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.BloodPressureSample>? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AFibClassificationSample? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.RawECGSample? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ECGReading? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.RawECGSample>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PulseVelocitySample? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.RRIntervalSample? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.AFibClassificationSample>? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.ECGReading>? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PulseVelocitySample>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.RRIntervalSample>? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HydrationMeasurementSample? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.HydrationMeasurementSample>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.KetoneSample? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.KetoneSample>? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MeasurementDataSample? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.MeasurementDataSample>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TemperatureSample? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.TemperatureSample>? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.GlucoseDataSample? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DailyPatternSample? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.GlucoseDataSample>? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.DailyPatternSample>? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MetricTrend? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StressSample? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BodyBatterySample? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StressSample>? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.BodyBatterySample>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.TagEntry? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.TagEntry>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MenstruationFlowSample? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MenstruationIntervalSample? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.MenstruationFlowSample>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.MenstruationIntervalSample>? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionMicros? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionQuantity? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionMacros? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BreathSample? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BreathsData? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.BreathSample>? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OxygenSaturationData? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SnoringSample? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SnoringData? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.SnoringSample>? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AsleepDurations? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AwakeDurations? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepHypnogramSample? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OtherSleepDurations? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.SleepHypnogramSample>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.EnvironmentTypeVariant1? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.EnvironmentTypeVariant2? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.EnvironmentTypeVariant3? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionType? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant1? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant2? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant3? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant4? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant5? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant6? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant7? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant8? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant9? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant10? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant11? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant12? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant13? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant14? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant15? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant16? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionConditionTypeVariant17? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.CompletionCondition? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetType? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant1? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant2? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant3? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant4? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant5? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant6? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant7? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant8? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant9? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant10? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant11? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant12? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant13? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant14? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant15? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant16? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant17? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant18? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant19? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.IntensityTarget? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepIntensity? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant1? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant2? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant3? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant4? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant5? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepControlType? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepControlTypeVariant1? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepControlTypeVariant2? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepControl? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WeightUnit? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WeightUnitVariant1? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WeightUnitVariant2? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthData? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeType? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant1? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant2? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant3? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant4? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant5? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant6? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant7? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrillType? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrillTypeVariant1? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrillTypeVariant2? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrillTypeVariant3? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentType? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant1? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant2? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant3? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant4? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant5? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant6? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimStepData? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.SwimEquipmentType>? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStep? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.IntensityTarget>? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.StepControl>? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.WorkoutStep>? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant1? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant2? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant3? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant4? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant5? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant6? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant7? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant8? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant9? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant10? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant11? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant12? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant13? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant14? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant15? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AthleteMetrics? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutSportEnum? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutDetailsMetadata? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutDetailsStepDuration? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutDetailsStepTarget? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutDetailsStep? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepDuration>? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStepTarget>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkoutDetailsStep>? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutDetails? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WebhookEvent? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthSuccessEventType? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthSuccessEventStatus? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthErrorEventType? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthErrorEventStatus? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DeauthEventType? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DeauthEventStatus? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserReauthEventType? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserReauthEventStatus? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AccessRevokedEventType? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AccessRevokedEventStatus? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PermissionChangeEventType? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PermissionChangeEventStatus? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ConnectionErrorEventType? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ConnectionErrorEventStatus? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LargeRequestSendingEventType? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LargeRequestProcessingEventType? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LargeRequestProcessingEventStatus? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.S3PayloadEventType? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.S3PayloadEventStatus? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ActivityEventType? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Activity>? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AthleteEventType? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionEventType? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Nutrition>? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DailyEventType? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Daily>? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepEventType? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Sleep>? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MenstruationEventType? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Menstruation>? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BodyEventType? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.Body>? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportEventResultSource? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportEventResult? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportEventData? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.LabReportEventResult>? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportCompletedEventType? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportFailureData? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportFailedEventType? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutEventType? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.PlannedWorkout>? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HormoneEventType? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.HormoneSample>? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HealthObservationMetadata? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ObservationCode? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ObservationValue? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ObservationComponent? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HealthObservationData? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.ObservationCode>? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.ObservationComponent>? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HealthObservation? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.HealthObservationEventType? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.HealthObservation>? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationAuthenticateUserRequest? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationAuthenticateUserRequestSdkApp? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutsPlanWorkoutRequest? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutsUpdatePlannedWorkoutRequest? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ReportsUploadRequest? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportsUploadRequest? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<int?, global::System.DateTime?>? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ReportsListReportType? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportsListReportType? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationAuthenticateUserResponse? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationAuthenticateUserResponseStatus? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationGenerateWidgetSessionResponse? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationGenerateWidgetSessionResponseStatus? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationDeauthenticateUserResponse? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationDeauthenticateUserResponseStatus? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationCreateAuthTokenResponse? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AuthenticationGenerateAuthTokenResponse? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.ActivityGetResponse2, global::Terra.DataSentToWebhook>? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.ActivityGetResponse2? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.BodyGetResponse2, global::Terra.DataSentToWebhook>? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.BodyGetResponse2? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.DailyGetResponse2, global::Terra.DataSentToWebhook>? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.DailyGetResponse2? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.MenstruationGetResponse2, global::Terra.DataSentToWebhook>? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.MenstruationGetResponse2? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.NutritionGetResponse2, global::Terra.DataSentToWebhook>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.NutritionGetResponse2? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.SleepGetResponse2, global::Terra.DataSentToWebhook>? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.SleepGetResponse2? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutsCreateWorkoutResponse? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutsCreateWorkoutResponseStatus? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.WorkoutTemplate>? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutsDeleteWorkoutResponse? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutsPlanWorkoutResponse? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutsPlanWorkoutResponseStatus? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.UserGetResponse2, global::System.Collections.Generic.IList<global::Terra.TerraUser>>? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserGetResponse2? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.AllOf<global::Terra.TerraUser, global::Terra.UserGetResponseUser>? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserGetResponseUser? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserGetResponseStatus? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Terra.TerraUser>? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserListResponse? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.UserListResponseStatus? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.IntegrationsListResponse? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.IntegrationsListResponseStatus? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.LabReportListPage, global::Terra.LabReportListResponse>? Type822 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StepBlock>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.CoercionWarning>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PlannedWorkoutUpdateResult>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.DrinkSample>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Meal>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.IntegrationProvider>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportSession>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportStatusEntry>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportResult>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportPanel>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportReferenceRange>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportDelivery>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportFile>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.ActivityLevelSample>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.CalorieSample>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.DeviceDataType>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.OtherDeviceData>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.DistanceSample>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.ElevationSample>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.FloorsClimbedSample>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StepSample>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.HeartRateDataSample>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.HeartRateVariabilityDataSampleRMSSD>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.HeartRateVariabilityDataSampleSDNN>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.HeartRateZoneData>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LapSample>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.METSample>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.CadenceSample>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.SpeedSample>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.TorqueSample>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.OxygenSaturationSample>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Vo2MaxSample>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PositionSample>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StrengthMovement>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StrengthMuscle>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StrengthSet>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StrengthExercise>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PowerSample>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.TSSSample>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.BloodPressureSample>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.RawECGSample>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.AFibClassificationSample>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.ECGReading>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PulseVelocitySample>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.RRIntervalSample>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.HydrationMeasurementSample>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.KetoneSample>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.MeasurementDataSample>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.TemperatureSample>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.GlucoseDataSample>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.DailyPatternSample>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StressSample>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.BodyBatterySample>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.TagEntry>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.MenstruationFlowSample>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.MenstruationIntervalSample>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.BreathSample>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.SnoringSample>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.SleepHypnogramSample>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.SwimEquipmentType>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.IntensityTarget>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.StepControl>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.WorkoutStep>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PlannedWorkoutDetailsStepDuration>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PlannedWorkoutDetailsStepTarget>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PlannedWorkoutDetailsStep>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Activity>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Nutrition>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Daily>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Sleep>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Menstruation>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.Body>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.LabReportEventResult>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.PlannedWorkout>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.HormoneSample>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.ObservationCode>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.ObservationComponent>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.HealthObservation>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.WorkoutTemplate>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Terra.OneOf<global::Terra.UserGetResponse2, global::System.Collections.Generic.List<global::Terra.TerraUser>>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Terra.TerraUser>? ListType83 { get; set; }
    }
}
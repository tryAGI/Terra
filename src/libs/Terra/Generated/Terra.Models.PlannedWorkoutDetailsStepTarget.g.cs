
#nullable enable

namespace Terra
{
    /// <summary>
    /// Intensity target of a provider planned-workout step
    /// </summary>
    public sealed partial class PlannedWorkoutDetailsStepTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TargetType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_bpm_high")]
        public double? HrBpmHigh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_bpm_low")]
        public double? HrBpmLow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        public double? Cadence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence_high")]
        public double? CadenceHigh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence_low")]
        public double? CadenceLow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_watt")]
        public double? PowerWatt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_watt_high")]
        public double? PowerWattHigh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_watt_low")]
        public double? PowerWattLow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("swim_strokes")]
        public double? SwimStrokes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_percentage")]
        public double? HrPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_percentage_high")]
        public double? HrPercentageHigh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hr_percentage_low")]
        public double? HrPercentageLow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_percentage")]
        public double? SpeedPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_percentage_high")]
        public double? SpeedPercentageHigh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_percentage_low")]
        public double? SpeedPercentageLow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_percentage")]
        public double? PowerPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_percentage_high")]
        public double? PowerPercentageHigh { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("power_percentage_low")]
        public double? PowerPercentageLow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitions")]
        public int? Repetitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_meters_per_second")]
        public double? SpeedMetersPerSecond { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_meters_per_second_low")]
        public double? SpeedMetersPerSecondLow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed_meters_per_second_high")]
        public double? SpeedMetersPerSecondHigh { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsStepTarget" /> class.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="hrBpmHigh"></param>
        /// <param name="hrBpmLow"></param>
        /// <param name="cadence"></param>
        /// <param name="cadenceHigh"></param>
        /// <param name="cadenceLow"></param>
        /// <param name="powerWatt"></param>
        /// <param name="powerWattHigh"></param>
        /// <param name="powerWattLow"></param>
        /// <param name="swimStrokes"></param>
        /// <param name="hrPercentage"></param>
        /// <param name="hrPercentageHigh"></param>
        /// <param name="hrPercentageLow"></param>
        /// <param name="speedPercentage"></param>
        /// <param name="speedPercentageHigh"></param>
        /// <param name="speedPercentageLow"></param>
        /// <param name="powerPercentage"></param>
        /// <param name="powerPercentageHigh"></param>
        /// <param name="powerPercentageLow"></param>
        /// <param name="repetitions"></param>
        /// <param name="speedMetersPerSecond"></param>
        /// <param name="speedMetersPerSecondLow"></param>
        /// <param name="speedMetersPerSecondHigh"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlannedWorkoutDetailsStepTarget(
            int targetType,
            double? hrBpmHigh,
            double? hrBpmLow,
            double? cadence,
            double? cadenceHigh,
            double? cadenceLow,
            double? powerWatt,
            double? powerWattHigh,
            double? powerWattLow,
            double? swimStrokes,
            double? hrPercentage,
            double? hrPercentageHigh,
            double? hrPercentageLow,
            double? speedPercentage,
            double? speedPercentageHigh,
            double? speedPercentageLow,
            double? powerPercentage,
            double? powerPercentageHigh,
            double? powerPercentageLow,
            int? repetitions,
            double? speedMetersPerSecond,
            double? speedMetersPerSecondLow,
            double? speedMetersPerSecondHigh)
        {
            this.TargetType = targetType;
            this.HrBpmHigh = hrBpmHigh;
            this.HrBpmLow = hrBpmLow;
            this.Cadence = cadence;
            this.CadenceHigh = cadenceHigh;
            this.CadenceLow = cadenceLow;
            this.PowerWatt = powerWatt;
            this.PowerWattHigh = powerWattHigh;
            this.PowerWattLow = powerWattLow;
            this.SwimStrokes = swimStrokes;
            this.HrPercentage = hrPercentage;
            this.HrPercentageHigh = hrPercentageHigh;
            this.HrPercentageLow = hrPercentageLow;
            this.SpeedPercentage = speedPercentage;
            this.SpeedPercentageHigh = speedPercentageHigh;
            this.SpeedPercentageLow = speedPercentageLow;
            this.PowerPercentage = powerPercentage;
            this.PowerPercentageHigh = powerPercentageHigh;
            this.PowerPercentageLow = powerPercentageLow;
            this.Repetitions = repetitions;
            this.SpeedMetersPerSecond = speedMetersPerSecond;
            this.SpeedMetersPerSecondLow = speedMetersPerSecondLow;
            this.SpeedMetersPerSecondHigh = speedMetersPerSecondHigh;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlannedWorkoutDetailsStepTarget" /> class.
        /// </summary>
        public PlannedWorkoutDetailsStepTarget()
        {
        }

    }
}
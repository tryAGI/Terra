
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasurementsData
    {
        /// <summary>
        /// List of body metrics &amp; measurements taken throughout the associated day.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurements")]
        public global::System.Collections.Generic.IList<global::Terra.MeasurementDataSample>? Measurements { get; set; }

        /// <summary>
        /// Day-average body mass index (BMI).<br/>
        /// Example: 22.5
        /// </summary>
        /// <example>22.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_bmi")]
        public double? DayAvgBmi { get; set; }

        /// <summary>
        /// Day-average basal metabolic rate (BMR), in kilocalories.<br/>
        /// Example: 1600
        /// </summary>
        /// <example>1600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_bmr")]
        public double? DayAvgBmr { get; set; }

        /// <summary>
        /// Day-average resting metabolic rate (RMR), in kilocalories.<br/>
        /// Example: 1500
        /// </summary>
        /// <example>1500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_rmr")]
        public double? DayAvgRmr { get; set; }

        /// <summary>
        /// Day-average estimated fitness age, in years.<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_estimated_fitness_age")]
        public double? DayAvgEstimatedFitnessAge { get; set; }

        /// <summary>
        /// Day-average skin fold thickness, in millimetres.<br/>
        /// Example: 12.5
        /// </summary>
        /// <example>12.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_skin_fold_mm")]
        public double? DayAvgSkinFoldMm { get; set; }

        /// <summary>
        /// Day-average body-fat percentage.<br/>
        /// Example: 18.2
        /// </summary>
        /// <example>18.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_bodyfat_percentage")]
        public double? DayAvgBodyfatPercentage { get; set; }

        /// <summary>
        /// Day-average weight, in kilograms.<br/>
        /// Example: 70.5
        /// </summary>
        /// <example>70.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_weight_kg")]
        public double? DayAvgWeightKg { get; set; }

        /// <summary>
        /// Day-average height, in centimetres.<br/>
        /// Example: 175
        /// </summary>
        /// <example>175</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_height_cm")]
        public double? DayAvgHeightCm { get; set; }

        /// <summary>
        /// Day-average bone mass, in grams.<br/>
        /// Example: 3200
        /// </summary>
        /// <example>3200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_bone_mass_g")]
        public double? DayAvgBoneMassG { get; set; }

        /// <summary>
        /// Day-average muscle mass, in grams.<br/>
        /// Example: 32000
        /// </summary>
        /// <example>32000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_muscle_mass_g")]
        public double? DayAvgMuscleMassG { get; set; }

        /// <summary>
        /// Day-average lean mass, in grams.<br/>
        /// Example: 55000
        /// </summary>
        /// <example>55000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_lean_mass_g")]
        public double? DayAvgLeanMassG { get; set; }

        /// <summary>
        /// Day-average body-water percentage.<br/>
        /// Example: 55
        /// </summary>
        /// <example>55</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_water_percentage")]
        public double? DayAvgWaterPercentage { get; set; }

        /// <summary>
        /// Day-average insulin, in units.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_insulin_units")]
        public double? DayAvgInsulinUnits { get; set; }

        /// <summary>
        /// Day-average visceral fat level.<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("day_avg_visceral_fat_level")]
        public double? DayAvgVisceralFatLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsData" /> class.
        /// </summary>
        /// <param name="measurements">
        /// List of body metrics &amp; measurements taken throughout the associated day.
        /// </param>
        /// <param name="dayAvgBmi">
        /// Day-average body mass index (BMI).<br/>
        /// Example: 22.5
        /// </param>
        /// <param name="dayAvgBmr">
        /// Day-average basal metabolic rate (BMR), in kilocalories.<br/>
        /// Example: 1600
        /// </param>
        /// <param name="dayAvgRmr">
        /// Day-average resting metabolic rate (RMR), in kilocalories.<br/>
        /// Example: 1500
        /// </param>
        /// <param name="dayAvgEstimatedFitnessAge">
        /// Day-average estimated fitness age, in years.<br/>
        /// Example: 30
        /// </param>
        /// <param name="dayAvgSkinFoldMm">
        /// Day-average skin fold thickness, in millimetres.<br/>
        /// Example: 12.5
        /// </param>
        /// <param name="dayAvgBodyfatPercentage">
        /// Day-average body-fat percentage.<br/>
        /// Example: 18.2
        /// </param>
        /// <param name="dayAvgWeightKg">
        /// Day-average weight, in kilograms.<br/>
        /// Example: 70.5
        /// </param>
        /// <param name="dayAvgHeightCm">
        /// Day-average height, in centimetres.<br/>
        /// Example: 175
        /// </param>
        /// <param name="dayAvgBoneMassG">
        /// Day-average bone mass, in grams.<br/>
        /// Example: 3200
        /// </param>
        /// <param name="dayAvgMuscleMassG">
        /// Day-average muscle mass, in grams.<br/>
        /// Example: 32000
        /// </param>
        /// <param name="dayAvgLeanMassG">
        /// Day-average lean mass, in grams.<br/>
        /// Example: 55000
        /// </param>
        /// <param name="dayAvgWaterPercentage">
        /// Day-average body-water percentage.<br/>
        /// Example: 55
        /// </param>
        /// <param name="dayAvgInsulinUnits">
        /// Day-average insulin, in units.<br/>
        /// Example: 0
        /// </param>
        /// <param name="dayAvgVisceralFatLevel">
        /// Day-average visceral fat level.<br/>
        /// Example: 8
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasurementsData(
            global::System.Collections.Generic.IList<global::Terra.MeasurementDataSample>? measurements,
            double? dayAvgBmi,
            double? dayAvgBmr,
            double? dayAvgRmr,
            double? dayAvgEstimatedFitnessAge,
            double? dayAvgSkinFoldMm,
            double? dayAvgBodyfatPercentage,
            double? dayAvgWeightKg,
            double? dayAvgHeightCm,
            double? dayAvgBoneMassG,
            double? dayAvgMuscleMassG,
            double? dayAvgLeanMassG,
            double? dayAvgWaterPercentage,
            double? dayAvgInsulinUnits,
            double? dayAvgVisceralFatLevel)
        {
            this.Measurements = measurements;
            this.DayAvgBmi = dayAvgBmi;
            this.DayAvgBmr = dayAvgBmr;
            this.DayAvgRmr = dayAvgRmr;
            this.DayAvgEstimatedFitnessAge = dayAvgEstimatedFitnessAge;
            this.DayAvgSkinFoldMm = dayAvgSkinFoldMm;
            this.DayAvgBodyfatPercentage = dayAvgBodyfatPercentage;
            this.DayAvgWeightKg = dayAvgWeightKg;
            this.DayAvgHeightCm = dayAvgHeightCm;
            this.DayAvgBoneMassG = dayAvgBoneMassG;
            this.DayAvgMuscleMassG = dayAvgMuscleMassG;
            this.DayAvgLeanMassG = dayAvgLeanMassG;
            this.DayAvgWaterPercentage = dayAvgWaterPercentage;
            this.DayAvgInsulinUnits = dayAvgInsulinUnits;
            this.DayAvgVisceralFatLevel = dayAvgVisceralFatLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementsData" /> class.
        /// </summary>
        public MeasurementsData()
        {
        }

    }
}
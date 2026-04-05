
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MeasurementDataSample
    {
        /// <summary>
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </summary>
        /// <example>2022-11-23T09:00:00.000000+02:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("measurement_time")]
        public string? MeasurementTime { get; set; }

        /// <summary>
        /// User's Body Mass Index (BMI).<br/>
        /// Example: 22.4
        /// </summary>
        /// <example>22.4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("BMI")]
        public double? Bmi { get; set; }

        /// <summary>
        /// User's Basal Metabolic Rate - minimum amount of calories that a person's body needs to perform necessary functions.<br/>
        /// Example: 1800
        /// </summary>
        /// <example>1800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("BMR")]
        public double? Bmr { get; set; }

        /// <summary>
        /// User's Resting Metabolic Rate - amount of energy that a person's body needs to function while at rest. RMR accounts for additional low-effort daily activities on top of basic body functions.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("RMR")]
        public double? Rmr { get; set; }

        /// <summary>
        /// Estimate of how fit the user is compared to their actual age, as measured by the device.<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_fitness_age")]
        public string? EstimatedFitnessAge { get; set; }

        /// <summary>
        /// User's skin fold measurement.<br/>
        /// Example: 12.5
        /// </summary>
        /// <example>12.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skin_fold_mm")]
        public double? SkinFoldMm { get; set; }

        /// <summary>
        /// User's body fat percentage.<br/>
        /// Example: 18.5
        /// </summary>
        /// <example>18.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bodyfat_percentage")]
        public double? BodyfatPercentage { get; set; }

        /// <summary>
        /// User's body weight.<br/>
        /// Example: 75.5
        /// </summary>
        /// <example>75.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight_kg")]
        public double? WeightKg { get; set; }

        /// <summary>
        /// User's height.<br/>
        /// Example: 178
        /// </summary>
        /// <example>178</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("height_cm")]
        public double? HeightCm { get; set; }

        /// <summary>
        /// User's total bone mass.<br/>
        /// Example: 3200
        /// </summary>
        /// <example>3200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bone_mass_g")]
        public double? BoneMassG { get; set; }

        /// <summary>
        /// User's total muscle mass (i.e. skeletal muscle mass).<br/>
        /// Example: 35000
        /// </summary>
        /// <example>35000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("muscle_mass_g")]
        public double? MuscleMassG { get; set; }

        /// <summary>
        /// Total lean mass of the user - calculated as the difference between total body weight and body fat weight.<br/>
        /// Example: 61500
        /// </summary>
        /// <example>61500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("lean_mass_g")]
        public double? LeanMassG { get; set; }

        /// <summary>
        /// Total amount of fluid in the user's body.<br/>
        /// Example: 60.5
        /// </summary>
        /// <example>60.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("water_percentage")]
        public double? WaterPercentage { get; set; }

        /// <summary>
        /// Quantity of insulin administered to the user.<br/>
        /// Example: 10.5
        /// </summary>
        /// <example>10.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("insulin_units")]
        public double? InsulinUnits { get; set; }

        /// <summary>
        /// Type of insulin administered to the user.<br/>
        /// Example: rapid-acting
        /// </summary>
        /// <example>rapid-acting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("insulin_type")]
        public string? InsulinType { get; set; }

        /// <summary>
        /// Color of the user's urine.<br/>
        /// Example: pale yellow
        /// </summary>
        /// <example>pale yellow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urine_color")]
        public string? UrineColor { get; set; }

        /// <summary>
        /// User notes associated with the measurement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_notes")]
        public string? UserNotes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementDataSample" /> class.
        /// </summary>
        /// <param name="measurementTime">
        /// Time with which the record is associated, in ISO8601 format with microsecond precision. TimeZone info will be provided whenever possible. If absent, the time corresponds to the user's local time.<br/>
        /// Example: 2022-11-23T09:00:00.000000+02:00
        /// </param>
        /// <param name="bmi">
        /// User's Body Mass Index (BMI).<br/>
        /// Example: 22.4
        /// </param>
        /// <param name="bmr">
        /// User's Basal Metabolic Rate - minimum amount of calories that a person's body needs to perform necessary functions.<br/>
        /// Example: 1800
        /// </param>
        /// <param name="rmr">
        /// User's Resting Metabolic Rate - amount of energy that a person's body needs to function while at rest. RMR accounts for additional low-effort daily activities on top of basic body functions.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="estimatedFitnessAge">
        /// Estimate of how fit the user is compared to their actual age, as measured by the device.<br/>
        /// Example: 25
        /// </param>
        /// <param name="skinFoldMm">
        /// User's skin fold measurement.<br/>
        /// Example: 12.5
        /// </param>
        /// <param name="bodyfatPercentage">
        /// User's body fat percentage.<br/>
        /// Example: 18.5
        /// </param>
        /// <param name="weightKg">
        /// User's body weight.<br/>
        /// Example: 75.5
        /// </param>
        /// <param name="heightCm">
        /// User's height.<br/>
        /// Example: 178
        /// </param>
        /// <param name="boneMassG">
        /// User's total bone mass.<br/>
        /// Example: 3200
        /// </param>
        /// <param name="muscleMassG">
        /// User's total muscle mass (i.e. skeletal muscle mass).<br/>
        /// Example: 35000
        /// </param>
        /// <param name="leanMassG">
        /// Total lean mass of the user - calculated as the difference between total body weight and body fat weight.<br/>
        /// Example: 61500
        /// </param>
        /// <param name="waterPercentage">
        /// Total amount of fluid in the user's body.<br/>
        /// Example: 60.5
        /// </param>
        /// <param name="insulinUnits">
        /// Quantity of insulin administered to the user.<br/>
        /// Example: 10.5
        /// </param>
        /// <param name="insulinType">
        /// Type of insulin administered to the user.<br/>
        /// Example: rapid-acting
        /// </param>
        /// <param name="urineColor">
        /// Color of the user's urine.<br/>
        /// Example: pale yellow
        /// </param>
        /// <param name="userNotes">
        /// User notes associated with the measurement.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MeasurementDataSample(
            string? measurementTime,
            double? bmi,
            double? bmr,
            double? rmr,
            string? estimatedFitnessAge,
            double? skinFoldMm,
            double? bodyfatPercentage,
            double? weightKg,
            double? heightCm,
            double? boneMassG,
            double? muscleMassG,
            double? leanMassG,
            double? waterPercentage,
            double? insulinUnits,
            string? insulinType,
            string? urineColor,
            string? userNotes)
        {
            this.MeasurementTime = measurementTime;
            this.Bmi = bmi;
            this.Bmr = bmr;
            this.Rmr = rmr;
            this.EstimatedFitnessAge = estimatedFitnessAge;
            this.SkinFoldMm = skinFoldMm;
            this.BodyfatPercentage = bodyfatPercentage;
            this.WeightKg = weightKg;
            this.HeightCm = heightCm;
            this.BoneMassG = boneMassG;
            this.MuscleMassG = muscleMassG;
            this.LeanMassG = leanMassG;
            this.WaterPercentage = waterPercentage;
            this.InsulinUnits = insulinUnits;
            this.InsulinType = insulinType;
            this.UrineColor = urineColor;
            this.UserNotes = userNotes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MeasurementDataSample" /> class.
        /// </summary>
        public MeasurementDataSample()
        {
        }
    }
}
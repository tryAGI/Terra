
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of exercise to be performed for the workout step
    /// </summary>
    public enum CardioPlannedWorkoutStepExerciseCategory
    {
        /// <summary>
        /// 
        /// </summary>
        BenchPress,
        /// <summary>
        /// 
        /// </summary>
        Bike,
        /// <summary>
        /// 
        /// </summary>
        CalfRaise,
        /// <summary>
        /// 
        /// </summary>
        Cardio,
        /// <summary>
        /// 
        /// </summary>
        CardioSensors,
        /// <summary>
        /// 
        /// </summary>
        Carry,
        /// <summary>
        /// 
        /// </summary>
        Chop,
        /// <summary>
        /// 
        /// </summary>
        Core,
        /// <summary>
        /// 
        /// </summary>
        Crunch,
        /// <summary>
        /// 
        /// </summary>
        Curl,
        /// <summary>
        /// 
        /// </summary>
        Deadlift,
        /// <summary>
        /// 
        /// </summary>
        Flye,
        /// <summary>
        /// 
        /// </summary>
        HipRaise,
        /// <summary>
        /// 
        /// </summary>
        HipStability,
        /// <summary>
        /// 
        /// </summary>
        HipSwing,
        /// <summary>
        /// 
        /// </summary>
        Hyperextension,
        /// <summary>
        /// 
        /// </summary>
        LateralRaise,
        /// <summary>
        /// 
        /// </summary>
        LegCurl,
        /// <summary>
        /// 
        /// </summary>
        LegRaise,
        /// <summary>
        /// 
        /// </summary>
        Lunge,
        /// <summary>
        /// 
        /// </summary>
        OlympicLift,
        /// <summary>
        /// 
        /// </summary>
        Plank,
        /// <summary>
        /// 
        /// </summary>
        Plyo,
        /// <summary>
        /// 
        /// </summary>
        PullUp,
        /// <summary>
        /// 
        /// </summary>
        PushUp,
        /// <summary>
        /// 
        /// </summary>
        Row,
        /// <summary>
        /// 
        /// </summary>
        Run,
        /// <summary>
        /// 
        /// </summary>
        ShoulderPress,
        /// <summary>
        /// 
        /// </summary>
        ShoulderStability,
        /// <summary>
        /// 
        /// </summary>
        Shrug,
        /// <summary>
        /// 
        /// </summary>
        SitUp,
        /// <summary>
        /// 
        /// </summary>
        Squat,
        /// <summary>
        /// 
        /// </summary>
        TotalBody,
        /// <summary>
        /// 
        /// </summary>
        TricepsExtension,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        WarmUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CardioPlannedWorkoutStepExerciseCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CardioPlannedWorkoutStepExerciseCategory value)
        {
            return value switch
            {
                CardioPlannedWorkoutStepExerciseCategory.BenchPress => "BENCH_PRESS",
                CardioPlannedWorkoutStepExerciseCategory.Bike => "BIKE",
                CardioPlannedWorkoutStepExerciseCategory.CalfRaise => "CALF_RAISE",
                CardioPlannedWorkoutStepExerciseCategory.Cardio => "CARDIO",
                CardioPlannedWorkoutStepExerciseCategory.CardioSensors => "CARDIO_SENSORS",
                CardioPlannedWorkoutStepExerciseCategory.Carry => "CARRY",
                CardioPlannedWorkoutStepExerciseCategory.Chop => "CHOP",
                CardioPlannedWorkoutStepExerciseCategory.Core => "CORE",
                CardioPlannedWorkoutStepExerciseCategory.Crunch => "CRUNCH",
                CardioPlannedWorkoutStepExerciseCategory.Curl => "CURL",
                CardioPlannedWorkoutStepExerciseCategory.Deadlift => "DEADLIFT",
                CardioPlannedWorkoutStepExerciseCategory.Flye => "FLYE",
                CardioPlannedWorkoutStepExerciseCategory.HipRaise => "HIP_RAISE",
                CardioPlannedWorkoutStepExerciseCategory.HipStability => "HIP_STABILITY",
                CardioPlannedWorkoutStepExerciseCategory.HipSwing => "HIP_SWING",
                CardioPlannedWorkoutStepExerciseCategory.Hyperextension => "HYPEREXTENSION",
                CardioPlannedWorkoutStepExerciseCategory.LateralRaise => "LATERAL_RAISE",
                CardioPlannedWorkoutStepExerciseCategory.LegCurl => "LEG_CURL",
                CardioPlannedWorkoutStepExerciseCategory.LegRaise => "LEG_RAISE",
                CardioPlannedWorkoutStepExerciseCategory.Lunge => "LUNGE",
                CardioPlannedWorkoutStepExerciseCategory.OlympicLift => "OLYMPIC_LIFT",
                CardioPlannedWorkoutStepExerciseCategory.Plank => "PLANK",
                CardioPlannedWorkoutStepExerciseCategory.Plyo => "PLYO",
                CardioPlannedWorkoutStepExerciseCategory.PullUp => "PULL_UP",
                CardioPlannedWorkoutStepExerciseCategory.PushUp => "PUSH_UP",
                CardioPlannedWorkoutStepExerciseCategory.Row => "ROW",
                CardioPlannedWorkoutStepExerciseCategory.Run => "RUN",
                CardioPlannedWorkoutStepExerciseCategory.ShoulderPress => "SHOULDER_PRESS",
                CardioPlannedWorkoutStepExerciseCategory.ShoulderStability => "SHOULDER_STABILITY",
                CardioPlannedWorkoutStepExerciseCategory.Shrug => "SHRUG",
                CardioPlannedWorkoutStepExerciseCategory.SitUp => "SIT_UP",
                CardioPlannedWorkoutStepExerciseCategory.Squat => "SQUAT",
                CardioPlannedWorkoutStepExerciseCategory.TotalBody => "TOTAL_BODY",
                CardioPlannedWorkoutStepExerciseCategory.TricepsExtension => "TRICEPS_EXTENSION",
                CardioPlannedWorkoutStepExerciseCategory.Unknown => "UNKNOWN",
                CardioPlannedWorkoutStepExerciseCategory.WarmUp => "WARM_UP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CardioPlannedWorkoutStepExerciseCategory? ToEnum(string value)
        {
            return value switch
            {
                "BENCH_PRESS" => CardioPlannedWorkoutStepExerciseCategory.BenchPress,
                "BIKE" => CardioPlannedWorkoutStepExerciseCategory.Bike,
                "CALF_RAISE" => CardioPlannedWorkoutStepExerciseCategory.CalfRaise,
                "CARDIO" => CardioPlannedWorkoutStepExerciseCategory.Cardio,
                "CARDIO_SENSORS" => CardioPlannedWorkoutStepExerciseCategory.CardioSensors,
                "CARRY" => CardioPlannedWorkoutStepExerciseCategory.Carry,
                "CHOP" => CardioPlannedWorkoutStepExerciseCategory.Chop,
                "CORE" => CardioPlannedWorkoutStepExerciseCategory.Core,
                "CRUNCH" => CardioPlannedWorkoutStepExerciseCategory.Crunch,
                "CURL" => CardioPlannedWorkoutStepExerciseCategory.Curl,
                "DEADLIFT" => CardioPlannedWorkoutStepExerciseCategory.Deadlift,
                "FLYE" => CardioPlannedWorkoutStepExerciseCategory.Flye,
                "HIP_RAISE" => CardioPlannedWorkoutStepExerciseCategory.HipRaise,
                "HIP_STABILITY" => CardioPlannedWorkoutStepExerciseCategory.HipStability,
                "HIP_SWING" => CardioPlannedWorkoutStepExerciseCategory.HipSwing,
                "HYPEREXTENSION" => CardioPlannedWorkoutStepExerciseCategory.Hyperextension,
                "LATERAL_RAISE" => CardioPlannedWorkoutStepExerciseCategory.LateralRaise,
                "LEG_CURL" => CardioPlannedWorkoutStepExerciseCategory.LegCurl,
                "LEG_RAISE" => CardioPlannedWorkoutStepExerciseCategory.LegRaise,
                "LUNGE" => CardioPlannedWorkoutStepExerciseCategory.Lunge,
                "OLYMPIC_LIFT" => CardioPlannedWorkoutStepExerciseCategory.OlympicLift,
                "PLANK" => CardioPlannedWorkoutStepExerciseCategory.Plank,
                "PLYO" => CardioPlannedWorkoutStepExerciseCategory.Plyo,
                "PULL_UP" => CardioPlannedWorkoutStepExerciseCategory.PullUp,
                "PUSH_UP" => CardioPlannedWorkoutStepExerciseCategory.PushUp,
                "ROW" => CardioPlannedWorkoutStepExerciseCategory.Row,
                "RUN" => CardioPlannedWorkoutStepExerciseCategory.Run,
                "SHOULDER_PRESS" => CardioPlannedWorkoutStepExerciseCategory.ShoulderPress,
                "SHOULDER_STABILITY" => CardioPlannedWorkoutStepExerciseCategory.ShoulderStability,
                "SHRUG" => CardioPlannedWorkoutStepExerciseCategory.Shrug,
                "SIT_UP" => CardioPlannedWorkoutStepExerciseCategory.SitUp,
                "SQUAT" => CardioPlannedWorkoutStepExerciseCategory.Squat,
                "TOTAL_BODY" => CardioPlannedWorkoutStepExerciseCategory.TotalBody,
                "TRICEPS_EXTENSION" => CardioPlannedWorkoutStepExerciseCategory.TricepsExtension,
                "UNKNOWN" => CardioPlannedWorkoutStepExerciseCategory.Unknown,
                "WARM_UP" => CardioPlannedWorkoutStepExerciseCategory.WarmUp,
                _ => null,
            };
        }
    }
}
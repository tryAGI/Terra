
#nullable enable

namespace Terra
{
    /// <summary>
    /// Type of strength exercise to be performed for the workout step
    /// </summary>
    public enum StrengthPlannedWorkoutStepExerciseCategory
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
    public static class StrengthPlannedWorkoutStepExerciseCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPlannedWorkoutStepExerciseCategory value)
        {
            return value switch
            {
                StrengthPlannedWorkoutStepExerciseCategory.BenchPress => "BENCH_PRESS",
                StrengthPlannedWorkoutStepExerciseCategory.Bike => "BIKE",
                StrengthPlannedWorkoutStepExerciseCategory.CalfRaise => "CALF_RAISE",
                StrengthPlannedWorkoutStepExerciseCategory.Cardio => "CARDIO",
                StrengthPlannedWorkoutStepExerciseCategory.CardioSensors => "CARDIO_SENSORS",
                StrengthPlannedWorkoutStepExerciseCategory.Carry => "CARRY",
                StrengthPlannedWorkoutStepExerciseCategory.Chop => "CHOP",
                StrengthPlannedWorkoutStepExerciseCategory.Core => "CORE",
                StrengthPlannedWorkoutStepExerciseCategory.Crunch => "CRUNCH",
                StrengthPlannedWorkoutStepExerciseCategory.Curl => "CURL",
                StrengthPlannedWorkoutStepExerciseCategory.Deadlift => "DEADLIFT",
                StrengthPlannedWorkoutStepExerciseCategory.Flye => "FLYE",
                StrengthPlannedWorkoutStepExerciseCategory.HipRaise => "HIP_RAISE",
                StrengthPlannedWorkoutStepExerciseCategory.HipStability => "HIP_STABILITY",
                StrengthPlannedWorkoutStepExerciseCategory.HipSwing => "HIP_SWING",
                StrengthPlannedWorkoutStepExerciseCategory.Hyperextension => "HYPEREXTENSION",
                StrengthPlannedWorkoutStepExerciseCategory.LateralRaise => "LATERAL_RAISE",
                StrengthPlannedWorkoutStepExerciseCategory.LegCurl => "LEG_CURL",
                StrengthPlannedWorkoutStepExerciseCategory.LegRaise => "LEG_RAISE",
                StrengthPlannedWorkoutStepExerciseCategory.Lunge => "LUNGE",
                StrengthPlannedWorkoutStepExerciseCategory.OlympicLift => "OLYMPIC_LIFT",
                StrengthPlannedWorkoutStepExerciseCategory.Plank => "PLANK",
                StrengthPlannedWorkoutStepExerciseCategory.Plyo => "PLYO",
                StrengthPlannedWorkoutStepExerciseCategory.PullUp => "PULL_UP",
                StrengthPlannedWorkoutStepExerciseCategory.PushUp => "PUSH_UP",
                StrengthPlannedWorkoutStepExerciseCategory.Row => "ROW",
                StrengthPlannedWorkoutStepExerciseCategory.Run => "RUN",
                StrengthPlannedWorkoutStepExerciseCategory.ShoulderPress => "SHOULDER_PRESS",
                StrengthPlannedWorkoutStepExerciseCategory.ShoulderStability => "SHOULDER_STABILITY",
                StrengthPlannedWorkoutStepExerciseCategory.Shrug => "SHRUG",
                StrengthPlannedWorkoutStepExerciseCategory.SitUp => "SIT_UP",
                StrengthPlannedWorkoutStepExerciseCategory.Squat => "SQUAT",
                StrengthPlannedWorkoutStepExerciseCategory.TotalBody => "TOTAL_BODY",
                StrengthPlannedWorkoutStepExerciseCategory.TricepsExtension => "TRICEPS_EXTENSION",
                StrengthPlannedWorkoutStepExerciseCategory.Unknown => "UNKNOWN",
                StrengthPlannedWorkoutStepExerciseCategory.WarmUp => "WARM_UP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPlannedWorkoutStepExerciseCategory? ToEnum(string value)
        {
            return value switch
            {
                "BENCH_PRESS" => StrengthPlannedWorkoutStepExerciseCategory.BenchPress,
                "BIKE" => StrengthPlannedWorkoutStepExerciseCategory.Bike,
                "CALF_RAISE" => StrengthPlannedWorkoutStepExerciseCategory.CalfRaise,
                "CARDIO" => StrengthPlannedWorkoutStepExerciseCategory.Cardio,
                "CARDIO_SENSORS" => StrengthPlannedWorkoutStepExerciseCategory.CardioSensors,
                "CARRY" => StrengthPlannedWorkoutStepExerciseCategory.Carry,
                "CHOP" => StrengthPlannedWorkoutStepExerciseCategory.Chop,
                "CORE" => StrengthPlannedWorkoutStepExerciseCategory.Core,
                "CRUNCH" => StrengthPlannedWorkoutStepExerciseCategory.Crunch,
                "CURL" => StrengthPlannedWorkoutStepExerciseCategory.Curl,
                "DEADLIFT" => StrengthPlannedWorkoutStepExerciseCategory.Deadlift,
                "FLYE" => StrengthPlannedWorkoutStepExerciseCategory.Flye,
                "HIP_RAISE" => StrengthPlannedWorkoutStepExerciseCategory.HipRaise,
                "HIP_STABILITY" => StrengthPlannedWorkoutStepExerciseCategory.HipStability,
                "HIP_SWING" => StrengthPlannedWorkoutStepExerciseCategory.HipSwing,
                "HYPEREXTENSION" => StrengthPlannedWorkoutStepExerciseCategory.Hyperextension,
                "LATERAL_RAISE" => StrengthPlannedWorkoutStepExerciseCategory.LateralRaise,
                "LEG_CURL" => StrengthPlannedWorkoutStepExerciseCategory.LegCurl,
                "LEG_RAISE" => StrengthPlannedWorkoutStepExerciseCategory.LegRaise,
                "LUNGE" => StrengthPlannedWorkoutStepExerciseCategory.Lunge,
                "OLYMPIC_LIFT" => StrengthPlannedWorkoutStepExerciseCategory.OlympicLift,
                "PLANK" => StrengthPlannedWorkoutStepExerciseCategory.Plank,
                "PLYO" => StrengthPlannedWorkoutStepExerciseCategory.Plyo,
                "PULL_UP" => StrengthPlannedWorkoutStepExerciseCategory.PullUp,
                "PUSH_UP" => StrengthPlannedWorkoutStepExerciseCategory.PushUp,
                "ROW" => StrengthPlannedWorkoutStepExerciseCategory.Row,
                "RUN" => StrengthPlannedWorkoutStepExerciseCategory.Run,
                "SHOULDER_PRESS" => StrengthPlannedWorkoutStepExerciseCategory.ShoulderPress,
                "SHOULDER_STABILITY" => StrengthPlannedWorkoutStepExerciseCategory.ShoulderStability,
                "SHRUG" => StrengthPlannedWorkoutStepExerciseCategory.Shrug,
                "SIT_UP" => StrengthPlannedWorkoutStepExerciseCategory.SitUp,
                "SQUAT" => StrengthPlannedWorkoutStepExerciseCategory.Squat,
                "TOTAL_BODY" => StrengthPlannedWorkoutStepExerciseCategory.TotalBody,
                "TRICEPS_EXTENSION" => StrengthPlannedWorkoutStepExerciseCategory.TricepsExtension,
                "UNKNOWN" => StrengthPlannedWorkoutStepExerciseCategory.Unknown,
                "WARM_UP" => StrengthPlannedWorkoutStepExerciseCategory.WarmUp,
                _ => null,
            };
        }
    }
}
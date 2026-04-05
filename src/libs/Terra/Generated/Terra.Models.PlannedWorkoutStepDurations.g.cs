#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PlannedWorkoutStepDurations : global::System.IEquatable<PlannedWorkoutStepDurations>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Terra.PlannedWorkoutStepDurationsDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PlannedWorkoutStepDuration? PlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.PlannedWorkoutStepDuration? PlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlannedWorkoutStepDuration))]
#endif
        public bool IsPlannedWorkoutStepDuration => PlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.TimePlannedWorkoutStepDuration? TimePlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.TimePlannedWorkoutStepDuration? TimePlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TimePlannedWorkoutStepDuration))]
#endif
        public bool IsTimePlannedWorkoutStepDuration => TimePlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PowerAbovePlannedWorkoutStepDuration? PowerAbovePlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.PowerAbovePlannedWorkoutStepDuration? PowerAbovePlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PowerAbovePlannedWorkoutStepDuration))]
#endif
        public bool IsPowerAbovePlannedWorkoutStepDuration => PowerAbovePlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PowerBelowPlannedWorkoutStepDuration? PowerBelowPlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.PowerBelowPlannedWorkoutStepDuration? PowerBelowPlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PowerBelowPlannedWorkoutStepDuration))]
#endif
        public bool IsPowerBelowPlannedWorkoutStepDuration => PowerBelowPlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.FixedRestPlannedWorkoutStepDuration? FixedRestPlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.FixedRestPlannedWorkoutStepDuration? FixedRestPlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FixedRestPlannedWorkoutStepDuration))]
#endif
        public bool IsFixedRestPlannedWorkoutStepDuration => FixedRestPlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CaloriesPlannedWorkoutStepDuration? CaloriesPlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.CaloriesPlannedWorkoutStepDuration? CaloriesPlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CaloriesPlannedWorkoutStepDuration))]
#endif
        public bool IsCaloriesPlannedWorkoutStepDuration => CaloriesPlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.HRAbovePlannedWorkoutStepDuration? HRAbovePlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.HRAbovePlannedWorkoutStepDuration? HRAbovePlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HRAbovePlannedWorkoutStepDuration))]
#endif
        public bool IsHRAbovePlannedWorkoutStepDuration => HRAbovePlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.HRBelowPlannedWorkoutStepDuration? HRBelowPlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.HRBelowPlannedWorkoutStepDuration? HRBelowPlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HRBelowPlannedWorkoutStepDuration))]
#endif
        public bool IsHRBelowPlannedWorkoutStepDuration => HRBelowPlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.RepsPlannedWorkoutStepDuration? RepsPlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.RepsPlannedWorkoutStepDuration? RepsPlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepsPlannedWorkoutStepDuration))]
#endif
        public bool IsRepsPlannedWorkoutStepDuration => RepsPlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.DistancePlannedWorkoutStepDuration? DistancePlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.DistancePlannedWorkoutStepDuration? DistancePlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DistancePlannedWorkoutStepDuration))]
#endif
        public bool IsDistancePlannedWorkoutStepDuration => DistancePlannedWorkoutStepDuration != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StepsPlannedWorkoutStepDuration? StepsPlannedWorkoutStepDuration { get; init; }
#else
        public global::Terra.StepsPlannedWorkoutStepDuration? StepsPlannedWorkoutStepDuration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepsPlannedWorkoutStepDuration))]
#endif
        public bool IsStepsPlannedWorkoutStepDuration => StepsPlannedWorkoutStepDuration != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.PlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.PlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.PlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.PlannedWorkoutStepDuration? value)
        {
            PlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.TimePlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.TimePlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.TimePlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.TimePlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.TimePlannedWorkoutStepDuration? value)
        {
            TimePlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.PowerAbovePlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.PowerAbovePlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PowerAbovePlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.PowerAbovePlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.PowerAbovePlannedWorkoutStepDuration? value)
        {
            PowerAbovePlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.PowerBelowPlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.PowerBelowPlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PowerBelowPlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.PowerBelowPlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.PowerBelowPlannedWorkoutStepDuration? value)
        {
            PowerBelowPlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.FixedRestPlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.FixedRestPlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.FixedRestPlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.FixedRestPlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.FixedRestPlannedWorkoutStepDuration? value)
        {
            FixedRestPlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.CaloriesPlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.CaloriesPlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CaloriesPlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.CaloriesPlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.CaloriesPlannedWorkoutStepDuration? value)
        {
            CaloriesPlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.HRAbovePlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.HRAbovePlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.HRAbovePlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.HRAbovePlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.HRAbovePlannedWorkoutStepDuration? value)
        {
            HRAbovePlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.HRBelowPlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.HRBelowPlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.HRBelowPlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.HRBelowPlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.HRBelowPlannedWorkoutStepDuration? value)
        {
            HRBelowPlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.RepsPlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.RepsPlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.RepsPlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.RepsPlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.RepsPlannedWorkoutStepDuration? value)
        {
            RepsPlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.DistancePlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.DistancePlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.DistancePlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.DistancePlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.DistancePlannedWorkoutStepDuration? value)
        {
            DistancePlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepDurations(global::Terra.StepsPlannedWorkoutStepDuration value) => new PlannedWorkoutStepDurations((global::Terra.StepsPlannedWorkoutStepDuration?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StepsPlannedWorkoutStepDuration?(PlannedWorkoutStepDurations @this) => @this.StepsPlannedWorkoutStepDuration;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(global::Terra.StepsPlannedWorkoutStepDuration? value)
        {
            StepsPlannedWorkoutStepDuration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepDurations(
            global::Terra.PlannedWorkoutStepDurationsDiscriminatorType? type,
            global::Terra.PlannedWorkoutStepDuration? plannedWorkoutStepDuration,
            global::Terra.TimePlannedWorkoutStepDuration? timePlannedWorkoutStepDuration,
            global::Terra.PowerAbovePlannedWorkoutStepDuration? powerAbovePlannedWorkoutStepDuration,
            global::Terra.PowerBelowPlannedWorkoutStepDuration? powerBelowPlannedWorkoutStepDuration,
            global::Terra.FixedRestPlannedWorkoutStepDuration? fixedRestPlannedWorkoutStepDuration,
            global::Terra.CaloriesPlannedWorkoutStepDuration? caloriesPlannedWorkoutStepDuration,
            global::Terra.HRAbovePlannedWorkoutStepDuration? hRAbovePlannedWorkoutStepDuration,
            global::Terra.HRBelowPlannedWorkoutStepDuration? hRBelowPlannedWorkoutStepDuration,
            global::Terra.RepsPlannedWorkoutStepDuration? repsPlannedWorkoutStepDuration,
            global::Terra.DistancePlannedWorkoutStepDuration? distancePlannedWorkoutStepDuration,
            global::Terra.StepsPlannedWorkoutStepDuration? stepsPlannedWorkoutStepDuration
            )
        {
            Type = type;

            PlannedWorkoutStepDuration = plannedWorkoutStepDuration;
            TimePlannedWorkoutStepDuration = timePlannedWorkoutStepDuration;
            PowerAbovePlannedWorkoutStepDuration = powerAbovePlannedWorkoutStepDuration;
            PowerBelowPlannedWorkoutStepDuration = powerBelowPlannedWorkoutStepDuration;
            FixedRestPlannedWorkoutStepDuration = fixedRestPlannedWorkoutStepDuration;
            CaloriesPlannedWorkoutStepDuration = caloriesPlannedWorkoutStepDuration;
            HRAbovePlannedWorkoutStepDuration = hRAbovePlannedWorkoutStepDuration;
            HRBelowPlannedWorkoutStepDuration = hRBelowPlannedWorkoutStepDuration;
            RepsPlannedWorkoutStepDuration = repsPlannedWorkoutStepDuration;
            DistancePlannedWorkoutStepDuration = distancePlannedWorkoutStepDuration;
            StepsPlannedWorkoutStepDuration = stepsPlannedWorkoutStepDuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StepsPlannedWorkoutStepDuration as object ??
            DistancePlannedWorkoutStepDuration as object ??
            RepsPlannedWorkoutStepDuration as object ??
            HRBelowPlannedWorkoutStepDuration as object ??
            HRAbovePlannedWorkoutStepDuration as object ??
            CaloriesPlannedWorkoutStepDuration as object ??
            FixedRestPlannedWorkoutStepDuration as object ??
            PowerBelowPlannedWorkoutStepDuration as object ??
            PowerAbovePlannedWorkoutStepDuration as object ??
            TimePlannedWorkoutStepDuration as object ??
            PlannedWorkoutStepDuration as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PlannedWorkoutStepDuration?.ToString() ??
            TimePlannedWorkoutStepDuration?.ToString() ??
            PowerAbovePlannedWorkoutStepDuration?.ToString() ??
            PowerBelowPlannedWorkoutStepDuration?.ToString() ??
            FixedRestPlannedWorkoutStepDuration?.ToString() ??
            CaloriesPlannedWorkoutStepDuration?.ToString() ??
            HRAbovePlannedWorkoutStepDuration?.ToString() ??
            HRBelowPlannedWorkoutStepDuration?.ToString() ??
            RepsPlannedWorkoutStepDuration?.ToString() ??
            DistancePlannedWorkoutStepDuration?.ToString() ??
            StepsPlannedWorkoutStepDuration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && IsDistancePlannedWorkoutStepDuration && !IsStepsPlannedWorkoutStepDuration || !IsPlannedWorkoutStepDuration && !IsTimePlannedWorkoutStepDuration && !IsPowerAbovePlannedWorkoutStepDuration && !IsPowerBelowPlannedWorkoutStepDuration && !IsFixedRestPlannedWorkoutStepDuration && !IsCaloriesPlannedWorkoutStepDuration && !IsHRAbovePlannedWorkoutStepDuration && !IsHRBelowPlannedWorkoutStepDuration && !IsRepsPlannedWorkoutStepDuration && !IsDistancePlannedWorkoutStepDuration && IsStepsPlannedWorkoutStepDuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.PlannedWorkoutStepDuration?, TResult>? plannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.TimePlannedWorkoutStepDuration?, TResult>? timePlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.PowerAbovePlannedWorkoutStepDuration?, TResult>? powerAbovePlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.PowerBelowPlannedWorkoutStepDuration?, TResult>? powerBelowPlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.FixedRestPlannedWorkoutStepDuration?, TResult>? fixedRestPlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.CaloriesPlannedWorkoutStepDuration?, TResult>? caloriesPlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.HRAbovePlannedWorkoutStepDuration?, TResult>? hRAbovePlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.HRBelowPlannedWorkoutStepDuration?, TResult>? hRBelowPlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.RepsPlannedWorkoutStepDuration?, TResult>? repsPlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.DistancePlannedWorkoutStepDuration?, TResult>? distancePlannedWorkoutStepDuration = null,
            global::System.Func<global::Terra.StepsPlannedWorkoutStepDuration?, TResult>? stepsPlannedWorkoutStepDuration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlannedWorkoutStepDuration && plannedWorkoutStepDuration != null)
            {
                return plannedWorkoutStepDuration(PlannedWorkoutStepDuration!);
            }
            else if (IsTimePlannedWorkoutStepDuration && timePlannedWorkoutStepDuration != null)
            {
                return timePlannedWorkoutStepDuration(TimePlannedWorkoutStepDuration!);
            }
            else if (IsPowerAbovePlannedWorkoutStepDuration && powerAbovePlannedWorkoutStepDuration != null)
            {
                return powerAbovePlannedWorkoutStepDuration(PowerAbovePlannedWorkoutStepDuration!);
            }
            else if (IsPowerBelowPlannedWorkoutStepDuration && powerBelowPlannedWorkoutStepDuration != null)
            {
                return powerBelowPlannedWorkoutStepDuration(PowerBelowPlannedWorkoutStepDuration!);
            }
            else if (IsFixedRestPlannedWorkoutStepDuration && fixedRestPlannedWorkoutStepDuration != null)
            {
                return fixedRestPlannedWorkoutStepDuration(FixedRestPlannedWorkoutStepDuration!);
            }
            else if (IsCaloriesPlannedWorkoutStepDuration && caloriesPlannedWorkoutStepDuration != null)
            {
                return caloriesPlannedWorkoutStepDuration(CaloriesPlannedWorkoutStepDuration!);
            }
            else if (IsHRAbovePlannedWorkoutStepDuration && hRAbovePlannedWorkoutStepDuration != null)
            {
                return hRAbovePlannedWorkoutStepDuration(HRAbovePlannedWorkoutStepDuration!);
            }
            else if (IsHRBelowPlannedWorkoutStepDuration && hRBelowPlannedWorkoutStepDuration != null)
            {
                return hRBelowPlannedWorkoutStepDuration(HRBelowPlannedWorkoutStepDuration!);
            }
            else if (IsRepsPlannedWorkoutStepDuration && repsPlannedWorkoutStepDuration != null)
            {
                return repsPlannedWorkoutStepDuration(RepsPlannedWorkoutStepDuration!);
            }
            else if (IsDistancePlannedWorkoutStepDuration && distancePlannedWorkoutStepDuration != null)
            {
                return distancePlannedWorkoutStepDuration(DistancePlannedWorkoutStepDuration!);
            }
            else if (IsStepsPlannedWorkoutStepDuration && stepsPlannedWorkoutStepDuration != null)
            {
                return stepsPlannedWorkoutStepDuration(StepsPlannedWorkoutStepDuration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.PlannedWorkoutStepDuration?>? plannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.TimePlannedWorkoutStepDuration?>? timePlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.PowerAbovePlannedWorkoutStepDuration?>? powerAbovePlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.PowerBelowPlannedWorkoutStepDuration?>? powerBelowPlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.FixedRestPlannedWorkoutStepDuration?>? fixedRestPlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.CaloriesPlannedWorkoutStepDuration?>? caloriesPlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.HRAbovePlannedWorkoutStepDuration?>? hRAbovePlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.HRBelowPlannedWorkoutStepDuration?>? hRBelowPlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.RepsPlannedWorkoutStepDuration?>? repsPlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.DistancePlannedWorkoutStepDuration?>? distancePlannedWorkoutStepDuration = null,
            global::System.Action<global::Terra.StepsPlannedWorkoutStepDuration?>? stepsPlannedWorkoutStepDuration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlannedWorkoutStepDuration)
            {
                plannedWorkoutStepDuration?.Invoke(PlannedWorkoutStepDuration!);
            }
            else if (IsTimePlannedWorkoutStepDuration)
            {
                timePlannedWorkoutStepDuration?.Invoke(TimePlannedWorkoutStepDuration!);
            }
            else if (IsPowerAbovePlannedWorkoutStepDuration)
            {
                powerAbovePlannedWorkoutStepDuration?.Invoke(PowerAbovePlannedWorkoutStepDuration!);
            }
            else if (IsPowerBelowPlannedWorkoutStepDuration)
            {
                powerBelowPlannedWorkoutStepDuration?.Invoke(PowerBelowPlannedWorkoutStepDuration!);
            }
            else if (IsFixedRestPlannedWorkoutStepDuration)
            {
                fixedRestPlannedWorkoutStepDuration?.Invoke(FixedRestPlannedWorkoutStepDuration!);
            }
            else if (IsCaloriesPlannedWorkoutStepDuration)
            {
                caloriesPlannedWorkoutStepDuration?.Invoke(CaloriesPlannedWorkoutStepDuration!);
            }
            else if (IsHRAbovePlannedWorkoutStepDuration)
            {
                hRAbovePlannedWorkoutStepDuration?.Invoke(HRAbovePlannedWorkoutStepDuration!);
            }
            else if (IsHRBelowPlannedWorkoutStepDuration)
            {
                hRBelowPlannedWorkoutStepDuration?.Invoke(HRBelowPlannedWorkoutStepDuration!);
            }
            else if (IsRepsPlannedWorkoutStepDuration)
            {
                repsPlannedWorkoutStepDuration?.Invoke(RepsPlannedWorkoutStepDuration!);
            }
            else if (IsDistancePlannedWorkoutStepDuration)
            {
                distancePlannedWorkoutStepDuration?.Invoke(DistancePlannedWorkoutStepDuration!);
            }
            else if (IsStepsPlannedWorkoutStepDuration)
            {
                stepsPlannedWorkoutStepDuration?.Invoke(StepsPlannedWorkoutStepDuration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlannedWorkoutStepDuration,
                typeof(global::Terra.PlannedWorkoutStepDuration),
                TimePlannedWorkoutStepDuration,
                typeof(global::Terra.TimePlannedWorkoutStepDuration),
                PowerAbovePlannedWorkoutStepDuration,
                typeof(global::Terra.PowerAbovePlannedWorkoutStepDuration),
                PowerBelowPlannedWorkoutStepDuration,
                typeof(global::Terra.PowerBelowPlannedWorkoutStepDuration),
                FixedRestPlannedWorkoutStepDuration,
                typeof(global::Terra.FixedRestPlannedWorkoutStepDuration),
                CaloriesPlannedWorkoutStepDuration,
                typeof(global::Terra.CaloriesPlannedWorkoutStepDuration),
                HRAbovePlannedWorkoutStepDuration,
                typeof(global::Terra.HRAbovePlannedWorkoutStepDuration),
                HRBelowPlannedWorkoutStepDuration,
                typeof(global::Terra.HRBelowPlannedWorkoutStepDuration),
                RepsPlannedWorkoutStepDuration,
                typeof(global::Terra.RepsPlannedWorkoutStepDuration),
                DistancePlannedWorkoutStepDuration,
                typeof(global::Terra.DistancePlannedWorkoutStepDuration),
                StepsPlannedWorkoutStepDuration,
                typeof(global::Terra.StepsPlannedWorkoutStepDuration),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(PlannedWorkoutStepDurations other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.PlannedWorkoutStepDuration?>.Default.Equals(PlannedWorkoutStepDuration, other.PlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.TimePlannedWorkoutStepDuration?>.Default.Equals(TimePlannedWorkoutStepDuration, other.TimePlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PowerAbovePlannedWorkoutStepDuration?>.Default.Equals(PowerAbovePlannedWorkoutStepDuration, other.PowerAbovePlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PowerBelowPlannedWorkoutStepDuration?>.Default.Equals(PowerBelowPlannedWorkoutStepDuration, other.PowerBelowPlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.FixedRestPlannedWorkoutStepDuration?>.Default.Equals(FixedRestPlannedWorkoutStepDuration, other.FixedRestPlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CaloriesPlannedWorkoutStepDuration?>.Default.Equals(CaloriesPlannedWorkoutStepDuration, other.CaloriesPlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.HRAbovePlannedWorkoutStepDuration?>.Default.Equals(HRAbovePlannedWorkoutStepDuration, other.HRAbovePlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.HRBelowPlannedWorkoutStepDuration?>.Default.Equals(HRBelowPlannedWorkoutStepDuration, other.HRBelowPlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.RepsPlannedWorkoutStepDuration?>.Default.Equals(RepsPlannedWorkoutStepDuration, other.RepsPlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.DistancePlannedWorkoutStepDuration?>.Default.Equals(DistancePlannedWorkoutStepDuration, other.DistancePlannedWorkoutStepDuration) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StepsPlannedWorkoutStepDuration?>.Default.Equals(StepsPlannedWorkoutStepDuration, other.StepsPlannedWorkoutStepDuration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PlannedWorkoutStepDurations obj1, PlannedWorkoutStepDurations obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlannedWorkoutStepDurations>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PlannedWorkoutStepDurations obj1, PlannedWorkoutStepDurations obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlannedWorkoutStepDurations o && Equals(o);
        }
    }
}

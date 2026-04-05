#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PlannedWorkoutSteps : global::System.IEquatable<PlannedWorkoutSteps>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Terra.PlannedWorkoutStepsDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PlannedWorkoutStep? PlannedWorkoutStep { get; init; }
#else
        public global::Terra.PlannedWorkoutStep? PlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlannedWorkoutStep))]
#endif
        public bool IsPlannedWorkoutStep => PlannedWorkoutStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PlannedWorkoutRepeatStep? PlannedWorkoutRepeatStep { get; init; }
#else
        public global::Terra.PlannedWorkoutRepeatStep? PlannedWorkoutRepeatStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlannedWorkoutRepeatStep))]
#endif
        public bool IsPlannedWorkoutRepeatStep => PlannedWorkoutRepeatStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimmingPlannedWorkoutStep? SwimmingPlannedWorkoutStep { get; init; }
#else
        public global::Terra.SwimmingPlannedWorkoutStep? SwimmingPlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimmingPlannedWorkoutStep))]
#endif
        public bool IsSwimmingPlannedWorkoutStep => SwimmingPlannedWorkoutStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CardioPlannedWorkoutStep? CardioPlannedWorkoutStep { get; init; }
#else
        public global::Terra.CardioPlannedWorkoutStep? CardioPlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CardioPlannedWorkoutStep))]
#endif
        public bool IsCardioPlannedWorkoutStep => CardioPlannedWorkoutStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPlannedWorkoutStep? StrengthPlannedWorkoutStep { get; init; }
#else
        public global::Terra.StrengthPlannedWorkoutStep? StrengthPlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPlannedWorkoutStep))]
#endif
        public bool IsStrengthPlannedWorkoutStep => StrengthPlannedWorkoutStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.YogaPlannedWorkoutStep? YogaPlannedWorkoutStep { get; init; }
#else
        public global::Terra.YogaPlannedWorkoutStep? YogaPlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(YogaPlannedWorkoutStep))]
#endif
        public bool IsYogaPlannedWorkoutStep => YogaPlannedWorkoutStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PilatesPlannedWorkoutStep? PilatesPlannedWorkoutStep { get; init; }
#else
        public global::Terra.PilatesPlannedWorkoutStep? PilatesPlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PilatesPlannedWorkoutStep))]
#endif
        public bool IsPilatesPlannedWorkoutStep => PilatesPlannedWorkoutStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.RunningPlannedWorkoutStep? RunningPlannedWorkoutStep { get; init; }
#else
        public global::Terra.RunningPlannedWorkoutStep? RunningPlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RunningPlannedWorkoutStep))]
#endif
        public bool IsRunningPlannedWorkoutStep => RunningPlannedWorkoutStep != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CyclingPlannedWorkoutStep? CyclingPlannedWorkoutStep { get; init; }
#else
        public global::Terra.CyclingPlannedWorkoutStep? CyclingPlannedWorkoutStep { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CyclingPlannedWorkoutStep))]
#endif
        public bool IsCyclingPlannedWorkoutStep => CyclingPlannedWorkoutStep != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.PlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.PlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.PlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.PlannedWorkoutStep? value)
        {
            PlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.PlannedWorkoutRepeatStep value) => new PlannedWorkoutSteps((global::Terra.PlannedWorkoutRepeatStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PlannedWorkoutRepeatStep?(PlannedWorkoutSteps @this) => @this.PlannedWorkoutRepeatStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.PlannedWorkoutRepeatStep? value)
        {
            PlannedWorkoutRepeatStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.SwimmingPlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.SwimmingPlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimmingPlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.SwimmingPlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.SwimmingPlannedWorkoutStep? value)
        {
            SwimmingPlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.CardioPlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.CardioPlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CardioPlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.CardioPlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.CardioPlannedWorkoutStep? value)
        {
            CardioPlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.StrengthPlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.StrengthPlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthPlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.StrengthPlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.StrengthPlannedWorkoutStep? value)
        {
            StrengthPlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.YogaPlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.YogaPlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.YogaPlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.YogaPlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.YogaPlannedWorkoutStep? value)
        {
            YogaPlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.PilatesPlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.PilatesPlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PilatesPlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.PilatesPlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.PilatesPlannedWorkoutStep? value)
        {
            PilatesPlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.RunningPlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.RunningPlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.RunningPlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.RunningPlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.RunningPlannedWorkoutStep? value)
        {
            RunningPlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutSteps(global::Terra.CyclingPlannedWorkoutStep value) => new PlannedWorkoutSteps((global::Terra.CyclingPlannedWorkoutStep?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CyclingPlannedWorkoutStep?(PlannedWorkoutSteps @this) => @this.CyclingPlannedWorkoutStep;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(global::Terra.CyclingPlannedWorkoutStep? value)
        {
            CyclingPlannedWorkoutStep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutSteps(
            global::Terra.PlannedWorkoutStepsDiscriminatorType? type,
            global::Terra.PlannedWorkoutStep? plannedWorkoutStep,
            global::Terra.PlannedWorkoutRepeatStep? plannedWorkoutRepeatStep,
            global::Terra.SwimmingPlannedWorkoutStep? swimmingPlannedWorkoutStep,
            global::Terra.CardioPlannedWorkoutStep? cardioPlannedWorkoutStep,
            global::Terra.StrengthPlannedWorkoutStep? strengthPlannedWorkoutStep,
            global::Terra.YogaPlannedWorkoutStep? yogaPlannedWorkoutStep,
            global::Terra.PilatesPlannedWorkoutStep? pilatesPlannedWorkoutStep,
            global::Terra.RunningPlannedWorkoutStep? runningPlannedWorkoutStep,
            global::Terra.CyclingPlannedWorkoutStep? cyclingPlannedWorkoutStep
            )
        {
            Type = type;

            PlannedWorkoutStep = plannedWorkoutStep;
            PlannedWorkoutRepeatStep = plannedWorkoutRepeatStep;
            SwimmingPlannedWorkoutStep = swimmingPlannedWorkoutStep;
            CardioPlannedWorkoutStep = cardioPlannedWorkoutStep;
            StrengthPlannedWorkoutStep = strengthPlannedWorkoutStep;
            YogaPlannedWorkoutStep = yogaPlannedWorkoutStep;
            PilatesPlannedWorkoutStep = pilatesPlannedWorkoutStep;
            RunningPlannedWorkoutStep = runningPlannedWorkoutStep;
            CyclingPlannedWorkoutStep = cyclingPlannedWorkoutStep;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CyclingPlannedWorkoutStep as object ??
            RunningPlannedWorkoutStep as object ??
            PilatesPlannedWorkoutStep as object ??
            YogaPlannedWorkoutStep as object ??
            StrengthPlannedWorkoutStep as object ??
            CardioPlannedWorkoutStep as object ??
            SwimmingPlannedWorkoutStep as object ??
            PlannedWorkoutRepeatStep as object ??
            PlannedWorkoutStep as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PlannedWorkoutStep?.ToString() ??
            PlannedWorkoutRepeatStep?.ToString() ??
            SwimmingPlannedWorkoutStep?.ToString() ??
            CardioPlannedWorkoutStep?.ToString() ??
            StrengthPlannedWorkoutStep?.ToString() ??
            YogaPlannedWorkoutStep?.ToString() ??
            PilatesPlannedWorkoutStep?.ToString() ??
            RunningPlannedWorkoutStep?.ToString() ??
            CyclingPlannedWorkoutStep?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && IsRunningPlannedWorkoutStep && !IsCyclingPlannedWorkoutStep || !IsPlannedWorkoutStep && !IsPlannedWorkoutRepeatStep && !IsSwimmingPlannedWorkoutStep && !IsCardioPlannedWorkoutStep && !IsStrengthPlannedWorkoutStep && !IsYogaPlannedWorkoutStep && !IsPilatesPlannedWorkoutStep && !IsRunningPlannedWorkoutStep && IsCyclingPlannedWorkoutStep;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.PlannedWorkoutStep?, TResult>? plannedWorkoutStep = null,
            global::System.Func<global::Terra.PlannedWorkoutRepeatStep?, TResult>? plannedWorkoutRepeatStep = null,
            global::System.Func<global::Terra.SwimmingPlannedWorkoutStep?, TResult>? swimmingPlannedWorkoutStep = null,
            global::System.Func<global::Terra.CardioPlannedWorkoutStep?, TResult>? cardioPlannedWorkoutStep = null,
            global::System.Func<global::Terra.StrengthPlannedWorkoutStep?, TResult>? strengthPlannedWorkoutStep = null,
            global::System.Func<global::Terra.YogaPlannedWorkoutStep?, TResult>? yogaPlannedWorkoutStep = null,
            global::System.Func<global::Terra.PilatesPlannedWorkoutStep?, TResult>? pilatesPlannedWorkoutStep = null,
            global::System.Func<global::Terra.RunningPlannedWorkoutStep?, TResult>? runningPlannedWorkoutStep = null,
            global::System.Func<global::Terra.CyclingPlannedWorkoutStep?, TResult>? cyclingPlannedWorkoutStep = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlannedWorkoutStep && plannedWorkoutStep != null)
            {
                return plannedWorkoutStep(PlannedWorkoutStep!);
            }
            else if (IsPlannedWorkoutRepeatStep && plannedWorkoutRepeatStep != null)
            {
                return plannedWorkoutRepeatStep(PlannedWorkoutRepeatStep!);
            }
            else if (IsSwimmingPlannedWorkoutStep && swimmingPlannedWorkoutStep != null)
            {
                return swimmingPlannedWorkoutStep(SwimmingPlannedWorkoutStep!);
            }
            else if (IsCardioPlannedWorkoutStep && cardioPlannedWorkoutStep != null)
            {
                return cardioPlannedWorkoutStep(CardioPlannedWorkoutStep!);
            }
            else if (IsStrengthPlannedWorkoutStep && strengthPlannedWorkoutStep != null)
            {
                return strengthPlannedWorkoutStep(StrengthPlannedWorkoutStep!);
            }
            else if (IsYogaPlannedWorkoutStep && yogaPlannedWorkoutStep != null)
            {
                return yogaPlannedWorkoutStep(YogaPlannedWorkoutStep!);
            }
            else if (IsPilatesPlannedWorkoutStep && pilatesPlannedWorkoutStep != null)
            {
                return pilatesPlannedWorkoutStep(PilatesPlannedWorkoutStep!);
            }
            else if (IsRunningPlannedWorkoutStep && runningPlannedWorkoutStep != null)
            {
                return runningPlannedWorkoutStep(RunningPlannedWorkoutStep!);
            }
            else if (IsCyclingPlannedWorkoutStep && cyclingPlannedWorkoutStep != null)
            {
                return cyclingPlannedWorkoutStep(CyclingPlannedWorkoutStep!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.PlannedWorkoutStep?>? plannedWorkoutStep = null,
            global::System.Action<global::Terra.PlannedWorkoutRepeatStep?>? plannedWorkoutRepeatStep = null,
            global::System.Action<global::Terra.SwimmingPlannedWorkoutStep?>? swimmingPlannedWorkoutStep = null,
            global::System.Action<global::Terra.CardioPlannedWorkoutStep?>? cardioPlannedWorkoutStep = null,
            global::System.Action<global::Terra.StrengthPlannedWorkoutStep?>? strengthPlannedWorkoutStep = null,
            global::System.Action<global::Terra.YogaPlannedWorkoutStep?>? yogaPlannedWorkoutStep = null,
            global::System.Action<global::Terra.PilatesPlannedWorkoutStep?>? pilatesPlannedWorkoutStep = null,
            global::System.Action<global::Terra.RunningPlannedWorkoutStep?>? runningPlannedWorkoutStep = null,
            global::System.Action<global::Terra.CyclingPlannedWorkoutStep?>? cyclingPlannedWorkoutStep = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlannedWorkoutStep)
            {
                plannedWorkoutStep?.Invoke(PlannedWorkoutStep!);
            }
            else if (IsPlannedWorkoutRepeatStep)
            {
                plannedWorkoutRepeatStep?.Invoke(PlannedWorkoutRepeatStep!);
            }
            else if (IsSwimmingPlannedWorkoutStep)
            {
                swimmingPlannedWorkoutStep?.Invoke(SwimmingPlannedWorkoutStep!);
            }
            else if (IsCardioPlannedWorkoutStep)
            {
                cardioPlannedWorkoutStep?.Invoke(CardioPlannedWorkoutStep!);
            }
            else if (IsStrengthPlannedWorkoutStep)
            {
                strengthPlannedWorkoutStep?.Invoke(StrengthPlannedWorkoutStep!);
            }
            else if (IsYogaPlannedWorkoutStep)
            {
                yogaPlannedWorkoutStep?.Invoke(YogaPlannedWorkoutStep!);
            }
            else if (IsPilatesPlannedWorkoutStep)
            {
                pilatesPlannedWorkoutStep?.Invoke(PilatesPlannedWorkoutStep!);
            }
            else if (IsRunningPlannedWorkoutStep)
            {
                runningPlannedWorkoutStep?.Invoke(RunningPlannedWorkoutStep!);
            }
            else if (IsCyclingPlannedWorkoutStep)
            {
                cyclingPlannedWorkoutStep?.Invoke(CyclingPlannedWorkoutStep!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlannedWorkoutStep,
                typeof(global::Terra.PlannedWorkoutStep),
                PlannedWorkoutRepeatStep,
                typeof(global::Terra.PlannedWorkoutRepeatStep),
                SwimmingPlannedWorkoutStep,
                typeof(global::Terra.SwimmingPlannedWorkoutStep),
                CardioPlannedWorkoutStep,
                typeof(global::Terra.CardioPlannedWorkoutStep),
                StrengthPlannedWorkoutStep,
                typeof(global::Terra.StrengthPlannedWorkoutStep),
                YogaPlannedWorkoutStep,
                typeof(global::Terra.YogaPlannedWorkoutStep),
                PilatesPlannedWorkoutStep,
                typeof(global::Terra.PilatesPlannedWorkoutStep),
                RunningPlannedWorkoutStep,
                typeof(global::Terra.RunningPlannedWorkoutStep),
                CyclingPlannedWorkoutStep,
                typeof(global::Terra.CyclingPlannedWorkoutStep),
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
        public bool Equals(PlannedWorkoutSteps other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.PlannedWorkoutStep?>.Default.Equals(PlannedWorkoutStep, other.PlannedWorkoutStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PlannedWorkoutRepeatStep?>.Default.Equals(PlannedWorkoutRepeatStep, other.PlannedWorkoutRepeatStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimmingPlannedWorkoutStep?>.Default.Equals(SwimmingPlannedWorkoutStep, other.SwimmingPlannedWorkoutStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CardioPlannedWorkoutStep?>.Default.Equals(CardioPlannedWorkoutStep, other.CardioPlannedWorkoutStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPlannedWorkoutStep?>.Default.Equals(StrengthPlannedWorkoutStep, other.StrengthPlannedWorkoutStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.YogaPlannedWorkoutStep?>.Default.Equals(YogaPlannedWorkoutStep, other.YogaPlannedWorkoutStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PilatesPlannedWorkoutStep?>.Default.Equals(PilatesPlannedWorkoutStep, other.PilatesPlannedWorkoutStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.RunningPlannedWorkoutStep?>.Default.Equals(RunningPlannedWorkoutStep, other.RunningPlannedWorkoutStep) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CyclingPlannedWorkoutStep?>.Default.Equals(CyclingPlannedWorkoutStep, other.CyclingPlannedWorkoutStep) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PlannedWorkoutSteps obj1, PlannedWorkoutSteps obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlannedWorkoutSteps>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PlannedWorkoutSteps obj1, PlannedWorkoutSteps obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlannedWorkoutSteps o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PlannedWorkoutStepTargets : global::System.IEquatable<PlannedWorkoutStepTargets>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Terra.PlannedWorkoutStepTargetsDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PlannedWorkoutStepTarget? PlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.PlannedWorkoutStepTarget? PlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlannedWorkoutStepTarget))]
#endif
        public bool IsPlannedWorkoutStepTarget => PlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.CadencePlannedWorkoutStepTarget? CadencePlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.CadencePlannedWorkoutStepTarget? CadencePlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CadencePlannedWorkoutStepTarget))]
#endif
        public bool IsCadencePlannedWorkoutStepTarget => CadencePlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.HRPlannedWorkoutStepTarget? HRPlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.HRPlannedWorkoutStepTarget? HRPlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HRPlannedWorkoutStepTarget))]
#endif
        public bool IsHRPlannedWorkoutStepTarget => HRPlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PowerPlannedWorkoutStepTarget? PowerPlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.PowerPlannedWorkoutStepTarget? PowerPlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PowerPlannedWorkoutStepTarget))]
#endif
        public bool IsPowerPlannedWorkoutStepTarget => PowerPlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SpeedPlannedWorkoutStepTarget? SpeedPlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.SpeedPlannedWorkoutStepTarget? SpeedPlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeedPlannedWorkoutStepTarget))]
#endif
        public bool IsSpeedPlannedWorkoutStepTarget => SpeedPlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PacePlannedWorkoutStepTarget? PacePlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.PacePlannedWorkoutStepTarget? PacePlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PacePlannedWorkoutStepTarget))]
#endif
        public bool IsPacePlannedWorkoutStepTarget => PacePlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.TSSPlannedWorkoutStepTarget? TSSPlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.TSSPlannedWorkoutStepTarget? TSSPlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TSSPlannedWorkoutStepTarget))]
#endif
        public bool IsTSSPlannedWorkoutStepTarget => TSSPlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.IFPlannedWorkoutStepTarget? IFPlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.IFPlannedWorkoutStepTarget? IFPlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IFPlannedWorkoutStepTarget))]
#endif
        public bool IsIFPlannedWorkoutStepTarget => IFPlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.RepetitionPlannedWorkoutStepTarget? RepetitionPlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.RepetitionPlannedWorkoutStepTarget? RepetitionPlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RepetitionPlannedWorkoutStepTarget))]
#endif
        public bool IsRepetitionPlannedWorkoutStepTarget => RepetitionPlannedWorkoutStepTarget != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokePlannedWorkoutStepTarget? SwimStrokePlannedWorkoutStepTarget { get; init; }
#else
        public global::Terra.SwimStrokePlannedWorkoutStepTarget? SwimStrokePlannedWorkoutStepTarget { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokePlannedWorkoutStepTarget))]
#endif
        public bool IsSwimStrokePlannedWorkoutStepTarget => SwimStrokePlannedWorkoutStepTarget != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.PlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.PlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.PlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.PlannedWorkoutStepTarget? value)
        {
            PlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.CadencePlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.CadencePlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.CadencePlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.CadencePlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.CadencePlannedWorkoutStepTarget? value)
        {
            CadencePlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.HRPlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.HRPlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.HRPlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.HRPlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.HRPlannedWorkoutStepTarget? value)
        {
            HRPlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.PowerPlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.PowerPlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PowerPlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.PowerPlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.PowerPlannedWorkoutStepTarget? value)
        {
            PowerPlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.SpeedPlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.SpeedPlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SpeedPlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.SpeedPlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.SpeedPlannedWorkoutStepTarget? value)
        {
            SpeedPlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.PacePlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.PacePlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.PacePlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.PacePlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.PacePlannedWorkoutStepTarget? value)
        {
            PacePlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.TSSPlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.TSSPlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.TSSPlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.TSSPlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.TSSPlannedWorkoutStepTarget? value)
        {
            TSSPlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.IFPlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.IFPlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.IFPlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.IFPlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.IFPlannedWorkoutStepTarget? value)
        {
            IFPlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.RepetitionPlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.RepetitionPlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.RepetitionPlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.RepetitionPlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.RepetitionPlannedWorkoutStepTarget? value)
        {
            RepetitionPlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PlannedWorkoutStepTargets(global::Terra.SwimStrokePlannedWorkoutStepTarget value) => new PlannedWorkoutStepTargets((global::Terra.SwimStrokePlannedWorkoutStepTarget?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokePlannedWorkoutStepTarget?(PlannedWorkoutStepTargets @this) => @this.SwimStrokePlannedWorkoutStepTarget;

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(global::Terra.SwimStrokePlannedWorkoutStepTarget? value)
        {
            SwimStrokePlannedWorkoutStepTarget = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PlannedWorkoutStepTargets(
            global::Terra.PlannedWorkoutStepTargetsDiscriminatorType? type,
            global::Terra.PlannedWorkoutStepTarget? plannedWorkoutStepTarget,
            global::Terra.CadencePlannedWorkoutStepTarget? cadencePlannedWorkoutStepTarget,
            global::Terra.HRPlannedWorkoutStepTarget? hRPlannedWorkoutStepTarget,
            global::Terra.PowerPlannedWorkoutStepTarget? powerPlannedWorkoutStepTarget,
            global::Terra.SpeedPlannedWorkoutStepTarget? speedPlannedWorkoutStepTarget,
            global::Terra.PacePlannedWorkoutStepTarget? pacePlannedWorkoutStepTarget,
            global::Terra.TSSPlannedWorkoutStepTarget? tSSPlannedWorkoutStepTarget,
            global::Terra.IFPlannedWorkoutStepTarget? iFPlannedWorkoutStepTarget,
            global::Terra.RepetitionPlannedWorkoutStepTarget? repetitionPlannedWorkoutStepTarget,
            global::Terra.SwimStrokePlannedWorkoutStepTarget? swimStrokePlannedWorkoutStepTarget
            )
        {
            Type = type;

            PlannedWorkoutStepTarget = plannedWorkoutStepTarget;
            CadencePlannedWorkoutStepTarget = cadencePlannedWorkoutStepTarget;
            HRPlannedWorkoutStepTarget = hRPlannedWorkoutStepTarget;
            PowerPlannedWorkoutStepTarget = powerPlannedWorkoutStepTarget;
            SpeedPlannedWorkoutStepTarget = speedPlannedWorkoutStepTarget;
            PacePlannedWorkoutStepTarget = pacePlannedWorkoutStepTarget;
            TSSPlannedWorkoutStepTarget = tSSPlannedWorkoutStepTarget;
            IFPlannedWorkoutStepTarget = iFPlannedWorkoutStepTarget;
            RepetitionPlannedWorkoutStepTarget = repetitionPlannedWorkoutStepTarget;
            SwimStrokePlannedWorkoutStepTarget = swimStrokePlannedWorkoutStepTarget;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SwimStrokePlannedWorkoutStepTarget as object ??
            RepetitionPlannedWorkoutStepTarget as object ??
            IFPlannedWorkoutStepTarget as object ??
            TSSPlannedWorkoutStepTarget as object ??
            PacePlannedWorkoutStepTarget as object ??
            SpeedPlannedWorkoutStepTarget as object ??
            PowerPlannedWorkoutStepTarget as object ??
            HRPlannedWorkoutStepTarget as object ??
            CadencePlannedWorkoutStepTarget as object ??
            PlannedWorkoutStepTarget as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            PlannedWorkoutStepTarget?.ToString() ??
            CadencePlannedWorkoutStepTarget?.ToString() ??
            HRPlannedWorkoutStepTarget?.ToString() ??
            PowerPlannedWorkoutStepTarget?.ToString() ??
            SpeedPlannedWorkoutStepTarget?.ToString() ??
            PacePlannedWorkoutStepTarget?.ToString() ??
            TSSPlannedWorkoutStepTarget?.ToString() ??
            IFPlannedWorkoutStepTarget?.ToString() ??
            RepetitionPlannedWorkoutStepTarget?.ToString() ??
            SwimStrokePlannedWorkoutStepTarget?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && IsRepetitionPlannedWorkoutStepTarget && !IsSwimStrokePlannedWorkoutStepTarget || !IsPlannedWorkoutStepTarget && !IsCadencePlannedWorkoutStepTarget && !IsHRPlannedWorkoutStepTarget && !IsPowerPlannedWorkoutStepTarget && !IsSpeedPlannedWorkoutStepTarget && !IsPacePlannedWorkoutStepTarget && !IsTSSPlannedWorkoutStepTarget && !IsIFPlannedWorkoutStepTarget && !IsRepetitionPlannedWorkoutStepTarget && IsSwimStrokePlannedWorkoutStepTarget;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.PlannedWorkoutStepTarget?, TResult>? plannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.CadencePlannedWorkoutStepTarget?, TResult>? cadencePlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.HRPlannedWorkoutStepTarget?, TResult>? hRPlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.PowerPlannedWorkoutStepTarget?, TResult>? powerPlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.SpeedPlannedWorkoutStepTarget?, TResult>? speedPlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.PacePlannedWorkoutStepTarget?, TResult>? pacePlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.TSSPlannedWorkoutStepTarget?, TResult>? tSSPlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.IFPlannedWorkoutStepTarget?, TResult>? iFPlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.RepetitionPlannedWorkoutStepTarget?, TResult>? repetitionPlannedWorkoutStepTarget = null,
            global::System.Func<global::Terra.SwimStrokePlannedWorkoutStepTarget?, TResult>? swimStrokePlannedWorkoutStepTarget = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlannedWorkoutStepTarget && plannedWorkoutStepTarget != null)
            {
                return plannedWorkoutStepTarget(PlannedWorkoutStepTarget!);
            }
            else if (IsCadencePlannedWorkoutStepTarget && cadencePlannedWorkoutStepTarget != null)
            {
                return cadencePlannedWorkoutStepTarget(CadencePlannedWorkoutStepTarget!);
            }
            else if (IsHRPlannedWorkoutStepTarget && hRPlannedWorkoutStepTarget != null)
            {
                return hRPlannedWorkoutStepTarget(HRPlannedWorkoutStepTarget!);
            }
            else if (IsPowerPlannedWorkoutStepTarget && powerPlannedWorkoutStepTarget != null)
            {
                return powerPlannedWorkoutStepTarget(PowerPlannedWorkoutStepTarget!);
            }
            else if (IsSpeedPlannedWorkoutStepTarget && speedPlannedWorkoutStepTarget != null)
            {
                return speedPlannedWorkoutStepTarget(SpeedPlannedWorkoutStepTarget!);
            }
            else if (IsPacePlannedWorkoutStepTarget && pacePlannedWorkoutStepTarget != null)
            {
                return pacePlannedWorkoutStepTarget(PacePlannedWorkoutStepTarget!);
            }
            else if (IsTSSPlannedWorkoutStepTarget && tSSPlannedWorkoutStepTarget != null)
            {
                return tSSPlannedWorkoutStepTarget(TSSPlannedWorkoutStepTarget!);
            }
            else if (IsIFPlannedWorkoutStepTarget && iFPlannedWorkoutStepTarget != null)
            {
                return iFPlannedWorkoutStepTarget(IFPlannedWorkoutStepTarget!);
            }
            else if (IsRepetitionPlannedWorkoutStepTarget && repetitionPlannedWorkoutStepTarget != null)
            {
                return repetitionPlannedWorkoutStepTarget(RepetitionPlannedWorkoutStepTarget!);
            }
            else if (IsSwimStrokePlannedWorkoutStepTarget && swimStrokePlannedWorkoutStepTarget != null)
            {
                return swimStrokePlannedWorkoutStepTarget(SwimStrokePlannedWorkoutStepTarget!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.PlannedWorkoutStepTarget?>? plannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.CadencePlannedWorkoutStepTarget?>? cadencePlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.HRPlannedWorkoutStepTarget?>? hRPlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.PowerPlannedWorkoutStepTarget?>? powerPlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.SpeedPlannedWorkoutStepTarget?>? speedPlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.PacePlannedWorkoutStepTarget?>? pacePlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.TSSPlannedWorkoutStepTarget?>? tSSPlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.IFPlannedWorkoutStepTarget?>? iFPlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.RepetitionPlannedWorkoutStepTarget?>? repetitionPlannedWorkoutStepTarget = null,
            global::System.Action<global::Terra.SwimStrokePlannedWorkoutStepTarget?>? swimStrokePlannedWorkoutStepTarget = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPlannedWorkoutStepTarget)
            {
                plannedWorkoutStepTarget?.Invoke(PlannedWorkoutStepTarget!);
            }
            else if (IsCadencePlannedWorkoutStepTarget)
            {
                cadencePlannedWorkoutStepTarget?.Invoke(CadencePlannedWorkoutStepTarget!);
            }
            else if (IsHRPlannedWorkoutStepTarget)
            {
                hRPlannedWorkoutStepTarget?.Invoke(HRPlannedWorkoutStepTarget!);
            }
            else if (IsPowerPlannedWorkoutStepTarget)
            {
                powerPlannedWorkoutStepTarget?.Invoke(PowerPlannedWorkoutStepTarget!);
            }
            else if (IsSpeedPlannedWorkoutStepTarget)
            {
                speedPlannedWorkoutStepTarget?.Invoke(SpeedPlannedWorkoutStepTarget!);
            }
            else if (IsPacePlannedWorkoutStepTarget)
            {
                pacePlannedWorkoutStepTarget?.Invoke(PacePlannedWorkoutStepTarget!);
            }
            else if (IsTSSPlannedWorkoutStepTarget)
            {
                tSSPlannedWorkoutStepTarget?.Invoke(TSSPlannedWorkoutStepTarget!);
            }
            else if (IsIFPlannedWorkoutStepTarget)
            {
                iFPlannedWorkoutStepTarget?.Invoke(IFPlannedWorkoutStepTarget!);
            }
            else if (IsRepetitionPlannedWorkoutStepTarget)
            {
                repetitionPlannedWorkoutStepTarget?.Invoke(RepetitionPlannedWorkoutStepTarget!);
            }
            else if (IsSwimStrokePlannedWorkoutStepTarget)
            {
                swimStrokePlannedWorkoutStepTarget?.Invoke(SwimStrokePlannedWorkoutStepTarget!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlannedWorkoutStepTarget,
                typeof(global::Terra.PlannedWorkoutStepTarget),
                CadencePlannedWorkoutStepTarget,
                typeof(global::Terra.CadencePlannedWorkoutStepTarget),
                HRPlannedWorkoutStepTarget,
                typeof(global::Terra.HRPlannedWorkoutStepTarget),
                PowerPlannedWorkoutStepTarget,
                typeof(global::Terra.PowerPlannedWorkoutStepTarget),
                SpeedPlannedWorkoutStepTarget,
                typeof(global::Terra.SpeedPlannedWorkoutStepTarget),
                PacePlannedWorkoutStepTarget,
                typeof(global::Terra.PacePlannedWorkoutStepTarget),
                TSSPlannedWorkoutStepTarget,
                typeof(global::Terra.TSSPlannedWorkoutStepTarget),
                IFPlannedWorkoutStepTarget,
                typeof(global::Terra.IFPlannedWorkoutStepTarget),
                RepetitionPlannedWorkoutStepTarget,
                typeof(global::Terra.RepetitionPlannedWorkoutStepTarget),
                SwimStrokePlannedWorkoutStepTarget,
                typeof(global::Terra.SwimStrokePlannedWorkoutStepTarget),
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
        public bool Equals(PlannedWorkoutStepTargets other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.PlannedWorkoutStepTarget?>.Default.Equals(PlannedWorkoutStepTarget, other.PlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.CadencePlannedWorkoutStepTarget?>.Default.Equals(CadencePlannedWorkoutStepTarget, other.CadencePlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.HRPlannedWorkoutStepTarget?>.Default.Equals(HRPlannedWorkoutStepTarget, other.HRPlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PowerPlannedWorkoutStepTarget?>.Default.Equals(PowerPlannedWorkoutStepTarget, other.PowerPlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SpeedPlannedWorkoutStepTarget?>.Default.Equals(SpeedPlannedWorkoutStepTarget, other.SpeedPlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PacePlannedWorkoutStepTarget?>.Default.Equals(PacePlannedWorkoutStepTarget, other.PacePlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.TSSPlannedWorkoutStepTarget?>.Default.Equals(TSSPlannedWorkoutStepTarget, other.TSSPlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.IFPlannedWorkoutStepTarget?>.Default.Equals(IFPlannedWorkoutStepTarget, other.IFPlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.RepetitionPlannedWorkoutStepTarget?>.Default.Equals(RepetitionPlannedWorkoutStepTarget, other.RepetitionPlannedWorkoutStepTarget) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokePlannedWorkoutStepTarget?>.Default.Equals(SwimStrokePlannedWorkoutStepTarget, other.SwimStrokePlannedWorkoutStepTarget) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PlannedWorkoutStepTargets obj1, PlannedWorkoutStepTargets obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlannedWorkoutStepTargets>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PlannedWorkoutStepTargets obj1, PlannedWorkoutStepTargets obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlannedWorkoutStepTargets o && Equals(o);
        }
    }
}

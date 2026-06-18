#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Intensity classification of a workout step
    /// </summary>
    public readonly partial struct WorkoutStepIntensity : global::System.IEquatable<WorkoutStepIntensity>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepIntensityVariant1? WorkoutStepIntensityVariant1 { get; init; }
#else
        public global::Terra.WorkoutStepIntensityVariant1? WorkoutStepIntensityVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepIntensityVariant1))]
#endif
        public bool IsWorkoutStepIntensityVariant1 => WorkoutStepIntensityVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWorkoutStepIntensityVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepIntensityVariant1? value)
        {
            value = WorkoutStepIntensityVariant1;
            return IsWorkoutStepIntensityVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant1 PickWorkoutStepIntensityVariant1() => IsWorkoutStepIntensityVariant1
            ? WorkoutStepIntensityVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepIntensityVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepIntensityVariant2? WorkoutStepIntensityVariant2 { get; init; }
#else
        public global::Terra.WorkoutStepIntensityVariant2? WorkoutStepIntensityVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepIntensityVariant2))]
#endif
        public bool IsWorkoutStepIntensityVariant2 => WorkoutStepIntensityVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWorkoutStepIntensityVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepIntensityVariant2? value)
        {
            value = WorkoutStepIntensityVariant2;
            return IsWorkoutStepIntensityVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant2 PickWorkoutStepIntensityVariant2() => IsWorkoutStepIntensityVariant2
            ? WorkoutStepIntensityVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepIntensityVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepIntensityVariant3? WorkoutStepIntensityVariant3 { get; init; }
#else
        public global::Terra.WorkoutStepIntensityVariant3? WorkoutStepIntensityVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepIntensityVariant3))]
#endif
        public bool IsWorkoutStepIntensityVariant3 => WorkoutStepIntensityVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWorkoutStepIntensityVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepIntensityVariant3? value)
        {
            value = WorkoutStepIntensityVariant3;
            return IsWorkoutStepIntensityVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant3 PickWorkoutStepIntensityVariant3() => IsWorkoutStepIntensityVariant3
            ? WorkoutStepIntensityVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepIntensityVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepIntensityVariant4? WorkoutStepIntensityVariant4 { get; init; }
#else
        public global::Terra.WorkoutStepIntensityVariant4? WorkoutStepIntensityVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepIntensityVariant4))]
#endif
        public bool IsWorkoutStepIntensityVariant4 => WorkoutStepIntensityVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWorkoutStepIntensityVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepIntensityVariant4? value)
        {
            value = WorkoutStepIntensityVariant4;
            return IsWorkoutStepIntensityVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant4 PickWorkoutStepIntensityVariant4() => IsWorkoutStepIntensityVariant4
            ? WorkoutStepIntensityVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepIntensityVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepIntensityVariant5? WorkoutStepIntensityVariant5 { get; init; }
#else
        public global::Terra.WorkoutStepIntensityVariant5? WorkoutStepIntensityVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepIntensityVariant5))]
#endif
        public bool IsWorkoutStepIntensityVariant5 => WorkoutStepIntensityVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWorkoutStepIntensityVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepIntensityVariant5? value)
        {
            value = WorkoutStepIntensityVariant5;
            return IsWorkoutStepIntensityVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.WorkoutStepIntensityVariant5 PickWorkoutStepIntensityVariant5() => IsWorkoutStepIntensityVariant5
            ? WorkoutStepIntensityVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepIntensityVariant5' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant1 value) => new WorkoutStepIntensity((global::Terra.WorkoutStepIntensityVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepIntensityVariant1?(WorkoutStepIntensity @this) => @this.WorkoutStepIntensityVariant1;

        /// <summary>
        /// 
        /// </summary>
        public WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant1? value)
        {
            WorkoutStepIntensityVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorkoutStepIntensity FromWorkoutStepIntensityVariant1(global::Terra.WorkoutStepIntensityVariant1? value) => new WorkoutStepIntensity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant2 value) => new WorkoutStepIntensity((global::Terra.WorkoutStepIntensityVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepIntensityVariant2?(WorkoutStepIntensity @this) => @this.WorkoutStepIntensityVariant2;

        /// <summary>
        /// 
        /// </summary>
        public WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant2? value)
        {
            WorkoutStepIntensityVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorkoutStepIntensity FromWorkoutStepIntensityVariant2(global::Terra.WorkoutStepIntensityVariant2? value) => new WorkoutStepIntensity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant3 value) => new WorkoutStepIntensity((global::Terra.WorkoutStepIntensityVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepIntensityVariant3?(WorkoutStepIntensity @this) => @this.WorkoutStepIntensityVariant3;

        /// <summary>
        /// 
        /// </summary>
        public WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant3? value)
        {
            WorkoutStepIntensityVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorkoutStepIntensity FromWorkoutStepIntensityVariant3(global::Terra.WorkoutStepIntensityVariant3? value) => new WorkoutStepIntensity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant4 value) => new WorkoutStepIntensity((global::Terra.WorkoutStepIntensityVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepIntensityVariant4?(WorkoutStepIntensity @this) => @this.WorkoutStepIntensityVariant4;

        /// <summary>
        /// 
        /// </summary>
        public WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant4? value)
        {
            WorkoutStepIntensityVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorkoutStepIntensity FromWorkoutStepIntensityVariant4(global::Terra.WorkoutStepIntensityVariant4? value) => new WorkoutStepIntensity(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant5 value) => new WorkoutStepIntensity((global::Terra.WorkoutStepIntensityVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepIntensityVariant5?(WorkoutStepIntensity @this) => @this.WorkoutStepIntensityVariant5;

        /// <summary>
        /// 
        /// </summary>
        public WorkoutStepIntensity(global::Terra.WorkoutStepIntensityVariant5? value)
        {
            WorkoutStepIntensityVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WorkoutStepIntensity FromWorkoutStepIntensityVariant5(global::Terra.WorkoutStepIntensityVariant5? value) => new WorkoutStepIntensity(value);

        /// <summary>
        /// 
        /// </summary>
        public WorkoutStepIntensity(
            global::Terra.WorkoutStepIntensityVariant1? workoutStepIntensityVariant1,
            global::Terra.WorkoutStepIntensityVariant2? workoutStepIntensityVariant2,
            global::Terra.WorkoutStepIntensityVariant3? workoutStepIntensityVariant3,
            global::Terra.WorkoutStepIntensityVariant4? workoutStepIntensityVariant4,
            global::Terra.WorkoutStepIntensityVariant5? workoutStepIntensityVariant5
            )
        {
            WorkoutStepIntensityVariant1 = workoutStepIntensityVariant1;
            WorkoutStepIntensityVariant2 = workoutStepIntensityVariant2;
            WorkoutStepIntensityVariant3 = workoutStepIntensityVariant3;
            WorkoutStepIntensityVariant4 = workoutStepIntensityVariant4;
            WorkoutStepIntensityVariant5 = workoutStepIntensityVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WorkoutStepIntensityVariant5 as object ??
            WorkoutStepIntensityVariant4 as object ??
            WorkoutStepIntensityVariant3 as object ??
            WorkoutStepIntensityVariant2 as object ??
            WorkoutStepIntensityVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            WorkoutStepIntensityVariant1?.ToValueString() ??
            WorkoutStepIntensityVariant2?.ToValueString() ??
            WorkoutStepIntensityVariant3?.ToValueString() ??
            WorkoutStepIntensityVariant4?.ToValueString() ??
            WorkoutStepIntensityVariant5?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWorkoutStepIntensityVariant1 || IsWorkoutStepIntensityVariant2 || IsWorkoutStepIntensityVariant3 || IsWorkoutStepIntensityVariant4 || IsWorkoutStepIntensityVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.WorkoutStepIntensityVariant1?, TResult>? workoutStepIntensityVariant1 = null,
            global::System.Func<global::Terra.WorkoutStepIntensityVariant2?, TResult>? workoutStepIntensityVariant2 = null,
            global::System.Func<global::Terra.WorkoutStepIntensityVariant3?, TResult>? workoutStepIntensityVariant3 = null,
            global::System.Func<global::Terra.WorkoutStepIntensityVariant4?, TResult>? workoutStepIntensityVariant4 = null,
            global::System.Func<global::Terra.WorkoutStepIntensityVariant5?, TResult>? workoutStepIntensityVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutStepIntensityVariant1 && workoutStepIntensityVariant1 != null)
            {
                return workoutStepIntensityVariant1(WorkoutStepIntensityVariant1!);
            }
            else if (IsWorkoutStepIntensityVariant2 && workoutStepIntensityVariant2 != null)
            {
                return workoutStepIntensityVariant2(WorkoutStepIntensityVariant2!);
            }
            else if (IsWorkoutStepIntensityVariant3 && workoutStepIntensityVariant3 != null)
            {
                return workoutStepIntensityVariant3(WorkoutStepIntensityVariant3!);
            }
            else if (IsWorkoutStepIntensityVariant4 && workoutStepIntensityVariant4 != null)
            {
                return workoutStepIntensityVariant4(WorkoutStepIntensityVariant4!);
            }
            else if (IsWorkoutStepIntensityVariant5 && workoutStepIntensityVariant5 != null)
            {
                return workoutStepIntensityVariant5(WorkoutStepIntensityVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.WorkoutStepIntensityVariant1?>? workoutStepIntensityVariant1 = null,

            global::System.Action<global::Terra.WorkoutStepIntensityVariant2?>? workoutStepIntensityVariant2 = null,

            global::System.Action<global::Terra.WorkoutStepIntensityVariant3?>? workoutStepIntensityVariant3 = null,

            global::System.Action<global::Terra.WorkoutStepIntensityVariant4?>? workoutStepIntensityVariant4 = null,

            global::System.Action<global::Terra.WorkoutStepIntensityVariant5?>? workoutStepIntensityVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutStepIntensityVariant1)
            {
                workoutStepIntensityVariant1?.Invoke(WorkoutStepIntensityVariant1!);
            }
            else if (IsWorkoutStepIntensityVariant2)
            {
                workoutStepIntensityVariant2?.Invoke(WorkoutStepIntensityVariant2!);
            }
            else if (IsWorkoutStepIntensityVariant3)
            {
                workoutStepIntensityVariant3?.Invoke(WorkoutStepIntensityVariant3!);
            }
            else if (IsWorkoutStepIntensityVariant4)
            {
                workoutStepIntensityVariant4?.Invoke(WorkoutStepIntensityVariant4!);
            }
            else if (IsWorkoutStepIntensityVariant5)
            {
                workoutStepIntensityVariant5?.Invoke(WorkoutStepIntensityVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.WorkoutStepIntensityVariant1?>? workoutStepIntensityVariant1 = null,
            global::System.Action<global::Terra.WorkoutStepIntensityVariant2?>? workoutStepIntensityVariant2 = null,
            global::System.Action<global::Terra.WorkoutStepIntensityVariant3?>? workoutStepIntensityVariant3 = null,
            global::System.Action<global::Terra.WorkoutStepIntensityVariant4?>? workoutStepIntensityVariant4 = null,
            global::System.Action<global::Terra.WorkoutStepIntensityVariant5?>? workoutStepIntensityVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutStepIntensityVariant1)
            {
                workoutStepIntensityVariant1?.Invoke(WorkoutStepIntensityVariant1!);
            }
            else if (IsWorkoutStepIntensityVariant2)
            {
                workoutStepIntensityVariant2?.Invoke(WorkoutStepIntensityVariant2!);
            }
            else if (IsWorkoutStepIntensityVariant3)
            {
                workoutStepIntensityVariant3?.Invoke(WorkoutStepIntensityVariant3!);
            }
            else if (IsWorkoutStepIntensityVariant4)
            {
                workoutStepIntensityVariant4?.Invoke(WorkoutStepIntensityVariant4!);
            }
            else if (IsWorkoutStepIntensityVariant5)
            {
                workoutStepIntensityVariant5?.Invoke(WorkoutStepIntensityVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkoutStepIntensityVariant1,
                typeof(global::Terra.WorkoutStepIntensityVariant1),
                WorkoutStepIntensityVariant2,
                typeof(global::Terra.WorkoutStepIntensityVariant2),
                WorkoutStepIntensityVariant3,
                typeof(global::Terra.WorkoutStepIntensityVariant3),
                WorkoutStepIntensityVariant4,
                typeof(global::Terra.WorkoutStepIntensityVariant4),
                WorkoutStepIntensityVariant5,
                typeof(global::Terra.WorkoutStepIntensityVariant5),
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
        public bool Equals(WorkoutStepIntensity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepIntensityVariant1?>.Default.Equals(WorkoutStepIntensityVariant1, other.WorkoutStepIntensityVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepIntensityVariant2?>.Default.Equals(WorkoutStepIntensityVariant2, other.WorkoutStepIntensityVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepIntensityVariant3?>.Default.Equals(WorkoutStepIntensityVariant3, other.WorkoutStepIntensityVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepIntensityVariant4?>.Default.Equals(WorkoutStepIntensityVariant4, other.WorkoutStepIntensityVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepIntensityVariant5?>.Default.Equals(WorkoutStepIntensityVariant5, other.WorkoutStepIntensityVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WorkoutStepIntensity obj1, WorkoutStepIntensity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkoutStepIntensity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WorkoutStepIntensity obj1, WorkoutStepIntensity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkoutStepIntensity o && Equals(o);
        }
    }
}

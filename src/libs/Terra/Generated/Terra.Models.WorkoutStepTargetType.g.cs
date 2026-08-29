#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Quantity an intensity target constrains
    /// </summary>
    public readonly partial struct WorkoutStepTargetType : global::System.IEquatable<WorkoutStepTargetType>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant1? WorkoutStepTargetTypeVariant1 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant1? WorkoutStepTargetTypeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant1))]
#endif
        public bool IsWorkoutStepTargetTypeVariant1 => WorkoutStepTargetTypeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant1? value)
        {
            value = WorkoutStepTargetTypeVariant1;
            return IsWorkoutStepTargetTypeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant1 PickWorkoutStepTargetTypeVariant1() => IsWorkoutStepTargetTypeVariant1
            ? WorkoutStepTargetTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant2? WorkoutStepTargetTypeVariant2 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant2? WorkoutStepTargetTypeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant2))]
#endif
        public bool IsWorkoutStepTargetTypeVariant2 => WorkoutStepTargetTypeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant2? value)
        {
            value = WorkoutStepTargetTypeVariant2;
            return IsWorkoutStepTargetTypeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant2 PickWorkoutStepTargetTypeVariant2() => IsWorkoutStepTargetTypeVariant2
            ? WorkoutStepTargetTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant3? WorkoutStepTargetTypeVariant3 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant3? WorkoutStepTargetTypeVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant3))]
#endif
        public bool IsWorkoutStepTargetTypeVariant3 => WorkoutStepTargetTypeVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant3? value)
        {
            value = WorkoutStepTargetTypeVariant3;
            return IsWorkoutStepTargetTypeVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant3 PickWorkoutStepTargetTypeVariant3() => IsWorkoutStepTargetTypeVariant3
            ? WorkoutStepTargetTypeVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant4? WorkoutStepTargetTypeVariant4 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant4? WorkoutStepTargetTypeVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant4))]
#endif
        public bool IsWorkoutStepTargetTypeVariant4 => WorkoutStepTargetTypeVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant4? value)
        {
            value = WorkoutStepTargetTypeVariant4;
            return IsWorkoutStepTargetTypeVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant4 PickWorkoutStepTargetTypeVariant4() => IsWorkoutStepTargetTypeVariant4
            ? WorkoutStepTargetTypeVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant5? WorkoutStepTargetTypeVariant5 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant5? WorkoutStepTargetTypeVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant5))]
#endif
        public bool IsWorkoutStepTargetTypeVariant5 => WorkoutStepTargetTypeVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant5? value)
        {
            value = WorkoutStepTargetTypeVariant5;
            return IsWorkoutStepTargetTypeVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant5 PickWorkoutStepTargetTypeVariant5() => IsWorkoutStepTargetTypeVariant5
            ? WorkoutStepTargetTypeVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant6? WorkoutStepTargetTypeVariant6 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant6? WorkoutStepTargetTypeVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant6))]
#endif
        public bool IsWorkoutStepTargetTypeVariant6 => WorkoutStepTargetTypeVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant6? value)
        {
            value = WorkoutStepTargetTypeVariant6;
            return IsWorkoutStepTargetTypeVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant6 PickWorkoutStepTargetTypeVariant6() => IsWorkoutStepTargetTypeVariant6
            ? WorkoutStepTargetTypeVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant7? WorkoutStepTargetTypeVariant7 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant7? WorkoutStepTargetTypeVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant7))]
#endif
        public bool IsWorkoutStepTargetTypeVariant7 => WorkoutStepTargetTypeVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant7? value)
        {
            value = WorkoutStepTargetTypeVariant7;
            return IsWorkoutStepTargetTypeVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant7 PickWorkoutStepTargetTypeVariant7() => IsWorkoutStepTargetTypeVariant7
            ? WorkoutStepTargetTypeVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant8? WorkoutStepTargetTypeVariant8 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant8? WorkoutStepTargetTypeVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant8))]
#endif
        public bool IsWorkoutStepTargetTypeVariant8 => WorkoutStepTargetTypeVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant8? value)
        {
            value = WorkoutStepTargetTypeVariant8;
            return IsWorkoutStepTargetTypeVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant8 PickWorkoutStepTargetTypeVariant8() => IsWorkoutStepTargetTypeVariant8
            ? WorkoutStepTargetTypeVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant9? WorkoutStepTargetTypeVariant9 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant9? WorkoutStepTargetTypeVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant9))]
#endif
        public bool IsWorkoutStepTargetTypeVariant9 => WorkoutStepTargetTypeVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant9? value)
        {
            value = WorkoutStepTargetTypeVariant9;
            return IsWorkoutStepTargetTypeVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant9 PickWorkoutStepTargetTypeVariant9() => IsWorkoutStepTargetTypeVariant9
            ? WorkoutStepTargetTypeVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant10? WorkoutStepTargetTypeVariant10 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant10? WorkoutStepTargetTypeVariant10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant10))]
#endif
        public bool IsWorkoutStepTargetTypeVariant10 => WorkoutStepTargetTypeVariant10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant10? value)
        {
            value = WorkoutStepTargetTypeVariant10;
            return IsWorkoutStepTargetTypeVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant10 PickWorkoutStepTargetTypeVariant10() => IsWorkoutStepTargetTypeVariant10
            ? WorkoutStepTargetTypeVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant10' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutStepTargetTypeVariant11? WorkoutStepTargetTypeVariant11 { get; init; }
#else
        public global::Terra.WorkoutStepTargetTypeVariant11? WorkoutStepTargetTypeVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutStepTargetTypeVariant11))]
#endif
        public bool IsWorkoutStepTargetTypeVariant11 => WorkoutStepTargetTypeVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutStepTargetTypeVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutStepTargetTypeVariant11? value)
        {
            value = WorkoutStepTargetTypeVariant11;
            return IsWorkoutStepTargetTypeVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutStepTargetTypeVariant11 PickWorkoutStepTargetTypeVariant11() => IsWorkoutStepTargetTypeVariant11
            ? WorkoutStepTargetTypeVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutStepTargetTypeVariant11' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant1 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant1?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant1;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant1? value)
        {
            WorkoutStepTargetTypeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant1(global::Terra.WorkoutStepTargetTypeVariant1? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant2 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant2?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant2;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant2? value)
        {
            WorkoutStepTargetTypeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant2(global::Terra.WorkoutStepTargetTypeVariant2? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant3 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant3?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant3;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant3? value)
        {
            WorkoutStepTargetTypeVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant3(global::Terra.WorkoutStepTargetTypeVariant3? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant4 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant4?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant4;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant4? value)
        {
            WorkoutStepTargetTypeVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant4(global::Terra.WorkoutStepTargetTypeVariant4? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant5 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant5?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant5;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant5? value)
        {
            WorkoutStepTargetTypeVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant5(global::Terra.WorkoutStepTargetTypeVariant5? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant6 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant6?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant6;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant6? value)
        {
            WorkoutStepTargetTypeVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant6(global::Terra.WorkoutStepTargetTypeVariant6? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant7 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant7?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant7;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant7? value)
        {
            WorkoutStepTargetTypeVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant7(global::Terra.WorkoutStepTargetTypeVariant7? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant8 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant8?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant8;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant8? value)
        {
            WorkoutStepTargetTypeVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant8(global::Terra.WorkoutStepTargetTypeVariant8? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant9 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant9?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant9;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant9? value)
        {
            WorkoutStepTargetTypeVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant9(global::Terra.WorkoutStepTargetTypeVariant9? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant10 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant10?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant10;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant10? value)
        {
            WorkoutStepTargetTypeVariant10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant10(global::Terra.WorkoutStepTargetTypeVariant10? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant11 value) => new WorkoutStepTargetType((global::Terra.WorkoutStepTargetTypeVariant11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutStepTargetTypeVariant11?(WorkoutStepTargetType @this) => @this.WorkoutStepTargetTypeVariant11;

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(global::Terra.WorkoutStepTargetTypeVariant11? value)
        {
            WorkoutStepTargetTypeVariant11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutStepTargetType FromWorkoutStepTargetTypeVariant11(global::Terra.WorkoutStepTargetTypeVariant11? value) => new WorkoutStepTargetType(value);

        /// <summary>
        ///
        /// </summary>
        public WorkoutStepTargetType(
            global::Terra.WorkoutStepTargetTypeVariant1? workoutStepTargetTypeVariant1,
            global::Terra.WorkoutStepTargetTypeVariant2? workoutStepTargetTypeVariant2,
            global::Terra.WorkoutStepTargetTypeVariant3? workoutStepTargetTypeVariant3,
            global::Terra.WorkoutStepTargetTypeVariant4? workoutStepTargetTypeVariant4,
            global::Terra.WorkoutStepTargetTypeVariant5? workoutStepTargetTypeVariant5,
            global::Terra.WorkoutStepTargetTypeVariant6? workoutStepTargetTypeVariant6,
            global::Terra.WorkoutStepTargetTypeVariant7? workoutStepTargetTypeVariant7,
            global::Terra.WorkoutStepTargetTypeVariant8? workoutStepTargetTypeVariant8,
            global::Terra.WorkoutStepTargetTypeVariant9? workoutStepTargetTypeVariant9,
            global::Terra.WorkoutStepTargetTypeVariant10? workoutStepTargetTypeVariant10,
            global::Terra.WorkoutStepTargetTypeVariant11? workoutStepTargetTypeVariant11
            )
        {
            WorkoutStepTargetTypeVariant1 = workoutStepTargetTypeVariant1;
            WorkoutStepTargetTypeVariant2 = workoutStepTargetTypeVariant2;
            WorkoutStepTargetTypeVariant3 = workoutStepTargetTypeVariant3;
            WorkoutStepTargetTypeVariant4 = workoutStepTargetTypeVariant4;
            WorkoutStepTargetTypeVariant5 = workoutStepTargetTypeVariant5;
            WorkoutStepTargetTypeVariant6 = workoutStepTargetTypeVariant6;
            WorkoutStepTargetTypeVariant7 = workoutStepTargetTypeVariant7;
            WorkoutStepTargetTypeVariant8 = workoutStepTargetTypeVariant8;
            WorkoutStepTargetTypeVariant9 = workoutStepTargetTypeVariant9;
            WorkoutStepTargetTypeVariant10 = workoutStepTargetTypeVariant10;
            WorkoutStepTargetTypeVariant11 = workoutStepTargetTypeVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WorkoutStepTargetTypeVariant11 as object ??
            WorkoutStepTargetTypeVariant10 as object ??
            WorkoutStepTargetTypeVariant9 as object ??
            WorkoutStepTargetTypeVariant8 as object ??
            WorkoutStepTargetTypeVariant7 as object ??
            WorkoutStepTargetTypeVariant6 as object ??
            WorkoutStepTargetTypeVariant5 as object ??
            WorkoutStepTargetTypeVariant4 as object ??
            WorkoutStepTargetTypeVariant3 as object ??
            WorkoutStepTargetTypeVariant2 as object ??
            WorkoutStepTargetTypeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WorkoutStepTargetTypeVariant1?.ToValueString() ??
            WorkoutStepTargetTypeVariant2?.ToValueString() ??
            WorkoutStepTargetTypeVariant3?.ToValueString() ??
            WorkoutStepTargetTypeVariant4?.ToValueString() ??
            WorkoutStepTargetTypeVariant5?.ToValueString() ??
            WorkoutStepTargetTypeVariant6?.ToValueString() ??
            WorkoutStepTargetTypeVariant7?.ToValueString() ??
            WorkoutStepTargetTypeVariant8?.ToValueString() ??
            WorkoutStepTargetTypeVariant9?.ToValueString() ??
            WorkoutStepTargetTypeVariant10?.ToValueString() ??
            WorkoutStepTargetTypeVariant11?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkoutStepTargetTypeVariant1 || IsWorkoutStepTargetTypeVariant2 || IsWorkoutStepTargetTypeVariant3 || IsWorkoutStepTargetTypeVariant4 || IsWorkoutStepTargetTypeVariant5 || IsWorkoutStepTargetTypeVariant6 || IsWorkoutStepTargetTypeVariant7 || IsWorkoutStepTargetTypeVariant8 || IsWorkoutStepTargetTypeVariant9 || IsWorkoutStepTargetTypeVariant10 || IsWorkoutStepTargetTypeVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant1?, TResult>? workoutStepTargetTypeVariant1 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant2?, TResult>? workoutStepTargetTypeVariant2 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant3?, TResult>? workoutStepTargetTypeVariant3 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant4?, TResult>? workoutStepTargetTypeVariant4 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant5?, TResult>? workoutStepTargetTypeVariant5 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant6?, TResult>? workoutStepTargetTypeVariant6 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant7?, TResult>? workoutStepTargetTypeVariant7 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant8?, TResult>? workoutStepTargetTypeVariant8 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant9?, TResult>? workoutStepTargetTypeVariant9 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant10?, TResult>? workoutStepTargetTypeVariant10 = null,
            global::System.Func<global::Terra.WorkoutStepTargetTypeVariant11?, TResult>? workoutStepTargetTypeVariant11 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutStepTargetTypeVariant1 && workoutStepTargetTypeVariant1 != null)
            {
                return workoutStepTargetTypeVariant1(WorkoutStepTargetTypeVariant1!);
            }
            else if (IsWorkoutStepTargetTypeVariant2 && workoutStepTargetTypeVariant2 != null)
            {
                return workoutStepTargetTypeVariant2(WorkoutStepTargetTypeVariant2!);
            }
            else if (IsWorkoutStepTargetTypeVariant3 && workoutStepTargetTypeVariant3 != null)
            {
                return workoutStepTargetTypeVariant3(WorkoutStepTargetTypeVariant3!);
            }
            else if (IsWorkoutStepTargetTypeVariant4 && workoutStepTargetTypeVariant4 != null)
            {
                return workoutStepTargetTypeVariant4(WorkoutStepTargetTypeVariant4!);
            }
            else if (IsWorkoutStepTargetTypeVariant5 && workoutStepTargetTypeVariant5 != null)
            {
                return workoutStepTargetTypeVariant5(WorkoutStepTargetTypeVariant5!);
            }
            else if (IsWorkoutStepTargetTypeVariant6 && workoutStepTargetTypeVariant6 != null)
            {
                return workoutStepTargetTypeVariant6(WorkoutStepTargetTypeVariant6!);
            }
            else if (IsWorkoutStepTargetTypeVariant7 && workoutStepTargetTypeVariant7 != null)
            {
                return workoutStepTargetTypeVariant7(WorkoutStepTargetTypeVariant7!);
            }
            else if (IsWorkoutStepTargetTypeVariant8 && workoutStepTargetTypeVariant8 != null)
            {
                return workoutStepTargetTypeVariant8(WorkoutStepTargetTypeVariant8!);
            }
            else if (IsWorkoutStepTargetTypeVariant9 && workoutStepTargetTypeVariant9 != null)
            {
                return workoutStepTargetTypeVariant9(WorkoutStepTargetTypeVariant9!);
            }
            else if (IsWorkoutStepTargetTypeVariant10 && workoutStepTargetTypeVariant10 != null)
            {
                return workoutStepTargetTypeVariant10(WorkoutStepTargetTypeVariant10!);
            }
            else if (IsWorkoutStepTargetTypeVariant11 && workoutStepTargetTypeVariant11 != null)
            {
                return workoutStepTargetTypeVariant11(WorkoutStepTargetTypeVariant11!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant1?>? workoutStepTargetTypeVariant1 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant2?>? workoutStepTargetTypeVariant2 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant3?>? workoutStepTargetTypeVariant3 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant4?>? workoutStepTargetTypeVariant4 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant5?>? workoutStepTargetTypeVariant5 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant6?>? workoutStepTargetTypeVariant6 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant7?>? workoutStepTargetTypeVariant7 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant8?>? workoutStepTargetTypeVariant8 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant9?>? workoutStepTargetTypeVariant9 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant10?>? workoutStepTargetTypeVariant10 = null,

            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant11?>? workoutStepTargetTypeVariant11 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutStepTargetTypeVariant1)
            {
                workoutStepTargetTypeVariant1?.Invoke(WorkoutStepTargetTypeVariant1!);
            }
            else if (IsWorkoutStepTargetTypeVariant2)
            {
                workoutStepTargetTypeVariant2?.Invoke(WorkoutStepTargetTypeVariant2!);
            }
            else if (IsWorkoutStepTargetTypeVariant3)
            {
                workoutStepTargetTypeVariant3?.Invoke(WorkoutStepTargetTypeVariant3!);
            }
            else if (IsWorkoutStepTargetTypeVariant4)
            {
                workoutStepTargetTypeVariant4?.Invoke(WorkoutStepTargetTypeVariant4!);
            }
            else if (IsWorkoutStepTargetTypeVariant5)
            {
                workoutStepTargetTypeVariant5?.Invoke(WorkoutStepTargetTypeVariant5!);
            }
            else if (IsWorkoutStepTargetTypeVariant6)
            {
                workoutStepTargetTypeVariant6?.Invoke(WorkoutStepTargetTypeVariant6!);
            }
            else if (IsWorkoutStepTargetTypeVariant7)
            {
                workoutStepTargetTypeVariant7?.Invoke(WorkoutStepTargetTypeVariant7!);
            }
            else if (IsWorkoutStepTargetTypeVariant8)
            {
                workoutStepTargetTypeVariant8?.Invoke(WorkoutStepTargetTypeVariant8!);
            }
            else if (IsWorkoutStepTargetTypeVariant9)
            {
                workoutStepTargetTypeVariant9?.Invoke(WorkoutStepTargetTypeVariant9!);
            }
            else if (IsWorkoutStepTargetTypeVariant10)
            {
                workoutStepTargetTypeVariant10?.Invoke(WorkoutStepTargetTypeVariant10!);
            }
            else if (IsWorkoutStepTargetTypeVariant11)
            {
                workoutStepTargetTypeVariant11?.Invoke(WorkoutStepTargetTypeVariant11!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant1?>? workoutStepTargetTypeVariant1 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant2?>? workoutStepTargetTypeVariant2 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant3?>? workoutStepTargetTypeVariant3 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant4?>? workoutStepTargetTypeVariant4 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant5?>? workoutStepTargetTypeVariant5 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant6?>? workoutStepTargetTypeVariant6 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant7?>? workoutStepTargetTypeVariant7 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant8?>? workoutStepTargetTypeVariant8 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant9?>? workoutStepTargetTypeVariant9 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant10?>? workoutStepTargetTypeVariant10 = null,
            global::System.Action<global::Terra.WorkoutStepTargetTypeVariant11?>? workoutStepTargetTypeVariant11 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutStepTargetTypeVariant1)
            {
                workoutStepTargetTypeVariant1?.Invoke(WorkoutStepTargetTypeVariant1!);
            }
            else if (IsWorkoutStepTargetTypeVariant2)
            {
                workoutStepTargetTypeVariant2?.Invoke(WorkoutStepTargetTypeVariant2!);
            }
            else if (IsWorkoutStepTargetTypeVariant3)
            {
                workoutStepTargetTypeVariant3?.Invoke(WorkoutStepTargetTypeVariant3!);
            }
            else if (IsWorkoutStepTargetTypeVariant4)
            {
                workoutStepTargetTypeVariant4?.Invoke(WorkoutStepTargetTypeVariant4!);
            }
            else if (IsWorkoutStepTargetTypeVariant5)
            {
                workoutStepTargetTypeVariant5?.Invoke(WorkoutStepTargetTypeVariant5!);
            }
            else if (IsWorkoutStepTargetTypeVariant6)
            {
                workoutStepTargetTypeVariant6?.Invoke(WorkoutStepTargetTypeVariant6!);
            }
            else if (IsWorkoutStepTargetTypeVariant7)
            {
                workoutStepTargetTypeVariant7?.Invoke(WorkoutStepTargetTypeVariant7!);
            }
            else if (IsWorkoutStepTargetTypeVariant8)
            {
                workoutStepTargetTypeVariant8?.Invoke(WorkoutStepTargetTypeVariant8!);
            }
            else if (IsWorkoutStepTargetTypeVariant9)
            {
                workoutStepTargetTypeVariant9?.Invoke(WorkoutStepTargetTypeVariant9!);
            }
            else if (IsWorkoutStepTargetTypeVariant10)
            {
                workoutStepTargetTypeVariant10?.Invoke(WorkoutStepTargetTypeVariant10!);
            }
            else if (IsWorkoutStepTargetTypeVariant11)
            {
                workoutStepTargetTypeVariant11?.Invoke(WorkoutStepTargetTypeVariant11!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkoutStepTargetTypeVariant1,
                typeof(global::Terra.WorkoutStepTargetTypeVariant1),
                WorkoutStepTargetTypeVariant2,
                typeof(global::Terra.WorkoutStepTargetTypeVariant2),
                WorkoutStepTargetTypeVariant3,
                typeof(global::Terra.WorkoutStepTargetTypeVariant3),
                WorkoutStepTargetTypeVariant4,
                typeof(global::Terra.WorkoutStepTargetTypeVariant4),
                WorkoutStepTargetTypeVariant5,
                typeof(global::Terra.WorkoutStepTargetTypeVariant5),
                WorkoutStepTargetTypeVariant6,
                typeof(global::Terra.WorkoutStepTargetTypeVariant6),
                WorkoutStepTargetTypeVariant7,
                typeof(global::Terra.WorkoutStepTargetTypeVariant7),
                WorkoutStepTargetTypeVariant8,
                typeof(global::Terra.WorkoutStepTargetTypeVariant8),
                WorkoutStepTargetTypeVariant9,
                typeof(global::Terra.WorkoutStepTargetTypeVariant9),
                WorkoutStepTargetTypeVariant10,
                typeof(global::Terra.WorkoutStepTargetTypeVariant10),
                WorkoutStepTargetTypeVariant11,
                typeof(global::Terra.WorkoutStepTargetTypeVariant11),
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
        public bool Equals(WorkoutStepTargetType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant1?>.Default.Equals(WorkoutStepTargetTypeVariant1, other.WorkoutStepTargetTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant2?>.Default.Equals(WorkoutStepTargetTypeVariant2, other.WorkoutStepTargetTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant3?>.Default.Equals(WorkoutStepTargetTypeVariant3, other.WorkoutStepTargetTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant4?>.Default.Equals(WorkoutStepTargetTypeVariant4, other.WorkoutStepTargetTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant5?>.Default.Equals(WorkoutStepTargetTypeVariant5, other.WorkoutStepTargetTypeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant6?>.Default.Equals(WorkoutStepTargetTypeVariant6, other.WorkoutStepTargetTypeVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant7?>.Default.Equals(WorkoutStepTargetTypeVariant7, other.WorkoutStepTargetTypeVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant8?>.Default.Equals(WorkoutStepTargetTypeVariant8, other.WorkoutStepTargetTypeVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant9?>.Default.Equals(WorkoutStepTargetTypeVariant9, other.WorkoutStepTargetTypeVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant10?>.Default.Equals(WorkoutStepTargetTypeVariant10, other.WorkoutStepTargetTypeVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutStepTargetTypeVariant11?>.Default.Equals(WorkoutStepTargetTypeVariant11, other.WorkoutStepTargetTypeVariant11)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WorkoutStepTargetType obj1, WorkoutStepTargetType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkoutStepTargetType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WorkoutStepTargetType obj1, WorkoutStepTargetType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkoutStepTargetType o && Equals(o);
        }
    }
}

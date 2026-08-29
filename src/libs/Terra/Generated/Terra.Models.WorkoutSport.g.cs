#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Sport a workout template targets. Indoor/outdoor is expressed separately via environment.
    /// </summary>
    public readonly partial struct WorkoutSport : global::System.IEquatable<WorkoutSport>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant1? WorkoutSportVariant1 { get; init; }
#else
        public global::Terra.WorkoutSportVariant1? WorkoutSportVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant1))]
#endif
        public bool IsWorkoutSportVariant1 => WorkoutSportVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant1? value)
        {
            value = WorkoutSportVariant1;
            return IsWorkoutSportVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant1 PickWorkoutSportVariant1() => IsWorkoutSportVariant1
            ? WorkoutSportVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant2? WorkoutSportVariant2 { get; init; }
#else
        public global::Terra.WorkoutSportVariant2? WorkoutSportVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant2))]
#endif
        public bool IsWorkoutSportVariant2 => WorkoutSportVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant2? value)
        {
            value = WorkoutSportVariant2;
            return IsWorkoutSportVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant2 PickWorkoutSportVariant2() => IsWorkoutSportVariant2
            ? WorkoutSportVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant3? WorkoutSportVariant3 { get; init; }
#else
        public global::Terra.WorkoutSportVariant3? WorkoutSportVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant3))]
#endif
        public bool IsWorkoutSportVariant3 => WorkoutSportVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant3? value)
        {
            value = WorkoutSportVariant3;
            return IsWorkoutSportVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant3 PickWorkoutSportVariant3() => IsWorkoutSportVariant3
            ? WorkoutSportVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant4? WorkoutSportVariant4 { get; init; }
#else
        public global::Terra.WorkoutSportVariant4? WorkoutSportVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant4))]
#endif
        public bool IsWorkoutSportVariant4 => WorkoutSportVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant4? value)
        {
            value = WorkoutSportVariant4;
            return IsWorkoutSportVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant4 PickWorkoutSportVariant4() => IsWorkoutSportVariant4
            ? WorkoutSportVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant5? WorkoutSportVariant5 { get; init; }
#else
        public global::Terra.WorkoutSportVariant5? WorkoutSportVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant5))]
#endif
        public bool IsWorkoutSportVariant5 => WorkoutSportVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant5? value)
        {
            value = WorkoutSportVariant5;
            return IsWorkoutSportVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant5 PickWorkoutSportVariant5() => IsWorkoutSportVariant5
            ? WorkoutSportVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant6? WorkoutSportVariant6 { get; init; }
#else
        public global::Terra.WorkoutSportVariant6? WorkoutSportVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant6))]
#endif
        public bool IsWorkoutSportVariant6 => WorkoutSportVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant6? value)
        {
            value = WorkoutSportVariant6;
            return IsWorkoutSportVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant6 PickWorkoutSportVariant6() => IsWorkoutSportVariant6
            ? WorkoutSportVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant7? WorkoutSportVariant7 { get; init; }
#else
        public global::Terra.WorkoutSportVariant7? WorkoutSportVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant7))]
#endif
        public bool IsWorkoutSportVariant7 => WorkoutSportVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant7? value)
        {
            value = WorkoutSportVariant7;
            return IsWorkoutSportVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant7 PickWorkoutSportVariant7() => IsWorkoutSportVariant7
            ? WorkoutSportVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant8? WorkoutSportVariant8 { get; init; }
#else
        public global::Terra.WorkoutSportVariant8? WorkoutSportVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant8))]
#endif
        public bool IsWorkoutSportVariant8 => WorkoutSportVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant8? value)
        {
            value = WorkoutSportVariant8;
            return IsWorkoutSportVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant8 PickWorkoutSportVariant8() => IsWorkoutSportVariant8
            ? WorkoutSportVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant9? WorkoutSportVariant9 { get; init; }
#else
        public global::Terra.WorkoutSportVariant9? WorkoutSportVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant9))]
#endif
        public bool IsWorkoutSportVariant9 => WorkoutSportVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant9? value)
        {
            value = WorkoutSportVariant9;
            return IsWorkoutSportVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant9 PickWorkoutSportVariant9() => IsWorkoutSportVariant9
            ? WorkoutSportVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant10? WorkoutSportVariant10 { get; init; }
#else
        public global::Terra.WorkoutSportVariant10? WorkoutSportVariant10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant10))]
#endif
        public bool IsWorkoutSportVariant10 => WorkoutSportVariant10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant10? value)
        {
            value = WorkoutSportVariant10;
            return IsWorkoutSportVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant10 PickWorkoutSportVariant10() => IsWorkoutSportVariant10
            ? WorkoutSportVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant10' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant11? WorkoutSportVariant11 { get; init; }
#else
        public global::Terra.WorkoutSportVariant11? WorkoutSportVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant11))]
#endif
        public bool IsWorkoutSportVariant11 => WorkoutSportVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant11? value)
        {
            value = WorkoutSportVariant11;
            return IsWorkoutSportVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant11 PickWorkoutSportVariant11() => IsWorkoutSportVariant11
            ? WorkoutSportVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant11' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant12? WorkoutSportVariant12 { get; init; }
#else
        public global::Terra.WorkoutSportVariant12? WorkoutSportVariant12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant12))]
#endif
        public bool IsWorkoutSportVariant12 => WorkoutSportVariant12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant12? value)
        {
            value = WorkoutSportVariant12;
            return IsWorkoutSportVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant12 PickWorkoutSportVariant12() => IsWorkoutSportVariant12
            ? WorkoutSportVariant12!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant12' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant13? WorkoutSportVariant13 { get; init; }
#else
        public global::Terra.WorkoutSportVariant13? WorkoutSportVariant13 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant13))]
#endif
        public bool IsWorkoutSportVariant13 => WorkoutSportVariant13 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant13? value)
        {
            value = WorkoutSportVariant13;
            return IsWorkoutSportVariant13;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant13 PickWorkoutSportVariant13() => IsWorkoutSportVariant13
            ? WorkoutSportVariant13!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant13' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant14? WorkoutSportVariant14 { get; init; }
#else
        public global::Terra.WorkoutSportVariant14? WorkoutSportVariant14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant14))]
#endif
        public bool IsWorkoutSportVariant14 => WorkoutSportVariant14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant14? value)
        {
            value = WorkoutSportVariant14;
            return IsWorkoutSportVariant14;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant14 PickWorkoutSportVariant14() => IsWorkoutSportVariant14
            ? WorkoutSportVariant14!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant14' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSportVariant15? WorkoutSportVariant15 { get; init; }
#else
        public global::Terra.WorkoutSportVariant15? WorkoutSportVariant15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSportVariant15))]
#endif
        public bool IsWorkoutSportVariant15 => WorkoutSportVariant15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSportVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSportVariant15? value)
        {
            value = WorkoutSportVariant15;
            return IsWorkoutSportVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSportVariant15 PickWorkoutSportVariant15() => IsWorkoutSportVariant15
            ? WorkoutSportVariant15!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSportVariant15' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant1 value) => new WorkoutSport((global::Terra.WorkoutSportVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant1?(WorkoutSport @this) => @this.WorkoutSportVariant1;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant1? value)
        {
            WorkoutSportVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant1(global::Terra.WorkoutSportVariant1? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant2 value) => new WorkoutSport((global::Terra.WorkoutSportVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant2?(WorkoutSport @this) => @this.WorkoutSportVariant2;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant2? value)
        {
            WorkoutSportVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant2(global::Terra.WorkoutSportVariant2? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant3 value) => new WorkoutSport((global::Terra.WorkoutSportVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant3?(WorkoutSport @this) => @this.WorkoutSportVariant3;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant3? value)
        {
            WorkoutSportVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant3(global::Terra.WorkoutSportVariant3? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant4 value) => new WorkoutSport((global::Terra.WorkoutSportVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant4?(WorkoutSport @this) => @this.WorkoutSportVariant4;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant4? value)
        {
            WorkoutSportVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant4(global::Terra.WorkoutSportVariant4? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant5 value) => new WorkoutSport((global::Terra.WorkoutSportVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant5?(WorkoutSport @this) => @this.WorkoutSportVariant5;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant5? value)
        {
            WorkoutSportVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant5(global::Terra.WorkoutSportVariant5? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant6 value) => new WorkoutSport((global::Terra.WorkoutSportVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant6?(WorkoutSport @this) => @this.WorkoutSportVariant6;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant6? value)
        {
            WorkoutSportVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant6(global::Terra.WorkoutSportVariant6? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant7 value) => new WorkoutSport((global::Terra.WorkoutSportVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant7?(WorkoutSport @this) => @this.WorkoutSportVariant7;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant7? value)
        {
            WorkoutSportVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant7(global::Terra.WorkoutSportVariant7? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant8 value) => new WorkoutSport((global::Terra.WorkoutSportVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant8?(WorkoutSport @this) => @this.WorkoutSportVariant8;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant8? value)
        {
            WorkoutSportVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant8(global::Terra.WorkoutSportVariant8? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant9 value) => new WorkoutSport((global::Terra.WorkoutSportVariant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant9?(WorkoutSport @this) => @this.WorkoutSportVariant9;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant9? value)
        {
            WorkoutSportVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant9(global::Terra.WorkoutSportVariant9? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant10 value) => new WorkoutSport((global::Terra.WorkoutSportVariant10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant10?(WorkoutSport @this) => @this.WorkoutSportVariant10;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant10? value)
        {
            WorkoutSportVariant10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant10(global::Terra.WorkoutSportVariant10? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant11 value) => new WorkoutSport((global::Terra.WorkoutSportVariant11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant11?(WorkoutSport @this) => @this.WorkoutSportVariant11;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant11? value)
        {
            WorkoutSportVariant11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant11(global::Terra.WorkoutSportVariant11? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant12 value) => new WorkoutSport((global::Terra.WorkoutSportVariant12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant12?(WorkoutSport @this) => @this.WorkoutSportVariant12;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant12? value)
        {
            WorkoutSportVariant12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant12(global::Terra.WorkoutSportVariant12? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant13 value) => new WorkoutSport((global::Terra.WorkoutSportVariant13?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant13?(WorkoutSport @this) => @this.WorkoutSportVariant13;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant13? value)
        {
            WorkoutSportVariant13 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant13(global::Terra.WorkoutSportVariant13? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant14 value) => new WorkoutSport((global::Terra.WorkoutSportVariant14?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant14?(WorkoutSport @this) => @this.WorkoutSportVariant14;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant14? value)
        {
            WorkoutSportVariant14 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant14(global::Terra.WorkoutSportVariant14? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WorkoutSport(global::Terra.WorkoutSportVariant15 value) => new WorkoutSport((global::Terra.WorkoutSportVariant15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSportVariant15?(WorkoutSport @this) => @this.WorkoutSportVariant15;

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(global::Terra.WorkoutSportVariant15? value)
        {
            WorkoutSportVariant15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WorkoutSport FromWorkoutSportVariant15(global::Terra.WorkoutSportVariant15? value) => new WorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public WorkoutSport(
            global::Terra.WorkoutSportVariant1? workoutSportVariant1,
            global::Terra.WorkoutSportVariant2? workoutSportVariant2,
            global::Terra.WorkoutSportVariant3? workoutSportVariant3,
            global::Terra.WorkoutSportVariant4? workoutSportVariant4,
            global::Terra.WorkoutSportVariant5? workoutSportVariant5,
            global::Terra.WorkoutSportVariant6? workoutSportVariant6,
            global::Terra.WorkoutSportVariant7? workoutSportVariant7,
            global::Terra.WorkoutSportVariant8? workoutSportVariant8,
            global::Terra.WorkoutSportVariant9? workoutSportVariant9,
            global::Terra.WorkoutSportVariant10? workoutSportVariant10,
            global::Terra.WorkoutSportVariant11? workoutSportVariant11,
            global::Terra.WorkoutSportVariant12? workoutSportVariant12,
            global::Terra.WorkoutSportVariant13? workoutSportVariant13,
            global::Terra.WorkoutSportVariant14? workoutSportVariant14,
            global::Terra.WorkoutSportVariant15? workoutSportVariant15
            )
        {
            WorkoutSportVariant1 = workoutSportVariant1;
            WorkoutSportVariant2 = workoutSportVariant2;
            WorkoutSportVariant3 = workoutSportVariant3;
            WorkoutSportVariant4 = workoutSportVariant4;
            WorkoutSportVariant5 = workoutSportVariant5;
            WorkoutSportVariant6 = workoutSportVariant6;
            WorkoutSportVariant7 = workoutSportVariant7;
            WorkoutSportVariant8 = workoutSportVariant8;
            WorkoutSportVariant9 = workoutSportVariant9;
            WorkoutSportVariant10 = workoutSportVariant10;
            WorkoutSportVariant11 = workoutSportVariant11;
            WorkoutSportVariant12 = workoutSportVariant12;
            WorkoutSportVariant13 = workoutSportVariant13;
            WorkoutSportVariant14 = workoutSportVariant14;
            WorkoutSportVariant15 = workoutSportVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WorkoutSportVariant15 as object ??
            WorkoutSportVariant14 as object ??
            WorkoutSportVariant13 as object ??
            WorkoutSportVariant12 as object ??
            WorkoutSportVariant11 as object ??
            WorkoutSportVariant10 as object ??
            WorkoutSportVariant9 as object ??
            WorkoutSportVariant8 as object ??
            WorkoutSportVariant7 as object ??
            WorkoutSportVariant6 as object ??
            WorkoutSportVariant5 as object ??
            WorkoutSportVariant4 as object ??
            WorkoutSportVariant3 as object ??
            WorkoutSportVariant2 as object ??
            WorkoutSportVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WorkoutSportVariant1?.ToValueString() ??
            WorkoutSportVariant2?.ToValueString() ??
            WorkoutSportVariant3?.ToValueString() ??
            WorkoutSportVariant4?.ToValueString() ??
            WorkoutSportVariant5?.ToValueString() ??
            WorkoutSportVariant6?.ToValueString() ??
            WorkoutSportVariant7?.ToValueString() ??
            WorkoutSportVariant8?.ToValueString() ??
            WorkoutSportVariant9?.ToValueString() ??
            WorkoutSportVariant10?.ToValueString() ??
            WorkoutSportVariant11?.ToValueString() ??
            WorkoutSportVariant12?.ToValueString() ??
            WorkoutSportVariant13?.ToValueString() ??
            WorkoutSportVariant14?.ToValueString() ??
            WorkoutSportVariant15?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkoutSportVariant1 || IsWorkoutSportVariant2 || IsWorkoutSportVariant3 || IsWorkoutSportVariant4 || IsWorkoutSportVariant5 || IsWorkoutSportVariant6 || IsWorkoutSportVariant7 || IsWorkoutSportVariant8 || IsWorkoutSportVariant9 || IsWorkoutSportVariant10 || IsWorkoutSportVariant11 || IsWorkoutSportVariant12 || IsWorkoutSportVariant13 || IsWorkoutSportVariant14 || IsWorkoutSportVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.WorkoutSportVariant1?, TResult>? workoutSportVariant1 = null,
            global::System.Func<global::Terra.WorkoutSportVariant2?, TResult>? workoutSportVariant2 = null,
            global::System.Func<global::Terra.WorkoutSportVariant3?, TResult>? workoutSportVariant3 = null,
            global::System.Func<global::Terra.WorkoutSportVariant4?, TResult>? workoutSportVariant4 = null,
            global::System.Func<global::Terra.WorkoutSportVariant5?, TResult>? workoutSportVariant5 = null,
            global::System.Func<global::Terra.WorkoutSportVariant6?, TResult>? workoutSportVariant6 = null,
            global::System.Func<global::Terra.WorkoutSportVariant7?, TResult>? workoutSportVariant7 = null,
            global::System.Func<global::Terra.WorkoutSportVariant8?, TResult>? workoutSportVariant8 = null,
            global::System.Func<global::Terra.WorkoutSportVariant9?, TResult>? workoutSportVariant9 = null,
            global::System.Func<global::Terra.WorkoutSportVariant10?, TResult>? workoutSportVariant10 = null,
            global::System.Func<global::Terra.WorkoutSportVariant11?, TResult>? workoutSportVariant11 = null,
            global::System.Func<global::Terra.WorkoutSportVariant12?, TResult>? workoutSportVariant12 = null,
            global::System.Func<global::Terra.WorkoutSportVariant13?, TResult>? workoutSportVariant13 = null,
            global::System.Func<global::Terra.WorkoutSportVariant14?, TResult>? workoutSportVariant14 = null,
            global::System.Func<global::Terra.WorkoutSportVariant15?, TResult>? workoutSportVariant15 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutSportVariant1 && workoutSportVariant1 != null)
            {
                return workoutSportVariant1(WorkoutSportVariant1!);
            }
            else if (IsWorkoutSportVariant2 && workoutSportVariant2 != null)
            {
                return workoutSportVariant2(WorkoutSportVariant2!);
            }
            else if (IsWorkoutSportVariant3 && workoutSportVariant3 != null)
            {
                return workoutSportVariant3(WorkoutSportVariant3!);
            }
            else if (IsWorkoutSportVariant4 && workoutSportVariant4 != null)
            {
                return workoutSportVariant4(WorkoutSportVariant4!);
            }
            else if (IsWorkoutSportVariant5 && workoutSportVariant5 != null)
            {
                return workoutSportVariant5(WorkoutSportVariant5!);
            }
            else if (IsWorkoutSportVariant6 && workoutSportVariant6 != null)
            {
                return workoutSportVariant6(WorkoutSportVariant6!);
            }
            else if (IsWorkoutSportVariant7 && workoutSportVariant7 != null)
            {
                return workoutSportVariant7(WorkoutSportVariant7!);
            }
            else if (IsWorkoutSportVariant8 && workoutSportVariant8 != null)
            {
                return workoutSportVariant8(WorkoutSportVariant8!);
            }
            else if (IsWorkoutSportVariant9 && workoutSportVariant9 != null)
            {
                return workoutSportVariant9(WorkoutSportVariant9!);
            }
            else if (IsWorkoutSportVariant10 && workoutSportVariant10 != null)
            {
                return workoutSportVariant10(WorkoutSportVariant10!);
            }
            else if (IsWorkoutSportVariant11 && workoutSportVariant11 != null)
            {
                return workoutSportVariant11(WorkoutSportVariant11!);
            }
            else if (IsWorkoutSportVariant12 && workoutSportVariant12 != null)
            {
                return workoutSportVariant12(WorkoutSportVariant12!);
            }
            else if (IsWorkoutSportVariant13 && workoutSportVariant13 != null)
            {
                return workoutSportVariant13(WorkoutSportVariant13!);
            }
            else if (IsWorkoutSportVariant14 && workoutSportVariant14 != null)
            {
                return workoutSportVariant14(WorkoutSportVariant14!);
            }
            else if (IsWorkoutSportVariant15 && workoutSportVariant15 != null)
            {
                return workoutSportVariant15(WorkoutSportVariant15!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.WorkoutSportVariant1?>? workoutSportVariant1 = null,

            global::System.Action<global::Terra.WorkoutSportVariant2?>? workoutSportVariant2 = null,

            global::System.Action<global::Terra.WorkoutSportVariant3?>? workoutSportVariant3 = null,

            global::System.Action<global::Terra.WorkoutSportVariant4?>? workoutSportVariant4 = null,

            global::System.Action<global::Terra.WorkoutSportVariant5?>? workoutSportVariant5 = null,

            global::System.Action<global::Terra.WorkoutSportVariant6?>? workoutSportVariant6 = null,

            global::System.Action<global::Terra.WorkoutSportVariant7?>? workoutSportVariant7 = null,

            global::System.Action<global::Terra.WorkoutSportVariant8?>? workoutSportVariant8 = null,

            global::System.Action<global::Terra.WorkoutSportVariant9?>? workoutSportVariant9 = null,

            global::System.Action<global::Terra.WorkoutSportVariant10?>? workoutSportVariant10 = null,

            global::System.Action<global::Terra.WorkoutSportVariant11?>? workoutSportVariant11 = null,

            global::System.Action<global::Terra.WorkoutSportVariant12?>? workoutSportVariant12 = null,

            global::System.Action<global::Terra.WorkoutSportVariant13?>? workoutSportVariant13 = null,

            global::System.Action<global::Terra.WorkoutSportVariant14?>? workoutSportVariant14 = null,

            global::System.Action<global::Terra.WorkoutSportVariant15?>? workoutSportVariant15 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutSportVariant1)
            {
                workoutSportVariant1?.Invoke(WorkoutSportVariant1!);
            }
            else if (IsWorkoutSportVariant2)
            {
                workoutSportVariant2?.Invoke(WorkoutSportVariant2!);
            }
            else if (IsWorkoutSportVariant3)
            {
                workoutSportVariant3?.Invoke(WorkoutSportVariant3!);
            }
            else if (IsWorkoutSportVariant4)
            {
                workoutSportVariant4?.Invoke(WorkoutSportVariant4!);
            }
            else if (IsWorkoutSportVariant5)
            {
                workoutSportVariant5?.Invoke(WorkoutSportVariant5!);
            }
            else if (IsWorkoutSportVariant6)
            {
                workoutSportVariant6?.Invoke(WorkoutSportVariant6!);
            }
            else if (IsWorkoutSportVariant7)
            {
                workoutSportVariant7?.Invoke(WorkoutSportVariant7!);
            }
            else if (IsWorkoutSportVariant8)
            {
                workoutSportVariant8?.Invoke(WorkoutSportVariant8!);
            }
            else if (IsWorkoutSportVariant9)
            {
                workoutSportVariant9?.Invoke(WorkoutSportVariant9!);
            }
            else if (IsWorkoutSportVariant10)
            {
                workoutSportVariant10?.Invoke(WorkoutSportVariant10!);
            }
            else if (IsWorkoutSportVariant11)
            {
                workoutSportVariant11?.Invoke(WorkoutSportVariant11!);
            }
            else if (IsWorkoutSportVariant12)
            {
                workoutSportVariant12?.Invoke(WorkoutSportVariant12!);
            }
            else if (IsWorkoutSportVariant13)
            {
                workoutSportVariant13?.Invoke(WorkoutSportVariant13!);
            }
            else if (IsWorkoutSportVariant14)
            {
                workoutSportVariant14?.Invoke(WorkoutSportVariant14!);
            }
            else if (IsWorkoutSportVariant15)
            {
                workoutSportVariant15?.Invoke(WorkoutSportVariant15!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.WorkoutSportVariant1?>? workoutSportVariant1 = null,
            global::System.Action<global::Terra.WorkoutSportVariant2?>? workoutSportVariant2 = null,
            global::System.Action<global::Terra.WorkoutSportVariant3?>? workoutSportVariant3 = null,
            global::System.Action<global::Terra.WorkoutSportVariant4?>? workoutSportVariant4 = null,
            global::System.Action<global::Terra.WorkoutSportVariant5?>? workoutSportVariant5 = null,
            global::System.Action<global::Terra.WorkoutSportVariant6?>? workoutSportVariant6 = null,
            global::System.Action<global::Terra.WorkoutSportVariant7?>? workoutSportVariant7 = null,
            global::System.Action<global::Terra.WorkoutSportVariant8?>? workoutSportVariant8 = null,
            global::System.Action<global::Terra.WorkoutSportVariant9?>? workoutSportVariant9 = null,
            global::System.Action<global::Terra.WorkoutSportVariant10?>? workoutSportVariant10 = null,
            global::System.Action<global::Terra.WorkoutSportVariant11?>? workoutSportVariant11 = null,
            global::System.Action<global::Terra.WorkoutSportVariant12?>? workoutSportVariant12 = null,
            global::System.Action<global::Terra.WorkoutSportVariant13?>? workoutSportVariant13 = null,
            global::System.Action<global::Terra.WorkoutSportVariant14?>? workoutSportVariant14 = null,
            global::System.Action<global::Terra.WorkoutSportVariant15?>? workoutSportVariant15 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutSportVariant1)
            {
                workoutSportVariant1?.Invoke(WorkoutSportVariant1!);
            }
            else if (IsWorkoutSportVariant2)
            {
                workoutSportVariant2?.Invoke(WorkoutSportVariant2!);
            }
            else if (IsWorkoutSportVariant3)
            {
                workoutSportVariant3?.Invoke(WorkoutSportVariant3!);
            }
            else if (IsWorkoutSportVariant4)
            {
                workoutSportVariant4?.Invoke(WorkoutSportVariant4!);
            }
            else if (IsWorkoutSportVariant5)
            {
                workoutSportVariant5?.Invoke(WorkoutSportVariant5!);
            }
            else if (IsWorkoutSportVariant6)
            {
                workoutSportVariant6?.Invoke(WorkoutSportVariant6!);
            }
            else if (IsWorkoutSportVariant7)
            {
                workoutSportVariant7?.Invoke(WorkoutSportVariant7!);
            }
            else if (IsWorkoutSportVariant8)
            {
                workoutSportVariant8?.Invoke(WorkoutSportVariant8!);
            }
            else if (IsWorkoutSportVariant9)
            {
                workoutSportVariant9?.Invoke(WorkoutSportVariant9!);
            }
            else if (IsWorkoutSportVariant10)
            {
                workoutSportVariant10?.Invoke(WorkoutSportVariant10!);
            }
            else if (IsWorkoutSportVariant11)
            {
                workoutSportVariant11?.Invoke(WorkoutSportVariant11!);
            }
            else if (IsWorkoutSportVariant12)
            {
                workoutSportVariant12?.Invoke(WorkoutSportVariant12!);
            }
            else if (IsWorkoutSportVariant13)
            {
                workoutSportVariant13?.Invoke(WorkoutSportVariant13!);
            }
            else if (IsWorkoutSportVariant14)
            {
                workoutSportVariant14?.Invoke(WorkoutSportVariant14!);
            }
            else if (IsWorkoutSportVariant15)
            {
                workoutSportVariant15?.Invoke(WorkoutSportVariant15!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkoutSportVariant1,
                typeof(global::Terra.WorkoutSportVariant1),
                WorkoutSportVariant2,
                typeof(global::Terra.WorkoutSportVariant2),
                WorkoutSportVariant3,
                typeof(global::Terra.WorkoutSportVariant3),
                WorkoutSportVariant4,
                typeof(global::Terra.WorkoutSportVariant4),
                WorkoutSportVariant5,
                typeof(global::Terra.WorkoutSportVariant5),
                WorkoutSportVariant6,
                typeof(global::Terra.WorkoutSportVariant6),
                WorkoutSportVariant7,
                typeof(global::Terra.WorkoutSportVariant7),
                WorkoutSportVariant8,
                typeof(global::Terra.WorkoutSportVariant8),
                WorkoutSportVariant9,
                typeof(global::Terra.WorkoutSportVariant9),
                WorkoutSportVariant10,
                typeof(global::Terra.WorkoutSportVariant10),
                WorkoutSportVariant11,
                typeof(global::Terra.WorkoutSportVariant11),
                WorkoutSportVariant12,
                typeof(global::Terra.WorkoutSportVariant12),
                WorkoutSportVariant13,
                typeof(global::Terra.WorkoutSportVariant13),
                WorkoutSportVariant14,
                typeof(global::Terra.WorkoutSportVariant14),
                WorkoutSportVariant15,
                typeof(global::Terra.WorkoutSportVariant15),
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
        public bool Equals(WorkoutSport other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant1?>.Default.Equals(WorkoutSportVariant1, other.WorkoutSportVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant2?>.Default.Equals(WorkoutSportVariant2, other.WorkoutSportVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant3?>.Default.Equals(WorkoutSportVariant3, other.WorkoutSportVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant4?>.Default.Equals(WorkoutSportVariant4, other.WorkoutSportVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant5?>.Default.Equals(WorkoutSportVariant5, other.WorkoutSportVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant6?>.Default.Equals(WorkoutSportVariant6, other.WorkoutSportVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant7?>.Default.Equals(WorkoutSportVariant7, other.WorkoutSportVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant8?>.Default.Equals(WorkoutSportVariant8, other.WorkoutSportVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant9?>.Default.Equals(WorkoutSportVariant9, other.WorkoutSportVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant10?>.Default.Equals(WorkoutSportVariant10, other.WorkoutSportVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant11?>.Default.Equals(WorkoutSportVariant11, other.WorkoutSportVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant12?>.Default.Equals(WorkoutSportVariant12, other.WorkoutSportVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant13?>.Default.Equals(WorkoutSportVariant13, other.WorkoutSportVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant14?>.Default.Equals(WorkoutSportVariant14, other.WorkoutSportVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSportVariant15?>.Default.Equals(WorkoutSportVariant15, other.WorkoutSportVariant15)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WorkoutSport obj1, WorkoutSport obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WorkoutSport>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WorkoutSport obj1, WorkoutSport obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WorkoutSport o && Equals(o);
        }
    }
}

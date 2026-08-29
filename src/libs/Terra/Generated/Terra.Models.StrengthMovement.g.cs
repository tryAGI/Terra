#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// The joint action an exercise performs, stripped of implement, grip, stance, tempo and position. Terra's own vocabulary, not the source's wording. Open enum — handle unknown values gracefully.<br/>
    /// Example: ab_rollout
    /// </summary>
    public readonly partial struct StrengthMovement : global::System.IEquatable<StrengthMovement>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant1? StrengthMovementVariant1 { get; init; }
#else
        public global::Terra.StrengthMovementVariant1? StrengthMovementVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant1))]
#endif
        public bool IsStrengthMovementVariant1 => StrengthMovementVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant1? value)
        {
            value = StrengthMovementVariant1;
            return IsStrengthMovementVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant1 PickStrengthMovementVariant1() => IsStrengthMovementVariant1
            ? StrengthMovementVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant2? StrengthMovementVariant2 { get; init; }
#else
        public global::Terra.StrengthMovementVariant2? StrengthMovementVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant2))]
#endif
        public bool IsStrengthMovementVariant2 => StrengthMovementVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant2? value)
        {
            value = StrengthMovementVariant2;
            return IsStrengthMovementVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant2 PickStrengthMovementVariant2() => IsStrengthMovementVariant2
            ? StrengthMovementVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant3? StrengthMovementVariant3 { get; init; }
#else
        public global::Terra.StrengthMovementVariant3? StrengthMovementVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant3))]
#endif
        public bool IsStrengthMovementVariant3 => StrengthMovementVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant3? value)
        {
            value = StrengthMovementVariant3;
            return IsStrengthMovementVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant3 PickStrengthMovementVariant3() => IsStrengthMovementVariant3
            ? StrengthMovementVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant4? StrengthMovementVariant4 { get; init; }
#else
        public global::Terra.StrengthMovementVariant4? StrengthMovementVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant4))]
#endif
        public bool IsStrengthMovementVariant4 => StrengthMovementVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant4? value)
        {
            value = StrengthMovementVariant4;
            return IsStrengthMovementVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant4 PickStrengthMovementVariant4() => IsStrengthMovementVariant4
            ? StrengthMovementVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant5? StrengthMovementVariant5 { get; init; }
#else
        public global::Terra.StrengthMovementVariant5? StrengthMovementVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant5))]
#endif
        public bool IsStrengthMovementVariant5 => StrengthMovementVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant5? value)
        {
            value = StrengthMovementVariant5;
            return IsStrengthMovementVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant5 PickStrengthMovementVariant5() => IsStrengthMovementVariant5
            ? StrengthMovementVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant6? StrengthMovementVariant6 { get; init; }
#else
        public global::Terra.StrengthMovementVariant6? StrengthMovementVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant6))]
#endif
        public bool IsStrengthMovementVariant6 => StrengthMovementVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant6? value)
        {
            value = StrengthMovementVariant6;
            return IsStrengthMovementVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant6 PickStrengthMovementVariant6() => IsStrengthMovementVariant6
            ? StrengthMovementVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant7? StrengthMovementVariant7 { get; init; }
#else
        public global::Terra.StrengthMovementVariant7? StrengthMovementVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant7))]
#endif
        public bool IsStrengthMovementVariant7 => StrengthMovementVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant7? value)
        {
            value = StrengthMovementVariant7;
            return IsStrengthMovementVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant7 PickStrengthMovementVariant7() => IsStrengthMovementVariant7
            ? StrengthMovementVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant8? StrengthMovementVariant8 { get; init; }
#else
        public global::Terra.StrengthMovementVariant8? StrengthMovementVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant8))]
#endif
        public bool IsStrengthMovementVariant8 => StrengthMovementVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant8? value)
        {
            value = StrengthMovementVariant8;
            return IsStrengthMovementVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant8 PickStrengthMovementVariant8() => IsStrengthMovementVariant8
            ? StrengthMovementVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant9? StrengthMovementVariant9 { get; init; }
#else
        public global::Terra.StrengthMovementVariant9? StrengthMovementVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant9))]
#endif
        public bool IsStrengthMovementVariant9 => StrengthMovementVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant9? value)
        {
            value = StrengthMovementVariant9;
            return IsStrengthMovementVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant9 PickStrengthMovementVariant9() => IsStrengthMovementVariant9
            ? StrengthMovementVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant10? StrengthMovementVariant10 { get; init; }
#else
        public global::Terra.StrengthMovementVariant10? StrengthMovementVariant10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant10))]
#endif
        public bool IsStrengthMovementVariant10 => StrengthMovementVariant10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant10? value)
        {
            value = StrengthMovementVariant10;
            return IsStrengthMovementVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant10 PickStrengthMovementVariant10() => IsStrengthMovementVariant10
            ? StrengthMovementVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant10' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant11? StrengthMovementVariant11 { get; init; }
#else
        public global::Terra.StrengthMovementVariant11? StrengthMovementVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant11))]
#endif
        public bool IsStrengthMovementVariant11 => StrengthMovementVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant11? value)
        {
            value = StrengthMovementVariant11;
            return IsStrengthMovementVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant11 PickStrengthMovementVariant11() => IsStrengthMovementVariant11
            ? StrengthMovementVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant11' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant12? StrengthMovementVariant12 { get; init; }
#else
        public global::Terra.StrengthMovementVariant12? StrengthMovementVariant12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant12))]
#endif
        public bool IsStrengthMovementVariant12 => StrengthMovementVariant12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant12? value)
        {
            value = StrengthMovementVariant12;
            return IsStrengthMovementVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant12 PickStrengthMovementVariant12() => IsStrengthMovementVariant12
            ? StrengthMovementVariant12!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant12' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant13? StrengthMovementVariant13 { get; init; }
#else
        public global::Terra.StrengthMovementVariant13? StrengthMovementVariant13 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant13))]
#endif
        public bool IsStrengthMovementVariant13 => StrengthMovementVariant13 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant13? value)
        {
            value = StrengthMovementVariant13;
            return IsStrengthMovementVariant13;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant13 PickStrengthMovementVariant13() => IsStrengthMovementVariant13
            ? StrengthMovementVariant13!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant13' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant14? StrengthMovementVariant14 { get; init; }
#else
        public global::Terra.StrengthMovementVariant14? StrengthMovementVariant14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant14))]
#endif
        public bool IsStrengthMovementVariant14 => StrengthMovementVariant14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant14? value)
        {
            value = StrengthMovementVariant14;
            return IsStrengthMovementVariant14;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant14 PickStrengthMovementVariant14() => IsStrengthMovementVariant14
            ? StrengthMovementVariant14!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant14' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant15? StrengthMovementVariant15 { get; init; }
#else
        public global::Terra.StrengthMovementVariant15? StrengthMovementVariant15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant15))]
#endif
        public bool IsStrengthMovementVariant15 => StrengthMovementVariant15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant15? value)
        {
            value = StrengthMovementVariant15;
            return IsStrengthMovementVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant15 PickStrengthMovementVariant15() => IsStrengthMovementVariant15
            ? StrengthMovementVariant15!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant16? StrengthMovementVariant16 { get; init; }
#else
        public global::Terra.StrengthMovementVariant16? StrengthMovementVariant16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant16))]
#endif
        public bool IsStrengthMovementVariant16 => StrengthMovementVariant16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant16? value)
        {
            value = StrengthMovementVariant16;
            return IsStrengthMovementVariant16;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant16 PickStrengthMovementVariant16() => IsStrengthMovementVariant16
            ? StrengthMovementVariant16!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant16' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant17? StrengthMovementVariant17 { get; init; }
#else
        public global::Terra.StrengthMovementVariant17? StrengthMovementVariant17 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant17))]
#endif
        public bool IsStrengthMovementVariant17 => StrengthMovementVariant17 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant17? value)
        {
            value = StrengthMovementVariant17;
            return IsStrengthMovementVariant17;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant17 PickStrengthMovementVariant17() => IsStrengthMovementVariant17
            ? StrengthMovementVariant17!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant17' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant18? StrengthMovementVariant18 { get; init; }
#else
        public global::Terra.StrengthMovementVariant18? StrengthMovementVariant18 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant18))]
#endif
        public bool IsStrengthMovementVariant18 => StrengthMovementVariant18 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant18(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant18? value)
        {
            value = StrengthMovementVariant18;
            return IsStrengthMovementVariant18;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant18 PickStrengthMovementVariant18() => IsStrengthMovementVariant18
            ? StrengthMovementVariant18!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant18' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant19? StrengthMovementVariant19 { get; init; }
#else
        public global::Terra.StrengthMovementVariant19? StrengthMovementVariant19 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant19))]
#endif
        public bool IsStrengthMovementVariant19 => StrengthMovementVariant19 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant19(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant19? value)
        {
            value = StrengthMovementVariant19;
            return IsStrengthMovementVariant19;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant19 PickStrengthMovementVariant19() => IsStrengthMovementVariant19
            ? StrengthMovementVariant19!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant19' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant20? StrengthMovementVariant20 { get; init; }
#else
        public global::Terra.StrengthMovementVariant20? StrengthMovementVariant20 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant20))]
#endif
        public bool IsStrengthMovementVariant20 => StrengthMovementVariant20 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant20? value)
        {
            value = StrengthMovementVariant20;
            return IsStrengthMovementVariant20;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant20 PickStrengthMovementVariant20() => IsStrengthMovementVariant20
            ? StrengthMovementVariant20!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant20' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant21? StrengthMovementVariant21 { get; init; }
#else
        public global::Terra.StrengthMovementVariant21? StrengthMovementVariant21 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant21))]
#endif
        public bool IsStrengthMovementVariant21 => StrengthMovementVariant21 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant21(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant21? value)
        {
            value = StrengthMovementVariant21;
            return IsStrengthMovementVariant21;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant21 PickStrengthMovementVariant21() => IsStrengthMovementVariant21
            ? StrengthMovementVariant21!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant21' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant22? StrengthMovementVariant22 { get; init; }
#else
        public global::Terra.StrengthMovementVariant22? StrengthMovementVariant22 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant22))]
#endif
        public bool IsStrengthMovementVariant22 => StrengthMovementVariant22 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant22(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant22? value)
        {
            value = StrengthMovementVariant22;
            return IsStrengthMovementVariant22;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant22 PickStrengthMovementVariant22() => IsStrengthMovementVariant22
            ? StrengthMovementVariant22!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant22' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant23? StrengthMovementVariant23 { get; init; }
#else
        public global::Terra.StrengthMovementVariant23? StrengthMovementVariant23 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant23))]
#endif
        public bool IsStrengthMovementVariant23 => StrengthMovementVariant23 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant23(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant23? value)
        {
            value = StrengthMovementVariant23;
            return IsStrengthMovementVariant23;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant23 PickStrengthMovementVariant23() => IsStrengthMovementVariant23
            ? StrengthMovementVariant23!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant23' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant24? StrengthMovementVariant24 { get; init; }
#else
        public global::Terra.StrengthMovementVariant24? StrengthMovementVariant24 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant24))]
#endif
        public bool IsStrengthMovementVariant24 => StrengthMovementVariant24 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant24(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant24? value)
        {
            value = StrengthMovementVariant24;
            return IsStrengthMovementVariant24;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant24 PickStrengthMovementVariant24() => IsStrengthMovementVariant24
            ? StrengthMovementVariant24!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant24' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant25? StrengthMovementVariant25 { get; init; }
#else
        public global::Terra.StrengthMovementVariant25? StrengthMovementVariant25 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant25))]
#endif
        public bool IsStrengthMovementVariant25 => StrengthMovementVariant25 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant25? value)
        {
            value = StrengthMovementVariant25;
            return IsStrengthMovementVariant25;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant25 PickStrengthMovementVariant25() => IsStrengthMovementVariant25
            ? StrengthMovementVariant25!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant25' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant26? StrengthMovementVariant26 { get; init; }
#else
        public global::Terra.StrengthMovementVariant26? StrengthMovementVariant26 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant26))]
#endif
        public bool IsStrengthMovementVariant26 => StrengthMovementVariant26 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant26(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant26? value)
        {
            value = StrengthMovementVariant26;
            return IsStrengthMovementVariant26;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant26 PickStrengthMovementVariant26() => IsStrengthMovementVariant26
            ? StrengthMovementVariant26!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant26' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant27? StrengthMovementVariant27 { get; init; }
#else
        public global::Terra.StrengthMovementVariant27? StrengthMovementVariant27 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant27))]
#endif
        public bool IsStrengthMovementVariant27 => StrengthMovementVariant27 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant27(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant27? value)
        {
            value = StrengthMovementVariant27;
            return IsStrengthMovementVariant27;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant27 PickStrengthMovementVariant27() => IsStrengthMovementVariant27
            ? StrengthMovementVariant27!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant27' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant28? StrengthMovementVariant28 { get; init; }
#else
        public global::Terra.StrengthMovementVariant28? StrengthMovementVariant28 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant28))]
#endif
        public bool IsStrengthMovementVariant28 => StrengthMovementVariant28 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant28(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant28? value)
        {
            value = StrengthMovementVariant28;
            return IsStrengthMovementVariant28;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant28 PickStrengthMovementVariant28() => IsStrengthMovementVariant28
            ? StrengthMovementVariant28!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant28' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant29? StrengthMovementVariant29 { get; init; }
#else
        public global::Terra.StrengthMovementVariant29? StrengthMovementVariant29 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant29))]
#endif
        public bool IsStrengthMovementVariant29 => StrengthMovementVariant29 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant29(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant29? value)
        {
            value = StrengthMovementVariant29;
            return IsStrengthMovementVariant29;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant29 PickStrengthMovementVariant29() => IsStrengthMovementVariant29
            ? StrengthMovementVariant29!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant29' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant30? StrengthMovementVariant30 { get; init; }
#else
        public global::Terra.StrengthMovementVariant30? StrengthMovementVariant30 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant30))]
#endif
        public bool IsStrengthMovementVariant30 => StrengthMovementVariant30 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant30(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant30? value)
        {
            value = StrengthMovementVariant30;
            return IsStrengthMovementVariant30;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant30 PickStrengthMovementVariant30() => IsStrengthMovementVariant30
            ? StrengthMovementVariant30!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant30' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant31? StrengthMovementVariant31 { get; init; }
#else
        public global::Terra.StrengthMovementVariant31? StrengthMovementVariant31 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant31))]
#endif
        public bool IsStrengthMovementVariant31 => StrengthMovementVariant31 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant31(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant31? value)
        {
            value = StrengthMovementVariant31;
            return IsStrengthMovementVariant31;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant31 PickStrengthMovementVariant31() => IsStrengthMovementVariant31
            ? StrengthMovementVariant31!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant31' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant32? StrengthMovementVariant32 { get; init; }
#else
        public global::Terra.StrengthMovementVariant32? StrengthMovementVariant32 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant32))]
#endif
        public bool IsStrengthMovementVariant32 => StrengthMovementVariant32 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant32(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant32? value)
        {
            value = StrengthMovementVariant32;
            return IsStrengthMovementVariant32;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant32 PickStrengthMovementVariant32() => IsStrengthMovementVariant32
            ? StrengthMovementVariant32!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant32' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant33? StrengthMovementVariant33 { get; init; }
#else
        public global::Terra.StrengthMovementVariant33? StrengthMovementVariant33 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant33))]
#endif
        public bool IsStrengthMovementVariant33 => StrengthMovementVariant33 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant33(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant33? value)
        {
            value = StrengthMovementVariant33;
            return IsStrengthMovementVariant33;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant33 PickStrengthMovementVariant33() => IsStrengthMovementVariant33
            ? StrengthMovementVariant33!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant33' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant34? StrengthMovementVariant34 { get; init; }
#else
        public global::Terra.StrengthMovementVariant34? StrengthMovementVariant34 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant34))]
#endif
        public bool IsStrengthMovementVariant34 => StrengthMovementVariant34 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant34(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant34? value)
        {
            value = StrengthMovementVariant34;
            return IsStrengthMovementVariant34;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant34 PickStrengthMovementVariant34() => IsStrengthMovementVariant34
            ? StrengthMovementVariant34!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant34' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant35? StrengthMovementVariant35 { get; init; }
#else
        public global::Terra.StrengthMovementVariant35? StrengthMovementVariant35 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant35))]
#endif
        public bool IsStrengthMovementVariant35 => StrengthMovementVariant35 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant35(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant35? value)
        {
            value = StrengthMovementVariant35;
            return IsStrengthMovementVariant35;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant35 PickStrengthMovementVariant35() => IsStrengthMovementVariant35
            ? StrengthMovementVariant35!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant35' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant36? StrengthMovementVariant36 { get; init; }
#else
        public global::Terra.StrengthMovementVariant36? StrengthMovementVariant36 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant36))]
#endif
        public bool IsStrengthMovementVariant36 => StrengthMovementVariant36 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant36(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant36? value)
        {
            value = StrengthMovementVariant36;
            return IsStrengthMovementVariant36;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant36 PickStrengthMovementVariant36() => IsStrengthMovementVariant36
            ? StrengthMovementVariant36!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant36' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant37? StrengthMovementVariant37 { get; init; }
#else
        public global::Terra.StrengthMovementVariant37? StrengthMovementVariant37 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant37))]
#endif
        public bool IsStrengthMovementVariant37 => StrengthMovementVariant37 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant37(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant37? value)
        {
            value = StrengthMovementVariant37;
            return IsStrengthMovementVariant37;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant37 PickStrengthMovementVariant37() => IsStrengthMovementVariant37
            ? StrengthMovementVariant37!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant37' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant38? StrengthMovementVariant38 { get; init; }
#else
        public global::Terra.StrengthMovementVariant38? StrengthMovementVariant38 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant38))]
#endif
        public bool IsStrengthMovementVariant38 => StrengthMovementVariant38 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant38(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant38? value)
        {
            value = StrengthMovementVariant38;
            return IsStrengthMovementVariant38;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant38 PickStrengthMovementVariant38() => IsStrengthMovementVariant38
            ? StrengthMovementVariant38!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant38' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant39? StrengthMovementVariant39 { get; init; }
#else
        public global::Terra.StrengthMovementVariant39? StrengthMovementVariant39 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant39))]
#endif
        public bool IsStrengthMovementVariant39 => StrengthMovementVariant39 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant39(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant39? value)
        {
            value = StrengthMovementVariant39;
            return IsStrengthMovementVariant39;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant39 PickStrengthMovementVariant39() => IsStrengthMovementVariant39
            ? StrengthMovementVariant39!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant39' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant40? StrengthMovementVariant40 { get; init; }
#else
        public global::Terra.StrengthMovementVariant40? StrengthMovementVariant40 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant40))]
#endif
        public bool IsStrengthMovementVariant40 => StrengthMovementVariant40 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant40(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant40? value)
        {
            value = StrengthMovementVariant40;
            return IsStrengthMovementVariant40;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant40 PickStrengthMovementVariant40() => IsStrengthMovementVariant40
            ? StrengthMovementVariant40!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant40' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant41? StrengthMovementVariant41 { get; init; }
#else
        public global::Terra.StrengthMovementVariant41? StrengthMovementVariant41 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant41))]
#endif
        public bool IsStrengthMovementVariant41 => StrengthMovementVariant41 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant41(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant41? value)
        {
            value = StrengthMovementVariant41;
            return IsStrengthMovementVariant41;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant41 PickStrengthMovementVariant41() => IsStrengthMovementVariant41
            ? StrengthMovementVariant41!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant41' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant42? StrengthMovementVariant42 { get; init; }
#else
        public global::Terra.StrengthMovementVariant42? StrengthMovementVariant42 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant42))]
#endif
        public bool IsStrengthMovementVariant42 => StrengthMovementVariant42 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant42(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant42? value)
        {
            value = StrengthMovementVariant42;
            return IsStrengthMovementVariant42;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant42 PickStrengthMovementVariant42() => IsStrengthMovementVariant42
            ? StrengthMovementVariant42!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant42' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant43? StrengthMovementVariant43 { get; init; }
#else
        public global::Terra.StrengthMovementVariant43? StrengthMovementVariant43 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant43))]
#endif
        public bool IsStrengthMovementVariant43 => StrengthMovementVariant43 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant43(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant43? value)
        {
            value = StrengthMovementVariant43;
            return IsStrengthMovementVariant43;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant43 PickStrengthMovementVariant43() => IsStrengthMovementVariant43
            ? StrengthMovementVariant43!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant43' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant44? StrengthMovementVariant44 { get; init; }
#else
        public global::Terra.StrengthMovementVariant44? StrengthMovementVariant44 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant44))]
#endif
        public bool IsStrengthMovementVariant44 => StrengthMovementVariant44 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant44(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant44? value)
        {
            value = StrengthMovementVariant44;
            return IsStrengthMovementVariant44;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant44 PickStrengthMovementVariant44() => IsStrengthMovementVariant44
            ? StrengthMovementVariant44!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant44' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant45? StrengthMovementVariant45 { get; init; }
#else
        public global::Terra.StrengthMovementVariant45? StrengthMovementVariant45 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant45))]
#endif
        public bool IsStrengthMovementVariant45 => StrengthMovementVariant45 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant45(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant45? value)
        {
            value = StrengthMovementVariant45;
            return IsStrengthMovementVariant45;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant45 PickStrengthMovementVariant45() => IsStrengthMovementVariant45
            ? StrengthMovementVariant45!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant45' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant46? StrengthMovementVariant46 { get; init; }
#else
        public global::Terra.StrengthMovementVariant46? StrengthMovementVariant46 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant46))]
#endif
        public bool IsStrengthMovementVariant46 => StrengthMovementVariant46 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant46(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant46? value)
        {
            value = StrengthMovementVariant46;
            return IsStrengthMovementVariant46;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant46 PickStrengthMovementVariant46() => IsStrengthMovementVariant46
            ? StrengthMovementVariant46!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant46' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant47? StrengthMovementVariant47 { get; init; }
#else
        public global::Terra.StrengthMovementVariant47? StrengthMovementVariant47 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant47))]
#endif
        public bool IsStrengthMovementVariant47 => StrengthMovementVariant47 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant47(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant47? value)
        {
            value = StrengthMovementVariant47;
            return IsStrengthMovementVariant47;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant47 PickStrengthMovementVariant47() => IsStrengthMovementVariant47
            ? StrengthMovementVariant47!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant47' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant48? StrengthMovementVariant48 { get; init; }
#else
        public global::Terra.StrengthMovementVariant48? StrengthMovementVariant48 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant48))]
#endif
        public bool IsStrengthMovementVariant48 => StrengthMovementVariant48 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant48(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant48? value)
        {
            value = StrengthMovementVariant48;
            return IsStrengthMovementVariant48;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant48 PickStrengthMovementVariant48() => IsStrengthMovementVariant48
            ? StrengthMovementVariant48!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant48' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant49? StrengthMovementVariant49 { get; init; }
#else
        public global::Terra.StrengthMovementVariant49? StrengthMovementVariant49 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant49))]
#endif
        public bool IsStrengthMovementVariant49 => StrengthMovementVariant49 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant49(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant49? value)
        {
            value = StrengthMovementVariant49;
            return IsStrengthMovementVariant49;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant49 PickStrengthMovementVariant49() => IsStrengthMovementVariant49
            ? StrengthMovementVariant49!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant49' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant50? StrengthMovementVariant50 { get; init; }
#else
        public global::Terra.StrengthMovementVariant50? StrengthMovementVariant50 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant50))]
#endif
        public bool IsStrengthMovementVariant50 => StrengthMovementVariant50 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant50(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant50? value)
        {
            value = StrengthMovementVariant50;
            return IsStrengthMovementVariant50;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant50 PickStrengthMovementVariant50() => IsStrengthMovementVariant50
            ? StrengthMovementVariant50!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant50' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant51? StrengthMovementVariant51 { get; init; }
#else
        public global::Terra.StrengthMovementVariant51? StrengthMovementVariant51 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant51))]
#endif
        public bool IsStrengthMovementVariant51 => StrengthMovementVariant51 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant51(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant51? value)
        {
            value = StrengthMovementVariant51;
            return IsStrengthMovementVariant51;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant51 PickStrengthMovementVariant51() => IsStrengthMovementVariant51
            ? StrengthMovementVariant51!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant51' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant52? StrengthMovementVariant52 { get; init; }
#else
        public global::Terra.StrengthMovementVariant52? StrengthMovementVariant52 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant52))]
#endif
        public bool IsStrengthMovementVariant52 => StrengthMovementVariant52 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant52(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant52? value)
        {
            value = StrengthMovementVariant52;
            return IsStrengthMovementVariant52;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant52 PickStrengthMovementVariant52() => IsStrengthMovementVariant52
            ? StrengthMovementVariant52!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant52' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant53? StrengthMovementVariant53 { get; init; }
#else
        public global::Terra.StrengthMovementVariant53? StrengthMovementVariant53 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant53))]
#endif
        public bool IsStrengthMovementVariant53 => StrengthMovementVariant53 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant53(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant53? value)
        {
            value = StrengthMovementVariant53;
            return IsStrengthMovementVariant53;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant53 PickStrengthMovementVariant53() => IsStrengthMovementVariant53
            ? StrengthMovementVariant53!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant53' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant54? StrengthMovementVariant54 { get; init; }
#else
        public global::Terra.StrengthMovementVariant54? StrengthMovementVariant54 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant54))]
#endif
        public bool IsStrengthMovementVariant54 => StrengthMovementVariant54 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant54(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant54? value)
        {
            value = StrengthMovementVariant54;
            return IsStrengthMovementVariant54;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant54 PickStrengthMovementVariant54() => IsStrengthMovementVariant54
            ? StrengthMovementVariant54!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant54' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant55? StrengthMovementVariant55 { get; init; }
#else
        public global::Terra.StrengthMovementVariant55? StrengthMovementVariant55 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant55))]
#endif
        public bool IsStrengthMovementVariant55 => StrengthMovementVariant55 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant55(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant55? value)
        {
            value = StrengthMovementVariant55;
            return IsStrengthMovementVariant55;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant55 PickStrengthMovementVariant55() => IsStrengthMovementVariant55
            ? StrengthMovementVariant55!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant55' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant56? StrengthMovementVariant56 { get; init; }
#else
        public global::Terra.StrengthMovementVariant56? StrengthMovementVariant56 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant56))]
#endif
        public bool IsStrengthMovementVariant56 => StrengthMovementVariant56 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant56(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant56? value)
        {
            value = StrengthMovementVariant56;
            return IsStrengthMovementVariant56;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant56 PickStrengthMovementVariant56() => IsStrengthMovementVariant56
            ? StrengthMovementVariant56!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant56' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant57? StrengthMovementVariant57 { get; init; }
#else
        public global::Terra.StrengthMovementVariant57? StrengthMovementVariant57 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant57))]
#endif
        public bool IsStrengthMovementVariant57 => StrengthMovementVariant57 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant57(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant57? value)
        {
            value = StrengthMovementVariant57;
            return IsStrengthMovementVariant57;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant57 PickStrengthMovementVariant57() => IsStrengthMovementVariant57
            ? StrengthMovementVariant57!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant57' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant58? StrengthMovementVariant58 { get; init; }
#else
        public global::Terra.StrengthMovementVariant58? StrengthMovementVariant58 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant58))]
#endif
        public bool IsStrengthMovementVariant58 => StrengthMovementVariant58 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant58(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant58? value)
        {
            value = StrengthMovementVariant58;
            return IsStrengthMovementVariant58;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant58 PickStrengthMovementVariant58() => IsStrengthMovementVariant58
            ? StrengthMovementVariant58!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant58' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant59? StrengthMovementVariant59 { get; init; }
#else
        public global::Terra.StrengthMovementVariant59? StrengthMovementVariant59 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant59))]
#endif
        public bool IsStrengthMovementVariant59 => StrengthMovementVariant59 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant59(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant59? value)
        {
            value = StrengthMovementVariant59;
            return IsStrengthMovementVariant59;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant59 PickStrengthMovementVariant59() => IsStrengthMovementVariant59
            ? StrengthMovementVariant59!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant59' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant60? StrengthMovementVariant60 { get; init; }
#else
        public global::Terra.StrengthMovementVariant60? StrengthMovementVariant60 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant60))]
#endif
        public bool IsStrengthMovementVariant60 => StrengthMovementVariant60 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant60(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant60? value)
        {
            value = StrengthMovementVariant60;
            return IsStrengthMovementVariant60;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant60 PickStrengthMovementVariant60() => IsStrengthMovementVariant60
            ? StrengthMovementVariant60!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant60' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant61? StrengthMovementVariant61 { get; init; }
#else
        public global::Terra.StrengthMovementVariant61? StrengthMovementVariant61 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant61))]
#endif
        public bool IsStrengthMovementVariant61 => StrengthMovementVariant61 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant61(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant61? value)
        {
            value = StrengthMovementVariant61;
            return IsStrengthMovementVariant61;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant61 PickStrengthMovementVariant61() => IsStrengthMovementVariant61
            ? StrengthMovementVariant61!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant61' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant62? StrengthMovementVariant62 { get; init; }
#else
        public global::Terra.StrengthMovementVariant62? StrengthMovementVariant62 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant62))]
#endif
        public bool IsStrengthMovementVariant62 => StrengthMovementVariant62 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant62(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant62? value)
        {
            value = StrengthMovementVariant62;
            return IsStrengthMovementVariant62;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant62 PickStrengthMovementVariant62() => IsStrengthMovementVariant62
            ? StrengthMovementVariant62!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant62' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant63? StrengthMovementVariant63 { get; init; }
#else
        public global::Terra.StrengthMovementVariant63? StrengthMovementVariant63 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant63))]
#endif
        public bool IsStrengthMovementVariant63 => StrengthMovementVariant63 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant63(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant63? value)
        {
            value = StrengthMovementVariant63;
            return IsStrengthMovementVariant63;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant63 PickStrengthMovementVariant63() => IsStrengthMovementVariant63
            ? StrengthMovementVariant63!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant63' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant64? StrengthMovementVariant64 { get; init; }
#else
        public global::Terra.StrengthMovementVariant64? StrengthMovementVariant64 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant64))]
#endif
        public bool IsStrengthMovementVariant64 => StrengthMovementVariant64 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant64(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant64? value)
        {
            value = StrengthMovementVariant64;
            return IsStrengthMovementVariant64;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant64 PickStrengthMovementVariant64() => IsStrengthMovementVariant64
            ? StrengthMovementVariant64!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant64' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant65? StrengthMovementVariant65 { get; init; }
#else
        public global::Terra.StrengthMovementVariant65? StrengthMovementVariant65 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant65))]
#endif
        public bool IsStrengthMovementVariant65 => StrengthMovementVariant65 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant65(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant65? value)
        {
            value = StrengthMovementVariant65;
            return IsStrengthMovementVariant65;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant65 PickStrengthMovementVariant65() => IsStrengthMovementVariant65
            ? StrengthMovementVariant65!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant65' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant66? StrengthMovementVariant66 { get; init; }
#else
        public global::Terra.StrengthMovementVariant66? StrengthMovementVariant66 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant66))]
#endif
        public bool IsStrengthMovementVariant66 => StrengthMovementVariant66 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant66(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant66? value)
        {
            value = StrengthMovementVariant66;
            return IsStrengthMovementVariant66;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant66 PickStrengthMovementVariant66() => IsStrengthMovementVariant66
            ? StrengthMovementVariant66!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant66' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant67? StrengthMovementVariant67 { get; init; }
#else
        public global::Terra.StrengthMovementVariant67? StrengthMovementVariant67 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant67))]
#endif
        public bool IsStrengthMovementVariant67 => StrengthMovementVariant67 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant67(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant67? value)
        {
            value = StrengthMovementVariant67;
            return IsStrengthMovementVariant67;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant67 PickStrengthMovementVariant67() => IsStrengthMovementVariant67
            ? StrengthMovementVariant67!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant67' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant68? StrengthMovementVariant68 { get; init; }
#else
        public global::Terra.StrengthMovementVariant68? StrengthMovementVariant68 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant68))]
#endif
        public bool IsStrengthMovementVariant68 => StrengthMovementVariant68 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant68(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant68? value)
        {
            value = StrengthMovementVariant68;
            return IsStrengthMovementVariant68;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant68 PickStrengthMovementVariant68() => IsStrengthMovementVariant68
            ? StrengthMovementVariant68!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant68' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant69? StrengthMovementVariant69 { get; init; }
#else
        public global::Terra.StrengthMovementVariant69? StrengthMovementVariant69 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant69))]
#endif
        public bool IsStrengthMovementVariant69 => StrengthMovementVariant69 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant69(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant69? value)
        {
            value = StrengthMovementVariant69;
            return IsStrengthMovementVariant69;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant69 PickStrengthMovementVariant69() => IsStrengthMovementVariant69
            ? StrengthMovementVariant69!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant69' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant70? StrengthMovementVariant70 { get; init; }
#else
        public global::Terra.StrengthMovementVariant70? StrengthMovementVariant70 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant70))]
#endif
        public bool IsStrengthMovementVariant70 => StrengthMovementVariant70 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant70(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant70? value)
        {
            value = StrengthMovementVariant70;
            return IsStrengthMovementVariant70;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant70 PickStrengthMovementVariant70() => IsStrengthMovementVariant70
            ? StrengthMovementVariant70!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant70' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant71? StrengthMovementVariant71 { get; init; }
#else
        public global::Terra.StrengthMovementVariant71? StrengthMovementVariant71 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant71))]
#endif
        public bool IsStrengthMovementVariant71 => StrengthMovementVariant71 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant71(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant71? value)
        {
            value = StrengthMovementVariant71;
            return IsStrengthMovementVariant71;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant71 PickStrengthMovementVariant71() => IsStrengthMovementVariant71
            ? StrengthMovementVariant71!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant71' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant72? StrengthMovementVariant72 { get; init; }
#else
        public global::Terra.StrengthMovementVariant72? StrengthMovementVariant72 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant72))]
#endif
        public bool IsStrengthMovementVariant72 => StrengthMovementVariant72 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant72(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant72? value)
        {
            value = StrengthMovementVariant72;
            return IsStrengthMovementVariant72;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant72 PickStrengthMovementVariant72() => IsStrengthMovementVariant72
            ? StrengthMovementVariant72!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant72' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant73? StrengthMovementVariant73 { get; init; }
#else
        public global::Terra.StrengthMovementVariant73? StrengthMovementVariant73 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant73))]
#endif
        public bool IsStrengthMovementVariant73 => StrengthMovementVariant73 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant73(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant73? value)
        {
            value = StrengthMovementVariant73;
            return IsStrengthMovementVariant73;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant73 PickStrengthMovementVariant73() => IsStrengthMovementVariant73
            ? StrengthMovementVariant73!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant73' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant74? StrengthMovementVariant74 { get; init; }
#else
        public global::Terra.StrengthMovementVariant74? StrengthMovementVariant74 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant74))]
#endif
        public bool IsStrengthMovementVariant74 => StrengthMovementVariant74 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant74(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant74? value)
        {
            value = StrengthMovementVariant74;
            return IsStrengthMovementVariant74;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant74 PickStrengthMovementVariant74() => IsStrengthMovementVariant74
            ? StrengthMovementVariant74!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant74' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant75? StrengthMovementVariant75 { get; init; }
#else
        public global::Terra.StrengthMovementVariant75? StrengthMovementVariant75 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant75))]
#endif
        public bool IsStrengthMovementVariant75 => StrengthMovementVariant75 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant75(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant75? value)
        {
            value = StrengthMovementVariant75;
            return IsStrengthMovementVariant75;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant75 PickStrengthMovementVariant75() => IsStrengthMovementVariant75
            ? StrengthMovementVariant75!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant75' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant76? StrengthMovementVariant76 { get; init; }
#else
        public global::Terra.StrengthMovementVariant76? StrengthMovementVariant76 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant76))]
#endif
        public bool IsStrengthMovementVariant76 => StrengthMovementVariant76 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant76(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant76? value)
        {
            value = StrengthMovementVariant76;
            return IsStrengthMovementVariant76;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant76 PickStrengthMovementVariant76() => IsStrengthMovementVariant76
            ? StrengthMovementVariant76!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant76' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant77? StrengthMovementVariant77 { get; init; }
#else
        public global::Terra.StrengthMovementVariant77? StrengthMovementVariant77 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant77))]
#endif
        public bool IsStrengthMovementVariant77 => StrengthMovementVariant77 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant77(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant77? value)
        {
            value = StrengthMovementVariant77;
            return IsStrengthMovementVariant77;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant77 PickStrengthMovementVariant77() => IsStrengthMovementVariant77
            ? StrengthMovementVariant77!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant77' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant78? StrengthMovementVariant78 { get; init; }
#else
        public global::Terra.StrengthMovementVariant78? StrengthMovementVariant78 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant78))]
#endif
        public bool IsStrengthMovementVariant78 => StrengthMovementVariant78 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant78(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant78? value)
        {
            value = StrengthMovementVariant78;
            return IsStrengthMovementVariant78;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant78 PickStrengthMovementVariant78() => IsStrengthMovementVariant78
            ? StrengthMovementVariant78!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant78' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant79? StrengthMovementVariant79 { get; init; }
#else
        public global::Terra.StrengthMovementVariant79? StrengthMovementVariant79 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant79))]
#endif
        public bool IsStrengthMovementVariant79 => StrengthMovementVariant79 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant79(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant79? value)
        {
            value = StrengthMovementVariant79;
            return IsStrengthMovementVariant79;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant79 PickStrengthMovementVariant79() => IsStrengthMovementVariant79
            ? StrengthMovementVariant79!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant79' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant80? StrengthMovementVariant80 { get; init; }
#else
        public global::Terra.StrengthMovementVariant80? StrengthMovementVariant80 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant80))]
#endif
        public bool IsStrengthMovementVariant80 => StrengthMovementVariant80 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant80(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant80? value)
        {
            value = StrengthMovementVariant80;
            return IsStrengthMovementVariant80;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant80 PickStrengthMovementVariant80() => IsStrengthMovementVariant80
            ? StrengthMovementVariant80!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant80' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant81? StrengthMovementVariant81 { get; init; }
#else
        public global::Terra.StrengthMovementVariant81? StrengthMovementVariant81 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant81))]
#endif
        public bool IsStrengthMovementVariant81 => StrengthMovementVariant81 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant81(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant81? value)
        {
            value = StrengthMovementVariant81;
            return IsStrengthMovementVariant81;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant81 PickStrengthMovementVariant81() => IsStrengthMovementVariant81
            ? StrengthMovementVariant81!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant81' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant82? StrengthMovementVariant82 { get; init; }
#else
        public global::Terra.StrengthMovementVariant82? StrengthMovementVariant82 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant82))]
#endif
        public bool IsStrengthMovementVariant82 => StrengthMovementVariant82 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant82(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant82? value)
        {
            value = StrengthMovementVariant82;
            return IsStrengthMovementVariant82;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant82 PickStrengthMovementVariant82() => IsStrengthMovementVariant82
            ? StrengthMovementVariant82!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant82' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant83? StrengthMovementVariant83 { get; init; }
#else
        public global::Terra.StrengthMovementVariant83? StrengthMovementVariant83 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant83))]
#endif
        public bool IsStrengthMovementVariant83 => StrengthMovementVariant83 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant83(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant83? value)
        {
            value = StrengthMovementVariant83;
            return IsStrengthMovementVariant83;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant83 PickStrengthMovementVariant83() => IsStrengthMovementVariant83
            ? StrengthMovementVariant83!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant83' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant84? StrengthMovementVariant84 { get; init; }
#else
        public global::Terra.StrengthMovementVariant84? StrengthMovementVariant84 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant84))]
#endif
        public bool IsStrengthMovementVariant84 => StrengthMovementVariant84 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant84(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant84? value)
        {
            value = StrengthMovementVariant84;
            return IsStrengthMovementVariant84;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant84 PickStrengthMovementVariant84() => IsStrengthMovementVariant84
            ? StrengthMovementVariant84!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant84' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant85? StrengthMovementVariant85 { get; init; }
#else
        public global::Terra.StrengthMovementVariant85? StrengthMovementVariant85 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant85))]
#endif
        public bool IsStrengthMovementVariant85 => StrengthMovementVariant85 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant85(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant85? value)
        {
            value = StrengthMovementVariant85;
            return IsStrengthMovementVariant85;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant85 PickStrengthMovementVariant85() => IsStrengthMovementVariant85
            ? StrengthMovementVariant85!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant85' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant86? StrengthMovementVariant86 { get; init; }
#else
        public global::Terra.StrengthMovementVariant86? StrengthMovementVariant86 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant86))]
#endif
        public bool IsStrengthMovementVariant86 => StrengthMovementVariant86 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant86(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant86? value)
        {
            value = StrengthMovementVariant86;
            return IsStrengthMovementVariant86;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant86 PickStrengthMovementVariant86() => IsStrengthMovementVariant86
            ? StrengthMovementVariant86!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant86' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant87? StrengthMovementVariant87 { get; init; }
#else
        public global::Terra.StrengthMovementVariant87? StrengthMovementVariant87 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant87))]
#endif
        public bool IsStrengthMovementVariant87 => StrengthMovementVariant87 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant87(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant87? value)
        {
            value = StrengthMovementVariant87;
            return IsStrengthMovementVariant87;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant87 PickStrengthMovementVariant87() => IsStrengthMovementVariant87
            ? StrengthMovementVariant87!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant87' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant88? StrengthMovementVariant88 { get; init; }
#else
        public global::Terra.StrengthMovementVariant88? StrengthMovementVariant88 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant88))]
#endif
        public bool IsStrengthMovementVariant88 => StrengthMovementVariant88 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant88(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant88? value)
        {
            value = StrengthMovementVariant88;
            return IsStrengthMovementVariant88;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant88 PickStrengthMovementVariant88() => IsStrengthMovementVariant88
            ? StrengthMovementVariant88!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant88' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant89? StrengthMovementVariant89 { get; init; }
#else
        public global::Terra.StrengthMovementVariant89? StrengthMovementVariant89 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant89))]
#endif
        public bool IsStrengthMovementVariant89 => StrengthMovementVariant89 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant89(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant89? value)
        {
            value = StrengthMovementVariant89;
            return IsStrengthMovementVariant89;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant89 PickStrengthMovementVariant89() => IsStrengthMovementVariant89
            ? StrengthMovementVariant89!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant89' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant90? StrengthMovementVariant90 { get; init; }
#else
        public global::Terra.StrengthMovementVariant90? StrengthMovementVariant90 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant90))]
#endif
        public bool IsStrengthMovementVariant90 => StrengthMovementVariant90 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant90(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant90? value)
        {
            value = StrengthMovementVariant90;
            return IsStrengthMovementVariant90;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant90 PickStrengthMovementVariant90() => IsStrengthMovementVariant90
            ? StrengthMovementVariant90!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant90' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant91? StrengthMovementVariant91 { get; init; }
#else
        public global::Terra.StrengthMovementVariant91? StrengthMovementVariant91 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant91))]
#endif
        public bool IsStrengthMovementVariant91 => StrengthMovementVariant91 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant91(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant91? value)
        {
            value = StrengthMovementVariant91;
            return IsStrengthMovementVariant91;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant91 PickStrengthMovementVariant91() => IsStrengthMovementVariant91
            ? StrengthMovementVariant91!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant91' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant92? StrengthMovementVariant92 { get; init; }
#else
        public global::Terra.StrengthMovementVariant92? StrengthMovementVariant92 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant92))]
#endif
        public bool IsStrengthMovementVariant92 => StrengthMovementVariant92 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant92(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant92? value)
        {
            value = StrengthMovementVariant92;
            return IsStrengthMovementVariant92;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant92 PickStrengthMovementVariant92() => IsStrengthMovementVariant92
            ? StrengthMovementVariant92!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant92' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant93? StrengthMovementVariant93 { get; init; }
#else
        public global::Terra.StrengthMovementVariant93? StrengthMovementVariant93 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant93))]
#endif
        public bool IsStrengthMovementVariant93 => StrengthMovementVariant93 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant93(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant93? value)
        {
            value = StrengthMovementVariant93;
            return IsStrengthMovementVariant93;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant93 PickStrengthMovementVariant93() => IsStrengthMovementVariant93
            ? StrengthMovementVariant93!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant93' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant94? StrengthMovementVariant94 { get; init; }
#else
        public global::Terra.StrengthMovementVariant94? StrengthMovementVariant94 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant94))]
#endif
        public bool IsStrengthMovementVariant94 => StrengthMovementVariant94 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant94(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant94? value)
        {
            value = StrengthMovementVariant94;
            return IsStrengthMovementVariant94;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant94 PickStrengthMovementVariant94() => IsStrengthMovementVariant94
            ? StrengthMovementVariant94!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant94' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant95? StrengthMovementVariant95 { get; init; }
#else
        public global::Terra.StrengthMovementVariant95? StrengthMovementVariant95 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant95))]
#endif
        public bool IsStrengthMovementVariant95 => StrengthMovementVariant95 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant95(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant95? value)
        {
            value = StrengthMovementVariant95;
            return IsStrengthMovementVariant95;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant95 PickStrengthMovementVariant95() => IsStrengthMovementVariant95
            ? StrengthMovementVariant95!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant95' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant96? StrengthMovementVariant96 { get; init; }
#else
        public global::Terra.StrengthMovementVariant96? StrengthMovementVariant96 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant96))]
#endif
        public bool IsStrengthMovementVariant96 => StrengthMovementVariant96 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant96(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant96? value)
        {
            value = StrengthMovementVariant96;
            return IsStrengthMovementVariant96;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant96 PickStrengthMovementVariant96() => IsStrengthMovementVariant96
            ? StrengthMovementVariant96!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant96' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant97? StrengthMovementVariant97 { get; init; }
#else
        public global::Terra.StrengthMovementVariant97? StrengthMovementVariant97 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant97))]
#endif
        public bool IsStrengthMovementVariant97 => StrengthMovementVariant97 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant97(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant97? value)
        {
            value = StrengthMovementVariant97;
            return IsStrengthMovementVariant97;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant97 PickStrengthMovementVariant97() => IsStrengthMovementVariant97
            ? StrengthMovementVariant97!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant97' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant98? StrengthMovementVariant98 { get; init; }
#else
        public global::Terra.StrengthMovementVariant98? StrengthMovementVariant98 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant98))]
#endif
        public bool IsStrengthMovementVariant98 => StrengthMovementVariant98 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant98(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant98? value)
        {
            value = StrengthMovementVariant98;
            return IsStrengthMovementVariant98;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant98 PickStrengthMovementVariant98() => IsStrengthMovementVariant98
            ? StrengthMovementVariant98!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant98' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant99? StrengthMovementVariant99 { get; init; }
#else
        public global::Terra.StrengthMovementVariant99? StrengthMovementVariant99 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant99))]
#endif
        public bool IsStrengthMovementVariant99 => StrengthMovementVariant99 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant99(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant99? value)
        {
            value = StrengthMovementVariant99;
            return IsStrengthMovementVariant99;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant99 PickStrengthMovementVariant99() => IsStrengthMovementVariant99
            ? StrengthMovementVariant99!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant99' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant100? StrengthMovementVariant100 { get; init; }
#else
        public global::Terra.StrengthMovementVariant100? StrengthMovementVariant100 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant100))]
#endif
        public bool IsStrengthMovementVariant100 => StrengthMovementVariant100 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant100(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant100? value)
        {
            value = StrengthMovementVariant100;
            return IsStrengthMovementVariant100;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant100 PickStrengthMovementVariant100() => IsStrengthMovementVariant100
            ? StrengthMovementVariant100!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant100' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant101? StrengthMovementVariant101 { get; init; }
#else
        public global::Terra.StrengthMovementVariant101? StrengthMovementVariant101 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant101))]
#endif
        public bool IsStrengthMovementVariant101 => StrengthMovementVariant101 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant101(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant101? value)
        {
            value = StrengthMovementVariant101;
            return IsStrengthMovementVariant101;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant101 PickStrengthMovementVariant101() => IsStrengthMovementVariant101
            ? StrengthMovementVariant101!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant101' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant102? StrengthMovementVariant102 { get; init; }
#else
        public global::Terra.StrengthMovementVariant102? StrengthMovementVariant102 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant102))]
#endif
        public bool IsStrengthMovementVariant102 => StrengthMovementVariant102 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant102(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant102? value)
        {
            value = StrengthMovementVariant102;
            return IsStrengthMovementVariant102;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant102 PickStrengthMovementVariant102() => IsStrengthMovementVariant102
            ? StrengthMovementVariant102!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant102' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant103? StrengthMovementVariant103 { get; init; }
#else
        public global::Terra.StrengthMovementVariant103? StrengthMovementVariant103 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant103))]
#endif
        public bool IsStrengthMovementVariant103 => StrengthMovementVariant103 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant103(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant103? value)
        {
            value = StrengthMovementVariant103;
            return IsStrengthMovementVariant103;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant103 PickStrengthMovementVariant103() => IsStrengthMovementVariant103
            ? StrengthMovementVariant103!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant103' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant104? StrengthMovementVariant104 { get; init; }
#else
        public global::Terra.StrengthMovementVariant104? StrengthMovementVariant104 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant104))]
#endif
        public bool IsStrengthMovementVariant104 => StrengthMovementVariant104 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant104(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant104? value)
        {
            value = StrengthMovementVariant104;
            return IsStrengthMovementVariant104;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant104 PickStrengthMovementVariant104() => IsStrengthMovementVariant104
            ? StrengthMovementVariant104!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant104' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant105? StrengthMovementVariant105 { get; init; }
#else
        public global::Terra.StrengthMovementVariant105? StrengthMovementVariant105 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant105))]
#endif
        public bool IsStrengthMovementVariant105 => StrengthMovementVariant105 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant105(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant105? value)
        {
            value = StrengthMovementVariant105;
            return IsStrengthMovementVariant105;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant105 PickStrengthMovementVariant105() => IsStrengthMovementVariant105
            ? StrengthMovementVariant105!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant105' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant106? StrengthMovementVariant106 { get; init; }
#else
        public global::Terra.StrengthMovementVariant106? StrengthMovementVariant106 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant106))]
#endif
        public bool IsStrengthMovementVariant106 => StrengthMovementVariant106 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant106(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant106? value)
        {
            value = StrengthMovementVariant106;
            return IsStrengthMovementVariant106;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant106 PickStrengthMovementVariant106() => IsStrengthMovementVariant106
            ? StrengthMovementVariant106!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant106' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant107? StrengthMovementVariant107 { get; init; }
#else
        public global::Terra.StrengthMovementVariant107? StrengthMovementVariant107 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant107))]
#endif
        public bool IsStrengthMovementVariant107 => StrengthMovementVariant107 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant107(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant107? value)
        {
            value = StrengthMovementVariant107;
            return IsStrengthMovementVariant107;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant107 PickStrengthMovementVariant107() => IsStrengthMovementVariant107
            ? StrengthMovementVariant107!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant107' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant108? StrengthMovementVariant108 { get; init; }
#else
        public global::Terra.StrengthMovementVariant108? StrengthMovementVariant108 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant108))]
#endif
        public bool IsStrengthMovementVariant108 => StrengthMovementVariant108 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant108(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant108? value)
        {
            value = StrengthMovementVariant108;
            return IsStrengthMovementVariant108;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant108 PickStrengthMovementVariant108() => IsStrengthMovementVariant108
            ? StrengthMovementVariant108!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant108' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant109? StrengthMovementVariant109 { get; init; }
#else
        public global::Terra.StrengthMovementVariant109? StrengthMovementVariant109 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant109))]
#endif
        public bool IsStrengthMovementVariant109 => StrengthMovementVariant109 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant109(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant109? value)
        {
            value = StrengthMovementVariant109;
            return IsStrengthMovementVariant109;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant109 PickStrengthMovementVariant109() => IsStrengthMovementVariant109
            ? StrengthMovementVariant109!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant109' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant110? StrengthMovementVariant110 { get; init; }
#else
        public global::Terra.StrengthMovementVariant110? StrengthMovementVariant110 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant110))]
#endif
        public bool IsStrengthMovementVariant110 => StrengthMovementVariant110 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant110(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant110? value)
        {
            value = StrengthMovementVariant110;
            return IsStrengthMovementVariant110;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant110 PickStrengthMovementVariant110() => IsStrengthMovementVariant110
            ? StrengthMovementVariant110!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant110' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant111? StrengthMovementVariant111 { get; init; }
#else
        public global::Terra.StrengthMovementVariant111? StrengthMovementVariant111 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant111))]
#endif
        public bool IsStrengthMovementVariant111 => StrengthMovementVariant111 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant111(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant111? value)
        {
            value = StrengthMovementVariant111;
            return IsStrengthMovementVariant111;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant111 PickStrengthMovementVariant111() => IsStrengthMovementVariant111
            ? StrengthMovementVariant111!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant111' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant112? StrengthMovementVariant112 { get; init; }
#else
        public global::Terra.StrengthMovementVariant112? StrengthMovementVariant112 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant112))]
#endif
        public bool IsStrengthMovementVariant112 => StrengthMovementVariant112 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant112(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant112? value)
        {
            value = StrengthMovementVariant112;
            return IsStrengthMovementVariant112;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant112 PickStrengthMovementVariant112() => IsStrengthMovementVariant112
            ? StrengthMovementVariant112!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant112' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant113? StrengthMovementVariant113 { get; init; }
#else
        public global::Terra.StrengthMovementVariant113? StrengthMovementVariant113 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant113))]
#endif
        public bool IsStrengthMovementVariant113 => StrengthMovementVariant113 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant113(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant113? value)
        {
            value = StrengthMovementVariant113;
            return IsStrengthMovementVariant113;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant113 PickStrengthMovementVariant113() => IsStrengthMovementVariant113
            ? StrengthMovementVariant113!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant113' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant114? StrengthMovementVariant114 { get; init; }
#else
        public global::Terra.StrengthMovementVariant114? StrengthMovementVariant114 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant114))]
#endif
        public bool IsStrengthMovementVariant114 => StrengthMovementVariant114 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant114(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant114? value)
        {
            value = StrengthMovementVariant114;
            return IsStrengthMovementVariant114;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant114 PickStrengthMovementVariant114() => IsStrengthMovementVariant114
            ? StrengthMovementVariant114!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant114' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant115? StrengthMovementVariant115 { get; init; }
#else
        public global::Terra.StrengthMovementVariant115? StrengthMovementVariant115 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant115))]
#endif
        public bool IsStrengthMovementVariant115 => StrengthMovementVariant115 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant115(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant115? value)
        {
            value = StrengthMovementVariant115;
            return IsStrengthMovementVariant115;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant115 PickStrengthMovementVariant115() => IsStrengthMovementVariant115
            ? StrengthMovementVariant115!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant115' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant116? StrengthMovementVariant116 { get; init; }
#else
        public global::Terra.StrengthMovementVariant116? StrengthMovementVariant116 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant116))]
#endif
        public bool IsStrengthMovementVariant116 => StrengthMovementVariant116 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant116(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant116? value)
        {
            value = StrengthMovementVariant116;
            return IsStrengthMovementVariant116;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant116 PickStrengthMovementVariant116() => IsStrengthMovementVariant116
            ? StrengthMovementVariant116!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant116' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant117? StrengthMovementVariant117 { get; init; }
#else
        public global::Terra.StrengthMovementVariant117? StrengthMovementVariant117 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant117))]
#endif
        public bool IsStrengthMovementVariant117 => StrengthMovementVariant117 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant117(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant117? value)
        {
            value = StrengthMovementVariant117;
            return IsStrengthMovementVariant117;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant117 PickStrengthMovementVariant117() => IsStrengthMovementVariant117
            ? StrengthMovementVariant117!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant117' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant118? StrengthMovementVariant118 { get; init; }
#else
        public global::Terra.StrengthMovementVariant118? StrengthMovementVariant118 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant118))]
#endif
        public bool IsStrengthMovementVariant118 => StrengthMovementVariant118 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant118(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant118? value)
        {
            value = StrengthMovementVariant118;
            return IsStrengthMovementVariant118;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant118 PickStrengthMovementVariant118() => IsStrengthMovementVariant118
            ? StrengthMovementVariant118!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant118' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant119? StrengthMovementVariant119 { get; init; }
#else
        public global::Terra.StrengthMovementVariant119? StrengthMovementVariant119 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant119))]
#endif
        public bool IsStrengthMovementVariant119 => StrengthMovementVariant119 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant119(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant119? value)
        {
            value = StrengthMovementVariant119;
            return IsStrengthMovementVariant119;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant119 PickStrengthMovementVariant119() => IsStrengthMovementVariant119
            ? StrengthMovementVariant119!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant119' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant120? StrengthMovementVariant120 { get; init; }
#else
        public global::Terra.StrengthMovementVariant120? StrengthMovementVariant120 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant120))]
#endif
        public bool IsStrengthMovementVariant120 => StrengthMovementVariant120 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant120(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant120? value)
        {
            value = StrengthMovementVariant120;
            return IsStrengthMovementVariant120;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant120 PickStrengthMovementVariant120() => IsStrengthMovementVariant120
            ? StrengthMovementVariant120!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant120' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant121? StrengthMovementVariant121 { get; init; }
#else
        public global::Terra.StrengthMovementVariant121? StrengthMovementVariant121 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant121))]
#endif
        public bool IsStrengthMovementVariant121 => StrengthMovementVariant121 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant121(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant121? value)
        {
            value = StrengthMovementVariant121;
            return IsStrengthMovementVariant121;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant121 PickStrengthMovementVariant121() => IsStrengthMovementVariant121
            ? StrengthMovementVariant121!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant121' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant122? StrengthMovementVariant122 { get; init; }
#else
        public global::Terra.StrengthMovementVariant122? StrengthMovementVariant122 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant122))]
#endif
        public bool IsStrengthMovementVariant122 => StrengthMovementVariant122 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant122(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant122? value)
        {
            value = StrengthMovementVariant122;
            return IsStrengthMovementVariant122;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant122 PickStrengthMovementVariant122() => IsStrengthMovementVariant122
            ? StrengthMovementVariant122!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant122' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant123? StrengthMovementVariant123 { get; init; }
#else
        public global::Terra.StrengthMovementVariant123? StrengthMovementVariant123 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant123))]
#endif
        public bool IsStrengthMovementVariant123 => StrengthMovementVariant123 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant123(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant123? value)
        {
            value = StrengthMovementVariant123;
            return IsStrengthMovementVariant123;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant123 PickStrengthMovementVariant123() => IsStrengthMovementVariant123
            ? StrengthMovementVariant123!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant123' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant124? StrengthMovementVariant124 { get; init; }
#else
        public global::Terra.StrengthMovementVariant124? StrengthMovementVariant124 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant124))]
#endif
        public bool IsStrengthMovementVariant124 => StrengthMovementVariant124 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant124(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant124? value)
        {
            value = StrengthMovementVariant124;
            return IsStrengthMovementVariant124;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant124 PickStrengthMovementVariant124() => IsStrengthMovementVariant124
            ? StrengthMovementVariant124!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant124' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant125? StrengthMovementVariant125 { get; init; }
#else
        public global::Terra.StrengthMovementVariant125? StrengthMovementVariant125 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant125))]
#endif
        public bool IsStrengthMovementVariant125 => StrengthMovementVariant125 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant125(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant125? value)
        {
            value = StrengthMovementVariant125;
            return IsStrengthMovementVariant125;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant125 PickStrengthMovementVariant125() => IsStrengthMovementVariant125
            ? StrengthMovementVariant125!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant125' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant126? StrengthMovementVariant126 { get; init; }
#else
        public global::Terra.StrengthMovementVariant126? StrengthMovementVariant126 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant126))]
#endif
        public bool IsStrengthMovementVariant126 => StrengthMovementVariant126 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant126(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant126? value)
        {
            value = StrengthMovementVariant126;
            return IsStrengthMovementVariant126;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant126 PickStrengthMovementVariant126() => IsStrengthMovementVariant126
            ? StrengthMovementVariant126!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant126' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant127? StrengthMovementVariant127 { get; init; }
#else
        public global::Terra.StrengthMovementVariant127? StrengthMovementVariant127 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant127))]
#endif
        public bool IsStrengthMovementVariant127 => StrengthMovementVariant127 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant127(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant127? value)
        {
            value = StrengthMovementVariant127;
            return IsStrengthMovementVariant127;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant127 PickStrengthMovementVariant127() => IsStrengthMovementVariant127
            ? StrengthMovementVariant127!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant127' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant128? StrengthMovementVariant128 { get; init; }
#else
        public global::Terra.StrengthMovementVariant128? StrengthMovementVariant128 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant128))]
#endif
        public bool IsStrengthMovementVariant128 => StrengthMovementVariant128 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant128(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant128? value)
        {
            value = StrengthMovementVariant128;
            return IsStrengthMovementVariant128;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant128 PickStrengthMovementVariant128() => IsStrengthMovementVariant128
            ? StrengthMovementVariant128!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant128' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant129? StrengthMovementVariant129 { get; init; }
#else
        public global::Terra.StrengthMovementVariant129? StrengthMovementVariant129 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant129))]
#endif
        public bool IsStrengthMovementVariant129 => StrengthMovementVariant129 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant129(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant129? value)
        {
            value = StrengthMovementVariant129;
            return IsStrengthMovementVariant129;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant129 PickStrengthMovementVariant129() => IsStrengthMovementVariant129
            ? StrengthMovementVariant129!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant129' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant130? StrengthMovementVariant130 { get; init; }
#else
        public global::Terra.StrengthMovementVariant130? StrengthMovementVariant130 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant130))]
#endif
        public bool IsStrengthMovementVariant130 => StrengthMovementVariant130 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant130(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant130? value)
        {
            value = StrengthMovementVariant130;
            return IsStrengthMovementVariant130;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant130 PickStrengthMovementVariant130() => IsStrengthMovementVariant130
            ? StrengthMovementVariant130!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant130' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant131? StrengthMovementVariant131 { get; init; }
#else
        public global::Terra.StrengthMovementVariant131? StrengthMovementVariant131 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant131))]
#endif
        public bool IsStrengthMovementVariant131 => StrengthMovementVariant131 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant131(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant131? value)
        {
            value = StrengthMovementVariant131;
            return IsStrengthMovementVariant131;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant131 PickStrengthMovementVariant131() => IsStrengthMovementVariant131
            ? StrengthMovementVariant131!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant131' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant132? StrengthMovementVariant132 { get; init; }
#else
        public global::Terra.StrengthMovementVariant132? StrengthMovementVariant132 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant132))]
#endif
        public bool IsStrengthMovementVariant132 => StrengthMovementVariant132 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant132(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant132? value)
        {
            value = StrengthMovementVariant132;
            return IsStrengthMovementVariant132;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant132 PickStrengthMovementVariant132() => IsStrengthMovementVariant132
            ? StrengthMovementVariant132!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant132' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant133? StrengthMovementVariant133 { get; init; }
#else
        public global::Terra.StrengthMovementVariant133? StrengthMovementVariant133 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant133))]
#endif
        public bool IsStrengthMovementVariant133 => StrengthMovementVariant133 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant133(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant133? value)
        {
            value = StrengthMovementVariant133;
            return IsStrengthMovementVariant133;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant133 PickStrengthMovementVariant133() => IsStrengthMovementVariant133
            ? StrengthMovementVariant133!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant133' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant134? StrengthMovementVariant134 { get; init; }
#else
        public global::Terra.StrengthMovementVariant134? StrengthMovementVariant134 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant134))]
#endif
        public bool IsStrengthMovementVariant134 => StrengthMovementVariant134 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant134(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant134? value)
        {
            value = StrengthMovementVariant134;
            return IsStrengthMovementVariant134;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant134 PickStrengthMovementVariant134() => IsStrengthMovementVariant134
            ? StrengthMovementVariant134!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant134' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant135? StrengthMovementVariant135 { get; init; }
#else
        public global::Terra.StrengthMovementVariant135? StrengthMovementVariant135 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant135))]
#endif
        public bool IsStrengthMovementVariant135 => StrengthMovementVariant135 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant135(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant135? value)
        {
            value = StrengthMovementVariant135;
            return IsStrengthMovementVariant135;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant135 PickStrengthMovementVariant135() => IsStrengthMovementVariant135
            ? StrengthMovementVariant135!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant135' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant136? StrengthMovementVariant136 { get; init; }
#else
        public global::Terra.StrengthMovementVariant136? StrengthMovementVariant136 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant136))]
#endif
        public bool IsStrengthMovementVariant136 => StrengthMovementVariant136 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant136(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant136? value)
        {
            value = StrengthMovementVariant136;
            return IsStrengthMovementVariant136;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant136 PickStrengthMovementVariant136() => IsStrengthMovementVariant136
            ? StrengthMovementVariant136!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant136' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant137? StrengthMovementVariant137 { get; init; }
#else
        public global::Terra.StrengthMovementVariant137? StrengthMovementVariant137 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant137))]
#endif
        public bool IsStrengthMovementVariant137 => StrengthMovementVariant137 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant137(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant137? value)
        {
            value = StrengthMovementVariant137;
            return IsStrengthMovementVariant137;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant137 PickStrengthMovementVariant137() => IsStrengthMovementVariant137
            ? StrengthMovementVariant137!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant137' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant138? StrengthMovementVariant138 { get; init; }
#else
        public global::Terra.StrengthMovementVariant138? StrengthMovementVariant138 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant138))]
#endif
        public bool IsStrengthMovementVariant138 => StrengthMovementVariant138 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant138(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant138? value)
        {
            value = StrengthMovementVariant138;
            return IsStrengthMovementVariant138;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant138 PickStrengthMovementVariant138() => IsStrengthMovementVariant138
            ? StrengthMovementVariant138!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant138' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant139? StrengthMovementVariant139 { get; init; }
#else
        public global::Terra.StrengthMovementVariant139? StrengthMovementVariant139 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant139))]
#endif
        public bool IsStrengthMovementVariant139 => StrengthMovementVariant139 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant139(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant139? value)
        {
            value = StrengthMovementVariant139;
            return IsStrengthMovementVariant139;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant139 PickStrengthMovementVariant139() => IsStrengthMovementVariant139
            ? StrengthMovementVariant139!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant139' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant140? StrengthMovementVariant140 { get; init; }
#else
        public global::Terra.StrengthMovementVariant140? StrengthMovementVariant140 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant140))]
#endif
        public bool IsStrengthMovementVariant140 => StrengthMovementVariant140 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant140(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant140? value)
        {
            value = StrengthMovementVariant140;
            return IsStrengthMovementVariant140;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant140 PickStrengthMovementVariant140() => IsStrengthMovementVariant140
            ? StrengthMovementVariant140!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant140' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant141? StrengthMovementVariant141 { get; init; }
#else
        public global::Terra.StrengthMovementVariant141? StrengthMovementVariant141 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant141))]
#endif
        public bool IsStrengthMovementVariant141 => StrengthMovementVariant141 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant141(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant141? value)
        {
            value = StrengthMovementVariant141;
            return IsStrengthMovementVariant141;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant141 PickStrengthMovementVariant141() => IsStrengthMovementVariant141
            ? StrengthMovementVariant141!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant141' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant142? StrengthMovementVariant142 { get; init; }
#else
        public global::Terra.StrengthMovementVariant142? StrengthMovementVariant142 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant142))]
#endif
        public bool IsStrengthMovementVariant142 => StrengthMovementVariant142 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant142(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant142? value)
        {
            value = StrengthMovementVariant142;
            return IsStrengthMovementVariant142;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant142 PickStrengthMovementVariant142() => IsStrengthMovementVariant142
            ? StrengthMovementVariant142!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant142' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant143? StrengthMovementVariant143 { get; init; }
#else
        public global::Terra.StrengthMovementVariant143? StrengthMovementVariant143 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant143))]
#endif
        public bool IsStrengthMovementVariant143 => StrengthMovementVariant143 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant143(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant143? value)
        {
            value = StrengthMovementVariant143;
            return IsStrengthMovementVariant143;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant143 PickStrengthMovementVariant143() => IsStrengthMovementVariant143
            ? StrengthMovementVariant143!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant143' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant144? StrengthMovementVariant144 { get; init; }
#else
        public global::Terra.StrengthMovementVariant144? StrengthMovementVariant144 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant144))]
#endif
        public bool IsStrengthMovementVariant144 => StrengthMovementVariant144 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant144(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant144? value)
        {
            value = StrengthMovementVariant144;
            return IsStrengthMovementVariant144;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant144 PickStrengthMovementVariant144() => IsStrengthMovementVariant144
            ? StrengthMovementVariant144!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant144' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant145? StrengthMovementVariant145 { get; init; }
#else
        public global::Terra.StrengthMovementVariant145? StrengthMovementVariant145 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant145))]
#endif
        public bool IsStrengthMovementVariant145 => StrengthMovementVariant145 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant145(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant145? value)
        {
            value = StrengthMovementVariant145;
            return IsStrengthMovementVariant145;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant145 PickStrengthMovementVariant145() => IsStrengthMovementVariant145
            ? StrengthMovementVariant145!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant145' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant146? StrengthMovementVariant146 { get; init; }
#else
        public global::Terra.StrengthMovementVariant146? StrengthMovementVariant146 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant146))]
#endif
        public bool IsStrengthMovementVariant146 => StrengthMovementVariant146 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant146(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant146? value)
        {
            value = StrengthMovementVariant146;
            return IsStrengthMovementVariant146;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant146 PickStrengthMovementVariant146() => IsStrengthMovementVariant146
            ? StrengthMovementVariant146!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant146' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant147? StrengthMovementVariant147 { get; init; }
#else
        public global::Terra.StrengthMovementVariant147? StrengthMovementVariant147 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant147))]
#endif
        public bool IsStrengthMovementVariant147 => StrengthMovementVariant147 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant147(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant147? value)
        {
            value = StrengthMovementVariant147;
            return IsStrengthMovementVariant147;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant147 PickStrengthMovementVariant147() => IsStrengthMovementVariant147
            ? StrengthMovementVariant147!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant147' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant148? StrengthMovementVariant148 { get; init; }
#else
        public global::Terra.StrengthMovementVariant148? StrengthMovementVariant148 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant148))]
#endif
        public bool IsStrengthMovementVariant148 => StrengthMovementVariant148 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant148(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant148? value)
        {
            value = StrengthMovementVariant148;
            return IsStrengthMovementVariant148;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant148 PickStrengthMovementVariant148() => IsStrengthMovementVariant148
            ? StrengthMovementVariant148!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant148' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant149? StrengthMovementVariant149 { get; init; }
#else
        public global::Terra.StrengthMovementVariant149? StrengthMovementVariant149 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant149))]
#endif
        public bool IsStrengthMovementVariant149 => StrengthMovementVariant149 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant149(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant149? value)
        {
            value = StrengthMovementVariant149;
            return IsStrengthMovementVariant149;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant149 PickStrengthMovementVariant149() => IsStrengthMovementVariant149
            ? StrengthMovementVariant149!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant149' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant150? StrengthMovementVariant150 { get; init; }
#else
        public global::Terra.StrengthMovementVariant150? StrengthMovementVariant150 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant150))]
#endif
        public bool IsStrengthMovementVariant150 => StrengthMovementVariant150 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant150(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant150? value)
        {
            value = StrengthMovementVariant150;
            return IsStrengthMovementVariant150;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant150 PickStrengthMovementVariant150() => IsStrengthMovementVariant150
            ? StrengthMovementVariant150!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant150' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant151? StrengthMovementVariant151 { get; init; }
#else
        public global::Terra.StrengthMovementVariant151? StrengthMovementVariant151 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant151))]
#endif
        public bool IsStrengthMovementVariant151 => StrengthMovementVariant151 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant151(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant151? value)
        {
            value = StrengthMovementVariant151;
            return IsStrengthMovementVariant151;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant151 PickStrengthMovementVariant151() => IsStrengthMovementVariant151
            ? StrengthMovementVariant151!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant151' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant152? StrengthMovementVariant152 { get; init; }
#else
        public global::Terra.StrengthMovementVariant152? StrengthMovementVariant152 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant152))]
#endif
        public bool IsStrengthMovementVariant152 => StrengthMovementVariant152 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant152(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant152? value)
        {
            value = StrengthMovementVariant152;
            return IsStrengthMovementVariant152;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant152 PickStrengthMovementVariant152() => IsStrengthMovementVariant152
            ? StrengthMovementVariant152!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant152' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant153? StrengthMovementVariant153 { get; init; }
#else
        public global::Terra.StrengthMovementVariant153? StrengthMovementVariant153 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant153))]
#endif
        public bool IsStrengthMovementVariant153 => StrengthMovementVariant153 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant153(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant153? value)
        {
            value = StrengthMovementVariant153;
            return IsStrengthMovementVariant153;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant153 PickStrengthMovementVariant153() => IsStrengthMovementVariant153
            ? StrengthMovementVariant153!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant153' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant154? StrengthMovementVariant154 { get; init; }
#else
        public global::Terra.StrengthMovementVariant154? StrengthMovementVariant154 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant154))]
#endif
        public bool IsStrengthMovementVariant154 => StrengthMovementVariant154 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant154(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant154? value)
        {
            value = StrengthMovementVariant154;
            return IsStrengthMovementVariant154;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant154 PickStrengthMovementVariant154() => IsStrengthMovementVariant154
            ? StrengthMovementVariant154!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant154' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant155? StrengthMovementVariant155 { get; init; }
#else
        public global::Terra.StrengthMovementVariant155? StrengthMovementVariant155 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant155))]
#endif
        public bool IsStrengthMovementVariant155 => StrengthMovementVariant155 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant155(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant155? value)
        {
            value = StrengthMovementVariant155;
            return IsStrengthMovementVariant155;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant155 PickStrengthMovementVariant155() => IsStrengthMovementVariant155
            ? StrengthMovementVariant155!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant155' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant156? StrengthMovementVariant156 { get; init; }
#else
        public global::Terra.StrengthMovementVariant156? StrengthMovementVariant156 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant156))]
#endif
        public bool IsStrengthMovementVariant156 => StrengthMovementVariant156 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant156(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant156? value)
        {
            value = StrengthMovementVariant156;
            return IsStrengthMovementVariant156;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant156 PickStrengthMovementVariant156() => IsStrengthMovementVariant156
            ? StrengthMovementVariant156!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant156' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant157? StrengthMovementVariant157 { get; init; }
#else
        public global::Terra.StrengthMovementVariant157? StrengthMovementVariant157 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant157))]
#endif
        public bool IsStrengthMovementVariant157 => StrengthMovementVariant157 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant157(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant157? value)
        {
            value = StrengthMovementVariant157;
            return IsStrengthMovementVariant157;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant157 PickStrengthMovementVariant157() => IsStrengthMovementVariant157
            ? StrengthMovementVariant157!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant157' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant158? StrengthMovementVariant158 { get; init; }
#else
        public global::Terra.StrengthMovementVariant158? StrengthMovementVariant158 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant158))]
#endif
        public bool IsStrengthMovementVariant158 => StrengthMovementVariant158 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant158(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant158? value)
        {
            value = StrengthMovementVariant158;
            return IsStrengthMovementVariant158;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant158 PickStrengthMovementVariant158() => IsStrengthMovementVariant158
            ? StrengthMovementVariant158!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant158' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant159? StrengthMovementVariant159 { get; init; }
#else
        public global::Terra.StrengthMovementVariant159? StrengthMovementVariant159 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant159))]
#endif
        public bool IsStrengthMovementVariant159 => StrengthMovementVariant159 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant159(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant159? value)
        {
            value = StrengthMovementVariant159;
            return IsStrengthMovementVariant159;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant159 PickStrengthMovementVariant159() => IsStrengthMovementVariant159
            ? StrengthMovementVariant159!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant159' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant160? StrengthMovementVariant160 { get; init; }
#else
        public global::Terra.StrengthMovementVariant160? StrengthMovementVariant160 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant160))]
#endif
        public bool IsStrengthMovementVariant160 => StrengthMovementVariant160 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant160(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant160? value)
        {
            value = StrengthMovementVariant160;
            return IsStrengthMovementVariant160;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant160 PickStrengthMovementVariant160() => IsStrengthMovementVariant160
            ? StrengthMovementVariant160!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant160' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant161? StrengthMovementVariant161 { get; init; }
#else
        public global::Terra.StrengthMovementVariant161? StrengthMovementVariant161 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant161))]
#endif
        public bool IsStrengthMovementVariant161 => StrengthMovementVariant161 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant161(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant161? value)
        {
            value = StrengthMovementVariant161;
            return IsStrengthMovementVariant161;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant161 PickStrengthMovementVariant161() => IsStrengthMovementVariant161
            ? StrengthMovementVariant161!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant161' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant162? StrengthMovementVariant162 { get; init; }
#else
        public global::Terra.StrengthMovementVariant162? StrengthMovementVariant162 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant162))]
#endif
        public bool IsStrengthMovementVariant162 => StrengthMovementVariant162 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant162(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant162? value)
        {
            value = StrengthMovementVariant162;
            return IsStrengthMovementVariant162;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant162 PickStrengthMovementVariant162() => IsStrengthMovementVariant162
            ? StrengthMovementVariant162!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant162' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant163? StrengthMovementVariant163 { get; init; }
#else
        public global::Terra.StrengthMovementVariant163? StrengthMovementVariant163 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant163))]
#endif
        public bool IsStrengthMovementVariant163 => StrengthMovementVariant163 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant163(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant163? value)
        {
            value = StrengthMovementVariant163;
            return IsStrengthMovementVariant163;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant163 PickStrengthMovementVariant163() => IsStrengthMovementVariant163
            ? StrengthMovementVariant163!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant163' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant164? StrengthMovementVariant164 { get; init; }
#else
        public global::Terra.StrengthMovementVariant164? StrengthMovementVariant164 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant164))]
#endif
        public bool IsStrengthMovementVariant164 => StrengthMovementVariant164 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant164(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant164? value)
        {
            value = StrengthMovementVariant164;
            return IsStrengthMovementVariant164;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant164 PickStrengthMovementVariant164() => IsStrengthMovementVariant164
            ? StrengthMovementVariant164!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant164' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant165? StrengthMovementVariant165 { get; init; }
#else
        public global::Terra.StrengthMovementVariant165? StrengthMovementVariant165 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant165))]
#endif
        public bool IsStrengthMovementVariant165 => StrengthMovementVariant165 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant165(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant165? value)
        {
            value = StrengthMovementVariant165;
            return IsStrengthMovementVariant165;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant165 PickStrengthMovementVariant165() => IsStrengthMovementVariant165
            ? StrengthMovementVariant165!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant165' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant166? StrengthMovementVariant166 { get; init; }
#else
        public global::Terra.StrengthMovementVariant166? StrengthMovementVariant166 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant166))]
#endif
        public bool IsStrengthMovementVariant166 => StrengthMovementVariant166 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant166(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant166? value)
        {
            value = StrengthMovementVariant166;
            return IsStrengthMovementVariant166;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant166 PickStrengthMovementVariant166() => IsStrengthMovementVariant166
            ? StrengthMovementVariant166!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant166' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant167? StrengthMovementVariant167 { get; init; }
#else
        public global::Terra.StrengthMovementVariant167? StrengthMovementVariant167 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant167))]
#endif
        public bool IsStrengthMovementVariant167 => StrengthMovementVariant167 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant167(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant167? value)
        {
            value = StrengthMovementVariant167;
            return IsStrengthMovementVariant167;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant167 PickStrengthMovementVariant167() => IsStrengthMovementVariant167
            ? StrengthMovementVariant167!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant167' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant168? StrengthMovementVariant168 { get; init; }
#else
        public global::Terra.StrengthMovementVariant168? StrengthMovementVariant168 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant168))]
#endif
        public bool IsStrengthMovementVariant168 => StrengthMovementVariant168 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant168(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant168? value)
        {
            value = StrengthMovementVariant168;
            return IsStrengthMovementVariant168;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant168 PickStrengthMovementVariant168() => IsStrengthMovementVariant168
            ? StrengthMovementVariant168!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant168' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant169? StrengthMovementVariant169 { get; init; }
#else
        public global::Terra.StrengthMovementVariant169? StrengthMovementVariant169 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant169))]
#endif
        public bool IsStrengthMovementVariant169 => StrengthMovementVariant169 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant169(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant169? value)
        {
            value = StrengthMovementVariant169;
            return IsStrengthMovementVariant169;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant169 PickStrengthMovementVariant169() => IsStrengthMovementVariant169
            ? StrengthMovementVariant169!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant169' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant170? StrengthMovementVariant170 { get; init; }
#else
        public global::Terra.StrengthMovementVariant170? StrengthMovementVariant170 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant170))]
#endif
        public bool IsStrengthMovementVariant170 => StrengthMovementVariant170 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant170(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant170? value)
        {
            value = StrengthMovementVariant170;
            return IsStrengthMovementVariant170;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant170 PickStrengthMovementVariant170() => IsStrengthMovementVariant170
            ? StrengthMovementVariant170!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant170' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant171? StrengthMovementVariant171 { get; init; }
#else
        public global::Terra.StrengthMovementVariant171? StrengthMovementVariant171 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant171))]
#endif
        public bool IsStrengthMovementVariant171 => StrengthMovementVariant171 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant171(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant171? value)
        {
            value = StrengthMovementVariant171;
            return IsStrengthMovementVariant171;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant171 PickStrengthMovementVariant171() => IsStrengthMovementVariant171
            ? StrengthMovementVariant171!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant171' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant172? StrengthMovementVariant172 { get; init; }
#else
        public global::Terra.StrengthMovementVariant172? StrengthMovementVariant172 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant172))]
#endif
        public bool IsStrengthMovementVariant172 => StrengthMovementVariant172 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant172(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant172? value)
        {
            value = StrengthMovementVariant172;
            return IsStrengthMovementVariant172;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant172 PickStrengthMovementVariant172() => IsStrengthMovementVariant172
            ? StrengthMovementVariant172!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant172' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant173? StrengthMovementVariant173 { get; init; }
#else
        public global::Terra.StrengthMovementVariant173? StrengthMovementVariant173 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant173))]
#endif
        public bool IsStrengthMovementVariant173 => StrengthMovementVariant173 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant173(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant173? value)
        {
            value = StrengthMovementVariant173;
            return IsStrengthMovementVariant173;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant173 PickStrengthMovementVariant173() => IsStrengthMovementVariant173
            ? StrengthMovementVariant173!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant173' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant174? StrengthMovementVariant174 { get; init; }
#else
        public global::Terra.StrengthMovementVariant174? StrengthMovementVariant174 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant174))]
#endif
        public bool IsStrengthMovementVariant174 => StrengthMovementVariant174 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant174(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant174? value)
        {
            value = StrengthMovementVariant174;
            return IsStrengthMovementVariant174;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant174 PickStrengthMovementVariant174() => IsStrengthMovementVariant174
            ? StrengthMovementVariant174!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant174' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMovementVariant175? StrengthMovementVariant175 { get; init; }
#else
        public global::Terra.StrengthMovementVariant175? StrengthMovementVariant175 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant175))]
#endif
        public bool IsStrengthMovementVariant175 => StrengthMovementVariant175 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant175(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMovementVariant175? value)
        {
            value = StrengthMovementVariant175;
            return IsStrengthMovementVariant175;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMovementVariant175 PickStrengthMovementVariant175() => IsStrengthMovementVariant175
            ? StrengthMovementVariant175!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant175' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthMovementVariant176 { get; init; }
#else
        public string? StrengthMovementVariant176 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMovementVariant176))]
#endif
        public bool IsStrengthMovementVariant176 => StrengthMovementVariant176 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMovementVariant176(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthMovementVariant176;
            return IsStrengthMovementVariant176;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthMovementVariant176() => IsStrengthMovementVariant176
            ? StrengthMovementVariant176!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMovementVariant176' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant1 value) => new StrengthMovement((global::Terra.StrengthMovementVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant1?(StrengthMovement @this) => @this.StrengthMovementVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant1? value)
        {
            StrengthMovementVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant1(global::Terra.StrengthMovementVariant1? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant2 value) => new StrengthMovement((global::Terra.StrengthMovementVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant2?(StrengthMovement @this) => @this.StrengthMovementVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant2? value)
        {
            StrengthMovementVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant2(global::Terra.StrengthMovementVariant2? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant3 value) => new StrengthMovement((global::Terra.StrengthMovementVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant3?(StrengthMovement @this) => @this.StrengthMovementVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant3? value)
        {
            StrengthMovementVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant3(global::Terra.StrengthMovementVariant3? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant4 value) => new StrengthMovement((global::Terra.StrengthMovementVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant4?(StrengthMovement @this) => @this.StrengthMovementVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant4? value)
        {
            StrengthMovementVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant4(global::Terra.StrengthMovementVariant4? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant5 value) => new StrengthMovement((global::Terra.StrengthMovementVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant5?(StrengthMovement @this) => @this.StrengthMovementVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant5? value)
        {
            StrengthMovementVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant5(global::Terra.StrengthMovementVariant5? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant6 value) => new StrengthMovement((global::Terra.StrengthMovementVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant6?(StrengthMovement @this) => @this.StrengthMovementVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant6? value)
        {
            StrengthMovementVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant6(global::Terra.StrengthMovementVariant6? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant7 value) => new StrengthMovement((global::Terra.StrengthMovementVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant7?(StrengthMovement @this) => @this.StrengthMovementVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant7? value)
        {
            StrengthMovementVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant7(global::Terra.StrengthMovementVariant7? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant8 value) => new StrengthMovement((global::Terra.StrengthMovementVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant8?(StrengthMovement @this) => @this.StrengthMovementVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant8? value)
        {
            StrengthMovementVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant8(global::Terra.StrengthMovementVariant8? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant9 value) => new StrengthMovement((global::Terra.StrengthMovementVariant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant9?(StrengthMovement @this) => @this.StrengthMovementVariant9;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant9? value)
        {
            StrengthMovementVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant9(global::Terra.StrengthMovementVariant9? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant10 value) => new StrengthMovement((global::Terra.StrengthMovementVariant10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant10?(StrengthMovement @this) => @this.StrengthMovementVariant10;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant10? value)
        {
            StrengthMovementVariant10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant10(global::Terra.StrengthMovementVariant10? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant11 value) => new StrengthMovement((global::Terra.StrengthMovementVariant11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant11?(StrengthMovement @this) => @this.StrengthMovementVariant11;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant11? value)
        {
            StrengthMovementVariant11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant11(global::Terra.StrengthMovementVariant11? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant12 value) => new StrengthMovement((global::Terra.StrengthMovementVariant12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant12?(StrengthMovement @this) => @this.StrengthMovementVariant12;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant12? value)
        {
            StrengthMovementVariant12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant12(global::Terra.StrengthMovementVariant12? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant13 value) => new StrengthMovement((global::Terra.StrengthMovementVariant13?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant13?(StrengthMovement @this) => @this.StrengthMovementVariant13;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant13? value)
        {
            StrengthMovementVariant13 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant13(global::Terra.StrengthMovementVariant13? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant14 value) => new StrengthMovement((global::Terra.StrengthMovementVariant14?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant14?(StrengthMovement @this) => @this.StrengthMovementVariant14;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant14? value)
        {
            StrengthMovementVariant14 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant14(global::Terra.StrengthMovementVariant14? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant15 value) => new StrengthMovement((global::Terra.StrengthMovementVariant15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant15?(StrengthMovement @this) => @this.StrengthMovementVariant15;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant15? value)
        {
            StrengthMovementVariant15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant15(global::Terra.StrengthMovementVariant15? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant16 value) => new StrengthMovement((global::Terra.StrengthMovementVariant16?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant16?(StrengthMovement @this) => @this.StrengthMovementVariant16;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant16? value)
        {
            StrengthMovementVariant16 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant16(global::Terra.StrengthMovementVariant16? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant17 value) => new StrengthMovement((global::Terra.StrengthMovementVariant17?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant17?(StrengthMovement @this) => @this.StrengthMovementVariant17;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant17? value)
        {
            StrengthMovementVariant17 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant17(global::Terra.StrengthMovementVariant17? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant18 value) => new StrengthMovement((global::Terra.StrengthMovementVariant18?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant18?(StrengthMovement @this) => @this.StrengthMovementVariant18;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant18? value)
        {
            StrengthMovementVariant18 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant18(global::Terra.StrengthMovementVariant18? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant19 value) => new StrengthMovement((global::Terra.StrengthMovementVariant19?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant19?(StrengthMovement @this) => @this.StrengthMovementVariant19;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant19? value)
        {
            StrengthMovementVariant19 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant19(global::Terra.StrengthMovementVariant19? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant20 value) => new StrengthMovement((global::Terra.StrengthMovementVariant20?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant20?(StrengthMovement @this) => @this.StrengthMovementVariant20;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant20? value)
        {
            StrengthMovementVariant20 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant20(global::Terra.StrengthMovementVariant20? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant21 value) => new StrengthMovement((global::Terra.StrengthMovementVariant21?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant21?(StrengthMovement @this) => @this.StrengthMovementVariant21;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant21? value)
        {
            StrengthMovementVariant21 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant21(global::Terra.StrengthMovementVariant21? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant22 value) => new StrengthMovement((global::Terra.StrengthMovementVariant22?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant22?(StrengthMovement @this) => @this.StrengthMovementVariant22;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant22? value)
        {
            StrengthMovementVariant22 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant22(global::Terra.StrengthMovementVariant22? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant23 value) => new StrengthMovement((global::Terra.StrengthMovementVariant23?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant23?(StrengthMovement @this) => @this.StrengthMovementVariant23;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant23? value)
        {
            StrengthMovementVariant23 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant23(global::Terra.StrengthMovementVariant23? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant24 value) => new StrengthMovement((global::Terra.StrengthMovementVariant24?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant24?(StrengthMovement @this) => @this.StrengthMovementVariant24;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant24? value)
        {
            StrengthMovementVariant24 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant24(global::Terra.StrengthMovementVariant24? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant25 value) => new StrengthMovement((global::Terra.StrengthMovementVariant25?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant25?(StrengthMovement @this) => @this.StrengthMovementVariant25;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant25? value)
        {
            StrengthMovementVariant25 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant25(global::Terra.StrengthMovementVariant25? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant26 value) => new StrengthMovement((global::Terra.StrengthMovementVariant26?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant26?(StrengthMovement @this) => @this.StrengthMovementVariant26;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant26? value)
        {
            StrengthMovementVariant26 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant26(global::Terra.StrengthMovementVariant26? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant27 value) => new StrengthMovement((global::Terra.StrengthMovementVariant27?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant27?(StrengthMovement @this) => @this.StrengthMovementVariant27;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant27? value)
        {
            StrengthMovementVariant27 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant27(global::Terra.StrengthMovementVariant27? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant28 value) => new StrengthMovement((global::Terra.StrengthMovementVariant28?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant28?(StrengthMovement @this) => @this.StrengthMovementVariant28;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant28? value)
        {
            StrengthMovementVariant28 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant28(global::Terra.StrengthMovementVariant28? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant29 value) => new StrengthMovement((global::Terra.StrengthMovementVariant29?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant29?(StrengthMovement @this) => @this.StrengthMovementVariant29;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant29? value)
        {
            StrengthMovementVariant29 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant29(global::Terra.StrengthMovementVariant29? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant30 value) => new StrengthMovement((global::Terra.StrengthMovementVariant30?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant30?(StrengthMovement @this) => @this.StrengthMovementVariant30;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant30? value)
        {
            StrengthMovementVariant30 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant30(global::Terra.StrengthMovementVariant30? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant31 value) => new StrengthMovement((global::Terra.StrengthMovementVariant31?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant31?(StrengthMovement @this) => @this.StrengthMovementVariant31;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant31? value)
        {
            StrengthMovementVariant31 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant31(global::Terra.StrengthMovementVariant31? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant32 value) => new StrengthMovement((global::Terra.StrengthMovementVariant32?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant32?(StrengthMovement @this) => @this.StrengthMovementVariant32;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant32? value)
        {
            StrengthMovementVariant32 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant32(global::Terra.StrengthMovementVariant32? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant33 value) => new StrengthMovement((global::Terra.StrengthMovementVariant33?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant33?(StrengthMovement @this) => @this.StrengthMovementVariant33;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant33? value)
        {
            StrengthMovementVariant33 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant33(global::Terra.StrengthMovementVariant33? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant34 value) => new StrengthMovement((global::Terra.StrengthMovementVariant34?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant34?(StrengthMovement @this) => @this.StrengthMovementVariant34;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant34? value)
        {
            StrengthMovementVariant34 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant34(global::Terra.StrengthMovementVariant34? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant35 value) => new StrengthMovement((global::Terra.StrengthMovementVariant35?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant35?(StrengthMovement @this) => @this.StrengthMovementVariant35;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant35? value)
        {
            StrengthMovementVariant35 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant35(global::Terra.StrengthMovementVariant35? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant36 value) => new StrengthMovement((global::Terra.StrengthMovementVariant36?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant36?(StrengthMovement @this) => @this.StrengthMovementVariant36;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant36? value)
        {
            StrengthMovementVariant36 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant36(global::Terra.StrengthMovementVariant36? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant37 value) => new StrengthMovement((global::Terra.StrengthMovementVariant37?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant37?(StrengthMovement @this) => @this.StrengthMovementVariant37;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant37? value)
        {
            StrengthMovementVariant37 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant37(global::Terra.StrengthMovementVariant37? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant38 value) => new StrengthMovement((global::Terra.StrengthMovementVariant38?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant38?(StrengthMovement @this) => @this.StrengthMovementVariant38;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant38? value)
        {
            StrengthMovementVariant38 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant38(global::Terra.StrengthMovementVariant38? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant39 value) => new StrengthMovement((global::Terra.StrengthMovementVariant39?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant39?(StrengthMovement @this) => @this.StrengthMovementVariant39;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant39? value)
        {
            StrengthMovementVariant39 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant39(global::Terra.StrengthMovementVariant39? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant40 value) => new StrengthMovement((global::Terra.StrengthMovementVariant40?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant40?(StrengthMovement @this) => @this.StrengthMovementVariant40;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant40? value)
        {
            StrengthMovementVariant40 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant40(global::Terra.StrengthMovementVariant40? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant41 value) => new StrengthMovement((global::Terra.StrengthMovementVariant41?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant41?(StrengthMovement @this) => @this.StrengthMovementVariant41;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant41? value)
        {
            StrengthMovementVariant41 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant41(global::Terra.StrengthMovementVariant41? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant42 value) => new StrengthMovement((global::Terra.StrengthMovementVariant42?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant42?(StrengthMovement @this) => @this.StrengthMovementVariant42;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant42? value)
        {
            StrengthMovementVariant42 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant42(global::Terra.StrengthMovementVariant42? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant43 value) => new StrengthMovement((global::Terra.StrengthMovementVariant43?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant43?(StrengthMovement @this) => @this.StrengthMovementVariant43;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant43? value)
        {
            StrengthMovementVariant43 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant43(global::Terra.StrengthMovementVariant43? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant44 value) => new StrengthMovement((global::Terra.StrengthMovementVariant44?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant44?(StrengthMovement @this) => @this.StrengthMovementVariant44;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant44? value)
        {
            StrengthMovementVariant44 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant44(global::Terra.StrengthMovementVariant44? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant45 value) => new StrengthMovement((global::Terra.StrengthMovementVariant45?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant45?(StrengthMovement @this) => @this.StrengthMovementVariant45;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant45? value)
        {
            StrengthMovementVariant45 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant45(global::Terra.StrengthMovementVariant45? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant46 value) => new StrengthMovement((global::Terra.StrengthMovementVariant46?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant46?(StrengthMovement @this) => @this.StrengthMovementVariant46;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant46? value)
        {
            StrengthMovementVariant46 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant46(global::Terra.StrengthMovementVariant46? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant47 value) => new StrengthMovement((global::Terra.StrengthMovementVariant47?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant47?(StrengthMovement @this) => @this.StrengthMovementVariant47;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant47? value)
        {
            StrengthMovementVariant47 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant47(global::Terra.StrengthMovementVariant47? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant48 value) => new StrengthMovement((global::Terra.StrengthMovementVariant48?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant48?(StrengthMovement @this) => @this.StrengthMovementVariant48;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant48? value)
        {
            StrengthMovementVariant48 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant48(global::Terra.StrengthMovementVariant48? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant49 value) => new StrengthMovement((global::Terra.StrengthMovementVariant49?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant49?(StrengthMovement @this) => @this.StrengthMovementVariant49;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant49? value)
        {
            StrengthMovementVariant49 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant49(global::Terra.StrengthMovementVariant49? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant50 value) => new StrengthMovement((global::Terra.StrengthMovementVariant50?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant50?(StrengthMovement @this) => @this.StrengthMovementVariant50;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant50? value)
        {
            StrengthMovementVariant50 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant50(global::Terra.StrengthMovementVariant50? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant51 value) => new StrengthMovement((global::Terra.StrengthMovementVariant51?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant51?(StrengthMovement @this) => @this.StrengthMovementVariant51;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant51? value)
        {
            StrengthMovementVariant51 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant51(global::Terra.StrengthMovementVariant51? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant52 value) => new StrengthMovement((global::Terra.StrengthMovementVariant52?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant52?(StrengthMovement @this) => @this.StrengthMovementVariant52;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant52? value)
        {
            StrengthMovementVariant52 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant52(global::Terra.StrengthMovementVariant52? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant53 value) => new StrengthMovement((global::Terra.StrengthMovementVariant53?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant53?(StrengthMovement @this) => @this.StrengthMovementVariant53;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant53? value)
        {
            StrengthMovementVariant53 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant53(global::Terra.StrengthMovementVariant53? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant54 value) => new StrengthMovement((global::Terra.StrengthMovementVariant54?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant54?(StrengthMovement @this) => @this.StrengthMovementVariant54;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant54? value)
        {
            StrengthMovementVariant54 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant54(global::Terra.StrengthMovementVariant54? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant55 value) => new StrengthMovement((global::Terra.StrengthMovementVariant55?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant55?(StrengthMovement @this) => @this.StrengthMovementVariant55;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant55? value)
        {
            StrengthMovementVariant55 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant55(global::Terra.StrengthMovementVariant55? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant56 value) => new StrengthMovement((global::Terra.StrengthMovementVariant56?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant56?(StrengthMovement @this) => @this.StrengthMovementVariant56;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant56? value)
        {
            StrengthMovementVariant56 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant56(global::Terra.StrengthMovementVariant56? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant57 value) => new StrengthMovement((global::Terra.StrengthMovementVariant57?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant57?(StrengthMovement @this) => @this.StrengthMovementVariant57;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant57? value)
        {
            StrengthMovementVariant57 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant57(global::Terra.StrengthMovementVariant57? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant58 value) => new StrengthMovement((global::Terra.StrengthMovementVariant58?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant58?(StrengthMovement @this) => @this.StrengthMovementVariant58;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant58? value)
        {
            StrengthMovementVariant58 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant58(global::Terra.StrengthMovementVariant58? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant59 value) => new StrengthMovement((global::Terra.StrengthMovementVariant59?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant59?(StrengthMovement @this) => @this.StrengthMovementVariant59;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant59? value)
        {
            StrengthMovementVariant59 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant59(global::Terra.StrengthMovementVariant59? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant60 value) => new StrengthMovement((global::Terra.StrengthMovementVariant60?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant60?(StrengthMovement @this) => @this.StrengthMovementVariant60;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant60? value)
        {
            StrengthMovementVariant60 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant60(global::Terra.StrengthMovementVariant60? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant61 value) => new StrengthMovement((global::Terra.StrengthMovementVariant61?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant61?(StrengthMovement @this) => @this.StrengthMovementVariant61;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant61? value)
        {
            StrengthMovementVariant61 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant61(global::Terra.StrengthMovementVariant61? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant62 value) => new StrengthMovement((global::Terra.StrengthMovementVariant62?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant62?(StrengthMovement @this) => @this.StrengthMovementVariant62;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant62? value)
        {
            StrengthMovementVariant62 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant62(global::Terra.StrengthMovementVariant62? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant63 value) => new StrengthMovement((global::Terra.StrengthMovementVariant63?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant63?(StrengthMovement @this) => @this.StrengthMovementVariant63;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant63? value)
        {
            StrengthMovementVariant63 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant63(global::Terra.StrengthMovementVariant63? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant64 value) => new StrengthMovement((global::Terra.StrengthMovementVariant64?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant64?(StrengthMovement @this) => @this.StrengthMovementVariant64;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant64? value)
        {
            StrengthMovementVariant64 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant64(global::Terra.StrengthMovementVariant64? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant65 value) => new StrengthMovement((global::Terra.StrengthMovementVariant65?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant65?(StrengthMovement @this) => @this.StrengthMovementVariant65;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant65? value)
        {
            StrengthMovementVariant65 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant65(global::Terra.StrengthMovementVariant65? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant66 value) => new StrengthMovement((global::Terra.StrengthMovementVariant66?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant66?(StrengthMovement @this) => @this.StrengthMovementVariant66;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant66? value)
        {
            StrengthMovementVariant66 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant66(global::Terra.StrengthMovementVariant66? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant67 value) => new StrengthMovement((global::Terra.StrengthMovementVariant67?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant67?(StrengthMovement @this) => @this.StrengthMovementVariant67;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant67? value)
        {
            StrengthMovementVariant67 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant67(global::Terra.StrengthMovementVariant67? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant68 value) => new StrengthMovement((global::Terra.StrengthMovementVariant68?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant68?(StrengthMovement @this) => @this.StrengthMovementVariant68;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant68? value)
        {
            StrengthMovementVariant68 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant68(global::Terra.StrengthMovementVariant68? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant69 value) => new StrengthMovement((global::Terra.StrengthMovementVariant69?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant69?(StrengthMovement @this) => @this.StrengthMovementVariant69;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant69? value)
        {
            StrengthMovementVariant69 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant69(global::Terra.StrengthMovementVariant69? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant70 value) => new StrengthMovement((global::Terra.StrengthMovementVariant70?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant70?(StrengthMovement @this) => @this.StrengthMovementVariant70;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant70? value)
        {
            StrengthMovementVariant70 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant70(global::Terra.StrengthMovementVariant70? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant71 value) => new StrengthMovement((global::Terra.StrengthMovementVariant71?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant71?(StrengthMovement @this) => @this.StrengthMovementVariant71;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant71? value)
        {
            StrengthMovementVariant71 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant71(global::Terra.StrengthMovementVariant71? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant72 value) => new StrengthMovement((global::Terra.StrengthMovementVariant72?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant72?(StrengthMovement @this) => @this.StrengthMovementVariant72;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant72? value)
        {
            StrengthMovementVariant72 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant72(global::Terra.StrengthMovementVariant72? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant73 value) => new StrengthMovement((global::Terra.StrengthMovementVariant73?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant73?(StrengthMovement @this) => @this.StrengthMovementVariant73;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant73? value)
        {
            StrengthMovementVariant73 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant73(global::Terra.StrengthMovementVariant73? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant74 value) => new StrengthMovement((global::Terra.StrengthMovementVariant74?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant74?(StrengthMovement @this) => @this.StrengthMovementVariant74;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant74? value)
        {
            StrengthMovementVariant74 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant74(global::Terra.StrengthMovementVariant74? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant75 value) => new StrengthMovement((global::Terra.StrengthMovementVariant75?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant75?(StrengthMovement @this) => @this.StrengthMovementVariant75;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant75? value)
        {
            StrengthMovementVariant75 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant75(global::Terra.StrengthMovementVariant75? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant76 value) => new StrengthMovement((global::Terra.StrengthMovementVariant76?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant76?(StrengthMovement @this) => @this.StrengthMovementVariant76;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant76? value)
        {
            StrengthMovementVariant76 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant76(global::Terra.StrengthMovementVariant76? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant77 value) => new StrengthMovement((global::Terra.StrengthMovementVariant77?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant77?(StrengthMovement @this) => @this.StrengthMovementVariant77;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant77? value)
        {
            StrengthMovementVariant77 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant77(global::Terra.StrengthMovementVariant77? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant78 value) => new StrengthMovement((global::Terra.StrengthMovementVariant78?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant78?(StrengthMovement @this) => @this.StrengthMovementVariant78;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant78? value)
        {
            StrengthMovementVariant78 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant78(global::Terra.StrengthMovementVariant78? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant79 value) => new StrengthMovement((global::Terra.StrengthMovementVariant79?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant79?(StrengthMovement @this) => @this.StrengthMovementVariant79;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant79? value)
        {
            StrengthMovementVariant79 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant79(global::Terra.StrengthMovementVariant79? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant80 value) => new StrengthMovement((global::Terra.StrengthMovementVariant80?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant80?(StrengthMovement @this) => @this.StrengthMovementVariant80;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant80? value)
        {
            StrengthMovementVariant80 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant80(global::Terra.StrengthMovementVariant80? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant81 value) => new StrengthMovement((global::Terra.StrengthMovementVariant81?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant81?(StrengthMovement @this) => @this.StrengthMovementVariant81;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant81? value)
        {
            StrengthMovementVariant81 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant81(global::Terra.StrengthMovementVariant81? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant82 value) => new StrengthMovement((global::Terra.StrengthMovementVariant82?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant82?(StrengthMovement @this) => @this.StrengthMovementVariant82;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant82? value)
        {
            StrengthMovementVariant82 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant82(global::Terra.StrengthMovementVariant82? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant83 value) => new StrengthMovement((global::Terra.StrengthMovementVariant83?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant83?(StrengthMovement @this) => @this.StrengthMovementVariant83;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant83? value)
        {
            StrengthMovementVariant83 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant83(global::Terra.StrengthMovementVariant83? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant84 value) => new StrengthMovement((global::Terra.StrengthMovementVariant84?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant84?(StrengthMovement @this) => @this.StrengthMovementVariant84;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant84? value)
        {
            StrengthMovementVariant84 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant84(global::Terra.StrengthMovementVariant84? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant85 value) => new StrengthMovement((global::Terra.StrengthMovementVariant85?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant85?(StrengthMovement @this) => @this.StrengthMovementVariant85;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant85? value)
        {
            StrengthMovementVariant85 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant85(global::Terra.StrengthMovementVariant85? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant86 value) => new StrengthMovement((global::Terra.StrengthMovementVariant86?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant86?(StrengthMovement @this) => @this.StrengthMovementVariant86;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant86? value)
        {
            StrengthMovementVariant86 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant86(global::Terra.StrengthMovementVariant86? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant87 value) => new StrengthMovement((global::Terra.StrengthMovementVariant87?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant87?(StrengthMovement @this) => @this.StrengthMovementVariant87;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant87? value)
        {
            StrengthMovementVariant87 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant87(global::Terra.StrengthMovementVariant87? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant88 value) => new StrengthMovement((global::Terra.StrengthMovementVariant88?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant88?(StrengthMovement @this) => @this.StrengthMovementVariant88;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant88? value)
        {
            StrengthMovementVariant88 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant88(global::Terra.StrengthMovementVariant88? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant89 value) => new StrengthMovement((global::Terra.StrengthMovementVariant89?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant89?(StrengthMovement @this) => @this.StrengthMovementVariant89;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant89? value)
        {
            StrengthMovementVariant89 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant89(global::Terra.StrengthMovementVariant89? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant90 value) => new StrengthMovement((global::Terra.StrengthMovementVariant90?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant90?(StrengthMovement @this) => @this.StrengthMovementVariant90;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant90? value)
        {
            StrengthMovementVariant90 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant90(global::Terra.StrengthMovementVariant90? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant91 value) => new StrengthMovement((global::Terra.StrengthMovementVariant91?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant91?(StrengthMovement @this) => @this.StrengthMovementVariant91;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant91? value)
        {
            StrengthMovementVariant91 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant91(global::Terra.StrengthMovementVariant91? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant92 value) => new StrengthMovement((global::Terra.StrengthMovementVariant92?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant92?(StrengthMovement @this) => @this.StrengthMovementVariant92;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant92? value)
        {
            StrengthMovementVariant92 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant92(global::Terra.StrengthMovementVariant92? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant93 value) => new StrengthMovement((global::Terra.StrengthMovementVariant93?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant93?(StrengthMovement @this) => @this.StrengthMovementVariant93;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant93? value)
        {
            StrengthMovementVariant93 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant93(global::Terra.StrengthMovementVariant93? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant94 value) => new StrengthMovement((global::Terra.StrengthMovementVariant94?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant94?(StrengthMovement @this) => @this.StrengthMovementVariant94;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant94? value)
        {
            StrengthMovementVariant94 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant94(global::Terra.StrengthMovementVariant94? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant95 value) => new StrengthMovement((global::Terra.StrengthMovementVariant95?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant95?(StrengthMovement @this) => @this.StrengthMovementVariant95;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant95? value)
        {
            StrengthMovementVariant95 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant95(global::Terra.StrengthMovementVariant95? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant96 value) => new StrengthMovement((global::Terra.StrengthMovementVariant96?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant96?(StrengthMovement @this) => @this.StrengthMovementVariant96;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant96? value)
        {
            StrengthMovementVariant96 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant96(global::Terra.StrengthMovementVariant96? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant97 value) => new StrengthMovement((global::Terra.StrengthMovementVariant97?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant97?(StrengthMovement @this) => @this.StrengthMovementVariant97;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant97? value)
        {
            StrengthMovementVariant97 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant97(global::Terra.StrengthMovementVariant97? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant98 value) => new StrengthMovement((global::Terra.StrengthMovementVariant98?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant98?(StrengthMovement @this) => @this.StrengthMovementVariant98;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant98? value)
        {
            StrengthMovementVariant98 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant98(global::Terra.StrengthMovementVariant98? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant99 value) => new StrengthMovement((global::Terra.StrengthMovementVariant99?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant99?(StrengthMovement @this) => @this.StrengthMovementVariant99;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant99? value)
        {
            StrengthMovementVariant99 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant99(global::Terra.StrengthMovementVariant99? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant100 value) => new StrengthMovement((global::Terra.StrengthMovementVariant100?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant100?(StrengthMovement @this) => @this.StrengthMovementVariant100;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant100? value)
        {
            StrengthMovementVariant100 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant100(global::Terra.StrengthMovementVariant100? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant101 value) => new StrengthMovement((global::Terra.StrengthMovementVariant101?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant101?(StrengthMovement @this) => @this.StrengthMovementVariant101;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant101? value)
        {
            StrengthMovementVariant101 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant101(global::Terra.StrengthMovementVariant101? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant102 value) => new StrengthMovement((global::Terra.StrengthMovementVariant102?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant102?(StrengthMovement @this) => @this.StrengthMovementVariant102;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant102? value)
        {
            StrengthMovementVariant102 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant102(global::Terra.StrengthMovementVariant102? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant103 value) => new StrengthMovement((global::Terra.StrengthMovementVariant103?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant103?(StrengthMovement @this) => @this.StrengthMovementVariant103;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant103? value)
        {
            StrengthMovementVariant103 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant103(global::Terra.StrengthMovementVariant103? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant104 value) => new StrengthMovement((global::Terra.StrengthMovementVariant104?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant104?(StrengthMovement @this) => @this.StrengthMovementVariant104;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant104? value)
        {
            StrengthMovementVariant104 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant104(global::Terra.StrengthMovementVariant104? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant105 value) => new StrengthMovement((global::Terra.StrengthMovementVariant105?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant105?(StrengthMovement @this) => @this.StrengthMovementVariant105;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant105? value)
        {
            StrengthMovementVariant105 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant105(global::Terra.StrengthMovementVariant105? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant106 value) => new StrengthMovement((global::Terra.StrengthMovementVariant106?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant106?(StrengthMovement @this) => @this.StrengthMovementVariant106;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant106? value)
        {
            StrengthMovementVariant106 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant106(global::Terra.StrengthMovementVariant106? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant107 value) => new StrengthMovement((global::Terra.StrengthMovementVariant107?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant107?(StrengthMovement @this) => @this.StrengthMovementVariant107;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant107? value)
        {
            StrengthMovementVariant107 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant107(global::Terra.StrengthMovementVariant107? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant108 value) => new StrengthMovement((global::Terra.StrengthMovementVariant108?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant108?(StrengthMovement @this) => @this.StrengthMovementVariant108;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant108? value)
        {
            StrengthMovementVariant108 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant108(global::Terra.StrengthMovementVariant108? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant109 value) => new StrengthMovement((global::Terra.StrengthMovementVariant109?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant109?(StrengthMovement @this) => @this.StrengthMovementVariant109;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant109? value)
        {
            StrengthMovementVariant109 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant109(global::Terra.StrengthMovementVariant109? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant110 value) => new StrengthMovement((global::Terra.StrengthMovementVariant110?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant110?(StrengthMovement @this) => @this.StrengthMovementVariant110;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant110? value)
        {
            StrengthMovementVariant110 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant110(global::Terra.StrengthMovementVariant110? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant111 value) => new StrengthMovement((global::Terra.StrengthMovementVariant111?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant111?(StrengthMovement @this) => @this.StrengthMovementVariant111;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant111? value)
        {
            StrengthMovementVariant111 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant111(global::Terra.StrengthMovementVariant111? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant112 value) => new StrengthMovement((global::Terra.StrengthMovementVariant112?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant112?(StrengthMovement @this) => @this.StrengthMovementVariant112;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant112? value)
        {
            StrengthMovementVariant112 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant112(global::Terra.StrengthMovementVariant112? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant113 value) => new StrengthMovement((global::Terra.StrengthMovementVariant113?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant113?(StrengthMovement @this) => @this.StrengthMovementVariant113;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant113? value)
        {
            StrengthMovementVariant113 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant113(global::Terra.StrengthMovementVariant113? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant114 value) => new StrengthMovement((global::Terra.StrengthMovementVariant114?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant114?(StrengthMovement @this) => @this.StrengthMovementVariant114;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant114? value)
        {
            StrengthMovementVariant114 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant114(global::Terra.StrengthMovementVariant114? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant115 value) => new StrengthMovement((global::Terra.StrengthMovementVariant115?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant115?(StrengthMovement @this) => @this.StrengthMovementVariant115;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant115? value)
        {
            StrengthMovementVariant115 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant115(global::Terra.StrengthMovementVariant115? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant116 value) => new StrengthMovement((global::Terra.StrengthMovementVariant116?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant116?(StrengthMovement @this) => @this.StrengthMovementVariant116;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant116? value)
        {
            StrengthMovementVariant116 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant116(global::Terra.StrengthMovementVariant116? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant117 value) => new StrengthMovement((global::Terra.StrengthMovementVariant117?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant117?(StrengthMovement @this) => @this.StrengthMovementVariant117;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant117? value)
        {
            StrengthMovementVariant117 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant117(global::Terra.StrengthMovementVariant117? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant118 value) => new StrengthMovement((global::Terra.StrengthMovementVariant118?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant118?(StrengthMovement @this) => @this.StrengthMovementVariant118;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant118? value)
        {
            StrengthMovementVariant118 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant118(global::Terra.StrengthMovementVariant118? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant119 value) => new StrengthMovement((global::Terra.StrengthMovementVariant119?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant119?(StrengthMovement @this) => @this.StrengthMovementVariant119;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant119? value)
        {
            StrengthMovementVariant119 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant119(global::Terra.StrengthMovementVariant119? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant120 value) => new StrengthMovement((global::Terra.StrengthMovementVariant120?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant120?(StrengthMovement @this) => @this.StrengthMovementVariant120;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant120? value)
        {
            StrengthMovementVariant120 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant120(global::Terra.StrengthMovementVariant120? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant121 value) => new StrengthMovement((global::Terra.StrengthMovementVariant121?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant121?(StrengthMovement @this) => @this.StrengthMovementVariant121;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant121? value)
        {
            StrengthMovementVariant121 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant121(global::Terra.StrengthMovementVariant121? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant122 value) => new StrengthMovement((global::Terra.StrengthMovementVariant122?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant122?(StrengthMovement @this) => @this.StrengthMovementVariant122;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant122? value)
        {
            StrengthMovementVariant122 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant122(global::Terra.StrengthMovementVariant122? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant123 value) => new StrengthMovement((global::Terra.StrengthMovementVariant123?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant123?(StrengthMovement @this) => @this.StrengthMovementVariant123;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant123? value)
        {
            StrengthMovementVariant123 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant123(global::Terra.StrengthMovementVariant123? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant124 value) => new StrengthMovement((global::Terra.StrengthMovementVariant124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant124?(StrengthMovement @this) => @this.StrengthMovementVariant124;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant124? value)
        {
            StrengthMovementVariant124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant124(global::Terra.StrengthMovementVariant124? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant125 value) => new StrengthMovement((global::Terra.StrengthMovementVariant125?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant125?(StrengthMovement @this) => @this.StrengthMovementVariant125;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant125? value)
        {
            StrengthMovementVariant125 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant125(global::Terra.StrengthMovementVariant125? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant126 value) => new StrengthMovement((global::Terra.StrengthMovementVariant126?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant126?(StrengthMovement @this) => @this.StrengthMovementVariant126;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant126? value)
        {
            StrengthMovementVariant126 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant126(global::Terra.StrengthMovementVariant126? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant127 value) => new StrengthMovement((global::Terra.StrengthMovementVariant127?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant127?(StrengthMovement @this) => @this.StrengthMovementVariant127;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant127? value)
        {
            StrengthMovementVariant127 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant127(global::Terra.StrengthMovementVariant127? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant128 value) => new StrengthMovement((global::Terra.StrengthMovementVariant128?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant128?(StrengthMovement @this) => @this.StrengthMovementVariant128;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant128? value)
        {
            StrengthMovementVariant128 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant128(global::Terra.StrengthMovementVariant128? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant129 value) => new StrengthMovement((global::Terra.StrengthMovementVariant129?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant129?(StrengthMovement @this) => @this.StrengthMovementVariant129;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant129? value)
        {
            StrengthMovementVariant129 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant129(global::Terra.StrengthMovementVariant129? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant130 value) => new StrengthMovement((global::Terra.StrengthMovementVariant130?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant130?(StrengthMovement @this) => @this.StrengthMovementVariant130;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant130? value)
        {
            StrengthMovementVariant130 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant130(global::Terra.StrengthMovementVariant130? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant131 value) => new StrengthMovement((global::Terra.StrengthMovementVariant131?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant131?(StrengthMovement @this) => @this.StrengthMovementVariant131;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant131? value)
        {
            StrengthMovementVariant131 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant131(global::Terra.StrengthMovementVariant131? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant132 value) => new StrengthMovement((global::Terra.StrengthMovementVariant132?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant132?(StrengthMovement @this) => @this.StrengthMovementVariant132;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant132? value)
        {
            StrengthMovementVariant132 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant132(global::Terra.StrengthMovementVariant132? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant133 value) => new StrengthMovement((global::Terra.StrengthMovementVariant133?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant133?(StrengthMovement @this) => @this.StrengthMovementVariant133;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant133? value)
        {
            StrengthMovementVariant133 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant133(global::Terra.StrengthMovementVariant133? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant134 value) => new StrengthMovement((global::Terra.StrengthMovementVariant134?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant134?(StrengthMovement @this) => @this.StrengthMovementVariant134;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant134? value)
        {
            StrengthMovementVariant134 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant134(global::Terra.StrengthMovementVariant134? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant135 value) => new StrengthMovement((global::Terra.StrengthMovementVariant135?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant135?(StrengthMovement @this) => @this.StrengthMovementVariant135;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant135? value)
        {
            StrengthMovementVariant135 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant135(global::Terra.StrengthMovementVariant135? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant136 value) => new StrengthMovement((global::Terra.StrengthMovementVariant136?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant136?(StrengthMovement @this) => @this.StrengthMovementVariant136;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant136? value)
        {
            StrengthMovementVariant136 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant136(global::Terra.StrengthMovementVariant136? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant137 value) => new StrengthMovement((global::Terra.StrengthMovementVariant137?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant137?(StrengthMovement @this) => @this.StrengthMovementVariant137;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant137? value)
        {
            StrengthMovementVariant137 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant137(global::Terra.StrengthMovementVariant137? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant138 value) => new StrengthMovement((global::Terra.StrengthMovementVariant138?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant138?(StrengthMovement @this) => @this.StrengthMovementVariant138;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant138? value)
        {
            StrengthMovementVariant138 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant138(global::Terra.StrengthMovementVariant138? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant139 value) => new StrengthMovement((global::Terra.StrengthMovementVariant139?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant139?(StrengthMovement @this) => @this.StrengthMovementVariant139;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant139? value)
        {
            StrengthMovementVariant139 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant139(global::Terra.StrengthMovementVariant139? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant140 value) => new StrengthMovement((global::Terra.StrengthMovementVariant140?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant140?(StrengthMovement @this) => @this.StrengthMovementVariant140;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant140? value)
        {
            StrengthMovementVariant140 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant140(global::Terra.StrengthMovementVariant140? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant141 value) => new StrengthMovement((global::Terra.StrengthMovementVariant141?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant141?(StrengthMovement @this) => @this.StrengthMovementVariant141;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant141? value)
        {
            StrengthMovementVariant141 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant141(global::Terra.StrengthMovementVariant141? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant142 value) => new StrengthMovement((global::Terra.StrengthMovementVariant142?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant142?(StrengthMovement @this) => @this.StrengthMovementVariant142;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant142? value)
        {
            StrengthMovementVariant142 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant142(global::Terra.StrengthMovementVariant142? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant143 value) => new StrengthMovement((global::Terra.StrengthMovementVariant143?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant143?(StrengthMovement @this) => @this.StrengthMovementVariant143;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant143? value)
        {
            StrengthMovementVariant143 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant143(global::Terra.StrengthMovementVariant143? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant144 value) => new StrengthMovement((global::Terra.StrengthMovementVariant144?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant144?(StrengthMovement @this) => @this.StrengthMovementVariant144;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant144? value)
        {
            StrengthMovementVariant144 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant144(global::Terra.StrengthMovementVariant144? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant145 value) => new StrengthMovement((global::Terra.StrengthMovementVariant145?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant145?(StrengthMovement @this) => @this.StrengthMovementVariant145;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant145? value)
        {
            StrengthMovementVariant145 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant145(global::Terra.StrengthMovementVariant145? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant146 value) => new StrengthMovement((global::Terra.StrengthMovementVariant146?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant146?(StrengthMovement @this) => @this.StrengthMovementVariant146;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant146? value)
        {
            StrengthMovementVariant146 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant146(global::Terra.StrengthMovementVariant146? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant147 value) => new StrengthMovement((global::Terra.StrengthMovementVariant147?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant147?(StrengthMovement @this) => @this.StrengthMovementVariant147;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant147? value)
        {
            StrengthMovementVariant147 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant147(global::Terra.StrengthMovementVariant147? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant148 value) => new StrengthMovement((global::Terra.StrengthMovementVariant148?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant148?(StrengthMovement @this) => @this.StrengthMovementVariant148;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant148? value)
        {
            StrengthMovementVariant148 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant148(global::Terra.StrengthMovementVariant148? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant149 value) => new StrengthMovement((global::Terra.StrengthMovementVariant149?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant149?(StrengthMovement @this) => @this.StrengthMovementVariant149;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant149? value)
        {
            StrengthMovementVariant149 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant149(global::Terra.StrengthMovementVariant149? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant150 value) => new StrengthMovement((global::Terra.StrengthMovementVariant150?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant150?(StrengthMovement @this) => @this.StrengthMovementVariant150;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant150? value)
        {
            StrengthMovementVariant150 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant150(global::Terra.StrengthMovementVariant150? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant151 value) => new StrengthMovement((global::Terra.StrengthMovementVariant151?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant151?(StrengthMovement @this) => @this.StrengthMovementVariant151;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant151? value)
        {
            StrengthMovementVariant151 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant151(global::Terra.StrengthMovementVariant151? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant152 value) => new StrengthMovement((global::Terra.StrengthMovementVariant152?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant152?(StrengthMovement @this) => @this.StrengthMovementVariant152;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant152? value)
        {
            StrengthMovementVariant152 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant152(global::Terra.StrengthMovementVariant152? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant153 value) => new StrengthMovement((global::Terra.StrengthMovementVariant153?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant153?(StrengthMovement @this) => @this.StrengthMovementVariant153;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant153? value)
        {
            StrengthMovementVariant153 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant153(global::Terra.StrengthMovementVariant153? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant154 value) => new StrengthMovement((global::Terra.StrengthMovementVariant154?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant154?(StrengthMovement @this) => @this.StrengthMovementVariant154;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant154? value)
        {
            StrengthMovementVariant154 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant154(global::Terra.StrengthMovementVariant154? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant155 value) => new StrengthMovement((global::Terra.StrengthMovementVariant155?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant155?(StrengthMovement @this) => @this.StrengthMovementVariant155;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant155? value)
        {
            StrengthMovementVariant155 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant155(global::Terra.StrengthMovementVariant155? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant156 value) => new StrengthMovement((global::Terra.StrengthMovementVariant156?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant156?(StrengthMovement @this) => @this.StrengthMovementVariant156;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant156? value)
        {
            StrengthMovementVariant156 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant156(global::Terra.StrengthMovementVariant156? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant157 value) => new StrengthMovement((global::Terra.StrengthMovementVariant157?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant157?(StrengthMovement @this) => @this.StrengthMovementVariant157;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant157? value)
        {
            StrengthMovementVariant157 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant157(global::Terra.StrengthMovementVariant157? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant158 value) => new StrengthMovement((global::Terra.StrengthMovementVariant158?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant158?(StrengthMovement @this) => @this.StrengthMovementVariant158;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant158? value)
        {
            StrengthMovementVariant158 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant158(global::Terra.StrengthMovementVariant158? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant159 value) => new StrengthMovement((global::Terra.StrengthMovementVariant159?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant159?(StrengthMovement @this) => @this.StrengthMovementVariant159;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant159? value)
        {
            StrengthMovementVariant159 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant159(global::Terra.StrengthMovementVariant159? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant160 value) => new StrengthMovement((global::Terra.StrengthMovementVariant160?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant160?(StrengthMovement @this) => @this.StrengthMovementVariant160;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant160? value)
        {
            StrengthMovementVariant160 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant160(global::Terra.StrengthMovementVariant160? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant161 value) => new StrengthMovement((global::Terra.StrengthMovementVariant161?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant161?(StrengthMovement @this) => @this.StrengthMovementVariant161;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant161? value)
        {
            StrengthMovementVariant161 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant161(global::Terra.StrengthMovementVariant161? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant162 value) => new StrengthMovement((global::Terra.StrengthMovementVariant162?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant162?(StrengthMovement @this) => @this.StrengthMovementVariant162;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant162? value)
        {
            StrengthMovementVariant162 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant162(global::Terra.StrengthMovementVariant162? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant163 value) => new StrengthMovement((global::Terra.StrengthMovementVariant163?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant163?(StrengthMovement @this) => @this.StrengthMovementVariant163;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant163? value)
        {
            StrengthMovementVariant163 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant163(global::Terra.StrengthMovementVariant163? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant164 value) => new StrengthMovement((global::Terra.StrengthMovementVariant164?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant164?(StrengthMovement @this) => @this.StrengthMovementVariant164;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant164? value)
        {
            StrengthMovementVariant164 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant164(global::Terra.StrengthMovementVariant164? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant165 value) => new StrengthMovement((global::Terra.StrengthMovementVariant165?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant165?(StrengthMovement @this) => @this.StrengthMovementVariant165;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant165? value)
        {
            StrengthMovementVariant165 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant165(global::Terra.StrengthMovementVariant165? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant166 value) => new StrengthMovement((global::Terra.StrengthMovementVariant166?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant166?(StrengthMovement @this) => @this.StrengthMovementVariant166;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant166? value)
        {
            StrengthMovementVariant166 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant166(global::Terra.StrengthMovementVariant166? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant167 value) => new StrengthMovement((global::Terra.StrengthMovementVariant167?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant167?(StrengthMovement @this) => @this.StrengthMovementVariant167;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant167? value)
        {
            StrengthMovementVariant167 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant167(global::Terra.StrengthMovementVariant167? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant168 value) => new StrengthMovement((global::Terra.StrengthMovementVariant168?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant168?(StrengthMovement @this) => @this.StrengthMovementVariant168;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant168? value)
        {
            StrengthMovementVariant168 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant168(global::Terra.StrengthMovementVariant168? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant169 value) => new StrengthMovement((global::Terra.StrengthMovementVariant169?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant169?(StrengthMovement @this) => @this.StrengthMovementVariant169;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant169? value)
        {
            StrengthMovementVariant169 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant169(global::Terra.StrengthMovementVariant169? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant170 value) => new StrengthMovement((global::Terra.StrengthMovementVariant170?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant170?(StrengthMovement @this) => @this.StrengthMovementVariant170;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant170? value)
        {
            StrengthMovementVariant170 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant170(global::Terra.StrengthMovementVariant170? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant171 value) => new StrengthMovement((global::Terra.StrengthMovementVariant171?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant171?(StrengthMovement @this) => @this.StrengthMovementVariant171;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant171? value)
        {
            StrengthMovementVariant171 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant171(global::Terra.StrengthMovementVariant171? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant172 value) => new StrengthMovement((global::Terra.StrengthMovementVariant172?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant172?(StrengthMovement @this) => @this.StrengthMovementVariant172;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant172? value)
        {
            StrengthMovementVariant172 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant172(global::Terra.StrengthMovementVariant172? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant173 value) => new StrengthMovement((global::Terra.StrengthMovementVariant173?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant173?(StrengthMovement @this) => @this.StrengthMovementVariant173;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant173? value)
        {
            StrengthMovementVariant173 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant173(global::Terra.StrengthMovementVariant173? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant174 value) => new StrengthMovement((global::Terra.StrengthMovementVariant174?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant174?(StrengthMovement @this) => @this.StrengthMovementVariant174;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant174? value)
        {
            StrengthMovementVariant174 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant174(global::Terra.StrengthMovementVariant174? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(global::Terra.StrengthMovementVariant175 value) => new StrengthMovement((global::Terra.StrengthMovementVariant175?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMovementVariant175?(StrengthMovement @this) => @this.StrengthMovementVariant175;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(global::Terra.StrengthMovementVariant175? value)
        {
            StrengthMovementVariant175 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant175(global::Terra.StrengthMovementVariant175? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMovement(string value) => new StrengthMovement((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthMovement @this) => @this.StrengthMovementVariant176;

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(string? value)
        {
            StrengthMovementVariant176 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMovement FromStrengthMovementVariant176(string? value) => new StrengthMovement(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthMovement(
            global::Terra.StrengthMovementVariant1? strengthMovementVariant1,
            global::Terra.StrengthMovementVariant2? strengthMovementVariant2,
            global::Terra.StrengthMovementVariant3? strengthMovementVariant3,
            global::Terra.StrengthMovementVariant4? strengthMovementVariant4,
            global::Terra.StrengthMovementVariant5? strengthMovementVariant5,
            global::Terra.StrengthMovementVariant6? strengthMovementVariant6,
            global::Terra.StrengthMovementVariant7? strengthMovementVariant7,
            global::Terra.StrengthMovementVariant8? strengthMovementVariant8,
            global::Terra.StrengthMovementVariant9? strengthMovementVariant9,
            global::Terra.StrengthMovementVariant10? strengthMovementVariant10,
            global::Terra.StrengthMovementVariant11? strengthMovementVariant11,
            global::Terra.StrengthMovementVariant12? strengthMovementVariant12,
            global::Terra.StrengthMovementVariant13? strengthMovementVariant13,
            global::Terra.StrengthMovementVariant14? strengthMovementVariant14,
            global::Terra.StrengthMovementVariant15? strengthMovementVariant15,
            global::Terra.StrengthMovementVariant16? strengthMovementVariant16,
            global::Terra.StrengthMovementVariant17? strengthMovementVariant17,
            global::Terra.StrengthMovementVariant18? strengthMovementVariant18,
            global::Terra.StrengthMovementVariant19? strengthMovementVariant19,
            global::Terra.StrengthMovementVariant20? strengthMovementVariant20,
            global::Terra.StrengthMovementVariant21? strengthMovementVariant21,
            global::Terra.StrengthMovementVariant22? strengthMovementVariant22,
            global::Terra.StrengthMovementVariant23? strengthMovementVariant23,
            global::Terra.StrengthMovementVariant24? strengthMovementVariant24,
            global::Terra.StrengthMovementVariant25? strengthMovementVariant25,
            global::Terra.StrengthMovementVariant26? strengthMovementVariant26,
            global::Terra.StrengthMovementVariant27? strengthMovementVariant27,
            global::Terra.StrengthMovementVariant28? strengthMovementVariant28,
            global::Terra.StrengthMovementVariant29? strengthMovementVariant29,
            global::Terra.StrengthMovementVariant30? strengthMovementVariant30,
            global::Terra.StrengthMovementVariant31? strengthMovementVariant31,
            global::Terra.StrengthMovementVariant32? strengthMovementVariant32,
            global::Terra.StrengthMovementVariant33? strengthMovementVariant33,
            global::Terra.StrengthMovementVariant34? strengthMovementVariant34,
            global::Terra.StrengthMovementVariant35? strengthMovementVariant35,
            global::Terra.StrengthMovementVariant36? strengthMovementVariant36,
            global::Terra.StrengthMovementVariant37? strengthMovementVariant37,
            global::Terra.StrengthMovementVariant38? strengthMovementVariant38,
            global::Terra.StrengthMovementVariant39? strengthMovementVariant39,
            global::Terra.StrengthMovementVariant40? strengthMovementVariant40,
            global::Terra.StrengthMovementVariant41? strengthMovementVariant41,
            global::Terra.StrengthMovementVariant42? strengthMovementVariant42,
            global::Terra.StrengthMovementVariant43? strengthMovementVariant43,
            global::Terra.StrengthMovementVariant44? strengthMovementVariant44,
            global::Terra.StrengthMovementVariant45? strengthMovementVariant45,
            global::Terra.StrengthMovementVariant46? strengthMovementVariant46,
            global::Terra.StrengthMovementVariant47? strengthMovementVariant47,
            global::Terra.StrengthMovementVariant48? strengthMovementVariant48,
            global::Terra.StrengthMovementVariant49? strengthMovementVariant49,
            global::Terra.StrengthMovementVariant50? strengthMovementVariant50,
            global::Terra.StrengthMovementVariant51? strengthMovementVariant51,
            global::Terra.StrengthMovementVariant52? strengthMovementVariant52,
            global::Terra.StrengthMovementVariant53? strengthMovementVariant53,
            global::Terra.StrengthMovementVariant54? strengthMovementVariant54,
            global::Terra.StrengthMovementVariant55? strengthMovementVariant55,
            global::Terra.StrengthMovementVariant56? strengthMovementVariant56,
            global::Terra.StrengthMovementVariant57? strengthMovementVariant57,
            global::Terra.StrengthMovementVariant58? strengthMovementVariant58,
            global::Terra.StrengthMovementVariant59? strengthMovementVariant59,
            global::Terra.StrengthMovementVariant60? strengthMovementVariant60,
            global::Terra.StrengthMovementVariant61? strengthMovementVariant61,
            global::Terra.StrengthMovementVariant62? strengthMovementVariant62,
            global::Terra.StrengthMovementVariant63? strengthMovementVariant63,
            global::Terra.StrengthMovementVariant64? strengthMovementVariant64,
            global::Terra.StrengthMovementVariant65? strengthMovementVariant65,
            global::Terra.StrengthMovementVariant66? strengthMovementVariant66,
            global::Terra.StrengthMovementVariant67? strengthMovementVariant67,
            global::Terra.StrengthMovementVariant68? strengthMovementVariant68,
            global::Terra.StrengthMovementVariant69? strengthMovementVariant69,
            global::Terra.StrengthMovementVariant70? strengthMovementVariant70,
            global::Terra.StrengthMovementVariant71? strengthMovementVariant71,
            global::Terra.StrengthMovementVariant72? strengthMovementVariant72,
            global::Terra.StrengthMovementVariant73? strengthMovementVariant73,
            global::Terra.StrengthMovementVariant74? strengthMovementVariant74,
            global::Terra.StrengthMovementVariant75? strengthMovementVariant75,
            global::Terra.StrengthMovementVariant76? strengthMovementVariant76,
            global::Terra.StrengthMovementVariant77? strengthMovementVariant77,
            global::Terra.StrengthMovementVariant78? strengthMovementVariant78,
            global::Terra.StrengthMovementVariant79? strengthMovementVariant79,
            global::Terra.StrengthMovementVariant80? strengthMovementVariant80,
            global::Terra.StrengthMovementVariant81? strengthMovementVariant81,
            global::Terra.StrengthMovementVariant82? strengthMovementVariant82,
            global::Terra.StrengthMovementVariant83? strengthMovementVariant83,
            global::Terra.StrengthMovementVariant84? strengthMovementVariant84,
            global::Terra.StrengthMovementVariant85? strengthMovementVariant85,
            global::Terra.StrengthMovementVariant86? strengthMovementVariant86,
            global::Terra.StrengthMovementVariant87? strengthMovementVariant87,
            global::Terra.StrengthMovementVariant88? strengthMovementVariant88,
            global::Terra.StrengthMovementVariant89? strengthMovementVariant89,
            global::Terra.StrengthMovementVariant90? strengthMovementVariant90,
            global::Terra.StrengthMovementVariant91? strengthMovementVariant91,
            global::Terra.StrengthMovementVariant92? strengthMovementVariant92,
            global::Terra.StrengthMovementVariant93? strengthMovementVariant93,
            global::Terra.StrengthMovementVariant94? strengthMovementVariant94,
            global::Terra.StrengthMovementVariant95? strengthMovementVariant95,
            global::Terra.StrengthMovementVariant96? strengthMovementVariant96,
            global::Terra.StrengthMovementVariant97? strengthMovementVariant97,
            global::Terra.StrengthMovementVariant98? strengthMovementVariant98,
            global::Terra.StrengthMovementVariant99? strengthMovementVariant99,
            global::Terra.StrengthMovementVariant100? strengthMovementVariant100,
            global::Terra.StrengthMovementVariant101? strengthMovementVariant101,
            global::Terra.StrengthMovementVariant102? strengthMovementVariant102,
            global::Terra.StrengthMovementVariant103? strengthMovementVariant103,
            global::Terra.StrengthMovementVariant104? strengthMovementVariant104,
            global::Terra.StrengthMovementVariant105? strengthMovementVariant105,
            global::Terra.StrengthMovementVariant106? strengthMovementVariant106,
            global::Terra.StrengthMovementVariant107? strengthMovementVariant107,
            global::Terra.StrengthMovementVariant108? strengthMovementVariant108,
            global::Terra.StrengthMovementVariant109? strengthMovementVariant109,
            global::Terra.StrengthMovementVariant110? strengthMovementVariant110,
            global::Terra.StrengthMovementVariant111? strengthMovementVariant111,
            global::Terra.StrengthMovementVariant112? strengthMovementVariant112,
            global::Terra.StrengthMovementVariant113? strengthMovementVariant113,
            global::Terra.StrengthMovementVariant114? strengthMovementVariant114,
            global::Terra.StrengthMovementVariant115? strengthMovementVariant115,
            global::Terra.StrengthMovementVariant116? strengthMovementVariant116,
            global::Terra.StrengthMovementVariant117? strengthMovementVariant117,
            global::Terra.StrengthMovementVariant118? strengthMovementVariant118,
            global::Terra.StrengthMovementVariant119? strengthMovementVariant119,
            global::Terra.StrengthMovementVariant120? strengthMovementVariant120,
            global::Terra.StrengthMovementVariant121? strengthMovementVariant121,
            global::Terra.StrengthMovementVariant122? strengthMovementVariant122,
            global::Terra.StrengthMovementVariant123? strengthMovementVariant123,
            global::Terra.StrengthMovementVariant124? strengthMovementVariant124,
            global::Terra.StrengthMovementVariant125? strengthMovementVariant125,
            global::Terra.StrengthMovementVariant126? strengthMovementVariant126,
            global::Terra.StrengthMovementVariant127? strengthMovementVariant127,
            global::Terra.StrengthMovementVariant128? strengthMovementVariant128,
            global::Terra.StrengthMovementVariant129? strengthMovementVariant129,
            global::Terra.StrengthMovementVariant130? strengthMovementVariant130,
            global::Terra.StrengthMovementVariant131? strengthMovementVariant131,
            global::Terra.StrengthMovementVariant132? strengthMovementVariant132,
            global::Terra.StrengthMovementVariant133? strengthMovementVariant133,
            global::Terra.StrengthMovementVariant134? strengthMovementVariant134,
            global::Terra.StrengthMovementVariant135? strengthMovementVariant135,
            global::Terra.StrengthMovementVariant136? strengthMovementVariant136,
            global::Terra.StrengthMovementVariant137? strengthMovementVariant137,
            global::Terra.StrengthMovementVariant138? strengthMovementVariant138,
            global::Terra.StrengthMovementVariant139? strengthMovementVariant139,
            global::Terra.StrengthMovementVariant140? strengthMovementVariant140,
            global::Terra.StrengthMovementVariant141? strengthMovementVariant141,
            global::Terra.StrengthMovementVariant142? strengthMovementVariant142,
            global::Terra.StrengthMovementVariant143? strengthMovementVariant143,
            global::Terra.StrengthMovementVariant144? strengthMovementVariant144,
            global::Terra.StrengthMovementVariant145? strengthMovementVariant145,
            global::Terra.StrengthMovementVariant146? strengthMovementVariant146,
            global::Terra.StrengthMovementVariant147? strengthMovementVariant147,
            global::Terra.StrengthMovementVariant148? strengthMovementVariant148,
            global::Terra.StrengthMovementVariant149? strengthMovementVariant149,
            global::Terra.StrengthMovementVariant150? strengthMovementVariant150,
            global::Terra.StrengthMovementVariant151? strengthMovementVariant151,
            global::Terra.StrengthMovementVariant152? strengthMovementVariant152,
            global::Terra.StrengthMovementVariant153? strengthMovementVariant153,
            global::Terra.StrengthMovementVariant154? strengthMovementVariant154,
            global::Terra.StrengthMovementVariant155? strengthMovementVariant155,
            global::Terra.StrengthMovementVariant156? strengthMovementVariant156,
            global::Terra.StrengthMovementVariant157? strengthMovementVariant157,
            global::Terra.StrengthMovementVariant158? strengthMovementVariant158,
            global::Terra.StrengthMovementVariant159? strengthMovementVariant159,
            global::Terra.StrengthMovementVariant160? strengthMovementVariant160,
            global::Terra.StrengthMovementVariant161? strengthMovementVariant161,
            global::Terra.StrengthMovementVariant162? strengthMovementVariant162,
            global::Terra.StrengthMovementVariant163? strengthMovementVariant163,
            global::Terra.StrengthMovementVariant164? strengthMovementVariant164,
            global::Terra.StrengthMovementVariant165? strengthMovementVariant165,
            global::Terra.StrengthMovementVariant166? strengthMovementVariant166,
            global::Terra.StrengthMovementVariant167? strengthMovementVariant167,
            global::Terra.StrengthMovementVariant168? strengthMovementVariant168,
            global::Terra.StrengthMovementVariant169? strengthMovementVariant169,
            global::Terra.StrengthMovementVariant170? strengthMovementVariant170,
            global::Terra.StrengthMovementVariant171? strengthMovementVariant171,
            global::Terra.StrengthMovementVariant172? strengthMovementVariant172,
            global::Terra.StrengthMovementVariant173? strengthMovementVariant173,
            global::Terra.StrengthMovementVariant174? strengthMovementVariant174,
            global::Terra.StrengthMovementVariant175? strengthMovementVariant175,
            string? strengthMovementVariant176
            )
        {
            StrengthMovementVariant1 = strengthMovementVariant1;
            StrengthMovementVariant2 = strengthMovementVariant2;
            StrengthMovementVariant3 = strengthMovementVariant3;
            StrengthMovementVariant4 = strengthMovementVariant4;
            StrengthMovementVariant5 = strengthMovementVariant5;
            StrengthMovementVariant6 = strengthMovementVariant6;
            StrengthMovementVariant7 = strengthMovementVariant7;
            StrengthMovementVariant8 = strengthMovementVariant8;
            StrengthMovementVariant9 = strengthMovementVariant9;
            StrengthMovementVariant10 = strengthMovementVariant10;
            StrengthMovementVariant11 = strengthMovementVariant11;
            StrengthMovementVariant12 = strengthMovementVariant12;
            StrengthMovementVariant13 = strengthMovementVariant13;
            StrengthMovementVariant14 = strengthMovementVariant14;
            StrengthMovementVariant15 = strengthMovementVariant15;
            StrengthMovementVariant16 = strengthMovementVariant16;
            StrengthMovementVariant17 = strengthMovementVariant17;
            StrengthMovementVariant18 = strengthMovementVariant18;
            StrengthMovementVariant19 = strengthMovementVariant19;
            StrengthMovementVariant20 = strengthMovementVariant20;
            StrengthMovementVariant21 = strengthMovementVariant21;
            StrengthMovementVariant22 = strengthMovementVariant22;
            StrengthMovementVariant23 = strengthMovementVariant23;
            StrengthMovementVariant24 = strengthMovementVariant24;
            StrengthMovementVariant25 = strengthMovementVariant25;
            StrengthMovementVariant26 = strengthMovementVariant26;
            StrengthMovementVariant27 = strengthMovementVariant27;
            StrengthMovementVariant28 = strengthMovementVariant28;
            StrengthMovementVariant29 = strengthMovementVariant29;
            StrengthMovementVariant30 = strengthMovementVariant30;
            StrengthMovementVariant31 = strengthMovementVariant31;
            StrengthMovementVariant32 = strengthMovementVariant32;
            StrengthMovementVariant33 = strengthMovementVariant33;
            StrengthMovementVariant34 = strengthMovementVariant34;
            StrengthMovementVariant35 = strengthMovementVariant35;
            StrengthMovementVariant36 = strengthMovementVariant36;
            StrengthMovementVariant37 = strengthMovementVariant37;
            StrengthMovementVariant38 = strengthMovementVariant38;
            StrengthMovementVariant39 = strengthMovementVariant39;
            StrengthMovementVariant40 = strengthMovementVariant40;
            StrengthMovementVariant41 = strengthMovementVariant41;
            StrengthMovementVariant42 = strengthMovementVariant42;
            StrengthMovementVariant43 = strengthMovementVariant43;
            StrengthMovementVariant44 = strengthMovementVariant44;
            StrengthMovementVariant45 = strengthMovementVariant45;
            StrengthMovementVariant46 = strengthMovementVariant46;
            StrengthMovementVariant47 = strengthMovementVariant47;
            StrengthMovementVariant48 = strengthMovementVariant48;
            StrengthMovementVariant49 = strengthMovementVariant49;
            StrengthMovementVariant50 = strengthMovementVariant50;
            StrengthMovementVariant51 = strengthMovementVariant51;
            StrengthMovementVariant52 = strengthMovementVariant52;
            StrengthMovementVariant53 = strengthMovementVariant53;
            StrengthMovementVariant54 = strengthMovementVariant54;
            StrengthMovementVariant55 = strengthMovementVariant55;
            StrengthMovementVariant56 = strengthMovementVariant56;
            StrengthMovementVariant57 = strengthMovementVariant57;
            StrengthMovementVariant58 = strengthMovementVariant58;
            StrengthMovementVariant59 = strengthMovementVariant59;
            StrengthMovementVariant60 = strengthMovementVariant60;
            StrengthMovementVariant61 = strengthMovementVariant61;
            StrengthMovementVariant62 = strengthMovementVariant62;
            StrengthMovementVariant63 = strengthMovementVariant63;
            StrengthMovementVariant64 = strengthMovementVariant64;
            StrengthMovementVariant65 = strengthMovementVariant65;
            StrengthMovementVariant66 = strengthMovementVariant66;
            StrengthMovementVariant67 = strengthMovementVariant67;
            StrengthMovementVariant68 = strengthMovementVariant68;
            StrengthMovementVariant69 = strengthMovementVariant69;
            StrengthMovementVariant70 = strengthMovementVariant70;
            StrengthMovementVariant71 = strengthMovementVariant71;
            StrengthMovementVariant72 = strengthMovementVariant72;
            StrengthMovementVariant73 = strengthMovementVariant73;
            StrengthMovementVariant74 = strengthMovementVariant74;
            StrengthMovementVariant75 = strengthMovementVariant75;
            StrengthMovementVariant76 = strengthMovementVariant76;
            StrengthMovementVariant77 = strengthMovementVariant77;
            StrengthMovementVariant78 = strengthMovementVariant78;
            StrengthMovementVariant79 = strengthMovementVariant79;
            StrengthMovementVariant80 = strengthMovementVariant80;
            StrengthMovementVariant81 = strengthMovementVariant81;
            StrengthMovementVariant82 = strengthMovementVariant82;
            StrengthMovementVariant83 = strengthMovementVariant83;
            StrengthMovementVariant84 = strengthMovementVariant84;
            StrengthMovementVariant85 = strengthMovementVariant85;
            StrengthMovementVariant86 = strengthMovementVariant86;
            StrengthMovementVariant87 = strengthMovementVariant87;
            StrengthMovementVariant88 = strengthMovementVariant88;
            StrengthMovementVariant89 = strengthMovementVariant89;
            StrengthMovementVariant90 = strengthMovementVariant90;
            StrengthMovementVariant91 = strengthMovementVariant91;
            StrengthMovementVariant92 = strengthMovementVariant92;
            StrengthMovementVariant93 = strengthMovementVariant93;
            StrengthMovementVariant94 = strengthMovementVariant94;
            StrengthMovementVariant95 = strengthMovementVariant95;
            StrengthMovementVariant96 = strengthMovementVariant96;
            StrengthMovementVariant97 = strengthMovementVariant97;
            StrengthMovementVariant98 = strengthMovementVariant98;
            StrengthMovementVariant99 = strengthMovementVariant99;
            StrengthMovementVariant100 = strengthMovementVariant100;
            StrengthMovementVariant101 = strengthMovementVariant101;
            StrengthMovementVariant102 = strengthMovementVariant102;
            StrengthMovementVariant103 = strengthMovementVariant103;
            StrengthMovementVariant104 = strengthMovementVariant104;
            StrengthMovementVariant105 = strengthMovementVariant105;
            StrengthMovementVariant106 = strengthMovementVariant106;
            StrengthMovementVariant107 = strengthMovementVariant107;
            StrengthMovementVariant108 = strengthMovementVariant108;
            StrengthMovementVariant109 = strengthMovementVariant109;
            StrengthMovementVariant110 = strengthMovementVariant110;
            StrengthMovementVariant111 = strengthMovementVariant111;
            StrengthMovementVariant112 = strengthMovementVariant112;
            StrengthMovementVariant113 = strengthMovementVariant113;
            StrengthMovementVariant114 = strengthMovementVariant114;
            StrengthMovementVariant115 = strengthMovementVariant115;
            StrengthMovementVariant116 = strengthMovementVariant116;
            StrengthMovementVariant117 = strengthMovementVariant117;
            StrengthMovementVariant118 = strengthMovementVariant118;
            StrengthMovementVariant119 = strengthMovementVariant119;
            StrengthMovementVariant120 = strengthMovementVariant120;
            StrengthMovementVariant121 = strengthMovementVariant121;
            StrengthMovementVariant122 = strengthMovementVariant122;
            StrengthMovementVariant123 = strengthMovementVariant123;
            StrengthMovementVariant124 = strengthMovementVariant124;
            StrengthMovementVariant125 = strengthMovementVariant125;
            StrengthMovementVariant126 = strengthMovementVariant126;
            StrengthMovementVariant127 = strengthMovementVariant127;
            StrengthMovementVariant128 = strengthMovementVariant128;
            StrengthMovementVariant129 = strengthMovementVariant129;
            StrengthMovementVariant130 = strengthMovementVariant130;
            StrengthMovementVariant131 = strengthMovementVariant131;
            StrengthMovementVariant132 = strengthMovementVariant132;
            StrengthMovementVariant133 = strengthMovementVariant133;
            StrengthMovementVariant134 = strengthMovementVariant134;
            StrengthMovementVariant135 = strengthMovementVariant135;
            StrengthMovementVariant136 = strengthMovementVariant136;
            StrengthMovementVariant137 = strengthMovementVariant137;
            StrengthMovementVariant138 = strengthMovementVariant138;
            StrengthMovementVariant139 = strengthMovementVariant139;
            StrengthMovementVariant140 = strengthMovementVariant140;
            StrengthMovementVariant141 = strengthMovementVariant141;
            StrengthMovementVariant142 = strengthMovementVariant142;
            StrengthMovementVariant143 = strengthMovementVariant143;
            StrengthMovementVariant144 = strengthMovementVariant144;
            StrengthMovementVariant145 = strengthMovementVariant145;
            StrengthMovementVariant146 = strengthMovementVariant146;
            StrengthMovementVariant147 = strengthMovementVariant147;
            StrengthMovementVariant148 = strengthMovementVariant148;
            StrengthMovementVariant149 = strengthMovementVariant149;
            StrengthMovementVariant150 = strengthMovementVariant150;
            StrengthMovementVariant151 = strengthMovementVariant151;
            StrengthMovementVariant152 = strengthMovementVariant152;
            StrengthMovementVariant153 = strengthMovementVariant153;
            StrengthMovementVariant154 = strengthMovementVariant154;
            StrengthMovementVariant155 = strengthMovementVariant155;
            StrengthMovementVariant156 = strengthMovementVariant156;
            StrengthMovementVariant157 = strengthMovementVariant157;
            StrengthMovementVariant158 = strengthMovementVariant158;
            StrengthMovementVariant159 = strengthMovementVariant159;
            StrengthMovementVariant160 = strengthMovementVariant160;
            StrengthMovementVariant161 = strengthMovementVariant161;
            StrengthMovementVariant162 = strengthMovementVariant162;
            StrengthMovementVariant163 = strengthMovementVariant163;
            StrengthMovementVariant164 = strengthMovementVariant164;
            StrengthMovementVariant165 = strengthMovementVariant165;
            StrengthMovementVariant166 = strengthMovementVariant166;
            StrengthMovementVariant167 = strengthMovementVariant167;
            StrengthMovementVariant168 = strengthMovementVariant168;
            StrengthMovementVariant169 = strengthMovementVariant169;
            StrengthMovementVariant170 = strengthMovementVariant170;
            StrengthMovementVariant171 = strengthMovementVariant171;
            StrengthMovementVariant172 = strengthMovementVariant172;
            StrengthMovementVariant173 = strengthMovementVariant173;
            StrengthMovementVariant174 = strengthMovementVariant174;
            StrengthMovementVariant175 = strengthMovementVariant175;
            StrengthMovementVariant176 = strengthMovementVariant176;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthMovementVariant176 as object ??
            StrengthMovementVariant175 as object ??
            StrengthMovementVariant174 as object ??
            StrengthMovementVariant173 as object ??
            StrengthMovementVariant172 as object ??
            StrengthMovementVariant171 as object ??
            StrengthMovementVariant170 as object ??
            StrengthMovementVariant169 as object ??
            StrengthMovementVariant168 as object ??
            StrengthMovementVariant167 as object ??
            StrengthMovementVariant166 as object ??
            StrengthMovementVariant165 as object ??
            StrengthMovementVariant164 as object ??
            StrengthMovementVariant163 as object ??
            StrengthMovementVariant162 as object ??
            StrengthMovementVariant161 as object ??
            StrengthMovementVariant160 as object ??
            StrengthMovementVariant159 as object ??
            StrengthMovementVariant158 as object ??
            StrengthMovementVariant157 as object ??
            StrengthMovementVariant156 as object ??
            StrengthMovementVariant155 as object ??
            StrengthMovementVariant154 as object ??
            StrengthMovementVariant153 as object ??
            StrengthMovementVariant152 as object ??
            StrengthMovementVariant151 as object ??
            StrengthMovementVariant150 as object ??
            StrengthMovementVariant149 as object ??
            StrengthMovementVariant148 as object ??
            StrengthMovementVariant147 as object ??
            StrengthMovementVariant146 as object ??
            StrengthMovementVariant145 as object ??
            StrengthMovementVariant144 as object ??
            StrengthMovementVariant143 as object ??
            StrengthMovementVariant142 as object ??
            StrengthMovementVariant141 as object ??
            StrengthMovementVariant140 as object ??
            StrengthMovementVariant139 as object ??
            StrengthMovementVariant138 as object ??
            StrengthMovementVariant137 as object ??
            StrengthMovementVariant136 as object ??
            StrengthMovementVariant135 as object ??
            StrengthMovementVariant134 as object ??
            StrengthMovementVariant133 as object ??
            StrengthMovementVariant132 as object ??
            StrengthMovementVariant131 as object ??
            StrengthMovementVariant130 as object ??
            StrengthMovementVariant129 as object ??
            StrengthMovementVariant128 as object ??
            StrengthMovementVariant127 as object ??
            StrengthMovementVariant126 as object ??
            StrengthMovementVariant125 as object ??
            StrengthMovementVariant124 as object ??
            StrengthMovementVariant123 as object ??
            StrengthMovementVariant122 as object ??
            StrengthMovementVariant121 as object ??
            StrengthMovementVariant120 as object ??
            StrengthMovementVariant119 as object ??
            StrengthMovementVariant118 as object ??
            StrengthMovementVariant117 as object ??
            StrengthMovementVariant116 as object ??
            StrengthMovementVariant115 as object ??
            StrengthMovementVariant114 as object ??
            StrengthMovementVariant113 as object ??
            StrengthMovementVariant112 as object ??
            StrengthMovementVariant111 as object ??
            StrengthMovementVariant110 as object ??
            StrengthMovementVariant109 as object ??
            StrengthMovementVariant108 as object ??
            StrengthMovementVariant107 as object ??
            StrengthMovementVariant106 as object ??
            StrengthMovementVariant105 as object ??
            StrengthMovementVariant104 as object ??
            StrengthMovementVariant103 as object ??
            StrengthMovementVariant102 as object ??
            StrengthMovementVariant101 as object ??
            StrengthMovementVariant100 as object ??
            StrengthMovementVariant99 as object ??
            StrengthMovementVariant98 as object ??
            StrengthMovementVariant97 as object ??
            StrengthMovementVariant96 as object ??
            StrengthMovementVariant95 as object ??
            StrengthMovementVariant94 as object ??
            StrengthMovementVariant93 as object ??
            StrengthMovementVariant92 as object ??
            StrengthMovementVariant91 as object ??
            StrengthMovementVariant90 as object ??
            StrengthMovementVariant89 as object ??
            StrengthMovementVariant88 as object ??
            StrengthMovementVariant87 as object ??
            StrengthMovementVariant86 as object ??
            StrengthMovementVariant85 as object ??
            StrengthMovementVariant84 as object ??
            StrengthMovementVariant83 as object ??
            StrengthMovementVariant82 as object ??
            StrengthMovementVariant81 as object ??
            StrengthMovementVariant80 as object ??
            StrengthMovementVariant79 as object ??
            StrengthMovementVariant78 as object ??
            StrengthMovementVariant77 as object ??
            StrengthMovementVariant76 as object ??
            StrengthMovementVariant75 as object ??
            StrengthMovementVariant74 as object ??
            StrengthMovementVariant73 as object ??
            StrengthMovementVariant72 as object ??
            StrengthMovementVariant71 as object ??
            StrengthMovementVariant70 as object ??
            StrengthMovementVariant69 as object ??
            StrengthMovementVariant68 as object ??
            StrengthMovementVariant67 as object ??
            StrengthMovementVariant66 as object ??
            StrengthMovementVariant65 as object ??
            StrengthMovementVariant64 as object ??
            StrengthMovementVariant63 as object ??
            StrengthMovementVariant62 as object ??
            StrengthMovementVariant61 as object ??
            StrengthMovementVariant60 as object ??
            StrengthMovementVariant59 as object ??
            StrengthMovementVariant58 as object ??
            StrengthMovementVariant57 as object ??
            StrengthMovementVariant56 as object ??
            StrengthMovementVariant55 as object ??
            StrengthMovementVariant54 as object ??
            StrengthMovementVariant53 as object ??
            StrengthMovementVariant52 as object ??
            StrengthMovementVariant51 as object ??
            StrengthMovementVariant50 as object ??
            StrengthMovementVariant49 as object ??
            StrengthMovementVariant48 as object ??
            StrengthMovementVariant47 as object ??
            StrengthMovementVariant46 as object ??
            StrengthMovementVariant45 as object ??
            StrengthMovementVariant44 as object ??
            StrengthMovementVariant43 as object ??
            StrengthMovementVariant42 as object ??
            StrengthMovementVariant41 as object ??
            StrengthMovementVariant40 as object ??
            StrengthMovementVariant39 as object ??
            StrengthMovementVariant38 as object ??
            StrengthMovementVariant37 as object ??
            StrengthMovementVariant36 as object ??
            StrengthMovementVariant35 as object ??
            StrengthMovementVariant34 as object ??
            StrengthMovementVariant33 as object ??
            StrengthMovementVariant32 as object ??
            StrengthMovementVariant31 as object ??
            StrengthMovementVariant30 as object ??
            StrengthMovementVariant29 as object ??
            StrengthMovementVariant28 as object ??
            StrengthMovementVariant27 as object ??
            StrengthMovementVariant26 as object ??
            StrengthMovementVariant25 as object ??
            StrengthMovementVariant24 as object ??
            StrengthMovementVariant23 as object ??
            StrengthMovementVariant22 as object ??
            StrengthMovementVariant21 as object ??
            StrengthMovementVariant20 as object ??
            StrengthMovementVariant19 as object ??
            StrengthMovementVariant18 as object ??
            StrengthMovementVariant17 as object ??
            StrengthMovementVariant16 as object ??
            StrengthMovementVariant15 as object ??
            StrengthMovementVariant14 as object ??
            StrengthMovementVariant13 as object ??
            StrengthMovementVariant12 as object ??
            StrengthMovementVariant11 as object ??
            StrengthMovementVariant10 as object ??
            StrengthMovementVariant9 as object ??
            StrengthMovementVariant8 as object ??
            StrengthMovementVariant7 as object ??
            StrengthMovementVariant6 as object ??
            StrengthMovementVariant5 as object ??
            StrengthMovementVariant4 as object ??
            StrengthMovementVariant3 as object ??
            StrengthMovementVariant2 as object ??
            StrengthMovementVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthMovementVariant1?.ToValueString() ??
            StrengthMovementVariant2?.ToValueString() ??
            StrengthMovementVariant3?.ToValueString() ??
            StrengthMovementVariant4?.ToValueString() ??
            StrengthMovementVariant5?.ToValueString() ??
            StrengthMovementVariant6?.ToValueString() ??
            StrengthMovementVariant7?.ToValueString() ??
            StrengthMovementVariant8?.ToValueString() ??
            StrengthMovementVariant9?.ToValueString() ??
            StrengthMovementVariant10?.ToValueString() ??
            StrengthMovementVariant11?.ToValueString() ??
            StrengthMovementVariant12?.ToValueString() ??
            StrengthMovementVariant13?.ToValueString() ??
            StrengthMovementVariant14?.ToValueString() ??
            StrengthMovementVariant15?.ToValueString() ??
            StrengthMovementVariant16?.ToValueString() ??
            StrengthMovementVariant17?.ToValueString() ??
            StrengthMovementVariant18?.ToValueString() ??
            StrengthMovementVariant19?.ToValueString() ??
            StrengthMovementVariant20?.ToValueString() ??
            StrengthMovementVariant21?.ToValueString() ??
            StrengthMovementVariant22?.ToValueString() ??
            StrengthMovementVariant23?.ToValueString() ??
            StrengthMovementVariant24?.ToValueString() ??
            StrengthMovementVariant25?.ToValueString() ??
            StrengthMovementVariant26?.ToValueString() ??
            StrengthMovementVariant27?.ToValueString() ??
            StrengthMovementVariant28?.ToValueString() ??
            StrengthMovementVariant29?.ToValueString() ??
            StrengthMovementVariant30?.ToValueString() ??
            StrengthMovementVariant31?.ToValueString() ??
            StrengthMovementVariant32?.ToValueString() ??
            StrengthMovementVariant33?.ToValueString() ??
            StrengthMovementVariant34?.ToValueString() ??
            StrengthMovementVariant35?.ToValueString() ??
            StrengthMovementVariant36?.ToValueString() ??
            StrengthMovementVariant37?.ToValueString() ??
            StrengthMovementVariant38?.ToValueString() ??
            StrengthMovementVariant39?.ToValueString() ??
            StrengthMovementVariant40?.ToValueString() ??
            StrengthMovementVariant41?.ToValueString() ??
            StrengthMovementVariant42?.ToValueString() ??
            StrengthMovementVariant43?.ToValueString() ??
            StrengthMovementVariant44?.ToValueString() ??
            StrengthMovementVariant45?.ToValueString() ??
            StrengthMovementVariant46?.ToValueString() ??
            StrengthMovementVariant47?.ToValueString() ??
            StrengthMovementVariant48?.ToValueString() ??
            StrengthMovementVariant49?.ToValueString() ??
            StrengthMovementVariant50?.ToValueString() ??
            StrengthMovementVariant51?.ToValueString() ??
            StrengthMovementVariant52?.ToValueString() ??
            StrengthMovementVariant53?.ToValueString() ??
            StrengthMovementVariant54?.ToValueString() ??
            StrengthMovementVariant55?.ToValueString() ??
            StrengthMovementVariant56?.ToValueString() ??
            StrengthMovementVariant57?.ToValueString() ??
            StrengthMovementVariant58?.ToValueString() ??
            StrengthMovementVariant59?.ToValueString() ??
            StrengthMovementVariant60?.ToValueString() ??
            StrengthMovementVariant61?.ToValueString() ??
            StrengthMovementVariant62?.ToValueString() ??
            StrengthMovementVariant63?.ToValueString() ??
            StrengthMovementVariant64?.ToValueString() ??
            StrengthMovementVariant65?.ToValueString() ??
            StrengthMovementVariant66?.ToValueString() ??
            StrengthMovementVariant67?.ToValueString() ??
            StrengthMovementVariant68?.ToValueString() ??
            StrengthMovementVariant69?.ToValueString() ??
            StrengthMovementVariant70?.ToValueString() ??
            StrengthMovementVariant71?.ToValueString() ??
            StrengthMovementVariant72?.ToValueString() ??
            StrengthMovementVariant73?.ToValueString() ??
            StrengthMovementVariant74?.ToValueString() ??
            StrengthMovementVariant75?.ToValueString() ??
            StrengthMovementVariant76?.ToValueString() ??
            StrengthMovementVariant77?.ToValueString() ??
            StrengthMovementVariant78?.ToValueString() ??
            StrengthMovementVariant79?.ToValueString() ??
            StrengthMovementVariant80?.ToValueString() ??
            StrengthMovementVariant81?.ToValueString() ??
            StrengthMovementVariant82?.ToValueString() ??
            StrengthMovementVariant83?.ToValueString() ??
            StrengthMovementVariant84?.ToValueString() ??
            StrengthMovementVariant85?.ToValueString() ??
            StrengthMovementVariant86?.ToValueString() ??
            StrengthMovementVariant87?.ToValueString() ??
            StrengthMovementVariant88?.ToValueString() ??
            StrengthMovementVariant89?.ToValueString() ??
            StrengthMovementVariant90?.ToValueString() ??
            StrengthMovementVariant91?.ToValueString() ??
            StrengthMovementVariant92?.ToValueString() ??
            StrengthMovementVariant93?.ToValueString() ??
            StrengthMovementVariant94?.ToValueString() ??
            StrengthMovementVariant95?.ToValueString() ??
            StrengthMovementVariant96?.ToValueString() ??
            StrengthMovementVariant97?.ToValueString() ??
            StrengthMovementVariant98?.ToValueString() ??
            StrengthMovementVariant99?.ToValueString() ??
            StrengthMovementVariant100?.ToValueString() ??
            StrengthMovementVariant101?.ToValueString() ??
            StrengthMovementVariant102?.ToValueString() ??
            StrengthMovementVariant103?.ToValueString() ??
            StrengthMovementVariant104?.ToValueString() ??
            StrengthMovementVariant105?.ToValueString() ??
            StrengthMovementVariant106?.ToValueString() ??
            StrengthMovementVariant107?.ToValueString() ??
            StrengthMovementVariant108?.ToValueString() ??
            StrengthMovementVariant109?.ToValueString() ??
            StrengthMovementVariant110?.ToValueString() ??
            StrengthMovementVariant111?.ToValueString() ??
            StrengthMovementVariant112?.ToValueString() ??
            StrengthMovementVariant113?.ToValueString() ??
            StrengthMovementVariant114?.ToValueString() ??
            StrengthMovementVariant115?.ToValueString() ??
            StrengthMovementVariant116?.ToValueString() ??
            StrengthMovementVariant117?.ToValueString() ??
            StrengthMovementVariant118?.ToValueString() ??
            StrengthMovementVariant119?.ToValueString() ??
            StrengthMovementVariant120?.ToValueString() ??
            StrengthMovementVariant121?.ToValueString() ??
            StrengthMovementVariant122?.ToValueString() ??
            StrengthMovementVariant123?.ToValueString() ??
            StrengthMovementVariant124?.ToValueString() ??
            StrengthMovementVariant125?.ToValueString() ??
            StrengthMovementVariant126?.ToValueString() ??
            StrengthMovementVariant127?.ToValueString() ??
            StrengthMovementVariant128?.ToValueString() ??
            StrengthMovementVariant129?.ToValueString() ??
            StrengthMovementVariant130?.ToValueString() ??
            StrengthMovementVariant131?.ToValueString() ??
            StrengthMovementVariant132?.ToValueString() ??
            StrengthMovementVariant133?.ToValueString() ??
            StrengthMovementVariant134?.ToValueString() ??
            StrengthMovementVariant135?.ToValueString() ??
            StrengthMovementVariant136?.ToValueString() ??
            StrengthMovementVariant137?.ToValueString() ??
            StrengthMovementVariant138?.ToValueString() ??
            StrengthMovementVariant139?.ToValueString() ??
            StrengthMovementVariant140?.ToValueString() ??
            StrengthMovementVariant141?.ToValueString() ??
            StrengthMovementVariant142?.ToValueString() ??
            StrengthMovementVariant143?.ToValueString() ??
            StrengthMovementVariant144?.ToValueString() ??
            StrengthMovementVariant145?.ToValueString() ??
            StrengthMovementVariant146?.ToValueString() ??
            StrengthMovementVariant147?.ToValueString() ??
            StrengthMovementVariant148?.ToValueString() ??
            StrengthMovementVariant149?.ToValueString() ??
            StrengthMovementVariant150?.ToValueString() ??
            StrengthMovementVariant151?.ToValueString() ??
            StrengthMovementVariant152?.ToValueString() ??
            StrengthMovementVariant153?.ToValueString() ??
            StrengthMovementVariant154?.ToValueString() ??
            StrengthMovementVariant155?.ToValueString() ??
            StrengthMovementVariant156?.ToValueString() ??
            StrengthMovementVariant157?.ToValueString() ??
            StrengthMovementVariant158?.ToValueString() ??
            StrengthMovementVariant159?.ToValueString() ??
            StrengthMovementVariant160?.ToValueString() ??
            StrengthMovementVariant161?.ToValueString() ??
            StrengthMovementVariant162?.ToValueString() ??
            StrengthMovementVariant163?.ToValueString() ??
            StrengthMovementVariant164?.ToValueString() ??
            StrengthMovementVariant165?.ToValueString() ??
            StrengthMovementVariant166?.ToValueString() ??
            StrengthMovementVariant167?.ToValueString() ??
            StrengthMovementVariant168?.ToValueString() ??
            StrengthMovementVariant169?.ToValueString() ??
            StrengthMovementVariant170?.ToValueString() ??
            StrengthMovementVariant171?.ToValueString() ??
            StrengthMovementVariant172?.ToValueString() ??
            StrengthMovementVariant173?.ToValueString() ??
            StrengthMovementVariant174?.ToValueString() ??
            StrengthMovementVariant175?.ToValueString() ??
            StrengthMovementVariant176?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthMovementVariant1 || IsStrengthMovementVariant2 || IsStrengthMovementVariant3 || IsStrengthMovementVariant4 || IsStrengthMovementVariant5 || IsStrengthMovementVariant6 || IsStrengthMovementVariant7 || IsStrengthMovementVariant8 || IsStrengthMovementVariant9 || IsStrengthMovementVariant10 || IsStrengthMovementVariant11 || IsStrengthMovementVariant12 || IsStrengthMovementVariant13 || IsStrengthMovementVariant14 || IsStrengthMovementVariant15 || IsStrengthMovementVariant16 || IsStrengthMovementVariant17 || IsStrengthMovementVariant18 || IsStrengthMovementVariant19 || IsStrengthMovementVariant20 || IsStrengthMovementVariant21 || IsStrengthMovementVariant22 || IsStrengthMovementVariant23 || IsStrengthMovementVariant24 || IsStrengthMovementVariant25 || IsStrengthMovementVariant26 || IsStrengthMovementVariant27 || IsStrengthMovementVariant28 || IsStrengthMovementVariant29 || IsStrengthMovementVariant30 || IsStrengthMovementVariant31 || IsStrengthMovementVariant32 || IsStrengthMovementVariant33 || IsStrengthMovementVariant34 || IsStrengthMovementVariant35 || IsStrengthMovementVariant36 || IsStrengthMovementVariant37 || IsStrengthMovementVariant38 || IsStrengthMovementVariant39 || IsStrengthMovementVariant40 || IsStrengthMovementVariant41 || IsStrengthMovementVariant42 || IsStrengthMovementVariant43 || IsStrengthMovementVariant44 || IsStrengthMovementVariant45 || IsStrengthMovementVariant46 || IsStrengthMovementVariant47 || IsStrengthMovementVariant48 || IsStrengthMovementVariant49 || IsStrengthMovementVariant50 || IsStrengthMovementVariant51 || IsStrengthMovementVariant52 || IsStrengthMovementVariant53 || IsStrengthMovementVariant54 || IsStrengthMovementVariant55 || IsStrengthMovementVariant56 || IsStrengthMovementVariant57 || IsStrengthMovementVariant58 || IsStrengthMovementVariant59 || IsStrengthMovementVariant60 || IsStrengthMovementVariant61 || IsStrengthMovementVariant62 || IsStrengthMovementVariant63 || IsStrengthMovementVariant64 || IsStrengthMovementVariant65 || IsStrengthMovementVariant66 || IsStrengthMovementVariant67 || IsStrengthMovementVariant68 || IsStrengthMovementVariant69 || IsStrengthMovementVariant70 || IsStrengthMovementVariant71 || IsStrengthMovementVariant72 || IsStrengthMovementVariant73 || IsStrengthMovementVariant74 || IsStrengthMovementVariant75 || IsStrengthMovementVariant76 || IsStrengthMovementVariant77 || IsStrengthMovementVariant78 || IsStrengthMovementVariant79 || IsStrengthMovementVariant80 || IsStrengthMovementVariant81 || IsStrengthMovementVariant82 || IsStrengthMovementVariant83 || IsStrengthMovementVariant84 || IsStrengthMovementVariant85 || IsStrengthMovementVariant86 || IsStrengthMovementVariant87 || IsStrengthMovementVariant88 || IsStrengthMovementVariant89 || IsStrengthMovementVariant90 || IsStrengthMovementVariant91 || IsStrengthMovementVariant92 || IsStrengthMovementVariant93 || IsStrengthMovementVariant94 || IsStrengthMovementVariant95 || IsStrengthMovementVariant96 || IsStrengthMovementVariant97 || IsStrengthMovementVariant98 || IsStrengthMovementVariant99 || IsStrengthMovementVariant100 || IsStrengthMovementVariant101 || IsStrengthMovementVariant102 || IsStrengthMovementVariant103 || IsStrengthMovementVariant104 || IsStrengthMovementVariant105 || IsStrengthMovementVariant106 || IsStrengthMovementVariant107 || IsStrengthMovementVariant108 || IsStrengthMovementVariant109 || IsStrengthMovementVariant110 || IsStrengthMovementVariant111 || IsStrengthMovementVariant112 || IsStrengthMovementVariant113 || IsStrengthMovementVariant114 || IsStrengthMovementVariant115 || IsStrengthMovementVariant116 || IsStrengthMovementVariant117 || IsStrengthMovementVariant118 || IsStrengthMovementVariant119 || IsStrengthMovementVariant120 || IsStrengthMovementVariant121 || IsStrengthMovementVariant122 || IsStrengthMovementVariant123 || IsStrengthMovementVariant124 || IsStrengthMovementVariant125 || IsStrengthMovementVariant126 || IsStrengthMovementVariant127 || IsStrengthMovementVariant128 || IsStrengthMovementVariant129 || IsStrengthMovementVariant130 || IsStrengthMovementVariant131 || IsStrengthMovementVariant132 || IsStrengthMovementVariant133 || IsStrengthMovementVariant134 || IsStrengthMovementVariant135 || IsStrengthMovementVariant136 || IsStrengthMovementVariant137 || IsStrengthMovementVariant138 || IsStrengthMovementVariant139 || IsStrengthMovementVariant140 || IsStrengthMovementVariant141 || IsStrengthMovementVariant142 || IsStrengthMovementVariant143 || IsStrengthMovementVariant144 || IsStrengthMovementVariant145 || IsStrengthMovementVariant146 || IsStrengthMovementVariant147 || IsStrengthMovementVariant148 || IsStrengthMovementVariant149 || IsStrengthMovementVariant150 || IsStrengthMovementVariant151 || IsStrengthMovementVariant152 || IsStrengthMovementVariant153 || IsStrengthMovementVariant154 || IsStrengthMovementVariant155 || IsStrengthMovementVariant156 || IsStrengthMovementVariant157 || IsStrengthMovementVariant158 || IsStrengthMovementVariant159 || IsStrengthMovementVariant160 || IsStrengthMovementVariant161 || IsStrengthMovementVariant162 || IsStrengthMovementVariant163 || IsStrengthMovementVariant164 || IsStrengthMovementVariant165 || IsStrengthMovementVariant166 || IsStrengthMovementVariant167 || IsStrengthMovementVariant168 || IsStrengthMovementVariant169 || IsStrengthMovementVariant170 || IsStrengthMovementVariant171 || IsStrengthMovementVariant172 || IsStrengthMovementVariant173 || IsStrengthMovementVariant174 || IsStrengthMovementVariant175 || IsStrengthMovementVariant176;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthMovementVariant1?, TResult>? strengthMovementVariant1 = null,
            global::System.Func<global::Terra.StrengthMovementVariant2?, TResult>? strengthMovementVariant2 = null,
            global::System.Func<global::Terra.StrengthMovementVariant3?, TResult>? strengthMovementVariant3 = null,
            global::System.Func<global::Terra.StrengthMovementVariant4?, TResult>? strengthMovementVariant4 = null,
            global::System.Func<global::Terra.StrengthMovementVariant5?, TResult>? strengthMovementVariant5 = null,
            global::System.Func<global::Terra.StrengthMovementVariant6?, TResult>? strengthMovementVariant6 = null,
            global::System.Func<global::Terra.StrengthMovementVariant7?, TResult>? strengthMovementVariant7 = null,
            global::System.Func<global::Terra.StrengthMovementVariant8?, TResult>? strengthMovementVariant8 = null,
            global::System.Func<global::Terra.StrengthMovementVariant9?, TResult>? strengthMovementVariant9 = null,
            global::System.Func<global::Terra.StrengthMovementVariant10?, TResult>? strengthMovementVariant10 = null,
            global::System.Func<global::Terra.StrengthMovementVariant11?, TResult>? strengthMovementVariant11 = null,
            global::System.Func<global::Terra.StrengthMovementVariant12?, TResult>? strengthMovementVariant12 = null,
            global::System.Func<global::Terra.StrengthMovementVariant13?, TResult>? strengthMovementVariant13 = null,
            global::System.Func<global::Terra.StrengthMovementVariant14?, TResult>? strengthMovementVariant14 = null,
            global::System.Func<global::Terra.StrengthMovementVariant15?, TResult>? strengthMovementVariant15 = null,
            global::System.Func<global::Terra.StrengthMovementVariant16?, TResult>? strengthMovementVariant16 = null,
            global::System.Func<global::Terra.StrengthMovementVariant17?, TResult>? strengthMovementVariant17 = null,
            global::System.Func<global::Terra.StrengthMovementVariant18?, TResult>? strengthMovementVariant18 = null,
            global::System.Func<global::Terra.StrengthMovementVariant19?, TResult>? strengthMovementVariant19 = null,
            global::System.Func<global::Terra.StrengthMovementVariant20?, TResult>? strengthMovementVariant20 = null,
            global::System.Func<global::Terra.StrengthMovementVariant21?, TResult>? strengthMovementVariant21 = null,
            global::System.Func<global::Terra.StrengthMovementVariant22?, TResult>? strengthMovementVariant22 = null,
            global::System.Func<global::Terra.StrengthMovementVariant23?, TResult>? strengthMovementVariant23 = null,
            global::System.Func<global::Terra.StrengthMovementVariant24?, TResult>? strengthMovementVariant24 = null,
            global::System.Func<global::Terra.StrengthMovementVariant25?, TResult>? strengthMovementVariant25 = null,
            global::System.Func<global::Terra.StrengthMovementVariant26?, TResult>? strengthMovementVariant26 = null,
            global::System.Func<global::Terra.StrengthMovementVariant27?, TResult>? strengthMovementVariant27 = null,
            global::System.Func<global::Terra.StrengthMovementVariant28?, TResult>? strengthMovementVariant28 = null,
            global::System.Func<global::Terra.StrengthMovementVariant29?, TResult>? strengthMovementVariant29 = null,
            global::System.Func<global::Terra.StrengthMovementVariant30?, TResult>? strengthMovementVariant30 = null,
            global::System.Func<global::Terra.StrengthMovementVariant31?, TResult>? strengthMovementVariant31 = null,
            global::System.Func<global::Terra.StrengthMovementVariant32?, TResult>? strengthMovementVariant32 = null,
            global::System.Func<global::Terra.StrengthMovementVariant33?, TResult>? strengthMovementVariant33 = null,
            global::System.Func<global::Terra.StrengthMovementVariant34?, TResult>? strengthMovementVariant34 = null,
            global::System.Func<global::Terra.StrengthMovementVariant35?, TResult>? strengthMovementVariant35 = null,
            global::System.Func<global::Terra.StrengthMovementVariant36?, TResult>? strengthMovementVariant36 = null,
            global::System.Func<global::Terra.StrengthMovementVariant37?, TResult>? strengthMovementVariant37 = null,
            global::System.Func<global::Terra.StrengthMovementVariant38?, TResult>? strengthMovementVariant38 = null,
            global::System.Func<global::Terra.StrengthMovementVariant39?, TResult>? strengthMovementVariant39 = null,
            global::System.Func<global::Terra.StrengthMovementVariant40?, TResult>? strengthMovementVariant40 = null,
            global::System.Func<global::Terra.StrengthMovementVariant41?, TResult>? strengthMovementVariant41 = null,
            global::System.Func<global::Terra.StrengthMovementVariant42?, TResult>? strengthMovementVariant42 = null,
            global::System.Func<global::Terra.StrengthMovementVariant43?, TResult>? strengthMovementVariant43 = null,
            global::System.Func<global::Terra.StrengthMovementVariant44?, TResult>? strengthMovementVariant44 = null,
            global::System.Func<global::Terra.StrengthMovementVariant45?, TResult>? strengthMovementVariant45 = null,
            global::System.Func<global::Terra.StrengthMovementVariant46?, TResult>? strengthMovementVariant46 = null,
            global::System.Func<global::Terra.StrengthMovementVariant47?, TResult>? strengthMovementVariant47 = null,
            global::System.Func<global::Terra.StrengthMovementVariant48?, TResult>? strengthMovementVariant48 = null,
            global::System.Func<global::Terra.StrengthMovementVariant49?, TResult>? strengthMovementVariant49 = null,
            global::System.Func<global::Terra.StrengthMovementVariant50?, TResult>? strengthMovementVariant50 = null,
            global::System.Func<global::Terra.StrengthMovementVariant51?, TResult>? strengthMovementVariant51 = null,
            global::System.Func<global::Terra.StrengthMovementVariant52?, TResult>? strengthMovementVariant52 = null,
            global::System.Func<global::Terra.StrengthMovementVariant53?, TResult>? strengthMovementVariant53 = null,
            global::System.Func<global::Terra.StrengthMovementVariant54?, TResult>? strengthMovementVariant54 = null,
            global::System.Func<global::Terra.StrengthMovementVariant55?, TResult>? strengthMovementVariant55 = null,
            global::System.Func<global::Terra.StrengthMovementVariant56?, TResult>? strengthMovementVariant56 = null,
            global::System.Func<global::Terra.StrengthMovementVariant57?, TResult>? strengthMovementVariant57 = null,
            global::System.Func<global::Terra.StrengthMovementVariant58?, TResult>? strengthMovementVariant58 = null,
            global::System.Func<global::Terra.StrengthMovementVariant59?, TResult>? strengthMovementVariant59 = null,
            global::System.Func<global::Terra.StrengthMovementVariant60?, TResult>? strengthMovementVariant60 = null,
            global::System.Func<global::Terra.StrengthMovementVariant61?, TResult>? strengthMovementVariant61 = null,
            global::System.Func<global::Terra.StrengthMovementVariant62?, TResult>? strengthMovementVariant62 = null,
            global::System.Func<global::Terra.StrengthMovementVariant63?, TResult>? strengthMovementVariant63 = null,
            global::System.Func<global::Terra.StrengthMovementVariant64?, TResult>? strengthMovementVariant64 = null,
            global::System.Func<global::Terra.StrengthMovementVariant65?, TResult>? strengthMovementVariant65 = null,
            global::System.Func<global::Terra.StrengthMovementVariant66?, TResult>? strengthMovementVariant66 = null,
            global::System.Func<global::Terra.StrengthMovementVariant67?, TResult>? strengthMovementVariant67 = null,
            global::System.Func<global::Terra.StrengthMovementVariant68?, TResult>? strengthMovementVariant68 = null,
            global::System.Func<global::Terra.StrengthMovementVariant69?, TResult>? strengthMovementVariant69 = null,
            global::System.Func<global::Terra.StrengthMovementVariant70?, TResult>? strengthMovementVariant70 = null,
            global::System.Func<global::Terra.StrengthMovementVariant71?, TResult>? strengthMovementVariant71 = null,
            global::System.Func<global::Terra.StrengthMovementVariant72?, TResult>? strengthMovementVariant72 = null,
            global::System.Func<global::Terra.StrengthMovementVariant73?, TResult>? strengthMovementVariant73 = null,
            global::System.Func<global::Terra.StrengthMovementVariant74?, TResult>? strengthMovementVariant74 = null,
            global::System.Func<global::Terra.StrengthMovementVariant75?, TResult>? strengthMovementVariant75 = null,
            global::System.Func<global::Terra.StrengthMovementVariant76?, TResult>? strengthMovementVariant76 = null,
            global::System.Func<global::Terra.StrengthMovementVariant77?, TResult>? strengthMovementVariant77 = null,
            global::System.Func<global::Terra.StrengthMovementVariant78?, TResult>? strengthMovementVariant78 = null,
            global::System.Func<global::Terra.StrengthMovementVariant79?, TResult>? strengthMovementVariant79 = null,
            global::System.Func<global::Terra.StrengthMovementVariant80?, TResult>? strengthMovementVariant80 = null,
            global::System.Func<global::Terra.StrengthMovementVariant81?, TResult>? strengthMovementVariant81 = null,
            global::System.Func<global::Terra.StrengthMovementVariant82?, TResult>? strengthMovementVariant82 = null,
            global::System.Func<global::Terra.StrengthMovementVariant83?, TResult>? strengthMovementVariant83 = null,
            global::System.Func<global::Terra.StrengthMovementVariant84?, TResult>? strengthMovementVariant84 = null,
            global::System.Func<global::Terra.StrengthMovementVariant85?, TResult>? strengthMovementVariant85 = null,
            global::System.Func<global::Terra.StrengthMovementVariant86?, TResult>? strengthMovementVariant86 = null,
            global::System.Func<global::Terra.StrengthMovementVariant87?, TResult>? strengthMovementVariant87 = null,
            global::System.Func<global::Terra.StrengthMovementVariant88?, TResult>? strengthMovementVariant88 = null,
            global::System.Func<global::Terra.StrengthMovementVariant89?, TResult>? strengthMovementVariant89 = null,
            global::System.Func<global::Terra.StrengthMovementVariant90?, TResult>? strengthMovementVariant90 = null,
            global::System.Func<global::Terra.StrengthMovementVariant91?, TResult>? strengthMovementVariant91 = null,
            global::System.Func<global::Terra.StrengthMovementVariant92?, TResult>? strengthMovementVariant92 = null,
            global::System.Func<global::Terra.StrengthMovementVariant93?, TResult>? strengthMovementVariant93 = null,
            global::System.Func<global::Terra.StrengthMovementVariant94?, TResult>? strengthMovementVariant94 = null,
            global::System.Func<global::Terra.StrengthMovementVariant95?, TResult>? strengthMovementVariant95 = null,
            global::System.Func<global::Terra.StrengthMovementVariant96?, TResult>? strengthMovementVariant96 = null,
            global::System.Func<global::Terra.StrengthMovementVariant97?, TResult>? strengthMovementVariant97 = null,
            global::System.Func<global::Terra.StrengthMovementVariant98?, TResult>? strengthMovementVariant98 = null,
            global::System.Func<global::Terra.StrengthMovementVariant99?, TResult>? strengthMovementVariant99 = null,
            global::System.Func<global::Terra.StrengthMovementVariant100?, TResult>? strengthMovementVariant100 = null,
            global::System.Func<global::Terra.StrengthMovementVariant101?, TResult>? strengthMovementVariant101 = null,
            global::System.Func<global::Terra.StrengthMovementVariant102?, TResult>? strengthMovementVariant102 = null,
            global::System.Func<global::Terra.StrengthMovementVariant103?, TResult>? strengthMovementVariant103 = null,
            global::System.Func<global::Terra.StrengthMovementVariant104?, TResult>? strengthMovementVariant104 = null,
            global::System.Func<global::Terra.StrengthMovementVariant105?, TResult>? strengthMovementVariant105 = null,
            global::System.Func<global::Terra.StrengthMovementVariant106?, TResult>? strengthMovementVariant106 = null,
            global::System.Func<global::Terra.StrengthMovementVariant107?, TResult>? strengthMovementVariant107 = null,
            global::System.Func<global::Terra.StrengthMovementVariant108?, TResult>? strengthMovementVariant108 = null,
            global::System.Func<global::Terra.StrengthMovementVariant109?, TResult>? strengthMovementVariant109 = null,
            global::System.Func<global::Terra.StrengthMovementVariant110?, TResult>? strengthMovementVariant110 = null,
            global::System.Func<global::Terra.StrengthMovementVariant111?, TResult>? strengthMovementVariant111 = null,
            global::System.Func<global::Terra.StrengthMovementVariant112?, TResult>? strengthMovementVariant112 = null,
            global::System.Func<global::Terra.StrengthMovementVariant113?, TResult>? strengthMovementVariant113 = null,
            global::System.Func<global::Terra.StrengthMovementVariant114?, TResult>? strengthMovementVariant114 = null,
            global::System.Func<global::Terra.StrengthMovementVariant115?, TResult>? strengthMovementVariant115 = null,
            global::System.Func<global::Terra.StrengthMovementVariant116?, TResult>? strengthMovementVariant116 = null,
            global::System.Func<global::Terra.StrengthMovementVariant117?, TResult>? strengthMovementVariant117 = null,
            global::System.Func<global::Terra.StrengthMovementVariant118?, TResult>? strengthMovementVariant118 = null,
            global::System.Func<global::Terra.StrengthMovementVariant119?, TResult>? strengthMovementVariant119 = null,
            global::System.Func<global::Terra.StrengthMovementVariant120?, TResult>? strengthMovementVariant120 = null,
            global::System.Func<global::Terra.StrengthMovementVariant121?, TResult>? strengthMovementVariant121 = null,
            global::System.Func<global::Terra.StrengthMovementVariant122?, TResult>? strengthMovementVariant122 = null,
            global::System.Func<global::Terra.StrengthMovementVariant123?, TResult>? strengthMovementVariant123 = null,
            global::System.Func<global::Terra.StrengthMovementVariant124?, TResult>? strengthMovementVariant124 = null,
            global::System.Func<global::Terra.StrengthMovementVariant125?, TResult>? strengthMovementVariant125 = null,
            global::System.Func<global::Terra.StrengthMovementVariant126?, TResult>? strengthMovementVariant126 = null,
            global::System.Func<global::Terra.StrengthMovementVariant127?, TResult>? strengthMovementVariant127 = null,
            global::System.Func<global::Terra.StrengthMovementVariant128?, TResult>? strengthMovementVariant128 = null,
            global::System.Func<global::Terra.StrengthMovementVariant129?, TResult>? strengthMovementVariant129 = null,
            global::System.Func<global::Terra.StrengthMovementVariant130?, TResult>? strengthMovementVariant130 = null,
            global::System.Func<global::Terra.StrengthMovementVariant131?, TResult>? strengthMovementVariant131 = null,
            global::System.Func<global::Terra.StrengthMovementVariant132?, TResult>? strengthMovementVariant132 = null,
            global::System.Func<global::Terra.StrengthMovementVariant133?, TResult>? strengthMovementVariant133 = null,
            global::System.Func<global::Terra.StrengthMovementVariant134?, TResult>? strengthMovementVariant134 = null,
            global::System.Func<global::Terra.StrengthMovementVariant135?, TResult>? strengthMovementVariant135 = null,
            global::System.Func<global::Terra.StrengthMovementVariant136?, TResult>? strengthMovementVariant136 = null,
            global::System.Func<global::Terra.StrengthMovementVariant137?, TResult>? strengthMovementVariant137 = null,
            global::System.Func<global::Terra.StrengthMovementVariant138?, TResult>? strengthMovementVariant138 = null,
            global::System.Func<global::Terra.StrengthMovementVariant139?, TResult>? strengthMovementVariant139 = null,
            global::System.Func<global::Terra.StrengthMovementVariant140?, TResult>? strengthMovementVariant140 = null,
            global::System.Func<global::Terra.StrengthMovementVariant141?, TResult>? strengthMovementVariant141 = null,
            global::System.Func<global::Terra.StrengthMovementVariant142?, TResult>? strengthMovementVariant142 = null,
            global::System.Func<global::Terra.StrengthMovementVariant143?, TResult>? strengthMovementVariant143 = null,
            global::System.Func<global::Terra.StrengthMovementVariant144?, TResult>? strengthMovementVariant144 = null,
            global::System.Func<global::Terra.StrengthMovementVariant145?, TResult>? strengthMovementVariant145 = null,
            global::System.Func<global::Terra.StrengthMovementVariant146?, TResult>? strengthMovementVariant146 = null,
            global::System.Func<global::Terra.StrengthMovementVariant147?, TResult>? strengthMovementVariant147 = null,
            global::System.Func<global::Terra.StrengthMovementVariant148?, TResult>? strengthMovementVariant148 = null,
            global::System.Func<global::Terra.StrengthMovementVariant149?, TResult>? strengthMovementVariant149 = null,
            global::System.Func<global::Terra.StrengthMovementVariant150?, TResult>? strengthMovementVariant150 = null,
            global::System.Func<global::Terra.StrengthMovementVariant151?, TResult>? strengthMovementVariant151 = null,
            global::System.Func<global::Terra.StrengthMovementVariant152?, TResult>? strengthMovementVariant152 = null,
            global::System.Func<global::Terra.StrengthMovementVariant153?, TResult>? strengthMovementVariant153 = null,
            global::System.Func<global::Terra.StrengthMovementVariant154?, TResult>? strengthMovementVariant154 = null,
            global::System.Func<global::Terra.StrengthMovementVariant155?, TResult>? strengthMovementVariant155 = null,
            global::System.Func<global::Terra.StrengthMovementVariant156?, TResult>? strengthMovementVariant156 = null,
            global::System.Func<global::Terra.StrengthMovementVariant157?, TResult>? strengthMovementVariant157 = null,
            global::System.Func<global::Terra.StrengthMovementVariant158?, TResult>? strengthMovementVariant158 = null,
            global::System.Func<global::Terra.StrengthMovementVariant159?, TResult>? strengthMovementVariant159 = null,
            global::System.Func<global::Terra.StrengthMovementVariant160?, TResult>? strengthMovementVariant160 = null,
            global::System.Func<global::Terra.StrengthMovementVariant161?, TResult>? strengthMovementVariant161 = null,
            global::System.Func<global::Terra.StrengthMovementVariant162?, TResult>? strengthMovementVariant162 = null,
            global::System.Func<global::Terra.StrengthMovementVariant163?, TResult>? strengthMovementVariant163 = null,
            global::System.Func<global::Terra.StrengthMovementVariant164?, TResult>? strengthMovementVariant164 = null,
            global::System.Func<global::Terra.StrengthMovementVariant165?, TResult>? strengthMovementVariant165 = null,
            global::System.Func<global::Terra.StrengthMovementVariant166?, TResult>? strengthMovementVariant166 = null,
            global::System.Func<global::Terra.StrengthMovementVariant167?, TResult>? strengthMovementVariant167 = null,
            global::System.Func<global::Terra.StrengthMovementVariant168?, TResult>? strengthMovementVariant168 = null,
            global::System.Func<global::Terra.StrengthMovementVariant169?, TResult>? strengthMovementVariant169 = null,
            global::System.Func<global::Terra.StrengthMovementVariant170?, TResult>? strengthMovementVariant170 = null,
            global::System.Func<global::Terra.StrengthMovementVariant171?, TResult>? strengthMovementVariant171 = null,
            global::System.Func<global::Terra.StrengthMovementVariant172?, TResult>? strengthMovementVariant172 = null,
            global::System.Func<global::Terra.StrengthMovementVariant173?, TResult>? strengthMovementVariant173 = null,
            global::System.Func<global::Terra.StrengthMovementVariant174?, TResult>? strengthMovementVariant174 = null,
            global::System.Func<global::Terra.StrengthMovementVariant175?, TResult>? strengthMovementVariant175 = null,
            global::System.Func<string, TResult>? strengthMovementVariant176 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthMovementVariant1 && strengthMovementVariant1 != null)
            {
                return strengthMovementVariant1(StrengthMovementVariant1!);
            }
            else if (IsStrengthMovementVariant2 && strengthMovementVariant2 != null)
            {
                return strengthMovementVariant2(StrengthMovementVariant2!);
            }
            else if (IsStrengthMovementVariant3 && strengthMovementVariant3 != null)
            {
                return strengthMovementVariant3(StrengthMovementVariant3!);
            }
            else if (IsStrengthMovementVariant4 && strengthMovementVariant4 != null)
            {
                return strengthMovementVariant4(StrengthMovementVariant4!);
            }
            else if (IsStrengthMovementVariant5 && strengthMovementVariant5 != null)
            {
                return strengthMovementVariant5(StrengthMovementVariant5!);
            }
            else if (IsStrengthMovementVariant6 && strengthMovementVariant6 != null)
            {
                return strengthMovementVariant6(StrengthMovementVariant6!);
            }
            else if (IsStrengthMovementVariant7 && strengthMovementVariant7 != null)
            {
                return strengthMovementVariant7(StrengthMovementVariant7!);
            }
            else if (IsStrengthMovementVariant8 && strengthMovementVariant8 != null)
            {
                return strengthMovementVariant8(StrengthMovementVariant8!);
            }
            else if (IsStrengthMovementVariant9 && strengthMovementVariant9 != null)
            {
                return strengthMovementVariant9(StrengthMovementVariant9!);
            }
            else if (IsStrengthMovementVariant10 && strengthMovementVariant10 != null)
            {
                return strengthMovementVariant10(StrengthMovementVariant10!);
            }
            else if (IsStrengthMovementVariant11 && strengthMovementVariant11 != null)
            {
                return strengthMovementVariant11(StrengthMovementVariant11!);
            }
            else if (IsStrengthMovementVariant12 && strengthMovementVariant12 != null)
            {
                return strengthMovementVariant12(StrengthMovementVariant12!);
            }
            else if (IsStrengthMovementVariant13 && strengthMovementVariant13 != null)
            {
                return strengthMovementVariant13(StrengthMovementVariant13!);
            }
            else if (IsStrengthMovementVariant14 && strengthMovementVariant14 != null)
            {
                return strengthMovementVariant14(StrengthMovementVariant14!);
            }
            else if (IsStrengthMovementVariant15 && strengthMovementVariant15 != null)
            {
                return strengthMovementVariant15(StrengthMovementVariant15!);
            }
            else if (IsStrengthMovementVariant16 && strengthMovementVariant16 != null)
            {
                return strengthMovementVariant16(StrengthMovementVariant16!);
            }
            else if (IsStrengthMovementVariant17 && strengthMovementVariant17 != null)
            {
                return strengthMovementVariant17(StrengthMovementVariant17!);
            }
            else if (IsStrengthMovementVariant18 && strengthMovementVariant18 != null)
            {
                return strengthMovementVariant18(StrengthMovementVariant18!);
            }
            else if (IsStrengthMovementVariant19 && strengthMovementVariant19 != null)
            {
                return strengthMovementVariant19(StrengthMovementVariant19!);
            }
            else if (IsStrengthMovementVariant20 && strengthMovementVariant20 != null)
            {
                return strengthMovementVariant20(StrengthMovementVariant20!);
            }
            else if (IsStrengthMovementVariant21 && strengthMovementVariant21 != null)
            {
                return strengthMovementVariant21(StrengthMovementVariant21!);
            }
            else if (IsStrengthMovementVariant22 && strengthMovementVariant22 != null)
            {
                return strengthMovementVariant22(StrengthMovementVariant22!);
            }
            else if (IsStrengthMovementVariant23 && strengthMovementVariant23 != null)
            {
                return strengthMovementVariant23(StrengthMovementVariant23!);
            }
            else if (IsStrengthMovementVariant24 && strengthMovementVariant24 != null)
            {
                return strengthMovementVariant24(StrengthMovementVariant24!);
            }
            else if (IsStrengthMovementVariant25 && strengthMovementVariant25 != null)
            {
                return strengthMovementVariant25(StrengthMovementVariant25!);
            }
            else if (IsStrengthMovementVariant26 && strengthMovementVariant26 != null)
            {
                return strengthMovementVariant26(StrengthMovementVariant26!);
            }
            else if (IsStrengthMovementVariant27 && strengthMovementVariant27 != null)
            {
                return strengthMovementVariant27(StrengthMovementVariant27!);
            }
            else if (IsStrengthMovementVariant28 && strengthMovementVariant28 != null)
            {
                return strengthMovementVariant28(StrengthMovementVariant28!);
            }
            else if (IsStrengthMovementVariant29 && strengthMovementVariant29 != null)
            {
                return strengthMovementVariant29(StrengthMovementVariant29!);
            }
            else if (IsStrengthMovementVariant30 && strengthMovementVariant30 != null)
            {
                return strengthMovementVariant30(StrengthMovementVariant30!);
            }
            else if (IsStrengthMovementVariant31 && strengthMovementVariant31 != null)
            {
                return strengthMovementVariant31(StrengthMovementVariant31!);
            }
            else if (IsStrengthMovementVariant32 && strengthMovementVariant32 != null)
            {
                return strengthMovementVariant32(StrengthMovementVariant32!);
            }
            else if (IsStrengthMovementVariant33 && strengthMovementVariant33 != null)
            {
                return strengthMovementVariant33(StrengthMovementVariant33!);
            }
            else if (IsStrengthMovementVariant34 && strengthMovementVariant34 != null)
            {
                return strengthMovementVariant34(StrengthMovementVariant34!);
            }
            else if (IsStrengthMovementVariant35 && strengthMovementVariant35 != null)
            {
                return strengthMovementVariant35(StrengthMovementVariant35!);
            }
            else if (IsStrengthMovementVariant36 && strengthMovementVariant36 != null)
            {
                return strengthMovementVariant36(StrengthMovementVariant36!);
            }
            else if (IsStrengthMovementVariant37 && strengthMovementVariant37 != null)
            {
                return strengthMovementVariant37(StrengthMovementVariant37!);
            }
            else if (IsStrengthMovementVariant38 && strengthMovementVariant38 != null)
            {
                return strengthMovementVariant38(StrengthMovementVariant38!);
            }
            else if (IsStrengthMovementVariant39 && strengthMovementVariant39 != null)
            {
                return strengthMovementVariant39(StrengthMovementVariant39!);
            }
            else if (IsStrengthMovementVariant40 && strengthMovementVariant40 != null)
            {
                return strengthMovementVariant40(StrengthMovementVariant40!);
            }
            else if (IsStrengthMovementVariant41 && strengthMovementVariant41 != null)
            {
                return strengthMovementVariant41(StrengthMovementVariant41!);
            }
            else if (IsStrengthMovementVariant42 && strengthMovementVariant42 != null)
            {
                return strengthMovementVariant42(StrengthMovementVariant42!);
            }
            else if (IsStrengthMovementVariant43 && strengthMovementVariant43 != null)
            {
                return strengthMovementVariant43(StrengthMovementVariant43!);
            }
            else if (IsStrengthMovementVariant44 && strengthMovementVariant44 != null)
            {
                return strengthMovementVariant44(StrengthMovementVariant44!);
            }
            else if (IsStrengthMovementVariant45 && strengthMovementVariant45 != null)
            {
                return strengthMovementVariant45(StrengthMovementVariant45!);
            }
            else if (IsStrengthMovementVariant46 && strengthMovementVariant46 != null)
            {
                return strengthMovementVariant46(StrengthMovementVariant46!);
            }
            else if (IsStrengthMovementVariant47 && strengthMovementVariant47 != null)
            {
                return strengthMovementVariant47(StrengthMovementVariant47!);
            }
            else if (IsStrengthMovementVariant48 && strengthMovementVariant48 != null)
            {
                return strengthMovementVariant48(StrengthMovementVariant48!);
            }
            else if (IsStrengthMovementVariant49 && strengthMovementVariant49 != null)
            {
                return strengthMovementVariant49(StrengthMovementVariant49!);
            }
            else if (IsStrengthMovementVariant50 && strengthMovementVariant50 != null)
            {
                return strengthMovementVariant50(StrengthMovementVariant50!);
            }
            else if (IsStrengthMovementVariant51 && strengthMovementVariant51 != null)
            {
                return strengthMovementVariant51(StrengthMovementVariant51!);
            }
            else if (IsStrengthMovementVariant52 && strengthMovementVariant52 != null)
            {
                return strengthMovementVariant52(StrengthMovementVariant52!);
            }
            else if (IsStrengthMovementVariant53 && strengthMovementVariant53 != null)
            {
                return strengthMovementVariant53(StrengthMovementVariant53!);
            }
            else if (IsStrengthMovementVariant54 && strengthMovementVariant54 != null)
            {
                return strengthMovementVariant54(StrengthMovementVariant54!);
            }
            else if (IsStrengthMovementVariant55 && strengthMovementVariant55 != null)
            {
                return strengthMovementVariant55(StrengthMovementVariant55!);
            }
            else if (IsStrengthMovementVariant56 && strengthMovementVariant56 != null)
            {
                return strengthMovementVariant56(StrengthMovementVariant56!);
            }
            else if (IsStrengthMovementVariant57 && strengthMovementVariant57 != null)
            {
                return strengthMovementVariant57(StrengthMovementVariant57!);
            }
            else if (IsStrengthMovementVariant58 && strengthMovementVariant58 != null)
            {
                return strengthMovementVariant58(StrengthMovementVariant58!);
            }
            else if (IsStrengthMovementVariant59 && strengthMovementVariant59 != null)
            {
                return strengthMovementVariant59(StrengthMovementVariant59!);
            }
            else if (IsStrengthMovementVariant60 && strengthMovementVariant60 != null)
            {
                return strengthMovementVariant60(StrengthMovementVariant60!);
            }
            else if (IsStrengthMovementVariant61 && strengthMovementVariant61 != null)
            {
                return strengthMovementVariant61(StrengthMovementVariant61!);
            }
            else if (IsStrengthMovementVariant62 && strengthMovementVariant62 != null)
            {
                return strengthMovementVariant62(StrengthMovementVariant62!);
            }
            else if (IsStrengthMovementVariant63 && strengthMovementVariant63 != null)
            {
                return strengthMovementVariant63(StrengthMovementVariant63!);
            }
            else if (IsStrengthMovementVariant64 && strengthMovementVariant64 != null)
            {
                return strengthMovementVariant64(StrengthMovementVariant64!);
            }
            else if (IsStrengthMovementVariant65 && strengthMovementVariant65 != null)
            {
                return strengthMovementVariant65(StrengthMovementVariant65!);
            }
            else if (IsStrengthMovementVariant66 && strengthMovementVariant66 != null)
            {
                return strengthMovementVariant66(StrengthMovementVariant66!);
            }
            else if (IsStrengthMovementVariant67 && strengthMovementVariant67 != null)
            {
                return strengthMovementVariant67(StrengthMovementVariant67!);
            }
            else if (IsStrengthMovementVariant68 && strengthMovementVariant68 != null)
            {
                return strengthMovementVariant68(StrengthMovementVariant68!);
            }
            else if (IsStrengthMovementVariant69 && strengthMovementVariant69 != null)
            {
                return strengthMovementVariant69(StrengthMovementVariant69!);
            }
            else if (IsStrengthMovementVariant70 && strengthMovementVariant70 != null)
            {
                return strengthMovementVariant70(StrengthMovementVariant70!);
            }
            else if (IsStrengthMovementVariant71 && strengthMovementVariant71 != null)
            {
                return strengthMovementVariant71(StrengthMovementVariant71!);
            }
            else if (IsStrengthMovementVariant72 && strengthMovementVariant72 != null)
            {
                return strengthMovementVariant72(StrengthMovementVariant72!);
            }
            else if (IsStrengthMovementVariant73 && strengthMovementVariant73 != null)
            {
                return strengthMovementVariant73(StrengthMovementVariant73!);
            }
            else if (IsStrengthMovementVariant74 && strengthMovementVariant74 != null)
            {
                return strengthMovementVariant74(StrengthMovementVariant74!);
            }
            else if (IsStrengthMovementVariant75 && strengthMovementVariant75 != null)
            {
                return strengthMovementVariant75(StrengthMovementVariant75!);
            }
            else if (IsStrengthMovementVariant76 && strengthMovementVariant76 != null)
            {
                return strengthMovementVariant76(StrengthMovementVariant76!);
            }
            else if (IsStrengthMovementVariant77 && strengthMovementVariant77 != null)
            {
                return strengthMovementVariant77(StrengthMovementVariant77!);
            }
            else if (IsStrengthMovementVariant78 && strengthMovementVariant78 != null)
            {
                return strengthMovementVariant78(StrengthMovementVariant78!);
            }
            else if (IsStrengthMovementVariant79 && strengthMovementVariant79 != null)
            {
                return strengthMovementVariant79(StrengthMovementVariant79!);
            }
            else if (IsStrengthMovementVariant80 && strengthMovementVariant80 != null)
            {
                return strengthMovementVariant80(StrengthMovementVariant80!);
            }
            else if (IsStrengthMovementVariant81 && strengthMovementVariant81 != null)
            {
                return strengthMovementVariant81(StrengthMovementVariant81!);
            }
            else if (IsStrengthMovementVariant82 && strengthMovementVariant82 != null)
            {
                return strengthMovementVariant82(StrengthMovementVariant82!);
            }
            else if (IsStrengthMovementVariant83 && strengthMovementVariant83 != null)
            {
                return strengthMovementVariant83(StrengthMovementVariant83!);
            }
            else if (IsStrengthMovementVariant84 && strengthMovementVariant84 != null)
            {
                return strengthMovementVariant84(StrengthMovementVariant84!);
            }
            else if (IsStrengthMovementVariant85 && strengthMovementVariant85 != null)
            {
                return strengthMovementVariant85(StrengthMovementVariant85!);
            }
            else if (IsStrengthMovementVariant86 && strengthMovementVariant86 != null)
            {
                return strengthMovementVariant86(StrengthMovementVariant86!);
            }
            else if (IsStrengthMovementVariant87 && strengthMovementVariant87 != null)
            {
                return strengthMovementVariant87(StrengthMovementVariant87!);
            }
            else if (IsStrengthMovementVariant88 && strengthMovementVariant88 != null)
            {
                return strengthMovementVariant88(StrengthMovementVariant88!);
            }
            else if (IsStrengthMovementVariant89 && strengthMovementVariant89 != null)
            {
                return strengthMovementVariant89(StrengthMovementVariant89!);
            }
            else if (IsStrengthMovementVariant90 && strengthMovementVariant90 != null)
            {
                return strengthMovementVariant90(StrengthMovementVariant90!);
            }
            else if (IsStrengthMovementVariant91 && strengthMovementVariant91 != null)
            {
                return strengthMovementVariant91(StrengthMovementVariant91!);
            }
            else if (IsStrengthMovementVariant92 && strengthMovementVariant92 != null)
            {
                return strengthMovementVariant92(StrengthMovementVariant92!);
            }
            else if (IsStrengthMovementVariant93 && strengthMovementVariant93 != null)
            {
                return strengthMovementVariant93(StrengthMovementVariant93!);
            }
            else if (IsStrengthMovementVariant94 && strengthMovementVariant94 != null)
            {
                return strengthMovementVariant94(StrengthMovementVariant94!);
            }
            else if (IsStrengthMovementVariant95 && strengthMovementVariant95 != null)
            {
                return strengthMovementVariant95(StrengthMovementVariant95!);
            }
            else if (IsStrengthMovementVariant96 && strengthMovementVariant96 != null)
            {
                return strengthMovementVariant96(StrengthMovementVariant96!);
            }
            else if (IsStrengthMovementVariant97 && strengthMovementVariant97 != null)
            {
                return strengthMovementVariant97(StrengthMovementVariant97!);
            }
            else if (IsStrengthMovementVariant98 && strengthMovementVariant98 != null)
            {
                return strengthMovementVariant98(StrengthMovementVariant98!);
            }
            else if (IsStrengthMovementVariant99 && strengthMovementVariant99 != null)
            {
                return strengthMovementVariant99(StrengthMovementVariant99!);
            }
            else if (IsStrengthMovementVariant100 && strengthMovementVariant100 != null)
            {
                return strengthMovementVariant100(StrengthMovementVariant100!);
            }
            else if (IsStrengthMovementVariant101 && strengthMovementVariant101 != null)
            {
                return strengthMovementVariant101(StrengthMovementVariant101!);
            }
            else if (IsStrengthMovementVariant102 && strengthMovementVariant102 != null)
            {
                return strengthMovementVariant102(StrengthMovementVariant102!);
            }
            else if (IsStrengthMovementVariant103 && strengthMovementVariant103 != null)
            {
                return strengthMovementVariant103(StrengthMovementVariant103!);
            }
            else if (IsStrengthMovementVariant104 && strengthMovementVariant104 != null)
            {
                return strengthMovementVariant104(StrengthMovementVariant104!);
            }
            else if (IsStrengthMovementVariant105 && strengthMovementVariant105 != null)
            {
                return strengthMovementVariant105(StrengthMovementVariant105!);
            }
            else if (IsStrengthMovementVariant106 && strengthMovementVariant106 != null)
            {
                return strengthMovementVariant106(StrengthMovementVariant106!);
            }
            else if (IsStrengthMovementVariant107 && strengthMovementVariant107 != null)
            {
                return strengthMovementVariant107(StrengthMovementVariant107!);
            }
            else if (IsStrengthMovementVariant108 && strengthMovementVariant108 != null)
            {
                return strengthMovementVariant108(StrengthMovementVariant108!);
            }
            else if (IsStrengthMovementVariant109 && strengthMovementVariant109 != null)
            {
                return strengthMovementVariant109(StrengthMovementVariant109!);
            }
            else if (IsStrengthMovementVariant110 && strengthMovementVariant110 != null)
            {
                return strengthMovementVariant110(StrengthMovementVariant110!);
            }
            else if (IsStrengthMovementVariant111 && strengthMovementVariant111 != null)
            {
                return strengthMovementVariant111(StrengthMovementVariant111!);
            }
            else if (IsStrengthMovementVariant112 && strengthMovementVariant112 != null)
            {
                return strengthMovementVariant112(StrengthMovementVariant112!);
            }
            else if (IsStrengthMovementVariant113 && strengthMovementVariant113 != null)
            {
                return strengthMovementVariant113(StrengthMovementVariant113!);
            }
            else if (IsStrengthMovementVariant114 && strengthMovementVariant114 != null)
            {
                return strengthMovementVariant114(StrengthMovementVariant114!);
            }
            else if (IsStrengthMovementVariant115 && strengthMovementVariant115 != null)
            {
                return strengthMovementVariant115(StrengthMovementVariant115!);
            }
            else if (IsStrengthMovementVariant116 && strengthMovementVariant116 != null)
            {
                return strengthMovementVariant116(StrengthMovementVariant116!);
            }
            else if (IsStrengthMovementVariant117 && strengthMovementVariant117 != null)
            {
                return strengthMovementVariant117(StrengthMovementVariant117!);
            }
            else if (IsStrengthMovementVariant118 && strengthMovementVariant118 != null)
            {
                return strengthMovementVariant118(StrengthMovementVariant118!);
            }
            else if (IsStrengthMovementVariant119 && strengthMovementVariant119 != null)
            {
                return strengthMovementVariant119(StrengthMovementVariant119!);
            }
            else if (IsStrengthMovementVariant120 && strengthMovementVariant120 != null)
            {
                return strengthMovementVariant120(StrengthMovementVariant120!);
            }
            else if (IsStrengthMovementVariant121 && strengthMovementVariant121 != null)
            {
                return strengthMovementVariant121(StrengthMovementVariant121!);
            }
            else if (IsStrengthMovementVariant122 && strengthMovementVariant122 != null)
            {
                return strengthMovementVariant122(StrengthMovementVariant122!);
            }
            else if (IsStrengthMovementVariant123 && strengthMovementVariant123 != null)
            {
                return strengthMovementVariant123(StrengthMovementVariant123!);
            }
            else if (IsStrengthMovementVariant124 && strengthMovementVariant124 != null)
            {
                return strengthMovementVariant124(StrengthMovementVariant124!);
            }
            else if (IsStrengthMovementVariant125 && strengthMovementVariant125 != null)
            {
                return strengthMovementVariant125(StrengthMovementVariant125!);
            }
            else if (IsStrengthMovementVariant126 && strengthMovementVariant126 != null)
            {
                return strengthMovementVariant126(StrengthMovementVariant126!);
            }
            else if (IsStrengthMovementVariant127 && strengthMovementVariant127 != null)
            {
                return strengthMovementVariant127(StrengthMovementVariant127!);
            }
            else if (IsStrengthMovementVariant128 && strengthMovementVariant128 != null)
            {
                return strengthMovementVariant128(StrengthMovementVariant128!);
            }
            else if (IsStrengthMovementVariant129 && strengthMovementVariant129 != null)
            {
                return strengthMovementVariant129(StrengthMovementVariant129!);
            }
            else if (IsStrengthMovementVariant130 && strengthMovementVariant130 != null)
            {
                return strengthMovementVariant130(StrengthMovementVariant130!);
            }
            else if (IsStrengthMovementVariant131 && strengthMovementVariant131 != null)
            {
                return strengthMovementVariant131(StrengthMovementVariant131!);
            }
            else if (IsStrengthMovementVariant132 && strengthMovementVariant132 != null)
            {
                return strengthMovementVariant132(StrengthMovementVariant132!);
            }
            else if (IsStrengthMovementVariant133 && strengthMovementVariant133 != null)
            {
                return strengthMovementVariant133(StrengthMovementVariant133!);
            }
            else if (IsStrengthMovementVariant134 && strengthMovementVariant134 != null)
            {
                return strengthMovementVariant134(StrengthMovementVariant134!);
            }
            else if (IsStrengthMovementVariant135 && strengthMovementVariant135 != null)
            {
                return strengthMovementVariant135(StrengthMovementVariant135!);
            }
            else if (IsStrengthMovementVariant136 && strengthMovementVariant136 != null)
            {
                return strengthMovementVariant136(StrengthMovementVariant136!);
            }
            else if (IsStrengthMovementVariant137 && strengthMovementVariant137 != null)
            {
                return strengthMovementVariant137(StrengthMovementVariant137!);
            }
            else if (IsStrengthMovementVariant138 && strengthMovementVariant138 != null)
            {
                return strengthMovementVariant138(StrengthMovementVariant138!);
            }
            else if (IsStrengthMovementVariant139 && strengthMovementVariant139 != null)
            {
                return strengthMovementVariant139(StrengthMovementVariant139!);
            }
            else if (IsStrengthMovementVariant140 && strengthMovementVariant140 != null)
            {
                return strengthMovementVariant140(StrengthMovementVariant140!);
            }
            else if (IsStrengthMovementVariant141 && strengthMovementVariant141 != null)
            {
                return strengthMovementVariant141(StrengthMovementVariant141!);
            }
            else if (IsStrengthMovementVariant142 && strengthMovementVariant142 != null)
            {
                return strengthMovementVariant142(StrengthMovementVariant142!);
            }
            else if (IsStrengthMovementVariant143 && strengthMovementVariant143 != null)
            {
                return strengthMovementVariant143(StrengthMovementVariant143!);
            }
            else if (IsStrengthMovementVariant144 && strengthMovementVariant144 != null)
            {
                return strengthMovementVariant144(StrengthMovementVariant144!);
            }
            else if (IsStrengthMovementVariant145 && strengthMovementVariant145 != null)
            {
                return strengthMovementVariant145(StrengthMovementVariant145!);
            }
            else if (IsStrengthMovementVariant146 && strengthMovementVariant146 != null)
            {
                return strengthMovementVariant146(StrengthMovementVariant146!);
            }
            else if (IsStrengthMovementVariant147 && strengthMovementVariant147 != null)
            {
                return strengthMovementVariant147(StrengthMovementVariant147!);
            }
            else if (IsStrengthMovementVariant148 && strengthMovementVariant148 != null)
            {
                return strengthMovementVariant148(StrengthMovementVariant148!);
            }
            else if (IsStrengthMovementVariant149 && strengthMovementVariant149 != null)
            {
                return strengthMovementVariant149(StrengthMovementVariant149!);
            }
            else if (IsStrengthMovementVariant150 && strengthMovementVariant150 != null)
            {
                return strengthMovementVariant150(StrengthMovementVariant150!);
            }
            else if (IsStrengthMovementVariant151 && strengthMovementVariant151 != null)
            {
                return strengthMovementVariant151(StrengthMovementVariant151!);
            }
            else if (IsStrengthMovementVariant152 && strengthMovementVariant152 != null)
            {
                return strengthMovementVariant152(StrengthMovementVariant152!);
            }
            else if (IsStrengthMovementVariant153 && strengthMovementVariant153 != null)
            {
                return strengthMovementVariant153(StrengthMovementVariant153!);
            }
            else if (IsStrengthMovementVariant154 && strengthMovementVariant154 != null)
            {
                return strengthMovementVariant154(StrengthMovementVariant154!);
            }
            else if (IsStrengthMovementVariant155 && strengthMovementVariant155 != null)
            {
                return strengthMovementVariant155(StrengthMovementVariant155!);
            }
            else if (IsStrengthMovementVariant156 && strengthMovementVariant156 != null)
            {
                return strengthMovementVariant156(StrengthMovementVariant156!);
            }
            else if (IsStrengthMovementVariant157 && strengthMovementVariant157 != null)
            {
                return strengthMovementVariant157(StrengthMovementVariant157!);
            }
            else if (IsStrengthMovementVariant158 && strengthMovementVariant158 != null)
            {
                return strengthMovementVariant158(StrengthMovementVariant158!);
            }
            else if (IsStrengthMovementVariant159 && strengthMovementVariant159 != null)
            {
                return strengthMovementVariant159(StrengthMovementVariant159!);
            }
            else if (IsStrengthMovementVariant160 && strengthMovementVariant160 != null)
            {
                return strengthMovementVariant160(StrengthMovementVariant160!);
            }
            else if (IsStrengthMovementVariant161 && strengthMovementVariant161 != null)
            {
                return strengthMovementVariant161(StrengthMovementVariant161!);
            }
            else if (IsStrengthMovementVariant162 && strengthMovementVariant162 != null)
            {
                return strengthMovementVariant162(StrengthMovementVariant162!);
            }
            else if (IsStrengthMovementVariant163 && strengthMovementVariant163 != null)
            {
                return strengthMovementVariant163(StrengthMovementVariant163!);
            }
            else if (IsStrengthMovementVariant164 && strengthMovementVariant164 != null)
            {
                return strengthMovementVariant164(StrengthMovementVariant164!);
            }
            else if (IsStrengthMovementVariant165 && strengthMovementVariant165 != null)
            {
                return strengthMovementVariant165(StrengthMovementVariant165!);
            }
            else if (IsStrengthMovementVariant166 && strengthMovementVariant166 != null)
            {
                return strengthMovementVariant166(StrengthMovementVariant166!);
            }
            else if (IsStrengthMovementVariant167 && strengthMovementVariant167 != null)
            {
                return strengthMovementVariant167(StrengthMovementVariant167!);
            }
            else if (IsStrengthMovementVariant168 && strengthMovementVariant168 != null)
            {
                return strengthMovementVariant168(StrengthMovementVariant168!);
            }
            else if (IsStrengthMovementVariant169 && strengthMovementVariant169 != null)
            {
                return strengthMovementVariant169(StrengthMovementVariant169!);
            }
            else if (IsStrengthMovementVariant170 && strengthMovementVariant170 != null)
            {
                return strengthMovementVariant170(StrengthMovementVariant170!);
            }
            else if (IsStrengthMovementVariant171 && strengthMovementVariant171 != null)
            {
                return strengthMovementVariant171(StrengthMovementVariant171!);
            }
            else if (IsStrengthMovementVariant172 && strengthMovementVariant172 != null)
            {
                return strengthMovementVariant172(StrengthMovementVariant172!);
            }
            else if (IsStrengthMovementVariant173 && strengthMovementVariant173 != null)
            {
                return strengthMovementVariant173(StrengthMovementVariant173!);
            }
            else if (IsStrengthMovementVariant174 && strengthMovementVariant174 != null)
            {
                return strengthMovementVariant174(StrengthMovementVariant174!);
            }
            else if (IsStrengthMovementVariant175 && strengthMovementVariant175 != null)
            {
                return strengthMovementVariant175(StrengthMovementVariant175!);
            }
            else if (IsStrengthMovementVariant176 && strengthMovementVariant176 != null)
            {
                return strengthMovementVariant176(StrengthMovementVariant176!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthMovementVariant1?>? strengthMovementVariant1 = null,

            global::System.Action<global::Terra.StrengthMovementVariant2?>? strengthMovementVariant2 = null,

            global::System.Action<global::Terra.StrengthMovementVariant3?>? strengthMovementVariant3 = null,

            global::System.Action<global::Terra.StrengthMovementVariant4?>? strengthMovementVariant4 = null,

            global::System.Action<global::Terra.StrengthMovementVariant5?>? strengthMovementVariant5 = null,

            global::System.Action<global::Terra.StrengthMovementVariant6?>? strengthMovementVariant6 = null,

            global::System.Action<global::Terra.StrengthMovementVariant7?>? strengthMovementVariant7 = null,

            global::System.Action<global::Terra.StrengthMovementVariant8?>? strengthMovementVariant8 = null,

            global::System.Action<global::Terra.StrengthMovementVariant9?>? strengthMovementVariant9 = null,

            global::System.Action<global::Terra.StrengthMovementVariant10?>? strengthMovementVariant10 = null,

            global::System.Action<global::Terra.StrengthMovementVariant11?>? strengthMovementVariant11 = null,

            global::System.Action<global::Terra.StrengthMovementVariant12?>? strengthMovementVariant12 = null,

            global::System.Action<global::Terra.StrengthMovementVariant13?>? strengthMovementVariant13 = null,

            global::System.Action<global::Terra.StrengthMovementVariant14?>? strengthMovementVariant14 = null,

            global::System.Action<global::Terra.StrengthMovementVariant15?>? strengthMovementVariant15 = null,

            global::System.Action<global::Terra.StrengthMovementVariant16?>? strengthMovementVariant16 = null,

            global::System.Action<global::Terra.StrengthMovementVariant17?>? strengthMovementVariant17 = null,

            global::System.Action<global::Terra.StrengthMovementVariant18?>? strengthMovementVariant18 = null,

            global::System.Action<global::Terra.StrengthMovementVariant19?>? strengthMovementVariant19 = null,

            global::System.Action<global::Terra.StrengthMovementVariant20?>? strengthMovementVariant20 = null,

            global::System.Action<global::Terra.StrengthMovementVariant21?>? strengthMovementVariant21 = null,

            global::System.Action<global::Terra.StrengthMovementVariant22?>? strengthMovementVariant22 = null,

            global::System.Action<global::Terra.StrengthMovementVariant23?>? strengthMovementVariant23 = null,

            global::System.Action<global::Terra.StrengthMovementVariant24?>? strengthMovementVariant24 = null,

            global::System.Action<global::Terra.StrengthMovementVariant25?>? strengthMovementVariant25 = null,

            global::System.Action<global::Terra.StrengthMovementVariant26?>? strengthMovementVariant26 = null,

            global::System.Action<global::Terra.StrengthMovementVariant27?>? strengthMovementVariant27 = null,

            global::System.Action<global::Terra.StrengthMovementVariant28?>? strengthMovementVariant28 = null,

            global::System.Action<global::Terra.StrengthMovementVariant29?>? strengthMovementVariant29 = null,

            global::System.Action<global::Terra.StrengthMovementVariant30?>? strengthMovementVariant30 = null,

            global::System.Action<global::Terra.StrengthMovementVariant31?>? strengthMovementVariant31 = null,

            global::System.Action<global::Terra.StrengthMovementVariant32?>? strengthMovementVariant32 = null,

            global::System.Action<global::Terra.StrengthMovementVariant33?>? strengthMovementVariant33 = null,

            global::System.Action<global::Terra.StrengthMovementVariant34?>? strengthMovementVariant34 = null,

            global::System.Action<global::Terra.StrengthMovementVariant35?>? strengthMovementVariant35 = null,

            global::System.Action<global::Terra.StrengthMovementVariant36?>? strengthMovementVariant36 = null,

            global::System.Action<global::Terra.StrengthMovementVariant37?>? strengthMovementVariant37 = null,

            global::System.Action<global::Terra.StrengthMovementVariant38?>? strengthMovementVariant38 = null,

            global::System.Action<global::Terra.StrengthMovementVariant39?>? strengthMovementVariant39 = null,

            global::System.Action<global::Terra.StrengthMovementVariant40?>? strengthMovementVariant40 = null,

            global::System.Action<global::Terra.StrengthMovementVariant41?>? strengthMovementVariant41 = null,

            global::System.Action<global::Terra.StrengthMovementVariant42?>? strengthMovementVariant42 = null,

            global::System.Action<global::Terra.StrengthMovementVariant43?>? strengthMovementVariant43 = null,

            global::System.Action<global::Terra.StrengthMovementVariant44?>? strengthMovementVariant44 = null,

            global::System.Action<global::Terra.StrengthMovementVariant45?>? strengthMovementVariant45 = null,

            global::System.Action<global::Terra.StrengthMovementVariant46?>? strengthMovementVariant46 = null,

            global::System.Action<global::Terra.StrengthMovementVariant47?>? strengthMovementVariant47 = null,

            global::System.Action<global::Terra.StrengthMovementVariant48?>? strengthMovementVariant48 = null,

            global::System.Action<global::Terra.StrengthMovementVariant49?>? strengthMovementVariant49 = null,

            global::System.Action<global::Terra.StrengthMovementVariant50?>? strengthMovementVariant50 = null,

            global::System.Action<global::Terra.StrengthMovementVariant51?>? strengthMovementVariant51 = null,

            global::System.Action<global::Terra.StrengthMovementVariant52?>? strengthMovementVariant52 = null,

            global::System.Action<global::Terra.StrengthMovementVariant53?>? strengthMovementVariant53 = null,

            global::System.Action<global::Terra.StrengthMovementVariant54?>? strengthMovementVariant54 = null,

            global::System.Action<global::Terra.StrengthMovementVariant55?>? strengthMovementVariant55 = null,

            global::System.Action<global::Terra.StrengthMovementVariant56?>? strengthMovementVariant56 = null,

            global::System.Action<global::Terra.StrengthMovementVariant57?>? strengthMovementVariant57 = null,

            global::System.Action<global::Terra.StrengthMovementVariant58?>? strengthMovementVariant58 = null,

            global::System.Action<global::Terra.StrengthMovementVariant59?>? strengthMovementVariant59 = null,

            global::System.Action<global::Terra.StrengthMovementVariant60?>? strengthMovementVariant60 = null,

            global::System.Action<global::Terra.StrengthMovementVariant61?>? strengthMovementVariant61 = null,

            global::System.Action<global::Terra.StrengthMovementVariant62?>? strengthMovementVariant62 = null,

            global::System.Action<global::Terra.StrengthMovementVariant63?>? strengthMovementVariant63 = null,

            global::System.Action<global::Terra.StrengthMovementVariant64?>? strengthMovementVariant64 = null,

            global::System.Action<global::Terra.StrengthMovementVariant65?>? strengthMovementVariant65 = null,

            global::System.Action<global::Terra.StrengthMovementVariant66?>? strengthMovementVariant66 = null,

            global::System.Action<global::Terra.StrengthMovementVariant67?>? strengthMovementVariant67 = null,

            global::System.Action<global::Terra.StrengthMovementVariant68?>? strengthMovementVariant68 = null,

            global::System.Action<global::Terra.StrengthMovementVariant69?>? strengthMovementVariant69 = null,

            global::System.Action<global::Terra.StrengthMovementVariant70?>? strengthMovementVariant70 = null,

            global::System.Action<global::Terra.StrengthMovementVariant71?>? strengthMovementVariant71 = null,

            global::System.Action<global::Terra.StrengthMovementVariant72?>? strengthMovementVariant72 = null,

            global::System.Action<global::Terra.StrengthMovementVariant73?>? strengthMovementVariant73 = null,

            global::System.Action<global::Terra.StrengthMovementVariant74?>? strengthMovementVariant74 = null,

            global::System.Action<global::Terra.StrengthMovementVariant75?>? strengthMovementVariant75 = null,

            global::System.Action<global::Terra.StrengthMovementVariant76?>? strengthMovementVariant76 = null,

            global::System.Action<global::Terra.StrengthMovementVariant77?>? strengthMovementVariant77 = null,

            global::System.Action<global::Terra.StrengthMovementVariant78?>? strengthMovementVariant78 = null,

            global::System.Action<global::Terra.StrengthMovementVariant79?>? strengthMovementVariant79 = null,

            global::System.Action<global::Terra.StrengthMovementVariant80?>? strengthMovementVariant80 = null,

            global::System.Action<global::Terra.StrengthMovementVariant81?>? strengthMovementVariant81 = null,

            global::System.Action<global::Terra.StrengthMovementVariant82?>? strengthMovementVariant82 = null,

            global::System.Action<global::Terra.StrengthMovementVariant83?>? strengthMovementVariant83 = null,

            global::System.Action<global::Terra.StrengthMovementVariant84?>? strengthMovementVariant84 = null,

            global::System.Action<global::Terra.StrengthMovementVariant85?>? strengthMovementVariant85 = null,

            global::System.Action<global::Terra.StrengthMovementVariant86?>? strengthMovementVariant86 = null,

            global::System.Action<global::Terra.StrengthMovementVariant87?>? strengthMovementVariant87 = null,

            global::System.Action<global::Terra.StrengthMovementVariant88?>? strengthMovementVariant88 = null,

            global::System.Action<global::Terra.StrengthMovementVariant89?>? strengthMovementVariant89 = null,

            global::System.Action<global::Terra.StrengthMovementVariant90?>? strengthMovementVariant90 = null,

            global::System.Action<global::Terra.StrengthMovementVariant91?>? strengthMovementVariant91 = null,

            global::System.Action<global::Terra.StrengthMovementVariant92?>? strengthMovementVariant92 = null,

            global::System.Action<global::Terra.StrengthMovementVariant93?>? strengthMovementVariant93 = null,

            global::System.Action<global::Terra.StrengthMovementVariant94?>? strengthMovementVariant94 = null,

            global::System.Action<global::Terra.StrengthMovementVariant95?>? strengthMovementVariant95 = null,

            global::System.Action<global::Terra.StrengthMovementVariant96?>? strengthMovementVariant96 = null,

            global::System.Action<global::Terra.StrengthMovementVariant97?>? strengthMovementVariant97 = null,

            global::System.Action<global::Terra.StrengthMovementVariant98?>? strengthMovementVariant98 = null,

            global::System.Action<global::Terra.StrengthMovementVariant99?>? strengthMovementVariant99 = null,

            global::System.Action<global::Terra.StrengthMovementVariant100?>? strengthMovementVariant100 = null,

            global::System.Action<global::Terra.StrengthMovementVariant101?>? strengthMovementVariant101 = null,

            global::System.Action<global::Terra.StrengthMovementVariant102?>? strengthMovementVariant102 = null,

            global::System.Action<global::Terra.StrengthMovementVariant103?>? strengthMovementVariant103 = null,

            global::System.Action<global::Terra.StrengthMovementVariant104?>? strengthMovementVariant104 = null,

            global::System.Action<global::Terra.StrengthMovementVariant105?>? strengthMovementVariant105 = null,

            global::System.Action<global::Terra.StrengthMovementVariant106?>? strengthMovementVariant106 = null,

            global::System.Action<global::Terra.StrengthMovementVariant107?>? strengthMovementVariant107 = null,

            global::System.Action<global::Terra.StrengthMovementVariant108?>? strengthMovementVariant108 = null,

            global::System.Action<global::Terra.StrengthMovementVariant109?>? strengthMovementVariant109 = null,

            global::System.Action<global::Terra.StrengthMovementVariant110?>? strengthMovementVariant110 = null,

            global::System.Action<global::Terra.StrengthMovementVariant111?>? strengthMovementVariant111 = null,

            global::System.Action<global::Terra.StrengthMovementVariant112?>? strengthMovementVariant112 = null,

            global::System.Action<global::Terra.StrengthMovementVariant113?>? strengthMovementVariant113 = null,

            global::System.Action<global::Terra.StrengthMovementVariant114?>? strengthMovementVariant114 = null,

            global::System.Action<global::Terra.StrengthMovementVariant115?>? strengthMovementVariant115 = null,

            global::System.Action<global::Terra.StrengthMovementVariant116?>? strengthMovementVariant116 = null,

            global::System.Action<global::Terra.StrengthMovementVariant117?>? strengthMovementVariant117 = null,

            global::System.Action<global::Terra.StrengthMovementVariant118?>? strengthMovementVariant118 = null,

            global::System.Action<global::Terra.StrengthMovementVariant119?>? strengthMovementVariant119 = null,

            global::System.Action<global::Terra.StrengthMovementVariant120?>? strengthMovementVariant120 = null,

            global::System.Action<global::Terra.StrengthMovementVariant121?>? strengthMovementVariant121 = null,

            global::System.Action<global::Terra.StrengthMovementVariant122?>? strengthMovementVariant122 = null,

            global::System.Action<global::Terra.StrengthMovementVariant123?>? strengthMovementVariant123 = null,

            global::System.Action<global::Terra.StrengthMovementVariant124?>? strengthMovementVariant124 = null,

            global::System.Action<global::Terra.StrengthMovementVariant125?>? strengthMovementVariant125 = null,

            global::System.Action<global::Terra.StrengthMovementVariant126?>? strengthMovementVariant126 = null,

            global::System.Action<global::Terra.StrengthMovementVariant127?>? strengthMovementVariant127 = null,

            global::System.Action<global::Terra.StrengthMovementVariant128?>? strengthMovementVariant128 = null,

            global::System.Action<global::Terra.StrengthMovementVariant129?>? strengthMovementVariant129 = null,

            global::System.Action<global::Terra.StrengthMovementVariant130?>? strengthMovementVariant130 = null,

            global::System.Action<global::Terra.StrengthMovementVariant131?>? strengthMovementVariant131 = null,

            global::System.Action<global::Terra.StrengthMovementVariant132?>? strengthMovementVariant132 = null,

            global::System.Action<global::Terra.StrengthMovementVariant133?>? strengthMovementVariant133 = null,

            global::System.Action<global::Terra.StrengthMovementVariant134?>? strengthMovementVariant134 = null,

            global::System.Action<global::Terra.StrengthMovementVariant135?>? strengthMovementVariant135 = null,

            global::System.Action<global::Terra.StrengthMovementVariant136?>? strengthMovementVariant136 = null,

            global::System.Action<global::Terra.StrengthMovementVariant137?>? strengthMovementVariant137 = null,

            global::System.Action<global::Terra.StrengthMovementVariant138?>? strengthMovementVariant138 = null,

            global::System.Action<global::Terra.StrengthMovementVariant139?>? strengthMovementVariant139 = null,

            global::System.Action<global::Terra.StrengthMovementVariant140?>? strengthMovementVariant140 = null,

            global::System.Action<global::Terra.StrengthMovementVariant141?>? strengthMovementVariant141 = null,

            global::System.Action<global::Terra.StrengthMovementVariant142?>? strengthMovementVariant142 = null,

            global::System.Action<global::Terra.StrengthMovementVariant143?>? strengthMovementVariant143 = null,

            global::System.Action<global::Terra.StrengthMovementVariant144?>? strengthMovementVariant144 = null,

            global::System.Action<global::Terra.StrengthMovementVariant145?>? strengthMovementVariant145 = null,

            global::System.Action<global::Terra.StrengthMovementVariant146?>? strengthMovementVariant146 = null,

            global::System.Action<global::Terra.StrengthMovementVariant147?>? strengthMovementVariant147 = null,

            global::System.Action<global::Terra.StrengthMovementVariant148?>? strengthMovementVariant148 = null,

            global::System.Action<global::Terra.StrengthMovementVariant149?>? strengthMovementVariant149 = null,

            global::System.Action<global::Terra.StrengthMovementVariant150?>? strengthMovementVariant150 = null,

            global::System.Action<global::Terra.StrengthMovementVariant151?>? strengthMovementVariant151 = null,

            global::System.Action<global::Terra.StrengthMovementVariant152?>? strengthMovementVariant152 = null,

            global::System.Action<global::Terra.StrengthMovementVariant153?>? strengthMovementVariant153 = null,

            global::System.Action<global::Terra.StrengthMovementVariant154?>? strengthMovementVariant154 = null,

            global::System.Action<global::Terra.StrengthMovementVariant155?>? strengthMovementVariant155 = null,

            global::System.Action<global::Terra.StrengthMovementVariant156?>? strengthMovementVariant156 = null,

            global::System.Action<global::Terra.StrengthMovementVariant157?>? strengthMovementVariant157 = null,

            global::System.Action<global::Terra.StrengthMovementVariant158?>? strengthMovementVariant158 = null,

            global::System.Action<global::Terra.StrengthMovementVariant159?>? strengthMovementVariant159 = null,

            global::System.Action<global::Terra.StrengthMovementVariant160?>? strengthMovementVariant160 = null,

            global::System.Action<global::Terra.StrengthMovementVariant161?>? strengthMovementVariant161 = null,

            global::System.Action<global::Terra.StrengthMovementVariant162?>? strengthMovementVariant162 = null,

            global::System.Action<global::Terra.StrengthMovementVariant163?>? strengthMovementVariant163 = null,

            global::System.Action<global::Terra.StrengthMovementVariant164?>? strengthMovementVariant164 = null,

            global::System.Action<global::Terra.StrengthMovementVariant165?>? strengthMovementVariant165 = null,

            global::System.Action<global::Terra.StrengthMovementVariant166?>? strengthMovementVariant166 = null,

            global::System.Action<global::Terra.StrengthMovementVariant167?>? strengthMovementVariant167 = null,

            global::System.Action<global::Terra.StrengthMovementVariant168?>? strengthMovementVariant168 = null,

            global::System.Action<global::Terra.StrengthMovementVariant169?>? strengthMovementVariant169 = null,

            global::System.Action<global::Terra.StrengthMovementVariant170?>? strengthMovementVariant170 = null,

            global::System.Action<global::Terra.StrengthMovementVariant171?>? strengthMovementVariant171 = null,

            global::System.Action<global::Terra.StrengthMovementVariant172?>? strengthMovementVariant172 = null,

            global::System.Action<global::Terra.StrengthMovementVariant173?>? strengthMovementVariant173 = null,

            global::System.Action<global::Terra.StrengthMovementVariant174?>? strengthMovementVariant174 = null,

            global::System.Action<global::Terra.StrengthMovementVariant175?>? strengthMovementVariant175 = null,

            global::System.Action<string>? strengthMovementVariant176 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthMovementVariant1)
            {
                strengthMovementVariant1?.Invoke(StrengthMovementVariant1!);
            }
            else if (IsStrengthMovementVariant2)
            {
                strengthMovementVariant2?.Invoke(StrengthMovementVariant2!);
            }
            else if (IsStrengthMovementVariant3)
            {
                strengthMovementVariant3?.Invoke(StrengthMovementVariant3!);
            }
            else if (IsStrengthMovementVariant4)
            {
                strengthMovementVariant4?.Invoke(StrengthMovementVariant4!);
            }
            else if (IsStrengthMovementVariant5)
            {
                strengthMovementVariant5?.Invoke(StrengthMovementVariant5!);
            }
            else if (IsStrengthMovementVariant6)
            {
                strengthMovementVariant6?.Invoke(StrengthMovementVariant6!);
            }
            else if (IsStrengthMovementVariant7)
            {
                strengthMovementVariant7?.Invoke(StrengthMovementVariant7!);
            }
            else if (IsStrengthMovementVariant8)
            {
                strengthMovementVariant8?.Invoke(StrengthMovementVariant8!);
            }
            else if (IsStrengthMovementVariant9)
            {
                strengthMovementVariant9?.Invoke(StrengthMovementVariant9!);
            }
            else if (IsStrengthMovementVariant10)
            {
                strengthMovementVariant10?.Invoke(StrengthMovementVariant10!);
            }
            else if (IsStrengthMovementVariant11)
            {
                strengthMovementVariant11?.Invoke(StrengthMovementVariant11!);
            }
            else if (IsStrengthMovementVariant12)
            {
                strengthMovementVariant12?.Invoke(StrengthMovementVariant12!);
            }
            else if (IsStrengthMovementVariant13)
            {
                strengthMovementVariant13?.Invoke(StrengthMovementVariant13!);
            }
            else if (IsStrengthMovementVariant14)
            {
                strengthMovementVariant14?.Invoke(StrengthMovementVariant14!);
            }
            else if (IsStrengthMovementVariant15)
            {
                strengthMovementVariant15?.Invoke(StrengthMovementVariant15!);
            }
            else if (IsStrengthMovementVariant16)
            {
                strengthMovementVariant16?.Invoke(StrengthMovementVariant16!);
            }
            else if (IsStrengthMovementVariant17)
            {
                strengthMovementVariant17?.Invoke(StrengthMovementVariant17!);
            }
            else if (IsStrengthMovementVariant18)
            {
                strengthMovementVariant18?.Invoke(StrengthMovementVariant18!);
            }
            else if (IsStrengthMovementVariant19)
            {
                strengthMovementVariant19?.Invoke(StrengthMovementVariant19!);
            }
            else if (IsStrengthMovementVariant20)
            {
                strengthMovementVariant20?.Invoke(StrengthMovementVariant20!);
            }
            else if (IsStrengthMovementVariant21)
            {
                strengthMovementVariant21?.Invoke(StrengthMovementVariant21!);
            }
            else if (IsStrengthMovementVariant22)
            {
                strengthMovementVariant22?.Invoke(StrengthMovementVariant22!);
            }
            else if (IsStrengthMovementVariant23)
            {
                strengthMovementVariant23?.Invoke(StrengthMovementVariant23!);
            }
            else if (IsStrengthMovementVariant24)
            {
                strengthMovementVariant24?.Invoke(StrengthMovementVariant24!);
            }
            else if (IsStrengthMovementVariant25)
            {
                strengthMovementVariant25?.Invoke(StrengthMovementVariant25!);
            }
            else if (IsStrengthMovementVariant26)
            {
                strengthMovementVariant26?.Invoke(StrengthMovementVariant26!);
            }
            else if (IsStrengthMovementVariant27)
            {
                strengthMovementVariant27?.Invoke(StrengthMovementVariant27!);
            }
            else if (IsStrengthMovementVariant28)
            {
                strengthMovementVariant28?.Invoke(StrengthMovementVariant28!);
            }
            else if (IsStrengthMovementVariant29)
            {
                strengthMovementVariant29?.Invoke(StrengthMovementVariant29!);
            }
            else if (IsStrengthMovementVariant30)
            {
                strengthMovementVariant30?.Invoke(StrengthMovementVariant30!);
            }
            else if (IsStrengthMovementVariant31)
            {
                strengthMovementVariant31?.Invoke(StrengthMovementVariant31!);
            }
            else if (IsStrengthMovementVariant32)
            {
                strengthMovementVariant32?.Invoke(StrengthMovementVariant32!);
            }
            else if (IsStrengthMovementVariant33)
            {
                strengthMovementVariant33?.Invoke(StrengthMovementVariant33!);
            }
            else if (IsStrengthMovementVariant34)
            {
                strengthMovementVariant34?.Invoke(StrengthMovementVariant34!);
            }
            else if (IsStrengthMovementVariant35)
            {
                strengthMovementVariant35?.Invoke(StrengthMovementVariant35!);
            }
            else if (IsStrengthMovementVariant36)
            {
                strengthMovementVariant36?.Invoke(StrengthMovementVariant36!);
            }
            else if (IsStrengthMovementVariant37)
            {
                strengthMovementVariant37?.Invoke(StrengthMovementVariant37!);
            }
            else if (IsStrengthMovementVariant38)
            {
                strengthMovementVariant38?.Invoke(StrengthMovementVariant38!);
            }
            else if (IsStrengthMovementVariant39)
            {
                strengthMovementVariant39?.Invoke(StrengthMovementVariant39!);
            }
            else if (IsStrengthMovementVariant40)
            {
                strengthMovementVariant40?.Invoke(StrengthMovementVariant40!);
            }
            else if (IsStrengthMovementVariant41)
            {
                strengthMovementVariant41?.Invoke(StrengthMovementVariant41!);
            }
            else if (IsStrengthMovementVariant42)
            {
                strengthMovementVariant42?.Invoke(StrengthMovementVariant42!);
            }
            else if (IsStrengthMovementVariant43)
            {
                strengthMovementVariant43?.Invoke(StrengthMovementVariant43!);
            }
            else if (IsStrengthMovementVariant44)
            {
                strengthMovementVariant44?.Invoke(StrengthMovementVariant44!);
            }
            else if (IsStrengthMovementVariant45)
            {
                strengthMovementVariant45?.Invoke(StrengthMovementVariant45!);
            }
            else if (IsStrengthMovementVariant46)
            {
                strengthMovementVariant46?.Invoke(StrengthMovementVariant46!);
            }
            else if (IsStrengthMovementVariant47)
            {
                strengthMovementVariant47?.Invoke(StrengthMovementVariant47!);
            }
            else if (IsStrengthMovementVariant48)
            {
                strengthMovementVariant48?.Invoke(StrengthMovementVariant48!);
            }
            else if (IsStrengthMovementVariant49)
            {
                strengthMovementVariant49?.Invoke(StrengthMovementVariant49!);
            }
            else if (IsStrengthMovementVariant50)
            {
                strengthMovementVariant50?.Invoke(StrengthMovementVariant50!);
            }
            else if (IsStrengthMovementVariant51)
            {
                strengthMovementVariant51?.Invoke(StrengthMovementVariant51!);
            }
            else if (IsStrengthMovementVariant52)
            {
                strengthMovementVariant52?.Invoke(StrengthMovementVariant52!);
            }
            else if (IsStrengthMovementVariant53)
            {
                strengthMovementVariant53?.Invoke(StrengthMovementVariant53!);
            }
            else if (IsStrengthMovementVariant54)
            {
                strengthMovementVariant54?.Invoke(StrengthMovementVariant54!);
            }
            else if (IsStrengthMovementVariant55)
            {
                strengthMovementVariant55?.Invoke(StrengthMovementVariant55!);
            }
            else if (IsStrengthMovementVariant56)
            {
                strengthMovementVariant56?.Invoke(StrengthMovementVariant56!);
            }
            else if (IsStrengthMovementVariant57)
            {
                strengthMovementVariant57?.Invoke(StrengthMovementVariant57!);
            }
            else if (IsStrengthMovementVariant58)
            {
                strengthMovementVariant58?.Invoke(StrengthMovementVariant58!);
            }
            else if (IsStrengthMovementVariant59)
            {
                strengthMovementVariant59?.Invoke(StrengthMovementVariant59!);
            }
            else if (IsStrengthMovementVariant60)
            {
                strengthMovementVariant60?.Invoke(StrengthMovementVariant60!);
            }
            else if (IsStrengthMovementVariant61)
            {
                strengthMovementVariant61?.Invoke(StrengthMovementVariant61!);
            }
            else if (IsStrengthMovementVariant62)
            {
                strengthMovementVariant62?.Invoke(StrengthMovementVariant62!);
            }
            else if (IsStrengthMovementVariant63)
            {
                strengthMovementVariant63?.Invoke(StrengthMovementVariant63!);
            }
            else if (IsStrengthMovementVariant64)
            {
                strengthMovementVariant64?.Invoke(StrengthMovementVariant64!);
            }
            else if (IsStrengthMovementVariant65)
            {
                strengthMovementVariant65?.Invoke(StrengthMovementVariant65!);
            }
            else if (IsStrengthMovementVariant66)
            {
                strengthMovementVariant66?.Invoke(StrengthMovementVariant66!);
            }
            else if (IsStrengthMovementVariant67)
            {
                strengthMovementVariant67?.Invoke(StrengthMovementVariant67!);
            }
            else if (IsStrengthMovementVariant68)
            {
                strengthMovementVariant68?.Invoke(StrengthMovementVariant68!);
            }
            else if (IsStrengthMovementVariant69)
            {
                strengthMovementVariant69?.Invoke(StrengthMovementVariant69!);
            }
            else if (IsStrengthMovementVariant70)
            {
                strengthMovementVariant70?.Invoke(StrengthMovementVariant70!);
            }
            else if (IsStrengthMovementVariant71)
            {
                strengthMovementVariant71?.Invoke(StrengthMovementVariant71!);
            }
            else if (IsStrengthMovementVariant72)
            {
                strengthMovementVariant72?.Invoke(StrengthMovementVariant72!);
            }
            else if (IsStrengthMovementVariant73)
            {
                strengthMovementVariant73?.Invoke(StrengthMovementVariant73!);
            }
            else if (IsStrengthMovementVariant74)
            {
                strengthMovementVariant74?.Invoke(StrengthMovementVariant74!);
            }
            else if (IsStrengthMovementVariant75)
            {
                strengthMovementVariant75?.Invoke(StrengthMovementVariant75!);
            }
            else if (IsStrengthMovementVariant76)
            {
                strengthMovementVariant76?.Invoke(StrengthMovementVariant76!);
            }
            else if (IsStrengthMovementVariant77)
            {
                strengthMovementVariant77?.Invoke(StrengthMovementVariant77!);
            }
            else if (IsStrengthMovementVariant78)
            {
                strengthMovementVariant78?.Invoke(StrengthMovementVariant78!);
            }
            else if (IsStrengthMovementVariant79)
            {
                strengthMovementVariant79?.Invoke(StrengthMovementVariant79!);
            }
            else if (IsStrengthMovementVariant80)
            {
                strengthMovementVariant80?.Invoke(StrengthMovementVariant80!);
            }
            else if (IsStrengthMovementVariant81)
            {
                strengthMovementVariant81?.Invoke(StrengthMovementVariant81!);
            }
            else if (IsStrengthMovementVariant82)
            {
                strengthMovementVariant82?.Invoke(StrengthMovementVariant82!);
            }
            else if (IsStrengthMovementVariant83)
            {
                strengthMovementVariant83?.Invoke(StrengthMovementVariant83!);
            }
            else if (IsStrengthMovementVariant84)
            {
                strengthMovementVariant84?.Invoke(StrengthMovementVariant84!);
            }
            else if (IsStrengthMovementVariant85)
            {
                strengthMovementVariant85?.Invoke(StrengthMovementVariant85!);
            }
            else if (IsStrengthMovementVariant86)
            {
                strengthMovementVariant86?.Invoke(StrengthMovementVariant86!);
            }
            else if (IsStrengthMovementVariant87)
            {
                strengthMovementVariant87?.Invoke(StrengthMovementVariant87!);
            }
            else if (IsStrengthMovementVariant88)
            {
                strengthMovementVariant88?.Invoke(StrengthMovementVariant88!);
            }
            else if (IsStrengthMovementVariant89)
            {
                strengthMovementVariant89?.Invoke(StrengthMovementVariant89!);
            }
            else if (IsStrengthMovementVariant90)
            {
                strengthMovementVariant90?.Invoke(StrengthMovementVariant90!);
            }
            else if (IsStrengthMovementVariant91)
            {
                strengthMovementVariant91?.Invoke(StrengthMovementVariant91!);
            }
            else if (IsStrengthMovementVariant92)
            {
                strengthMovementVariant92?.Invoke(StrengthMovementVariant92!);
            }
            else if (IsStrengthMovementVariant93)
            {
                strengthMovementVariant93?.Invoke(StrengthMovementVariant93!);
            }
            else if (IsStrengthMovementVariant94)
            {
                strengthMovementVariant94?.Invoke(StrengthMovementVariant94!);
            }
            else if (IsStrengthMovementVariant95)
            {
                strengthMovementVariant95?.Invoke(StrengthMovementVariant95!);
            }
            else if (IsStrengthMovementVariant96)
            {
                strengthMovementVariant96?.Invoke(StrengthMovementVariant96!);
            }
            else if (IsStrengthMovementVariant97)
            {
                strengthMovementVariant97?.Invoke(StrengthMovementVariant97!);
            }
            else if (IsStrengthMovementVariant98)
            {
                strengthMovementVariant98?.Invoke(StrengthMovementVariant98!);
            }
            else if (IsStrengthMovementVariant99)
            {
                strengthMovementVariant99?.Invoke(StrengthMovementVariant99!);
            }
            else if (IsStrengthMovementVariant100)
            {
                strengthMovementVariant100?.Invoke(StrengthMovementVariant100!);
            }
            else if (IsStrengthMovementVariant101)
            {
                strengthMovementVariant101?.Invoke(StrengthMovementVariant101!);
            }
            else if (IsStrengthMovementVariant102)
            {
                strengthMovementVariant102?.Invoke(StrengthMovementVariant102!);
            }
            else if (IsStrengthMovementVariant103)
            {
                strengthMovementVariant103?.Invoke(StrengthMovementVariant103!);
            }
            else if (IsStrengthMovementVariant104)
            {
                strengthMovementVariant104?.Invoke(StrengthMovementVariant104!);
            }
            else if (IsStrengthMovementVariant105)
            {
                strengthMovementVariant105?.Invoke(StrengthMovementVariant105!);
            }
            else if (IsStrengthMovementVariant106)
            {
                strengthMovementVariant106?.Invoke(StrengthMovementVariant106!);
            }
            else if (IsStrengthMovementVariant107)
            {
                strengthMovementVariant107?.Invoke(StrengthMovementVariant107!);
            }
            else if (IsStrengthMovementVariant108)
            {
                strengthMovementVariant108?.Invoke(StrengthMovementVariant108!);
            }
            else if (IsStrengthMovementVariant109)
            {
                strengthMovementVariant109?.Invoke(StrengthMovementVariant109!);
            }
            else if (IsStrengthMovementVariant110)
            {
                strengthMovementVariant110?.Invoke(StrengthMovementVariant110!);
            }
            else if (IsStrengthMovementVariant111)
            {
                strengthMovementVariant111?.Invoke(StrengthMovementVariant111!);
            }
            else if (IsStrengthMovementVariant112)
            {
                strengthMovementVariant112?.Invoke(StrengthMovementVariant112!);
            }
            else if (IsStrengthMovementVariant113)
            {
                strengthMovementVariant113?.Invoke(StrengthMovementVariant113!);
            }
            else if (IsStrengthMovementVariant114)
            {
                strengthMovementVariant114?.Invoke(StrengthMovementVariant114!);
            }
            else if (IsStrengthMovementVariant115)
            {
                strengthMovementVariant115?.Invoke(StrengthMovementVariant115!);
            }
            else if (IsStrengthMovementVariant116)
            {
                strengthMovementVariant116?.Invoke(StrengthMovementVariant116!);
            }
            else if (IsStrengthMovementVariant117)
            {
                strengthMovementVariant117?.Invoke(StrengthMovementVariant117!);
            }
            else if (IsStrengthMovementVariant118)
            {
                strengthMovementVariant118?.Invoke(StrengthMovementVariant118!);
            }
            else if (IsStrengthMovementVariant119)
            {
                strengthMovementVariant119?.Invoke(StrengthMovementVariant119!);
            }
            else if (IsStrengthMovementVariant120)
            {
                strengthMovementVariant120?.Invoke(StrengthMovementVariant120!);
            }
            else if (IsStrengthMovementVariant121)
            {
                strengthMovementVariant121?.Invoke(StrengthMovementVariant121!);
            }
            else if (IsStrengthMovementVariant122)
            {
                strengthMovementVariant122?.Invoke(StrengthMovementVariant122!);
            }
            else if (IsStrengthMovementVariant123)
            {
                strengthMovementVariant123?.Invoke(StrengthMovementVariant123!);
            }
            else if (IsStrengthMovementVariant124)
            {
                strengthMovementVariant124?.Invoke(StrengthMovementVariant124!);
            }
            else if (IsStrengthMovementVariant125)
            {
                strengthMovementVariant125?.Invoke(StrengthMovementVariant125!);
            }
            else if (IsStrengthMovementVariant126)
            {
                strengthMovementVariant126?.Invoke(StrengthMovementVariant126!);
            }
            else if (IsStrengthMovementVariant127)
            {
                strengthMovementVariant127?.Invoke(StrengthMovementVariant127!);
            }
            else if (IsStrengthMovementVariant128)
            {
                strengthMovementVariant128?.Invoke(StrengthMovementVariant128!);
            }
            else if (IsStrengthMovementVariant129)
            {
                strengthMovementVariant129?.Invoke(StrengthMovementVariant129!);
            }
            else if (IsStrengthMovementVariant130)
            {
                strengthMovementVariant130?.Invoke(StrengthMovementVariant130!);
            }
            else if (IsStrengthMovementVariant131)
            {
                strengthMovementVariant131?.Invoke(StrengthMovementVariant131!);
            }
            else if (IsStrengthMovementVariant132)
            {
                strengthMovementVariant132?.Invoke(StrengthMovementVariant132!);
            }
            else if (IsStrengthMovementVariant133)
            {
                strengthMovementVariant133?.Invoke(StrengthMovementVariant133!);
            }
            else if (IsStrengthMovementVariant134)
            {
                strengthMovementVariant134?.Invoke(StrengthMovementVariant134!);
            }
            else if (IsStrengthMovementVariant135)
            {
                strengthMovementVariant135?.Invoke(StrengthMovementVariant135!);
            }
            else if (IsStrengthMovementVariant136)
            {
                strengthMovementVariant136?.Invoke(StrengthMovementVariant136!);
            }
            else if (IsStrengthMovementVariant137)
            {
                strengthMovementVariant137?.Invoke(StrengthMovementVariant137!);
            }
            else if (IsStrengthMovementVariant138)
            {
                strengthMovementVariant138?.Invoke(StrengthMovementVariant138!);
            }
            else if (IsStrengthMovementVariant139)
            {
                strengthMovementVariant139?.Invoke(StrengthMovementVariant139!);
            }
            else if (IsStrengthMovementVariant140)
            {
                strengthMovementVariant140?.Invoke(StrengthMovementVariant140!);
            }
            else if (IsStrengthMovementVariant141)
            {
                strengthMovementVariant141?.Invoke(StrengthMovementVariant141!);
            }
            else if (IsStrengthMovementVariant142)
            {
                strengthMovementVariant142?.Invoke(StrengthMovementVariant142!);
            }
            else if (IsStrengthMovementVariant143)
            {
                strengthMovementVariant143?.Invoke(StrengthMovementVariant143!);
            }
            else if (IsStrengthMovementVariant144)
            {
                strengthMovementVariant144?.Invoke(StrengthMovementVariant144!);
            }
            else if (IsStrengthMovementVariant145)
            {
                strengthMovementVariant145?.Invoke(StrengthMovementVariant145!);
            }
            else if (IsStrengthMovementVariant146)
            {
                strengthMovementVariant146?.Invoke(StrengthMovementVariant146!);
            }
            else if (IsStrengthMovementVariant147)
            {
                strengthMovementVariant147?.Invoke(StrengthMovementVariant147!);
            }
            else if (IsStrengthMovementVariant148)
            {
                strengthMovementVariant148?.Invoke(StrengthMovementVariant148!);
            }
            else if (IsStrengthMovementVariant149)
            {
                strengthMovementVariant149?.Invoke(StrengthMovementVariant149!);
            }
            else if (IsStrengthMovementVariant150)
            {
                strengthMovementVariant150?.Invoke(StrengthMovementVariant150!);
            }
            else if (IsStrengthMovementVariant151)
            {
                strengthMovementVariant151?.Invoke(StrengthMovementVariant151!);
            }
            else if (IsStrengthMovementVariant152)
            {
                strengthMovementVariant152?.Invoke(StrengthMovementVariant152!);
            }
            else if (IsStrengthMovementVariant153)
            {
                strengthMovementVariant153?.Invoke(StrengthMovementVariant153!);
            }
            else if (IsStrengthMovementVariant154)
            {
                strengthMovementVariant154?.Invoke(StrengthMovementVariant154!);
            }
            else if (IsStrengthMovementVariant155)
            {
                strengthMovementVariant155?.Invoke(StrengthMovementVariant155!);
            }
            else if (IsStrengthMovementVariant156)
            {
                strengthMovementVariant156?.Invoke(StrengthMovementVariant156!);
            }
            else if (IsStrengthMovementVariant157)
            {
                strengthMovementVariant157?.Invoke(StrengthMovementVariant157!);
            }
            else if (IsStrengthMovementVariant158)
            {
                strengthMovementVariant158?.Invoke(StrengthMovementVariant158!);
            }
            else if (IsStrengthMovementVariant159)
            {
                strengthMovementVariant159?.Invoke(StrengthMovementVariant159!);
            }
            else if (IsStrengthMovementVariant160)
            {
                strengthMovementVariant160?.Invoke(StrengthMovementVariant160!);
            }
            else if (IsStrengthMovementVariant161)
            {
                strengthMovementVariant161?.Invoke(StrengthMovementVariant161!);
            }
            else if (IsStrengthMovementVariant162)
            {
                strengthMovementVariant162?.Invoke(StrengthMovementVariant162!);
            }
            else if (IsStrengthMovementVariant163)
            {
                strengthMovementVariant163?.Invoke(StrengthMovementVariant163!);
            }
            else if (IsStrengthMovementVariant164)
            {
                strengthMovementVariant164?.Invoke(StrengthMovementVariant164!);
            }
            else if (IsStrengthMovementVariant165)
            {
                strengthMovementVariant165?.Invoke(StrengthMovementVariant165!);
            }
            else if (IsStrengthMovementVariant166)
            {
                strengthMovementVariant166?.Invoke(StrengthMovementVariant166!);
            }
            else if (IsStrengthMovementVariant167)
            {
                strengthMovementVariant167?.Invoke(StrengthMovementVariant167!);
            }
            else if (IsStrengthMovementVariant168)
            {
                strengthMovementVariant168?.Invoke(StrengthMovementVariant168!);
            }
            else if (IsStrengthMovementVariant169)
            {
                strengthMovementVariant169?.Invoke(StrengthMovementVariant169!);
            }
            else if (IsStrengthMovementVariant170)
            {
                strengthMovementVariant170?.Invoke(StrengthMovementVariant170!);
            }
            else if (IsStrengthMovementVariant171)
            {
                strengthMovementVariant171?.Invoke(StrengthMovementVariant171!);
            }
            else if (IsStrengthMovementVariant172)
            {
                strengthMovementVariant172?.Invoke(StrengthMovementVariant172!);
            }
            else if (IsStrengthMovementVariant173)
            {
                strengthMovementVariant173?.Invoke(StrengthMovementVariant173!);
            }
            else if (IsStrengthMovementVariant174)
            {
                strengthMovementVariant174?.Invoke(StrengthMovementVariant174!);
            }
            else if (IsStrengthMovementVariant175)
            {
                strengthMovementVariant175?.Invoke(StrengthMovementVariant175!);
            }
            else if (IsStrengthMovementVariant176)
            {
                strengthMovementVariant176?.Invoke(StrengthMovementVariant176!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthMovementVariant1?>? strengthMovementVariant1 = null,
            global::System.Action<global::Terra.StrengthMovementVariant2?>? strengthMovementVariant2 = null,
            global::System.Action<global::Terra.StrengthMovementVariant3?>? strengthMovementVariant3 = null,
            global::System.Action<global::Terra.StrengthMovementVariant4?>? strengthMovementVariant4 = null,
            global::System.Action<global::Terra.StrengthMovementVariant5?>? strengthMovementVariant5 = null,
            global::System.Action<global::Terra.StrengthMovementVariant6?>? strengthMovementVariant6 = null,
            global::System.Action<global::Terra.StrengthMovementVariant7?>? strengthMovementVariant7 = null,
            global::System.Action<global::Terra.StrengthMovementVariant8?>? strengthMovementVariant8 = null,
            global::System.Action<global::Terra.StrengthMovementVariant9?>? strengthMovementVariant9 = null,
            global::System.Action<global::Terra.StrengthMovementVariant10?>? strengthMovementVariant10 = null,
            global::System.Action<global::Terra.StrengthMovementVariant11?>? strengthMovementVariant11 = null,
            global::System.Action<global::Terra.StrengthMovementVariant12?>? strengthMovementVariant12 = null,
            global::System.Action<global::Terra.StrengthMovementVariant13?>? strengthMovementVariant13 = null,
            global::System.Action<global::Terra.StrengthMovementVariant14?>? strengthMovementVariant14 = null,
            global::System.Action<global::Terra.StrengthMovementVariant15?>? strengthMovementVariant15 = null,
            global::System.Action<global::Terra.StrengthMovementVariant16?>? strengthMovementVariant16 = null,
            global::System.Action<global::Terra.StrengthMovementVariant17?>? strengthMovementVariant17 = null,
            global::System.Action<global::Terra.StrengthMovementVariant18?>? strengthMovementVariant18 = null,
            global::System.Action<global::Terra.StrengthMovementVariant19?>? strengthMovementVariant19 = null,
            global::System.Action<global::Terra.StrengthMovementVariant20?>? strengthMovementVariant20 = null,
            global::System.Action<global::Terra.StrengthMovementVariant21?>? strengthMovementVariant21 = null,
            global::System.Action<global::Terra.StrengthMovementVariant22?>? strengthMovementVariant22 = null,
            global::System.Action<global::Terra.StrengthMovementVariant23?>? strengthMovementVariant23 = null,
            global::System.Action<global::Terra.StrengthMovementVariant24?>? strengthMovementVariant24 = null,
            global::System.Action<global::Terra.StrengthMovementVariant25?>? strengthMovementVariant25 = null,
            global::System.Action<global::Terra.StrengthMovementVariant26?>? strengthMovementVariant26 = null,
            global::System.Action<global::Terra.StrengthMovementVariant27?>? strengthMovementVariant27 = null,
            global::System.Action<global::Terra.StrengthMovementVariant28?>? strengthMovementVariant28 = null,
            global::System.Action<global::Terra.StrengthMovementVariant29?>? strengthMovementVariant29 = null,
            global::System.Action<global::Terra.StrengthMovementVariant30?>? strengthMovementVariant30 = null,
            global::System.Action<global::Terra.StrengthMovementVariant31?>? strengthMovementVariant31 = null,
            global::System.Action<global::Terra.StrengthMovementVariant32?>? strengthMovementVariant32 = null,
            global::System.Action<global::Terra.StrengthMovementVariant33?>? strengthMovementVariant33 = null,
            global::System.Action<global::Terra.StrengthMovementVariant34?>? strengthMovementVariant34 = null,
            global::System.Action<global::Terra.StrengthMovementVariant35?>? strengthMovementVariant35 = null,
            global::System.Action<global::Terra.StrengthMovementVariant36?>? strengthMovementVariant36 = null,
            global::System.Action<global::Terra.StrengthMovementVariant37?>? strengthMovementVariant37 = null,
            global::System.Action<global::Terra.StrengthMovementVariant38?>? strengthMovementVariant38 = null,
            global::System.Action<global::Terra.StrengthMovementVariant39?>? strengthMovementVariant39 = null,
            global::System.Action<global::Terra.StrengthMovementVariant40?>? strengthMovementVariant40 = null,
            global::System.Action<global::Terra.StrengthMovementVariant41?>? strengthMovementVariant41 = null,
            global::System.Action<global::Terra.StrengthMovementVariant42?>? strengthMovementVariant42 = null,
            global::System.Action<global::Terra.StrengthMovementVariant43?>? strengthMovementVariant43 = null,
            global::System.Action<global::Terra.StrengthMovementVariant44?>? strengthMovementVariant44 = null,
            global::System.Action<global::Terra.StrengthMovementVariant45?>? strengthMovementVariant45 = null,
            global::System.Action<global::Terra.StrengthMovementVariant46?>? strengthMovementVariant46 = null,
            global::System.Action<global::Terra.StrengthMovementVariant47?>? strengthMovementVariant47 = null,
            global::System.Action<global::Terra.StrengthMovementVariant48?>? strengthMovementVariant48 = null,
            global::System.Action<global::Terra.StrengthMovementVariant49?>? strengthMovementVariant49 = null,
            global::System.Action<global::Terra.StrengthMovementVariant50?>? strengthMovementVariant50 = null,
            global::System.Action<global::Terra.StrengthMovementVariant51?>? strengthMovementVariant51 = null,
            global::System.Action<global::Terra.StrengthMovementVariant52?>? strengthMovementVariant52 = null,
            global::System.Action<global::Terra.StrengthMovementVariant53?>? strengthMovementVariant53 = null,
            global::System.Action<global::Terra.StrengthMovementVariant54?>? strengthMovementVariant54 = null,
            global::System.Action<global::Terra.StrengthMovementVariant55?>? strengthMovementVariant55 = null,
            global::System.Action<global::Terra.StrengthMovementVariant56?>? strengthMovementVariant56 = null,
            global::System.Action<global::Terra.StrengthMovementVariant57?>? strengthMovementVariant57 = null,
            global::System.Action<global::Terra.StrengthMovementVariant58?>? strengthMovementVariant58 = null,
            global::System.Action<global::Terra.StrengthMovementVariant59?>? strengthMovementVariant59 = null,
            global::System.Action<global::Terra.StrengthMovementVariant60?>? strengthMovementVariant60 = null,
            global::System.Action<global::Terra.StrengthMovementVariant61?>? strengthMovementVariant61 = null,
            global::System.Action<global::Terra.StrengthMovementVariant62?>? strengthMovementVariant62 = null,
            global::System.Action<global::Terra.StrengthMovementVariant63?>? strengthMovementVariant63 = null,
            global::System.Action<global::Terra.StrengthMovementVariant64?>? strengthMovementVariant64 = null,
            global::System.Action<global::Terra.StrengthMovementVariant65?>? strengthMovementVariant65 = null,
            global::System.Action<global::Terra.StrengthMovementVariant66?>? strengthMovementVariant66 = null,
            global::System.Action<global::Terra.StrengthMovementVariant67?>? strengthMovementVariant67 = null,
            global::System.Action<global::Terra.StrengthMovementVariant68?>? strengthMovementVariant68 = null,
            global::System.Action<global::Terra.StrengthMovementVariant69?>? strengthMovementVariant69 = null,
            global::System.Action<global::Terra.StrengthMovementVariant70?>? strengthMovementVariant70 = null,
            global::System.Action<global::Terra.StrengthMovementVariant71?>? strengthMovementVariant71 = null,
            global::System.Action<global::Terra.StrengthMovementVariant72?>? strengthMovementVariant72 = null,
            global::System.Action<global::Terra.StrengthMovementVariant73?>? strengthMovementVariant73 = null,
            global::System.Action<global::Terra.StrengthMovementVariant74?>? strengthMovementVariant74 = null,
            global::System.Action<global::Terra.StrengthMovementVariant75?>? strengthMovementVariant75 = null,
            global::System.Action<global::Terra.StrengthMovementVariant76?>? strengthMovementVariant76 = null,
            global::System.Action<global::Terra.StrengthMovementVariant77?>? strengthMovementVariant77 = null,
            global::System.Action<global::Terra.StrengthMovementVariant78?>? strengthMovementVariant78 = null,
            global::System.Action<global::Terra.StrengthMovementVariant79?>? strengthMovementVariant79 = null,
            global::System.Action<global::Terra.StrengthMovementVariant80?>? strengthMovementVariant80 = null,
            global::System.Action<global::Terra.StrengthMovementVariant81?>? strengthMovementVariant81 = null,
            global::System.Action<global::Terra.StrengthMovementVariant82?>? strengthMovementVariant82 = null,
            global::System.Action<global::Terra.StrengthMovementVariant83?>? strengthMovementVariant83 = null,
            global::System.Action<global::Terra.StrengthMovementVariant84?>? strengthMovementVariant84 = null,
            global::System.Action<global::Terra.StrengthMovementVariant85?>? strengthMovementVariant85 = null,
            global::System.Action<global::Terra.StrengthMovementVariant86?>? strengthMovementVariant86 = null,
            global::System.Action<global::Terra.StrengthMovementVariant87?>? strengthMovementVariant87 = null,
            global::System.Action<global::Terra.StrengthMovementVariant88?>? strengthMovementVariant88 = null,
            global::System.Action<global::Terra.StrengthMovementVariant89?>? strengthMovementVariant89 = null,
            global::System.Action<global::Terra.StrengthMovementVariant90?>? strengthMovementVariant90 = null,
            global::System.Action<global::Terra.StrengthMovementVariant91?>? strengthMovementVariant91 = null,
            global::System.Action<global::Terra.StrengthMovementVariant92?>? strengthMovementVariant92 = null,
            global::System.Action<global::Terra.StrengthMovementVariant93?>? strengthMovementVariant93 = null,
            global::System.Action<global::Terra.StrengthMovementVariant94?>? strengthMovementVariant94 = null,
            global::System.Action<global::Terra.StrengthMovementVariant95?>? strengthMovementVariant95 = null,
            global::System.Action<global::Terra.StrengthMovementVariant96?>? strengthMovementVariant96 = null,
            global::System.Action<global::Terra.StrengthMovementVariant97?>? strengthMovementVariant97 = null,
            global::System.Action<global::Terra.StrengthMovementVariant98?>? strengthMovementVariant98 = null,
            global::System.Action<global::Terra.StrengthMovementVariant99?>? strengthMovementVariant99 = null,
            global::System.Action<global::Terra.StrengthMovementVariant100?>? strengthMovementVariant100 = null,
            global::System.Action<global::Terra.StrengthMovementVariant101?>? strengthMovementVariant101 = null,
            global::System.Action<global::Terra.StrengthMovementVariant102?>? strengthMovementVariant102 = null,
            global::System.Action<global::Terra.StrengthMovementVariant103?>? strengthMovementVariant103 = null,
            global::System.Action<global::Terra.StrengthMovementVariant104?>? strengthMovementVariant104 = null,
            global::System.Action<global::Terra.StrengthMovementVariant105?>? strengthMovementVariant105 = null,
            global::System.Action<global::Terra.StrengthMovementVariant106?>? strengthMovementVariant106 = null,
            global::System.Action<global::Terra.StrengthMovementVariant107?>? strengthMovementVariant107 = null,
            global::System.Action<global::Terra.StrengthMovementVariant108?>? strengthMovementVariant108 = null,
            global::System.Action<global::Terra.StrengthMovementVariant109?>? strengthMovementVariant109 = null,
            global::System.Action<global::Terra.StrengthMovementVariant110?>? strengthMovementVariant110 = null,
            global::System.Action<global::Terra.StrengthMovementVariant111?>? strengthMovementVariant111 = null,
            global::System.Action<global::Terra.StrengthMovementVariant112?>? strengthMovementVariant112 = null,
            global::System.Action<global::Terra.StrengthMovementVariant113?>? strengthMovementVariant113 = null,
            global::System.Action<global::Terra.StrengthMovementVariant114?>? strengthMovementVariant114 = null,
            global::System.Action<global::Terra.StrengthMovementVariant115?>? strengthMovementVariant115 = null,
            global::System.Action<global::Terra.StrengthMovementVariant116?>? strengthMovementVariant116 = null,
            global::System.Action<global::Terra.StrengthMovementVariant117?>? strengthMovementVariant117 = null,
            global::System.Action<global::Terra.StrengthMovementVariant118?>? strengthMovementVariant118 = null,
            global::System.Action<global::Terra.StrengthMovementVariant119?>? strengthMovementVariant119 = null,
            global::System.Action<global::Terra.StrengthMovementVariant120?>? strengthMovementVariant120 = null,
            global::System.Action<global::Terra.StrengthMovementVariant121?>? strengthMovementVariant121 = null,
            global::System.Action<global::Terra.StrengthMovementVariant122?>? strengthMovementVariant122 = null,
            global::System.Action<global::Terra.StrengthMovementVariant123?>? strengthMovementVariant123 = null,
            global::System.Action<global::Terra.StrengthMovementVariant124?>? strengthMovementVariant124 = null,
            global::System.Action<global::Terra.StrengthMovementVariant125?>? strengthMovementVariant125 = null,
            global::System.Action<global::Terra.StrengthMovementVariant126?>? strengthMovementVariant126 = null,
            global::System.Action<global::Terra.StrengthMovementVariant127?>? strengthMovementVariant127 = null,
            global::System.Action<global::Terra.StrengthMovementVariant128?>? strengthMovementVariant128 = null,
            global::System.Action<global::Terra.StrengthMovementVariant129?>? strengthMovementVariant129 = null,
            global::System.Action<global::Terra.StrengthMovementVariant130?>? strengthMovementVariant130 = null,
            global::System.Action<global::Terra.StrengthMovementVariant131?>? strengthMovementVariant131 = null,
            global::System.Action<global::Terra.StrengthMovementVariant132?>? strengthMovementVariant132 = null,
            global::System.Action<global::Terra.StrengthMovementVariant133?>? strengthMovementVariant133 = null,
            global::System.Action<global::Terra.StrengthMovementVariant134?>? strengthMovementVariant134 = null,
            global::System.Action<global::Terra.StrengthMovementVariant135?>? strengthMovementVariant135 = null,
            global::System.Action<global::Terra.StrengthMovementVariant136?>? strengthMovementVariant136 = null,
            global::System.Action<global::Terra.StrengthMovementVariant137?>? strengthMovementVariant137 = null,
            global::System.Action<global::Terra.StrengthMovementVariant138?>? strengthMovementVariant138 = null,
            global::System.Action<global::Terra.StrengthMovementVariant139?>? strengthMovementVariant139 = null,
            global::System.Action<global::Terra.StrengthMovementVariant140?>? strengthMovementVariant140 = null,
            global::System.Action<global::Terra.StrengthMovementVariant141?>? strengthMovementVariant141 = null,
            global::System.Action<global::Terra.StrengthMovementVariant142?>? strengthMovementVariant142 = null,
            global::System.Action<global::Terra.StrengthMovementVariant143?>? strengthMovementVariant143 = null,
            global::System.Action<global::Terra.StrengthMovementVariant144?>? strengthMovementVariant144 = null,
            global::System.Action<global::Terra.StrengthMovementVariant145?>? strengthMovementVariant145 = null,
            global::System.Action<global::Terra.StrengthMovementVariant146?>? strengthMovementVariant146 = null,
            global::System.Action<global::Terra.StrengthMovementVariant147?>? strengthMovementVariant147 = null,
            global::System.Action<global::Terra.StrengthMovementVariant148?>? strengthMovementVariant148 = null,
            global::System.Action<global::Terra.StrengthMovementVariant149?>? strengthMovementVariant149 = null,
            global::System.Action<global::Terra.StrengthMovementVariant150?>? strengthMovementVariant150 = null,
            global::System.Action<global::Terra.StrengthMovementVariant151?>? strengthMovementVariant151 = null,
            global::System.Action<global::Terra.StrengthMovementVariant152?>? strengthMovementVariant152 = null,
            global::System.Action<global::Terra.StrengthMovementVariant153?>? strengthMovementVariant153 = null,
            global::System.Action<global::Terra.StrengthMovementVariant154?>? strengthMovementVariant154 = null,
            global::System.Action<global::Terra.StrengthMovementVariant155?>? strengthMovementVariant155 = null,
            global::System.Action<global::Terra.StrengthMovementVariant156?>? strengthMovementVariant156 = null,
            global::System.Action<global::Terra.StrengthMovementVariant157?>? strengthMovementVariant157 = null,
            global::System.Action<global::Terra.StrengthMovementVariant158?>? strengthMovementVariant158 = null,
            global::System.Action<global::Terra.StrengthMovementVariant159?>? strengthMovementVariant159 = null,
            global::System.Action<global::Terra.StrengthMovementVariant160?>? strengthMovementVariant160 = null,
            global::System.Action<global::Terra.StrengthMovementVariant161?>? strengthMovementVariant161 = null,
            global::System.Action<global::Terra.StrengthMovementVariant162?>? strengthMovementVariant162 = null,
            global::System.Action<global::Terra.StrengthMovementVariant163?>? strengthMovementVariant163 = null,
            global::System.Action<global::Terra.StrengthMovementVariant164?>? strengthMovementVariant164 = null,
            global::System.Action<global::Terra.StrengthMovementVariant165?>? strengthMovementVariant165 = null,
            global::System.Action<global::Terra.StrengthMovementVariant166?>? strengthMovementVariant166 = null,
            global::System.Action<global::Terra.StrengthMovementVariant167?>? strengthMovementVariant167 = null,
            global::System.Action<global::Terra.StrengthMovementVariant168?>? strengthMovementVariant168 = null,
            global::System.Action<global::Terra.StrengthMovementVariant169?>? strengthMovementVariant169 = null,
            global::System.Action<global::Terra.StrengthMovementVariant170?>? strengthMovementVariant170 = null,
            global::System.Action<global::Terra.StrengthMovementVariant171?>? strengthMovementVariant171 = null,
            global::System.Action<global::Terra.StrengthMovementVariant172?>? strengthMovementVariant172 = null,
            global::System.Action<global::Terra.StrengthMovementVariant173?>? strengthMovementVariant173 = null,
            global::System.Action<global::Terra.StrengthMovementVariant174?>? strengthMovementVariant174 = null,
            global::System.Action<global::Terra.StrengthMovementVariant175?>? strengthMovementVariant175 = null,
            global::System.Action<string>? strengthMovementVariant176 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthMovementVariant1)
            {
                strengthMovementVariant1?.Invoke(StrengthMovementVariant1!);
            }
            else if (IsStrengthMovementVariant2)
            {
                strengthMovementVariant2?.Invoke(StrengthMovementVariant2!);
            }
            else if (IsStrengthMovementVariant3)
            {
                strengthMovementVariant3?.Invoke(StrengthMovementVariant3!);
            }
            else if (IsStrengthMovementVariant4)
            {
                strengthMovementVariant4?.Invoke(StrengthMovementVariant4!);
            }
            else if (IsStrengthMovementVariant5)
            {
                strengthMovementVariant5?.Invoke(StrengthMovementVariant5!);
            }
            else if (IsStrengthMovementVariant6)
            {
                strengthMovementVariant6?.Invoke(StrengthMovementVariant6!);
            }
            else if (IsStrengthMovementVariant7)
            {
                strengthMovementVariant7?.Invoke(StrengthMovementVariant7!);
            }
            else if (IsStrengthMovementVariant8)
            {
                strengthMovementVariant8?.Invoke(StrengthMovementVariant8!);
            }
            else if (IsStrengthMovementVariant9)
            {
                strengthMovementVariant9?.Invoke(StrengthMovementVariant9!);
            }
            else if (IsStrengthMovementVariant10)
            {
                strengthMovementVariant10?.Invoke(StrengthMovementVariant10!);
            }
            else if (IsStrengthMovementVariant11)
            {
                strengthMovementVariant11?.Invoke(StrengthMovementVariant11!);
            }
            else if (IsStrengthMovementVariant12)
            {
                strengthMovementVariant12?.Invoke(StrengthMovementVariant12!);
            }
            else if (IsStrengthMovementVariant13)
            {
                strengthMovementVariant13?.Invoke(StrengthMovementVariant13!);
            }
            else if (IsStrengthMovementVariant14)
            {
                strengthMovementVariant14?.Invoke(StrengthMovementVariant14!);
            }
            else if (IsStrengthMovementVariant15)
            {
                strengthMovementVariant15?.Invoke(StrengthMovementVariant15!);
            }
            else if (IsStrengthMovementVariant16)
            {
                strengthMovementVariant16?.Invoke(StrengthMovementVariant16!);
            }
            else if (IsStrengthMovementVariant17)
            {
                strengthMovementVariant17?.Invoke(StrengthMovementVariant17!);
            }
            else if (IsStrengthMovementVariant18)
            {
                strengthMovementVariant18?.Invoke(StrengthMovementVariant18!);
            }
            else if (IsStrengthMovementVariant19)
            {
                strengthMovementVariant19?.Invoke(StrengthMovementVariant19!);
            }
            else if (IsStrengthMovementVariant20)
            {
                strengthMovementVariant20?.Invoke(StrengthMovementVariant20!);
            }
            else if (IsStrengthMovementVariant21)
            {
                strengthMovementVariant21?.Invoke(StrengthMovementVariant21!);
            }
            else if (IsStrengthMovementVariant22)
            {
                strengthMovementVariant22?.Invoke(StrengthMovementVariant22!);
            }
            else if (IsStrengthMovementVariant23)
            {
                strengthMovementVariant23?.Invoke(StrengthMovementVariant23!);
            }
            else if (IsStrengthMovementVariant24)
            {
                strengthMovementVariant24?.Invoke(StrengthMovementVariant24!);
            }
            else if (IsStrengthMovementVariant25)
            {
                strengthMovementVariant25?.Invoke(StrengthMovementVariant25!);
            }
            else if (IsStrengthMovementVariant26)
            {
                strengthMovementVariant26?.Invoke(StrengthMovementVariant26!);
            }
            else if (IsStrengthMovementVariant27)
            {
                strengthMovementVariant27?.Invoke(StrengthMovementVariant27!);
            }
            else if (IsStrengthMovementVariant28)
            {
                strengthMovementVariant28?.Invoke(StrengthMovementVariant28!);
            }
            else if (IsStrengthMovementVariant29)
            {
                strengthMovementVariant29?.Invoke(StrengthMovementVariant29!);
            }
            else if (IsStrengthMovementVariant30)
            {
                strengthMovementVariant30?.Invoke(StrengthMovementVariant30!);
            }
            else if (IsStrengthMovementVariant31)
            {
                strengthMovementVariant31?.Invoke(StrengthMovementVariant31!);
            }
            else if (IsStrengthMovementVariant32)
            {
                strengthMovementVariant32?.Invoke(StrengthMovementVariant32!);
            }
            else if (IsStrengthMovementVariant33)
            {
                strengthMovementVariant33?.Invoke(StrengthMovementVariant33!);
            }
            else if (IsStrengthMovementVariant34)
            {
                strengthMovementVariant34?.Invoke(StrengthMovementVariant34!);
            }
            else if (IsStrengthMovementVariant35)
            {
                strengthMovementVariant35?.Invoke(StrengthMovementVariant35!);
            }
            else if (IsStrengthMovementVariant36)
            {
                strengthMovementVariant36?.Invoke(StrengthMovementVariant36!);
            }
            else if (IsStrengthMovementVariant37)
            {
                strengthMovementVariant37?.Invoke(StrengthMovementVariant37!);
            }
            else if (IsStrengthMovementVariant38)
            {
                strengthMovementVariant38?.Invoke(StrengthMovementVariant38!);
            }
            else if (IsStrengthMovementVariant39)
            {
                strengthMovementVariant39?.Invoke(StrengthMovementVariant39!);
            }
            else if (IsStrengthMovementVariant40)
            {
                strengthMovementVariant40?.Invoke(StrengthMovementVariant40!);
            }
            else if (IsStrengthMovementVariant41)
            {
                strengthMovementVariant41?.Invoke(StrengthMovementVariant41!);
            }
            else if (IsStrengthMovementVariant42)
            {
                strengthMovementVariant42?.Invoke(StrengthMovementVariant42!);
            }
            else if (IsStrengthMovementVariant43)
            {
                strengthMovementVariant43?.Invoke(StrengthMovementVariant43!);
            }
            else if (IsStrengthMovementVariant44)
            {
                strengthMovementVariant44?.Invoke(StrengthMovementVariant44!);
            }
            else if (IsStrengthMovementVariant45)
            {
                strengthMovementVariant45?.Invoke(StrengthMovementVariant45!);
            }
            else if (IsStrengthMovementVariant46)
            {
                strengthMovementVariant46?.Invoke(StrengthMovementVariant46!);
            }
            else if (IsStrengthMovementVariant47)
            {
                strengthMovementVariant47?.Invoke(StrengthMovementVariant47!);
            }
            else if (IsStrengthMovementVariant48)
            {
                strengthMovementVariant48?.Invoke(StrengthMovementVariant48!);
            }
            else if (IsStrengthMovementVariant49)
            {
                strengthMovementVariant49?.Invoke(StrengthMovementVariant49!);
            }
            else if (IsStrengthMovementVariant50)
            {
                strengthMovementVariant50?.Invoke(StrengthMovementVariant50!);
            }
            else if (IsStrengthMovementVariant51)
            {
                strengthMovementVariant51?.Invoke(StrengthMovementVariant51!);
            }
            else if (IsStrengthMovementVariant52)
            {
                strengthMovementVariant52?.Invoke(StrengthMovementVariant52!);
            }
            else if (IsStrengthMovementVariant53)
            {
                strengthMovementVariant53?.Invoke(StrengthMovementVariant53!);
            }
            else if (IsStrengthMovementVariant54)
            {
                strengthMovementVariant54?.Invoke(StrengthMovementVariant54!);
            }
            else if (IsStrengthMovementVariant55)
            {
                strengthMovementVariant55?.Invoke(StrengthMovementVariant55!);
            }
            else if (IsStrengthMovementVariant56)
            {
                strengthMovementVariant56?.Invoke(StrengthMovementVariant56!);
            }
            else if (IsStrengthMovementVariant57)
            {
                strengthMovementVariant57?.Invoke(StrengthMovementVariant57!);
            }
            else if (IsStrengthMovementVariant58)
            {
                strengthMovementVariant58?.Invoke(StrengthMovementVariant58!);
            }
            else if (IsStrengthMovementVariant59)
            {
                strengthMovementVariant59?.Invoke(StrengthMovementVariant59!);
            }
            else if (IsStrengthMovementVariant60)
            {
                strengthMovementVariant60?.Invoke(StrengthMovementVariant60!);
            }
            else if (IsStrengthMovementVariant61)
            {
                strengthMovementVariant61?.Invoke(StrengthMovementVariant61!);
            }
            else if (IsStrengthMovementVariant62)
            {
                strengthMovementVariant62?.Invoke(StrengthMovementVariant62!);
            }
            else if (IsStrengthMovementVariant63)
            {
                strengthMovementVariant63?.Invoke(StrengthMovementVariant63!);
            }
            else if (IsStrengthMovementVariant64)
            {
                strengthMovementVariant64?.Invoke(StrengthMovementVariant64!);
            }
            else if (IsStrengthMovementVariant65)
            {
                strengthMovementVariant65?.Invoke(StrengthMovementVariant65!);
            }
            else if (IsStrengthMovementVariant66)
            {
                strengthMovementVariant66?.Invoke(StrengthMovementVariant66!);
            }
            else if (IsStrengthMovementVariant67)
            {
                strengthMovementVariant67?.Invoke(StrengthMovementVariant67!);
            }
            else if (IsStrengthMovementVariant68)
            {
                strengthMovementVariant68?.Invoke(StrengthMovementVariant68!);
            }
            else if (IsStrengthMovementVariant69)
            {
                strengthMovementVariant69?.Invoke(StrengthMovementVariant69!);
            }
            else if (IsStrengthMovementVariant70)
            {
                strengthMovementVariant70?.Invoke(StrengthMovementVariant70!);
            }
            else if (IsStrengthMovementVariant71)
            {
                strengthMovementVariant71?.Invoke(StrengthMovementVariant71!);
            }
            else if (IsStrengthMovementVariant72)
            {
                strengthMovementVariant72?.Invoke(StrengthMovementVariant72!);
            }
            else if (IsStrengthMovementVariant73)
            {
                strengthMovementVariant73?.Invoke(StrengthMovementVariant73!);
            }
            else if (IsStrengthMovementVariant74)
            {
                strengthMovementVariant74?.Invoke(StrengthMovementVariant74!);
            }
            else if (IsStrengthMovementVariant75)
            {
                strengthMovementVariant75?.Invoke(StrengthMovementVariant75!);
            }
            else if (IsStrengthMovementVariant76)
            {
                strengthMovementVariant76?.Invoke(StrengthMovementVariant76!);
            }
            else if (IsStrengthMovementVariant77)
            {
                strengthMovementVariant77?.Invoke(StrengthMovementVariant77!);
            }
            else if (IsStrengthMovementVariant78)
            {
                strengthMovementVariant78?.Invoke(StrengthMovementVariant78!);
            }
            else if (IsStrengthMovementVariant79)
            {
                strengthMovementVariant79?.Invoke(StrengthMovementVariant79!);
            }
            else if (IsStrengthMovementVariant80)
            {
                strengthMovementVariant80?.Invoke(StrengthMovementVariant80!);
            }
            else if (IsStrengthMovementVariant81)
            {
                strengthMovementVariant81?.Invoke(StrengthMovementVariant81!);
            }
            else if (IsStrengthMovementVariant82)
            {
                strengthMovementVariant82?.Invoke(StrengthMovementVariant82!);
            }
            else if (IsStrengthMovementVariant83)
            {
                strengthMovementVariant83?.Invoke(StrengthMovementVariant83!);
            }
            else if (IsStrengthMovementVariant84)
            {
                strengthMovementVariant84?.Invoke(StrengthMovementVariant84!);
            }
            else if (IsStrengthMovementVariant85)
            {
                strengthMovementVariant85?.Invoke(StrengthMovementVariant85!);
            }
            else if (IsStrengthMovementVariant86)
            {
                strengthMovementVariant86?.Invoke(StrengthMovementVariant86!);
            }
            else if (IsStrengthMovementVariant87)
            {
                strengthMovementVariant87?.Invoke(StrengthMovementVariant87!);
            }
            else if (IsStrengthMovementVariant88)
            {
                strengthMovementVariant88?.Invoke(StrengthMovementVariant88!);
            }
            else if (IsStrengthMovementVariant89)
            {
                strengthMovementVariant89?.Invoke(StrengthMovementVariant89!);
            }
            else if (IsStrengthMovementVariant90)
            {
                strengthMovementVariant90?.Invoke(StrengthMovementVariant90!);
            }
            else if (IsStrengthMovementVariant91)
            {
                strengthMovementVariant91?.Invoke(StrengthMovementVariant91!);
            }
            else if (IsStrengthMovementVariant92)
            {
                strengthMovementVariant92?.Invoke(StrengthMovementVariant92!);
            }
            else if (IsStrengthMovementVariant93)
            {
                strengthMovementVariant93?.Invoke(StrengthMovementVariant93!);
            }
            else if (IsStrengthMovementVariant94)
            {
                strengthMovementVariant94?.Invoke(StrengthMovementVariant94!);
            }
            else if (IsStrengthMovementVariant95)
            {
                strengthMovementVariant95?.Invoke(StrengthMovementVariant95!);
            }
            else if (IsStrengthMovementVariant96)
            {
                strengthMovementVariant96?.Invoke(StrengthMovementVariant96!);
            }
            else if (IsStrengthMovementVariant97)
            {
                strengthMovementVariant97?.Invoke(StrengthMovementVariant97!);
            }
            else if (IsStrengthMovementVariant98)
            {
                strengthMovementVariant98?.Invoke(StrengthMovementVariant98!);
            }
            else if (IsStrengthMovementVariant99)
            {
                strengthMovementVariant99?.Invoke(StrengthMovementVariant99!);
            }
            else if (IsStrengthMovementVariant100)
            {
                strengthMovementVariant100?.Invoke(StrengthMovementVariant100!);
            }
            else if (IsStrengthMovementVariant101)
            {
                strengthMovementVariant101?.Invoke(StrengthMovementVariant101!);
            }
            else if (IsStrengthMovementVariant102)
            {
                strengthMovementVariant102?.Invoke(StrengthMovementVariant102!);
            }
            else if (IsStrengthMovementVariant103)
            {
                strengthMovementVariant103?.Invoke(StrengthMovementVariant103!);
            }
            else if (IsStrengthMovementVariant104)
            {
                strengthMovementVariant104?.Invoke(StrengthMovementVariant104!);
            }
            else if (IsStrengthMovementVariant105)
            {
                strengthMovementVariant105?.Invoke(StrengthMovementVariant105!);
            }
            else if (IsStrengthMovementVariant106)
            {
                strengthMovementVariant106?.Invoke(StrengthMovementVariant106!);
            }
            else if (IsStrengthMovementVariant107)
            {
                strengthMovementVariant107?.Invoke(StrengthMovementVariant107!);
            }
            else if (IsStrengthMovementVariant108)
            {
                strengthMovementVariant108?.Invoke(StrengthMovementVariant108!);
            }
            else if (IsStrengthMovementVariant109)
            {
                strengthMovementVariant109?.Invoke(StrengthMovementVariant109!);
            }
            else if (IsStrengthMovementVariant110)
            {
                strengthMovementVariant110?.Invoke(StrengthMovementVariant110!);
            }
            else if (IsStrengthMovementVariant111)
            {
                strengthMovementVariant111?.Invoke(StrengthMovementVariant111!);
            }
            else if (IsStrengthMovementVariant112)
            {
                strengthMovementVariant112?.Invoke(StrengthMovementVariant112!);
            }
            else if (IsStrengthMovementVariant113)
            {
                strengthMovementVariant113?.Invoke(StrengthMovementVariant113!);
            }
            else if (IsStrengthMovementVariant114)
            {
                strengthMovementVariant114?.Invoke(StrengthMovementVariant114!);
            }
            else if (IsStrengthMovementVariant115)
            {
                strengthMovementVariant115?.Invoke(StrengthMovementVariant115!);
            }
            else if (IsStrengthMovementVariant116)
            {
                strengthMovementVariant116?.Invoke(StrengthMovementVariant116!);
            }
            else if (IsStrengthMovementVariant117)
            {
                strengthMovementVariant117?.Invoke(StrengthMovementVariant117!);
            }
            else if (IsStrengthMovementVariant118)
            {
                strengthMovementVariant118?.Invoke(StrengthMovementVariant118!);
            }
            else if (IsStrengthMovementVariant119)
            {
                strengthMovementVariant119?.Invoke(StrengthMovementVariant119!);
            }
            else if (IsStrengthMovementVariant120)
            {
                strengthMovementVariant120?.Invoke(StrengthMovementVariant120!);
            }
            else if (IsStrengthMovementVariant121)
            {
                strengthMovementVariant121?.Invoke(StrengthMovementVariant121!);
            }
            else if (IsStrengthMovementVariant122)
            {
                strengthMovementVariant122?.Invoke(StrengthMovementVariant122!);
            }
            else if (IsStrengthMovementVariant123)
            {
                strengthMovementVariant123?.Invoke(StrengthMovementVariant123!);
            }
            else if (IsStrengthMovementVariant124)
            {
                strengthMovementVariant124?.Invoke(StrengthMovementVariant124!);
            }
            else if (IsStrengthMovementVariant125)
            {
                strengthMovementVariant125?.Invoke(StrengthMovementVariant125!);
            }
            else if (IsStrengthMovementVariant126)
            {
                strengthMovementVariant126?.Invoke(StrengthMovementVariant126!);
            }
            else if (IsStrengthMovementVariant127)
            {
                strengthMovementVariant127?.Invoke(StrengthMovementVariant127!);
            }
            else if (IsStrengthMovementVariant128)
            {
                strengthMovementVariant128?.Invoke(StrengthMovementVariant128!);
            }
            else if (IsStrengthMovementVariant129)
            {
                strengthMovementVariant129?.Invoke(StrengthMovementVariant129!);
            }
            else if (IsStrengthMovementVariant130)
            {
                strengthMovementVariant130?.Invoke(StrengthMovementVariant130!);
            }
            else if (IsStrengthMovementVariant131)
            {
                strengthMovementVariant131?.Invoke(StrengthMovementVariant131!);
            }
            else if (IsStrengthMovementVariant132)
            {
                strengthMovementVariant132?.Invoke(StrengthMovementVariant132!);
            }
            else if (IsStrengthMovementVariant133)
            {
                strengthMovementVariant133?.Invoke(StrengthMovementVariant133!);
            }
            else if (IsStrengthMovementVariant134)
            {
                strengthMovementVariant134?.Invoke(StrengthMovementVariant134!);
            }
            else if (IsStrengthMovementVariant135)
            {
                strengthMovementVariant135?.Invoke(StrengthMovementVariant135!);
            }
            else if (IsStrengthMovementVariant136)
            {
                strengthMovementVariant136?.Invoke(StrengthMovementVariant136!);
            }
            else if (IsStrengthMovementVariant137)
            {
                strengthMovementVariant137?.Invoke(StrengthMovementVariant137!);
            }
            else if (IsStrengthMovementVariant138)
            {
                strengthMovementVariant138?.Invoke(StrengthMovementVariant138!);
            }
            else if (IsStrengthMovementVariant139)
            {
                strengthMovementVariant139?.Invoke(StrengthMovementVariant139!);
            }
            else if (IsStrengthMovementVariant140)
            {
                strengthMovementVariant140?.Invoke(StrengthMovementVariant140!);
            }
            else if (IsStrengthMovementVariant141)
            {
                strengthMovementVariant141?.Invoke(StrengthMovementVariant141!);
            }
            else if (IsStrengthMovementVariant142)
            {
                strengthMovementVariant142?.Invoke(StrengthMovementVariant142!);
            }
            else if (IsStrengthMovementVariant143)
            {
                strengthMovementVariant143?.Invoke(StrengthMovementVariant143!);
            }
            else if (IsStrengthMovementVariant144)
            {
                strengthMovementVariant144?.Invoke(StrengthMovementVariant144!);
            }
            else if (IsStrengthMovementVariant145)
            {
                strengthMovementVariant145?.Invoke(StrengthMovementVariant145!);
            }
            else if (IsStrengthMovementVariant146)
            {
                strengthMovementVariant146?.Invoke(StrengthMovementVariant146!);
            }
            else if (IsStrengthMovementVariant147)
            {
                strengthMovementVariant147?.Invoke(StrengthMovementVariant147!);
            }
            else if (IsStrengthMovementVariant148)
            {
                strengthMovementVariant148?.Invoke(StrengthMovementVariant148!);
            }
            else if (IsStrengthMovementVariant149)
            {
                strengthMovementVariant149?.Invoke(StrengthMovementVariant149!);
            }
            else if (IsStrengthMovementVariant150)
            {
                strengthMovementVariant150?.Invoke(StrengthMovementVariant150!);
            }
            else if (IsStrengthMovementVariant151)
            {
                strengthMovementVariant151?.Invoke(StrengthMovementVariant151!);
            }
            else if (IsStrengthMovementVariant152)
            {
                strengthMovementVariant152?.Invoke(StrengthMovementVariant152!);
            }
            else if (IsStrengthMovementVariant153)
            {
                strengthMovementVariant153?.Invoke(StrengthMovementVariant153!);
            }
            else if (IsStrengthMovementVariant154)
            {
                strengthMovementVariant154?.Invoke(StrengthMovementVariant154!);
            }
            else if (IsStrengthMovementVariant155)
            {
                strengthMovementVariant155?.Invoke(StrengthMovementVariant155!);
            }
            else if (IsStrengthMovementVariant156)
            {
                strengthMovementVariant156?.Invoke(StrengthMovementVariant156!);
            }
            else if (IsStrengthMovementVariant157)
            {
                strengthMovementVariant157?.Invoke(StrengthMovementVariant157!);
            }
            else if (IsStrengthMovementVariant158)
            {
                strengthMovementVariant158?.Invoke(StrengthMovementVariant158!);
            }
            else if (IsStrengthMovementVariant159)
            {
                strengthMovementVariant159?.Invoke(StrengthMovementVariant159!);
            }
            else if (IsStrengthMovementVariant160)
            {
                strengthMovementVariant160?.Invoke(StrengthMovementVariant160!);
            }
            else if (IsStrengthMovementVariant161)
            {
                strengthMovementVariant161?.Invoke(StrengthMovementVariant161!);
            }
            else if (IsStrengthMovementVariant162)
            {
                strengthMovementVariant162?.Invoke(StrengthMovementVariant162!);
            }
            else if (IsStrengthMovementVariant163)
            {
                strengthMovementVariant163?.Invoke(StrengthMovementVariant163!);
            }
            else if (IsStrengthMovementVariant164)
            {
                strengthMovementVariant164?.Invoke(StrengthMovementVariant164!);
            }
            else if (IsStrengthMovementVariant165)
            {
                strengthMovementVariant165?.Invoke(StrengthMovementVariant165!);
            }
            else if (IsStrengthMovementVariant166)
            {
                strengthMovementVariant166?.Invoke(StrengthMovementVariant166!);
            }
            else if (IsStrengthMovementVariant167)
            {
                strengthMovementVariant167?.Invoke(StrengthMovementVariant167!);
            }
            else if (IsStrengthMovementVariant168)
            {
                strengthMovementVariant168?.Invoke(StrengthMovementVariant168!);
            }
            else if (IsStrengthMovementVariant169)
            {
                strengthMovementVariant169?.Invoke(StrengthMovementVariant169!);
            }
            else if (IsStrengthMovementVariant170)
            {
                strengthMovementVariant170?.Invoke(StrengthMovementVariant170!);
            }
            else if (IsStrengthMovementVariant171)
            {
                strengthMovementVariant171?.Invoke(StrengthMovementVariant171!);
            }
            else if (IsStrengthMovementVariant172)
            {
                strengthMovementVariant172?.Invoke(StrengthMovementVariant172!);
            }
            else if (IsStrengthMovementVariant173)
            {
                strengthMovementVariant173?.Invoke(StrengthMovementVariant173!);
            }
            else if (IsStrengthMovementVariant174)
            {
                strengthMovementVariant174?.Invoke(StrengthMovementVariant174!);
            }
            else if (IsStrengthMovementVariant175)
            {
                strengthMovementVariant175?.Invoke(StrengthMovementVariant175!);
            }
            else if (IsStrengthMovementVariant176)
            {
                strengthMovementVariant176?.Invoke(StrengthMovementVariant176!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthMovementVariant1,
                typeof(global::Terra.StrengthMovementVariant1),
                StrengthMovementVariant2,
                typeof(global::Terra.StrengthMovementVariant2),
                StrengthMovementVariant3,
                typeof(global::Terra.StrengthMovementVariant3),
                StrengthMovementVariant4,
                typeof(global::Terra.StrengthMovementVariant4),
                StrengthMovementVariant5,
                typeof(global::Terra.StrengthMovementVariant5),
                StrengthMovementVariant6,
                typeof(global::Terra.StrengthMovementVariant6),
                StrengthMovementVariant7,
                typeof(global::Terra.StrengthMovementVariant7),
                StrengthMovementVariant8,
                typeof(global::Terra.StrengthMovementVariant8),
                StrengthMovementVariant9,
                typeof(global::Terra.StrengthMovementVariant9),
                StrengthMovementVariant10,
                typeof(global::Terra.StrengthMovementVariant10),
                StrengthMovementVariant11,
                typeof(global::Terra.StrengthMovementVariant11),
                StrengthMovementVariant12,
                typeof(global::Terra.StrengthMovementVariant12),
                StrengthMovementVariant13,
                typeof(global::Terra.StrengthMovementVariant13),
                StrengthMovementVariant14,
                typeof(global::Terra.StrengthMovementVariant14),
                StrengthMovementVariant15,
                typeof(global::Terra.StrengthMovementVariant15),
                StrengthMovementVariant16,
                typeof(global::Terra.StrengthMovementVariant16),
                StrengthMovementVariant17,
                typeof(global::Terra.StrengthMovementVariant17),
                StrengthMovementVariant18,
                typeof(global::Terra.StrengthMovementVariant18),
                StrengthMovementVariant19,
                typeof(global::Terra.StrengthMovementVariant19),
                StrengthMovementVariant20,
                typeof(global::Terra.StrengthMovementVariant20),
                StrengthMovementVariant21,
                typeof(global::Terra.StrengthMovementVariant21),
                StrengthMovementVariant22,
                typeof(global::Terra.StrengthMovementVariant22),
                StrengthMovementVariant23,
                typeof(global::Terra.StrengthMovementVariant23),
                StrengthMovementVariant24,
                typeof(global::Terra.StrengthMovementVariant24),
                StrengthMovementVariant25,
                typeof(global::Terra.StrengthMovementVariant25),
                StrengthMovementVariant26,
                typeof(global::Terra.StrengthMovementVariant26),
                StrengthMovementVariant27,
                typeof(global::Terra.StrengthMovementVariant27),
                StrengthMovementVariant28,
                typeof(global::Terra.StrengthMovementVariant28),
                StrengthMovementVariant29,
                typeof(global::Terra.StrengthMovementVariant29),
                StrengthMovementVariant30,
                typeof(global::Terra.StrengthMovementVariant30),
                StrengthMovementVariant31,
                typeof(global::Terra.StrengthMovementVariant31),
                StrengthMovementVariant32,
                typeof(global::Terra.StrengthMovementVariant32),
                StrengthMovementVariant33,
                typeof(global::Terra.StrengthMovementVariant33),
                StrengthMovementVariant34,
                typeof(global::Terra.StrengthMovementVariant34),
                StrengthMovementVariant35,
                typeof(global::Terra.StrengthMovementVariant35),
                StrengthMovementVariant36,
                typeof(global::Terra.StrengthMovementVariant36),
                StrengthMovementVariant37,
                typeof(global::Terra.StrengthMovementVariant37),
                StrengthMovementVariant38,
                typeof(global::Terra.StrengthMovementVariant38),
                StrengthMovementVariant39,
                typeof(global::Terra.StrengthMovementVariant39),
                StrengthMovementVariant40,
                typeof(global::Terra.StrengthMovementVariant40),
                StrengthMovementVariant41,
                typeof(global::Terra.StrengthMovementVariant41),
                StrengthMovementVariant42,
                typeof(global::Terra.StrengthMovementVariant42),
                StrengthMovementVariant43,
                typeof(global::Terra.StrengthMovementVariant43),
                StrengthMovementVariant44,
                typeof(global::Terra.StrengthMovementVariant44),
                StrengthMovementVariant45,
                typeof(global::Terra.StrengthMovementVariant45),
                StrengthMovementVariant46,
                typeof(global::Terra.StrengthMovementVariant46),
                StrengthMovementVariant47,
                typeof(global::Terra.StrengthMovementVariant47),
                StrengthMovementVariant48,
                typeof(global::Terra.StrengthMovementVariant48),
                StrengthMovementVariant49,
                typeof(global::Terra.StrengthMovementVariant49),
                StrengthMovementVariant50,
                typeof(global::Terra.StrengthMovementVariant50),
                StrengthMovementVariant51,
                typeof(global::Terra.StrengthMovementVariant51),
                StrengthMovementVariant52,
                typeof(global::Terra.StrengthMovementVariant52),
                StrengthMovementVariant53,
                typeof(global::Terra.StrengthMovementVariant53),
                StrengthMovementVariant54,
                typeof(global::Terra.StrengthMovementVariant54),
                StrengthMovementVariant55,
                typeof(global::Terra.StrengthMovementVariant55),
                StrengthMovementVariant56,
                typeof(global::Terra.StrengthMovementVariant56),
                StrengthMovementVariant57,
                typeof(global::Terra.StrengthMovementVariant57),
                StrengthMovementVariant58,
                typeof(global::Terra.StrengthMovementVariant58),
                StrengthMovementVariant59,
                typeof(global::Terra.StrengthMovementVariant59),
                StrengthMovementVariant60,
                typeof(global::Terra.StrengthMovementVariant60),
                StrengthMovementVariant61,
                typeof(global::Terra.StrengthMovementVariant61),
                StrengthMovementVariant62,
                typeof(global::Terra.StrengthMovementVariant62),
                StrengthMovementVariant63,
                typeof(global::Terra.StrengthMovementVariant63),
                StrengthMovementVariant64,
                typeof(global::Terra.StrengthMovementVariant64),
                StrengthMovementVariant65,
                typeof(global::Terra.StrengthMovementVariant65),
                StrengthMovementVariant66,
                typeof(global::Terra.StrengthMovementVariant66),
                StrengthMovementVariant67,
                typeof(global::Terra.StrengthMovementVariant67),
                StrengthMovementVariant68,
                typeof(global::Terra.StrengthMovementVariant68),
                StrengthMovementVariant69,
                typeof(global::Terra.StrengthMovementVariant69),
                StrengthMovementVariant70,
                typeof(global::Terra.StrengthMovementVariant70),
                StrengthMovementVariant71,
                typeof(global::Terra.StrengthMovementVariant71),
                StrengthMovementVariant72,
                typeof(global::Terra.StrengthMovementVariant72),
                StrengthMovementVariant73,
                typeof(global::Terra.StrengthMovementVariant73),
                StrengthMovementVariant74,
                typeof(global::Terra.StrengthMovementVariant74),
                StrengthMovementVariant75,
                typeof(global::Terra.StrengthMovementVariant75),
                StrengthMovementVariant76,
                typeof(global::Terra.StrengthMovementVariant76),
                StrengthMovementVariant77,
                typeof(global::Terra.StrengthMovementVariant77),
                StrengthMovementVariant78,
                typeof(global::Terra.StrengthMovementVariant78),
                StrengthMovementVariant79,
                typeof(global::Terra.StrengthMovementVariant79),
                StrengthMovementVariant80,
                typeof(global::Terra.StrengthMovementVariant80),
                StrengthMovementVariant81,
                typeof(global::Terra.StrengthMovementVariant81),
                StrengthMovementVariant82,
                typeof(global::Terra.StrengthMovementVariant82),
                StrengthMovementVariant83,
                typeof(global::Terra.StrengthMovementVariant83),
                StrengthMovementVariant84,
                typeof(global::Terra.StrengthMovementVariant84),
                StrengthMovementVariant85,
                typeof(global::Terra.StrengthMovementVariant85),
                StrengthMovementVariant86,
                typeof(global::Terra.StrengthMovementVariant86),
                StrengthMovementVariant87,
                typeof(global::Terra.StrengthMovementVariant87),
                StrengthMovementVariant88,
                typeof(global::Terra.StrengthMovementVariant88),
                StrengthMovementVariant89,
                typeof(global::Terra.StrengthMovementVariant89),
                StrengthMovementVariant90,
                typeof(global::Terra.StrengthMovementVariant90),
                StrengthMovementVariant91,
                typeof(global::Terra.StrengthMovementVariant91),
                StrengthMovementVariant92,
                typeof(global::Terra.StrengthMovementVariant92),
                StrengthMovementVariant93,
                typeof(global::Terra.StrengthMovementVariant93),
                StrengthMovementVariant94,
                typeof(global::Terra.StrengthMovementVariant94),
                StrengthMovementVariant95,
                typeof(global::Terra.StrengthMovementVariant95),
                StrengthMovementVariant96,
                typeof(global::Terra.StrengthMovementVariant96),
                StrengthMovementVariant97,
                typeof(global::Terra.StrengthMovementVariant97),
                StrengthMovementVariant98,
                typeof(global::Terra.StrengthMovementVariant98),
                StrengthMovementVariant99,
                typeof(global::Terra.StrengthMovementVariant99),
                StrengthMovementVariant100,
                typeof(global::Terra.StrengthMovementVariant100),
                StrengthMovementVariant101,
                typeof(global::Terra.StrengthMovementVariant101),
                StrengthMovementVariant102,
                typeof(global::Terra.StrengthMovementVariant102),
                StrengthMovementVariant103,
                typeof(global::Terra.StrengthMovementVariant103),
                StrengthMovementVariant104,
                typeof(global::Terra.StrengthMovementVariant104),
                StrengthMovementVariant105,
                typeof(global::Terra.StrengthMovementVariant105),
                StrengthMovementVariant106,
                typeof(global::Terra.StrengthMovementVariant106),
                StrengthMovementVariant107,
                typeof(global::Terra.StrengthMovementVariant107),
                StrengthMovementVariant108,
                typeof(global::Terra.StrengthMovementVariant108),
                StrengthMovementVariant109,
                typeof(global::Terra.StrengthMovementVariant109),
                StrengthMovementVariant110,
                typeof(global::Terra.StrengthMovementVariant110),
                StrengthMovementVariant111,
                typeof(global::Terra.StrengthMovementVariant111),
                StrengthMovementVariant112,
                typeof(global::Terra.StrengthMovementVariant112),
                StrengthMovementVariant113,
                typeof(global::Terra.StrengthMovementVariant113),
                StrengthMovementVariant114,
                typeof(global::Terra.StrengthMovementVariant114),
                StrengthMovementVariant115,
                typeof(global::Terra.StrengthMovementVariant115),
                StrengthMovementVariant116,
                typeof(global::Terra.StrengthMovementVariant116),
                StrengthMovementVariant117,
                typeof(global::Terra.StrengthMovementVariant117),
                StrengthMovementVariant118,
                typeof(global::Terra.StrengthMovementVariant118),
                StrengthMovementVariant119,
                typeof(global::Terra.StrengthMovementVariant119),
                StrengthMovementVariant120,
                typeof(global::Terra.StrengthMovementVariant120),
                StrengthMovementVariant121,
                typeof(global::Terra.StrengthMovementVariant121),
                StrengthMovementVariant122,
                typeof(global::Terra.StrengthMovementVariant122),
                StrengthMovementVariant123,
                typeof(global::Terra.StrengthMovementVariant123),
                StrengthMovementVariant124,
                typeof(global::Terra.StrengthMovementVariant124),
                StrengthMovementVariant125,
                typeof(global::Terra.StrengthMovementVariant125),
                StrengthMovementVariant126,
                typeof(global::Terra.StrengthMovementVariant126),
                StrengthMovementVariant127,
                typeof(global::Terra.StrengthMovementVariant127),
                StrengthMovementVariant128,
                typeof(global::Terra.StrengthMovementVariant128),
                StrengthMovementVariant129,
                typeof(global::Terra.StrengthMovementVariant129),
                StrengthMovementVariant130,
                typeof(global::Terra.StrengthMovementVariant130),
                StrengthMovementVariant131,
                typeof(global::Terra.StrengthMovementVariant131),
                StrengthMovementVariant132,
                typeof(global::Terra.StrengthMovementVariant132),
                StrengthMovementVariant133,
                typeof(global::Terra.StrengthMovementVariant133),
                StrengthMovementVariant134,
                typeof(global::Terra.StrengthMovementVariant134),
                StrengthMovementVariant135,
                typeof(global::Terra.StrengthMovementVariant135),
                StrengthMovementVariant136,
                typeof(global::Terra.StrengthMovementVariant136),
                StrengthMovementVariant137,
                typeof(global::Terra.StrengthMovementVariant137),
                StrengthMovementVariant138,
                typeof(global::Terra.StrengthMovementVariant138),
                StrengthMovementVariant139,
                typeof(global::Terra.StrengthMovementVariant139),
                StrengthMovementVariant140,
                typeof(global::Terra.StrengthMovementVariant140),
                StrengthMovementVariant141,
                typeof(global::Terra.StrengthMovementVariant141),
                StrengthMovementVariant142,
                typeof(global::Terra.StrengthMovementVariant142),
                StrengthMovementVariant143,
                typeof(global::Terra.StrengthMovementVariant143),
                StrengthMovementVariant144,
                typeof(global::Terra.StrengthMovementVariant144),
                StrengthMovementVariant145,
                typeof(global::Terra.StrengthMovementVariant145),
                StrengthMovementVariant146,
                typeof(global::Terra.StrengthMovementVariant146),
                StrengthMovementVariant147,
                typeof(global::Terra.StrengthMovementVariant147),
                StrengthMovementVariant148,
                typeof(global::Terra.StrengthMovementVariant148),
                StrengthMovementVariant149,
                typeof(global::Terra.StrengthMovementVariant149),
                StrengthMovementVariant150,
                typeof(global::Terra.StrengthMovementVariant150),
                StrengthMovementVariant151,
                typeof(global::Terra.StrengthMovementVariant151),
                StrengthMovementVariant152,
                typeof(global::Terra.StrengthMovementVariant152),
                StrengthMovementVariant153,
                typeof(global::Terra.StrengthMovementVariant153),
                StrengthMovementVariant154,
                typeof(global::Terra.StrengthMovementVariant154),
                StrengthMovementVariant155,
                typeof(global::Terra.StrengthMovementVariant155),
                StrengthMovementVariant156,
                typeof(global::Terra.StrengthMovementVariant156),
                StrengthMovementVariant157,
                typeof(global::Terra.StrengthMovementVariant157),
                StrengthMovementVariant158,
                typeof(global::Terra.StrengthMovementVariant158),
                StrengthMovementVariant159,
                typeof(global::Terra.StrengthMovementVariant159),
                StrengthMovementVariant160,
                typeof(global::Terra.StrengthMovementVariant160),
                StrengthMovementVariant161,
                typeof(global::Terra.StrengthMovementVariant161),
                StrengthMovementVariant162,
                typeof(global::Terra.StrengthMovementVariant162),
                StrengthMovementVariant163,
                typeof(global::Terra.StrengthMovementVariant163),
                StrengthMovementVariant164,
                typeof(global::Terra.StrengthMovementVariant164),
                StrengthMovementVariant165,
                typeof(global::Terra.StrengthMovementVariant165),
                StrengthMovementVariant166,
                typeof(global::Terra.StrengthMovementVariant166),
                StrengthMovementVariant167,
                typeof(global::Terra.StrengthMovementVariant167),
                StrengthMovementVariant168,
                typeof(global::Terra.StrengthMovementVariant168),
                StrengthMovementVariant169,
                typeof(global::Terra.StrengthMovementVariant169),
                StrengthMovementVariant170,
                typeof(global::Terra.StrengthMovementVariant170),
                StrengthMovementVariant171,
                typeof(global::Terra.StrengthMovementVariant171),
                StrengthMovementVariant172,
                typeof(global::Terra.StrengthMovementVariant172),
                StrengthMovementVariant173,
                typeof(global::Terra.StrengthMovementVariant173),
                StrengthMovementVariant174,
                typeof(global::Terra.StrengthMovementVariant174),
                StrengthMovementVariant175,
                typeof(global::Terra.StrengthMovementVariant175),
                StrengthMovementVariant176,
                typeof(string),
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
        public bool Equals(StrengthMovement other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant1?>.Default.Equals(StrengthMovementVariant1, other.StrengthMovementVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant2?>.Default.Equals(StrengthMovementVariant2, other.StrengthMovementVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant3?>.Default.Equals(StrengthMovementVariant3, other.StrengthMovementVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant4?>.Default.Equals(StrengthMovementVariant4, other.StrengthMovementVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant5?>.Default.Equals(StrengthMovementVariant5, other.StrengthMovementVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant6?>.Default.Equals(StrengthMovementVariant6, other.StrengthMovementVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant7?>.Default.Equals(StrengthMovementVariant7, other.StrengthMovementVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant8?>.Default.Equals(StrengthMovementVariant8, other.StrengthMovementVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant9?>.Default.Equals(StrengthMovementVariant9, other.StrengthMovementVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant10?>.Default.Equals(StrengthMovementVariant10, other.StrengthMovementVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant11?>.Default.Equals(StrengthMovementVariant11, other.StrengthMovementVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant12?>.Default.Equals(StrengthMovementVariant12, other.StrengthMovementVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant13?>.Default.Equals(StrengthMovementVariant13, other.StrengthMovementVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant14?>.Default.Equals(StrengthMovementVariant14, other.StrengthMovementVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant15?>.Default.Equals(StrengthMovementVariant15, other.StrengthMovementVariant15) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant16?>.Default.Equals(StrengthMovementVariant16, other.StrengthMovementVariant16) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant17?>.Default.Equals(StrengthMovementVariant17, other.StrengthMovementVariant17) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant18?>.Default.Equals(StrengthMovementVariant18, other.StrengthMovementVariant18) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant19?>.Default.Equals(StrengthMovementVariant19, other.StrengthMovementVariant19) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant20?>.Default.Equals(StrengthMovementVariant20, other.StrengthMovementVariant20) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant21?>.Default.Equals(StrengthMovementVariant21, other.StrengthMovementVariant21) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant22?>.Default.Equals(StrengthMovementVariant22, other.StrengthMovementVariant22) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant23?>.Default.Equals(StrengthMovementVariant23, other.StrengthMovementVariant23) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant24?>.Default.Equals(StrengthMovementVariant24, other.StrengthMovementVariant24) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant25?>.Default.Equals(StrengthMovementVariant25, other.StrengthMovementVariant25) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant26?>.Default.Equals(StrengthMovementVariant26, other.StrengthMovementVariant26) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant27?>.Default.Equals(StrengthMovementVariant27, other.StrengthMovementVariant27) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant28?>.Default.Equals(StrengthMovementVariant28, other.StrengthMovementVariant28) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant29?>.Default.Equals(StrengthMovementVariant29, other.StrengthMovementVariant29) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant30?>.Default.Equals(StrengthMovementVariant30, other.StrengthMovementVariant30) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant31?>.Default.Equals(StrengthMovementVariant31, other.StrengthMovementVariant31) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant32?>.Default.Equals(StrengthMovementVariant32, other.StrengthMovementVariant32) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant33?>.Default.Equals(StrengthMovementVariant33, other.StrengthMovementVariant33) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant34?>.Default.Equals(StrengthMovementVariant34, other.StrengthMovementVariant34) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant35?>.Default.Equals(StrengthMovementVariant35, other.StrengthMovementVariant35) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant36?>.Default.Equals(StrengthMovementVariant36, other.StrengthMovementVariant36) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant37?>.Default.Equals(StrengthMovementVariant37, other.StrengthMovementVariant37) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant38?>.Default.Equals(StrengthMovementVariant38, other.StrengthMovementVariant38) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant39?>.Default.Equals(StrengthMovementVariant39, other.StrengthMovementVariant39) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant40?>.Default.Equals(StrengthMovementVariant40, other.StrengthMovementVariant40) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant41?>.Default.Equals(StrengthMovementVariant41, other.StrengthMovementVariant41) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant42?>.Default.Equals(StrengthMovementVariant42, other.StrengthMovementVariant42) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant43?>.Default.Equals(StrengthMovementVariant43, other.StrengthMovementVariant43) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant44?>.Default.Equals(StrengthMovementVariant44, other.StrengthMovementVariant44) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant45?>.Default.Equals(StrengthMovementVariant45, other.StrengthMovementVariant45) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant46?>.Default.Equals(StrengthMovementVariant46, other.StrengthMovementVariant46) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant47?>.Default.Equals(StrengthMovementVariant47, other.StrengthMovementVariant47) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant48?>.Default.Equals(StrengthMovementVariant48, other.StrengthMovementVariant48) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant49?>.Default.Equals(StrengthMovementVariant49, other.StrengthMovementVariant49) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant50?>.Default.Equals(StrengthMovementVariant50, other.StrengthMovementVariant50) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant51?>.Default.Equals(StrengthMovementVariant51, other.StrengthMovementVariant51) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant52?>.Default.Equals(StrengthMovementVariant52, other.StrengthMovementVariant52) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant53?>.Default.Equals(StrengthMovementVariant53, other.StrengthMovementVariant53) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant54?>.Default.Equals(StrengthMovementVariant54, other.StrengthMovementVariant54) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant55?>.Default.Equals(StrengthMovementVariant55, other.StrengthMovementVariant55) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant56?>.Default.Equals(StrengthMovementVariant56, other.StrengthMovementVariant56) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant57?>.Default.Equals(StrengthMovementVariant57, other.StrengthMovementVariant57) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant58?>.Default.Equals(StrengthMovementVariant58, other.StrengthMovementVariant58) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant59?>.Default.Equals(StrengthMovementVariant59, other.StrengthMovementVariant59) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant60?>.Default.Equals(StrengthMovementVariant60, other.StrengthMovementVariant60) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant61?>.Default.Equals(StrengthMovementVariant61, other.StrengthMovementVariant61) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant62?>.Default.Equals(StrengthMovementVariant62, other.StrengthMovementVariant62) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant63?>.Default.Equals(StrengthMovementVariant63, other.StrengthMovementVariant63) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant64?>.Default.Equals(StrengthMovementVariant64, other.StrengthMovementVariant64) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant65?>.Default.Equals(StrengthMovementVariant65, other.StrengthMovementVariant65) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant66?>.Default.Equals(StrengthMovementVariant66, other.StrengthMovementVariant66) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant67?>.Default.Equals(StrengthMovementVariant67, other.StrengthMovementVariant67) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant68?>.Default.Equals(StrengthMovementVariant68, other.StrengthMovementVariant68) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant69?>.Default.Equals(StrengthMovementVariant69, other.StrengthMovementVariant69) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant70?>.Default.Equals(StrengthMovementVariant70, other.StrengthMovementVariant70) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant71?>.Default.Equals(StrengthMovementVariant71, other.StrengthMovementVariant71) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant72?>.Default.Equals(StrengthMovementVariant72, other.StrengthMovementVariant72) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant73?>.Default.Equals(StrengthMovementVariant73, other.StrengthMovementVariant73) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant74?>.Default.Equals(StrengthMovementVariant74, other.StrengthMovementVariant74) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant75?>.Default.Equals(StrengthMovementVariant75, other.StrengthMovementVariant75) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant76?>.Default.Equals(StrengthMovementVariant76, other.StrengthMovementVariant76) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant77?>.Default.Equals(StrengthMovementVariant77, other.StrengthMovementVariant77) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant78?>.Default.Equals(StrengthMovementVariant78, other.StrengthMovementVariant78) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant79?>.Default.Equals(StrengthMovementVariant79, other.StrengthMovementVariant79) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant80?>.Default.Equals(StrengthMovementVariant80, other.StrengthMovementVariant80) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant81?>.Default.Equals(StrengthMovementVariant81, other.StrengthMovementVariant81) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant82?>.Default.Equals(StrengthMovementVariant82, other.StrengthMovementVariant82) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant83?>.Default.Equals(StrengthMovementVariant83, other.StrengthMovementVariant83) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant84?>.Default.Equals(StrengthMovementVariant84, other.StrengthMovementVariant84) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant85?>.Default.Equals(StrengthMovementVariant85, other.StrengthMovementVariant85) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant86?>.Default.Equals(StrengthMovementVariant86, other.StrengthMovementVariant86) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant87?>.Default.Equals(StrengthMovementVariant87, other.StrengthMovementVariant87) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant88?>.Default.Equals(StrengthMovementVariant88, other.StrengthMovementVariant88) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant89?>.Default.Equals(StrengthMovementVariant89, other.StrengthMovementVariant89) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant90?>.Default.Equals(StrengthMovementVariant90, other.StrengthMovementVariant90) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant91?>.Default.Equals(StrengthMovementVariant91, other.StrengthMovementVariant91) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant92?>.Default.Equals(StrengthMovementVariant92, other.StrengthMovementVariant92) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant93?>.Default.Equals(StrengthMovementVariant93, other.StrengthMovementVariant93) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant94?>.Default.Equals(StrengthMovementVariant94, other.StrengthMovementVariant94) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant95?>.Default.Equals(StrengthMovementVariant95, other.StrengthMovementVariant95) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant96?>.Default.Equals(StrengthMovementVariant96, other.StrengthMovementVariant96) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant97?>.Default.Equals(StrengthMovementVariant97, other.StrengthMovementVariant97) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant98?>.Default.Equals(StrengthMovementVariant98, other.StrengthMovementVariant98) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant99?>.Default.Equals(StrengthMovementVariant99, other.StrengthMovementVariant99) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant100?>.Default.Equals(StrengthMovementVariant100, other.StrengthMovementVariant100) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant101?>.Default.Equals(StrengthMovementVariant101, other.StrengthMovementVariant101) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant102?>.Default.Equals(StrengthMovementVariant102, other.StrengthMovementVariant102) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant103?>.Default.Equals(StrengthMovementVariant103, other.StrengthMovementVariant103) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant104?>.Default.Equals(StrengthMovementVariant104, other.StrengthMovementVariant104) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant105?>.Default.Equals(StrengthMovementVariant105, other.StrengthMovementVariant105) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant106?>.Default.Equals(StrengthMovementVariant106, other.StrengthMovementVariant106) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant107?>.Default.Equals(StrengthMovementVariant107, other.StrengthMovementVariant107) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant108?>.Default.Equals(StrengthMovementVariant108, other.StrengthMovementVariant108) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant109?>.Default.Equals(StrengthMovementVariant109, other.StrengthMovementVariant109) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant110?>.Default.Equals(StrengthMovementVariant110, other.StrengthMovementVariant110) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant111?>.Default.Equals(StrengthMovementVariant111, other.StrengthMovementVariant111) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant112?>.Default.Equals(StrengthMovementVariant112, other.StrengthMovementVariant112) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant113?>.Default.Equals(StrengthMovementVariant113, other.StrengthMovementVariant113) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant114?>.Default.Equals(StrengthMovementVariant114, other.StrengthMovementVariant114) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant115?>.Default.Equals(StrengthMovementVariant115, other.StrengthMovementVariant115) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant116?>.Default.Equals(StrengthMovementVariant116, other.StrengthMovementVariant116) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant117?>.Default.Equals(StrengthMovementVariant117, other.StrengthMovementVariant117) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant118?>.Default.Equals(StrengthMovementVariant118, other.StrengthMovementVariant118) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant119?>.Default.Equals(StrengthMovementVariant119, other.StrengthMovementVariant119) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant120?>.Default.Equals(StrengthMovementVariant120, other.StrengthMovementVariant120) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant121?>.Default.Equals(StrengthMovementVariant121, other.StrengthMovementVariant121) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant122?>.Default.Equals(StrengthMovementVariant122, other.StrengthMovementVariant122) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant123?>.Default.Equals(StrengthMovementVariant123, other.StrengthMovementVariant123) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant124?>.Default.Equals(StrengthMovementVariant124, other.StrengthMovementVariant124) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant125?>.Default.Equals(StrengthMovementVariant125, other.StrengthMovementVariant125) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant126?>.Default.Equals(StrengthMovementVariant126, other.StrengthMovementVariant126) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant127?>.Default.Equals(StrengthMovementVariant127, other.StrengthMovementVariant127) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant128?>.Default.Equals(StrengthMovementVariant128, other.StrengthMovementVariant128) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant129?>.Default.Equals(StrengthMovementVariant129, other.StrengthMovementVariant129) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant130?>.Default.Equals(StrengthMovementVariant130, other.StrengthMovementVariant130) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant131?>.Default.Equals(StrengthMovementVariant131, other.StrengthMovementVariant131) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant132?>.Default.Equals(StrengthMovementVariant132, other.StrengthMovementVariant132) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant133?>.Default.Equals(StrengthMovementVariant133, other.StrengthMovementVariant133) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant134?>.Default.Equals(StrengthMovementVariant134, other.StrengthMovementVariant134) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant135?>.Default.Equals(StrengthMovementVariant135, other.StrengthMovementVariant135) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant136?>.Default.Equals(StrengthMovementVariant136, other.StrengthMovementVariant136) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant137?>.Default.Equals(StrengthMovementVariant137, other.StrengthMovementVariant137) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant138?>.Default.Equals(StrengthMovementVariant138, other.StrengthMovementVariant138) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant139?>.Default.Equals(StrengthMovementVariant139, other.StrengthMovementVariant139) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant140?>.Default.Equals(StrengthMovementVariant140, other.StrengthMovementVariant140) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant141?>.Default.Equals(StrengthMovementVariant141, other.StrengthMovementVariant141) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant142?>.Default.Equals(StrengthMovementVariant142, other.StrengthMovementVariant142) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant143?>.Default.Equals(StrengthMovementVariant143, other.StrengthMovementVariant143) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant144?>.Default.Equals(StrengthMovementVariant144, other.StrengthMovementVariant144) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant145?>.Default.Equals(StrengthMovementVariant145, other.StrengthMovementVariant145) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant146?>.Default.Equals(StrengthMovementVariant146, other.StrengthMovementVariant146) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant147?>.Default.Equals(StrengthMovementVariant147, other.StrengthMovementVariant147) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant148?>.Default.Equals(StrengthMovementVariant148, other.StrengthMovementVariant148) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant149?>.Default.Equals(StrengthMovementVariant149, other.StrengthMovementVariant149) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant150?>.Default.Equals(StrengthMovementVariant150, other.StrengthMovementVariant150) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant151?>.Default.Equals(StrengthMovementVariant151, other.StrengthMovementVariant151) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant152?>.Default.Equals(StrengthMovementVariant152, other.StrengthMovementVariant152) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant153?>.Default.Equals(StrengthMovementVariant153, other.StrengthMovementVariant153) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant154?>.Default.Equals(StrengthMovementVariant154, other.StrengthMovementVariant154) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant155?>.Default.Equals(StrengthMovementVariant155, other.StrengthMovementVariant155) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant156?>.Default.Equals(StrengthMovementVariant156, other.StrengthMovementVariant156) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant157?>.Default.Equals(StrengthMovementVariant157, other.StrengthMovementVariant157) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant158?>.Default.Equals(StrengthMovementVariant158, other.StrengthMovementVariant158) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant159?>.Default.Equals(StrengthMovementVariant159, other.StrengthMovementVariant159) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant160?>.Default.Equals(StrengthMovementVariant160, other.StrengthMovementVariant160) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant161?>.Default.Equals(StrengthMovementVariant161, other.StrengthMovementVariant161) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant162?>.Default.Equals(StrengthMovementVariant162, other.StrengthMovementVariant162) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant163?>.Default.Equals(StrengthMovementVariant163, other.StrengthMovementVariant163) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant164?>.Default.Equals(StrengthMovementVariant164, other.StrengthMovementVariant164) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant165?>.Default.Equals(StrengthMovementVariant165, other.StrengthMovementVariant165) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant166?>.Default.Equals(StrengthMovementVariant166, other.StrengthMovementVariant166) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant167?>.Default.Equals(StrengthMovementVariant167, other.StrengthMovementVariant167) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant168?>.Default.Equals(StrengthMovementVariant168, other.StrengthMovementVariant168) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant169?>.Default.Equals(StrengthMovementVariant169, other.StrengthMovementVariant169) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant170?>.Default.Equals(StrengthMovementVariant170, other.StrengthMovementVariant170) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant171?>.Default.Equals(StrengthMovementVariant171, other.StrengthMovementVariant171) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant172?>.Default.Equals(StrengthMovementVariant172, other.StrengthMovementVariant172) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant173?>.Default.Equals(StrengthMovementVariant173, other.StrengthMovementVariant173) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant174?>.Default.Equals(StrengthMovementVariant174, other.StrengthMovementVariant174) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMovementVariant175?>.Default.Equals(StrengthMovementVariant175, other.StrengthMovementVariant175) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthMovementVariant176, other.StrengthMovementVariant176)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthMovement obj1, StrengthMovement obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthMovement>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthMovement obj1, StrengthMovement obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthMovement o && Equals(o);
        }
    }
}

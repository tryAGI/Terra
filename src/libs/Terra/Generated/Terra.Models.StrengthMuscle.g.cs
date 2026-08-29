#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// A muscle group an exercise works, used by both primary_muscles and secondary_muscles. Open enum — handle unknown values gracefully.<br/>
    /// Members are training groups rather than anatomy: a source naming a specific head reports the group it belongs to, so the same exercise groups the same way whichever app recorded it.<br/>
    /// Members are added over time, and a new one changes the total of the member it is most closely related to. If you aggregate per muscle, plan for that.<br/>
    /// Some members are parts of a broader one and can be summed with it for a coarse view that stays stable: `lat` + `upper_back` + `back` covers the whole back, and `obliques` + `abs` the whole midsection.<br/>
    /// Others are their own group and should not be folded into a neighbour — `serratus` is not part of the chest, `tibialis` is not part of the calves, and `hip_flexor` is not part of the quadriceps.<br/>
    /// Example: abductors
    /// </summary>
    public readonly partial struct StrengthMuscle : global::System.IEquatable<StrengthMuscle>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant1? StrengthMuscleVariant1 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant1? StrengthMuscleVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant1))]
#endif
        public bool IsStrengthMuscleVariant1 => StrengthMuscleVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant1? value)
        {
            value = StrengthMuscleVariant1;
            return IsStrengthMuscleVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant1 PickStrengthMuscleVariant1() => IsStrengthMuscleVariant1
            ? StrengthMuscleVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant2? StrengthMuscleVariant2 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant2? StrengthMuscleVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant2))]
#endif
        public bool IsStrengthMuscleVariant2 => StrengthMuscleVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant2? value)
        {
            value = StrengthMuscleVariant2;
            return IsStrengthMuscleVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant2 PickStrengthMuscleVariant2() => IsStrengthMuscleVariant2
            ? StrengthMuscleVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant3? StrengthMuscleVariant3 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant3? StrengthMuscleVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant3))]
#endif
        public bool IsStrengthMuscleVariant3 => StrengthMuscleVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant3? value)
        {
            value = StrengthMuscleVariant3;
            return IsStrengthMuscleVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant3 PickStrengthMuscleVariant3() => IsStrengthMuscleVariant3
            ? StrengthMuscleVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant3' but the value was {ToString()}.");

        /// <summary>
        /// The back without a part named. Where a source distinguishes the lats or the upper back, `lat` or `upper_back` is reported instead.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant4? StrengthMuscleVariant4 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant4? StrengthMuscleVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant4))]
#endif
        public bool IsStrengthMuscleVariant4 => StrengthMuscleVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant4? value)
        {
            value = StrengthMuscleVariant4;
            return IsStrengthMuscleVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant4 PickStrengthMuscleVariant4() => IsStrengthMuscleVariant4
            ? StrengthMuscleVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant5? StrengthMuscleVariant5 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant5? StrengthMuscleVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant5))]
#endif
        public bool IsStrengthMuscleVariant5 => StrengthMuscleVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant5? value)
        {
            value = StrengthMuscleVariant5;
            return IsStrengthMuscleVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant5 PickStrengthMuscleVariant5() => IsStrengthMuscleVariant5
            ? StrengthMuscleVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant6? StrengthMuscleVariant6 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant6? StrengthMuscleVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant6))]
#endif
        public bool IsStrengthMuscleVariant6 => StrengthMuscleVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant6? value)
        {
            value = StrengthMuscleVariant6;
            return IsStrengthMuscleVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant6 PickStrengthMuscleVariant6() => IsStrengthMuscleVariant6
            ? StrengthMuscleVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant7? StrengthMuscleVariant7 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant7? StrengthMuscleVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant7))]
#endif
        public bool IsStrengthMuscleVariant7 => StrengthMuscleVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant7? value)
        {
            value = StrengthMuscleVariant7;
            return IsStrengthMuscleVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant7 PickStrengthMuscleVariant7() => IsStrengthMuscleVariant7
            ? StrengthMuscleVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant8? StrengthMuscleVariant8 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant8? StrengthMuscleVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant8))]
#endif
        public bool IsStrengthMuscleVariant8 => StrengthMuscleVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant8? value)
        {
            value = StrengthMuscleVariant8;
            return IsStrengthMuscleVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant8 PickStrengthMuscleVariant8() => IsStrengthMuscleVariant8
            ? StrengthMuscleVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant9? StrengthMuscleVariant9 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant9? StrengthMuscleVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant9))]
#endif
        public bool IsStrengthMuscleVariant9 => StrengthMuscleVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant9? value)
        {
            value = StrengthMuscleVariant9;
            return IsStrengthMuscleVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant9 PickStrengthMuscleVariant9() => IsStrengthMuscleVariant9
            ? StrengthMuscleVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant10? StrengthMuscleVariant10 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant10? StrengthMuscleVariant10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant10))]
#endif
        public bool IsStrengthMuscleVariant10 => StrengthMuscleVariant10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant10? value)
        {
            value = StrengthMuscleVariant10;
            return IsStrengthMuscleVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant10 PickStrengthMuscleVariant10() => IsStrengthMuscleVariant10
            ? StrengthMuscleVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant10' but the value was {ToString()}.");

        /// <summary>
        /// Iliopsoas and sartorius. Its own group — not part of the quadriceps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant11? StrengthMuscleVariant11 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant11? StrengthMuscleVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant11))]
#endif
        public bool IsStrengthMuscleVariant11 => StrengthMuscleVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant11? value)
        {
            value = StrengthMuscleVariant11;
            return IsStrengthMuscleVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant11 PickStrengthMuscleVariant11() => IsStrengthMuscleVariant11
            ? StrengthMuscleVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant11' but the value was {ToString()}.");

        /// <summary>
        /// Latissimus dorsi. Reported separately from `back` and `upper_back`: a pulldown and a row are different work.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant12? StrengthMuscleVariant12 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant12? StrengthMuscleVariant12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant12))]
#endif
        public bool IsStrengthMuscleVariant12 => StrengthMuscleVariant12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant12? value)
        {
            value = StrengthMuscleVariant12;
            return IsStrengthMuscleVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant12 PickStrengthMuscleVariant12() => IsStrengthMuscleVariant12
            ? StrengthMuscleVariant12!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant12' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant13? StrengthMuscleVariant13 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant13? StrengthMuscleVariant13 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant13))]
#endif
        public bool IsStrengthMuscleVariant13 => StrengthMuscleVariant13 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant13? value)
        {
            value = StrengthMuscleVariant13;
            return IsStrengthMuscleVariant13;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant13 PickStrengthMuscleVariant13() => IsStrengthMuscleVariant13
            ? StrengthMuscleVariant13!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant13' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant14? StrengthMuscleVariant14 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant14? StrengthMuscleVariant14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant14))]
#endif
        public bool IsStrengthMuscleVariant14 => StrengthMuscleVariant14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant14? value)
        {
            value = StrengthMuscleVariant14;
            return IsStrengthMuscleVariant14;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant14 PickStrengthMuscleVariant14() => IsStrengthMuscleVariant14
            ? StrengthMuscleVariant14!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant14' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant15? StrengthMuscleVariant15 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant15? StrengthMuscleVariant15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant15))]
#endif
        public bool IsStrengthMuscleVariant15 => StrengthMuscleVariant15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant15? value)
        {
            value = StrengthMuscleVariant15;
            return IsStrengthMuscleVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant15 PickStrengthMuscleVariant15() => IsStrengthMuscleVariant15
            ? StrengthMuscleVariant15!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant16? StrengthMuscleVariant16 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant16? StrengthMuscleVariant16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant16))]
#endif
        public bool IsStrengthMuscleVariant16 => StrengthMuscleVariant16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant16? value)
        {
            value = StrengthMuscleVariant16;
            return IsStrengthMuscleVariant16;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant16 PickStrengthMuscleVariant16() => IsStrengthMuscleVariant16
            ? StrengthMuscleVariant16!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant16' but the value was {ToString()}.");

        /// <summary>
        /// Serratus anterior. Its own group — not part of the chest.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant17? StrengthMuscleVariant17 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant17? StrengthMuscleVariant17 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant17))]
#endif
        public bool IsStrengthMuscleVariant17 => StrengthMuscleVariant17 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant17? value)
        {
            value = StrengthMuscleVariant17;
            return IsStrengthMuscleVariant17;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant17 PickStrengthMuscleVariant17() => IsStrengthMuscleVariant17
            ? StrengthMuscleVariant17!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant17' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant18? StrengthMuscleVariant18 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant18? StrengthMuscleVariant18 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant18))]
#endif
        public bool IsStrengthMuscleVariant18 => StrengthMuscleVariant18 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant18(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant18? value)
        {
            value = StrengthMuscleVariant18;
            return IsStrengthMuscleVariant18;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant18 PickStrengthMuscleVariant18() => IsStrengthMuscleVariant18
            ? StrengthMuscleVariant18!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant18' but the value was {ToString()}.");

        /// <summary>
        /// Tibialis anterior. Its own group — not part of the calves, which it opposes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant19? StrengthMuscleVariant19 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant19? StrengthMuscleVariant19 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant19))]
#endif
        public bool IsStrengthMuscleVariant19 => StrengthMuscleVariant19 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant19(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant19? value)
        {
            value = StrengthMuscleVariant19;
            return IsStrengthMuscleVariant19;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant19 PickStrengthMuscleVariant19() => IsStrengthMuscleVariant19
            ? StrengthMuscleVariant19!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant19' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant20? StrengthMuscleVariant20 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant20? StrengthMuscleVariant20 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant20))]
#endif
        public bool IsStrengthMuscleVariant20 => StrengthMuscleVariant20 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant20? value)
        {
            value = StrengthMuscleVariant20;
            return IsStrengthMuscleVariant20;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant20 PickStrengthMuscleVariant20() => IsStrengthMuscleVariant20
            ? StrengthMuscleVariant20!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant20' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant21? StrengthMuscleVariant21 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant21? StrengthMuscleVariant21 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant21))]
#endif
        public bool IsStrengthMuscleVariant21 => StrengthMuscleVariant21 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant21(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant21? value)
        {
            value = StrengthMuscleVariant21;
            return IsStrengthMuscleVariant21;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant21 PickStrengthMuscleVariant21() => IsStrengthMuscleVariant21
            ? StrengthMuscleVariant21!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant21' but the value was {ToString()}.");

        /// <summary>
        /// The upper back — rhomboids and mid traps — as distinct from the lats.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant22? StrengthMuscleVariant22 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant22? StrengthMuscleVariant22 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant22))]
#endif
        public bool IsStrengthMuscleVariant22 => StrengthMuscleVariant22 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant22(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant22? value)
        {
            value = StrengthMuscleVariant22;
            return IsStrengthMuscleVariant22;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant22 PickStrengthMuscleVariant22() => IsStrengthMuscleVariant22
            ? StrengthMuscleVariant22!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant22' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthMuscleVariant23? StrengthMuscleVariant23 { get; init; }
#else
        public global::Terra.StrengthMuscleVariant23? StrengthMuscleVariant23 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant23))]
#endif
        public bool IsStrengthMuscleVariant23 => StrengthMuscleVariant23 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant23(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthMuscleVariant23? value)
        {
            value = StrengthMuscleVariant23;
            return IsStrengthMuscleVariant23;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthMuscleVariant23 PickStrengthMuscleVariant23() => IsStrengthMuscleVariant23
            ? StrengthMuscleVariant23!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant23' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthMuscleVariant24 { get; init; }
#else
        public string? StrengthMuscleVariant24 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthMuscleVariant24))]
#endif
        public bool IsStrengthMuscleVariant24 => StrengthMuscleVariant24 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthMuscleVariant24(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthMuscleVariant24;
            return IsStrengthMuscleVariant24;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthMuscleVariant24() => IsStrengthMuscleVariant24
            ? StrengthMuscleVariant24!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthMuscleVariant24' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant1 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant1?(StrengthMuscle @this) => @this.StrengthMuscleVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant1? value)
        {
            StrengthMuscleVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant1(global::Terra.StrengthMuscleVariant1? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant2 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant2?(StrengthMuscle @this) => @this.StrengthMuscleVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant2? value)
        {
            StrengthMuscleVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant2(global::Terra.StrengthMuscleVariant2? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant3 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant3?(StrengthMuscle @this) => @this.StrengthMuscleVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant3? value)
        {
            StrengthMuscleVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant3(global::Terra.StrengthMuscleVariant3? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant4 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant4?(StrengthMuscle @this) => @this.StrengthMuscleVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant4? value)
        {
            StrengthMuscleVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant4(global::Terra.StrengthMuscleVariant4? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant5 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant5?(StrengthMuscle @this) => @this.StrengthMuscleVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant5? value)
        {
            StrengthMuscleVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant5(global::Terra.StrengthMuscleVariant5? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant6 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant6?(StrengthMuscle @this) => @this.StrengthMuscleVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant6? value)
        {
            StrengthMuscleVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant6(global::Terra.StrengthMuscleVariant6? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant7 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant7?(StrengthMuscle @this) => @this.StrengthMuscleVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant7? value)
        {
            StrengthMuscleVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant7(global::Terra.StrengthMuscleVariant7? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant8 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant8?(StrengthMuscle @this) => @this.StrengthMuscleVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant8? value)
        {
            StrengthMuscleVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant8(global::Terra.StrengthMuscleVariant8? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant9 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant9?(StrengthMuscle @this) => @this.StrengthMuscleVariant9;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant9? value)
        {
            StrengthMuscleVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant9(global::Terra.StrengthMuscleVariant9? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant10 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant10?(StrengthMuscle @this) => @this.StrengthMuscleVariant10;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant10? value)
        {
            StrengthMuscleVariant10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant10(global::Terra.StrengthMuscleVariant10? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant11 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant11?(StrengthMuscle @this) => @this.StrengthMuscleVariant11;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant11? value)
        {
            StrengthMuscleVariant11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant11(global::Terra.StrengthMuscleVariant11? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant12 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant12?(StrengthMuscle @this) => @this.StrengthMuscleVariant12;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant12? value)
        {
            StrengthMuscleVariant12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant12(global::Terra.StrengthMuscleVariant12? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant13 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant13?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant13?(StrengthMuscle @this) => @this.StrengthMuscleVariant13;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant13? value)
        {
            StrengthMuscleVariant13 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant13(global::Terra.StrengthMuscleVariant13? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant14 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant14?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant14?(StrengthMuscle @this) => @this.StrengthMuscleVariant14;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant14? value)
        {
            StrengthMuscleVariant14 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant14(global::Terra.StrengthMuscleVariant14? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant15 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant15?(StrengthMuscle @this) => @this.StrengthMuscleVariant15;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant15? value)
        {
            StrengthMuscleVariant15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant15(global::Terra.StrengthMuscleVariant15? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant16 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant16?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant16?(StrengthMuscle @this) => @this.StrengthMuscleVariant16;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant16? value)
        {
            StrengthMuscleVariant16 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant16(global::Terra.StrengthMuscleVariant16? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant17 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant17?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant17?(StrengthMuscle @this) => @this.StrengthMuscleVariant17;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant17? value)
        {
            StrengthMuscleVariant17 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant17(global::Terra.StrengthMuscleVariant17? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant18 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant18?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant18?(StrengthMuscle @this) => @this.StrengthMuscleVariant18;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant18? value)
        {
            StrengthMuscleVariant18 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant18(global::Terra.StrengthMuscleVariant18? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant19 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant19?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant19?(StrengthMuscle @this) => @this.StrengthMuscleVariant19;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant19? value)
        {
            StrengthMuscleVariant19 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant19(global::Terra.StrengthMuscleVariant19? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant20 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant20?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant20?(StrengthMuscle @this) => @this.StrengthMuscleVariant20;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant20? value)
        {
            StrengthMuscleVariant20 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant20(global::Terra.StrengthMuscleVariant20? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant21 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant21?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant21?(StrengthMuscle @this) => @this.StrengthMuscleVariant21;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant21? value)
        {
            StrengthMuscleVariant21 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant21(global::Terra.StrengthMuscleVariant21? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant22 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant22?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant22?(StrengthMuscle @this) => @this.StrengthMuscleVariant22;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant22? value)
        {
            StrengthMuscleVariant22 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant22(global::Terra.StrengthMuscleVariant22? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(global::Terra.StrengthMuscleVariant23 value) => new StrengthMuscle((global::Terra.StrengthMuscleVariant23?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthMuscleVariant23?(StrengthMuscle @this) => @this.StrengthMuscleVariant23;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(global::Terra.StrengthMuscleVariant23? value)
        {
            StrengthMuscleVariant23 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant23(global::Terra.StrengthMuscleVariant23? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthMuscle(string value) => new StrengthMuscle((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthMuscle @this) => @this.StrengthMuscleVariant24;

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(string? value)
        {
            StrengthMuscleVariant24 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthMuscle FromStrengthMuscleVariant24(string? value) => new StrengthMuscle(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthMuscle(
            global::Terra.StrengthMuscleVariant1? strengthMuscleVariant1,
            global::Terra.StrengthMuscleVariant2? strengthMuscleVariant2,
            global::Terra.StrengthMuscleVariant3? strengthMuscleVariant3,
            global::Terra.StrengthMuscleVariant4? strengthMuscleVariant4,
            global::Terra.StrengthMuscleVariant5? strengthMuscleVariant5,
            global::Terra.StrengthMuscleVariant6? strengthMuscleVariant6,
            global::Terra.StrengthMuscleVariant7? strengthMuscleVariant7,
            global::Terra.StrengthMuscleVariant8? strengthMuscleVariant8,
            global::Terra.StrengthMuscleVariant9? strengthMuscleVariant9,
            global::Terra.StrengthMuscleVariant10? strengthMuscleVariant10,
            global::Terra.StrengthMuscleVariant11? strengthMuscleVariant11,
            global::Terra.StrengthMuscleVariant12? strengthMuscleVariant12,
            global::Terra.StrengthMuscleVariant13? strengthMuscleVariant13,
            global::Terra.StrengthMuscleVariant14? strengthMuscleVariant14,
            global::Terra.StrengthMuscleVariant15? strengthMuscleVariant15,
            global::Terra.StrengthMuscleVariant16? strengthMuscleVariant16,
            global::Terra.StrengthMuscleVariant17? strengthMuscleVariant17,
            global::Terra.StrengthMuscleVariant18? strengthMuscleVariant18,
            global::Terra.StrengthMuscleVariant19? strengthMuscleVariant19,
            global::Terra.StrengthMuscleVariant20? strengthMuscleVariant20,
            global::Terra.StrengthMuscleVariant21? strengthMuscleVariant21,
            global::Terra.StrengthMuscleVariant22? strengthMuscleVariant22,
            global::Terra.StrengthMuscleVariant23? strengthMuscleVariant23,
            string? strengthMuscleVariant24
            )
        {
            StrengthMuscleVariant1 = strengthMuscleVariant1;
            StrengthMuscleVariant2 = strengthMuscleVariant2;
            StrengthMuscleVariant3 = strengthMuscleVariant3;
            StrengthMuscleVariant4 = strengthMuscleVariant4;
            StrengthMuscleVariant5 = strengthMuscleVariant5;
            StrengthMuscleVariant6 = strengthMuscleVariant6;
            StrengthMuscleVariant7 = strengthMuscleVariant7;
            StrengthMuscleVariant8 = strengthMuscleVariant8;
            StrengthMuscleVariant9 = strengthMuscleVariant9;
            StrengthMuscleVariant10 = strengthMuscleVariant10;
            StrengthMuscleVariant11 = strengthMuscleVariant11;
            StrengthMuscleVariant12 = strengthMuscleVariant12;
            StrengthMuscleVariant13 = strengthMuscleVariant13;
            StrengthMuscleVariant14 = strengthMuscleVariant14;
            StrengthMuscleVariant15 = strengthMuscleVariant15;
            StrengthMuscleVariant16 = strengthMuscleVariant16;
            StrengthMuscleVariant17 = strengthMuscleVariant17;
            StrengthMuscleVariant18 = strengthMuscleVariant18;
            StrengthMuscleVariant19 = strengthMuscleVariant19;
            StrengthMuscleVariant20 = strengthMuscleVariant20;
            StrengthMuscleVariant21 = strengthMuscleVariant21;
            StrengthMuscleVariant22 = strengthMuscleVariant22;
            StrengthMuscleVariant23 = strengthMuscleVariant23;
            StrengthMuscleVariant24 = strengthMuscleVariant24;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthMuscleVariant24 as object ??
            StrengthMuscleVariant23 as object ??
            StrengthMuscleVariant22 as object ??
            StrengthMuscleVariant21 as object ??
            StrengthMuscleVariant20 as object ??
            StrengthMuscleVariant19 as object ??
            StrengthMuscleVariant18 as object ??
            StrengthMuscleVariant17 as object ??
            StrengthMuscleVariant16 as object ??
            StrengthMuscleVariant15 as object ??
            StrengthMuscleVariant14 as object ??
            StrengthMuscleVariant13 as object ??
            StrengthMuscleVariant12 as object ??
            StrengthMuscleVariant11 as object ??
            StrengthMuscleVariant10 as object ??
            StrengthMuscleVariant9 as object ??
            StrengthMuscleVariant8 as object ??
            StrengthMuscleVariant7 as object ??
            StrengthMuscleVariant6 as object ??
            StrengthMuscleVariant5 as object ??
            StrengthMuscleVariant4 as object ??
            StrengthMuscleVariant3 as object ??
            StrengthMuscleVariant2 as object ??
            StrengthMuscleVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthMuscleVariant1?.ToValueString() ??
            StrengthMuscleVariant2?.ToValueString() ??
            StrengthMuscleVariant3?.ToValueString() ??
            StrengthMuscleVariant4?.ToValueString() ??
            StrengthMuscleVariant5?.ToValueString() ??
            StrengthMuscleVariant6?.ToValueString() ??
            StrengthMuscleVariant7?.ToValueString() ??
            StrengthMuscleVariant8?.ToValueString() ??
            StrengthMuscleVariant9?.ToValueString() ??
            StrengthMuscleVariant10?.ToValueString() ??
            StrengthMuscleVariant11?.ToValueString() ??
            StrengthMuscleVariant12?.ToValueString() ??
            StrengthMuscleVariant13?.ToValueString() ??
            StrengthMuscleVariant14?.ToValueString() ??
            StrengthMuscleVariant15?.ToValueString() ??
            StrengthMuscleVariant16?.ToValueString() ??
            StrengthMuscleVariant17?.ToValueString() ??
            StrengthMuscleVariant18?.ToValueString() ??
            StrengthMuscleVariant19?.ToValueString() ??
            StrengthMuscleVariant20?.ToValueString() ??
            StrengthMuscleVariant21?.ToValueString() ??
            StrengthMuscleVariant22?.ToValueString() ??
            StrengthMuscleVariant23?.ToValueString() ??
            StrengthMuscleVariant24?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthMuscleVariant1 || IsStrengthMuscleVariant2 || IsStrengthMuscleVariant3 || IsStrengthMuscleVariant4 || IsStrengthMuscleVariant5 || IsStrengthMuscleVariant6 || IsStrengthMuscleVariant7 || IsStrengthMuscleVariant8 || IsStrengthMuscleVariant9 || IsStrengthMuscleVariant10 || IsStrengthMuscleVariant11 || IsStrengthMuscleVariant12 || IsStrengthMuscleVariant13 || IsStrengthMuscleVariant14 || IsStrengthMuscleVariant15 || IsStrengthMuscleVariant16 || IsStrengthMuscleVariant17 || IsStrengthMuscleVariant18 || IsStrengthMuscleVariant19 || IsStrengthMuscleVariant20 || IsStrengthMuscleVariant21 || IsStrengthMuscleVariant22 || IsStrengthMuscleVariant23 || IsStrengthMuscleVariant24;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthMuscleVariant1?, TResult>? strengthMuscleVariant1 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant2?, TResult>? strengthMuscleVariant2 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant3?, TResult>? strengthMuscleVariant3 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant4?, TResult>? strengthMuscleVariant4 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant5?, TResult>? strengthMuscleVariant5 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant6?, TResult>? strengthMuscleVariant6 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant7?, TResult>? strengthMuscleVariant7 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant8?, TResult>? strengthMuscleVariant8 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant9?, TResult>? strengthMuscleVariant9 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant10?, TResult>? strengthMuscleVariant10 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant11?, TResult>? strengthMuscleVariant11 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant12?, TResult>? strengthMuscleVariant12 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant13?, TResult>? strengthMuscleVariant13 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant14?, TResult>? strengthMuscleVariant14 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant15?, TResult>? strengthMuscleVariant15 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant16?, TResult>? strengthMuscleVariant16 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant17?, TResult>? strengthMuscleVariant17 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant18?, TResult>? strengthMuscleVariant18 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant19?, TResult>? strengthMuscleVariant19 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant20?, TResult>? strengthMuscleVariant20 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant21?, TResult>? strengthMuscleVariant21 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant22?, TResult>? strengthMuscleVariant22 = null,
            global::System.Func<global::Terra.StrengthMuscleVariant23?, TResult>? strengthMuscleVariant23 = null,
            global::System.Func<string, TResult>? strengthMuscleVariant24 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthMuscleVariant1 && strengthMuscleVariant1 != null)
            {
                return strengthMuscleVariant1(StrengthMuscleVariant1!);
            }
            else if (IsStrengthMuscleVariant2 && strengthMuscleVariant2 != null)
            {
                return strengthMuscleVariant2(StrengthMuscleVariant2!);
            }
            else if (IsStrengthMuscleVariant3 && strengthMuscleVariant3 != null)
            {
                return strengthMuscleVariant3(StrengthMuscleVariant3!);
            }
            else if (IsStrengthMuscleVariant4 && strengthMuscleVariant4 != null)
            {
                return strengthMuscleVariant4(StrengthMuscleVariant4!);
            }
            else if (IsStrengthMuscleVariant5 && strengthMuscleVariant5 != null)
            {
                return strengthMuscleVariant5(StrengthMuscleVariant5!);
            }
            else if (IsStrengthMuscleVariant6 && strengthMuscleVariant6 != null)
            {
                return strengthMuscleVariant6(StrengthMuscleVariant6!);
            }
            else if (IsStrengthMuscleVariant7 && strengthMuscleVariant7 != null)
            {
                return strengthMuscleVariant7(StrengthMuscleVariant7!);
            }
            else if (IsStrengthMuscleVariant8 && strengthMuscleVariant8 != null)
            {
                return strengthMuscleVariant8(StrengthMuscleVariant8!);
            }
            else if (IsStrengthMuscleVariant9 && strengthMuscleVariant9 != null)
            {
                return strengthMuscleVariant9(StrengthMuscleVariant9!);
            }
            else if (IsStrengthMuscleVariant10 && strengthMuscleVariant10 != null)
            {
                return strengthMuscleVariant10(StrengthMuscleVariant10!);
            }
            else if (IsStrengthMuscleVariant11 && strengthMuscleVariant11 != null)
            {
                return strengthMuscleVariant11(StrengthMuscleVariant11!);
            }
            else if (IsStrengthMuscleVariant12 && strengthMuscleVariant12 != null)
            {
                return strengthMuscleVariant12(StrengthMuscleVariant12!);
            }
            else if (IsStrengthMuscleVariant13 && strengthMuscleVariant13 != null)
            {
                return strengthMuscleVariant13(StrengthMuscleVariant13!);
            }
            else if (IsStrengthMuscleVariant14 && strengthMuscleVariant14 != null)
            {
                return strengthMuscleVariant14(StrengthMuscleVariant14!);
            }
            else if (IsStrengthMuscleVariant15 && strengthMuscleVariant15 != null)
            {
                return strengthMuscleVariant15(StrengthMuscleVariant15!);
            }
            else if (IsStrengthMuscleVariant16 && strengthMuscleVariant16 != null)
            {
                return strengthMuscleVariant16(StrengthMuscleVariant16!);
            }
            else if (IsStrengthMuscleVariant17 && strengthMuscleVariant17 != null)
            {
                return strengthMuscleVariant17(StrengthMuscleVariant17!);
            }
            else if (IsStrengthMuscleVariant18 && strengthMuscleVariant18 != null)
            {
                return strengthMuscleVariant18(StrengthMuscleVariant18!);
            }
            else if (IsStrengthMuscleVariant19 && strengthMuscleVariant19 != null)
            {
                return strengthMuscleVariant19(StrengthMuscleVariant19!);
            }
            else if (IsStrengthMuscleVariant20 && strengthMuscleVariant20 != null)
            {
                return strengthMuscleVariant20(StrengthMuscleVariant20!);
            }
            else if (IsStrengthMuscleVariant21 && strengthMuscleVariant21 != null)
            {
                return strengthMuscleVariant21(StrengthMuscleVariant21!);
            }
            else if (IsStrengthMuscleVariant22 && strengthMuscleVariant22 != null)
            {
                return strengthMuscleVariant22(StrengthMuscleVariant22!);
            }
            else if (IsStrengthMuscleVariant23 && strengthMuscleVariant23 != null)
            {
                return strengthMuscleVariant23(StrengthMuscleVariant23!);
            }
            else if (IsStrengthMuscleVariant24 && strengthMuscleVariant24 != null)
            {
                return strengthMuscleVariant24(StrengthMuscleVariant24!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthMuscleVariant1?>? strengthMuscleVariant1 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant2?>? strengthMuscleVariant2 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant3?>? strengthMuscleVariant3 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant4?>? strengthMuscleVariant4 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant5?>? strengthMuscleVariant5 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant6?>? strengthMuscleVariant6 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant7?>? strengthMuscleVariant7 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant8?>? strengthMuscleVariant8 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant9?>? strengthMuscleVariant9 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant10?>? strengthMuscleVariant10 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant11?>? strengthMuscleVariant11 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant12?>? strengthMuscleVariant12 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant13?>? strengthMuscleVariant13 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant14?>? strengthMuscleVariant14 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant15?>? strengthMuscleVariant15 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant16?>? strengthMuscleVariant16 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant17?>? strengthMuscleVariant17 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant18?>? strengthMuscleVariant18 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant19?>? strengthMuscleVariant19 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant20?>? strengthMuscleVariant20 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant21?>? strengthMuscleVariant21 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant22?>? strengthMuscleVariant22 = null,

            global::System.Action<global::Terra.StrengthMuscleVariant23?>? strengthMuscleVariant23 = null,

            global::System.Action<string>? strengthMuscleVariant24 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthMuscleVariant1)
            {
                strengthMuscleVariant1?.Invoke(StrengthMuscleVariant1!);
            }
            else if (IsStrengthMuscleVariant2)
            {
                strengthMuscleVariant2?.Invoke(StrengthMuscleVariant2!);
            }
            else if (IsStrengthMuscleVariant3)
            {
                strengthMuscleVariant3?.Invoke(StrengthMuscleVariant3!);
            }
            else if (IsStrengthMuscleVariant4)
            {
                strengthMuscleVariant4?.Invoke(StrengthMuscleVariant4!);
            }
            else if (IsStrengthMuscleVariant5)
            {
                strengthMuscleVariant5?.Invoke(StrengthMuscleVariant5!);
            }
            else if (IsStrengthMuscleVariant6)
            {
                strengthMuscleVariant6?.Invoke(StrengthMuscleVariant6!);
            }
            else if (IsStrengthMuscleVariant7)
            {
                strengthMuscleVariant7?.Invoke(StrengthMuscleVariant7!);
            }
            else if (IsStrengthMuscleVariant8)
            {
                strengthMuscleVariant8?.Invoke(StrengthMuscleVariant8!);
            }
            else if (IsStrengthMuscleVariant9)
            {
                strengthMuscleVariant9?.Invoke(StrengthMuscleVariant9!);
            }
            else if (IsStrengthMuscleVariant10)
            {
                strengthMuscleVariant10?.Invoke(StrengthMuscleVariant10!);
            }
            else if (IsStrengthMuscleVariant11)
            {
                strengthMuscleVariant11?.Invoke(StrengthMuscleVariant11!);
            }
            else if (IsStrengthMuscleVariant12)
            {
                strengthMuscleVariant12?.Invoke(StrengthMuscleVariant12!);
            }
            else if (IsStrengthMuscleVariant13)
            {
                strengthMuscleVariant13?.Invoke(StrengthMuscleVariant13!);
            }
            else if (IsStrengthMuscleVariant14)
            {
                strengthMuscleVariant14?.Invoke(StrengthMuscleVariant14!);
            }
            else if (IsStrengthMuscleVariant15)
            {
                strengthMuscleVariant15?.Invoke(StrengthMuscleVariant15!);
            }
            else if (IsStrengthMuscleVariant16)
            {
                strengthMuscleVariant16?.Invoke(StrengthMuscleVariant16!);
            }
            else if (IsStrengthMuscleVariant17)
            {
                strengthMuscleVariant17?.Invoke(StrengthMuscleVariant17!);
            }
            else if (IsStrengthMuscleVariant18)
            {
                strengthMuscleVariant18?.Invoke(StrengthMuscleVariant18!);
            }
            else if (IsStrengthMuscleVariant19)
            {
                strengthMuscleVariant19?.Invoke(StrengthMuscleVariant19!);
            }
            else if (IsStrengthMuscleVariant20)
            {
                strengthMuscleVariant20?.Invoke(StrengthMuscleVariant20!);
            }
            else if (IsStrengthMuscleVariant21)
            {
                strengthMuscleVariant21?.Invoke(StrengthMuscleVariant21!);
            }
            else if (IsStrengthMuscleVariant22)
            {
                strengthMuscleVariant22?.Invoke(StrengthMuscleVariant22!);
            }
            else if (IsStrengthMuscleVariant23)
            {
                strengthMuscleVariant23?.Invoke(StrengthMuscleVariant23!);
            }
            else if (IsStrengthMuscleVariant24)
            {
                strengthMuscleVariant24?.Invoke(StrengthMuscleVariant24!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthMuscleVariant1?>? strengthMuscleVariant1 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant2?>? strengthMuscleVariant2 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant3?>? strengthMuscleVariant3 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant4?>? strengthMuscleVariant4 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant5?>? strengthMuscleVariant5 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant6?>? strengthMuscleVariant6 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant7?>? strengthMuscleVariant7 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant8?>? strengthMuscleVariant8 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant9?>? strengthMuscleVariant9 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant10?>? strengthMuscleVariant10 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant11?>? strengthMuscleVariant11 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant12?>? strengthMuscleVariant12 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant13?>? strengthMuscleVariant13 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant14?>? strengthMuscleVariant14 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant15?>? strengthMuscleVariant15 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant16?>? strengthMuscleVariant16 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant17?>? strengthMuscleVariant17 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant18?>? strengthMuscleVariant18 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant19?>? strengthMuscleVariant19 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant20?>? strengthMuscleVariant20 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant21?>? strengthMuscleVariant21 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant22?>? strengthMuscleVariant22 = null,
            global::System.Action<global::Terra.StrengthMuscleVariant23?>? strengthMuscleVariant23 = null,
            global::System.Action<string>? strengthMuscleVariant24 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthMuscleVariant1)
            {
                strengthMuscleVariant1?.Invoke(StrengthMuscleVariant1!);
            }
            else if (IsStrengthMuscleVariant2)
            {
                strengthMuscleVariant2?.Invoke(StrengthMuscleVariant2!);
            }
            else if (IsStrengthMuscleVariant3)
            {
                strengthMuscleVariant3?.Invoke(StrengthMuscleVariant3!);
            }
            else if (IsStrengthMuscleVariant4)
            {
                strengthMuscleVariant4?.Invoke(StrengthMuscleVariant4!);
            }
            else if (IsStrengthMuscleVariant5)
            {
                strengthMuscleVariant5?.Invoke(StrengthMuscleVariant5!);
            }
            else if (IsStrengthMuscleVariant6)
            {
                strengthMuscleVariant6?.Invoke(StrengthMuscleVariant6!);
            }
            else if (IsStrengthMuscleVariant7)
            {
                strengthMuscleVariant7?.Invoke(StrengthMuscleVariant7!);
            }
            else if (IsStrengthMuscleVariant8)
            {
                strengthMuscleVariant8?.Invoke(StrengthMuscleVariant8!);
            }
            else if (IsStrengthMuscleVariant9)
            {
                strengthMuscleVariant9?.Invoke(StrengthMuscleVariant9!);
            }
            else if (IsStrengthMuscleVariant10)
            {
                strengthMuscleVariant10?.Invoke(StrengthMuscleVariant10!);
            }
            else if (IsStrengthMuscleVariant11)
            {
                strengthMuscleVariant11?.Invoke(StrengthMuscleVariant11!);
            }
            else if (IsStrengthMuscleVariant12)
            {
                strengthMuscleVariant12?.Invoke(StrengthMuscleVariant12!);
            }
            else if (IsStrengthMuscleVariant13)
            {
                strengthMuscleVariant13?.Invoke(StrengthMuscleVariant13!);
            }
            else if (IsStrengthMuscleVariant14)
            {
                strengthMuscleVariant14?.Invoke(StrengthMuscleVariant14!);
            }
            else if (IsStrengthMuscleVariant15)
            {
                strengthMuscleVariant15?.Invoke(StrengthMuscleVariant15!);
            }
            else if (IsStrengthMuscleVariant16)
            {
                strengthMuscleVariant16?.Invoke(StrengthMuscleVariant16!);
            }
            else if (IsStrengthMuscleVariant17)
            {
                strengthMuscleVariant17?.Invoke(StrengthMuscleVariant17!);
            }
            else if (IsStrengthMuscleVariant18)
            {
                strengthMuscleVariant18?.Invoke(StrengthMuscleVariant18!);
            }
            else if (IsStrengthMuscleVariant19)
            {
                strengthMuscleVariant19?.Invoke(StrengthMuscleVariant19!);
            }
            else if (IsStrengthMuscleVariant20)
            {
                strengthMuscleVariant20?.Invoke(StrengthMuscleVariant20!);
            }
            else if (IsStrengthMuscleVariant21)
            {
                strengthMuscleVariant21?.Invoke(StrengthMuscleVariant21!);
            }
            else if (IsStrengthMuscleVariant22)
            {
                strengthMuscleVariant22?.Invoke(StrengthMuscleVariant22!);
            }
            else if (IsStrengthMuscleVariant23)
            {
                strengthMuscleVariant23?.Invoke(StrengthMuscleVariant23!);
            }
            else if (IsStrengthMuscleVariant24)
            {
                strengthMuscleVariant24?.Invoke(StrengthMuscleVariant24!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthMuscleVariant1,
                typeof(global::Terra.StrengthMuscleVariant1),
                StrengthMuscleVariant2,
                typeof(global::Terra.StrengthMuscleVariant2),
                StrengthMuscleVariant3,
                typeof(global::Terra.StrengthMuscleVariant3),
                StrengthMuscleVariant4,
                typeof(global::Terra.StrengthMuscleVariant4),
                StrengthMuscleVariant5,
                typeof(global::Terra.StrengthMuscleVariant5),
                StrengthMuscleVariant6,
                typeof(global::Terra.StrengthMuscleVariant6),
                StrengthMuscleVariant7,
                typeof(global::Terra.StrengthMuscleVariant7),
                StrengthMuscleVariant8,
                typeof(global::Terra.StrengthMuscleVariant8),
                StrengthMuscleVariant9,
                typeof(global::Terra.StrengthMuscleVariant9),
                StrengthMuscleVariant10,
                typeof(global::Terra.StrengthMuscleVariant10),
                StrengthMuscleVariant11,
                typeof(global::Terra.StrengthMuscleVariant11),
                StrengthMuscleVariant12,
                typeof(global::Terra.StrengthMuscleVariant12),
                StrengthMuscleVariant13,
                typeof(global::Terra.StrengthMuscleVariant13),
                StrengthMuscleVariant14,
                typeof(global::Terra.StrengthMuscleVariant14),
                StrengthMuscleVariant15,
                typeof(global::Terra.StrengthMuscleVariant15),
                StrengthMuscleVariant16,
                typeof(global::Terra.StrengthMuscleVariant16),
                StrengthMuscleVariant17,
                typeof(global::Terra.StrengthMuscleVariant17),
                StrengthMuscleVariant18,
                typeof(global::Terra.StrengthMuscleVariant18),
                StrengthMuscleVariant19,
                typeof(global::Terra.StrengthMuscleVariant19),
                StrengthMuscleVariant20,
                typeof(global::Terra.StrengthMuscleVariant20),
                StrengthMuscleVariant21,
                typeof(global::Terra.StrengthMuscleVariant21),
                StrengthMuscleVariant22,
                typeof(global::Terra.StrengthMuscleVariant22),
                StrengthMuscleVariant23,
                typeof(global::Terra.StrengthMuscleVariant23),
                StrengthMuscleVariant24,
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
        public bool Equals(StrengthMuscle other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant1?>.Default.Equals(StrengthMuscleVariant1, other.StrengthMuscleVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant2?>.Default.Equals(StrengthMuscleVariant2, other.StrengthMuscleVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant3?>.Default.Equals(StrengthMuscleVariant3, other.StrengthMuscleVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant4?>.Default.Equals(StrengthMuscleVariant4, other.StrengthMuscleVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant5?>.Default.Equals(StrengthMuscleVariant5, other.StrengthMuscleVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant6?>.Default.Equals(StrengthMuscleVariant6, other.StrengthMuscleVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant7?>.Default.Equals(StrengthMuscleVariant7, other.StrengthMuscleVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant8?>.Default.Equals(StrengthMuscleVariant8, other.StrengthMuscleVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant9?>.Default.Equals(StrengthMuscleVariant9, other.StrengthMuscleVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant10?>.Default.Equals(StrengthMuscleVariant10, other.StrengthMuscleVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant11?>.Default.Equals(StrengthMuscleVariant11, other.StrengthMuscleVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant12?>.Default.Equals(StrengthMuscleVariant12, other.StrengthMuscleVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant13?>.Default.Equals(StrengthMuscleVariant13, other.StrengthMuscleVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant14?>.Default.Equals(StrengthMuscleVariant14, other.StrengthMuscleVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant15?>.Default.Equals(StrengthMuscleVariant15, other.StrengthMuscleVariant15) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant16?>.Default.Equals(StrengthMuscleVariant16, other.StrengthMuscleVariant16) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant17?>.Default.Equals(StrengthMuscleVariant17, other.StrengthMuscleVariant17) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant18?>.Default.Equals(StrengthMuscleVariant18, other.StrengthMuscleVariant18) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant19?>.Default.Equals(StrengthMuscleVariant19, other.StrengthMuscleVariant19) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant20?>.Default.Equals(StrengthMuscleVariant20, other.StrengthMuscleVariant20) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant21?>.Default.Equals(StrengthMuscleVariant21, other.StrengthMuscleVariant21) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant22?>.Default.Equals(StrengthMuscleVariant22, other.StrengthMuscleVariant22) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthMuscleVariant23?>.Default.Equals(StrengthMuscleVariant23, other.StrengthMuscleVariant23) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthMuscleVariant24, other.StrengthMuscleVariant24)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthMuscle obj1, StrengthMuscle obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthMuscle>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthMuscle obj1, StrengthMuscle obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthMuscle o && Equals(o);
        }
    }
}

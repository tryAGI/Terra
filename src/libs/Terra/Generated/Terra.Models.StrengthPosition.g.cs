#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Orientation of the body or bench. Open enum — handle unknown values gracefully.<br/>
    /// Example: bent_over
    /// </summary>
    public readonly partial struct StrengthPosition : global::System.IEquatable<StrengthPosition>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant1? StrengthPositionVariant1 { get; init; }
#else
        public global::Terra.StrengthPositionVariant1? StrengthPositionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant1))]
#endif
        public bool IsStrengthPositionVariant1 => StrengthPositionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant1? value)
        {
            value = StrengthPositionVariant1;
            return IsStrengthPositionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant1 PickStrengthPositionVariant1() => StrengthPositionVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant2? StrengthPositionVariant2 { get; init; }
#else
        public global::Terra.StrengthPositionVariant2? StrengthPositionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant2))]
#endif
        public bool IsStrengthPositionVariant2 => StrengthPositionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant2? value)
        {
            value = StrengthPositionVariant2;
            return IsStrengthPositionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant2 PickStrengthPositionVariant2() => StrengthPositionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant3? StrengthPositionVariant3 { get; init; }
#else
        public global::Terra.StrengthPositionVariant3? StrengthPositionVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant3))]
#endif
        public bool IsStrengthPositionVariant3 => StrengthPositionVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant3? value)
        {
            value = StrengthPositionVariant3;
            return IsStrengthPositionVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant3 PickStrengthPositionVariant3() => StrengthPositionVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant4? StrengthPositionVariant4 { get; init; }
#else
        public global::Terra.StrengthPositionVariant4? StrengthPositionVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant4))]
#endif
        public bool IsStrengthPositionVariant4 => StrengthPositionVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant4? value)
        {
            value = StrengthPositionVariant4;
            return IsStrengthPositionVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant4 PickStrengthPositionVariant4() => StrengthPositionVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant5? StrengthPositionVariant5 { get; init; }
#else
        public global::Terra.StrengthPositionVariant5? StrengthPositionVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant5))]
#endif
        public bool IsStrengthPositionVariant5 => StrengthPositionVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant5? value)
        {
            value = StrengthPositionVariant5;
            return IsStrengthPositionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant5 PickStrengthPositionVariant5() => StrengthPositionVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant6? StrengthPositionVariant6 { get; init; }
#else
        public global::Terra.StrengthPositionVariant6? StrengthPositionVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant6))]
#endif
        public bool IsStrengthPositionVariant6 => StrengthPositionVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant6? value)
        {
            value = StrengthPositionVariant6;
            return IsStrengthPositionVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant6 PickStrengthPositionVariant6() => StrengthPositionVariant6 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant7? StrengthPositionVariant7 { get; init; }
#else
        public global::Terra.StrengthPositionVariant7? StrengthPositionVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant7))]
#endif
        public bool IsStrengthPositionVariant7 => StrengthPositionVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant7? value)
        {
            value = StrengthPositionVariant7;
            return IsStrengthPositionVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant7 PickStrengthPositionVariant7() => StrengthPositionVariant7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant8? StrengthPositionVariant8 { get; init; }
#else
        public global::Terra.StrengthPositionVariant8? StrengthPositionVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant8))]
#endif
        public bool IsStrengthPositionVariant8 => StrengthPositionVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant8? value)
        {
            value = StrengthPositionVariant8;
            return IsStrengthPositionVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant8 PickStrengthPositionVariant8() => StrengthPositionVariant8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant9? StrengthPositionVariant9 { get; init; }
#else
        public global::Terra.StrengthPositionVariant9? StrengthPositionVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant9))]
#endif
        public bool IsStrengthPositionVariant9 => StrengthPositionVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant9? value)
        {
            value = StrengthPositionVariant9;
            return IsStrengthPositionVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant9 PickStrengthPositionVariant9() => StrengthPositionVariant9 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant10? StrengthPositionVariant10 { get; init; }
#else
        public global::Terra.StrengthPositionVariant10? StrengthPositionVariant10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant10))]
#endif
        public bool IsStrengthPositionVariant10 => StrengthPositionVariant10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant10? value)
        {
            value = StrengthPositionVariant10;
            return IsStrengthPositionVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant10 PickStrengthPositionVariant10() => StrengthPositionVariant10 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant10' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant11? StrengthPositionVariant11 { get; init; }
#else
        public global::Terra.StrengthPositionVariant11? StrengthPositionVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant11))]
#endif
        public bool IsStrengthPositionVariant11 => StrengthPositionVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant11? value)
        {
            value = StrengthPositionVariant11;
            return IsStrengthPositionVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant11 PickStrengthPositionVariant11() => StrengthPositionVariant11 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant11' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant12? StrengthPositionVariant12 { get; init; }
#else
        public global::Terra.StrengthPositionVariant12? StrengthPositionVariant12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant12))]
#endif
        public bool IsStrengthPositionVariant12 => StrengthPositionVariant12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant12? value)
        {
            value = StrengthPositionVariant12;
            return IsStrengthPositionVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant12 PickStrengthPositionVariant12() => StrengthPositionVariant12 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant12' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant13? StrengthPositionVariant13 { get; init; }
#else
        public global::Terra.StrengthPositionVariant13? StrengthPositionVariant13 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant13))]
#endif
        public bool IsStrengthPositionVariant13 => StrengthPositionVariant13 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant13? value)
        {
            value = StrengthPositionVariant13;
            return IsStrengthPositionVariant13;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant13 PickStrengthPositionVariant13() => StrengthPositionVariant13 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant13' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant14? StrengthPositionVariant14 { get; init; }
#else
        public global::Terra.StrengthPositionVariant14? StrengthPositionVariant14 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant14))]
#endif
        public bool IsStrengthPositionVariant14 => StrengthPositionVariant14 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant14? value)
        {
            value = StrengthPositionVariant14;
            return IsStrengthPositionVariant14;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant14 PickStrengthPositionVariant14() => StrengthPositionVariant14 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant14' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant15? StrengthPositionVariant15 { get; init; }
#else
        public global::Terra.StrengthPositionVariant15? StrengthPositionVariant15 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant15))]
#endif
        public bool IsStrengthPositionVariant15 => StrengthPositionVariant15 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant15? value)
        {
            value = StrengthPositionVariant15;
            return IsStrengthPositionVariant15;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant15 PickStrengthPositionVariant15() => StrengthPositionVariant15 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant15' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant16? StrengthPositionVariant16 { get; init; }
#else
        public global::Terra.StrengthPositionVariant16? StrengthPositionVariant16 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant16))]
#endif
        public bool IsStrengthPositionVariant16 => StrengthPositionVariant16 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant16? value)
        {
            value = StrengthPositionVariant16;
            return IsStrengthPositionVariant16;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant16 PickStrengthPositionVariant16() => StrengthPositionVariant16 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant16' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant17? StrengthPositionVariant17 { get; init; }
#else
        public global::Terra.StrengthPositionVariant17? StrengthPositionVariant17 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant17))]
#endif
        public bool IsStrengthPositionVariant17 => StrengthPositionVariant17 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant17? value)
        {
            value = StrengthPositionVariant17;
            return IsStrengthPositionVariant17;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant17 PickStrengthPositionVariant17() => StrengthPositionVariant17 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant17' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant18? StrengthPositionVariant18 { get; init; }
#else
        public global::Terra.StrengthPositionVariant18? StrengthPositionVariant18 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant18))]
#endif
        public bool IsStrengthPositionVariant18 => StrengthPositionVariant18 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant18(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant18? value)
        {
            value = StrengthPositionVariant18;
            return IsStrengthPositionVariant18;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant18 PickStrengthPositionVariant18() => StrengthPositionVariant18 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant18' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthPositionVariant19? StrengthPositionVariant19 { get; init; }
#else
        public global::Terra.StrengthPositionVariant19? StrengthPositionVariant19 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant19))]
#endif
        public bool IsStrengthPositionVariant19 => StrengthPositionVariant19 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant19(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthPositionVariant19? value)
        {
            value = StrengthPositionVariant19;
            return IsStrengthPositionVariant19;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthPositionVariant19 PickStrengthPositionVariant19() => StrengthPositionVariant19 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant19' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthPositionVariant20 { get; init; }
#else
        public string? StrengthPositionVariant20 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthPositionVariant20))]
#endif
        public bool IsStrengthPositionVariant20 => StrengthPositionVariant20 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthPositionVariant20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthPositionVariant20;
            return IsStrengthPositionVariant20;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthPositionVariant20() => StrengthPositionVariant20 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthPositionVariant20' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant1 value) => new StrengthPosition((global::Terra.StrengthPositionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant1?(StrengthPosition @this) => @this.StrengthPositionVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant1? value)
        {
            StrengthPositionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant1(global::Terra.StrengthPositionVariant1? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant2 value) => new StrengthPosition((global::Terra.StrengthPositionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant2?(StrengthPosition @this) => @this.StrengthPositionVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant2? value)
        {
            StrengthPositionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant2(global::Terra.StrengthPositionVariant2? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant3 value) => new StrengthPosition((global::Terra.StrengthPositionVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant3?(StrengthPosition @this) => @this.StrengthPositionVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant3? value)
        {
            StrengthPositionVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant3(global::Terra.StrengthPositionVariant3? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant4 value) => new StrengthPosition((global::Terra.StrengthPositionVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant4?(StrengthPosition @this) => @this.StrengthPositionVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant4? value)
        {
            StrengthPositionVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant4(global::Terra.StrengthPositionVariant4? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant5 value) => new StrengthPosition((global::Terra.StrengthPositionVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant5?(StrengthPosition @this) => @this.StrengthPositionVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant5? value)
        {
            StrengthPositionVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant5(global::Terra.StrengthPositionVariant5? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant6 value) => new StrengthPosition((global::Terra.StrengthPositionVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant6?(StrengthPosition @this) => @this.StrengthPositionVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant6? value)
        {
            StrengthPositionVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant6(global::Terra.StrengthPositionVariant6? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant7 value) => new StrengthPosition((global::Terra.StrengthPositionVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant7?(StrengthPosition @this) => @this.StrengthPositionVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant7? value)
        {
            StrengthPositionVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant7(global::Terra.StrengthPositionVariant7? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant8 value) => new StrengthPosition((global::Terra.StrengthPositionVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant8?(StrengthPosition @this) => @this.StrengthPositionVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant8? value)
        {
            StrengthPositionVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant8(global::Terra.StrengthPositionVariant8? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant9 value) => new StrengthPosition((global::Terra.StrengthPositionVariant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant9?(StrengthPosition @this) => @this.StrengthPositionVariant9;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant9? value)
        {
            StrengthPositionVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant9(global::Terra.StrengthPositionVariant9? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant10 value) => new StrengthPosition((global::Terra.StrengthPositionVariant10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant10?(StrengthPosition @this) => @this.StrengthPositionVariant10;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant10? value)
        {
            StrengthPositionVariant10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant10(global::Terra.StrengthPositionVariant10? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant11 value) => new StrengthPosition((global::Terra.StrengthPositionVariant11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant11?(StrengthPosition @this) => @this.StrengthPositionVariant11;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant11? value)
        {
            StrengthPositionVariant11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant11(global::Terra.StrengthPositionVariant11? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant12 value) => new StrengthPosition((global::Terra.StrengthPositionVariant12?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant12?(StrengthPosition @this) => @this.StrengthPositionVariant12;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant12? value)
        {
            StrengthPositionVariant12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant12(global::Terra.StrengthPositionVariant12? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant13 value) => new StrengthPosition((global::Terra.StrengthPositionVariant13?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant13?(StrengthPosition @this) => @this.StrengthPositionVariant13;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant13? value)
        {
            StrengthPositionVariant13 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant13(global::Terra.StrengthPositionVariant13? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant14 value) => new StrengthPosition((global::Terra.StrengthPositionVariant14?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant14?(StrengthPosition @this) => @this.StrengthPositionVariant14;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant14? value)
        {
            StrengthPositionVariant14 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant14(global::Terra.StrengthPositionVariant14? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant15 value) => new StrengthPosition((global::Terra.StrengthPositionVariant15?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant15?(StrengthPosition @this) => @this.StrengthPositionVariant15;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant15? value)
        {
            StrengthPositionVariant15 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant15(global::Terra.StrengthPositionVariant15? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant16 value) => new StrengthPosition((global::Terra.StrengthPositionVariant16?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant16?(StrengthPosition @this) => @this.StrengthPositionVariant16;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant16? value)
        {
            StrengthPositionVariant16 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant16(global::Terra.StrengthPositionVariant16? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant17 value) => new StrengthPosition((global::Terra.StrengthPositionVariant17?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant17?(StrengthPosition @this) => @this.StrengthPositionVariant17;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant17? value)
        {
            StrengthPositionVariant17 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant17(global::Terra.StrengthPositionVariant17? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant18 value) => new StrengthPosition((global::Terra.StrengthPositionVariant18?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant18?(StrengthPosition @this) => @this.StrengthPositionVariant18;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant18? value)
        {
            StrengthPositionVariant18 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant18(global::Terra.StrengthPositionVariant18? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(global::Terra.StrengthPositionVariant19 value) => new StrengthPosition((global::Terra.StrengthPositionVariant19?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthPositionVariant19?(StrengthPosition @this) => @this.StrengthPositionVariant19;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(global::Terra.StrengthPositionVariant19? value)
        {
            StrengthPositionVariant19 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant19(global::Terra.StrengthPositionVariant19? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthPosition(string value) => new StrengthPosition((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthPosition @this) => @this.StrengthPositionVariant20;

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(string? value)
        {
            StrengthPositionVariant20 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthPosition FromStrengthPositionVariant20(string? value) => new StrengthPosition(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthPosition(
            global::Terra.StrengthPositionVariant1? strengthPositionVariant1,
            global::Terra.StrengthPositionVariant2? strengthPositionVariant2,
            global::Terra.StrengthPositionVariant3? strengthPositionVariant3,
            global::Terra.StrengthPositionVariant4? strengthPositionVariant4,
            global::Terra.StrengthPositionVariant5? strengthPositionVariant5,
            global::Terra.StrengthPositionVariant6? strengthPositionVariant6,
            global::Terra.StrengthPositionVariant7? strengthPositionVariant7,
            global::Terra.StrengthPositionVariant8? strengthPositionVariant8,
            global::Terra.StrengthPositionVariant9? strengthPositionVariant9,
            global::Terra.StrengthPositionVariant10? strengthPositionVariant10,
            global::Terra.StrengthPositionVariant11? strengthPositionVariant11,
            global::Terra.StrengthPositionVariant12? strengthPositionVariant12,
            global::Terra.StrengthPositionVariant13? strengthPositionVariant13,
            global::Terra.StrengthPositionVariant14? strengthPositionVariant14,
            global::Terra.StrengthPositionVariant15? strengthPositionVariant15,
            global::Terra.StrengthPositionVariant16? strengthPositionVariant16,
            global::Terra.StrengthPositionVariant17? strengthPositionVariant17,
            global::Terra.StrengthPositionVariant18? strengthPositionVariant18,
            global::Terra.StrengthPositionVariant19? strengthPositionVariant19,
            string? strengthPositionVariant20
            )
        {
            StrengthPositionVariant1 = strengthPositionVariant1;
            StrengthPositionVariant2 = strengthPositionVariant2;
            StrengthPositionVariant3 = strengthPositionVariant3;
            StrengthPositionVariant4 = strengthPositionVariant4;
            StrengthPositionVariant5 = strengthPositionVariant5;
            StrengthPositionVariant6 = strengthPositionVariant6;
            StrengthPositionVariant7 = strengthPositionVariant7;
            StrengthPositionVariant8 = strengthPositionVariant8;
            StrengthPositionVariant9 = strengthPositionVariant9;
            StrengthPositionVariant10 = strengthPositionVariant10;
            StrengthPositionVariant11 = strengthPositionVariant11;
            StrengthPositionVariant12 = strengthPositionVariant12;
            StrengthPositionVariant13 = strengthPositionVariant13;
            StrengthPositionVariant14 = strengthPositionVariant14;
            StrengthPositionVariant15 = strengthPositionVariant15;
            StrengthPositionVariant16 = strengthPositionVariant16;
            StrengthPositionVariant17 = strengthPositionVariant17;
            StrengthPositionVariant18 = strengthPositionVariant18;
            StrengthPositionVariant19 = strengthPositionVariant19;
            StrengthPositionVariant20 = strengthPositionVariant20;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthPositionVariant20 as object ??
            StrengthPositionVariant19 as object ??
            StrengthPositionVariant18 as object ??
            StrengthPositionVariant17 as object ??
            StrengthPositionVariant16 as object ??
            StrengthPositionVariant15 as object ??
            StrengthPositionVariant14 as object ??
            StrengthPositionVariant13 as object ??
            StrengthPositionVariant12 as object ??
            StrengthPositionVariant11 as object ??
            StrengthPositionVariant10 as object ??
            StrengthPositionVariant9 as object ??
            StrengthPositionVariant8 as object ??
            StrengthPositionVariant7 as object ??
            StrengthPositionVariant6 as object ??
            StrengthPositionVariant5 as object ??
            StrengthPositionVariant4 as object ??
            StrengthPositionVariant3 as object ??
            StrengthPositionVariant2 as object ??
            StrengthPositionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthPositionVariant1?.ToValueString() ??
            StrengthPositionVariant2?.ToValueString() ??
            StrengthPositionVariant3?.ToValueString() ??
            StrengthPositionVariant4?.ToValueString() ??
            StrengthPositionVariant5?.ToValueString() ??
            StrengthPositionVariant6?.ToValueString() ??
            StrengthPositionVariant7?.ToValueString() ??
            StrengthPositionVariant8?.ToValueString() ??
            StrengthPositionVariant9?.ToValueString() ??
            StrengthPositionVariant10?.ToValueString() ??
            StrengthPositionVariant11?.ToValueString() ??
            StrengthPositionVariant12?.ToValueString() ??
            StrengthPositionVariant13?.ToValueString() ??
            StrengthPositionVariant14?.ToValueString() ??
            StrengthPositionVariant15?.ToValueString() ??
            StrengthPositionVariant16?.ToValueString() ??
            StrengthPositionVariant17?.ToValueString() ??
            StrengthPositionVariant18?.ToValueString() ??
            StrengthPositionVariant19?.ToValueString() ??
            StrengthPositionVariant20?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthPositionVariant1 || IsStrengthPositionVariant2 || IsStrengthPositionVariant3 || IsStrengthPositionVariant4 || IsStrengthPositionVariant5 || IsStrengthPositionVariant6 || IsStrengthPositionVariant7 || IsStrengthPositionVariant8 || IsStrengthPositionVariant9 || IsStrengthPositionVariant10 || IsStrengthPositionVariant11 || IsStrengthPositionVariant12 || IsStrengthPositionVariant13 || IsStrengthPositionVariant14 || IsStrengthPositionVariant15 || IsStrengthPositionVariant16 || IsStrengthPositionVariant17 || IsStrengthPositionVariant18 || IsStrengthPositionVariant19 || IsStrengthPositionVariant20;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthPositionVariant1?, TResult>? strengthPositionVariant1 = null,
            global::System.Func<global::Terra.StrengthPositionVariant2?, TResult>? strengthPositionVariant2 = null,
            global::System.Func<global::Terra.StrengthPositionVariant3?, TResult>? strengthPositionVariant3 = null,
            global::System.Func<global::Terra.StrengthPositionVariant4?, TResult>? strengthPositionVariant4 = null,
            global::System.Func<global::Terra.StrengthPositionVariant5?, TResult>? strengthPositionVariant5 = null,
            global::System.Func<global::Terra.StrengthPositionVariant6?, TResult>? strengthPositionVariant6 = null,
            global::System.Func<global::Terra.StrengthPositionVariant7?, TResult>? strengthPositionVariant7 = null,
            global::System.Func<global::Terra.StrengthPositionVariant8?, TResult>? strengthPositionVariant8 = null,
            global::System.Func<global::Terra.StrengthPositionVariant9?, TResult>? strengthPositionVariant9 = null,
            global::System.Func<global::Terra.StrengthPositionVariant10?, TResult>? strengthPositionVariant10 = null,
            global::System.Func<global::Terra.StrengthPositionVariant11?, TResult>? strengthPositionVariant11 = null,
            global::System.Func<global::Terra.StrengthPositionVariant12?, TResult>? strengthPositionVariant12 = null,
            global::System.Func<global::Terra.StrengthPositionVariant13?, TResult>? strengthPositionVariant13 = null,
            global::System.Func<global::Terra.StrengthPositionVariant14?, TResult>? strengthPositionVariant14 = null,
            global::System.Func<global::Terra.StrengthPositionVariant15?, TResult>? strengthPositionVariant15 = null,
            global::System.Func<global::Terra.StrengthPositionVariant16?, TResult>? strengthPositionVariant16 = null,
            global::System.Func<global::Terra.StrengthPositionVariant17?, TResult>? strengthPositionVariant17 = null,
            global::System.Func<global::Terra.StrengthPositionVariant18?, TResult>? strengthPositionVariant18 = null,
            global::System.Func<global::Terra.StrengthPositionVariant19?, TResult>? strengthPositionVariant19 = null,
            global::System.Func<string, TResult>? strengthPositionVariant20 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StrengthPositionVariant1 is { } __value0 && strengthPositionVariant1 != null)
            {
                return strengthPositionVariant1(__value0);
            }
            else if (StrengthPositionVariant2 is { } __value1 && strengthPositionVariant2 != null)
            {
                return strengthPositionVariant2(__value1);
            }
            else if (StrengthPositionVariant3 is { } __value2 && strengthPositionVariant3 != null)
            {
                return strengthPositionVariant3(__value2);
            }
            else if (StrengthPositionVariant4 is { } __value3 && strengthPositionVariant4 != null)
            {
                return strengthPositionVariant4(__value3);
            }
            else if (StrengthPositionVariant5 is { } __value4 && strengthPositionVariant5 != null)
            {
                return strengthPositionVariant5(__value4);
            }
            else if (StrengthPositionVariant6 is { } __value5 && strengthPositionVariant6 != null)
            {
                return strengthPositionVariant6(__value5);
            }
            else if (StrengthPositionVariant7 is { } __value6 && strengthPositionVariant7 != null)
            {
                return strengthPositionVariant7(__value6);
            }
            else if (StrengthPositionVariant8 is { } __value7 && strengthPositionVariant8 != null)
            {
                return strengthPositionVariant8(__value7);
            }
            else if (StrengthPositionVariant9 is { } __value8 && strengthPositionVariant9 != null)
            {
                return strengthPositionVariant9(__value8);
            }
            else if (StrengthPositionVariant10 is { } __value9 && strengthPositionVariant10 != null)
            {
                return strengthPositionVariant10(__value9);
            }
            else if (StrengthPositionVariant11 is { } __value10 && strengthPositionVariant11 != null)
            {
                return strengthPositionVariant11(__value10);
            }
            else if (StrengthPositionVariant12 is { } __value11 && strengthPositionVariant12 != null)
            {
                return strengthPositionVariant12(__value11);
            }
            else if (StrengthPositionVariant13 is { } __value12 && strengthPositionVariant13 != null)
            {
                return strengthPositionVariant13(__value12);
            }
            else if (StrengthPositionVariant14 is { } __value13 && strengthPositionVariant14 != null)
            {
                return strengthPositionVariant14(__value13);
            }
            else if (StrengthPositionVariant15 is { } __value14 && strengthPositionVariant15 != null)
            {
                return strengthPositionVariant15(__value14);
            }
            else if (StrengthPositionVariant16 is { } __value15 && strengthPositionVariant16 != null)
            {
                return strengthPositionVariant16(__value15);
            }
            else if (StrengthPositionVariant17 is { } __value16 && strengthPositionVariant17 != null)
            {
                return strengthPositionVariant17(__value16);
            }
            else if (StrengthPositionVariant18 is { } __value17 && strengthPositionVariant18 != null)
            {
                return strengthPositionVariant18(__value17);
            }
            else if (StrengthPositionVariant19 is { } __value18 && strengthPositionVariant19 != null)
            {
                return strengthPositionVariant19(__value18);
            }
            else if (StrengthPositionVariant20 is { } __value19 && strengthPositionVariant20 != null)
            {
                return strengthPositionVariant20(__value19);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthPositionVariant1?>? strengthPositionVariant1 = null,

            global::System.Action<global::Terra.StrengthPositionVariant2?>? strengthPositionVariant2 = null,

            global::System.Action<global::Terra.StrengthPositionVariant3?>? strengthPositionVariant3 = null,

            global::System.Action<global::Terra.StrengthPositionVariant4?>? strengthPositionVariant4 = null,

            global::System.Action<global::Terra.StrengthPositionVariant5?>? strengthPositionVariant5 = null,

            global::System.Action<global::Terra.StrengthPositionVariant6?>? strengthPositionVariant6 = null,

            global::System.Action<global::Terra.StrengthPositionVariant7?>? strengthPositionVariant7 = null,

            global::System.Action<global::Terra.StrengthPositionVariant8?>? strengthPositionVariant8 = null,

            global::System.Action<global::Terra.StrengthPositionVariant9?>? strengthPositionVariant9 = null,

            global::System.Action<global::Terra.StrengthPositionVariant10?>? strengthPositionVariant10 = null,

            global::System.Action<global::Terra.StrengthPositionVariant11?>? strengthPositionVariant11 = null,

            global::System.Action<global::Terra.StrengthPositionVariant12?>? strengthPositionVariant12 = null,

            global::System.Action<global::Terra.StrengthPositionVariant13?>? strengthPositionVariant13 = null,

            global::System.Action<global::Terra.StrengthPositionVariant14?>? strengthPositionVariant14 = null,

            global::System.Action<global::Terra.StrengthPositionVariant15?>? strengthPositionVariant15 = null,

            global::System.Action<global::Terra.StrengthPositionVariant16?>? strengthPositionVariant16 = null,

            global::System.Action<global::Terra.StrengthPositionVariant17?>? strengthPositionVariant17 = null,

            global::System.Action<global::Terra.StrengthPositionVariant18?>? strengthPositionVariant18 = null,

            global::System.Action<global::Terra.StrengthPositionVariant19?>? strengthPositionVariant19 = null,

            global::System.Action<string>? strengthPositionVariant20 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StrengthPositionVariant1 is { } __value0)
            {
                strengthPositionVariant1?.Invoke(__value0);
            }
            else if (StrengthPositionVariant2 is { } __value1)
            {
                strengthPositionVariant2?.Invoke(__value1);
            }
            else if (StrengthPositionVariant3 is { } __value2)
            {
                strengthPositionVariant3?.Invoke(__value2);
            }
            else if (StrengthPositionVariant4 is { } __value3)
            {
                strengthPositionVariant4?.Invoke(__value3);
            }
            else if (StrengthPositionVariant5 is { } __value4)
            {
                strengthPositionVariant5?.Invoke(__value4);
            }
            else if (StrengthPositionVariant6 is { } __value5)
            {
                strengthPositionVariant6?.Invoke(__value5);
            }
            else if (StrengthPositionVariant7 is { } __value6)
            {
                strengthPositionVariant7?.Invoke(__value6);
            }
            else if (StrengthPositionVariant8 is { } __value7)
            {
                strengthPositionVariant8?.Invoke(__value7);
            }
            else if (StrengthPositionVariant9 is { } __value8)
            {
                strengthPositionVariant9?.Invoke(__value8);
            }
            else if (StrengthPositionVariant10 is { } __value9)
            {
                strengthPositionVariant10?.Invoke(__value9);
            }
            else if (StrengthPositionVariant11 is { } __value10)
            {
                strengthPositionVariant11?.Invoke(__value10);
            }
            else if (StrengthPositionVariant12 is { } __value11)
            {
                strengthPositionVariant12?.Invoke(__value11);
            }
            else if (StrengthPositionVariant13 is { } __value12)
            {
                strengthPositionVariant13?.Invoke(__value12);
            }
            else if (StrengthPositionVariant14 is { } __value13)
            {
                strengthPositionVariant14?.Invoke(__value13);
            }
            else if (StrengthPositionVariant15 is { } __value14)
            {
                strengthPositionVariant15?.Invoke(__value14);
            }
            else if (StrengthPositionVariant16 is { } __value15)
            {
                strengthPositionVariant16?.Invoke(__value15);
            }
            else if (StrengthPositionVariant17 is { } __value16)
            {
                strengthPositionVariant17?.Invoke(__value16);
            }
            else if (StrengthPositionVariant18 is { } __value17)
            {
                strengthPositionVariant18?.Invoke(__value17);
            }
            else if (StrengthPositionVariant19 is { } __value18)
            {
                strengthPositionVariant19?.Invoke(__value18);
            }
            else if (StrengthPositionVariant20 is { } __value19)
            {
                strengthPositionVariant20?.Invoke(__value19);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthPositionVariant1?>? strengthPositionVariant1 = null,
            global::System.Action<global::Terra.StrengthPositionVariant2?>? strengthPositionVariant2 = null,
            global::System.Action<global::Terra.StrengthPositionVariant3?>? strengthPositionVariant3 = null,
            global::System.Action<global::Terra.StrengthPositionVariant4?>? strengthPositionVariant4 = null,
            global::System.Action<global::Terra.StrengthPositionVariant5?>? strengthPositionVariant5 = null,
            global::System.Action<global::Terra.StrengthPositionVariant6?>? strengthPositionVariant6 = null,
            global::System.Action<global::Terra.StrengthPositionVariant7?>? strengthPositionVariant7 = null,
            global::System.Action<global::Terra.StrengthPositionVariant8?>? strengthPositionVariant8 = null,
            global::System.Action<global::Terra.StrengthPositionVariant9?>? strengthPositionVariant9 = null,
            global::System.Action<global::Terra.StrengthPositionVariant10?>? strengthPositionVariant10 = null,
            global::System.Action<global::Terra.StrengthPositionVariant11?>? strengthPositionVariant11 = null,
            global::System.Action<global::Terra.StrengthPositionVariant12?>? strengthPositionVariant12 = null,
            global::System.Action<global::Terra.StrengthPositionVariant13?>? strengthPositionVariant13 = null,
            global::System.Action<global::Terra.StrengthPositionVariant14?>? strengthPositionVariant14 = null,
            global::System.Action<global::Terra.StrengthPositionVariant15?>? strengthPositionVariant15 = null,
            global::System.Action<global::Terra.StrengthPositionVariant16?>? strengthPositionVariant16 = null,
            global::System.Action<global::Terra.StrengthPositionVariant17?>? strengthPositionVariant17 = null,
            global::System.Action<global::Terra.StrengthPositionVariant18?>? strengthPositionVariant18 = null,
            global::System.Action<global::Terra.StrengthPositionVariant19?>? strengthPositionVariant19 = null,
            global::System.Action<string>? strengthPositionVariant20 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StrengthPositionVariant1 is { } __value0)
            {
                strengthPositionVariant1?.Invoke(__value0);
            }
            else if (StrengthPositionVariant2 is { } __value1)
            {
                strengthPositionVariant2?.Invoke(__value1);
            }
            else if (StrengthPositionVariant3 is { } __value2)
            {
                strengthPositionVariant3?.Invoke(__value2);
            }
            else if (StrengthPositionVariant4 is { } __value3)
            {
                strengthPositionVariant4?.Invoke(__value3);
            }
            else if (StrengthPositionVariant5 is { } __value4)
            {
                strengthPositionVariant5?.Invoke(__value4);
            }
            else if (StrengthPositionVariant6 is { } __value5)
            {
                strengthPositionVariant6?.Invoke(__value5);
            }
            else if (StrengthPositionVariant7 is { } __value6)
            {
                strengthPositionVariant7?.Invoke(__value6);
            }
            else if (StrengthPositionVariant8 is { } __value7)
            {
                strengthPositionVariant8?.Invoke(__value7);
            }
            else if (StrengthPositionVariant9 is { } __value8)
            {
                strengthPositionVariant9?.Invoke(__value8);
            }
            else if (StrengthPositionVariant10 is { } __value9)
            {
                strengthPositionVariant10?.Invoke(__value9);
            }
            else if (StrengthPositionVariant11 is { } __value10)
            {
                strengthPositionVariant11?.Invoke(__value10);
            }
            else if (StrengthPositionVariant12 is { } __value11)
            {
                strengthPositionVariant12?.Invoke(__value11);
            }
            else if (StrengthPositionVariant13 is { } __value12)
            {
                strengthPositionVariant13?.Invoke(__value12);
            }
            else if (StrengthPositionVariant14 is { } __value13)
            {
                strengthPositionVariant14?.Invoke(__value13);
            }
            else if (StrengthPositionVariant15 is { } __value14)
            {
                strengthPositionVariant15?.Invoke(__value14);
            }
            else if (StrengthPositionVariant16 is { } __value15)
            {
                strengthPositionVariant16?.Invoke(__value15);
            }
            else if (StrengthPositionVariant17 is { } __value16)
            {
                strengthPositionVariant17?.Invoke(__value16);
            }
            else if (StrengthPositionVariant18 is { } __value17)
            {
                strengthPositionVariant18?.Invoke(__value17);
            }
            else if (StrengthPositionVariant19 is { } __value18)
            {
                strengthPositionVariant19?.Invoke(__value18);
            }
            else if (StrengthPositionVariant20 is { } __value19)
            {
                strengthPositionVariant20?.Invoke(__value19);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthPositionVariant1,
                typeof(global::Terra.StrengthPositionVariant1),
                StrengthPositionVariant2,
                typeof(global::Terra.StrengthPositionVariant2),
                StrengthPositionVariant3,
                typeof(global::Terra.StrengthPositionVariant3),
                StrengthPositionVariant4,
                typeof(global::Terra.StrengthPositionVariant4),
                StrengthPositionVariant5,
                typeof(global::Terra.StrengthPositionVariant5),
                StrengthPositionVariant6,
                typeof(global::Terra.StrengthPositionVariant6),
                StrengthPositionVariant7,
                typeof(global::Terra.StrengthPositionVariant7),
                StrengthPositionVariant8,
                typeof(global::Terra.StrengthPositionVariant8),
                StrengthPositionVariant9,
                typeof(global::Terra.StrengthPositionVariant9),
                StrengthPositionVariant10,
                typeof(global::Terra.StrengthPositionVariant10),
                StrengthPositionVariant11,
                typeof(global::Terra.StrengthPositionVariant11),
                StrengthPositionVariant12,
                typeof(global::Terra.StrengthPositionVariant12),
                StrengthPositionVariant13,
                typeof(global::Terra.StrengthPositionVariant13),
                StrengthPositionVariant14,
                typeof(global::Terra.StrengthPositionVariant14),
                StrengthPositionVariant15,
                typeof(global::Terra.StrengthPositionVariant15),
                StrengthPositionVariant16,
                typeof(global::Terra.StrengthPositionVariant16),
                StrengthPositionVariant17,
                typeof(global::Terra.StrengthPositionVariant17),
                StrengthPositionVariant18,
                typeof(global::Terra.StrengthPositionVariant18),
                StrengthPositionVariant19,
                typeof(global::Terra.StrengthPositionVariant19),
                StrengthPositionVariant20,
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
        public bool Equals(StrengthPosition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant1?>.Default.Equals(StrengthPositionVariant1, other.StrengthPositionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant2?>.Default.Equals(StrengthPositionVariant2, other.StrengthPositionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant3?>.Default.Equals(StrengthPositionVariant3, other.StrengthPositionVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant4?>.Default.Equals(StrengthPositionVariant4, other.StrengthPositionVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant5?>.Default.Equals(StrengthPositionVariant5, other.StrengthPositionVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant6?>.Default.Equals(StrengthPositionVariant6, other.StrengthPositionVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant7?>.Default.Equals(StrengthPositionVariant7, other.StrengthPositionVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant8?>.Default.Equals(StrengthPositionVariant8, other.StrengthPositionVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant9?>.Default.Equals(StrengthPositionVariant9, other.StrengthPositionVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant10?>.Default.Equals(StrengthPositionVariant10, other.StrengthPositionVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant11?>.Default.Equals(StrengthPositionVariant11, other.StrengthPositionVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant12?>.Default.Equals(StrengthPositionVariant12, other.StrengthPositionVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant13?>.Default.Equals(StrengthPositionVariant13, other.StrengthPositionVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant14?>.Default.Equals(StrengthPositionVariant14, other.StrengthPositionVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant15?>.Default.Equals(StrengthPositionVariant15, other.StrengthPositionVariant15) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant16?>.Default.Equals(StrengthPositionVariant16, other.StrengthPositionVariant16) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant17?>.Default.Equals(StrengthPositionVariant17, other.StrengthPositionVariant17) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant18?>.Default.Equals(StrengthPositionVariant18, other.StrengthPositionVariant18) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthPositionVariant19?>.Default.Equals(StrengthPositionVariant19, other.StrengthPositionVariant19) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthPositionVariant20, other.StrengthPositionVariant20)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthPosition obj1, StrengthPosition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthPosition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthPosition obj1, StrengthPosition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthPosition o && Equals(o);
        }
    }
}

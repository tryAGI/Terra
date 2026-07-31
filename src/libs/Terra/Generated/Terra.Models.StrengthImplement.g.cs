#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// What provides the load. Open enum — handle unknown values gracefully.<br/>
    /// Example: band
    /// </summary>
    public readonly partial struct StrengthImplement : global::System.IEquatable<StrengthImplement>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant1? StrengthImplementVariant1 { get; init; }
#else
        public global::Terra.StrengthImplementVariant1? StrengthImplementVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant1))]
#endif
        public bool IsStrengthImplementVariant1 => StrengthImplementVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant1? value)
        {
            value = StrengthImplementVariant1;
            return IsStrengthImplementVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant1 PickStrengthImplementVariant1() => IsStrengthImplementVariant1
            ? StrengthImplementVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant2? StrengthImplementVariant2 { get; init; }
#else
        public global::Terra.StrengthImplementVariant2? StrengthImplementVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant2))]
#endif
        public bool IsStrengthImplementVariant2 => StrengthImplementVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant2? value)
        {
            value = StrengthImplementVariant2;
            return IsStrengthImplementVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant2 PickStrengthImplementVariant2() => IsStrengthImplementVariant2
            ? StrengthImplementVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant3? StrengthImplementVariant3 { get; init; }
#else
        public global::Terra.StrengthImplementVariant3? StrengthImplementVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant3))]
#endif
        public bool IsStrengthImplementVariant3 => StrengthImplementVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant3? value)
        {
            value = StrengthImplementVariant3;
            return IsStrengthImplementVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant3 PickStrengthImplementVariant3() => IsStrengthImplementVariant3
            ? StrengthImplementVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant4? StrengthImplementVariant4 { get; init; }
#else
        public global::Terra.StrengthImplementVariant4? StrengthImplementVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant4))]
#endif
        public bool IsStrengthImplementVariant4 => StrengthImplementVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant4? value)
        {
            value = StrengthImplementVariant4;
            return IsStrengthImplementVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant4 PickStrengthImplementVariant4() => IsStrengthImplementVariant4
            ? StrengthImplementVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant5? StrengthImplementVariant5 { get; init; }
#else
        public global::Terra.StrengthImplementVariant5? StrengthImplementVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant5))]
#endif
        public bool IsStrengthImplementVariant5 => StrengthImplementVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant5? value)
        {
            value = StrengthImplementVariant5;
            return IsStrengthImplementVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant5 PickStrengthImplementVariant5() => IsStrengthImplementVariant5
            ? StrengthImplementVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant6? StrengthImplementVariant6 { get; init; }
#else
        public global::Terra.StrengthImplementVariant6? StrengthImplementVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant6))]
#endif
        public bool IsStrengthImplementVariant6 => StrengthImplementVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant6? value)
        {
            value = StrengthImplementVariant6;
            return IsStrengthImplementVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant6 PickStrengthImplementVariant6() => IsStrengthImplementVariant6
            ? StrengthImplementVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant6' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant7? StrengthImplementVariant7 { get; init; }
#else
        public global::Terra.StrengthImplementVariant7? StrengthImplementVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant7))]
#endif
        public bool IsStrengthImplementVariant7 => StrengthImplementVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant7? value)
        {
            value = StrengthImplementVariant7;
            return IsStrengthImplementVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant7 PickStrengthImplementVariant7() => IsStrengthImplementVariant7
            ? StrengthImplementVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant7' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant8? StrengthImplementVariant8 { get; init; }
#else
        public global::Terra.StrengthImplementVariant8? StrengthImplementVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant8))]
#endif
        public bool IsStrengthImplementVariant8 => StrengthImplementVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant8? value)
        {
            value = StrengthImplementVariant8;
            return IsStrengthImplementVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant8 PickStrengthImplementVariant8() => IsStrengthImplementVariant8
            ? StrengthImplementVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant8' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant9? StrengthImplementVariant9 { get; init; }
#else
        public global::Terra.StrengthImplementVariant9? StrengthImplementVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant9))]
#endif
        public bool IsStrengthImplementVariant9 => StrengthImplementVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant9? value)
        {
            value = StrengthImplementVariant9;
            return IsStrengthImplementVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant9 PickStrengthImplementVariant9() => IsStrengthImplementVariant9
            ? StrengthImplementVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant9' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant10? StrengthImplementVariant10 { get; init; }
#else
        public global::Terra.StrengthImplementVariant10? StrengthImplementVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant10))]
#endif
        public bool IsStrengthImplementVariant10 => StrengthImplementVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant10? value)
        {
            value = StrengthImplementVariant10;
            return IsStrengthImplementVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant10 PickStrengthImplementVariant10() => IsStrengthImplementVariant10
            ? StrengthImplementVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant10' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant11? StrengthImplementVariant11 { get; init; }
#else
        public global::Terra.StrengthImplementVariant11? StrengthImplementVariant11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant11))]
#endif
        public bool IsStrengthImplementVariant11 => StrengthImplementVariant11 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant11? value)
        {
            value = StrengthImplementVariant11;
            return IsStrengthImplementVariant11;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant11 PickStrengthImplementVariant11() => IsStrengthImplementVariant11
            ? StrengthImplementVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant11' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant12? StrengthImplementVariant12 { get; init; }
#else
        public global::Terra.StrengthImplementVariant12? StrengthImplementVariant12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant12))]
#endif
        public bool IsStrengthImplementVariant12 => StrengthImplementVariant12 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant12? value)
        {
            value = StrengthImplementVariant12;
            return IsStrengthImplementVariant12;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant12 PickStrengthImplementVariant12() => IsStrengthImplementVariant12
            ? StrengthImplementVariant12!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant12' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant13? StrengthImplementVariant13 { get; init; }
#else
        public global::Terra.StrengthImplementVariant13? StrengthImplementVariant13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant13))]
#endif
        public bool IsStrengthImplementVariant13 => StrengthImplementVariant13 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant13? value)
        {
            value = StrengthImplementVariant13;
            return IsStrengthImplementVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant13 PickStrengthImplementVariant13() => IsStrengthImplementVariant13
            ? StrengthImplementVariant13!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant13' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant14? StrengthImplementVariant14 { get; init; }
#else
        public global::Terra.StrengthImplementVariant14? StrengthImplementVariant14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant14))]
#endif
        public bool IsStrengthImplementVariant14 => StrengthImplementVariant14 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant14? value)
        {
            value = StrengthImplementVariant14;
            return IsStrengthImplementVariant14;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant14 PickStrengthImplementVariant14() => IsStrengthImplementVariant14
            ? StrengthImplementVariant14!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant14' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant15? StrengthImplementVariant15 { get; init; }
#else
        public global::Terra.StrengthImplementVariant15? StrengthImplementVariant15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant15))]
#endif
        public bool IsStrengthImplementVariant15 => StrengthImplementVariant15 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant15? value)
        {
            value = StrengthImplementVariant15;
            return IsStrengthImplementVariant15;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant15 PickStrengthImplementVariant15() => IsStrengthImplementVariant15
            ? StrengthImplementVariant15!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant15' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant16? StrengthImplementVariant16 { get; init; }
#else
        public global::Terra.StrengthImplementVariant16? StrengthImplementVariant16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant16))]
#endif
        public bool IsStrengthImplementVariant16 => StrengthImplementVariant16 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant16? value)
        {
            value = StrengthImplementVariant16;
            return IsStrengthImplementVariant16;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant16 PickStrengthImplementVariant16() => IsStrengthImplementVariant16
            ? StrengthImplementVariant16!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant16' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant17? StrengthImplementVariant17 { get; init; }
#else
        public global::Terra.StrengthImplementVariant17? StrengthImplementVariant17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant17))]
#endif
        public bool IsStrengthImplementVariant17 => StrengthImplementVariant17 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant17? value)
        {
            value = StrengthImplementVariant17;
            return IsStrengthImplementVariant17;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant17 PickStrengthImplementVariant17() => IsStrengthImplementVariant17
            ? StrengthImplementVariant17!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant17' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant18? StrengthImplementVariant18 { get; init; }
#else
        public global::Terra.StrengthImplementVariant18? StrengthImplementVariant18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant18))]
#endif
        public bool IsStrengthImplementVariant18 => StrengthImplementVariant18 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant18(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant18? value)
        {
            value = StrengthImplementVariant18;
            return IsStrengthImplementVariant18;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant18 PickStrengthImplementVariant18() => IsStrengthImplementVariant18
            ? StrengthImplementVariant18!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant18' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant19? StrengthImplementVariant19 { get; init; }
#else
        public global::Terra.StrengthImplementVariant19? StrengthImplementVariant19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant19))]
#endif
        public bool IsStrengthImplementVariant19 => StrengthImplementVariant19 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant19(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant19? value)
        {
            value = StrengthImplementVariant19;
            return IsStrengthImplementVariant19;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant19 PickStrengthImplementVariant19() => IsStrengthImplementVariant19
            ? StrengthImplementVariant19!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant19' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant20? StrengthImplementVariant20 { get; init; }
#else
        public global::Terra.StrengthImplementVariant20? StrengthImplementVariant20 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant20))]
#endif
        public bool IsStrengthImplementVariant20 => StrengthImplementVariant20 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant20? value)
        {
            value = StrengthImplementVariant20;
            return IsStrengthImplementVariant20;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant20 PickStrengthImplementVariant20() => IsStrengthImplementVariant20
            ? StrengthImplementVariant20!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant20' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant21? StrengthImplementVariant21 { get; init; }
#else
        public global::Terra.StrengthImplementVariant21? StrengthImplementVariant21 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant21))]
#endif
        public bool IsStrengthImplementVariant21 => StrengthImplementVariant21 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant21(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant21? value)
        {
            value = StrengthImplementVariant21;
            return IsStrengthImplementVariant21;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant21 PickStrengthImplementVariant21() => IsStrengthImplementVariant21
            ? StrengthImplementVariant21!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant21' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant22? StrengthImplementVariant22 { get; init; }
#else
        public global::Terra.StrengthImplementVariant22? StrengthImplementVariant22 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant22))]
#endif
        public bool IsStrengthImplementVariant22 => StrengthImplementVariant22 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant22(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant22? value)
        {
            value = StrengthImplementVariant22;
            return IsStrengthImplementVariant22;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant22 PickStrengthImplementVariant22() => IsStrengthImplementVariant22
            ? StrengthImplementVariant22!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant22' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant23? StrengthImplementVariant23 { get; init; }
#else
        public global::Terra.StrengthImplementVariant23? StrengthImplementVariant23 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant23))]
#endif
        public bool IsStrengthImplementVariant23 => StrengthImplementVariant23 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant23(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant23? value)
        {
            value = StrengthImplementVariant23;
            return IsStrengthImplementVariant23;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant23 PickStrengthImplementVariant23() => IsStrengthImplementVariant23
            ? StrengthImplementVariant23!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant23' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant24? StrengthImplementVariant24 { get; init; }
#else
        public global::Terra.StrengthImplementVariant24? StrengthImplementVariant24 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant24))]
#endif
        public bool IsStrengthImplementVariant24 => StrengthImplementVariant24 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant24(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant24? value)
        {
            value = StrengthImplementVariant24;
            return IsStrengthImplementVariant24;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant24 PickStrengthImplementVariant24() => IsStrengthImplementVariant24
            ? StrengthImplementVariant24!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant24' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthImplementVariant25? StrengthImplementVariant25 { get; init; }
#else
        public global::Terra.StrengthImplementVariant25? StrengthImplementVariant25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant25))]
#endif
        public bool IsStrengthImplementVariant25 => StrengthImplementVariant25 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthImplementVariant25? value)
        {
            value = StrengthImplementVariant25;
            return IsStrengthImplementVariant25;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthImplementVariant25 PickStrengthImplementVariant25() => IsStrengthImplementVariant25
            ? StrengthImplementVariant25!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant25' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthImplementVariant26 { get; init; }
#else
        public string? StrengthImplementVariant26 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthImplementVariant26))]
#endif
        public bool IsStrengthImplementVariant26 => StrengthImplementVariant26 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthImplementVariant26(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthImplementVariant26;
            return IsStrengthImplementVariant26;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickStrengthImplementVariant26() => IsStrengthImplementVariant26
            ? StrengthImplementVariant26!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthImplementVariant26' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant1 value) => new StrengthImplement((global::Terra.StrengthImplementVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant1?(StrengthImplement @this) => @this.StrengthImplementVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant1? value)
        {
            StrengthImplementVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant1(global::Terra.StrengthImplementVariant1? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant2 value) => new StrengthImplement((global::Terra.StrengthImplementVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant2?(StrengthImplement @this) => @this.StrengthImplementVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant2? value)
        {
            StrengthImplementVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant2(global::Terra.StrengthImplementVariant2? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant3 value) => new StrengthImplement((global::Terra.StrengthImplementVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant3?(StrengthImplement @this) => @this.StrengthImplementVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant3? value)
        {
            StrengthImplementVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant3(global::Terra.StrengthImplementVariant3? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant4 value) => new StrengthImplement((global::Terra.StrengthImplementVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant4?(StrengthImplement @this) => @this.StrengthImplementVariant4;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant4? value)
        {
            StrengthImplementVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant4(global::Terra.StrengthImplementVariant4? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant5 value) => new StrengthImplement((global::Terra.StrengthImplementVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant5?(StrengthImplement @this) => @this.StrengthImplementVariant5;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant5? value)
        {
            StrengthImplementVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant5(global::Terra.StrengthImplementVariant5? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant6 value) => new StrengthImplement((global::Terra.StrengthImplementVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant6?(StrengthImplement @this) => @this.StrengthImplementVariant6;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant6? value)
        {
            StrengthImplementVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant6(global::Terra.StrengthImplementVariant6? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant7 value) => new StrengthImplement((global::Terra.StrengthImplementVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant7?(StrengthImplement @this) => @this.StrengthImplementVariant7;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant7? value)
        {
            StrengthImplementVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant7(global::Terra.StrengthImplementVariant7? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant8 value) => new StrengthImplement((global::Terra.StrengthImplementVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant8?(StrengthImplement @this) => @this.StrengthImplementVariant8;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant8? value)
        {
            StrengthImplementVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant8(global::Terra.StrengthImplementVariant8? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant9 value) => new StrengthImplement((global::Terra.StrengthImplementVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant9?(StrengthImplement @this) => @this.StrengthImplementVariant9;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant9? value)
        {
            StrengthImplementVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant9(global::Terra.StrengthImplementVariant9? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant10 value) => new StrengthImplement((global::Terra.StrengthImplementVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant10?(StrengthImplement @this) => @this.StrengthImplementVariant10;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant10? value)
        {
            StrengthImplementVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant10(global::Terra.StrengthImplementVariant10? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant11 value) => new StrengthImplement((global::Terra.StrengthImplementVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant11?(StrengthImplement @this) => @this.StrengthImplementVariant11;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant11? value)
        {
            StrengthImplementVariant11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant11(global::Terra.StrengthImplementVariant11? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant12 value) => new StrengthImplement((global::Terra.StrengthImplementVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant12?(StrengthImplement @this) => @this.StrengthImplementVariant12;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant12? value)
        {
            StrengthImplementVariant12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant12(global::Terra.StrengthImplementVariant12? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant13 value) => new StrengthImplement((global::Terra.StrengthImplementVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant13?(StrengthImplement @this) => @this.StrengthImplementVariant13;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant13? value)
        {
            StrengthImplementVariant13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant13(global::Terra.StrengthImplementVariant13? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant14 value) => new StrengthImplement((global::Terra.StrengthImplementVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant14?(StrengthImplement @this) => @this.StrengthImplementVariant14;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant14? value)
        {
            StrengthImplementVariant14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant14(global::Terra.StrengthImplementVariant14? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant15 value) => new StrengthImplement((global::Terra.StrengthImplementVariant15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant15?(StrengthImplement @this) => @this.StrengthImplementVariant15;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant15? value)
        {
            StrengthImplementVariant15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant15(global::Terra.StrengthImplementVariant15? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant16 value) => new StrengthImplement((global::Terra.StrengthImplementVariant16?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant16?(StrengthImplement @this) => @this.StrengthImplementVariant16;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant16? value)
        {
            StrengthImplementVariant16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant16(global::Terra.StrengthImplementVariant16? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant17 value) => new StrengthImplement((global::Terra.StrengthImplementVariant17?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant17?(StrengthImplement @this) => @this.StrengthImplementVariant17;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant17? value)
        {
            StrengthImplementVariant17 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant17(global::Terra.StrengthImplementVariant17? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant18 value) => new StrengthImplement((global::Terra.StrengthImplementVariant18?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant18?(StrengthImplement @this) => @this.StrengthImplementVariant18;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant18? value)
        {
            StrengthImplementVariant18 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant18(global::Terra.StrengthImplementVariant18? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant19 value) => new StrengthImplement((global::Terra.StrengthImplementVariant19?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant19?(StrengthImplement @this) => @this.StrengthImplementVariant19;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant19? value)
        {
            StrengthImplementVariant19 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant19(global::Terra.StrengthImplementVariant19? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant20 value) => new StrengthImplement((global::Terra.StrengthImplementVariant20?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant20?(StrengthImplement @this) => @this.StrengthImplementVariant20;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant20? value)
        {
            StrengthImplementVariant20 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant20(global::Terra.StrengthImplementVariant20? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant21 value) => new StrengthImplement((global::Terra.StrengthImplementVariant21?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant21?(StrengthImplement @this) => @this.StrengthImplementVariant21;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant21? value)
        {
            StrengthImplementVariant21 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant21(global::Terra.StrengthImplementVariant21? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant22 value) => new StrengthImplement((global::Terra.StrengthImplementVariant22?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant22?(StrengthImplement @this) => @this.StrengthImplementVariant22;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant22? value)
        {
            StrengthImplementVariant22 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant22(global::Terra.StrengthImplementVariant22? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant23 value) => new StrengthImplement((global::Terra.StrengthImplementVariant23?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant23?(StrengthImplement @this) => @this.StrengthImplementVariant23;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant23? value)
        {
            StrengthImplementVariant23 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant23(global::Terra.StrengthImplementVariant23? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant24 value) => new StrengthImplement((global::Terra.StrengthImplementVariant24?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant24?(StrengthImplement @this) => @this.StrengthImplementVariant24;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant24? value)
        {
            StrengthImplementVariant24 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant24(global::Terra.StrengthImplementVariant24? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(global::Terra.StrengthImplementVariant25 value) => new StrengthImplement((global::Terra.StrengthImplementVariant25?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthImplementVariant25?(StrengthImplement @this) => @this.StrengthImplementVariant25;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(global::Terra.StrengthImplementVariant25? value)
        {
            StrengthImplementVariant25 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant25(global::Terra.StrengthImplementVariant25? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthImplement(string value) => new StrengthImplement((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StrengthImplement @this) => @this.StrengthImplementVariant26;

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(string? value)
        {
            StrengthImplementVariant26 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthImplement FromStrengthImplementVariant26(string? value) => new StrengthImplement(value);

        /// <summary>
        /// 
        /// </summary>
        public StrengthImplement(
            global::Terra.StrengthImplementVariant1? strengthImplementVariant1,
            global::Terra.StrengthImplementVariant2? strengthImplementVariant2,
            global::Terra.StrengthImplementVariant3? strengthImplementVariant3,
            global::Terra.StrengthImplementVariant4? strengthImplementVariant4,
            global::Terra.StrengthImplementVariant5? strengthImplementVariant5,
            global::Terra.StrengthImplementVariant6? strengthImplementVariant6,
            global::Terra.StrengthImplementVariant7? strengthImplementVariant7,
            global::Terra.StrengthImplementVariant8? strengthImplementVariant8,
            global::Terra.StrengthImplementVariant9? strengthImplementVariant9,
            global::Terra.StrengthImplementVariant10? strengthImplementVariant10,
            global::Terra.StrengthImplementVariant11? strengthImplementVariant11,
            global::Terra.StrengthImplementVariant12? strengthImplementVariant12,
            global::Terra.StrengthImplementVariant13? strengthImplementVariant13,
            global::Terra.StrengthImplementVariant14? strengthImplementVariant14,
            global::Terra.StrengthImplementVariant15? strengthImplementVariant15,
            global::Terra.StrengthImplementVariant16? strengthImplementVariant16,
            global::Terra.StrengthImplementVariant17? strengthImplementVariant17,
            global::Terra.StrengthImplementVariant18? strengthImplementVariant18,
            global::Terra.StrengthImplementVariant19? strengthImplementVariant19,
            global::Terra.StrengthImplementVariant20? strengthImplementVariant20,
            global::Terra.StrengthImplementVariant21? strengthImplementVariant21,
            global::Terra.StrengthImplementVariant22? strengthImplementVariant22,
            global::Terra.StrengthImplementVariant23? strengthImplementVariant23,
            global::Terra.StrengthImplementVariant24? strengthImplementVariant24,
            global::Terra.StrengthImplementVariant25? strengthImplementVariant25,
            string? strengthImplementVariant26
            )
        {
            StrengthImplementVariant1 = strengthImplementVariant1;
            StrengthImplementVariant2 = strengthImplementVariant2;
            StrengthImplementVariant3 = strengthImplementVariant3;
            StrengthImplementVariant4 = strengthImplementVariant4;
            StrengthImplementVariant5 = strengthImplementVariant5;
            StrengthImplementVariant6 = strengthImplementVariant6;
            StrengthImplementVariant7 = strengthImplementVariant7;
            StrengthImplementVariant8 = strengthImplementVariant8;
            StrengthImplementVariant9 = strengthImplementVariant9;
            StrengthImplementVariant10 = strengthImplementVariant10;
            StrengthImplementVariant11 = strengthImplementVariant11;
            StrengthImplementVariant12 = strengthImplementVariant12;
            StrengthImplementVariant13 = strengthImplementVariant13;
            StrengthImplementVariant14 = strengthImplementVariant14;
            StrengthImplementVariant15 = strengthImplementVariant15;
            StrengthImplementVariant16 = strengthImplementVariant16;
            StrengthImplementVariant17 = strengthImplementVariant17;
            StrengthImplementVariant18 = strengthImplementVariant18;
            StrengthImplementVariant19 = strengthImplementVariant19;
            StrengthImplementVariant20 = strengthImplementVariant20;
            StrengthImplementVariant21 = strengthImplementVariant21;
            StrengthImplementVariant22 = strengthImplementVariant22;
            StrengthImplementVariant23 = strengthImplementVariant23;
            StrengthImplementVariant24 = strengthImplementVariant24;
            StrengthImplementVariant25 = strengthImplementVariant25;
            StrengthImplementVariant26 = strengthImplementVariant26;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StrengthImplementVariant26 as object ??
            StrengthImplementVariant25 as object ??
            StrengthImplementVariant24 as object ??
            StrengthImplementVariant23 as object ??
            StrengthImplementVariant22 as object ??
            StrengthImplementVariant21 as object ??
            StrengthImplementVariant20 as object ??
            StrengthImplementVariant19 as object ??
            StrengthImplementVariant18 as object ??
            StrengthImplementVariant17 as object ??
            StrengthImplementVariant16 as object ??
            StrengthImplementVariant15 as object ??
            StrengthImplementVariant14 as object ??
            StrengthImplementVariant13 as object ??
            StrengthImplementVariant12 as object ??
            StrengthImplementVariant11 as object ??
            StrengthImplementVariant10 as object ??
            StrengthImplementVariant9 as object ??
            StrengthImplementVariant8 as object ??
            StrengthImplementVariant7 as object ??
            StrengthImplementVariant6 as object ??
            StrengthImplementVariant5 as object ??
            StrengthImplementVariant4 as object ??
            StrengthImplementVariant3 as object ??
            StrengthImplementVariant2 as object ??
            StrengthImplementVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StrengthImplementVariant1?.ToValueString() ??
            StrengthImplementVariant2?.ToValueString() ??
            StrengthImplementVariant3?.ToValueString() ??
            StrengthImplementVariant4?.ToValueString() ??
            StrengthImplementVariant5?.ToValueString() ??
            StrengthImplementVariant6?.ToValueString() ??
            StrengthImplementVariant7?.ToValueString() ??
            StrengthImplementVariant8?.ToValueString() ??
            StrengthImplementVariant9?.ToValueString() ??
            StrengthImplementVariant10?.ToValueString() ??
            StrengthImplementVariant11?.ToValueString() ??
            StrengthImplementVariant12?.ToValueString() ??
            StrengthImplementVariant13?.ToValueString() ??
            StrengthImplementVariant14?.ToValueString() ??
            StrengthImplementVariant15?.ToValueString() ??
            StrengthImplementVariant16?.ToValueString() ??
            StrengthImplementVariant17?.ToValueString() ??
            StrengthImplementVariant18?.ToValueString() ??
            StrengthImplementVariant19?.ToValueString() ??
            StrengthImplementVariant20?.ToValueString() ??
            StrengthImplementVariant21?.ToValueString() ??
            StrengthImplementVariant22?.ToValueString() ??
            StrengthImplementVariant23?.ToValueString() ??
            StrengthImplementVariant24?.ToValueString() ??
            StrengthImplementVariant25?.ToValueString() ??
            StrengthImplementVariant26?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStrengthImplementVariant1 || IsStrengthImplementVariant2 || IsStrengthImplementVariant3 || IsStrengthImplementVariant4 || IsStrengthImplementVariant5 || IsStrengthImplementVariant6 || IsStrengthImplementVariant7 || IsStrengthImplementVariant8 || IsStrengthImplementVariant9 || IsStrengthImplementVariant10 || IsStrengthImplementVariant11 || IsStrengthImplementVariant12 || IsStrengthImplementVariant13 || IsStrengthImplementVariant14 || IsStrengthImplementVariant15 || IsStrengthImplementVariant16 || IsStrengthImplementVariant17 || IsStrengthImplementVariant18 || IsStrengthImplementVariant19 || IsStrengthImplementVariant20 || IsStrengthImplementVariant21 || IsStrengthImplementVariant22 || IsStrengthImplementVariant23 || IsStrengthImplementVariant24 || IsStrengthImplementVariant25 || IsStrengthImplementVariant26;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthImplementVariant1?, TResult>? strengthImplementVariant1 = null,
            global::System.Func<global::Terra.StrengthImplementVariant2?, TResult>? strengthImplementVariant2 = null,
            global::System.Func<global::Terra.StrengthImplementVariant3?, TResult>? strengthImplementVariant3 = null,
            global::System.Func<global::Terra.StrengthImplementVariant4?, TResult>? strengthImplementVariant4 = null,
            global::System.Func<global::Terra.StrengthImplementVariant5?, TResult>? strengthImplementVariant5 = null,
            global::System.Func<global::Terra.StrengthImplementVariant6?, TResult>? strengthImplementVariant6 = null,
            global::System.Func<global::Terra.StrengthImplementVariant7?, TResult>? strengthImplementVariant7 = null,
            global::System.Func<global::Terra.StrengthImplementVariant8?, TResult>? strengthImplementVariant8 = null,
            global::System.Func<global::Terra.StrengthImplementVariant9?, TResult>? strengthImplementVariant9 = null,
            global::System.Func<global::Terra.StrengthImplementVariant10?, TResult>? strengthImplementVariant10 = null,
            global::System.Func<global::Terra.StrengthImplementVariant11?, TResult>? strengthImplementVariant11 = null,
            global::System.Func<global::Terra.StrengthImplementVariant12?, TResult>? strengthImplementVariant12 = null,
            global::System.Func<global::Terra.StrengthImplementVariant13?, TResult>? strengthImplementVariant13 = null,
            global::System.Func<global::Terra.StrengthImplementVariant14?, TResult>? strengthImplementVariant14 = null,
            global::System.Func<global::Terra.StrengthImplementVariant15?, TResult>? strengthImplementVariant15 = null,
            global::System.Func<global::Terra.StrengthImplementVariant16?, TResult>? strengthImplementVariant16 = null,
            global::System.Func<global::Terra.StrengthImplementVariant17?, TResult>? strengthImplementVariant17 = null,
            global::System.Func<global::Terra.StrengthImplementVariant18?, TResult>? strengthImplementVariant18 = null,
            global::System.Func<global::Terra.StrengthImplementVariant19?, TResult>? strengthImplementVariant19 = null,
            global::System.Func<global::Terra.StrengthImplementVariant20?, TResult>? strengthImplementVariant20 = null,
            global::System.Func<global::Terra.StrengthImplementVariant21?, TResult>? strengthImplementVariant21 = null,
            global::System.Func<global::Terra.StrengthImplementVariant22?, TResult>? strengthImplementVariant22 = null,
            global::System.Func<global::Terra.StrengthImplementVariant23?, TResult>? strengthImplementVariant23 = null,
            global::System.Func<global::Terra.StrengthImplementVariant24?, TResult>? strengthImplementVariant24 = null,
            global::System.Func<global::Terra.StrengthImplementVariant25?, TResult>? strengthImplementVariant25 = null,
            global::System.Func<string, TResult>? strengthImplementVariant26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthImplementVariant1 && strengthImplementVariant1 != null)
            {
                return strengthImplementVariant1(StrengthImplementVariant1!);
            }
            else if (IsStrengthImplementVariant2 && strengthImplementVariant2 != null)
            {
                return strengthImplementVariant2(StrengthImplementVariant2!);
            }
            else if (IsStrengthImplementVariant3 && strengthImplementVariant3 != null)
            {
                return strengthImplementVariant3(StrengthImplementVariant3!);
            }
            else if (IsStrengthImplementVariant4 && strengthImplementVariant4 != null)
            {
                return strengthImplementVariant4(StrengthImplementVariant4!);
            }
            else if (IsStrengthImplementVariant5 && strengthImplementVariant5 != null)
            {
                return strengthImplementVariant5(StrengthImplementVariant5!);
            }
            else if (IsStrengthImplementVariant6 && strengthImplementVariant6 != null)
            {
                return strengthImplementVariant6(StrengthImplementVariant6!);
            }
            else if (IsStrengthImplementVariant7 && strengthImplementVariant7 != null)
            {
                return strengthImplementVariant7(StrengthImplementVariant7!);
            }
            else if (IsStrengthImplementVariant8 && strengthImplementVariant8 != null)
            {
                return strengthImplementVariant8(StrengthImplementVariant8!);
            }
            else if (IsStrengthImplementVariant9 && strengthImplementVariant9 != null)
            {
                return strengthImplementVariant9(StrengthImplementVariant9!);
            }
            else if (IsStrengthImplementVariant10 && strengthImplementVariant10 != null)
            {
                return strengthImplementVariant10(StrengthImplementVariant10!);
            }
            else if (IsStrengthImplementVariant11 && strengthImplementVariant11 != null)
            {
                return strengthImplementVariant11(StrengthImplementVariant11!);
            }
            else if (IsStrengthImplementVariant12 && strengthImplementVariant12 != null)
            {
                return strengthImplementVariant12(StrengthImplementVariant12!);
            }
            else if (IsStrengthImplementVariant13 && strengthImplementVariant13 != null)
            {
                return strengthImplementVariant13(StrengthImplementVariant13!);
            }
            else if (IsStrengthImplementVariant14 && strengthImplementVariant14 != null)
            {
                return strengthImplementVariant14(StrengthImplementVariant14!);
            }
            else if (IsStrengthImplementVariant15 && strengthImplementVariant15 != null)
            {
                return strengthImplementVariant15(StrengthImplementVariant15!);
            }
            else if (IsStrengthImplementVariant16 && strengthImplementVariant16 != null)
            {
                return strengthImplementVariant16(StrengthImplementVariant16!);
            }
            else if (IsStrengthImplementVariant17 && strengthImplementVariant17 != null)
            {
                return strengthImplementVariant17(StrengthImplementVariant17!);
            }
            else if (IsStrengthImplementVariant18 && strengthImplementVariant18 != null)
            {
                return strengthImplementVariant18(StrengthImplementVariant18!);
            }
            else if (IsStrengthImplementVariant19 && strengthImplementVariant19 != null)
            {
                return strengthImplementVariant19(StrengthImplementVariant19!);
            }
            else if (IsStrengthImplementVariant20 && strengthImplementVariant20 != null)
            {
                return strengthImplementVariant20(StrengthImplementVariant20!);
            }
            else if (IsStrengthImplementVariant21 && strengthImplementVariant21 != null)
            {
                return strengthImplementVariant21(StrengthImplementVariant21!);
            }
            else if (IsStrengthImplementVariant22 && strengthImplementVariant22 != null)
            {
                return strengthImplementVariant22(StrengthImplementVariant22!);
            }
            else if (IsStrengthImplementVariant23 && strengthImplementVariant23 != null)
            {
                return strengthImplementVariant23(StrengthImplementVariant23!);
            }
            else if (IsStrengthImplementVariant24 && strengthImplementVariant24 != null)
            {
                return strengthImplementVariant24(StrengthImplementVariant24!);
            }
            else if (IsStrengthImplementVariant25 && strengthImplementVariant25 != null)
            {
                return strengthImplementVariant25(StrengthImplementVariant25!);
            }
            else if (IsStrengthImplementVariant26 && strengthImplementVariant26 != null)
            {
                return strengthImplementVariant26(StrengthImplementVariant26!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthImplementVariant1?>? strengthImplementVariant1 = null,

            global::System.Action<global::Terra.StrengthImplementVariant2?>? strengthImplementVariant2 = null,

            global::System.Action<global::Terra.StrengthImplementVariant3?>? strengthImplementVariant3 = null,

            global::System.Action<global::Terra.StrengthImplementVariant4?>? strengthImplementVariant4 = null,

            global::System.Action<global::Terra.StrengthImplementVariant5?>? strengthImplementVariant5 = null,

            global::System.Action<global::Terra.StrengthImplementVariant6?>? strengthImplementVariant6 = null,

            global::System.Action<global::Terra.StrengthImplementVariant7?>? strengthImplementVariant7 = null,

            global::System.Action<global::Terra.StrengthImplementVariant8?>? strengthImplementVariant8 = null,

            global::System.Action<global::Terra.StrengthImplementVariant9?>? strengthImplementVariant9 = null,

            global::System.Action<global::Terra.StrengthImplementVariant10?>? strengthImplementVariant10 = null,

            global::System.Action<global::Terra.StrengthImplementVariant11?>? strengthImplementVariant11 = null,

            global::System.Action<global::Terra.StrengthImplementVariant12?>? strengthImplementVariant12 = null,

            global::System.Action<global::Terra.StrengthImplementVariant13?>? strengthImplementVariant13 = null,

            global::System.Action<global::Terra.StrengthImplementVariant14?>? strengthImplementVariant14 = null,

            global::System.Action<global::Terra.StrengthImplementVariant15?>? strengthImplementVariant15 = null,

            global::System.Action<global::Terra.StrengthImplementVariant16?>? strengthImplementVariant16 = null,

            global::System.Action<global::Terra.StrengthImplementVariant17?>? strengthImplementVariant17 = null,

            global::System.Action<global::Terra.StrengthImplementVariant18?>? strengthImplementVariant18 = null,

            global::System.Action<global::Terra.StrengthImplementVariant19?>? strengthImplementVariant19 = null,

            global::System.Action<global::Terra.StrengthImplementVariant20?>? strengthImplementVariant20 = null,

            global::System.Action<global::Terra.StrengthImplementVariant21?>? strengthImplementVariant21 = null,

            global::System.Action<global::Terra.StrengthImplementVariant22?>? strengthImplementVariant22 = null,

            global::System.Action<global::Terra.StrengthImplementVariant23?>? strengthImplementVariant23 = null,

            global::System.Action<global::Terra.StrengthImplementVariant24?>? strengthImplementVariant24 = null,

            global::System.Action<global::Terra.StrengthImplementVariant25?>? strengthImplementVariant25 = null,

            global::System.Action<string>? strengthImplementVariant26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthImplementVariant1)
            {
                strengthImplementVariant1?.Invoke(StrengthImplementVariant1!);
            }
            else if (IsStrengthImplementVariant2)
            {
                strengthImplementVariant2?.Invoke(StrengthImplementVariant2!);
            }
            else if (IsStrengthImplementVariant3)
            {
                strengthImplementVariant3?.Invoke(StrengthImplementVariant3!);
            }
            else if (IsStrengthImplementVariant4)
            {
                strengthImplementVariant4?.Invoke(StrengthImplementVariant4!);
            }
            else if (IsStrengthImplementVariant5)
            {
                strengthImplementVariant5?.Invoke(StrengthImplementVariant5!);
            }
            else if (IsStrengthImplementVariant6)
            {
                strengthImplementVariant6?.Invoke(StrengthImplementVariant6!);
            }
            else if (IsStrengthImplementVariant7)
            {
                strengthImplementVariant7?.Invoke(StrengthImplementVariant7!);
            }
            else if (IsStrengthImplementVariant8)
            {
                strengthImplementVariant8?.Invoke(StrengthImplementVariant8!);
            }
            else if (IsStrengthImplementVariant9)
            {
                strengthImplementVariant9?.Invoke(StrengthImplementVariant9!);
            }
            else if (IsStrengthImplementVariant10)
            {
                strengthImplementVariant10?.Invoke(StrengthImplementVariant10!);
            }
            else if (IsStrengthImplementVariant11)
            {
                strengthImplementVariant11?.Invoke(StrengthImplementVariant11!);
            }
            else if (IsStrengthImplementVariant12)
            {
                strengthImplementVariant12?.Invoke(StrengthImplementVariant12!);
            }
            else if (IsStrengthImplementVariant13)
            {
                strengthImplementVariant13?.Invoke(StrengthImplementVariant13!);
            }
            else if (IsStrengthImplementVariant14)
            {
                strengthImplementVariant14?.Invoke(StrengthImplementVariant14!);
            }
            else if (IsStrengthImplementVariant15)
            {
                strengthImplementVariant15?.Invoke(StrengthImplementVariant15!);
            }
            else if (IsStrengthImplementVariant16)
            {
                strengthImplementVariant16?.Invoke(StrengthImplementVariant16!);
            }
            else if (IsStrengthImplementVariant17)
            {
                strengthImplementVariant17?.Invoke(StrengthImplementVariant17!);
            }
            else if (IsStrengthImplementVariant18)
            {
                strengthImplementVariant18?.Invoke(StrengthImplementVariant18!);
            }
            else if (IsStrengthImplementVariant19)
            {
                strengthImplementVariant19?.Invoke(StrengthImplementVariant19!);
            }
            else if (IsStrengthImplementVariant20)
            {
                strengthImplementVariant20?.Invoke(StrengthImplementVariant20!);
            }
            else if (IsStrengthImplementVariant21)
            {
                strengthImplementVariant21?.Invoke(StrengthImplementVariant21!);
            }
            else if (IsStrengthImplementVariant22)
            {
                strengthImplementVariant22?.Invoke(StrengthImplementVariant22!);
            }
            else if (IsStrengthImplementVariant23)
            {
                strengthImplementVariant23?.Invoke(StrengthImplementVariant23!);
            }
            else if (IsStrengthImplementVariant24)
            {
                strengthImplementVariant24?.Invoke(StrengthImplementVariant24!);
            }
            else if (IsStrengthImplementVariant25)
            {
                strengthImplementVariant25?.Invoke(StrengthImplementVariant25!);
            }
            else if (IsStrengthImplementVariant26)
            {
                strengthImplementVariant26?.Invoke(StrengthImplementVariant26!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthImplementVariant1?>? strengthImplementVariant1 = null,
            global::System.Action<global::Terra.StrengthImplementVariant2?>? strengthImplementVariant2 = null,
            global::System.Action<global::Terra.StrengthImplementVariant3?>? strengthImplementVariant3 = null,
            global::System.Action<global::Terra.StrengthImplementVariant4?>? strengthImplementVariant4 = null,
            global::System.Action<global::Terra.StrengthImplementVariant5?>? strengthImplementVariant5 = null,
            global::System.Action<global::Terra.StrengthImplementVariant6?>? strengthImplementVariant6 = null,
            global::System.Action<global::Terra.StrengthImplementVariant7?>? strengthImplementVariant7 = null,
            global::System.Action<global::Terra.StrengthImplementVariant8?>? strengthImplementVariant8 = null,
            global::System.Action<global::Terra.StrengthImplementVariant9?>? strengthImplementVariant9 = null,
            global::System.Action<global::Terra.StrengthImplementVariant10?>? strengthImplementVariant10 = null,
            global::System.Action<global::Terra.StrengthImplementVariant11?>? strengthImplementVariant11 = null,
            global::System.Action<global::Terra.StrengthImplementVariant12?>? strengthImplementVariant12 = null,
            global::System.Action<global::Terra.StrengthImplementVariant13?>? strengthImplementVariant13 = null,
            global::System.Action<global::Terra.StrengthImplementVariant14?>? strengthImplementVariant14 = null,
            global::System.Action<global::Terra.StrengthImplementVariant15?>? strengthImplementVariant15 = null,
            global::System.Action<global::Terra.StrengthImplementVariant16?>? strengthImplementVariant16 = null,
            global::System.Action<global::Terra.StrengthImplementVariant17?>? strengthImplementVariant17 = null,
            global::System.Action<global::Terra.StrengthImplementVariant18?>? strengthImplementVariant18 = null,
            global::System.Action<global::Terra.StrengthImplementVariant19?>? strengthImplementVariant19 = null,
            global::System.Action<global::Terra.StrengthImplementVariant20?>? strengthImplementVariant20 = null,
            global::System.Action<global::Terra.StrengthImplementVariant21?>? strengthImplementVariant21 = null,
            global::System.Action<global::Terra.StrengthImplementVariant22?>? strengthImplementVariant22 = null,
            global::System.Action<global::Terra.StrengthImplementVariant23?>? strengthImplementVariant23 = null,
            global::System.Action<global::Terra.StrengthImplementVariant24?>? strengthImplementVariant24 = null,
            global::System.Action<global::Terra.StrengthImplementVariant25?>? strengthImplementVariant25 = null,
            global::System.Action<string>? strengthImplementVariant26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthImplementVariant1)
            {
                strengthImplementVariant1?.Invoke(StrengthImplementVariant1!);
            }
            else if (IsStrengthImplementVariant2)
            {
                strengthImplementVariant2?.Invoke(StrengthImplementVariant2!);
            }
            else if (IsStrengthImplementVariant3)
            {
                strengthImplementVariant3?.Invoke(StrengthImplementVariant3!);
            }
            else if (IsStrengthImplementVariant4)
            {
                strengthImplementVariant4?.Invoke(StrengthImplementVariant4!);
            }
            else if (IsStrengthImplementVariant5)
            {
                strengthImplementVariant5?.Invoke(StrengthImplementVariant5!);
            }
            else if (IsStrengthImplementVariant6)
            {
                strengthImplementVariant6?.Invoke(StrengthImplementVariant6!);
            }
            else if (IsStrengthImplementVariant7)
            {
                strengthImplementVariant7?.Invoke(StrengthImplementVariant7!);
            }
            else if (IsStrengthImplementVariant8)
            {
                strengthImplementVariant8?.Invoke(StrengthImplementVariant8!);
            }
            else if (IsStrengthImplementVariant9)
            {
                strengthImplementVariant9?.Invoke(StrengthImplementVariant9!);
            }
            else if (IsStrengthImplementVariant10)
            {
                strengthImplementVariant10?.Invoke(StrengthImplementVariant10!);
            }
            else if (IsStrengthImplementVariant11)
            {
                strengthImplementVariant11?.Invoke(StrengthImplementVariant11!);
            }
            else if (IsStrengthImplementVariant12)
            {
                strengthImplementVariant12?.Invoke(StrengthImplementVariant12!);
            }
            else if (IsStrengthImplementVariant13)
            {
                strengthImplementVariant13?.Invoke(StrengthImplementVariant13!);
            }
            else if (IsStrengthImplementVariant14)
            {
                strengthImplementVariant14?.Invoke(StrengthImplementVariant14!);
            }
            else if (IsStrengthImplementVariant15)
            {
                strengthImplementVariant15?.Invoke(StrengthImplementVariant15!);
            }
            else if (IsStrengthImplementVariant16)
            {
                strengthImplementVariant16?.Invoke(StrengthImplementVariant16!);
            }
            else if (IsStrengthImplementVariant17)
            {
                strengthImplementVariant17?.Invoke(StrengthImplementVariant17!);
            }
            else if (IsStrengthImplementVariant18)
            {
                strengthImplementVariant18?.Invoke(StrengthImplementVariant18!);
            }
            else if (IsStrengthImplementVariant19)
            {
                strengthImplementVariant19?.Invoke(StrengthImplementVariant19!);
            }
            else if (IsStrengthImplementVariant20)
            {
                strengthImplementVariant20?.Invoke(StrengthImplementVariant20!);
            }
            else if (IsStrengthImplementVariant21)
            {
                strengthImplementVariant21?.Invoke(StrengthImplementVariant21!);
            }
            else if (IsStrengthImplementVariant22)
            {
                strengthImplementVariant22?.Invoke(StrengthImplementVariant22!);
            }
            else if (IsStrengthImplementVariant23)
            {
                strengthImplementVariant23?.Invoke(StrengthImplementVariant23!);
            }
            else if (IsStrengthImplementVariant24)
            {
                strengthImplementVariant24?.Invoke(StrengthImplementVariant24!);
            }
            else if (IsStrengthImplementVariant25)
            {
                strengthImplementVariant25?.Invoke(StrengthImplementVariant25!);
            }
            else if (IsStrengthImplementVariant26)
            {
                strengthImplementVariant26?.Invoke(StrengthImplementVariant26!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthImplementVariant1,
                typeof(global::Terra.StrengthImplementVariant1),
                StrengthImplementVariant2,
                typeof(global::Terra.StrengthImplementVariant2),
                StrengthImplementVariant3,
                typeof(global::Terra.StrengthImplementVariant3),
                StrengthImplementVariant4,
                typeof(global::Terra.StrengthImplementVariant4),
                StrengthImplementVariant5,
                typeof(global::Terra.StrengthImplementVariant5),
                StrengthImplementVariant6,
                typeof(global::Terra.StrengthImplementVariant6),
                StrengthImplementVariant7,
                typeof(global::Terra.StrengthImplementVariant7),
                StrengthImplementVariant8,
                typeof(global::Terra.StrengthImplementVariant8),
                StrengthImplementVariant9,
                typeof(global::Terra.StrengthImplementVariant9),
                StrengthImplementVariant10,
                typeof(global::Terra.StrengthImplementVariant10),
                StrengthImplementVariant11,
                typeof(global::Terra.StrengthImplementVariant11),
                StrengthImplementVariant12,
                typeof(global::Terra.StrengthImplementVariant12),
                StrengthImplementVariant13,
                typeof(global::Terra.StrengthImplementVariant13),
                StrengthImplementVariant14,
                typeof(global::Terra.StrengthImplementVariant14),
                StrengthImplementVariant15,
                typeof(global::Terra.StrengthImplementVariant15),
                StrengthImplementVariant16,
                typeof(global::Terra.StrengthImplementVariant16),
                StrengthImplementVariant17,
                typeof(global::Terra.StrengthImplementVariant17),
                StrengthImplementVariant18,
                typeof(global::Terra.StrengthImplementVariant18),
                StrengthImplementVariant19,
                typeof(global::Terra.StrengthImplementVariant19),
                StrengthImplementVariant20,
                typeof(global::Terra.StrengthImplementVariant20),
                StrengthImplementVariant21,
                typeof(global::Terra.StrengthImplementVariant21),
                StrengthImplementVariant22,
                typeof(global::Terra.StrengthImplementVariant22),
                StrengthImplementVariant23,
                typeof(global::Terra.StrengthImplementVariant23),
                StrengthImplementVariant24,
                typeof(global::Terra.StrengthImplementVariant24),
                StrengthImplementVariant25,
                typeof(global::Terra.StrengthImplementVariant25),
                StrengthImplementVariant26,
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
        public bool Equals(StrengthImplement other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant1?>.Default.Equals(StrengthImplementVariant1, other.StrengthImplementVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant2?>.Default.Equals(StrengthImplementVariant2, other.StrengthImplementVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant3?>.Default.Equals(StrengthImplementVariant3, other.StrengthImplementVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant4?>.Default.Equals(StrengthImplementVariant4, other.StrengthImplementVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant5?>.Default.Equals(StrengthImplementVariant5, other.StrengthImplementVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant6?>.Default.Equals(StrengthImplementVariant6, other.StrengthImplementVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant7?>.Default.Equals(StrengthImplementVariant7, other.StrengthImplementVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant8?>.Default.Equals(StrengthImplementVariant8, other.StrengthImplementVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant9?>.Default.Equals(StrengthImplementVariant9, other.StrengthImplementVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant10?>.Default.Equals(StrengthImplementVariant10, other.StrengthImplementVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant11?>.Default.Equals(StrengthImplementVariant11, other.StrengthImplementVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant12?>.Default.Equals(StrengthImplementVariant12, other.StrengthImplementVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant13?>.Default.Equals(StrengthImplementVariant13, other.StrengthImplementVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant14?>.Default.Equals(StrengthImplementVariant14, other.StrengthImplementVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant15?>.Default.Equals(StrengthImplementVariant15, other.StrengthImplementVariant15) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant16?>.Default.Equals(StrengthImplementVariant16, other.StrengthImplementVariant16) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant17?>.Default.Equals(StrengthImplementVariant17, other.StrengthImplementVariant17) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant18?>.Default.Equals(StrengthImplementVariant18, other.StrengthImplementVariant18) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant19?>.Default.Equals(StrengthImplementVariant19, other.StrengthImplementVariant19) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant20?>.Default.Equals(StrengthImplementVariant20, other.StrengthImplementVariant20) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant21?>.Default.Equals(StrengthImplementVariant21, other.StrengthImplementVariant21) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant22?>.Default.Equals(StrengthImplementVariant22, other.StrengthImplementVariant22) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant23?>.Default.Equals(StrengthImplementVariant23, other.StrengthImplementVariant23) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant24?>.Default.Equals(StrengthImplementVariant24, other.StrengthImplementVariant24) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthImplementVariant25?>.Default.Equals(StrengthImplementVariant25, other.StrengthImplementVariant25) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthImplementVariant26, other.StrengthImplementVariant26) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StrengthImplement obj1, StrengthImplement obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthImplement>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StrengthImplement obj1, StrengthImplement obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthImplement o && Equals(o);
        }
    }
}

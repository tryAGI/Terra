#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// The body part a stretch or mobility drill acts on. For a stretch the body part IS the exercise, which is why it is reported separately from the muscles worked. Open enum — handle unknown values gracefully.<br/>
    /// Example: abs
    /// </summary>
    public readonly partial struct StrengthTarget : global::System.IEquatable<StrengthTarget>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant1? StrengthTargetVariant1 { get; init; }
#else
        public global::Terra.StrengthTargetVariant1? StrengthTargetVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant1))]
#endif
        public bool IsStrengthTargetVariant1 => StrengthTargetVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant1? value)
        {
            value = StrengthTargetVariant1;
            return IsStrengthTargetVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant1 PickStrengthTargetVariant1() => IsStrengthTargetVariant1
            ? StrengthTargetVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant2? StrengthTargetVariant2 { get; init; }
#else
        public global::Terra.StrengthTargetVariant2? StrengthTargetVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant2))]
#endif
        public bool IsStrengthTargetVariant2 => StrengthTargetVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant2? value)
        {
            value = StrengthTargetVariant2;
            return IsStrengthTargetVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant2 PickStrengthTargetVariant2() => IsStrengthTargetVariant2
            ? StrengthTargetVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant3? StrengthTargetVariant3 { get; init; }
#else
        public global::Terra.StrengthTargetVariant3? StrengthTargetVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant3))]
#endif
        public bool IsStrengthTargetVariant3 => StrengthTargetVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant3? value)
        {
            value = StrengthTargetVariant3;
            return IsStrengthTargetVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant3 PickStrengthTargetVariant3() => IsStrengthTargetVariant3
            ? StrengthTargetVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant4? StrengthTargetVariant4 { get; init; }
#else
        public global::Terra.StrengthTargetVariant4? StrengthTargetVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant4))]
#endif
        public bool IsStrengthTargetVariant4 => StrengthTargetVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant4? value)
        {
            value = StrengthTargetVariant4;
            return IsStrengthTargetVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant4 PickStrengthTargetVariant4() => IsStrengthTargetVariant4
            ? StrengthTargetVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant5? StrengthTargetVariant5 { get; init; }
#else
        public global::Terra.StrengthTargetVariant5? StrengthTargetVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant5))]
#endif
        public bool IsStrengthTargetVariant5 => StrengthTargetVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant5? value)
        {
            value = StrengthTargetVariant5;
            return IsStrengthTargetVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant5 PickStrengthTargetVariant5() => IsStrengthTargetVariant5
            ? StrengthTargetVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant6? StrengthTargetVariant6 { get; init; }
#else
        public global::Terra.StrengthTargetVariant6? StrengthTargetVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant6))]
#endif
        public bool IsStrengthTargetVariant6 => StrengthTargetVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant6? value)
        {
            value = StrengthTargetVariant6;
            return IsStrengthTargetVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant6 PickStrengthTargetVariant6() => IsStrengthTargetVariant6
            ? StrengthTargetVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant6' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant7? StrengthTargetVariant7 { get; init; }
#else
        public global::Terra.StrengthTargetVariant7? StrengthTargetVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant7))]
#endif
        public bool IsStrengthTargetVariant7 => StrengthTargetVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant7? value)
        {
            value = StrengthTargetVariant7;
            return IsStrengthTargetVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant7 PickStrengthTargetVariant7() => IsStrengthTargetVariant7
            ? StrengthTargetVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant7' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant8? StrengthTargetVariant8 { get; init; }
#else
        public global::Terra.StrengthTargetVariant8? StrengthTargetVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant8))]
#endif
        public bool IsStrengthTargetVariant8 => StrengthTargetVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant8? value)
        {
            value = StrengthTargetVariant8;
            return IsStrengthTargetVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant8 PickStrengthTargetVariant8() => IsStrengthTargetVariant8
            ? StrengthTargetVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant8' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant9? StrengthTargetVariant9 { get; init; }
#else
        public global::Terra.StrengthTargetVariant9? StrengthTargetVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant9))]
#endif
        public bool IsStrengthTargetVariant9 => StrengthTargetVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant9? value)
        {
            value = StrengthTargetVariant9;
            return IsStrengthTargetVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant9 PickStrengthTargetVariant9() => IsStrengthTargetVariant9
            ? StrengthTargetVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant9' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant10? StrengthTargetVariant10 { get; init; }
#else
        public global::Terra.StrengthTargetVariant10? StrengthTargetVariant10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant10))]
#endif
        public bool IsStrengthTargetVariant10 => StrengthTargetVariant10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant10? value)
        {
            value = StrengthTargetVariant10;
            return IsStrengthTargetVariant10;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant10 PickStrengthTargetVariant10() => IsStrengthTargetVariant10
            ? StrengthTargetVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant10' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant11? StrengthTargetVariant11 { get; init; }
#else
        public global::Terra.StrengthTargetVariant11? StrengthTargetVariant11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant11))]
#endif
        public bool IsStrengthTargetVariant11 => StrengthTargetVariant11 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant11? value)
        {
            value = StrengthTargetVariant11;
            return IsStrengthTargetVariant11;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant11 PickStrengthTargetVariant11() => IsStrengthTargetVariant11
            ? StrengthTargetVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant11' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant12? StrengthTargetVariant12 { get; init; }
#else
        public global::Terra.StrengthTargetVariant12? StrengthTargetVariant12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant12))]
#endif
        public bool IsStrengthTargetVariant12 => StrengthTargetVariant12 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant12? value)
        {
            value = StrengthTargetVariant12;
            return IsStrengthTargetVariant12;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant12 PickStrengthTargetVariant12() => IsStrengthTargetVariant12
            ? StrengthTargetVariant12!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant12' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant13? StrengthTargetVariant13 { get; init; }
#else
        public global::Terra.StrengthTargetVariant13? StrengthTargetVariant13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant13))]
#endif
        public bool IsStrengthTargetVariant13 => StrengthTargetVariant13 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant13(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant13? value)
        {
            value = StrengthTargetVariant13;
            return IsStrengthTargetVariant13;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant13 PickStrengthTargetVariant13() => IsStrengthTargetVariant13
            ? StrengthTargetVariant13!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant13' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant14? StrengthTargetVariant14 { get; init; }
#else
        public global::Terra.StrengthTargetVariant14? StrengthTargetVariant14 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant14))]
#endif
        public bool IsStrengthTargetVariant14 => StrengthTargetVariant14 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant14(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant14? value)
        {
            value = StrengthTargetVariant14;
            return IsStrengthTargetVariant14;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant14 PickStrengthTargetVariant14() => IsStrengthTargetVariant14
            ? StrengthTargetVariant14!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant14' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant15? StrengthTargetVariant15 { get; init; }
#else
        public global::Terra.StrengthTargetVariant15? StrengthTargetVariant15 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant15))]
#endif
        public bool IsStrengthTargetVariant15 => StrengthTargetVariant15 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant15(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant15? value)
        {
            value = StrengthTargetVariant15;
            return IsStrengthTargetVariant15;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant15 PickStrengthTargetVariant15() => IsStrengthTargetVariant15
            ? StrengthTargetVariant15!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant15' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant16? StrengthTargetVariant16 { get; init; }
#else
        public global::Terra.StrengthTargetVariant16? StrengthTargetVariant16 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant16))]
#endif
        public bool IsStrengthTargetVariant16 => StrengthTargetVariant16 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant16(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant16? value)
        {
            value = StrengthTargetVariant16;
            return IsStrengthTargetVariant16;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant16 PickStrengthTargetVariant16() => IsStrengthTargetVariant16
            ? StrengthTargetVariant16!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant16' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant17? StrengthTargetVariant17 { get; init; }
#else
        public global::Terra.StrengthTargetVariant17? StrengthTargetVariant17 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant17))]
#endif
        public bool IsStrengthTargetVariant17 => StrengthTargetVariant17 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant17(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant17? value)
        {
            value = StrengthTargetVariant17;
            return IsStrengthTargetVariant17;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant17 PickStrengthTargetVariant17() => IsStrengthTargetVariant17
            ? StrengthTargetVariant17!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant17' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant18? StrengthTargetVariant18 { get; init; }
#else
        public global::Terra.StrengthTargetVariant18? StrengthTargetVariant18 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant18))]
#endif
        public bool IsStrengthTargetVariant18 => StrengthTargetVariant18 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant18(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant18? value)
        {
            value = StrengthTargetVariant18;
            return IsStrengthTargetVariant18;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant18 PickStrengthTargetVariant18() => IsStrengthTargetVariant18
            ? StrengthTargetVariant18!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant18' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant19? StrengthTargetVariant19 { get; init; }
#else
        public global::Terra.StrengthTargetVariant19? StrengthTargetVariant19 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant19))]
#endif
        public bool IsStrengthTargetVariant19 => StrengthTargetVariant19 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant19(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant19? value)
        {
            value = StrengthTargetVariant19;
            return IsStrengthTargetVariant19;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant19 PickStrengthTargetVariant19() => IsStrengthTargetVariant19
            ? StrengthTargetVariant19!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant19' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant20? StrengthTargetVariant20 { get; init; }
#else
        public global::Terra.StrengthTargetVariant20? StrengthTargetVariant20 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant20))]
#endif
        public bool IsStrengthTargetVariant20 => StrengthTargetVariant20 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant20(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant20? value)
        {
            value = StrengthTargetVariant20;
            return IsStrengthTargetVariant20;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant20 PickStrengthTargetVariant20() => IsStrengthTargetVariant20
            ? StrengthTargetVariant20!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant20' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant21? StrengthTargetVariant21 { get; init; }
#else
        public global::Terra.StrengthTargetVariant21? StrengthTargetVariant21 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant21))]
#endif
        public bool IsStrengthTargetVariant21 => StrengthTargetVariant21 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant21(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant21? value)
        {
            value = StrengthTargetVariant21;
            return IsStrengthTargetVariant21;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant21 PickStrengthTargetVariant21() => IsStrengthTargetVariant21
            ? StrengthTargetVariant21!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant21' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant22? StrengthTargetVariant22 { get; init; }
#else
        public global::Terra.StrengthTargetVariant22? StrengthTargetVariant22 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant22))]
#endif
        public bool IsStrengthTargetVariant22 => StrengthTargetVariant22 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant22(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant22? value)
        {
            value = StrengthTargetVariant22;
            return IsStrengthTargetVariant22;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant22 PickStrengthTargetVariant22() => IsStrengthTargetVariant22
            ? StrengthTargetVariant22!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant22' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant23? StrengthTargetVariant23 { get; init; }
#else
        public global::Terra.StrengthTargetVariant23? StrengthTargetVariant23 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant23))]
#endif
        public bool IsStrengthTargetVariant23 => StrengthTargetVariant23 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant23(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant23? value)
        {
            value = StrengthTargetVariant23;
            return IsStrengthTargetVariant23;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant23 PickStrengthTargetVariant23() => IsStrengthTargetVariant23
            ? StrengthTargetVariant23!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant23' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant24? StrengthTargetVariant24 { get; init; }
#else
        public global::Terra.StrengthTargetVariant24? StrengthTargetVariant24 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant24))]
#endif
        public bool IsStrengthTargetVariant24 => StrengthTargetVariant24 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant24(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant24? value)
        {
            value = StrengthTargetVariant24;
            return IsStrengthTargetVariant24;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant24 PickStrengthTargetVariant24() => IsStrengthTargetVariant24
            ? StrengthTargetVariant24!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant24' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTargetVariant25? StrengthTargetVariant25 { get; init; }
#else
        public global::Terra.StrengthTargetVariant25? StrengthTargetVariant25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant25))]
#endif
        public bool IsStrengthTargetVariant25 => StrengthTargetVariant25 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTargetVariant25? value)
        {
            value = StrengthTargetVariant25;
            return IsStrengthTargetVariant25;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTargetVariant25 PickStrengthTargetVariant25() => IsStrengthTargetVariant25
            ? StrengthTargetVariant25!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant25' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthTargetVariant26 { get; init; }
#else
        public string? StrengthTargetVariant26 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTargetVariant26))]
#endif
        public bool IsStrengthTargetVariant26 => StrengthTargetVariant26 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTargetVariant26(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthTargetVariant26;
            return IsStrengthTargetVariant26;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickStrengthTargetVariant26() => IsStrengthTargetVariant26
            ? StrengthTargetVariant26!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTargetVariant26' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant1 value) => new StrengthTarget((global::Terra.StrengthTargetVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant1?(StrengthTarget @this) => @this.StrengthTargetVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant1? value)
        {
            StrengthTargetVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant1(global::Terra.StrengthTargetVariant1? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant2 value) => new StrengthTarget((global::Terra.StrengthTargetVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant2?(StrengthTarget @this) => @this.StrengthTargetVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant2? value)
        {
            StrengthTargetVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant2(global::Terra.StrengthTargetVariant2? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant3 value) => new StrengthTarget((global::Terra.StrengthTargetVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant3?(StrengthTarget @this) => @this.StrengthTargetVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant3? value)
        {
            StrengthTargetVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant3(global::Terra.StrengthTargetVariant3? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant4 value) => new StrengthTarget((global::Terra.StrengthTargetVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant4?(StrengthTarget @this) => @this.StrengthTargetVariant4;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant4? value)
        {
            StrengthTargetVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant4(global::Terra.StrengthTargetVariant4? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant5 value) => new StrengthTarget((global::Terra.StrengthTargetVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant5?(StrengthTarget @this) => @this.StrengthTargetVariant5;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant5? value)
        {
            StrengthTargetVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant5(global::Terra.StrengthTargetVariant5? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant6 value) => new StrengthTarget((global::Terra.StrengthTargetVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant6?(StrengthTarget @this) => @this.StrengthTargetVariant6;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant6? value)
        {
            StrengthTargetVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant6(global::Terra.StrengthTargetVariant6? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant7 value) => new StrengthTarget((global::Terra.StrengthTargetVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant7?(StrengthTarget @this) => @this.StrengthTargetVariant7;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant7? value)
        {
            StrengthTargetVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant7(global::Terra.StrengthTargetVariant7? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant8 value) => new StrengthTarget((global::Terra.StrengthTargetVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant8?(StrengthTarget @this) => @this.StrengthTargetVariant8;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant8? value)
        {
            StrengthTargetVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant8(global::Terra.StrengthTargetVariant8? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant9 value) => new StrengthTarget((global::Terra.StrengthTargetVariant9?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant9?(StrengthTarget @this) => @this.StrengthTargetVariant9;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant9? value)
        {
            StrengthTargetVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant9(global::Terra.StrengthTargetVariant9? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant10 value) => new StrengthTarget((global::Terra.StrengthTargetVariant10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant10?(StrengthTarget @this) => @this.StrengthTargetVariant10;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant10? value)
        {
            StrengthTargetVariant10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant10(global::Terra.StrengthTargetVariant10? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant11 value) => new StrengthTarget((global::Terra.StrengthTargetVariant11?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant11?(StrengthTarget @this) => @this.StrengthTargetVariant11;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant11? value)
        {
            StrengthTargetVariant11 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant11(global::Terra.StrengthTargetVariant11? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant12 value) => new StrengthTarget((global::Terra.StrengthTargetVariant12?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant12?(StrengthTarget @this) => @this.StrengthTargetVariant12;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant12? value)
        {
            StrengthTargetVariant12 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant12(global::Terra.StrengthTargetVariant12? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant13 value) => new StrengthTarget((global::Terra.StrengthTargetVariant13?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant13?(StrengthTarget @this) => @this.StrengthTargetVariant13;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant13? value)
        {
            StrengthTargetVariant13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant13(global::Terra.StrengthTargetVariant13? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant14 value) => new StrengthTarget((global::Terra.StrengthTargetVariant14?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant14?(StrengthTarget @this) => @this.StrengthTargetVariant14;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant14? value)
        {
            StrengthTargetVariant14 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant14(global::Terra.StrengthTargetVariant14? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant15 value) => new StrengthTarget((global::Terra.StrengthTargetVariant15?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant15?(StrengthTarget @this) => @this.StrengthTargetVariant15;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant15? value)
        {
            StrengthTargetVariant15 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant15(global::Terra.StrengthTargetVariant15? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant16 value) => new StrengthTarget((global::Terra.StrengthTargetVariant16?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant16?(StrengthTarget @this) => @this.StrengthTargetVariant16;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant16? value)
        {
            StrengthTargetVariant16 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant16(global::Terra.StrengthTargetVariant16? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant17 value) => new StrengthTarget((global::Terra.StrengthTargetVariant17?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant17?(StrengthTarget @this) => @this.StrengthTargetVariant17;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant17? value)
        {
            StrengthTargetVariant17 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant17(global::Terra.StrengthTargetVariant17? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant18 value) => new StrengthTarget((global::Terra.StrengthTargetVariant18?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant18?(StrengthTarget @this) => @this.StrengthTargetVariant18;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant18? value)
        {
            StrengthTargetVariant18 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant18(global::Terra.StrengthTargetVariant18? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant19 value) => new StrengthTarget((global::Terra.StrengthTargetVariant19?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant19?(StrengthTarget @this) => @this.StrengthTargetVariant19;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant19? value)
        {
            StrengthTargetVariant19 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant19(global::Terra.StrengthTargetVariant19? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant20 value) => new StrengthTarget((global::Terra.StrengthTargetVariant20?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant20?(StrengthTarget @this) => @this.StrengthTargetVariant20;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant20? value)
        {
            StrengthTargetVariant20 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant20(global::Terra.StrengthTargetVariant20? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant21 value) => new StrengthTarget((global::Terra.StrengthTargetVariant21?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant21?(StrengthTarget @this) => @this.StrengthTargetVariant21;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant21? value)
        {
            StrengthTargetVariant21 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant21(global::Terra.StrengthTargetVariant21? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant22 value) => new StrengthTarget((global::Terra.StrengthTargetVariant22?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant22?(StrengthTarget @this) => @this.StrengthTargetVariant22;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant22? value)
        {
            StrengthTargetVariant22 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant22(global::Terra.StrengthTargetVariant22? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant23 value) => new StrengthTarget((global::Terra.StrengthTargetVariant23?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant23?(StrengthTarget @this) => @this.StrengthTargetVariant23;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant23? value)
        {
            StrengthTargetVariant23 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant23(global::Terra.StrengthTargetVariant23? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant24 value) => new StrengthTarget((global::Terra.StrengthTargetVariant24?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant24?(StrengthTarget @this) => @this.StrengthTargetVariant24;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant24? value)
        {
            StrengthTargetVariant24 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant24(global::Terra.StrengthTargetVariant24? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(global::Terra.StrengthTargetVariant25 value) => new StrengthTarget((global::Terra.StrengthTargetVariant25?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTargetVariant25?(StrengthTarget @this) => @this.StrengthTargetVariant25;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(global::Terra.StrengthTargetVariant25? value)
        {
            StrengthTargetVariant25 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant25(global::Terra.StrengthTargetVariant25? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTarget(string value) => new StrengthTarget((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StrengthTarget @this) => @this.StrengthTargetVariant26;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(string? value)
        {
            StrengthTargetVariant26 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTarget FromStrengthTargetVariant26(string? value) => new StrengthTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public StrengthTarget(
            global::Terra.StrengthTargetVariant1? strengthTargetVariant1,
            global::Terra.StrengthTargetVariant2? strengthTargetVariant2,
            global::Terra.StrengthTargetVariant3? strengthTargetVariant3,
            global::Terra.StrengthTargetVariant4? strengthTargetVariant4,
            global::Terra.StrengthTargetVariant5? strengthTargetVariant5,
            global::Terra.StrengthTargetVariant6? strengthTargetVariant6,
            global::Terra.StrengthTargetVariant7? strengthTargetVariant7,
            global::Terra.StrengthTargetVariant8? strengthTargetVariant8,
            global::Terra.StrengthTargetVariant9? strengthTargetVariant9,
            global::Terra.StrengthTargetVariant10? strengthTargetVariant10,
            global::Terra.StrengthTargetVariant11? strengthTargetVariant11,
            global::Terra.StrengthTargetVariant12? strengthTargetVariant12,
            global::Terra.StrengthTargetVariant13? strengthTargetVariant13,
            global::Terra.StrengthTargetVariant14? strengthTargetVariant14,
            global::Terra.StrengthTargetVariant15? strengthTargetVariant15,
            global::Terra.StrengthTargetVariant16? strengthTargetVariant16,
            global::Terra.StrengthTargetVariant17? strengthTargetVariant17,
            global::Terra.StrengthTargetVariant18? strengthTargetVariant18,
            global::Terra.StrengthTargetVariant19? strengthTargetVariant19,
            global::Terra.StrengthTargetVariant20? strengthTargetVariant20,
            global::Terra.StrengthTargetVariant21? strengthTargetVariant21,
            global::Terra.StrengthTargetVariant22? strengthTargetVariant22,
            global::Terra.StrengthTargetVariant23? strengthTargetVariant23,
            global::Terra.StrengthTargetVariant24? strengthTargetVariant24,
            global::Terra.StrengthTargetVariant25? strengthTargetVariant25,
            string? strengthTargetVariant26
            )
        {
            StrengthTargetVariant1 = strengthTargetVariant1;
            StrengthTargetVariant2 = strengthTargetVariant2;
            StrengthTargetVariant3 = strengthTargetVariant3;
            StrengthTargetVariant4 = strengthTargetVariant4;
            StrengthTargetVariant5 = strengthTargetVariant5;
            StrengthTargetVariant6 = strengthTargetVariant6;
            StrengthTargetVariant7 = strengthTargetVariant7;
            StrengthTargetVariant8 = strengthTargetVariant8;
            StrengthTargetVariant9 = strengthTargetVariant9;
            StrengthTargetVariant10 = strengthTargetVariant10;
            StrengthTargetVariant11 = strengthTargetVariant11;
            StrengthTargetVariant12 = strengthTargetVariant12;
            StrengthTargetVariant13 = strengthTargetVariant13;
            StrengthTargetVariant14 = strengthTargetVariant14;
            StrengthTargetVariant15 = strengthTargetVariant15;
            StrengthTargetVariant16 = strengthTargetVariant16;
            StrengthTargetVariant17 = strengthTargetVariant17;
            StrengthTargetVariant18 = strengthTargetVariant18;
            StrengthTargetVariant19 = strengthTargetVariant19;
            StrengthTargetVariant20 = strengthTargetVariant20;
            StrengthTargetVariant21 = strengthTargetVariant21;
            StrengthTargetVariant22 = strengthTargetVariant22;
            StrengthTargetVariant23 = strengthTargetVariant23;
            StrengthTargetVariant24 = strengthTargetVariant24;
            StrengthTargetVariant25 = strengthTargetVariant25;
            StrengthTargetVariant26 = strengthTargetVariant26;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StrengthTargetVariant26 as object ??
            StrengthTargetVariant25 as object ??
            StrengthTargetVariant24 as object ??
            StrengthTargetVariant23 as object ??
            StrengthTargetVariant22 as object ??
            StrengthTargetVariant21 as object ??
            StrengthTargetVariant20 as object ??
            StrengthTargetVariant19 as object ??
            StrengthTargetVariant18 as object ??
            StrengthTargetVariant17 as object ??
            StrengthTargetVariant16 as object ??
            StrengthTargetVariant15 as object ??
            StrengthTargetVariant14 as object ??
            StrengthTargetVariant13 as object ??
            StrengthTargetVariant12 as object ??
            StrengthTargetVariant11 as object ??
            StrengthTargetVariant10 as object ??
            StrengthTargetVariant9 as object ??
            StrengthTargetVariant8 as object ??
            StrengthTargetVariant7 as object ??
            StrengthTargetVariant6 as object ??
            StrengthTargetVariant5 as object ??
            StrengthTargetVariant4 as object ??
            StrengthTargetVariant3 as object ??
            StrengthTargetVariant2 as object ??
            StrengthTargetVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StrengthTargetVariant1?.ToValueString() ??
            StrengthTargetVariant2?.ToValueString() ??
            StrengthTargetVariant3?.ToValueString() ??
            StrengthTargetVariant4?.ToValueString() ??
            StrengthTargetVariant5?.ToValueString() ??
            StrengthTargetVariant6?.ToValueString() ??
            StrengthTargetVariant7?.ToValueString() ??
            StrengthTargetVariant8?.ToValueString() ??
            StrengthTargetVariant9?.ToValueString() ??
            StrengthTargetVariant10?.ToValueString() ??
            StrengthTargetVariant11?.ToValueString() ??
            StrengthTargetVariant12?.ToValueString() ??
            StrengthTargetVariant13?.ToValueString() ??
            StrengthTargetVariant14?.ToValueString() ??
            StrengthTargetVariant15?.ToValueString() ??
            StrengthTargetVariant16?.ToValueString() ??
            StrengthTargetVariant17?.ToValueString() ??
            StrengthTargetVariant18?.ToValueString() ??
            StrengthTargetVariant19?.ToValueString() ??
            StrengthTargetVariant20?.ToValueString() ??
            StrengthTargetVariant21?.ToValueString() ??
            StrengthTargetVariant22?.ToValueString() ??
            StrengthTargetVariant23?.ToValueString() ??
            StrengthTargetVariant24?.ToValueString() ??
            StrengthTargetVariant25?.ToValueString() ??
            StrengthTargetVariant26?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStrengthTargetVariant1 || IsStrengthTargetVariant2 || IsStrengthTargetVariant3 || IsStrengthTargetVariant4 || IsStrengthTargetVariant5 || IsStrengthTargetVariant6 || IsStrengthTargetVariant7 || IsStrengthTargetVariant8 || IsStrengthTargetVariant9 || IsStrengthTargetVariant10 || IsStrengthTargetVariant11 || IsStrengthTargetVariant12 || IsStrengthTargetVariant13 || IsStrengthTargetVariant14 || IsStrengthTargetVariant15 || IsStrengthTargetVariant16 || IsStrengthTargetVariant17 || IsStrengthTargetVariant18 || IsStrengthTargetVariant19 || IsStrengthTargetVariant20 || IsStrengthTargetVariant21 || IsStrengthTargetVariant22 || IsStrengthTargetVariant23 || IsStrengthTargetVariant24 || IsStrengthTargetVariant25 || IsStrengthTargetVariant26;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthTargetVariant1?, TResult>? strengthTargetVariant1 = null,
            global::System.Func<global::Terra.StrengthTargetVariant2?, TResult>? strengthTargetVariant2 = null,
            global::System.Func<global::Terra.StrengthTargetVariant3?, TResult>? strengthTargetVariant3 = null,
            global::System.Func<global::Terra.StrengthTargetVariant4?, TResult>? strengthTargetVariant4 = null,
            global::System.Func<global::Terra.StrengthTargetVariant5?, TResult>? strengthTargetVariant5 = null,
            global::System.Func<global::Terra.StrengthTargetVariant6?, TResult>? strengthTargetVariant6 = null,
            global::System.Func<global::Terra.StrengthTargetVariant7?, TResult>? strengthTargetVariant7 = null,
            global::System.Func<global::Terra.StrengthTargetVariant8?, TResult>? strengthTargetVariant8 = null,
            global::System.Func<global::Terra.StrengthTargetVariant9?, TResult>? strengthTargetVariant9 = null,
            global::System.Func<global::Terra.StrengthTargetVariant10?, TResult>? strengthTargetVariant10 = null,
            global::System.Func<global::Terra.StrengthTargetVariant11?, TResult>? strengthTargetVariant11 = null,
            global::System.Func<global::Terra.StrengthTargetVariant12?, TResult>? strengthTargetVariant12 = null,
            global::System.Func<global::Terra.StrengthTargetVariant13?, TResult>? strengthTargetVariant13 = null,
            global::System.Func<global::Terra.StrengthTargetVariant14?, TResult>? strengthTargetVariant14 = null,
            global::System.Func<global::Terra.StrengthTargetVariant15?, TResult>? strengthTargetVariant15 = null,
            global::System.Func<global::Terra.StrengthTargetVariant16?, TResult>? strengthTargetVariant16 = null,
            global::System.Func<global::Terra.StrengthTargetVariant17?, TResult>? strengthTargetVariant17 = null,
            global::System.Func<global::Terra.StrengthTargetVariant18?, TResult>? strengthTargetVariant18 = null,
            global::System.Func<global::Terra.StrengthTargetVariant19?, TResult>? strengthTargetVariant19 = null,
            global::System.Func<global::Terra.StrengthTargetVariant20?, TResult>? strengthTargetVariant20 = null,
            global::System.Func<global::Terra.StrengthTargetVariant21?, TResult>? strengthTargetVariant21 = null,
            global::System.Func<global::Terra.StrengthTargetVariant22?, TResult>? strengthTargetVariant22 = null,
            global::System.Func<global::Terra.StrengthTargetVariant23?, TResult>? strengthTargetVariant23 = null,
            global::System.Func<global::Terra.StrengthTargetVariant24?, TResult>? strengthTargetVariant24 = null,
            global::System.Func<global::Terra.StrengthTargetVariant25?, TResult>? strengthTargetVariant25 = null,
            global::System.Func<string, TResult>? strengthTargetVariant26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthTargetVariant1 && strengthTargetVariant1 != null)
            {
                return strengthTargetVariant1(StrengthTargetVariant1!);
            }
            else if (IsStrengthTargetVariant2 && strengthTargetVariant2 != null)
            {
                return strengthTargetVariant2(StrengthTargetVariant2!);
            }
            else if (IsStrengthTargetVariant3 && strengthTargetVariant3 != null)
            {
                return strengthTargetVariant3(StrengthTargetVariant3!);
            }
            else if (IsStrengthTargetVariant4 && strengthTargetVariant4 != null)
            {
                return strengthTargetVariant4(StrengthTargetVariant4!);
            }
            else if (IsStrengthTargetVariant5 && strengthTargetVariant5 != null)
            {
                return strengthTargetVariant5(StrengthTargetVariant5!);
            }
            else if (IsStrengthTargetVariant6 && strengthTargetVariant6 != null)
            {
                return strengthTargetVariant6(StrengthTargetVariant6!);
            }
            else if (IsStrengthTargetVariant7 && strengthTargetVariant7 != null)
            {
                return strengthTargetVariant7(StrengthTargetVariant7!);
            }
            else if (IsStrengthTargetVariant8 && strengthTargetVariant8 != null)
            {
                return strengthTargetVariant8(StrengthTargetVariant8!);
            }
            else if (IsStrengthTargetVariant9 && strengthTargetVariant9 != null)
            {
                return strengthTargetVariant9(StrengthTargetVariant9!);
            }
            else if (IsStrengthTargetVariant10 && strengthTargetVariant10 != null)
            {
                return strengthTargetVariant10(StrengthTargetVariant10!);
            }
            else if (IsStrengthTargetVariant11 && strengthTargetVariant11 != null)
            {
                return strengthTargetVariant11(StrengthTargetVariant11!);
            }
            else if (IsStrengthTargetVariant12 && strengthTargetVariant12 != null)
            {
                return strengthTargetVariant12(StrengthTargetVariant12!);
            }
            else if (IsStrengthTargetVariant13 && strengthTargetVariant13 != null)
            {
                return strengthTargetVariant13(StrengthTargetVariant13!);
            }
            else if (IsStrengthTargetVariant14 && strengthTargetVariant14 != null)
            {
                return strengthTargetVariant14(StrengthTargetVariant14!);
            }
            else if (IsStrengthTargetVariant15 && strengthTargetVariant15 != null)
            {
                return strengthTargetVariant15(StrengthTargetVariant15!);
            }
            else if (IsStrengthTargetVariant16 && strengthTargetVariant16 != null)
            {
                return strengthTargetVariant16(StrengthTargetVariant16!);
            }
            else if (IsStrengthTargetVariant17 && strengthTargetVariant17 != null)
            {
                return strengthTargetVariant17(StrengthTargetVariant17!);
            }
            else if (IsStrengthTargetVariant18 && strengthTargetVariant18 != null)
            {
                return strengthTargetVariant18(StrengthTargetVariant18!);
            }
            else if (IsStrengthTargetVariant19 && strengthTargetVariant19 != null)
            {
                return strengthTargetVariant19(StrengthTargetVariant19!);
            }
            else if (IsStrengthTargetVariant20 && strengthTargetVariant20 != null)
            {
                return strengthTargetVariant20(StrengthTargetVariant20!);
            }
            else if (IsStrengthTargetVariant21 && strengthTargetVariant21 != null)
            {
                return strengthTargetVariant21(StrengthTargetVariant21!);
            }
            else if (IsStrengthTargetVariant22 && strengthTargetVariant22 != null)
            {
                return strengthTargetVariant22(StrengthTargetVariant22!);
            }
            else if (IsStrengthTargetVariant23 && strengthTargetVariant23 != null)
            {
                return strengthTargetVariant23(StrengthTargetVariant23!);
            }
            else if (IsStrengthTargetVariant24 && strengthTargetVariant24 != null)
            {
                return strengthTargetVariant24(StrengthTargetVariant24!);
            }
            else if (IsStrengthTargetVariant25 && strengthTargetVariant25 != null)
            {
                return strengthTargetVariant25(StrengthTargetVariant25!);
            }
            else if (IsStrengthTargetVariant26 && strengthTargetVariant26 != null)
            {
                return strengthTargetVariant26(StrengthTargetVariant26!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthTargetVariant1?>? strengthTargetVariant1 = null,

            global::System.Action<global::Terra.StrengthTargetVariant2?>? strengthTargetVariant2 = null,

            global::System.Action<global::Terra.StrengthTargetVariant3?>? strengthTargetVariant3 = null,

            global::System.Action<global::Terra.StrengthTargetVariant4?>? strengthTargetVariant4 = null,

            global::System.Action<global::Terra.StrengthTargetVariant5?>? strengthTargetVariant5 = null,

            global::System.Action<global::Terra.StrengthTargetVariant6?>? strengthTargetVariant6 = null,

            global::System.Action<global::Terra.StrengthTargetVariant7?>? strengthTargetVariant7 = null,

            global::System.Action<global::Terra.StrengthTargetVariant8?>? strengthTargetVariant8 = null,

            global::System.Action<global::Terra.StrengthTargetVariant9?>? strengthTargetVariant9 = null,

            global::System.Action<global::Terra.StrengthTargetVariant10?>? strengthTargetVariant10 = null,

            global::System.Action<global::Terra.StrengthTargetVariant11?>? strengthTargetVariant11 = null,

            global::System.Action<global::Terra.StrengthTargetVariant12?>? strengthTargetVariant12 = null,

            global::System.Action<global::Terra.StrengthTargetVariant13?>? strengthTargetVariant13 = null,

            global::System.Action<global::Terra.StrengthTargetVariant14?>? strengthTargetVariant14 = null,

            global::System.Action<global::Terra.StrengthTargetVariant15?>? strengthTargetVariant15 = null,

            global::System.Action<global::Terra.StrengthTargetVariant16?>? strengthTargetVariant16 = null,

            global::System.Action<global::Terra.StrengthTargetVariant17?>? strengthTargetVariant17 = null,

            global::System.Action<global::Terra.StrengthTargetVariant18?>? strengthTargetVariant18 = null,

            global::System.Action<global::Terra.StrengthTargetVariant19?>? strengthTargetVariant19 = null,

            global::System.Action<global::Terra.StrengthTargetVariant20?>? strengthTargetVariant20 = null,

            global::System.Action<global::Terra.StrengthTargetVariant21?>? strengthTargetVariant21 = null,

            global::System.Action<global::Terra.StrengthTargetVariant22?>? strengthTargetVariant22 = null,

            global::System.Action<global::Terra.StrengthTargetVariant23?>? strengthTargetVariant23 = null,

            global::System.Action<global::Terra.StrengthTargetVariant24?>? strengthTargetVariant24 = null,

            global::System.Action<global::Terra.StrengthTargetVariant25?>? strengthTargetVariant25 = null,

            global::System.Action<string>? strengthTargetVariant26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthTargetVariant1)
            {
                strengthTargetVariant1?.Invoke(StrengthTargetVariant1!);
            }
            else if (IsStrengthTargetVariant2)
            {
                strengthTargetVariant2?.Invoke(StrengthTargetVariant2!);
            }
            else if (IsStrengthTargetVariant3)
            {
                strengthTargetVariant3?.Invoke(StrengthTargetVariant3!);
            }
            else if (IsStrengthTargetVariant4)
            {
                strengthTargetVariant4?.Invoke(StrengthTargetVariant4!);
            }
            else if (IsStrengthTargetVariant5)
            {
                strengthTargetVariant5?.Invoke(StrengthTargetVariant5!);
            }
            else if (IsStrengthTargetVariant6)
            {
                strengthTargetVariant6?.Invoke(StrengthTargetVariant6!);
            }
            else if (IsStrengthTargetVariant7)
            {
                strengthTargetVariant7?.Invoke(StrengthTargetVariant7!);
            }
            else if (IsStrengthTargetVariant8)
            {
                strengthTargetVariant8?.Invoke(StrengthTargetVariant8!);
            }
            else if (IsStrengthTargetVariant9)
            {
                strengthTargetVariant9?.Invoke(StrengthTargetVariant9!);
            }
            else if (IsStrengthTargetVariant10)
            {
                strengthTargetVariant10?.Invoke(StrengthTargetVariant10!);
            }
            else if (IsStrengthTargetVariant11)
            {
                strengthTargetVariant11?.Invoke(StrengthTargetVariant11!);
            }
            else if (IsStrengthTargetVariant12)
            {
                strengthTargetVariant12?.Invoke(StrengthTargetVariant12!);
            }
            else if (IsStrengthTargetVariant13)
            {
                strengthTargetVariant13?.Invoke(StrengthTargetVariant13!);
            }
            else if (IsStrengthTargetVariant14)
            {
                strengthTargetVariant14?.Invoke(StrengthTargetVariant14!);
            }
            else if (IsStrengthTargetVariant15)
            {
                strengthTargetVariant15?.Invoke(StrengthTargetVariant15!);
            }
            else if (IsStrengthTargetVariant16)
            {
                strengthTargetVariant16?.Invoke(StrengthTargetVariant16!);
            }
            else if (IsStrengthTargetVariant17)
            {
                strengthTargetVariant17?.Invoke(StrengthTargetVariant17!);
            }
            else if (IsStrengthTargetVariant18)
            {
                strengthTargetVariant18?.Invoke(StrengthTargetVariant18!);
            }
            else if (IsStrengthTargetVariant19)
            {
                strengthTargetVariant19?.Invoke(StrengthTargetVariant19!);
            }
            else if (IsStrengthTargetVariant20)
            {
                strengthTargetVariant20?.Invoke(StrengthTargetVariant20!);
            }
            else if (IsStrengthTargetVariant21)
            {
                strengthTargetVariant21?.Invoke(StrengthTargetVariant21!);
            }
            else if (IsStrengthTargetVariant22)
            {
                strengthTargetVariant22?.Invoke(StrengthTargetVariant22!);
            }
            else if (IsStrengthTargetVariant23)
            {
                strengthTargetVariant23?.Invoke(StrengthTargetVariant23!);
            }
            else if (IsStrengthTargetVariant24)
            {
                strengthTargetVariant24?.Invoke(StrengthTargetVariant24!);
            }
            else if (IsStrengthTargetVariant25)
            {
                strengthTargetVariant25?.Invoke(StrengthTargetVariant25!);
            }
            else if (IsStrengthTargetVariant26)
            {
                strengthTargetVariant26?.Invoke(StrengthTargetVariant26!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthTargetVariant1?>? strengthTargetVariant1 = null,
            global::System.Action<global::Terra.StrengthTargetVariant2?>? strengthTargetVariant2 = null,
            global::System.Action<global::Terra.StrengthTargetVariant3?>? strengthTargetVariant3 = null,
            global::System.Action<global::Terra.StrengthTargetVariant4?>? strengthTargetVariant4 = null,
            global::System.Action<global::Terra.StrengthTargetVariant5?>? strengthTargetVariant5 = null,
            global::System.Action<global::Terra.StrengthTargetVariant6?>? strengthTargetVariant6 = null,
            global::System.Action<global::Terra.StrengthTargetVariant7?>? strengthTargetVariant7 = null,
            global::System.Action<global::Terra.StrengthTargetVariant8?>? strengthTargetVariant8 = null,
            global::System.Action<global::Terra.StrengthTargetVariant9?>? strengthTargetVariant9 = null,
            global::System.Action<global::Terra.StrengthTargetVariant10?>? strengthTargetVariant10 = null,
            global::System.Action<global::Terra.StrengthTargetVariant11?>? strengthTargetVariant11 = null,
            global::System.Action<global::Terra.StrengthTargetVariant12?>? strengthTargetVariant12 = null,
            global::System.Action<global::Terra.StrengthTargetVariant13?>? strengthTargetVariant13 = null,
            global::System.Action<global::Terra.StrengthTargetVariant14?>? strengthTargetVariant14 = null,
            global::System.Action<global::Terra.StrengthTargetVariant15?>? strengthTargetVariant15 = null,
            global::System.Action<global::Terra.StrengthTargetVariant16?>? strengthTargetVariant16 = null,
            global::System.Action<global::Terra.StrengthTargetVariant17?>? strengthTargetVariant17 = null,
            global::System.Action<global::Terra.StrengthTargetVariant18?>? strengthTargetVariant18 = null,
            global::System.Action<global::Terra.StrengthTargetVariant19?>? strengthTargetVariant19 = null,
            global::System.Action<global::Terra.StrengthTargetVariant20?>? strengthTargetVariant20 = null,
            global::System.Action<global::Terra.StrengthTargetVariant21?>? strengthTargetVariant21 = null,
            global::System.Action<global::Terra.StrengthTargetVariant22?>? strengthTargetVariant22 = null,
            global::System.Action<global::Terra.StrengthTargetVariant23?>? strengthTargetVariant23 = null,
            global::System.Action<global::Terra.StrengthTargetVariant24?>? strengthTargetVariant24 = null,
            global::System.Action<global::Terra.StrengthTargetVariant25?>? strengthTargetVariant25 = null,
            global::System.Action<string>? strengthTargetVariant26 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthTargetVariant1)
            {
                strengthTargetVariant1?.Invoke(StrengthTargetVariant1!);
            }
            else if (IsStrengthTargetVariant2)
            {
                strengthTargetVariant2?.Invoke(StrengthTargetVariant2!);
            }
            else if (IsStrengthTargetVariant3)
            {
                strengthTargetVariant3?.Invoke(StrengthTargetVariant3!);
            }
            else if (IsStrengthTargetVariant4)
            {
                strengthTargetVariant4?.Invoke(StrengthTargetVariant4!);
            }
            else if (IsStrengthTargetVariant5)
            {
                strengthTargetVariant5?.Invoke(StrengthTargetVariant5!);
            }
            else if (IsStrengthTargetVariant6)
            {
                strengthTargetVariant6?.Invoke(StrengthTargetVariant6!);
            }
            else if (IsStrengthTargetVariant7)
            {
                strengthTargetVariant7?.Invoke(StrengthTargetVariant7!);
            }
            else if (IsStrengthTargetVariant8)
            {
                strengthTargetVariant8?.Invoke(StrengthTargetVariant8!);
            }
            else if (IsStrengthTargetVariant9)
            {
                strengthTargetVariant9?.Invoke(StrengthTargetVariant9!);
            }
            else if (IsStrengthTargetVariant10)
            {
                strengthTargetVariant10?.Invoke(StrengthTargetVariant10!);
            }
            else if (IsStrengthTargetVariant11)
            {
                strengthTargetVariant11?.Invoke(StrengthTargetVariant11!);
            }
            else if (IsStrengthTargetVariant12)
            {
                strengthTargetVariant12?.Invoke(StrengthTargetVariant12!);
            }
            else if (IsStrengthTargetVariant13)
            {
                strengthTargetVariant13?.Invoke(StrengthTargetVariant13!);
            }
            else if (IsStrengthTargetVariant14)
            {
                strengthTargetVariant14?.Invoke(StrengthTargetVariant14!);
            }
            else if (IsStrengthTargetVariant15)
            {
                strengthTargetVariant15?.Invoke(StrengthTargetVariant15!);
            }
            else if (IsStrengthTargetVariant16)
            {
                strengthTargetVariant16?.Invoke(StrengthTargetVariant16!);
            }
            else if (IsStrengthTargetVariant17)
            {
                strengthTargetVariant17?.Invoke(StrengthTargetVariant17!);
            }
            else if (IsStrengthTargetVariant18)
            {
                strengthTargetVariant18?.Invoke(StrengthTargetVariant18!);
            }
            else if (IsStrengthTargetVariant19)
            {
                strengthTargetVariant19?.Invoke(StrengthTargetVariant19!);
            }
            else if (IsStrengthTargetVariant20)
            {
                strengthTargetVariant20?.Invoke(StrengthTargetVariant20!);
            }
            else if (IsStrengthTargetVariant21)
            {
                strengthTargetVariant21?.Invoke(StrengthTargetVariant21!);
            }
            else if (IsStrengthTargetVariant22)
            {
                strengthTargetVariant22?.Invoke(StrengthTargetVariant22!);
            }
            else if (IsStrengthTargetVariant23)
            {
                strengthTargetVariant23?.Invoke(StrengthTargetVariant23!);
            }
            else if (IsStrengthTargetVariant24)
            {
                strengthTargetVariant24?.Invoke(StrengthTargetVariant24!);
            }
            else if (IsStrengthTargetVariant25)
            {
                strengthTargetVariant25?.Invoke(StrengthTargetVariant25!);
            }
            else if (IsStrengthTargetVariant26)
            {
                strengthTargetVariant26?.Invoke(StrengthTargetVariant26!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthTargetVariant1,
                typeof(global::Terra.StrengthTargetVariant1),
                StrengthTargetVariant2,
                typeof(global::Terra.StrengthTargetVariant2),
                StrengthTargetVariant3,
                typeof(global::Terra.StrengthTargetVariant3),
                StrengthTargetVariant4,
                typeof(global::Terra.StrengthTargetVariant4),
                StrengthTargetVariant5,
                typeof(global::Terra.StrengthTargetVariant5),
                StrengthTargetVariant6,
                typeof(global::Terra.StrengthTargetVariant6),
                StrengthTargetVariant7,
                typeof(global::Terra.StrengthTargetVariant7),
                StrengthTargetVariant8,
                typeof(global::Terra.StrengthTargetVariant8),
                StrengthTargetVariant9,
                typeof(global::Terra.StrengthTargetVariant9),
                StrengthTargetVariant10,
                typeof(global::Terra.StrengthTargetVariant10),
                StrengthTargetVariant11,
                typeof(global::Terra.StrengthTargetVariant11),
                StrengthTargetVariant12,
                typeof(global::Terra.StrengthTargetVariant12),
                StrengthTargetVariant13,
                typeof(global::Terra.StrengthTargetVariant13),
                StrengthTargetVariant14,
                typeof(global::Terra.StrengthTargetVariant14),
                StrengthTargetVariant15,
                typeof(global::Terra.StrengthTargetVariant15),
                StrengthTargetVariant16,
                typeof(global::Terra.StrengthTargetVariant16),
                StrengthTargetVariant17,
                typeof(global::Terra.StrengthTargetVariant17),
                StrengthTargetVariant18,
                typeof(global::Terra.StrengthTargetVariant18),
                StrengthTargetVariant19,
                typeof(global::Terra.StrengthTargetVariant19),
                StrengthTargetVariant20,
                typeof(global::Terra.StrengthTargetVariant20),
                StrengthTargetVariant21,
                typeof(global::Terra.StrengthTargetVariant21),
                StrengthTargetVariant22,
                typeof(global::Terra.StrengthTargetVariant22),
                StrengthTargetVariant23,
                typeof(global::Terra.StrengthTargetVariant23),
                StrengthTargetVariant24,
                typeof(global::Terra.StrengthTargetVariant24),
                StrengthTargetVariant25,
                typeof(global::Terra.StrengthTargetVariant25),
                StrengthTargetVariant26,
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
        public bool Equals(StrengthTarget other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant1?>.Default.Equals(StrengthTargetVariant1, other.StrengthTargetVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant2?>.Default.Equals(StrengthTargetVariant2, other.StrengthTargetVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant3?>.Default.Equals(StrengthTargetVariant3, other.StrengthTargetVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant4?>.Default.Equals(StrengthTargetVariant4, other.StrengthTargetVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant5?>.Default.Equals(StrengthTargetVariant5, other.StrengthTargetVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant6?>.Default.Equals(StrengthTargetVariant6, other.StrengthTargetVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant7?>.Default.Equals(StrengthTargetVariant7, other.StrengthTargetVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant8?>.Default.Equals(StrengthTargetVariant8, other.StrengthTargetVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant9?>.Default.Equals(StrengthTargetVariant9, other.StrengthTargetVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant10?>.Default.Equals(StrengthTargetVariant10, other.StrengthTargetVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant11?>.Default.Equals(StrengthTargetVariant11, other.StrengthTargetVariant11) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant12?>.Default.Equals(StrengthTargetVariant12, other.StrengthTargetVariant12) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant13?>.Default.Equals(StrengthTargetVariant13, other.StrengthTargetVariant13) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant14?>.Default.Equals(StrengthTargetVariant14, other.StrengthTargetVariant14) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant15?>.Default.Equals(StrengthTargetVariant15, other.StrengthTargetVariant15) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant16?>.Default.Equals(StrengthTargetVariant16, other.StrengthTargetVariant16) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant17?>.Default.Equals(StrengthTargetVariant17, other.StrengthTargetVariant17) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant18?>.Default.Equals(StrengthTargetVariant18, other.StrengthTargetVariant18) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant19?>.Default.Equals(StrengthTargetVariant19, other.StrengthTargetVariant19) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant20?>.Default.Equals(StrengthTargetVariant20, other.StrengthTargetVariant20) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant21?>.Default.Equals(StrengthTargetVariant21, other.StrengthTargetVariant21) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant22?>.Default.Equals(StrengthTargetVariant22, other.StrengthTargetVariant22) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant23?>.Default.Equals(StrengthTargetVariant23, other.StrengthTargetVariant23) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant24?>.Default.Equals(StrengthTargetVariant24, other.StrengthTargetVariant24) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTargetVariant25?>.Default.Equals(StrengthTargetVariant25, other.StrengthTargetVariant25) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthTargetVariant26, other.StrengthTargetVariant26) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StrengthTarget obj1, StrengthTarget obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthTarget>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StrengthTarget obj1, StrengthTarget obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthTarget o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// What the body is supported on, when it is not the floor. Open enum — handle unknown values gracefully.<br/>
    /// Example: bench
    /// </summary>
    public readonly partial struct StrengthSurface : global::System.IEquatable<StrengthSurface>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant1? StrengthSurfaceVariant1 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant1? StrengthSurfaceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant1))]
#endif
        public bool IsStrengthSurfaceVariant1 => StrengthSurfaceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant1? value)
        {
            value = StrengthSurfaceVariant1;
            return IsStrengthSurfaceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant1 PickStrengthSurfaceVariant1() => IsStrengthSurfaceVariant1
            ? StrengthSurfaceVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant2? StrengthSurfaceVariant2 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant2? StrengthSurfaceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant2))]
#endif
        public bool IsStrengthSurfaceVariant2 => StrengthSurfaceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant2? value)
        {
            value = StrengthSurfaceVariant2;
            return IsStrengthSurfaceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant2 PickStrengthSurfaceVariant2() => IsStrengthSurfaceVariant2
            ? StrengthSurfaceVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant3? StrengthSurfaceVariant3 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant3? StrengthSurfaceVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant3))]
#endif
        public bool IsStrengthSurfaceVariant3 => StrengthSurfaceVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant3? value)
        {
            value = StrengthSurfaceVariant3;
            return IsStrengthSurfaceVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant3 PickStrengthSurfaceVariant3() => IsStrengthSurfaceVariant3
            ? StrengthSurfaceVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant4? StrengthSurfaceVariant4 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant4? StrengthSurfaceVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant4))]
#endif
        public bool IsStrengthSurfaceVariant4 => StrengthSurfaceVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant4? value)
        {
            value = StrengthSurfaceVariant4;
            return IsStrengthSurfaceVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant4 PickStrengthSurfaceVariant4() => IsStrengthSurfaceVariant4
            ? StrengthSurfaceVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant5? StrengthSurfaceVariant5 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant5? StrengthSurfaceVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant5))]
#endif
        public bool IsStrengthSurfaceVariant5 => StrengthSurfaceVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant5? value)
        {
            value = StrengthSurfaceVariant5;
            return IsStrengthSurfaceVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant5 PickStrengthSurfaceVariant5() => IsStrengthSurfaceVariant5
            ? StrengthSurfaceVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant6? StrengthSurfaceVariant6 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant6? StrengthSurfaceVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant6))]
#endif
        public bool IsStrengthSurfaceVariant6 => StrengthSurfaceVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant6? value)
        {
            value = StrengthSurfaceVariant6;
            return IsStrengthSurfaceVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant6 PickStrengthSurfaceVariant6() => IsStrengthSurfaceVariant6
            ? StrengthSurfaceVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant7? StrengthSurfaceVariant7 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant7? StrengthSurfaceVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant7))]
#endif
        public bool IsStrengthSurfaceVariant7 => StrengthSurfaceVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant7? value)
        {
            value = StrengthSurfaceVariant7;
            return IsStrengthSurfaceVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant7 PickStrengthSurfaceVariant7() => IsStrengthSurfaceVariant7
            ? StrengthSurfaceVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant8? StrengthSurfaceVariant8 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant8? StrengthSurfaceVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant8))]
#endif
        public bool IsStrengthSurfaceVariant8 => StrengthSurfaceVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant8? value)
        {
            value = StrengthSurfaceVariant8;
            return IsStrengthSurfaceVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant8 PickStrengthSurfaceVariant8() => IsStrengthSurfaceVariant8
            ? StrengthSurfaceVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant9? StrengthSurfaceVariant9 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant9? StrengthSurfaceVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant9))]
#endif
        public bool IsStrengthSurfaceVariant9 => StrengthSurfaceVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant9? value)
        {
            value = StrengthSurfaceVariant9;
            return IsStrengthSurfaceVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant9 PickStrengthSurfaceVariant9() => IsStrengthSurfaceVariant9
            ? StrengthSurfaceVariant9!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant9' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant10? StrengthSurfaceVariant10 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant10? StrengthSurfaceVariant10 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant10))]
#endif
        public bool IsStrengthSurfaceVariant10 => StrengthSurfaceVariant10 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant10? value)
        {
            value = StrengthSurfaceVariant10;
            return IsStrengthSurfaceVariant10;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant10 PickStrengthSurfaceVariant10() => IsStrengthSurfaceVariant10
            ? StrengthSurfaceVariant10!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant10' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSurfaceVariant11? StrengthSurfaceVariant11 { get; init; }
#else
        public global::Terra.StrengthSurfaceVariant11? StrengthSurfaceVariant11 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant11))]
#endif
        public bool IsStrengthSurfaceVariant11 => StrengthSurfaceVariant11 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant11(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSurfaceVariant11? value)
        {
            value = StrengthSurfaceVariant11;
            return IsStrengthSurfaceVariant11;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSurfaceVariant11 PickStrengthSurfaceVariant11() => IsStrengthSurfaceVariant11
            ? StrengthSurfaceVariant11!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant11' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthSurfaceVariant12 { get; init; }
#else
        public string? StrengthSurfaceVariant12 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSurfaceVariant12))]
#endif
        public bool IsStrengthSurfaceVariant12 => StrengthSurfaceVariant12 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSurfaceVariant12(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthSurfaceVariant12;
            return IsStrengthSurfaceVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthSurfaceVariant12() => IsStrengthSurfaceVariant12
            ? StrengthSurfaceVariant12!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSurfaceVariant12' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant1 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant1?(StrengthSurface @this) => @this.StrengthSurfaceVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant1? value)
        {
            StrengthSurfaceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant1(global::Terra.StrengthSurfaceVariant1? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant2 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant2?(StrengthSurface @this) => @this.StrengthSurfaceVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant2? value)
        {
            StrengthSurfaceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant2(global::Terra.StrengthSurfaceVariant2? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant3 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant3?(StrengthSurface @this) => @this.StrengthSurfaceVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant3? value)
        {
            StrengthSurfaceVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant3(global::Terra.StrengthSurfaceVariant3? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant4 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant4?(StrengthSurface @this) => @this.StrengthSurfaceVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant4? value)
        {
            StrengthSurfaceVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant4(global::Terra.StrengthSurfaceVariant4? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant5 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant5?(StrengthSurface @this) => @this.StrengthSurfaceVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant5? value)
        {
            StrengthSurfaceVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant5(global::Terra.StrengthSurfaceVariant5? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant6 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant6?(StrengthSurface @this) => @this.StrengthSurfaceVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant6? value)
        {
            StrengthSurfaceVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant6(global::Terra.StrengthSurfaceVariant6? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant7 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant7?(StrengthSurface @this) => @this.StrengthSurfaceVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant7? value)
        {
            StrengthSurfaceVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant7(global::Terra.StrengthSurfaceVariant7? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant8 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant8?(StrengthSurface @this) => @this.StrengthSurfaceVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant8? value)
        {
            StrengthSurfaceVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant8(global::Terra.StrengthSurfaceVariant8? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant9 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant9?(StrengthSurface @this) => @this.StrengthSurfaceVariant9;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant9? value)
        {
            StrengthSurfaceVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant9(global::Terra.StrengthSurfaceVariant9? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant10 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant10?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant10?(StrengthSurface @this) => @this.StrengthSurfaceVariant10;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant10? value)
        {
            StrengthSurfaceVariant10 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant10(global::Terra.StrengthSurfaceVariant10? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(global::Terra.StrengthSurfaceVariant11 value) => new StrengthSurface((global::Terra.StrengthSurfaceVariant11?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSurfaceVariant11?(StrengthSurface @this) => @this.StrengthSurfaceVariant11;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(global::Terra.StrengthSurfaceVariant11? value)
        {
            StrengthSurfaceVariant11 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant11(global::Terra.StrengthSurfaceVariant11? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSurface(string value) => new StrengthSurface((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthSurface @this) => @this.StrengthSurfaceVariant12;

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(string? value)
        {
            StrengthSurfaceVariant12 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSurface FromStrengthSurfaceVariant12(string? value) => new StrengthSurface(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthSurface(
            global::Terra.StrengthSurfaceVariant1? strengthSurfaceVariant1,
            global::Terra.StrengthSurfaceVariant2? strengthSurfaceVariant2,
            global::Terra.StrengthSurfaceVariant3? strengthSurfaceVariant3,
            global::Terra.StrengthSurfaceVariant4? strengthSurfaceVariant4,
            global::Terra.StrengthSurfaceVariant5? strengthSurfaceVariant5,
            global::Terra.StrengthSurfaceVariant6? strengthSurfaceVariant6,
            global::Terra.StrengthSurfaceVariant7? strengthSurfaceVariant7,
            global::Terra.StrengthSurfaceVariant8? strengthSurfaceVariant8,
            global::Terra.StrengthSurfaceVariant9? strengthSurfaceVariant9,
            global::Terra.StrengthSurfaceVariant10? strengthSurfaceVariant10,
            global::Terra.StrengthSurfaceVariant11? strengthSurfaceVariant11,
            string? strengthSurfaceVariant12
            )
        {
            StrengthSurfaceVariant1 = strengthSurfaceVariant1;
            StrengthSurfaceVariant2 = strengthSurfaceVariant2;
            StrengthSurfaceVariant3 = strengthSurfaceVariant3;
            StrengthSurfaceVariant4 = strengthSurfaceVariant4;
            StrengthSurfaceVariant5 = strengthSurfaceVariant5;
            StrengthSurfaceVariant6 = strengthSurfaceVariant6;
            StrengthSurfaceVariant7 = strengthSurfaceVariant7;
            StrengthSurfaceVariant8 = strengthSurfaceVariant8;
            StrengthSurfaceVariant9 = strengthSurfaceVariant9;
            StrengthSurfaceVariant10 = strengthSurfaceVariant10;
            StrengthSurfaceVariant11 = strengthSurfaceVariant11;
            StrengthSurfaceVariant12 = strengthSurfaceVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthSurfaceVariant12 as object ??
            StrengthSurfaceVariant11 as object ??
            StrengthSurfaceVariant10 as object ??
            StrengthSurfaceVariant9 as object ??
            StrengthSurfaceVariant8 as object ??
            StrengthSurfaceVariant7 as object ??
            StrengthSurfaceVariant6 as object ??
            StrengthSurfaceVariant5 as object ??
            StrengthSurfaceVariant4 as object ??
            StrengthSurfaceVariant3 as object ??
            StrengthSurfaceVariant2 as object ??
            StrengthSurfaceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthSurfaceVariant1?.ToValueString() ??
            StrengthSurfaceVariant2?.ToValueString() ??
            StrengthSurfaceVariant3?.ToValueString() ??
            StrengthSurfaceVariant4?.ToValueString() ??
            StrengthSurfaceVariant5?.ToValueString() ??
            StrengthSurfaceVariant6?.ToValueString() ??
            StrengthSurfaceVariant7?.ToValueString() ??
            StrengthSurfaceVariant8?.ToValueString() ??
            StrengthSurfaceVariant9?.ToValueString() ??
            StrengthSurfaceVariant10?.ToValueString() ??
            StrengthSurfaceVariant11?.ToValueString() ??
            StrengthSurfaceVariant12?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthSurfaceVariant1 || IsStrengthSurfaceVariant2 || IsStrengthSurfaceVariant3 || IsStrengthSurfaceVariant4 || IsStrengthSurfaceVariant5 || IsStrengthSurfaceVariant6 || IsStrengthSurfaceVariant7 || IsStrengthSurfaceVariant8 || IsStrengthSurfaceVariant9 || IsStrengthSurfaceVariant10 || IsStrengthSurfaceVariant11 || IsStrengthSurfaceVariant12;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthSurfaceVariant1?, TResult>? strengthSurfaceVariant1 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant2?, TResult>? strengthSurfaceVariant2 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant3?, TResult>? strengthSurfaceVariant3 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant4?, TResult>? strengthSurfaceVariant4 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant5?, TResult>? strengthSurfaceVariant5 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant6?, TResult>? strengthSurfaceVariant6 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant7?, TResult>? strengthSurfaceVariant7 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant8?, TResult>? strengthSurfaceVariant8 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant9?, TResult>? strengthSurfaceVariant9 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant10?, TResult>? strengthSurfaceVariant10 = null,
            global::System.Func<global::Terra.StrengthSurfaceVariant11?, TResult>? strengthSurfaceVariant11 = null,
            global::System.Func<string, TResult>? strengthSurfaceVariant12 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthSurfaceVariant1 && strengthSurfaceVariant1 != null)
            {
                return strengthSurfaceVariant1(StrengthSurfaceVariant1!);
            }
            else if (IsStrengthSurfaceVariant2 && strengthSurfaceVariant2 != null)
            {
                return strengthSurfaceVariant2(StrengthSurfaceVariant2!);
            }
            else if (IsStrengthSurfaceVariant3 && strengthSurfaceVariant3 != null)
            {
                return strengthSurfaceVariant3(StrengthSurfaceVariant3!);
            }
            else if (IsStrengthSurfaceVariant4 && strengthSurfaceVariant4 != null)
            {
                return strengthSurfaceVariant4(StrengthSurfaceVariant4!);
            }
            else if (IsStrengthSurfaceVariant5 && strengthSurfaceVariant5 != null)
            {
                return strengthSurfaceVariant5(StrengthSurfaceVariant5!);
            }
            else if (IsStrengthSurfaceVariant6 && strengthSurfaceVariant6 != null)
            {
                return strengthSurfaceVariant6(StrengthSurfaceVariant6!);
            }
            else if (IsStrengthSurfaceVariant7 && strengthSurfaceVariant7 != null)
            {
                return strengthSurfaceVariant7(StrengthSurfaceVariant7!);
            }
            else if (IsStrengthSurfaceVariant8 && strengthSurfaceVariant8 != null)
            {
                return strengthSurfaceVariant8(StrengthSurfaceVariant8!);
            }
            else if (IsStrengthSurfaceVariant9 && strengthSurfaceVariant9 != null)
            {
                return strengthSurfaceVariant9(StrengthSurfaceVariant9!);
            }
            else if (IsStrengthSurfaceVariant10 && strengthSurfaceVariant10 != null)
            {
                return strengthSurfaceVariant10(StrengthSurfaceVariant10!);
            }
            else if (IsStrengthSurfaceVariant11 && strengthSurfaceVariant11 != null)
            {
                return strengthSurfaceVariant11(StrengthSurfaceVariant11!);
            }
            else if (IsStrengthSurfaceVariant12 && strengthSurfaceVariant12 != null)
            {
                return strengthSurfaceVariant12(StrengthSurfaceVariant12!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthSurfaceVariant1?>? strengthSurfaceVariant1 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant2?>? strengthSurfaceVariant2 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant3?>? strengthSurfaceVariant3 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant4?>? strengthSurfaceVariant4 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant5?>? strengthSurfaceVariant5 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant6?>? strengthSurfaceVariant6 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant7?>? strengthSurfaceVariant7 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant8?>? strengthSurfaceVariant8 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant9?>? strengthSurfaceVariant9 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant10?>? strengthSurfaceVariant10 = null,

            global::System.Action<global::Terra.StrengthSurfaceVariant11?>? strengthSurfaceVariant11 = null,

            global::System.Action<string>? strengthSurfaceVariant12 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthSurfaceVariant1)
            {
                strengthSurfaceVariant1?.Invoke(StrengthSurfaceVariant1!);
            }
            else if (IsStrengthSurfaceVariant2)
            {
                strengthSurfaceVariant2?.Invoke(StrengthSurfaceVariant2!);
            }
            else if (IsStrengthSurfaceVariant3)
            {
                strengthSurfaceVariant3?.Invoke(StrengthSurfaceVariant3!);
            }
            else if (IsStrengthSurfaceVariant4)
            {
                strengthSurfaceVariant4?.Invoke(StrengthSurfaceVariant4!);
            }
            else if (IsStrengthSurfaceVariant5)
            {
                strengthSurfaceVariant5?.Invoke(StrengthSurfaceVariant5!);
            }
            else if (IsStrengthSurfaceVariant6)
            {
                strengthSurfaceVariant6?.Invoke(StrengthSurfaceVariant6!);
            }
            else if (IsStrengthSurfaceVariant7)
            {
                strengthSurfaceVariant7?.Invoke(StrengthSurfaceVariant7!);
            }
            else if (IsStrengthSurfaceVariant8)
            {
                strengthSurfaceVariant8?.Invoke(StrengthSurfaceVariant8!);
            }
            else if (IsStrengthSurfaceVariant9)
            {
                strengthSurfaceVariant9?.Invoke(StrengthSurfaceVariant9!);
            }
            else if (IsStrengthSurfaceVariant10)
            {
                strengthSurfaceVariant10?.Invoke(StrengthSurfaceVariant10!);
            }
            else if (IsStrengthSurfaceVariant11)
            {
                strengthSurfaceVariant11?.Invoke(StrengthSurfaceVariant11!);
            }
            else if (IsStrengthSurfaceVariant12)
            {
                strengthSurfaceVariant12?.Invoke(StrengthSurfaceVariant12!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthSurfaceVariant1?>? strengthSurfaceVariant1 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant2?>? strengthSurfaceVariant2 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant3?>? strengthSurfaceVariant3 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant4?>? strengthSurfaceVariant4 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant5?>? strengthSurfaceVariant5 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant6?>? strengthSurfaceVariant6 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant7?>? strengthSurfaceVariant7 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant8?>? strengthSurfaceVariant8 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant9?>? strengthSurfaceVariant9 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant10?>? strengthSurfaceVariant10 = null,
            global::System.Action<global::Terra.StrengthSurfaceVariant11?>? strengthSurfaceVariant11 = null,
            global::System.Action<string>? strengthSurfaceVariant12 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthSurfaceVariant1)
            {
                strengthSurfaceVariant1?.Invoke(StrengthSurfaceVariant1!);
            }
            else if (IsStrengthSurfaceVariant2)
            {
                strengthSurfaceVariant2?.Invoke(StrengthSurfaceVariant2!);
            }
            else if (IsStrengthSurfaceVariant3)
            {
                strengthSurfaceVariant3?.Invoke(StrengthSurfaceVariant3!);
            }
            else if (IsStrengthSurfaceVariant4)
            {
                strengthSurfaceVariant4?.Invoke(StrengthSurfaceVariant4!);
            }
            else if (IsStrengthSurfaceVariant5)
            {
                strengthSurfaceVariant5?.Invoke(StrengthSurfaceVariant5!);
            }
            else if (IsStrengthSurfaceVariant6)
            {
                strengthSurfaceVariant6?.Invoke(StrengthSurfaceVariant6!);
            }
            else if (IsStrengthSurfaceVariant7)
            {
                strengthSurfaceVariant7?.Invoke(StrengthSurfaceVariant7!);
            }
            else if (IsStrengthSurfaceVariant8)
            {
                strengthSurfaceVariant8?.Invoke(StrengthSurfaceVariant8!);
            }
            else if (IsStrengthSurfaceVariant9)
            {
                strengthSurfaceVariant9?.Invoke(StrengthSurfaceVariant9!);
            }
            else if (IsStrengthSurfaceVariant10)
            {
                strengthSurfaceVariant10?.Invoke(StrengthSurfaceVariant10!);
            }
            else if (IsStrengthSurfaceVariant11)
            {
                strengthSurfaceVariant11?.Invoke(StrengthSurfaceVariant11!);
            }
            else if (IsStrengthSurfaceVariant12)
            {
                strengthSurfaceVariant12?.Invoke(StrengthSurfaceVariant12!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthSurfaceVariant1,
                typeof(global::Terra.StrengthSurfaceVariant1),
                StrengthSurfaceVariant2,
                typeof(global::Terra.StrengthSurfaceVariant2),
                StrengthSurfaceVariant3,
                typeof(global::Terra.StrengthSurfaceVariant3),
                StrengthSurfaceVariant4,
                typeof(global::Terra.StrengthSurfaceVariant4),
                StrengthSurfaceVariant5,
                typeof(global::Terra.StrengthSurfaceVariant5),
                StrengthSurfaceVariant6,
                typeof(global::Terra.StrengthSurfaceVariant6),
                StrengthSurfaceVariant7,
                typeof(global::Terra.StrengthSurfaceVariant7),
                StrengthSurfaceVariant8,
                typeof(global::Terra.StrengthSurfaceVariant8),
                StrengthSurfaceVariant9,
                typeof(global::Terra.StrengthSurfaceVariant9),
                StrengthSurfaceVariant10,
                typeof(global::Terra.StrengthSurfaceVariant10),
                StrengthSurfaceVariant11,
                typeof(global::Terra.StrengthSurfaceVariant11),
                StrengthSurfaceVariant12,
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
        public bool Equals(StrengthSurface other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant1?>.Default.Equals(StrengthSurfaceVariant1, other.StrengthSurfaceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant2?>.Default.Equals(StrengthSurfaceVariant2, other.StrengthSurfaceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant3?>.Default.Equals(StrengthSurfaceVariant3, other.StrengthSurfaceVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant4?>.Default.Equals(StrengthSurfaceVariant4, other.StrengthSurfaceVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant5?>.Default.Equals(StrengthSurfaceVariant5, other.StrengthSurfaceVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant6?>.Default.Equals(StrengthSurfaceVariant6, other.StrengthSurfaceVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant7?>.Default.Equals(StrengthSurfaceVariant7, other.StrengthSurfaceVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant8?>.Default.Equals(StrengthSurfaceVariant8, other.StrengthSurfaceVariant8) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant9?>.Default.Equals(StrengthSurfaceVariant9, other.StrengthSurfaceVariant9) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant10?>.Default.Equals(StrengthSurfaceVariant10, other.StrengthSurfaceVariant10) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSurfaceVariant11?>.Default.Equals(StrengthSurfaceVariant11, other.StrengthSurfaceVariant11) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthSurfaceVariant12, other.StrengthSurfaceVariant12)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthSurface obj1, StrengthSurface obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthSurface>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthSurface obj1, StrengthSurface obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthSurface o && Equals(o);
        }
    }
}

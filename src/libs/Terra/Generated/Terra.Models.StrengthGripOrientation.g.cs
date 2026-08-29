#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Which way the hands face. Separate from grip_width because the two combine. Open enum — handle unknown values gracefully.<br/>
    /// Example: bottoms_up
    /// </summary>
    public readonly partial struct StrengthGripOrientation : global::System.IEquatable<StrengthGripOrientation>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant1? StrengthGripOrientationVariant1 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant1? StrengthGripOrientationVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant1))]
#endif
        public bool IsStrengthGripOrientationVariant1 => StrengthGripOrientationVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant1? value)
        {
            value = StrengthGripOrientationVariant1;
            return IsStrengthGripOrientationVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant1 PickStrengthGripOrientationVariant1() => IsStrengthGripOrientationVariant1
            ? StrengthGripOrientationVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant2? StrengthGripOrientationVariant2 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant2? StrengthGripOrientationVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant2))]
#endif
        public bool IsStrengthGripOrientationVariant2 => StrengthGripOrientationVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant2? value)
        {
            value = StrengthGripOrientationVariant2;
            return IsStrengthGripOrientationVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant2 PickStrengthGripOrientationVariant2() => IsStrengthGripOrientationVariant2
            ? StrengthGripOrientationVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant3? StrengthGripOrientationVariant3 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant3? StrengthGripOrientationVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant3))]
#endif
        public bool IsStrengthGripOrientationVariant3 => StrengthGripOrientationVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant3? value)
        {
            value = StrengthGripOrientationVariant3;
            return IsStrengthGripOrientationVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant3 PickStrengthGripOrientationVariant3() => IsStrengthGripOrientationVariant3
            ? StrengthGripOrientationVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant4? StrengthGripOrientationVariant4 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant4? StrengthGripOrientationVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant4))]
#endif
        public bool IsStrengthGripOrientationVariant4 => StrengthGripOrientationVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant4? value)
        {
            value = StrengthGripOrientationVariant4;
            return IsStrengthGripOrientationVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant4 PickStrengthGripOrientationVariant4() => IsStrengthGripOrientationVariant4
            ? StrengthGripOrientationVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant5? StrengthGripOrientationVariant5 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant5? StrengthGripOrientationVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant5))]
#endif
        public bool IsStrengthGripOrientationVariant5 => StrengthGripOrientationVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant5? value)
        {
            value = StrengthGripOrientationVariant5;
            return IsStrengthGripOrientationVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant5 PickStrengthGripOrientationVariant5() => IsStrengthGripOrientationVariant5
            ? StrengthGripOrientationVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant6? StrengthGripOrientationVariant6 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant6? StrengthGripOrientationVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant6))]
#endif
        public bool IsStrengthGripOrientationVariant6 => StrengthGripOrientationVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant6? value)
        {
            value = StrengthGripOrientationVariant6;
            return IsStrengthGripOrientationVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant6 PickStrengthGripOrientationVariant6() => IsStrengthGripOrientationVariant6
            ? StrengthGripOrientationVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant7? StrengthGripOrientationVariant7 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant7? StrengthGripOrientationVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant7))]
#endif
        public bool IsStrengthGripOrientationVariant7 => StrengthGripOrientationVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant7? value)
        {
            value = StrengthGripOrientationVariant7;
            return IsStrengthGripOrientationVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant7 PickStrengthGripOrientationVariant7() => IsStrengthGripOrientationVariant7
            ? StrengthGripOrientationVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant7' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripOrientationVariant8? StrengthGripOrientationVariant8 { get; init; }
#else
        public global::Terra.StrengthGripOrientationVariant8? StrengthGripOrientationVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant8))]
#endif
        public bool IsStrengthGripOrientationVariant8 => StrengthGripOrientationVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripOrientationVariant8? value)
        {
            value = StrengthGripOrientationVariant8;
            return IsStrengthGripOrientationVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthGripOrientationVariant8 PickStrengthGripOrientationVariant8() => IsStrengthGripOrientationVariant8
            ? StrengthGripOrientationVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant8' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthGripOrientationVariant9 { get; init; }
#else
        public string? StrengthGripOrientationVariant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripOrientationVariant9))]
#endif
        public bool IsStrengthGripOrientationVariant9 => StrengthGripOrientationVariant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthGripOrientationVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthGripOrientationVariant9;
            return IsStrengthGripOrientationVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthGripOrientationVariant9() => IsStrengthGripOrientationVariant9
            ? StrengthGripOrientationVariant9!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripOrientationVariant9' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant1 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant1?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant1? value)
        {
            StrengthGripOrientationVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant1(global::Terra.StrengthGripOrientationVariant1? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant2 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant2?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant2? value)
        {
            StrengthGripOrientationVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant2(global::Terra.StrengthGripOrientationVariant2? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant3 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant3?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant3? value)
        {
            StrengthGripOrientationVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant3(global::Terra.StrengthGripOrientationVariant3? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant4 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant4?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant4? value)
        {
            StrengthGripOrientationVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant4(global::Terra.StrengthGripOrientationVariant4? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant5 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant5?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant5? value)
        {
            StrengthGripOrientationVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant5(global::Terra.StrengthGripOrientationVariant5? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant6 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant6?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant6? value)
        {
            StrengthGripOrientationVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant6(global::Terra.StrengthGripOrientationVariant6? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant7 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant7?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant7? value)
        {
            StrengthGripOrientationVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant7(global::Terra.StrengthGripOrientationVariant7? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant8 value) => new StrengthGripOrientation((global::Terra.StrengthGripOrientationVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthGripOrientationVariant8?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(global::Terra.StrengthGripOrientationVariant8? value)
        {
            StrengthGripOrientationVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant8(global::Terra.StrengthGripOrientationVariant8? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthGripOrientation(string value) => new StrengthGripOrientation((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthGripOrientation @this) => @this.StrengthGripOrientationVariant9;

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(string? value)
        {
            StrengthGripOrientationVariant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthGripOrientation FromStrengthGripOrientationVariant9(string? value) => new StrengthGripOrientation(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthGripOrientation(
            global::Terra.StrengthGripOrientationVariant1? strengthGripOrientationVariant1,
            global::Terra.StrengthGripOrientationVariant2? strengthGripOrientationVariant2,
            global::Terra.StrengthGripOrientationVariant3? strengthGripOrientationVariant3,
            global::Terra.StrengthGripOrientationVariant4? strengthGripOrientationVariant4,
            global::Terra.StrengthGripOrientationVariant5? strengthGripOrientationVariant5,
            global::Terra.StrengthGripOrientationVariant6? strengthGripOrientationVariant6,
            global::Terra.StrengthGripOrientationVariant7? strengthGripOrientationVariant7,
            global::Terra.StrengthGripOrientationVariant8? strengthGripOrientationVariant8,
            string? strengthGripOrientationVariant9
            )
        {
            StrengthGripOrientationVariant1 = strengthGripOrientationVariant1;
            StrengthGripOrientationVariant2 = strengthGripOrientationVariant2;
            StrengthGripOrientationVariant3 = strengthGripOrientationVariant3;
            StrengthGripOrientationVariant4 = strengthGripOrientationVariant4;
            StrengthGripOrientationVariant5 = strengthGripOrientationVariant5;
            StrengthGripOrientationVariant6 = strengthGripOrientationVariant6;
            StrengthGripOrientationVariant7 = strengthGripOrientationVariant7;
            StrengthGripOrientationVariant8 = strengthGripOrientationVariant8;
            StrengthGripOrientationVariant9 = strengthGripOrientationVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthGripOrientationVariant9 as object ??
            StrengthGripOrientationVariant8 as object ??
            StrengthGripOrientationVariant7 as object ??
            StrengthGripOrientationVariant6 as object ??
            StrengthGripOrientationVariant5 as object ??
            StrengthGripOrientationVariant4 as object ??
            StrengthGripOrientationVariant3 as object ??
            StrengthGripOrientationVariant2 as object ??
            StrengthGripOrientationVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthGripOrientationVariant1?.ToValueString() ??
            StrengthGripOrientationVariant2?.ToValueString() ??
            StrengthGripOrientationVariant3?.ToValueString() ??
            StrengthGripOrientationVariant4?.ToValueString() ??
            StrengthGripOrientationVariant5?.ToValueString() ??
            StrengthGripOrientationVariant6?.ToValueString() ??
            StrengthGripOrientationVariant7?.ToValueString() ??
            StrengthGripOrientationVariant8?.ToValueString() ??
            StrengthGripOrientationVariant9?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthGripOrientationVariant1 || IsStrengthGripOrientationVariant2 || IsStrengthGripOrientationVariant3 || IsStrengthGripOrientationVariant4 || IsStrengthGripOrientationVariant5 || IsStrengthGripOrientationVariant6 || IsStrengthGripOrientationVariant7 || IsStrengthGripOrientationVariant8 || IsStrengthGripOrientationVariant9;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthGripOrientationVariant1?, TResult>? strengthGripOrientationVariant1 = null,
            global::System.Func<global::Terra.StrengthGripOrientationVariant2?, TResult>? strengthGripOrientationVariant2 = null,
            global::System.Func<global::Terra.StrengthGripOrientationVariant3?, TResult>? strengthGripOrientationVariant3 = null,
            global::System.Func<global::Terra.StrengthGripOrientationVariant4?, TResult>? strengthGripOrientationVariant4 = null,
            global::System.Func<global::Terra.StrengthGripOrientationVariant5?, TResult>? strengthGripOrientationVariant5 = null,
            global::System.Func<global::Terra.StrengthGripOrientationVariant6?, TResult>? strengthGripOrientationVariant6 = null,
            global::System.Func<global::Terra.StrengthGripOrientationVariant7?, TResult>? strengthGripOrientationVariant7 = null,
            global::System.Func<global::Terra.StrengthGripOrientationVariant8?, TResult>? strengthGripOrientationVariant8 = null,
            global::System.Func<string, TResult>? strengthGripOrientationVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthGripOrientationVariant1 && strengthGripOrientationVariant1 != null)
            {
                return strengthGripOrientationVariant1(StrengthGripOrientationVariant1!);
            }
            else if (IsStrengthGripOrientationVariant2 && strengthGripOrientationVariant2 != null)
            {
                return strengthGripOrientationVariant2(StrengthGripOrientationVariant2!);
            }
            else if (IsStrengthGripOrientationVariant3 && strengthGripOrientationVariant3 != null)
            {
                return strengthGripOrientationVariant3(StrengthGripOrientationVariant3!);
            }
            else if (IsStrengthGripOrientationVariant4 && strengthGripOrientationVariant4 != null)
            {
                return strengthGripOrientationVariant4(StrengthGripOrientationVariant4!);
            }
            else if (IsStrengthGripOrientationVariant5 && strengthGripOrientationVariant5 != null)
            {
                return strengthGripOrientationVariant5(StrengthGripOrientationVariant5!);
            }
            else if (IsStrengthGripOrientationVariant6 && strengthGripOrientationVariant6 != null)
            {
                return strengthGripOrientationVariant6(StrengthGripOrientationVariant6!);
            }
            else if (IsStrengthGripOrientationVariant7 && strengthGripOrientationVariant7 != null)
            {
                return strengthGripOrientationVariant7(StrengthGripOrientationVariant7!);
            }
            else if (IsStrengthGripOrientationVariant8 && strengthGripOrientationVariant8 != null)
            {
                return strengthGripOrientationVariant8(StrengthGripOrientationVariant8!);
            }
            else if (IsStrengthGripOrientationVariant9 && strengthGripOrientationVariant9 != null)
            {
                return strengthGripOrientationVariant9(StrengthGripOrientationVariant9!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthGripOrientationVariant1?>? strengthGripOrientationVariant1 = null,

            global::System.Action<global::Terra.StrengthGripOrientationVariant2?>? strengthGripOrientationVariant2 = null,

            global::System.Action<global::Terra.StrengthGripOrientationVariant3?>? strengthGripOrientationVariant3 = null,

            global::System.Action<global::Terra.StrengthGripOrientationVariant4?>? strengthGripOrientationVariant4 = null,

            global::System.Action<global::Terra.StrengthGripOrientationVariant5?>? strengthGripOrientationVariant5 = null,

            global::System.Action<global::Terra.StrengthGripOrientationVariant6?>? strengthGripOrientationVariant6 = null,

            global::System.Action<global::Terra.StrengthGripOrientationVariant7?>? strengthGripOrientationVariant7 = null,

            global::System.Action<global::Terra.StrengthGripOrientationVariant8?>? strengthGripOrientationVariant8 = null,

            global::System.Action<string>? strengthGripOrientationVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthGripOrientationVariant1)
            {
                strengthGripOrientationVariant1?.Invoke(StrengthGripOrientationVariant1!);
            }
            else if (IsStrengthGripOrientationVariant2)
            {
                strengthGripOrientationVariant2?.Invoke(StrengthGripOrientationVariant2!);
            }
            else if (IsStrengthGripOrientationVariant3)
            {
                strengthGripOrientationVariant3?.Invoke(StrengthGripOrientationVariant3!);
            }
            else if (IsStrengthGripOrientationVariant4)
            {
                strengthGripOrientationVariant4?.Invoke(StrengthGripOrientationVariant4!);
            }
            else if (IsStrengthGripOrientationVariant5)
            {
                strengthGripOrientationVariant5?.Invoke(StrengthGripOrientationVariant5!);
            }
            else if (IsStrengthGripOrientationVariant6)
            {
                strengthGripOrientationVariant6?.Invoke(StrengthGripOrientationVariant6!);
            }
            else if (IsStrengthGripOrientationVariant7)
            {
                strengthGripOrientationVariant7?.Invoke(StrengthGripOrientationVariant7!);
            }
            else if (IsStrengthGripOrientationVariant8)
            {
                strengthGripOrientationVariant8?.Invoke(StrengthGripOrientationVariant8!);
            }
            else if (IsStrengthGripOrientationVariant9)
            {
                strengthGripOrientationVariant9?.Invoke(StrengthGripOrientationVariant9!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthGripOrientationVariant1?>? strengthGripOrientationVariant1 = null,
            global::System.Action<global::Terra.StrengthGripOrientationVariant2?>? strengthGripOrientationVariant2 = null,
            global::System.Action<global::Terra.StrengthGripOrientationVariant3?>? strengthGripOrientationVariant3 = null,
            global::System.Action<global::Terra.StrengthGripOrientationVariant4?>? strengthGripOrientationVariant4 = null,
            global::System.Action<global::Terra.StrengthGripOrientationVariant5?>? strengthGripOrientationVariant5 = null,
            global::System.Action<global::Terra.StrengthGripOrientationVariant6?>? strengthGripOrientationVariant6 = null,
            global::System.Action<global::Terra.StrengthGripOrientationVariant7?>? strengthGripOrientationVariant7 = null,
            global::System.Action<global::Terra.StrengthGripOrientationVariant8?>? strengthGripOrientationVariant8 = null,
            global::System.Action<string>? strengthGripOrientationVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthGripOrientationVariant1)
            {
                strengthGripOrientationVariant1?.Invoke(StrengthGripOrientationVariant1!);
            }
            else if (IsStrengthGripOrientationVariant2)
            {
                strengthGripOrientationVariant2?.Invoke(StrengthGripOrientationVariant2!);
            }
            else if (IsStrengthGripOrientationVariant3)
            {
                strengthGripOrientationVariant3?.Invoke(StrengthGripOrientationVariant3!);
            }
            else if (IsStrengthGripOrientationVariant4)
            {
                strengthGripOrientationVariant4?.Invoke(StrengthGripOrientationVariant4!);
            }
            else if (IsStrengthGripOrientationVariant5)
            {
                strengthGripOrientationVariant5?.Invoke(StrengthGripOrientationVariant5!);
            }
            else if (IsStrengthGripOrientationVariant6)
            {
                strengthGripOrientationVariant6?.Invoke(StrengthGripOrientationVariant6!);
            }
            else if (IsStrengthGripOrientationVariant7)
            {
                strengthGripOrientationVariant7?.Invoke(StrengthGripOrientationVariant7!);
            }
            else if (IsStrengthGripOrientationVariant8)
            {
                strengthGripOrientationVariant8?.Invoke(StrengthGripOrientationVariant8!);
            }
            else if (IsStrengthGripOrientationVariant9)
            {
                strengthGripOrientationVariant9?.Invoke(StrengthGripOrientationVariant9!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthGripOrientationVariant1,
                typeof(global::Terra.StrengthGripOrientationVariant1),
                StrengthGripOrientationVariant2,
                typeof(global::Terra.StrengthGripOrientationVariant2),
                StrengthGripOrientationVariant3,
                typeof(global::Terra.StrengthGripOrientationVariant3),
                StrengthGripOrientationVariant4,
                typeof(global::Terra.StrengthGripOrientationVariant4),
                StrengthGripOrientationVariant5,
                typeof(global::Terra.StrengthGripOrientationVariant5),
                StrengthGripOrientationVariant6,
                typeof(global::Terra.StrengthGripOrientationVariant6),
                StrengthGripOrientationVariant7,
                typeof(global::Terra.StrengthGripOrientationVariant7),
                StrengthGripOrientationVariant8,
                typeof(global::Terra.StrengthGripOrientationVariant8),
                StrengthGripOrientationVariant9,
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
        public bool Equals(StrengthGripOrientation other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant1?>.Default.Equals(StrengthGripOrientationVariant1, other.StrengthGripOrientationVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant2?>.Default.Equals(StrengthGripOrientationVariant2, other.StrengthGripOrientationVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant3?>.Default.Equals(StrengthGripOrientationVariant3, other.StrengthGripOrientationVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant4?>.Default.Equals(StrengthGripOrientationVariant4, other.StrengthGripOrientationVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant5?>.Default.Equals(StrengthGripOrientationVariant5, other.StrengthGripOrientationVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant6?>.Default.Equals(StrengthGripOrientationVariant6, other.StrengthGripOrientationVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant7?>.Default.Equals(StrengthGripOrientationVariant7, other.StrengthGripOrientationVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripOrientationVariant8?>.Default.Equals(StrengthGripOrientationVariant8, other.StrengthGripOrientationVariant8) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthGripOrientationVariant9, other.StrengthGripOrientationVariant9)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthGripOrientation obj1, StrengthGripOrientation obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthGripOrientation>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthGripOrientation obj1, StrengthGripOrientation obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthGripOrientation o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// How much of the movement is performed, or where it starts. Open enum — handle unknown values gracefully.<br/>
    /// Example: deficit
    /// </summary>
    public readonly partial struct StrengthRangeOfMotion : global::System.IEquatable<StrengthRangeOfMotion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthRangeOfMotionVariant1? StrengthRangeOfMotionVariant1 { get; init; }
#else
        public global::Terra.StrengthRangeOfMotionVariant1? StrengthRangeOfMotionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant1))]
#endif
        public bool IsStrengthRangeOfMotionVariant1 => StrengthRangeOfMotionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthRangeOfMotionVariant1? value)
        {
            value = StrengthRangeOfMotionVariant1;
            return IsStrengthRangeOfMotionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant1 PickStrengthRangeOfMotionVariant1() => IsStrengthRangeOfMotionVariant1
            ? StrengthRangeOfMotionVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthRangeOfMotionVariant2? StrengthRangeOfMotionVariant2 { get; init; }
#else
        public global::Terra.StrengthRangeOfMotionVariant2? StrengthRangeOfMotionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant2))]
#endif
        public bool IsStrengthRangeOfMotionVariant2 => StrengthRangeOfMotionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthRangeOfMotionVariant2? value)
        {
            value = StrengthRangeOfMotionVariant2;
            return IsStrengthRangeOfMotionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant2 PickStrengthRangeOfMotionVariant2() => IsStrengthRangeOfMotionVariant2
            ? StrengthRangeOfMotionVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthRangeOfMotionVariant3? StrengthRangeOfMotionVariant3 { get; init; }
#else
        public global::Terra.StrengthRangeOfMotionVariant3? StrengthRangeOfMotionVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant3))]
#endif
        public bool IsStrengthRangeOfMotionVariant3 => StrengthRangeOfMotionVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthRangeOfMotionVariant3? value)
        {
            value = StrengthRangeOfMotionVariant3;
            return IsStrengthRangeOfMotionVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant3 PickStrengthRangeOfMotionVariant3() => IsStrengthRangeOfMotionVariant3
            ? StrengthRangeOfMotionVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthRangeOfMotionVariant4? StrengthRangeOfMotionVariant4 { get; init; }
#else
        public global::Terra.StrengthRangeOfMotionVariant4? StrengthRangeOfMotionVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant4))]
#endif
        public bool IsStrengthRangeOfMotionVariant4 => StrengthRangeOfMotionVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthRangeOfMotionVariant4? value)
        {
            value = StrengthRangeOfMotionVariant4;
            return IsStrengthRangeOfMotionVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant4 PickStrengthRangeOfMotionVariant4() => IsStrengthRangeOfMotionVariant4
            ? StrengthRangeOfMotionVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthRangeOfMotionVariant5? StrengthRangeOfMotionVariant5 { get; init; }
#else
        public global::Terra.StrengthRangeOfMotionVariant5? StrengthRangeOfMotionVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant5))]
#endif
        public bool IsStrengthRangeOfMotionVariant5 => StrengthRangeOfMotionVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthRangeOfMotionVariant5? value)
        {
            value = StrengthRangeOfMotionVariant5;
            return IsStrengthRangeOfMotionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant5 PickStrengthRangeOfMotionVariant5() => IsStrengthRangeOfMotionVariant5
            ? StrengthRangeOfMotionVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthRangeOfMotionVariant6? StrengthRangeOfMotionVariant6 { get; init; }
#else
        public global::Terra.StrengthRangeOfMotionVariant6? StrengthRangeOfMotionVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant6))]
#endif
        public bool IsStrengthRangeOfMotionVariant6 => StrengthRangeOfMotionVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthRangeOfMotionVariant6? value)
        {
            value = StrengthRangeOfMotionVariant6;
            return IsStrengthRangeOfMotionVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant6 PickStrengthRangeOfMotionVariant6() => IsStrengthRangeOfMotionVariant6
            ? StrengthRangeOfMotionVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant6' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthRangeOfMotionVariant7? StrengthRangeOfMotionVariant7 { get; init; }
#else
        public global::Terra.StrengthRangeOfMotionVariant7? StrengthRangeOfMotionVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant7))]
#endif
        public bool IsStrengthRangeOfMotionVariant7 => StrengthRangeOfMotionVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthRangeOfMotionVariant7? value)
        {
            value = StrengthRangeOfMotionVariant7;
            return IsStrengthRangeOfMotionVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthRangeOfMotionVariant7 PickStrengthRangeOfMotionVariant7() => IsStrengthRangeOfMotionVariant7
            ? StrengthRangeOfMotionVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant7' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthRangeOfMotionVariant8 { get; init; }
#else
        public string? StrengthRangeOfMotionVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthRangeOfMotionVariant8))]
#endif
        public bool IsStrengthRangeOfMotionVariant8 => StrengthRangeOfMotionVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthRangeOfMotionVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthRangeOfMotionVariant8;
            return IsStrengthRangeOfMotionVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthRangeOfMotionVariant8() => IsStrengthRangeOfMotionVariant8
            ? StrengthRangeOfMotionVariant8!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthRangeOfMotionVariant8' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant1 value) => new StrengthRangeOfMotion((global::Terra.StrengthRangeOfMotionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthRangeOfMotionVariant1?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant1? value)
        {
            StrengthRangeOfMotionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant1(global::Terra.StrengthRangeOfMotionVariant1? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant2 value) => new StrengthRangeOfMotion((global::Terra.StrengthRangeOfMotionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthRangeOfMotionVariant2?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant2? value)
        {
            StrengthRangeOfMotionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant2(global::Terra.StrengthRangeOfMotionVariant2? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant3 value) => new StrengthRangeOfMotion((global::Terra.StrengthRangeOfMotionVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthRangeOfMotionVariant3?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant3? value)
        {
            StrengthRangeOfMotionVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant3(global::Terra.StrengthRangeOfMotionVariant3? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant4 value) => new StrengthRangeOfMotion((global::Terra.StrengthRangeOfMotionVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthRangeOfMotionVariant4?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant4? value)
        {
            StrengthRangeOfMotionVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant4(global::Terra.StrengthRangeOfMotionVariant4? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant5 value) => new StrengthRangeOfMotion((global::Terra.StrengthRangeOfMotionVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthRangeOfMotionVariant5?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant5? value)
        {
            StrengthRangeOfMotionVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant5(global::Terra.StrengthRangeOfMotionVariant5? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant6 value) => new StrengthRangeOfMotion((global::Terra.StrengthRangeOfMotionVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthRangeOfMotionVariant6?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant6? value)
        {
            StrengthRangeOfMotionVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant6(global::Terra.StrengthRangeOfMotionVariant6? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant7 value) => new StrengthRangeOfMotion((global::Terra.StrengthRangeOfMotionVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthRangeOfMotionVariant7?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(global::Terra.StrengthRangeOfMotionVariant7? value)
        {
            StrengthRangeOfMotionVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant7(global::Terra.StrengthRangeOfMotionVariant7? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthRangeOfMotion(string value) => new StrengthRangeOfMotion((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthRangeOfMotion @this) => @this.StrengthRangeOfMotionVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(string? value)
        {
            StrengthRangeOfMotionVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthRangeOfMotion FromStrengthRangeOfMotionVariant8(string? value) => new StrengthRangeOfMotion(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthRangeOfMotion(
            global::Terra.StrengthRangeOfMotionVariant1? strengthRangeOfMotionVariant1,
            global::Terra.StrengthRangeOfMotionVariant2? strengthRangeOfMotionVariant2,
            global::Terra.StrengthRangeOfMotionVariant3? strengthRangeOfMotionVariant3,
            global::Terra.StrengthRangeOfMotionVariant4? strengthRangeOfMotionVariant4,
            global::Terra.StrengthRangeOfMotionVariant5? strengthRangeOfMotionVariant5,
            global::Terra.StrengthRangeOfMotionVariant6? strengthRangeOfMotionVariant6,
            global::Terra.StrengthRangeOfMotionVariant7? strengthRangeOfMotionVariant7,
            string? strengthRangeOfMotionVariant8
            )
        {
            StrengthRangeOfMotionVariant1 = strengthRangeOfMotionVariant1;
            StrengthRangeOfMotionVariant2 = strengthRangeOfMotionVariant2;
            StrengthRangeOfMotionVariant3 = strengthRangeOfMotionVariant3;
            StrengthRangeOfMotionVariant4 = strengthRangeOfMotionVariant4;
            StrengthRangeOfMotionVariant5 = strengthRangeOfMotionVariant5;
            StrengthRangeOfMotionVariant6 = strengthRangeOfMotionVariant6;
            StrengthRangeOfMotionVariant7 = strengthRangeOfMotionVariant7;
            StrengthRangeOfMotionVariant8 = strengthRangeOfMotionVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthRangeOfMotionVariant8 as object ??
            StrengthRangeOfMotionVariant7 as object ??
            StrengthRangeOfMotionVariant6 as object ??
            StrengthRangeOfMotionVariant5 as object ??
            StrengthRangeOfMotionVariant4 as object ??
            StrengthRangeOfMotionVariant3 as object ??
            StrengthRangeOfMotionVariant2 as object ??
            StrengthRangeOfMotionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthRangeOfMotionVariant1?.ToValueString() ??
            StrengthRangeOfMotionVariant2?.ToValueString() ??
            StrengthRangeOfMotionVariant3?.ToValueString() ??
            StrengthRangeOfMotionVariant4?.ToValueString() ??
            StrengthRangeOfMotionVariant5?.ToValueString() ??
            StrengthRangeOfMotionVariant6?.ToValueString() ??
            StrengthRangeOfMotionVariant7?.ToValueString() ??
            StrengthRangeOfMotionVariant8?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthRangeOfMotionVariant1 || IsStrengthRangeOfMotionVariant2 || IsStrengthRangeOfMotionVariant3 || IsStrengthRangeOfMotionVariant4 || IsStrengthRangeOfMotionVariant5 || IsStrengthRangeOfMotionVariant6 || IsStrengthRangeOfMotionVariant7 || IsStrengthRangeOfMotionVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthRangeOfMotionVariant1?, TResult>? strengthRangeOfMotionVariant1 = null,
            global::System.Func<global::Terra.StrengthRangeOfMotionVariant2?, TResult>? strengthRangeOfMotionVariant2 = null,
            global::System.Func<global::Terra.StrengthRangeOfMotionVariant3?, TResult>? strengthRangeOfMotionVariant3 = null,
            global::System.Func<global::Terra.StrengthRangeOfMotionVariant4?, TResult>? strengthRangeOfMotionVariant4 = null,
            global::System.Func<global::Terra.StrengthRangeOfMotionVariant5?, TResult>? strengthRangeOfMotionVariant5 = null,
            global::System.Func<global::Terra.StrengthRangeOfMotionVariant6?, TResult>? strengthRangeOfMotionVariant6 = null,
            global::System.Func<global::Terra.StrengthRangeOfMotionVariant7?, TResult>? strengthRangeOfMotionVariant7 = null,
            global::System.Func<string, TResult>? strengthRangeOfMotionVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthRangeOfMotionVariant1 && strengthRangeOfMotionVariant1 != null)
            {
                return strengthRangeOfMotionVariant1(StrengthRangeOfMotionVariant1!);
            }
            else if (IsStrengthRangeOfMotionVariant2 && strengthRangeOfMotionVariant2 != null)
            {
                return strengthRangeOfMotionVariant2(StrengthRangeOfMotionVariant2!);
            }
            else if (IsStrengthRangeOfMotionVariant3 && strengthRangeOfMotionVariant3 != null)
            {
                return strengthRangeOfMotionVariant3(StrengthRangeOfMotionVariant3!);
            }
            else if (IsStrengthRangeOfMotionVariant4 && strengthRangeOfMotionVariant4 != null)
            {
                return strengthRangeOfMotionVariant4(StrengthRangeOfMotionVariant4!);
            }
            else if (IsStrengthRangeOfMotionVariant5 && strengthRangeOfMotionVariant5 != null)
            {
                return strengthRangeOfMotionVariant5(StrengthRangeOfMotionVariant5!);
            }
            else if (IsStrengthRangeOfMotionVariant6 && strengthRangeOfMotionVariant6 != null)
            {
                return strengthRangeOfMotionVariant6(StrengthRangeOfMotionVariant6!);
            }
            else if (IsStrengthRangeOfMotionVariant7 && strengthRangeOfMotionVariant7 != null)
            {
                return strengthRangeOfMotionVariant7(StrengthRangeOfMotionVariant7!);
            }
            else if (IsStrengthRangeOfMotionVariant8 && strengthRangeOfMotionVariant8 != null)
            {
                return strengthRangeOfMotionVariant8(StrengthRangeOfMotionVariant8!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant1?>? strengthRangeOfMotionVariant1 = null,

            global::System.Action<global::Terra.StrengthRangeOfMotionVariant2?>? strengthRangeOfMotionVariant2 = null,

            global::System.Action<global::Terra.StrengthRangeOfMotionVariant3?>? strengthRangeOfMotionVariant3 = null,

            global::System.Action<global::Terra.StrengthRangeOfMotionVariant4?>? strengthRangeOfMotionVariant4 = null,

            global::System.Action<global::Terra.StrengthRangeOfMotionVariant5?>? strengthRangeOfMotionVariant5 = null,

            global::System.Action<global::Terra.StrengthRangeOfMotionVariant6?>? strengthRangeOfMotionVariant6 = null,

            global::System.Action<global::Terra.StrengthRangeOfMotionVariant7?>? strengthRangeOfMotionVariant7 = null,

            global::System.Action<string>? strengthRangeOfMotionVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthRangeOfMotionVariant1)
            {
                strengthRangeOfMotionVariant1?.Invoke(StrengthRangeOfMotionVariant1!);
            }
            else if (IsStrengthRangeOfMotionVariant2)
            {
                strengthRangeOfMotionVariant2?.Invoke(StrengthRangeOfMotionVariant2!);
            }
            else if (IsStrengthRangeOfMotionVariant3)
            {
                strengthRangeOfMotionVariant3?.Invoke(StrengthRangeOfMotionVariant3!);
            }
            else if (IsStrengthRangeOfMotionVariant4)
            {
                strengthRangeOfMotionVariant4?.Invoke(StrengthRangeOfMotionVariant4!);
            }
            else if (IsStrengthRangeOfMotionVariant5)
            {
                strengthRangeOfMotionVariant5?.Invoke(StrengthRangeOfMotionVariant5!);
            }
            else if (IsStrengthRangeOfMotionVariant6)
            {
                strengthRangeOfMotionVariant6?.Invoke(StrengthRangeOfMotionVariant6!);
            }
            else if (IsStrengthRangeOfMotionVariant7)
            {
                strengthRangeOfMotionVariant7?.Invoke(StrengthRangeOfMotionVariant7!);
            }
            else if (IsStrengthRangeOfMotionVariant8)
            {
                strengthRangeOfMotionVariant8?.Invoke(StrengthRangeOfMotionVariant8!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant1?>? strengthRangeOfMotionVariant1 = null,
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant2?>? strengthRangeOfMotionVariant2 = null,
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant3?>? strengthRangeOfMotionVariant3 = null,
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant4?>? strengthRangeOfMotionVariant4 = null,
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant5?>? strengthRangeOfMotionVariant5 = null,
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant6?>? strengthRangeOfMotionVariant6 = null,
            global::System.Action<global::Terra.StrengthRangeOfMotionVariant7?>? strengthRangeOfMotionVariant7 = null,
            global::System.Action<string>? strengthRangeOfMotionVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthRangeOfMotionVariant1)
            {
                strengthRangeOfMotionVariant1?.Invoke(StrengthRangeOfMotionVariant1!);
            }
            else if (IsStrengthRangeOfMotionVariant2)
            {
                strengthRangeOfMotionVariant2?.Invoke(StrengthRangeOfMotionVariant2!);
            }
            else if (IsStrengthRangeOfMotionVariant3)
            {
                strengthRangeOfMotionVariant3?.Invoke(StrengthRangeOfMotionVariant3!);
            }
            else if (IsStrengthRangeOfMotionVariant4)
            {
                strengthRangeOfMotionVariant4?.Invoke(StrengthRangeOfMotionVariant4!);
            }
            else if (IsStrengthRangeOfMotionVariant5)
            {
                strengthRangeOfMotionVariant5?.Invoke(StrengthRangeOfMotionVariant5!);
            }
            else if (IsStrengthRangeOfMotionVariant6)
            {
                strengthRangeOfMotionVariant6?.Invoke(StrengthRangeOfMotionVariant6!);
            }
            else if (IsStrengthRangeOfMotionVariant7)
            {
                strengthRangeOfMotionVariant7?.Invoke(StrengthRangeOfMotionVariant7!);
            }
            else if (IsStrengthRangeOfMotionVariant8)
            {
                strengthRangeOfMotionVariant8?.Invoke(StrengthRangeOfMotionVariant8!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthRangeOfMotionVariant1,
                typeof(global::Terra.StrengthRangeOfMotionVariant1),
                StrengthRangeOfMotionVariant2,
                typeof(global::Terra.StrengthRangeOfMotionVariant2),
                StrengthRangeOfMotionVariant3,
                typeof(global::Terra.StrengthRangeOfMotionVariant3),
                StrengthRangeOfMotionVariant4,
                typeof(global::Terra.StrengthRangeOfMotionVariant4),
                StrengthRangeOfMotionVariant5,
                typeof(global::Terra.StrengthRangeOfMotionVariant5),
                StrengthRangeOfMotionVariant6,
                typeof(global::Terra.StrengthRangeOfMotionVariant6),
                StrengthRangeOfMotionVariant7,
                typeof(global::Terra.StrengthRangeOfMotionVariant7),
                StrengthRangeOfMotionVariant8,
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
        public bool Equals(StrengthRangeOfMotion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthRangeOfMotionVariant1?>.Default.Equals(StrengthRangeOfMotionVariant1, other.StrengthRangeOfMotionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthRangeOfMotionVariant2?>.Default.Equals(StrengthRangeOfMotionVariant2, other.StrengthRangeOfMotionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthRangeOfMotionVariant3?>.Default.Equals(StrengthRangeOfMotionVariant3, other.StrengthRangeOfMotionVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthRangeOfMotionVariant4?>.Default.Equals(StrengthRangeOfMotionVariant4, other.StrengthRangeOfMotionVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthRangeOfMotionVariant5?>.Default.Equals(StrengthRangeOfMotionVariant5, other.StrengthRangeOfMotionVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthRangeOfMotionVariant6?>.Default.Equals(StrengthRangeOfMotionVariant6, other.StrengthRangeOfMotionVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthRangeOfMotionVariant7?>.Default.Equals(StrengthRangeOfMotionVariant7, other.StrengthRangeOfMotionVariant7) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthRangeOfMotionVariant8, other.StrengthRangeOfMotionVariant8)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthRangeOfMotion obj1, StrengthRangeOfMotion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthRangeOfMotion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthRangeOfMotion obj1, StrengthRangeOfMotion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthRangeOfMotion o && Equals(o);
        }
    }
}

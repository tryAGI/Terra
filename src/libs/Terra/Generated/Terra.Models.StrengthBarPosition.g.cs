#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Where the implement is carried. Open enum — handle unknown values gracefully.<br/>
    /// Example: behind_back
    /// </summary>
    public readonly partial struct StrengthBarPosition : global::System.IEquatable<StrengthBarPosition>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthBarPositionVariant1? StrengthBarPositionVariant1 { get; init; }
#else
        public global::Terra.StrengthBarPositionVariant1? StrengthBarPositionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant1))]
#endif
        public bool IsStrengthBarPositionVariant1 => StrengthBarPositionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthBarPositionVariant1? value)
        {
            value = StrengthBarPositionVariant1;
            return IsStrengthBarPositionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant1 PickStrengthBarPositionVariant1() => IsStrengthBarPositionVariant1
            ? StrengthBarPositionVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthBarPositionVariant2? StrengthBarPositionVariant2 { get; init; }
#else
        public global::Terra.StrengthBarPositionVariant2? StrengthBarPositionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant2))]
#endif
        public bool IsStrengthBarPositionVariant2 => StrengthBarPositionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthBarPositionVariant2? value)
        {
            value = StrengthBarPositionVariant2;
            return IsStrengthBarPositionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant2 PickStrengthBarPositionVariant2() => IsStrengthBarPositionVariant2
            ? StrengthBarPositionVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthBarPositionVariant3? StrengthBarPositionVariant3 { get; init; }
#else
        public global::Terra.StrengthBarPositionVariant3? StrengthBarPositionVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant3))]
#endif
        public bool IsStrengthBarPositionVariant3 => StrengthBarPositionVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthBarPositionVariant3? value)
        {
            value = StrengthBarPositionVariant3;
            return IsStrengthBarPositionVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant3 PickStrengthBarPositionVariant3() => IsStrengthBarPositionVariant3
            ? StrengthBarPositionVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthBarPositionVariant4? StrengthBarPositionVariant4 { get; init; }
#else
        public global::Terra.StrengthBarPositionVariant4? StrengthBarPositionVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant4))]
#endif
        public bool IsStrengthBarPositionVariant4 => StrengthBarPositionVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthBarPositionVariant4? value)
        {
            value = StrengthBarPositionVariant4;
            return IsStrengthBarPositionVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant4 PickStrengthBarPositionVariant4() => IsStrengthBarPositionVariant4
            ? StrengthBarPositionVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthBarPositionVariant5? StrengthBarPositionVariant5 { get; init; }
#else
        public global::Terra.StrengthBarPositionVariant5? StrengthBarPositionVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant5))]
#endif
        public bool IsStrengthBarPositionVariant5 => StrengthBarPositionVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthBarPositionVariant5? value)
        {
            value = StrengthBarPositionVariant5;
            return IsStrengthBarPositionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant5 PickStrengthBarPositionVariant5() => IsStrengthBarPositionVariant5
            ? StrengthBarPositionVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthBarPositionVariant6? StrengthBarPositionVariant6 { get; init; }
#else
        public global::Terra.StrengthBarPositionVariant6? StrengthBarPositionVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant6))]
#endif
        public bool IsStrengthBarPositionVariant6 => StrengthBarPositionVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthBarPositionVariant6? value)
        {
            value = StrengthBarPositionVariant6;
            return IsStrengthBarPositionVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant6 PickStrengthBarPositionVariant6() => IsStrengthBarPositionVariant6
            ? StrengthBarPositionVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant6' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthBarPositionVariant7? StrengthBarPositionVariant7 { get; init; }
#else
        public global::Terra.StrengthBarPositionVariant7? StrengthBarPositionVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant7))]
#endif
        public bool IsStrengthBarPositionVariant7 => StrengthBarPositionVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthBarPositionVariant7? value)
        {
            value = StrengthBarPositionVariant7;
            return IsStrengthBarPositionVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthBarPositionVariant7 PickStrengthBarPositionVariant7() => IsStrengthBarPositionVariant7
            ? StrengthBarPositionVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant7' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthBarPositionVariant8 { get; init; }
#else
        public string? StrengthBarPositionVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthBarPositionVariant8))]
#endif
        public bool IsStrengthBarPositionVariant8 => StrengthBarPositionVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthBarPositionVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthBarPositionVariant8;
            return IsStrengthBarPositionVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthBarPositionVariant8() => IsStrengthBarPositionVariant8
            ? StrengthBarPositionVariant8!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthBarPositionVariant8' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(global::Terra.StrengthBarPositionVariant1 value) => new StrengthBarPosition((global::Terra.StrengthBarPositionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthBarPositionVariant1?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(global::Terra.StrengthBarPositionVariant1? value)
        {
            StrengthBarPositionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant1(global::Terra.StrengthBarPositionVariant1? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(global::Terra.StrengthBarPositionVariant2 value) => new StrengthBarPosition((global::Terra.StrengthBarPositionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthBarPositionVariant2?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(global::Terra.StrengthBarPositionVariant2? value)
        {
            StrengthBarPositionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant2(global::Terra.StrengthBarPositionVariant2? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(global::Terra.StrengthBarPositionVariant3 value) => new StrengthBarPosition((global::Terra.StrengthBarPositionVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthBarPositionVariant3?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(global::Terra.StrengthBarPositionVariant3? value)
        {
            StrengthBarPositionVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant3(global::Terra.StrengthBarPositionVariant3? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(global::Terra.StrengthBarPositionVariant4 value) => new StrengthBarPosition((global::Terra.StrengthBarPositionVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthBarPositionVariant4?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(global::Terra.StrengthBarPositionVariant4? value)
        {
            StrengthBarPositionVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant4(global::Terra.StrengthBarPositionVariant4? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(global::Terra.StrengthBarPositionVariant5 value) => new StrengthBarPosition((global::Terra.StrengthBarPositionVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthBarPositionVariant5?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(global::Terra.StrengthBarPositionVariant5? value)
        {
            StrengthBarPositionVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant5(global::Terra.StrengthBarPositionVariant5? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(global::Terra.StrengthBarPositionVariant6 value) => new StrengthBarPosition((global::Terra.StrengthBarPositionVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthBarPositionVariant6?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(global::Terra.StrengthBarPositionVariant6? value)
        {
            StrengthBarPositionVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant6(global::Terra.StrengthBarPositionVariant6? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(global::Terra.StrengthBarPositionVariant7 value) => new StrengthBarPosition((global::Terra.StrengthBarPositionVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthBarPositionVariant7?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(global::Terra.StrengthBarPositionVariant7? value)
        {
            StrengthBarPositionVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant7(global::Terra.StrengthBarPositionVariant7? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthBarPosition(string value) => new StrengthBarPosition((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthBarPosition @this) => @this.StrengthBarPositionVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(string? value)
        {
            StrengthBarPositionVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthBarPosition FromStrengthBarPositionVariant8(string? value) => new StrengthBarPosition(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthBarPosition(
            global::Terra.StrengthBarPositionVariant1? strengthBarPositionVariant1,
            global::Terra.StrengthBarPositionVariant2? strengthBarPositionVariant2,
            global::Terra.StrengthBarPositionVariant3? strengthBarPositionVariant3,
            global::Terra.StrengthBarPositionVariant4? strengthBarPositionVariant4,
            global::Terra.StrengthBarPositionVariant5? strengthBarPositionVariant5,
            global::Terra.StrengthBarPositionVariant6? strengthBarPositionVariant6,
            global::Terra.StrengthBarPositionVariant7? strengthBarPositionVariant7,
            string? strengthBarPositionVariant8
            )
        {
            StrengthBarPositionVariant1 = strengthBarPositionVariant1;
            StrengthBarPositionVariant2 = strengthBarPositionVariant2;
            StrengthBarPositionVariant3 = strengthBarPositionVariant3;
            StrengthBarPositionVariant4 = strengthBarPositionVariant4;
            StrengthBarPositionVariant5 = strengthBarPositionVariant5;
            StrengthBarPositionVariant6 = strengthBarPositionVariant6;
            StrengthBarPositionVariant7 = strengthBarPositionVariant7;
            StrengthBarPositionVariant8 = strengthBarPositionVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthBarPositionVariant8 as object ??
            StrengthBarPositionVariant7 as object ??
            StrengthBarPositionVariant6 as object ??
            StrengthBarPositionVariant5 as object ??
            StrengthBarPositionVariant4 as object ??
            StrengthBarPositionVariant3 as object ??
            StrengthBarPositionVariant2 as object ??
            StrengthBarPositionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthBarPositionVariant1?.ToValueString() ??
            StrengthBarPositionVariant2?.ToValueString() ??
            StrengthBarPositionVariant3?.ToValueString() ??
            StrengthBarPositionVariant4?.ToValueString() ??
            StrengthBarPositionVariant5?.ToValueString() ??
            StrengthBarPositionVariant6?.ToValueString() ??
            StrengthBarPositionVariant7?.ToValueString() ??
            StrengthBarPositionVariant8?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthBarPositionVariant1 || IsStrengthBarPositionVariant2 || IsStrengthBarPositionVariant3 || IsStrengthBarPositionVariant4 || IsStrengthBarPositionVariant5 || IsStrengthBarPositionVariant6 || IsStrengthBarPositionVariant7 || IsStrengthBarPositionVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthBarPositionVariant1?, TResult>? strengthBarPositionVariant1 = null,
            global::System.Func<global::Terra.StrengthBarPositionVariant2?, TResult>? strengthBarPositionVariant2 = null,
            global::System.Func<global::Terra.StrengthBarPositionVariant3?, TResult>? strengthBarPositionVariant3 = null,
            global::System.Func<global::Terra.StrengthBarPositionVariant4?, TResult>? strengthBarPositionVariant4 = null,
            global::System.Func<global::Terra.StrengthBarPositionVariant5?, TResult>? strengthBarPositionVariant5 = null,
            global::System.Func<global::Terra.StrengthBarPositionVariant6?, TResult>? strengthBarPositionVariant6 = null,
            global::System.Func<global::Terra.StrengthBarPositionVariant7?, TResult>? strengthBarPositionVariant7 = null,
            global::System.Func<string, TResult>? strengthBarPositionVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthBarPositionVariant1 && strengthBarPositionVariant1 != null)
            {
                return strengthBarPositionVariant1(StrengthBarPositionVariant1!);
            }
            else if (IsStrengthBarPositionVariant2 && strengthBarPositionVariant2 != null)
            {
                return strengthBarPositionVariant2(StrengthBarPositionVariant2!);
            }
            else if (IsStrengthBarPositionVariant3 && strengthBarPositionVariant3 != null)
            {
                return strengthBarPositionVariant3(StrengthBarPositionVariant3!);
            }
            else if (IsStrengthBarPositionVariant4 && strengthBarPositionVariant4 != null)
            {
                return strengthBarPositionVariant4(StrengthBarPositionVariant4!);
            }
            else if (IsStrengthBarPositionVariant5 && strengthBarPositionVariant5 != null)
            {
                return strengthBarPositionVariant5(StrengthBarPositionVariant5!);
            }
            else if (IsStrengthBarPositionVariant6 && strengthBarPositionVariant6 != null)
            {
                return strengthBarPositionVariant6(StrengthBarPositionVariant6!);
            }
            else if (IsStrengthBarPositionVariant7 && strengthBarPositionVariant7 != null)
            {
                return strengthBarPositionVariant7(StrengthBarPositionVariant7!);
            }
            else if (IsStrengthBarPositionVariant8 && strengthBarPositionVariant8 != null)
            {
                return strengthBarPositionVariant8(StrengthBarPositionVariant8!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthBarPositionVariant1?>? strengthBarPositionVariant1 = null,

            global::System.Action<global::Terra.StrengthBarPositionVariant2?>? strengthBarPositionVariant2 = null,

            global::System.Action<global::Terra.StrengthBarPositionVariant3?>? strengthBarPositionVariant3 = null,

            global::System.Action<global::Terra.StrengthBarPositionVariant4?>? strengthBarPositionVariant4 = null,

            global::System.Action<global::Terra.StrengthBarPositionVariant5?>? strengthBarPositionVariant5 = null,

            global::System.Action<global::Terra.StrengthBarPositionVariant6?>? strengthBarPositionVariant6 = null,

            global::System.Action<global::Terra.StrengthBarPositionVariant7?>? strengthBarPositionVariant7 = null,

            global::System.Action<string>? strengthBarPositionVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthBarPositionVariant1)
            {
                strengthBarPositionVariant1?.Invoke(StrengthBarPositionVariant1!);
            }
            else if (IsStrengthBarPositionVariant2)
            {
                strengthBarPositionVariant2?.Invoke(StrengthBarPositionVariant2!);
            }
            else if (IsStrengthBarPositionVariant3)
            {
                strengthBarPositionVariant3?.Invoke(StrengthBarPositionVariant3!);
            }
            else if (IsStrengthBarPositionVariant4)
            {
                strengthBarPositionVariant4?.Invoke(StrengthBarPositionVariant4!);
            }
            else if (IsStrengthBarPositionVariant5)
            {
                strengthBarPositionVariant5?.Invoke(StrengthBarPositionVariant5!);
            }
            else if (IsStrengthBarPositionVariant6)
            {
                strengthBarPositionVariant6?.Invoke(StrengthBarPositionVariant6!);
            }
            else if (IsStrengthBarPositionVariant7)
            {
                strengthBarPositionVariant7?.Invoke(StrengthBarPositionVariant7!);
            }
            else if (IsStrengthBarPositionVariant8)
            {
                strengthBarPositionVariant8?.Invoke(StrengthBarPositionVariant8!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthBarPositionVariant1?>? strengthBarPositionVariant1 = null,
            global::System.Action<global::Terra.StrengthBarPositionVariant2?>? strengthBarPositionVariant2 = null,
            global::System.Action<global::Terra.StrengthBarPositionVariant3?>? strengthBarPositionVariant3 = null,
            global::System.Action<global::Terra.StrengthBarPositionVariant4?>? strengthBarPositionVariant4 = null,
            global::System.Action<global::Terra.StrengthBarPositionVariant5?>? strengthBarPositionVariant5 = null,
            global::System.Action<global::Terra.StrengthBarPositionVariant6?>? strengthBarPositionVariant6 = null,
            global::System.Action<global::Terra.StrengthBarPositionVariant7?>? strengthBarPositionVariant7 = null,
            global::System.Action<string>? strengthBarPositionVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthBarPositionVariant1)
            {
                strengthBarPositionVariant1?.Invoke(StrengthBarPositionVariant1!);
            }
            else if (IsStrengthBarPositionVariant2)
            {
                strengthBarPositionVariant2?.Invoke(StrengthBarPositionVariant2!);
            }
            else if (IsStrengthBarPositionVariant3)
            {
                strengthBarPositionVariant3?.Invoke(StrengthBarPositionVariant3!);
            }
            else if (IsStrengthBarPositionVariant4)
            {
                strengthBarPositionVariant4?.Invoke(StrengthBarPositionVariant4!);
            }
            else if (IsStrengthBarPositionVariant5)
            {
                strengthBarPositionVariant5?.Invoke(StrengthBarPositionVariant5!);
            }
            else if (IsStrengthBarPositionVariant6)
            {
                strengthBarPositionVariant6?.Invoke(StrengthBarPositionVariant6!);
            }
            else if (IsStrengthBarPositionVariant7)
            {
                strengthBarPositionVariant7?.Invoke(StrengthBarPositionVariant7!);
            }
            else if (IsStrengthBarPositionVariant8)
            {
                strengthBarPositionVariant8?.Invoke(StrengthBarPositionVariant8!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthBarPositionVariant1,
                typeof(global::Terra.StrengthBarPositionVariant1),
                StrengthBarPositionVariant2,
                typeof(global::Terra.StrengthBarPositionVariant2),
                StrengthBarPositionVariant3,
                typeof(global::Terra.StrengthBarPositionVariant3),
                StrengthBarPositionVariant4,
                typeof(global::Terra.StrengthBarPositionVariant4),
                StrengthBarPositionVariant5,
                typeof(global::Terra.StrengthBarPositionVariant5),
                StrengthBarPositionVariant6,
                typeof(global::Terra.StrengthBarPositionVariant6),
                StrengthBarPositionVariant7,
                typeof(global::Terra.StrengthBarPositionVariant7),
                StrengthBarPositionVariant8,
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
        public bool Equals(StrengthBarPosition other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthBarPositionVariant1?>.Default.Equals(StrengthBarPositionVariant1, other.StrengthBarPositionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthBarPositionVariant2?>.Default.Equals(StrengthBarPositionVariant2, other.StrengthBarPositionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthBarPositionVariant3?>.Default.Equals(StrengthBarPositionVariant3, other.StrengthBarPositionVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthBarPositionVariant4?>.Default.Equals(StrengthBarPositionVariant4, other.StrengthBarPositionVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthBarPositionVariant5?>.Default.Equals(StrengthBarPositionVariant5, other.StrengthBarPositionVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthBarPositionVariant6?>.Default.Equals(StrengthBarPositionVariant6, other.StrengthBarPositionVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthBarPositionVariant7?>.Default.Equals(StrengthBarPositionVariant7, other.StrengthBarPositionVariant7) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthBarPositionVariant8, other.StrengthBarPositionVariant8)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthBarPosition obj1, StrengthBarPosition obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthBarPosition>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthBarPosition obj1, StrengthBarPosition obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthBarPosition o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// What kind of set this was. Open enum — handle unknown values gracefully.<br/>
    /// Example: amrap
    /// </summary>
    public readonly partial struct StrengthSetType : global::System.IEquatable<StrengthSetType>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSetTypeVariant1? StrengthSetTypeVariant1 { get; init; }
#else
        public global::Terra.StrengthSetTypeVariant1? StrengthSetTypeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant1))]
#endif
        public bool IsStrengthSetTypeVariant1 => StrengthSetTypeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSetTypeVariant1? value)
        {
            value = StrengthSetTypeVariant1;
            return IsStrengthSetTypeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant1 PickStrengthSetTypeVariant1() => StrengthSetTypeVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSetTypeVariant2? StrengthSetTypeVariant2 { get; init; }
#else
        public global::Terra.StrengthSetTypeVariant2? StrengthSetTypeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant2))]
#endif
        public bool IsStrengthSetTypeVariant2 => StrengthSetTypeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSetTypeVariant2? value)
        {
            value = StrengthSetTypeVariant2;
            return IsStrengthSetTypeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant2 PickStrengthSetTypeVariant2() => StrengthSetTypeVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSetTypeVariant3? StrengthSetTypeVariant3 { get; init; }
#else
        public global::Terra.StrengthSetTypeVariant3? StrengthSetTypeVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant3))]
#endif
        public bool IsStrengthSetTypeVariant3 => StrengthSetTypeVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSetTypeVariant3? value)
        {
            value = StrengthSetTypeVariant3;
            return IsStrengthSetTypeVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant3 PickStrengthSetTypeVariant3() => StrengthSetTypeVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSetTypeVariant4? StrengthSetTypeVariant4 { get; init; }
#else
        public global::Terra.StrengthSetTypeVariant4? StrengthSetTypeVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant4))]
#endif
        public bool IsStrengthSetTypeVariant4 => StrengthSetTypeVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSetTypeVariant4? value)
        {
            value = StrengthSetTypeVariant4;
            return IsStrengthSetTypeVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant4 PickStrengthSetTypeVariant4() => StrengthSetTypeVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSetTypeVariant5? StrengthSetTypeVariant5 { get; init; }
#else
        public global::Terra.StrengthSetTypeVariant5? StrengthSetTypeVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant5))]
#endif
        public bool IsStrengthSetTypeVariant5 => StrengthSetTypeVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSetTypeVariant5? value)
        {
            value = StrengthSetTypeVariant5;
            return IsStrengthSetTypeVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant5 PickStrengthSetTypeVariant5() => StrengthSetTypeVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSetTypeVariant6? StrengthSetTypeVariant6 { get; init; }
#else
        public global::Terra.StrengthSetTypeVariant6? StrengthSetTypeVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant6))]
#endif
        public bool IsStrengthSetTypeVariant6 => StrengthSetTypeVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSetTypeVariant6? value)
        {
            value = StrengthSetTypeVariant6;
            return IsStrengthSetTypeVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant6 PickStrengthSetTypeVariant6() => StrengthSetTypeVariant6 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant6' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSetTypeVariant7? StrengthSetTypeVariant7 { get; init; }
#else
        public global::Terra.StrengthSetTypeVariant7? StrengthSetTypeVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant7))]
#endif
        public bool IsStrengthSetTypeVariant7 => StrengthSetTypeVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSetTypeVariant7? value)
        {
            value = StrengthSetTypeVariant7;
            return IsStrengthSetTypeVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthSetTypeVariant7 PickStrengthSetTypeVariant7() => StrengthSetTypeVariant7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant7' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthSetTypeVariant8 { get; init; }
#else
        public string? StrengthSetTypeVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSetTypeVariant8))]
#endif
        public bool IsStrengthSetTypeVariant8 => StrengthSetTypeVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthSetTypeVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthSetTypeVariant8;
            return IsStrengthSetTypeVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthSetTypeVariant8() => StrengthSetTypeVariant8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSetTypeVariant8' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(global::Terra.StrengthSetTypeVariant1 value) => new StrengthSetType((global::Terra.StrengthSetTypeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSetTypeVariant1?(StrengthSetType @this) => @this.StrengthSetTypeVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(global::Terra.StrengthSetTypeVariant1? value)
        {
            StrengthSetTypeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant1(global::Terra.StrengthSetTypeVariant1? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(global::Terra.StrengthSetTypeVariant2 value) => new StrengthSetType((global::Terra.StrengthSetTypeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSetTypeVariant2?(StrengthSetType @this) => @this.StrengthSetTypeVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(global::Terra.StrengthSetTypeVariant2? value)
        {
            StrengthSetTypeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant2(global::Terra.StrengthSetTypeVariant2? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(global::Terra.StrengthSetTypeVariant3 value) => new StrengthSetType((global::Terra.StrengthSetTypeVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSetTypeVariant3?(StrengthSetType @this) => @this.StrengthSetTypeVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(global::Terra.StrengthSetTypeVariant3? value)
        {
            StrengthSetTypeVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant3(global::Terra.StrengthSetTypeVariant3? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(global::Terra.StrengthSetTypeVariant4 value) => new StrengthSetType((global::Terra.StrengthSetTypeVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSetTypeVariant4?(StrengthSetType @this) => @this.StrengthSetTypeVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(global::Terra.StrengthSetTypeVariant4? value)
        {
            StrengthSetTypeVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant4(global::Terra.StrengthSetTypeVariant4? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(global::Terra.StrengthSetTypeVariant5 value) => new StrengthSetType((global::Terra.StrengthSetTypeVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSetTypeVariant5?(StrengthSetType @this) => @this.StrengthSetTypeVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(global::Terra.StrengthSetTypeVariant5? value)
        {
            StrengthSetTypeVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant5(global::Terra.StrengthSetTypeVariant5? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(global::Terra.StrengthSetTypeVariant6 value) => new StrengthSetType((global::Terra.StrengthSetTypeVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSetTypeVariant6?(StrengthSetType @this) => @this.StrengthSetTypeVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(global::Terra.StrengthSetTypeVariant6? value)
        {
            StrengthSetTypeVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant6(global::Terra.StrengthSetTypeVariant6? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(global::Terra.StrengthSetTypeVariant7 value) => new StrengthSetType((global::Terra.StrengthSetTypeVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthSetTypeVariant7?(StrengthSetType @this) => @this.StrengthSetTypeVariant7;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(global::Terra.StrengthSetTypeVariant7? value)
        {
            StrengthSetTypeVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant7(global::Terra.StrengthSetTypeVariant7? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthSetType(string value) => new StrengthSetType((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthSetType @this) => @this.StrengthSetTypeVariant8;

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(string? value)
        {
            StrengthSetTypeVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthSetType FromStrengthSetTypeVariant8(string? value) => new StrengthSetType(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthSetType(
            global::Terra.StrengthSetTypeVariant1? strengthSetTypeVariant1,
            global::Terra.StrengthSetTypeVariant2? strengthSetTypeVariant2,
            global::Terra.StrengthSetTypeVariant3? strengthSetTypeVariant3,
            global::Terra.StrengthSetTypeVariant4? strengthSetTypeVariant4,
            global::Terra.StrengthSetTypeVariant5? strengthSetTypeVariant5,
            global::Terra.StrengthSetTypeVariant6? strengthSetTypeVariant6,
            global::Terra.StrengthSetTypeVariant7? strengthSetTypeVariant7,
            string? strengthSetTypeVariant8
            )
        {
            StrengthSetTypeVariant1 = strengthSetTypeVariant1;
            StrengthSetTypeVariant2 = strengthSetTypeVariant2;
            StrengthSetTypeVariant3 = strengthSetTypeVariant3;
            StrengthSetTypeVariant4 = strengthSetTypeVariant4;
            StrengthSetTypeVariant5 = strengthSetTypeVariant5;
            StrengthSetTypeVariant6 = strengthSetTypeVariant6;
            StrengthSetTypeVariant7 = strengthSetTypeVariant7;
            StrengthSetTypeVariant8 = strengthSetTypeVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthSetTypeVariant8 as object ??
            StrengthSetTypeVariant7 as object ??
            StrengthSetTypeVariant6 as object ??
            StrengthSetTypeVariant5 as object ??
            StrengthSetTypeVariant4 as object ??
            StrengthSetTypeVariant3 as object ??
            StrengthSetTypeVariant2 as object ??
            StrengthSetTypeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthSetTypeVariant1?.ToValueString() ??
            StrengthSetTypeVariant2?.ToValueString() ??
            StrengthSetTypeVariant3?.ToValueString() ??
            StrengthSetTypeVariant4?.ToValueString() ??
            StrengthSetTypeVariant5?.ToValueString() ??
            StrengthSetTypeVariant6?.ToValueString() ??
            StrengthSetTypeVariant7?.ToValueString() ??
            StrengthSetTypeVariant8?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthSetTypeVariant1 || IsStrengthSetTypeVariant2 || IsStrengthSetTypeVariant3 || IsStrengthSetTypeVariant4 || IsStrengthSetTypeVariant5 || IsStrengthSetTypeVariant6 || IsStrengthSetTypeVariant7 || IsStrengthSetTypeVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthSetTypeVariant1?, TResult>? strengthSetTypeVariant1 = null,
            global::System.Func<global::Terra.StrengthSetTypeVariant2?, TResult>? strengthSetTypeVariant2 = null,
            global::System.Func<global::Terra.StrengthSetTypeVariant3?, TResult>? strengthSetTypeVariant3 = null,
            global::System.Func<global::Terra.StrengthSetTypeVariant4?, TResult>? strengthSetTypeVariant4 = null,
            global::System.Func<global::Terra.StrengthSetTypeVariant5?, TResult>? strengthSetTypeVariant5 = null,
            global::System.Func<global::Terra.StrengthSetTypeVariant6?, TResult>? strengthSetTypeVariant6 = null,
            global::System.Func<global::Terra.StrengthSetTypeVariant7?, TResult>? strengthSetTypeVariant7 = null,
            global::System.Func<string, TResult>? strengthSetTypeVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StrengthSetTypeVariant1 is { } __value0 && strengthSetTypeVariant1 != null)
            {
                return strengthSetTypeVariant1(__value0);
            }
            else if (StrengthSetTypeVariant2 is { } __value1 && strengthSetTypeVariant2 != null)
            {
                return strengthSetTypeVariant2(__value1);
            }
            else if (StrengthSetTypeVariant3 is { } __value2 && strengthSetTypeVariant3 != null)
            {
                return strengthSetTypeVariant3(__value2);
            }
            else if (StrengthSetTypeVariant4 is { } __value3 && strengthSetTypeVariant4 != null)
            {
                return strengthSetTypeVariant4(__value3);
            }
            else if (StrengthSetTypeVariant5 is { } __value4 && strengthSetTypeVariant5 != null)
            {
                return strengthSetTypeVariant5(__value4);
            }
            else if (StrengthSetTypeVariant6 is { } __value5 && strengthSetTypeVariant6 != null)
            {
                return strengthSetTypeVariant6(__value5);
            }
            else if (StrengthSetTypeVariant7 is { } __value6 && strengthSetTypeVariant7 != null)
            {
                return strengthSetTypeVariant7(__value6);
            }
            else if (StrengthSetTypeVariant8 is { } __value7 && strengthSetTypeVariant8 != null)
            {
                return strengthSetTypeVariant8(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthSetTypeVariant1?>? strengthSetTypeVariant1 = null,

            global::System.Action<global::Terra.StrengthSetTypeVariant2?>? strengthSetTypeVariant2 = null,

            global::System.Action<global::Terra.StrengthSetTypeVariant3?>? strengthSetTypeVariant3 = null,

            global::System.Action<global::Terra.StrengthSetTypeVariant4?>? strengthSetTypeVariant4 = null,

            global::System.Action<global::Terra.StrengthSetTypeVariant5?>? strengthSetTypeVariant5 = null,

            global::System.Action<global::Terra.StrengthSetTypeVariant6?>? strengthSetTypeVariant6 = null,

            global::System.Action<global::Terra.StrengthSetTypeVariant7?>? strengthSetTypeVariant7 = null,

            global::System.Action<string>? strengthSetTypeVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StrengthSetTypeVariant1 is { } __value0)
            {
                strengthSetTypeVariant1?.Invoke(__value0);
            }
            else if (StrengthSetTypeVariant2 is { } __value1)
            {
                strengthSetTypeVariant2?.Invoke(__value1);
            }
            else if (StrengthSetTypeVariant3 is { } __value2)
            {
                strengthSetTypeVariant3?.Invoke(__value2);
            }
            else if (StrengthSetTypeVariant4 is { } __value3)
            {
                strengthSetTypeVariant4?.Invoke(__value3);
            }
            else if (StrengthSetTypeVariant5 is { } __value4)
            {
                strengthSetTypeVariant5?.Invoke(__value4);
            }
            else if (StrengthSetTypeVariant6 is { } __value5)
            {
                strengthSetTypeVariant6?.Invoke(__value5);
            }
            else if (StrengthSetTypeVariant7 is { } __value6)
            {
                strengthSetTypeVariant7?.Invoke(__value6);
            }
            else if (StrengthSetTypeVariant8 is { } __value7)
            {
                strengthSetTypeVariant8?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthSetTypeVariant1?>? strengthSetTypeVariant1 = null,
            global::System.Action<global::Terra.StrengthSetTypeVariant2?>? strengthSetTypeVariant2 = null,
            global::System.Action<global::Terra.StrengthSetTypeVariant3?>? strengthSetTypeVariant3 = null,
            global::System.Action<global::Terra.StrengthSetTypeVariant4?>? strengthSetTypeVariant4 = null,
            global::System.Action<global::Terra.StrengthSetTypeVariant5?>? strengthSetTypeVariant5 = null,
            global::System.Action<global::Terra.StrengthSetTypeVariant6?>? strengthSetTypeVariant6 = null,
            global::System.Action<global::Terra.StrengthSetTypeVariant7?>? strengthSetTypeVariant7 = null,
            global::System.Action<string>? strengthSetTypeVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StrengthSetTypeVariant1 is { } __value0)
            {
                strengthSetTypeVariant1?.Invoke(__value0);
            }
            else if (StrengthSetTypeVariant2 is { } __value1)
            {
                strengthSetTypeVariant2?.Invoke(__value1);
            }
            else if (StrengthSetTypeVariant3 is { } __value2)
            {
                strengthSetTypeVariant3?.Invoke(__value2);
            }
            else if (StrengthSetTypeVariant4 is { } __value3)
            {
                strengthSetTypeVariant4?.Invoke(__value3);
            }
            else if (StrengthSetTypeVariant5 is { } __value4)
            {
                strengthSetTypeVariant5?.Invoke(__value4);
            }
            else if (StrengthSetTypeVariant6 is { } __value5)
            {
                strengthSetTypeVariant6?.Invoke(__value5);
            }
            else if (StrengthSetTypeVariant7 is { } __value6)
            {
                strengthSetTypeVariant7?.Invoke(__value6);
            }
            else if (StrengthSetTypeVariant8 is { } __value7)
            {
                strengthSetTypeVariant8?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthSetTypeVariant1,
                typeof(global::Terra.StrengthSetTypeVariant1),
                StrengthSetTypeVariant2,
                typeof(global::Terra.StrengthSetTypeVariant2),
                StrengthSetTypeVariant3,
                typeof(global::Terra.StrengthSetTypeVariant3),
                StrengthSetTypeVariant4,
                typeof(global::Terra.StrengthSetTypeVariant4),
                StrengthSetTypeVariant5,
                typeof(global::Terra.StrengthSetTypeVariant5),
                StrengthSetTypeVariant6,
                typeof(global::Terra.StrengthSetTypeVariant6),
                StrengthSetTypeVariant7,
                typeof(global::Terra.StrengthSetTypeVariant7),
                StrengthSetTypeVariant8,
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
        public bool Equals(StrengthSetType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSetTypeVariant1?>.Default.Equals(StrengthSetTypeVariant1, other.StrengthSetTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSetTypeVariant2?>.Default.Equals(StrengthSetTypeVariant2, other.StrengthSetTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSetTypeVariant3?>.Default.Equals(StrengthSetTypeVariant3, other.StrengthSetTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSetTypeVariant4?>.Default.Equals(StrengthSetTypeVariant4, other.StrengthSetTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSetTypeVariant5?>.Default.Equals(StrengthSetTypeVariant5, other.StrengthSetTypeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSetTypeVariant6?>.Default.Equals(StrengthSetTypeVariant6, other.StrengthSetTypeVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSetTypeVariant7?>.Default.Equals(StrengthSetTypeVariant7, other.StrengthSetTypeVariant7) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthSetTypeVariant8, other.StrengthSetTypeVariant8)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthSetType obj1, StrengthSetType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthSetType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthSetType obj1, StrengthSetType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthSetType o && Equals(o);
        }
    }
}

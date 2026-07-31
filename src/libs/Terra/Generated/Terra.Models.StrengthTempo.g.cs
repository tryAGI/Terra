#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// How the repetition is paced. Open enum — handle unknown values gracefully.<br/>
    /// Example: eccentric
    /// </summary>
    public readonly partial struct StrengthTempo : global::System.IEquatable<StrengthTempo>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant1? StrengthTempoVariant1 { get; init; }
#else
        public global::Terra.StrengthTempoVariant1? StrengthTempoVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant1))]
#endif
        public bool IsStrengthTempoVariant1 => StrengthTempoVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant1? value)
        {
            value = StrengthTempoVariant1;
            return IsStrengthTempoVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant1 PickStrengthTempoVariant1() => IsStrengthTempoVariant1
            ? StrengthTempoVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant2? StrengthTempoVariant2 { get; init; }
#else
        public global::Terra.StrengthTempoVariant2? StrengthTempoVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant2))]
#endif
        public bool IsStrengthTempoVariant2 => StrengthTempoVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant2? value)
        {
            value = StrengthTempoVariant2;
            return IsStrengthTempoVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant2 PickStrengthTempoVariant2() => IsStrengthTempoVariant2
            ? StrengthTempoVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant3? StrengthTempoVariant3 { get; init; }
#else
        public global::Terra.StrengthTempoVariant3? StrengthTempoVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant3))]
#endif
        public bool IsStrengthTempoVariant3 => StrengthTempoVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant3? value)
        {
            value = StrengthTempoVariant3;
            return IsStrengthTempoVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant3 PickStrengthTempoVariant3() => IsStrengthTempoVariant3
            ? StrengthTempoVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant4? StrengthTempoVariant4 { get; init; }
#else
        public global::Terra.StrengthTempoVariant4? StrengthTempoVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant4))]
#endif
        public bool IsStrengthTempoVariant4 => StrengthTempoVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant4? value)
        {
            value = StrengthTempoVariant4;
            return IsStrengthTempoVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant4 PickStrengthTempoVariant4() => IsStrengthTempoVariant4
            ? StrengthTempoVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant5? StrengthTempoVariant5 { get; init; }
#else
        public global::Terra.StrengthTempoVariant5? StrengthTempoVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant5))]
#endif
        public bool IsStrengthTempoVariant5 => StrengthTempoVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant5? value)
        {
            value = StrengthTempoVariant5;
            return IsStrengthTempoVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant5 PickStrengthTempoVariant5() => IsStrengthTempoVariant5
            ? StrengthTempoVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant6? StrengthTempoVariant6 { get; init; }
#else
        public global::Terra.StrengthTempoVariant6? StrengthTempoVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant6))]
#endif
        public bool IsStrengthTempoVariant6 => StrengthTempoVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant6? value)
        {
            value = StrengthTempoVariant6;
            return IsStrengthTempoVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant6 PickStrengthTempoVariant6() => IsStrengthTempoVariant6
            ? StrengthTempoVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant6' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant7? StrengthTempoVariant7 { get; init; }
#else
        public global::Terra.StrengthTempoVariant7? StrengthTempoVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant7))]
#endif
        public bool IsStrengthTempoVariant7 => StrengthTempoVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant7? value)
        {
            value = StrengthTempoVariant7;
            return IsStrengthTempoVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant7 PickStrengthTempoVariant7() => IsStrengthTempoVariant7
            ? StrengthTempoVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant7' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthTempoVariant8? StrengthTempoVariant8 { get; init; }
#else
        public global::Terra.StrengthTempoVariant8? StrengthTempoVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant8))]
#endif
        public bool IsStrengthTempoVariant8 => StrengthTempoVariant8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthTempoVariant8? value)
        {
            value = StrengthTempoVariant8;
            return IsStrengthTempoVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthTempoVariant8 PickStrengthTempoVariant8() => IsStrengthTempoVariant8
            ? StrengthTempoVariant8!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant8' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthTempoVariant9 { get; init; }
#else
        public string? StrengthTempoVariant9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthTempoVariant9))]
#endif
        public bool IsStrengthTempoVariant9 => StrengthTempoVariant9 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthTempoVariant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthTempoVariant9;
            return IsStrengthTempoVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickStrengthTempoVariant9() => IsStrengthTempoVariant9
            ? StrengthTempoVariant9!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthTempoVariant9' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant1 value) => new StrengthTempo((global::Terra.StrengthTempoVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant1?(StrengthTempo @this) => @this.StrengthTempoVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant1? value)
        {
            StrengthTempoVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant1(global::Terra.StrengthTempoVariant1? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant2 value) => new StrengthTempo((global::Terra.StrengthTempoVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant2?(StrengthTempo @this) => @this.StrengthTempoVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant2? value)
        {
            StrengthTempoVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant2(global::Terra.StrengthTempoVariant2? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant3 value) => new StrengthTempo((global::Terra.StrengthTempoVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant3?(StrengthTempo @this) => @this.StrengthTempoVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant3? value)
        {
            StrengthTempoVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant3(global::Terra.StrengthTempoVariant3? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant4 value) => new StrengthTempo((global::Terra.StrengthTempoVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant4?(StrengthTempo @this) => @this.StrengthTempoVariant4;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant4? value)
        {
            StrengthTempoVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant4(global::Terra.StrengthTempoVariant4? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant5 value) => new StrengthTempo((global::Terra.StrengthTempoVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant5?(StrengthTempo @this) => @this.StrengthTempoVariant5;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant5? value)
        {
            StrengthTempoVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant5(global::Terra.StrengthTempoVariant5? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant6 value) => new StrengthTempo((global::Terra.StrengthTempoVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant6?(StrengthTempo @this) => @this.StrengthTempoVariant6;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant6? value)
        {
            StrengthTempoVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant6(global::Terra.StrengthTempoVariant6? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant7 value) => new StrengthTempo((global::Terra.StrengthTempoVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant7?(StrengthTempo @this) => @this.StrengthTempoVariant7;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant7? value)
        {
            StrengthTempoVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant7(global::Terra.StrengthTempoVariant7? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(global::Terra.StrengthTempoVariant8 value) => new StrengthTempo((global::Terra.StrengthTempoVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthTempoVariant8?(StrengthTempo @this) => @this.StrengthTempoVariant8;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(global::Terra.StrengthTempoVariant8? value)
        {
            StrengthTempoVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant8(global::Terra.StrengthTempoVariant8? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthTempo(string value) => new StrengthTempo((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StrengthTempo @this) => @this.StrengthTempoVariant9;

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(string? value)
        {
            StrengthTempoVariant9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthTempo FromStrengthTempoVariant9(string? value) => new StrengthTempo(value);

        /// <summary>
        /// 
        /// </summary>
        public StrengthTempo(
            global::Terra.StrengthTempoVariant1? strengthTempoVariant1,
            global::Terra.StrengthTempoVariant2? strengthTempoVariant2,
            global::Terra.StrengthTempoVariant3? strengthTempoVariant3,
            global::Terra.StrengthTempoVariant4? strengthTempoVariant4,
            global::Terra.StrengthTempoVariant5? strengthTempoVariant5,
            global::Terra.StrengthTempoVariant6? strengthTempoVariant6,
            global::Terra.StrengthTempoVariant7? strengthTempoVariant7,
            global::Terra.StrengthTempoVariant8? strengthTempoVariant8,
            string? strengthTempoVariant9
            )
        {
            StrengthTempoVariant1 = strengthTempoVariant1;
            StrengthTempoVariant2 = strengthTempoVariant2;
            StrengthTempoVariant3 = strengthTempoVariant3;
            StrengthTempoVariant4 = strengthTempoVariant4;
            StrengthTempoVariant5 = strengthTempoVariant5;
            StrengthTempoVariant6 = strengthTempoVariant6;
            StrengthTempoVariant7 = strengthTempoVariant7;
            StrengthTempoVariant8 = strengthTempoVariant8;
            StrengthTempoVariant9 = strengthTempoVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StrengthTempoVariant9 as object ??
            StrengthTempoVariant8 as object ??
            StrengthTempoVariant7 as object ??
            StrengthTempoVariant6 as object ??
            StrengthTempoVariant5 as object ??
            StrengthTempoVariant4 as object ??
            StrengthTempoVariant3 as object ??
            StrengthTempoVariant2 as object ??
            StrengthTempoVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StrengthTempoVariant1?.ToValueString() ??
            StrengthTempoVariant2?.ToValueString() ??
            StrengthTempoVariant3?.ToValueString() ??
            StrengthTempoVariant4?.ToValueString() ??
            StrengthTempoVariant5?.ToValueString() ??
            StrengthTempoVariant6?.ToValueString() ??
            StrengthTempoVariant7?.ToValueString() ??
            StrengthTempoVariant8?.ToValueString() ??
            StrengthTempoVariant9?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStrengthTempoVariant1 || IsStrengthTempoVariant2 || IsStrengthTempoVariant3 || IsStrengthTempoVariant4 || IsStrengthTempoVariant5 || IsStrengthTempoVariant6 || IsStrengthTempoVariant7 || IsStrengthTempoVariant8 || IsStrengthTempoVariant9;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthTempoVariant1?, TResult>? strengthTempoVariant1 = null,
            global::System.Func<global::Terra.StrengthTempoVariant2?, TResult>? strengthTempoVariant2 = null,
            global::System.Func<global::Terra.StrengthTempoVariant3?, TResult>? strengthTempoVariant3 = null,
            global::System.Func<global::Terra.StrengthTempoVariant4?, TResult>? strengthTempoVariant4 = null,
            global::System.Func<global::Terra.StrengthTempoVariant5?, TResult>? strengthTempoVariant5 = null,
            global::System.Func<global::Terra.StrengthTempoVariant6?, TResult>? strengthTempoVariant6 = null,
            global::System.Func<global::Terra.StrengthTempoVariant7?, TResult>? strengthTempoVariant7 = null,
            global::System.Func<global::Terra.StrengthTempoVariant8?, TResult>? strengthTempoVariant8 = null,
            global::System.Func<string, TResult>? strengthTempoVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthTempoVariant1 && strengthTempoVariant1 != null)
            {
                return strengthTempoVariant1(StrengthTempoVariant1!);
            }
            else if (IsStrengthTempoVariant2 && strengthTempoVariant2 != null)
            {
                return strengthTempoVariant2(StrengthTempoVariant2!);
            }
            else if (IsStrengthTempoVariant3 && strengthTempoVariant3 != null)
            {
                return strengthTempoVariant3(StrengthTempoVariant3!);
            }
            else if (IsStrengthTempoVariant4 && strengthTempoVariant4 != null)
            {
                return strengthTempoVariant4(StrengthTempoVariant4!);
            }
            else if (IsStrengthTempoVariant5 && strengthTempoVariant5 != null)
            {
                return strengthTempoVariant5(StrengthTempoVariant5!);
            }
            else if (IsStrengthTempoVariant6 && strengthTempoVariant6 != null)
            {
                return strengthTempoVariant6(StrengthTempoVariant6!);
            }
            else if (IsStrengthTempoVariant7 && strengthTempoVariant7 != null)
            {
                return strengthTempoVariant7(StrengthTempoVariant7!);
            }
            else if (IsStrengthTempoVariant8 && strengthTempoVariant8 != null)
            {
                return strengthTempoVariant8(StrengthTempoVariant8!);
            }
            else if (IsStrengthTempoVariant9 && strengthTempoVariant9 != null)
            {
                return strengthTempoVariant9(StrengthTempoVariant9!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthTempoVariant1?>? strengthTempoVariant1 = null,

            global::System.Action<global::Terra.StrengthTempoVariant2?>? strengthTempoVariant2 = null,

            global::System.Action<global::Terra.StrengthTempoVariant3?>? strengthTempoVariant3 = null,

            global::System.Action<global::Terra.StrengthTempoVariant4?>? strengthTempoVariant4 = null,

            global::System.Action<global::Terra.StrengthTempoVariant5?>? strengthTempoVariant5 = null,

            global::System.Action<global::Terra.StrengthTempoVariant6?>? strengthTempoVariant6 = null,

            global::System.Action<global::Terra.StrengthTempoVariant7?>? strengthTempoVariant7 = null,

            global::System.Action<global::Terra.StrengthTempoVariant8?>? strengthTempoVariant8 = null,

            global::System.Action<string>? strengthTempoVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthTempoVariant1)
            {
                strengthTempoVariant1?.Invoke(StrengthTempoVariant1!);
            }
            else if (IsStrengthTempoVariant2)
            {
                strengthTempoVariant2?.Invoke(StrengthTempoVariant2!);
            }
            else if (IsStrengthTempoVariant3)
            {
                strengthTempoVariant3?.Invoke(StrengthTempoVariant3!);
            }
            else if (IsStrengthTempoVariant4)
            {
                strengthTempoVariant4?.Invoke(StrengthTempoVariant4!);
            }
            else if (IsStrengthTempoVariant5)
            {
                strengthTempoVariant5?.Invoke(StrengthTempoVariant5!);
            }
            else if (IsStrengthTempoVariant6)
            {
                strengthTempoVariant6?.Invoke(StrengthTempoVariant6!);
            }
            else if (IsStrengthTempoVariant7)
            {
                strengthTempoVariant7?.Invoke(StrengthTempoVariant7!);
            }
            else if (IsStrengthTempoVariant8)
            {
                strengthTempoVariant8?.Invoke(StrengthTempoVariant8!);
            }
            else if (IsStrengthTempoVariant9)
            {
                strengthTempoVariant9?.Invoke(StrengthTempoVariant9!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthTempoVariant1?>? strengthTempoVariant1 = null,
            global::System.Action<global::Terra.StrengthTempoVariant2?>? strengthTempoVariant2 = null,
            global::System.Action<global::Terra.StrengthTempoVariant3?>? strengthTempoVariant3 = null,
            global::System.Action<global::Terra.StrengthTempoVariant4?>? strengthTempoVariant4 = null,
            global::System.Action<global::Terra.StrengthTempoVariant5?>? strengthTempoVariant5 = null,
            global::System.Action<global::Terra.StrengthTempoVariant6?>? strengthTempoVariant6 = null,
            global::System.Action<global::Terra.StrengthTempoVariant7?>? strengthTempoVariant7 = null,
            global::System.Action<global::Terra.StrengthTempoVariant8?>? strengthTempoVariant8 = null,
            global::System.Action<string>? strengthTempoVariant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthTempoVariant1)
            {
                strengthTempoVariant1?.Invoke(StrengthTempoVariant1!);
            }
            else if (IsStrengthTempoVariant2)
            {
                strengthTempoVariant2?.Invoke(StrengthTempoVariant2!);
            }
            else if (IsStrengthTempoVariant3)
            {
                strengthTempoVariant3?.Invoke(StrengthTempoVariant3!);
            }
            else if (IsStrengthTempoVariant4)
            {
                strengthTempoVariant4?.Invoke(StrengthTempoVariant4!);
            }
            else if (IsStrengthTempoVariant5)
            {
                strengthTempoVariant5?.Invoke(StrengthTempoVariant5!);
            }
            else if (IsStrengthTempoVariant6)
            {
                strengthTempoVariant6?.Invoke(StrengthTempoVariant6!);
            }
            else if (IsStrengthTempoVariant7)
            {
                strengthTempoVariant7?.Invoke(StrengthTempoVariant7!);
            }
            else if (IsStrengthTempoVariant8)
            {
                strengthTempoVariant8?.Invoke(StrengthTempoVariant8!);
            }
            else if (IsStrengthTempoVariant9)
            {
                strengthTempoVariant9?.Invoke(StrengthTempoVariant9!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthTempoVariant1,
                typeof(global::Terra.StrengthTempoVariant1),
                StrengthTempoVariant2,
                typeof(global::Terra.StrengthTempoVariant2),
                StrengthTempoVariant3,
                typeof(global::Terra.StrengthTempoVariant3),
                StrengthTempoVariant4,
                typeof(global::Terra.StrengthTempoVariant4),
                StrengthTempoVariant5,
                typeof(global::Terra.StrengthTempoVariant5),
                StrengthTempoVariant6,
                typeof(global::Terra.StrengthTempoVariant6),
                StrengthTempoVariant7,
                typeof(global::Terra.StrengthTempoVariant7),
                StrengthTempoVariant8,
                typeof(global::Terra.StrengthTempoVariant8),
                StrengthTempoVariant9,
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
        public bool Equals(StrengthTempo other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant1?>.Default.Equals(StrengthTempoVariant1, other.StrengthTempoVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant2?>.Default.Equals(StrengthTempoVariant2, other.StrengthTempoVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant3?>.Default.Equals(StrengthTempoVariant3, other.StrengthTempoVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant4?>.Default.Equals(StrengthTempoVariant4, other.StrengthTempoVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant5?>.Default.Equals(StrengthTempoVariant5, other.StrengthTempoVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant6?>.Default.Equals(StrengthTempoVariant6, other.StrengthTempoVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant7?>.Default.Equals(StrengthTempoVariant7, other.StrengthTempoVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthTempoVariant8?>.Default.Equals(StrengthTempoVariant8, other.StrengthTempoVariant8) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthTempoVariant9, other.StrengthTempoVariant9) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StrengthTempo obj1, StrengthTempo obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthTempo>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StrengthTempo obj1, StrengthTempo obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthTempo o && Equals(o);
        }
    }
}

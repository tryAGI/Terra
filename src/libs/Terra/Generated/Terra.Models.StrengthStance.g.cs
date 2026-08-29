#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Foot arrangement. Open enum — handle unknown values gracefully.<br/>
    /// Example: crossover
    /// </summary>
    public readonly partial struct StrengthStance : global::System.IEquatable<StrengthStance>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthStanceVariant1? StrengthStanceVariant1 { get; init; }
#else
        public global::Terra.StrengthStanceVariant1? StrengthStanceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthStanceVariant1))]
#endif
        public bool IsStrengthStanceVariant1 => StrengthStanceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthStanceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthStanceVariant1? value)
        {
            value = StrengthStanceVariant1;
            return IsStrengthStanceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant1 PickStrengthStanceVariant1() => IsStrengthStanceVariant1
            ? StrengthStanceVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthStanceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthStanceVariant2? StrengthStanceVariant2 { get; init; }
#else
        public global::Terra.StrengthStanceVariant2? StrengthStanceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthStanceVariant2))]
#endif
        public bool IsStrengthStanceVariant2 => StrengthStanceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthStanceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthStanceVariant2? value)
        {
            value = StrengthStanceVariant2;
            return IsStrengthStanceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant2 PickStrengthStanceVariant2() => IsStrengthStanceVariant2
            ? StrengthStanceVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthStanceVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthStanceVariant3? StrengthStanceVariant3 { get; init; }
#else
        public global::Terra.StrengthStanceVariant3? StrengthStanceVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthStanceVariant3))]
#endif
        public bool IsStrengthStanceVariant3 => StrengthStanceVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthStanceVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthStanceVariant3? value)
        {
            value = StrengthStanceVariant3;
            return IsStrengthStanceVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant3 PickStrengthStanceVariant3() => IsStrengthStanceVariant3
            ? StrengthStanceVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthStanceVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthStanceVariant4? StrengthStanceVariant4 { get; init; }
#else
        public global::Terra.StrengthStanceVariant4? StrengthStanceVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthStanceVariant4))]
#endif
        public bool IsStrengthStanceVariant4 => StrengthStanceVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthStanceVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthStanceVariant4? value)
        {
            value = StrengthStanceVariant4;
            return IsStrengthStanceVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant4 PickStrengthStanceVariant4() => IsStrengthStanceVariant4
            ? StrengthStanceVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthStanceVariant4' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthStanceVariant5? StrengthStanceVariant5 { get; init; }
#else
        public global::Terra.StrengthStanceVariant5? StrengthStanceVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthStanceVariant5))]
#endif
        public bool IsStrengthStanceVariant5 => StrengthStanceVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthStanceVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthStanceVariant5? value)
        {
            value = StrengthStanceVariant5;
            return IsStrengthStanceVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthStanceVariant5 PickStrengthStanceVariant5() => IsStrengthStanceVariant5
            ? StrengthStanceVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthStanceVariant5' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthStanceVariant6 { get; init; }
#else
        public string? StrengthStanceVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthStanceVariant6))]
#endif
        public bool IsStrengthStanceVariant6 => StrengthStanceVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthStanceVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthStanceVariant6;
            return IsStrengthStanceVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthStanceVariant6() => IsStrengthStanceVariant6
            ? StrengthStanceVariant6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthStanceVariant6' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthStance(global::Terra.StrengthStanceVariant1 value) => new StrengthStance((global::Terra.StrengthStanceVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthStanceVariant1?(StrengthStance @this) => @this.StrengthStanceVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthStance(global::Terra.StrengthStanceVariant1? value)
        {
            StrengthStanceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthStance FromStrengthStanceVariant1(global::Terra.StrengthStanceVariant1? value) => new StrengthStance(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthStance(global::Terra.StrengthStanceVariant2 value) => new StrengthStance((global::Terra.StrengthStanceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthStanceVariant2?(StrengthStance @this) => @this.StrengthStanceVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthStance(global::Terra.StrengthStanceVariant2? value)
        {
            StrengthStanceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthStance FromStrengthStanceVariant2(global::Terra.StrengthStanceVariant2? value) => new StrengthStance(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthStance(global::Terra.StrengthStanceVariant3 value) => new StrengthStance((global::Terra.StrengthStanceVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthStanceVariant3?(StrengthStance @this) => @this.StrengthStanceVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthStance(global::Terra.StrengthStanceVariant3? value)
        {
            StrengthStanceVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthStance FromStrengthStanceVariant3(global::Terra.StrengthStanceVariant3? value) => new StrengthStance(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthStance(global::Terra.StrengthStanceVariant4 value) => new StrengthStance((global::Terra.StrengthStanceVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthStanceVariant4?(StrengthStance @this) => @this.StrengthStanceVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthStance(global::Terra.StrengthStanceVariant4? value)
        {
            StrengthStanceVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthStance FromStrengthStanceVariant4(global::Terra.StrengthStanceVariant4? value) => new StrengthStance(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthStance(global::Terra.StrengthStanceVariant5 value) => new StrengthStance((global::Terra.StrengthStanceVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthStanceVariant5?(StrengthStance @this) => @this.StrengthStanceVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthStance(global::Terra.StrengthStanceVariant5? value)
        {
            StrengthStanceVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthStance FromStrengthStanceVariant5(global::Terra.StrengthStanceVariant5? value) => new StrengthStance(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthStance(string value) => new StrengthStance((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthStance @this) => @this.StrengthStanceVariant6;

        /// <summary>
        ///
        /// </summary>
        public StrengthStance(string? value)
        {
            StrengthStanceVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthStance FromStrengthStanceVariant6(string? value) => new StrengthStance(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthStance(
            global::Terra.StrengthStanceVariant1? strengthStanceVariant1,
            global::Terra.StrengthStanceVariant2? strengthStanceVariant2,
            global::Terra.StrengthStanceVariant3? strengthStanceVariant3,
            global::Terra.StrengthStanceVariant4? strengthStanceVariant4,
            global::Terra.StrengthStanceVariant5? strengthStanceVariant5,
            string? strengthStanceVariant6
            )
        {
            StrengthStanceVariant1 = strengthStanceVariant1;
            StrengthStanceVariant2 = strengthStanceVariant2;
            StrengthStanceVariant3 = strengthStanceVariant3;
            StrengthStanceVariant4 = strengthStanceVariant4;
            StrengthStanceVariant5 = strengthStanceVariant5;
            StrengthStanceVariant6 = strengthStanceVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthStanceVariant6 as object ??
            StrengthStanceVariant5 as object ??
            StrengthStanceVariant4 as object ??
            StrengthStanceVariant3 as object ??
            StrengthStanceVariant2 as object ??
            StrengthStanceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthStanceVariant1?.ToValueString() ??
            StrengthStanceVariant2?.ToValueString() ??
            StrengthStanceVariant3?.ToValueString() ??
            StrengthStanceVariant4?.ToValueString() ??
            StrengthStanceVariant5?.ToValueString() ??
            StrengthStanceVariant6?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthStanceVariant1 || IsStrengthStanceVariant2 || IsStrengthStanceVariant3 || IsStrengthStanceVariant4 || IsStrengthStanceVariant5 || IsStrengthStanceVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthStanceVariant1?, TResult>? strengthStanceVariant1 = null,
            global::System.Func<global::Terra.StrengthStanceVariant2?, TResult>? strengthStanceVariant2 = null,
            global::System.Func<global::Terra.StrengthStanceVariant3?, TResult>? strengthStanceVariant3 = null,
            global::System.Func<global::Terra.StrengthStanceVariant4?, TResult>? strengthStanceVariant4 = null,
            global::System.Func<global::Terra.StrengthStanceVariant5?, TResult>? strengthStanceVariant5 = null,
            global::System.Func<string, TResult>? strengthStanceVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthStanceVariant1 && strengthStanceVariant1 != null)
            {
                return strengthStanceVariant1(StrengthStanceVariant1!);
            }
            else if (IsStrengthStanceVariant2 && strengthStanceVariant2 != null)
            {
                return strengthStanceVariant2(StrengthStanceVariant2!);
            }
            else if (IsStrengthStanceVariant3 && strengthStanceVariant3 != null)
            {
                return strengthStanceVariant3(StrengthStanceVariant3!);
            }
            else if (IsStrengthStanceVariant4 && strengthStanceVariant4 != null)
            {
                return strengthStanceVariant4(StrengthStanceVariant4!);
            }
            else if (IsStrengthStanceVariant5 && strengthStanceVariant5 != null)
            {
                return strengthStanceVariant5(StrengthStanceVariant5!);
            }
            else if (IsStrengthStanceVariant6 && strengthStanceVariant6 != null)
            {
                return strengthStanceVariant6(StrengthStanceVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthStanceVariant1?>? strengthStanceVariant1 = null,

            global::System.Action<global::Terra.StrengthStanceVariant2?>? strengthStanceVariant2 = null,

            global::System.Action<global::Terra.StrengthStanceVariant3?>? strengthStanceVariant3 = null,

            global::System.Action<global::Terra.StrengthStanceVariant4?>? strengthStanceVariant4 = null,

            global::System.Action<global::Terra.StrengthStanceVariant5?>? strengthStanceVariant5 = null,

            global::System.Action<string>? strengthStanceVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthStanceVariant1)
            {
                strengthStanceVariant1?.Invoke(StrengthStanceVariant1!);
            }
            else if (IsStrengthStanceVariant2)
            {
                strengthStanceVariant2?.Invoke(StrengthStanceVariant2!);
            }
            else if (IsStrengthStanceVariant3)
            {
                strengthStanceVariant3?.Invoke(StrengthStanceVariant3!);
            }
            else if (IsStrengthStanceVariant4)
            {
                strengthStanceVariant4?.Invoke(StrengthStanceVariant4!);
            }
            else if (IsStrengthStanceVariant5)
            {
                strengthStanceVariant5?.Invoke(StrengthStanceVariant5!);
            }
            else if (IsStrengthStanceVariant6)
            {
                strengthStanceVariant6?.Invoke(StrengthStanceVariant6!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthStanceVariant1?>? strengthStanceVariant1 = null,
            global::System.Action<global::Terra.StrengthStanceVariant2?>? strengthStanceVariant2 = null,
            global::System.Action<global::Terra.StrengthStanceVariant3?>? strengthStanceVariant3 = null,
            global::System.Action<global::Terra.StrengthStanceVariant4?>? strengthStanceVariant4 = null,
            global::System.Action<global::Terra.StrengthStanceVariant5?>? strengthStanceVariant5 = null,
            global::System.Action<string>? strengthStanceVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthStanceVariant1)
            {
                strengthStanceVariant1?.Invoke(StrengthStanceVariant1!);
            }
            else if (IsStrengthStanceVariant2)
            {
                strengthStanceVariant2?.Invoke(StrengthStanceVariant2!);
            }
            else if (IsStrengthStanceVariant3)
            {
                strengthStanceVariant3?.Invoke(StrengthStanceVariant3!);
            }
            else if (IsStrengthStanceVariant4)
            {
                strengthStanceVariant4?.Invoke(StrengthStanceVariant4!);
            }
            else if (IsStrengthStanceVariant5)
            {
                strengthStanceVariant5?.Invoke(StrengthStanceVariant5!);
            }
            else if (IsStrengthStanceVariant6)
            {
                strengthStanceVariant6?.Invoke(StrengthStanceVariant6!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthStanceVariant1,
                typeof(global::Terra.StrengthStanceVariant1),
                StrengthStanceVariant2,
                typeof(global::Terra.StrengthStanceVariant2),
                StrengthStanceVariant3,
                typeof(global::Terra.StrengthStanceVariant3),
                StrengthStanceVariant4,
                typeof(global::Terra.StrengthStanceVariant4),
                StrengthStanceVariant5,
                typeof(global::Terra.StrengthStanceVariant5),
                StrengthStanceVariant6,
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
        public bool Equals(StrengthStance other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthStanceVariant1?>.Default.Equals(StrengthStanceVariant1, other.StrengthStanceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthStanceVariant2?>.Default.Equals(StrengthStanceVariant2, other.StrengthStanceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthStanceVariant3?>.Default.Equals(StrengthStanceVariant3, other.StrengthStanceVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthStanceVariant4?>.Default.Equals(StrengthStanceVariant4, other.StrengthStanceVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthStanceVariant5?>.Default.Equals(StrengthStanceVariant5, other.StrengthStanceVariant5) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthStanceVariant6, other.StrengthStanceVariant6)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthStance obj1, StrengthStance obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthStance>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthStance obj1, StrengthStance obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthStance o && Equals(o);
        }
    }
}

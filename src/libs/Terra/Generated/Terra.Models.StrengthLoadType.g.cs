#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// How to read weight_kg for this set. Open enum — handle unknown values gracefully.<br/>
    /// Example: assisted
    /// </summary>
    public readonly partial struct StrengthLoadType : global::System.IEquatable<StrengthLoadType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLoadTypeVariant1? StrengthLoadTypeVariant1 { get; init; }
#else
        public global::Terra.StrengthLoadTypeVariant1? StrengthLoadTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLoadTypeVariant1))]
#endif
        public bool IsStrengthLoadTypeVariant1 => StrengthLoadTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthLoadTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLoadTypeVariant1? value)
        {
            value = StrengthLoadTypeVariant1;
            return IsStrengthLoadTypeVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant1 PickStrengthLoadTypeVariant1() => IsStrengthLoadTypeVariant1
            ? StrengthLoadTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLoadTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLoadTypeVariant2? StrengthLoadTypeVariant2 { get; init; }
#else
        public global::Terra.StrengthLoadTypeVariant2? StrengthLoadTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLoadTypeVariant2))]
#endif
        public bool IsStrengthLoadTypeVariant2 => StrengthLoadTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthLoadTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLoadTypeVariant2? value)
        {
            value = StrengthLoadTypeVariant2;
            return IsStrengthLoadTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant2 PickStrengthLoadTypeVariant2() => IsStrengthLoadTypeVariant2
            ? StrengthLoadTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLoadTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLoadTypeVariant3? StrengthLoadTypeVariant3 { get; init; }
#else
        public global::Terra.StrengthLoadTypeVariant3? StrengthLoadTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLoadTypeVariant3))]
#endif
        public bool IsStrengthLoadTypeVariant3 => StrengthLoadTypeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthLoadTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLoadTypeVariant3? value)
        {
            value = StrengthLoadTypeVariant3;
            return IsStrengthLoadTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant3 PickStrengthLoadTypeVariant3() => IsStrengthLoadTypeVariant3
            ? StrengthLoadTypeVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLoadTypeVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLoadTypeVariant4? StrengthLoadTypeVariant4 { get; init; }
#else
        public global::Terra.StrengthLoadTypeVariant4? StrengthLoadTypeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLoadTypeVariant4))]
#endif
        public bool IsStrengthLoadTypeVariant4 => StrengthLoadTypeVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthLoadTypeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLoadTypeVariant4? value)
        {
            value = StrengthLoadTypeVariant4;
            return IsStrengthLoadTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant4 PickStrengthLoadTypeVariant4() => IsStrengthLoadTypeVariant4
            ? StrengthLoadTypeVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLoadTypeVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLoadTypeVariant5? StrengthLoadTypeVariant5 { get; init; }
#else
        public global::Terra.StrengthLoadTypeVariant5? StrengthLoadTypeVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLoadTypeVariant5))]
#endif
        public bool IsStrengthLoadTypeVariant5 => StrengthLoadTypeVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthLoadTypeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLoadTypeVariant5? value)
        {
            value = StrengthLoadTypeVariant5;
            return IsStrengthLoadTypeVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthLoadTypeVariant5 PickStrengthLoadTypeVariant5() => IsStrengthLoadTypeVariant5
            ? StrengthLoadTypeVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLoadTypeVariant5' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthLoadTypeVariant6 { get; init; }
#else
        public string? StrengthLoadTypeVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLoadTypeVariant6))]
#endif
        public bool IsStrengthLoadTypeVariant6 => StrengthLoadTypeVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthLoadTypeVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthLoadTypeVariant6;
            return IsStrengthLoadTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickStrengthLoadTypeVariant6() => IsStrengthLoadTypeVariant6
            ? StrengthLoadTypeVariant6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLoadTypeVariant6' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthLoadType(global::Terra.StrengthLoadTypeVariant1 value) => new StrengthLoadType((global::Terra.StrengthLoadTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthLoadTypeVariant1?(StrengthLoadType @this) => @this.StrengthLoadTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StrengthLoadType(global::Terra.StrengthLoadTypeVariant1? value)
        {
            StrengthLoadTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthLoadType FromStrengthLoadTypeVariant1(global::Terra.StrengthLoadTypeVariant1? value) => new StrengthLoadType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthLoadType(global::Terra.StrengthLoadTypeVariant2 value) => new StrengthLoadType((global::Terra.StrengthLoadTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthLoadTypeVariant2?(StrengthLoadType @this) => @this.StrengthLoadTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StrengthLoadType(global::Terra.StrengthLoadTypeVariant2? value)
        {
            StrengthLoadTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthLoadType FromStrengthLoadTypeVariant2(global::Terra.StrengthLoadTypeVariant2? value) => new StrengthLoadType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthLoadType(global::Terra.StrengthLoadTypeVariant3 value) => new StrengthLoadType((global::Terra.StrengthLoadTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthLoadTypeVariant3?(StrengthLoadType @this) => @this.StrengthLoadTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StrengthLoadType(global::Terra.StrengthLoadTypeVariant3? value)
        {
            StrengthLoadTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthLoadType FromStrengthLoadTypeVariant3(global::Terra.StrengthLoadTypeVariant3? value) => new StrengthLoadType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthLoadType(global::Terra.StrengthLoadTypeVariant4 value) => new StrengthLoadType((global::Terra.StrengthLoadTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthLoadTypeVariant4?(StrengthLoadType @this) => @this.StrengthLoadTypeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public StrengthLoadType(global::Terra.StrengthLoadTypeVariant4? value)
        {
            StrengthLoadTypeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthLoadType FromStrengthLoadTypeVariant4(global::Terra.StrengthLoadTypeVariant4? value) => new StrengthLoadType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthLoadType(global::Terra.StrengthLoadTypeVariant5 value) => new StrengthLoadType((global::Terra.StrengthLoadTypeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthLoadTypeVariant5?(StrengthLoadType @this) => @this.StrengthLoadTypeVariant5;

        /// <summary>
        /// 
        /// </summary>
        public StrengthLoadType(global::Terra.StrengthLoadTypeVariant5? value)
        {
            StrengthLoadTypeVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthLoadType FromStrengthLoadTypeVariant5(global::Terra.StrengthLoadTypeVariant5? value) => new StrengthLoadType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthLoadType(string value) => new StrengthLoadType((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StrengthLoadType @this) => @this.StrengthLoadTypeVariant6;

        /// <summary>
        /// 
        /// </summary>
        public StrengthLoadType(string? value)
        {
            StrengthLoadTypeVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthLoadType FromStrengthLoadTypeVariant6(string? value) => new StrengthLoadType(value);

        /// <summary>
        /// 
        /// </summary>
        public StrengthLoadType(
            global::Terra.StrengthLoadTypeVariant1? strengthLoadTypeVariant1,
            global::Terra.StrengthLoadTypeVariant2? strengthLoadTypeVariant2,
            global::Terra.StrengthLoadTypeVariant3? strengthLoadTypeVariant3,
            global::Terra.StrengthLoadTypeVariant4? strengthLoadTypeVariant4,
            global::Terra.StrengthLoadTypeVariant5? strengthLoadTypeVariant5,
            string? strengthLoadTypeVariant6
            )
        {
            StrengthLoadTypeVariant1 = strengthLoadTypeVariant1;
            StrengthLoadTypeVariant2 = strengthLoadTypeVariant2;
            StrengthLoadTypeVariant3 = strengthLoadTypeVariant3;
            StrengthLoadTypeVariant4 = strengthLoadTypeVariant4;
            StrengthLoadTypeVariant5 = strengthLoadTypeVariant5;
            StrengthLoadTypeVariant6 = strengthLoadTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StrengthLoadTypeVariant6 as object ??
            StrengthLoadTypeVariant5 as object ??
            StrengthLoadTypeVariant4 as object ??
            StrengthLoadTypeVariant3 as object ??
            StrengthLoadTypeVariant2 as object ??
            StrengthLoadTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StrengthLoadTypeVariant1?.ToValueString() ??
            StrengthLoadTypeVariant2?.ToValueString() ??
            StrengthLoadTypeVariant3?.ToValueString() ??
            StrengthLoadTypeVariant4?.ToValueString() ??
            StrengthLoadTypeVariant5?.ToValueString() ??
            StrengthLoadTypeVariant6?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStrengthLoadTypeVariant1 || IsStrengthLoadTypeVariant2 || IsStrengthLoadTypeVariant3 || IsStrengthLoadTypeVariant4 || IsStrengthLoadTypeVariant5 || IsStrengthLoadTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthLoadTypeVariant1?, TResult>? strengthLoadTypeVariant1 = null,
            global::System.Func<global::Terra.StrengthLoadTypeVariant2?, TResult>? strengthLoadTypeVariant2 = null,
            global::System.Func<global::Terra.StrengthLoadTypeVariant3?, TResult>? strengthLoadTypeVariant3 = null,
            global::System.Func<global::Terra.StrengthLoadTypeVariant4?, TResult>? strengthLoadTypeVariant4 = null,
            global::System.Func<global::Terra.StrengthLoadTypeVariant5?, TResult>? strengthLoadTypeVariant5 = null,
            global::System.Func<string, TResult>? strengthLoadTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthLoadTypeVariant1 && strengthLoadTypeVariant1 != null)
            {
                return strengthLoadTypeVariant1(StrengthLoadTypeVariant1!);
            }
            else if (IsStrengthLoadTypeVariant2 && strengthLoadTypeVariant2 != null)
            {
                return strengthLoadTypeVariant2(StrengthLoadTypeVariant2!);
            }
            else if (IsStrengthLoadTypeVariant3 && strengthLoadTypeVariant3 != null)
            {
                return strengthLoadTypeVariant3(StrengthLoadTypeVariant3!);
            }
            else if (IsStrengthLoadTypeVariant4 && strengthLoadTypeVariant4 != null)
            {
                return strengthLoadTypeVariant4(StrengthLoadTypeVariant4!);
            }
            else if (IsStrengthLoadTypeVariant5 && strengthLoadTypeVariant5 != null)
            {
                return strengthLoadTypeVariant5(StrengthLoadTypeVariant5!);
            }
            else if (IsStrengthLoadTypeVariant6 && strengthLoadTypeVariant6 != null)
            {
                return strengthLoadTypeVariant6(StrengthLoadTypeVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthLoadTypeVariant1?>? strengthLoadTypeVariant1 = null,

            global::System.Action<global::Terra.StrengthLoadTypeVariant2?>? strengthLoadTypeVariant2 = null,

            global::System.Action<global::Terra.StrengthLoadTypeVariant3?>? strengthLoadTypeVariant3 = null,

            global::System.Action<global::Terra.StrengthLoadTypeVariant4?>? strengthLoadTypeVariant4 = null,

            global::System.Action<global::Terra.StrengthLoadTypeVariant5?>? strengthLoadTypeVariant5 = null,

            global::System.Action<string>? strengthLoadTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthLoadTypeVariant1)
            {
                strengthLoadTypeVariant1?.Invoke(StrengthLoadTypeVariant1!);
            }
            else if (IsStrengthLoadTypeVariant2)
            {
                strengthLoadTypeVariant2?.Invoke(StrengthLoadTypeVariant2!);
            }
            else if (IsStrengthLoadTypeVariant3)
            {
                strengthLoadTypeVariant3?.Invoke(StrengthLoadTypeVariant3!);
            }
            else if (IsStrengthLoadTypeVariant4)
            {
                strengthLoadTypeVariant4?.Invoke(StrengthLoadTypeVariant4!);
            }
            else if (IsStrengthLoadTypeVariant5)
            {
                strengthLoadTypeVariant5?.Invoke(StrengthLoadTypeVariant5!);
            }
            else if (IsStrengthLoadTypeVariant6)
            {
                strengthLoadTypeVariant6?.Invoke(StrengthLoadTypeVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthLoadTypeVariant1?>? strengthLoadTypeVariant1 = null,
            global::System.Action<global::Terra.StrengthLoadTypeVariant2?>? strengthLoadTypeVariant2 = null,
            global::System.Action<global::Terra.StrengthLoadTypeVariant3?>? strengthLoadTypeVariant3 = null,
            global::System.Action<global::Terra.StrengthLoadTypeVariant4?>? strengthLoadTypeVariant4 = null,
            global::System.Action<global::Terra.StrengthLoadTypeVariant5?>? strengthLoadTypeVariant5 = null,
            global::System.Action<string>? strengthLoadTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthLoadTypeVariant1)
            {
                strengthLoadTypeVariant1?.Invoke(StrengthLoadTypeVariant1!);
            }
            else if (IsStrengthLoadTypeVariant2)
            {
                strengthLoadTypeVariant2?.Invoke(StrengthLoadTypeVariant2!);
            }
            else if (IsStrengthLoadTypeVariant3)
            {
                strengthLoadTypeVariant3?.Invoke(StrengthLoadTypeVariant3!);
            }
            else if (IsStrengthLoadTypeVariant4)
            {
                strengthLoadTypeVariant4?.Invoke(StrengthLoadTypeVariant4!);
            }
            else if (IsStrengthLoadTypeVariant5)
            {
                strengthLoadTypeVariant5?.Invoke(StrengthLoadTypeVariant5!);
            }
            else if (IsStrengthLoadTypeVariant6)
            {
                strengthLoadTypeVariant6?.Invoke(StrengthLoadTypeVariant6!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthLoadTypeVariant1,
                typeof(global::Terra.StrengthLoadTypeVariant1),
                StrengthLoadTypeVariant2,
                typeof(global::Terra.StrengthLoadTypeVariant2),
                StrengthLoadTypeVariant3,
                typeof(global::Terra.StrengthLoadTypeVariant3),
                StrengthLoadTypeVariant4,
                typeof(global::Terra.StrengthLoadTypeVariant4),
                StrengthLoadTypeVariant5,
                typeof(global::Terra.StrengthLoadTypeVariant5),
                StrengthLoadTypeVariant6,
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
        public bool Equals(StrengthLoadType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLoadTypeVariant1?>.Default.Equals(StrengthLoadTypeVariant1, other.StrengthLoadTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLoadTypeVariant2?>.Default.Equals(StrengthLoadTypeVariant2, other.StrengthLoadTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLoadTypeVariant3?>.Default.Equals(StrengthLoadTypeVariant3, other.StrengthLoadTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLoadTypeVariant4?>.Default.Equals(StrengthLoadTypeVariant4, other.StrengthLoadTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLoadTypeVariant5?>.Default.Equals(StrengthLoadTypeVariant5, other.StrengthLoadTypeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthLoadTypeVariant6, other.StrengthLoadTypeVariant6) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StrengthLoadType obj1, StrengthLoadType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthLoadType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StrengthLoadType obj1, StrengthLoadType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthLoadType o && Equals(o);
        }
    }
}

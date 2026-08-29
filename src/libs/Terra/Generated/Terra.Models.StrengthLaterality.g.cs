#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Whether both limbs work together, alternately, or one at a time. Open enum — handle unknown values gracefully.<br/>
    /// Example: alternating
    /// </summary>
    public readonly partial struct StrengthLaterality : global::System.IEquatable<StrengthLaterality>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLateralityVariant1? StrengthLateralityVariant1 { get; init; }
#else
        public global::Terra.StrengthLateralityVariant1? StrengthLateralityVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLateralityVariant1))]
#endif
        public bool IsStrengthLateralityVariant1 => StrengthLateralityVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthLateralityVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLateralityVariant1? value)
        {
            value = StrengthLateralityVariant1;
            return IsStrengthLateralityVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant1 PickStrengthLateralityVariant1() => IsStrengthLateralityVariant1
            ? StrengthLateralityVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLateralityVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLateralityVariant2? StrengthLateralityVariant2 { get; init; }
#else
        public global::Terra.StrengthLateralityVariant2? StrengthLateralityVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLateralityVariant2))]
#endif
        public bool IsStrengthLateralityVariant2 => StrengthLateralityVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthLateralityVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLateralityVariant2? value)
        {
            value = StrengthLateralityVariant2;
            return IsStrengthLateralityVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant2 PickStrengthLateralityVariant2() => IsStrengthLateralityVariant2
            ? StrengthLateralityVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLateralityVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLateralityVariant3? StrengthLateralityVariant3 { get; init; }
#else
        public global::Terra.StrengthLateralityVariant3? StrengthLateralityVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLateralityVariant3))]
#endif
        public bool IsStrengthLateralityVariant3 => StrengthLateralityVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthLateralityVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLateralityVariant3? value)
        {
            value = StrengthLateralityVariant3;
            return IsStrengthLateralityVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant3 PickStrengthLateralityVariant3() => IsStrengthLateralityVariant3
            ? StrengthLateralityVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLateralityVariant3' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthLateralityVariant4? StrengthLateralityVariant4 { get; init; }
#else
        public global::Terra.StrengthLateralityVariant4? StrengthLateralityVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLateralityVariant4))]
#endif
        public bool IsStrengthLateralityVariant4 => StrengthLateralityVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthLateralityVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthLateralityVariant4? value)
        {
            value = StrengthLateralityVariant4;
            return IsStrengthLateralityVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StrengthLateralityVariant4 PickStrengthLateralityVariant4() => IsStrengthLateralityVariant4
            ? StrengthLateralityVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLateralityVariant4' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthLateralityVariant5 { get; init; }
#else
        public string? StrengthLateralityVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthLateralityVariant5))]
#endif
        public bool IsStrengthLateralityVariant5 => StrengthLateralityVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStrengthLateralityVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthLateralityVariant5;
            return IsStrengthLateralityVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickStrengthLateralityVariant5() => IsStrengthLateralityVariant5
            ? StrengthLateralityVariant5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthLateralityVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthLaterality(global::Terra.StrengthLateralityVariant1 value) => new StrengthLaterality((global::Terra.StrengthLateralityVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthLateralityVariant1?(StrengthLaterality @this) => @this.StrengthLateralityVariant1;

        /// <summary>
        ///
        /// </summary>
        public StrengthLaterality(global::Terra.StrengthLateralityVariant1? value)
        {
            StrengthLateralityVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthLaterality FromStrengthLateralityVariant1(global::Terra.StrengthLateralityVariant1? value) => new StrengthLaterality(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthLaterality(global::Terra.StrengthLateralityVariant2 value) => new StrengthLaterality((global::Terra.StrengthLateralityVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthLateralityVariant2?(StrengthLaterality @this) => @this.StrengthLateralityVariant2;

        /// <summary>
        ///
        /// </summary>
        public StrengthLaterality(global::Terra.StrengthLateralityVariant2? value)
        {
            StrengthLateralityVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthLaterality FromStrengthLateralityVariant2(global::Terra.StrengthLateralityVariant2? value) => new StrengthLaterality(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthLaterality(global::Terra.StrengthLateralityVariant3 value) => new StrengthLaterality((global::Terra.StrengthLateralityVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthLateralityVariant3?(StrengthLaterality @this) => @this.StrengthLateralityVariant3;

        /// <summary>
        ///
        /// </summary>
        public StrengthLaterality(global::Terra.StrengthLateralityVariant3? value)
        {
            StrengthLateralityVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthLaterality FromStrengthLateralityVariant3(global::Terra.StrengthLateralityVariant3? value) => new StrengthLaterality(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthLaterality(global::Terra.StrengthLateralityVariant4 value) => new StrengthLaterality((global::Terra.StrengthLateralityVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StrengthLateralityVariant4?(StrengthLaterality @this) => @this.StrengthLateralityVariant4;

        /// <summary>
        ///
        /// </summary>
        public StrengthLaterality(global::Terra.StrengthLateralityVariant4? value)
        {
            StrengthLateralityVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthLaterality FromStrengthLateralityVariant4(global::Terra.StrengthLateralityVariant4? value) => new StrengthLaterality(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StrengthLaterality(string value) => new StrengthLaterality((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(StrengthLaterality @this) => @this.StrengthLateralityVariant5;

        /// <summary>
        ///
        /// </summary>
        public StrengthLaterality(string? value)
        {
            StrengthLateralityVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StrengthLaterality FromStrengthLateralityVariant5(string? value) => new StrengthLaterality(value);

        /// <summary>
        ///
        /// </summary>
        public StrengthLaterality(
            global::Terra.StrengthLateralityVariant1? strengthLateralityVariant1,
            global::Terra.StrengthLateralityVariant2? strengthLateralityVariant2,
            global::Terra.StrengthLateralityVariant3? strengthLateralityVariant3,
            global::Terra.StrengthLateralityVariant4? strengthLateralityVariant4,
            string? strengthLateralityVariant5
            )
        {
            StrengthLateralityVariant1 = strengthLateralityVariant1;
            StrengthLateralityVariant2 = strengthLateralityVariant2;
            StrengthLateralityVariant3 = strengthLateralityVariant3;
            StrengthLateralityVariant4 = strengthLateralityVariant4;
            StrengthLateralityVariant5 = strengthLateralityVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StrengthLateralityVariant5 as object ??
            StrengthLateralityVariant4 as object ??
            StrengthLateralityVariant3 as object ??
            StrengthLateralityVariant2 as object ??
            StrengthLateralityVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StrengthLateralityVariant1?.ToValueString() ??
            StrengthLateralityVariant2?.ToValueString() ??
            StrengthLateralityVariant3?.ToValueString() ??
            StrengthLateralityVariant4?.ToValueString() ??
            StrengthLateralityVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStrengthLateralityVariant1 || IsStrengthLateralityVariant2 || IsStrengthLateralityVariant3 || IsStrengthLateralityVariant4 || IsStrengthLateralityVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthLateralityVariant1?, TResult>? strengthLateralityVariant1 = null,
            global::System.Func<global::Terra.StrengthLateralityVariant2?, TResult>? strengthLateralityVariant2 = null,
            global::System.Func<global::Terra.StrengthLateralityVariant3?, TResult>? strengthLateralityVariant3 = null,
            global::System.Func<global::Terra.StrengthLateralityVariant4?, TResult>? strengthLateralityVariant4 = null,
            global::System.Func<string, TResult>? strengthLateralityVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthLateralityVariant1 && strengthLateralityVariant1 != null)
            {
                return strengthLateralityVariant1(StrengthLateralityVariant1!);
            }
            else if (IsStrengthLateralityVariant2 && strengthLateralityVariant2 != null)
            {
                return strengthLateralityVariant2(StrengthLateralityVariant2!);
            }
            else if (IsStrengthLateralityVariant3 && strengthLateralityVariant3 != null)
            {
                return strengthLateralityVariant3(StrengthLateralityVariant3!);
            }
            else if (IsStrengthLateralityVariant4 && strengthLateralityVariant4 != null)
            {
                return strengthLateralityVariant4(StrengthLateralityVariant4!);
            }
            else if (IsStrengthLateralityVariant5 && strengthLateralityVariant5 != null)
            {
                return strengthLateralityVariant5(StrengthLateralityVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthLateralityVariant1?>? strengthLateralityVariant1 = null,

            global::System.Action<global::Terra.StrengthLateralityVariant2?>? strengthLateralityVariant2 = null,

            global::System.Action<global::Terra.StrengthLateralityVariant3?>? strengthLateralityVariant3 = null,

            global::System.Action<global::Terra.StrengthLateralityVariant4?>? strengthLateralityVariant4 = null,

            global::System.Action<string>? strengthLateralityVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthLateralityVariant1)
            {
                strengthLateralityVariant1?.Invoke(StrengthLateralityVariant1!);
            }
            else if (IsStrengthLateralityVariant2)
            {
                strengthLateralityVariant2?.Invoke(StrengthLateralityVariant2!);
            }
            else if (IsStrengthLateralityVariant3)
            {
                strengthLateralityVariant3?.Invoke(StrengthLateralityVariant3!);
            }
            else if (IsStrengthLateralityVariant4)
            {
                strengthLateralityVariant4?.Invoke(StrengthLateralityVariant4!);
            }
            else if (IsStrengthLateralityVariant5)
            {
                strengthLateralityVariant5?.Invoke(StrengthLateralityVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthLateralityVariant1?>? strengthLateralityVariant1 = null,
            global::System.Action<global::Terra.StrengthLateralityVariant2?>? strengthLateralityVariant2 = null,
            global::System.Action<global::Terra.StrengthLateralityVariant3?>? strengthLateralityVariant3 = null,
            global::System.Action<global::Terra.StrengthLateralityVariant4?>? strengthLateralityVariant4 = null,
            global::System.Action<string>? strengthLateralityVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthLateralityVariant1)
            {
                strengthLateralityVariant1?.Invoke(StrengthLateralityVariant1!);
            }
            else if (IsStrengthLateralityVariant2)
            {
                strengthLateralityVariant2?.Invoke(StrengthLateralityVariant2!);
            }
            else if (IsStrengthLateralityVariant3)
            {
                strengthLateralityVariant3?.Invoke(StrengthLateralityVariant3!);
            }
            else if (IsStrengthLateralityVariant4)
            {
                strengthLateralityVariant4?.Invoke(StrengthLateralityVariant4!);
            }
            else if (IsStrengthLateralityVariant5)
            {
                strengthLateralityVariant5?.Invoke(StrengthLateralityVariant5!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthLateralityVariant1,
                typeof(global::Terra.StrengthLateralityVariant1),
                StrengthLateralityVariant2,
                typeof(global::Terra.StrengthLateralityVariant2),
                StrengthLateralityVariant3,
                typeof(global::Terra.StrengthLateralityVariant3),
                StrengthLateralityVariant4,
                typeof(global::Terra.StrengthLateralityVariant4),
                StrengthLateralityVariant5,
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
        public bool Equals(StrengthLaterality other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLateralityVariant1?>.Default.Equals(StrengthLateralityVariant1, other.StrengthLateralityVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLateralityVariant2?>.Default.Equals(StrengthLateralityVariant2, other.StrengthLateralityVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLateralityVariant3?>.Default.Equals(StrengthLateralityVariant3, other.StrengthLateralityVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthLateralityVariant4?>.Default.Equals(StrengthLateralityVariant4, other.StrengthLateralityVariant4) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthLateralityVariant5, other.StrengthLateralityVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StrengthLaterality obj1, StrengthLaterality obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthLaterality>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StrengthLaterality obj1, StrengthLaterality obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthLaterality o && Equals(o);
        }
    }
}

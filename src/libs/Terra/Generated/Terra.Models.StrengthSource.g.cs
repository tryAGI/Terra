#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// How the exercise came to be recorded. Open enum — handle unknown values gracefully.<br/>
    /// Example: user_logged
    /// </summary>
    public readonly partial struct StrengthSource : global::System.IEquatable<StrengthSource>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSourceVariant1? StrengthSourceVariant1 { get; init; }
#else
        public global::Terra.StrengthSourceVariant1? StrengthSourceVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSourceVariant1))]
#endif
        public bool IsStrengthSourceVariant1 => StrengthSourceVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthSourceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSourceVariant1? value)
        {
            value = StrengthSourceVariant1;
            return IsStrengthSourceVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthSourceVariant1 PickStrengthSourceVariant1() => IsStrengthSourceVariant1
            ? StrengthSourceVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSourceVariant1' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthSourceVariant2? StrengthSourceVariant2 { get; init; }
#else
        public global::Terra.StrengthSourceVariant2? StrengthSourceVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSourceVariant2))]
#endif
        public bool IsStrengthSourceVariant2 => StrengthSourceVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthSourceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthSourceVariant2? value)
        {
            value = StrengthSourceVariant2;
            return IsStrengthSourceVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthSourceVariant2 PickStrengthSourceVariant2() => IsStrengthSourceVariant2
            ? StrengthSourceVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSourceVariant2' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthSourceVariant3 { get; init; }
#else
        public string? StrengthSourceVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthSourceVariant3))]
#endif
        public bool IsStrengthSourceVariant3 => StrengthSourceVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthSourceVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthSourceVariant3;
            return IsStrengthSourceVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickStrengthSourceVariant3() => IsStrengthSourceVariant3
            ? StrengthSourceVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthSourceVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthSource(global::Terra.StrengthSourceVariant1 value) => new StrengthSource((global::Terra.StrengthSourceVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthSourceVariant1?(StrengthSource @this) => @this.StrengthSourceVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StrengthSource(global::Terra.StrengthSourceVariant1? value)
        {
            StrengthSourceVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthSource FromStrengthSourceVariant1(global::Terra.StrengthSourceVariant1? value) => new StrengthSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthSource(global::Terra.StrengthSourceVariant2 value) => new StrengthSource((global::Terra.StrengthSourceVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthSourceVariant2?(StrengthSource @this) => @this.StrengthSourceVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StrengthSource(global::Terra.StrengthSourceVariant2? value)
        {
            StrengthSourceVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthSource FromStrengthSourceVariant2(global::Terra.StrengthSourceVariant2? value) => new StrengthSource(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthSource(string value) => new StrengthSource((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StrengthSource @this) => @this.StrengthSourceVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StrengthSource(string? value)
        {
            StrengthSourceVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthSource FromStrengthSourceVariant3(string? value) => new StrengthSource(value);

        /// <summary>
        /// 
        /// </summary>
        public StrengthSource(
            global::Terra.StrengthSourceVariant1? strengthSourceVariant1,
            global::Terra.StrengthSourceVariant2? strengthSourceVariant2,
            string? strengthSourceVariant3
            )
        {
            StrengthSourceVariant1 = strengthSourceVariant1;
            StrengthSourceVariant2 = strengthSourceVariant2;
            StrengthSourceVariant3 = strengthSourceVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StrengthSourceVariant3 as object ??
            StrengthSourceVariant2 as object ??
            StrengthSourceVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StrengthSourceVariant1?.ToValueString() ??
            StrengthSourceVariant2?.ToValueString() ??
            StrengthSourceVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStrengthSourceVariant1 || IsStrengthSourceVariant2 || IsStrengthSourceVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthSourceVariant1?, TResult>? strengthSourceVariant1 = null,
            global::System.Func<global::Terra.StrengthSourceVariant2?, TResult>? strengthSourceVariant2 = null,
            global::System.Func<string, TResult>? strengthSourceVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthSourceVariant1 && strengthSourceVariant1 != null)
            {
                return strengthSourceVariant1(StrengthSourceVariant1!);
            }
            else if (IsStrengthSourceVariant2 && strengthSourceVariant2 != null)
            {
                return strengthSourceVariant2(StrengthSourceVariant2!);
            }
            else if (IsStrengthSourceVariant3 && strengthSourceVariant3 != null)
            {
                return strengthSourceVariant3(StrengthSourceVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthSourceVariant1?>? strengthSourceVariant1 = null,

            global::System.Action<global::Terra.StrengthSourceVariant2?>? strengthSourceVariant2 = null,

            global::System.Action<string>? strengthSourceVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthSourceVariant1)
            {
                strengthSourceVariant1?.Invoke(StrengthSourceVariant1!);
            }
            else if (IsStrengthSourceVariant2)
            {
                strengthSourceVariant2?.Invoke(StrengthSourceVariant2!);
            }
            else if (IsStrengthSourceVariant3)
            {
                strengthSourceVariant3?.Invoke(StrengthSourceVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthSourceVariant1?>? strengthSourceVariant1 = null,
            global::System.Action<global::Terra.StrengthSourceVariant2?>? strengthSourceVariant2 = null,
            global::System.Action<string>? strengthSourceVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthSourceVariant1)
            {
                strengthSourceVariant1?.Invoke(StrengthSourceVariant1!);
            }
            else if (IsStrengthSourceVariant2)
            {
                strengthSourceVariant2?.Invoke(StrengthSourceVariant2!);
            }
            else if (IsStrengthSourceVariant3)
            {
                strengthSourceVariant3?.Invoke(StrengthSourceVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthSourceVariant1,
                typeof(global::Terra.StrengthSourceVariant1),
                StrengthSourceVariant2,
                typeof(global::Terra.StrengthSourceVariant2),
                StrengthSourceVariant3,
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
        public bool Equals(StrengthSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSourceVariant1?>.Default.Equals(StrengthSourceVariant1, other.StrengthSourceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthSourceVariant2?>.Default.Equals(StrengthSourceVariant2, other.StrengthSourceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthSourceVariant3, other.StrengthSourceVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StrengthSource obj1, StrengthSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StrengthSource obj1, StrengthSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthSource o && Equals(o);
        }
    }
}

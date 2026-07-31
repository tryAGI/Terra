#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// A programme or population the variant belongs to. Descriptive only — it changes neither the movement nor the load. Open enum — handle unknown values gracefully.<br/>
    /// Example: pregnancy
    /// </summary>
    public readonly partial struct StrengthProgramme : global::System.IEquatable<StrengthProgramme>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthProgrammeVariant1? StrengthProgrammeVariant1 { get; init; }
#else
        public global::Terra.StrengthProgrammeVariant1? StrengthProgrammeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthProgrammeVariant1))]
#endif
        public bool IsStrengthProgrammeVariant1 => StrengthProgrammeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthProgrammeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthProgrammeVariant1? value)
        {
            value = StrengthProgrammeVariant1;
            return IsStrengthProgrammeVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthProgrammeVariant1 PickStrengthProgrammeVariant1() => IsStrengthProgrammeVariant1
            ? StrengthProgrammeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthProgrammeVariant1' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthProgrammeVariant2? StrengthProgrammeVariant2 { get; init; }
#else
        public global::Terra.StrengthProgrammeVariant2? StrengthProgrammeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthProgrammeVariant2))]
#endif
        public bool IsStrengthProgrammeVariant2 => StrengthProgrammeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthProgrammeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthProgrammeVariant2? value)
        {
            value = StrengthProgrammeVariant2;
            return IsStrengthProgrammeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthProgrammeVariant2 PickStrengthProgrammeVariant2() => IsStrengthProgrammeVariant2
            ? StrengthProgrammeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthProgrammeVariant2' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthProgrammeVariant3 { get; init; }
#else
        public string? StrengthProgrammeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthProgrammeVariant3))]
#endif
        public bool IsStrengthProgrammeVariant3 => StrengthProgrammeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthProgrammeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthProgrammeVariant3;
            return IsStrengthProgrammeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickStrengthProgrammeVariant3() => IsStrengthProgrammeVariant3
            ? StrengthProgrammeVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthProgrammeVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthProgramme(global::Terra.StrengthProgrammeVariant1 value) => new StrengthProgramme((global::Terra.StrengthProgrammeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthProgrammeVariant1?(StrengthProgramme @this) => @this.StrengthProgrammeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StrengthProgramme(global::Terra.StrengthProgrammeVariant1? value)
        {
            StrengthProgrammeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthProgramme FromStrengthProgrammeVariant1(global::Terra.StrengthProgrammeVariant1? value) => new StrengthProgramme(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthProgramme(global::Terra.StrengthProgrammeVariant2 value) => new StrengthProgramme((global::Terra.StrengthProgrammeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthProgrammeVariant2?(StrengthProgramme @this) => @this.StrengthProgrammeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StrengthProgramme(global::Terra.StrengthProgrammeVariant2? value)
        {
            StrengthProgrammeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthProgramme FromStrengthProgrammeVariant2(global::Terra.StrengthProgrammeVariant2? value) => new StrengthProgramme(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthProgramme(string value) => new StrengthProgramme((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StrengthProgramme @this) => @this.StrengthProgrammeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StrengthProgramme(string? value)
        {
            StrengthProgrammeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthProgramme FromStrengthProgrammeVariant3(string? value) => new StrengthProgramme(value);

        /// <summary>
        /// 
        /// </summary>
        public StrengthProgramme(
            global::Terra.StrengthProgrammeVariant1? strengthProgrammeVariant1,
            global::Terra.StrengthProgrammeVariant2? strengthProgrammeVariant2,
            string? strengthProgrammeVariant3
            )
        {
            StrengthProgrammeVariant1 = strengthProgrammeVariant1;
            StrengthProgrammeVariant2 = strengthProgrammeVariant2;
            StrengthProgrammeVariant3 = strengthProgrammeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StrengthProgrammeVariant3 as object ??
            StrengthProgrammeVariant2 as object ??
            StrengthProgrammeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StrengthProgrammeVariant1?.ToValueString() ??
            StrengthProgrammeVariant2?.ToValueString() ??
            StrengthProgrammeVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStrengthProgrammeVariant1 || IsStrengthProgrammeVariant2 || IsStrengthProgrammeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthProgrammeVariant1?, TResult>? strengthProgrammeVariant1 = null,
            global::System.Func<global::Terra.StrengthProgrammeVariant2?, TResult>? strengthProgrammeVariant2 = null,
            global::System.Func<string, TResult>? strengthProgrammeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthProgrammeVariant1 && strengthProgrammeVariant1 != null)
            {
                return strengthProgrammeVariant1(StrengthProgrammeVariant1!);
            }
            else if (IsStrengthProgrammeVariant2 && strengthProgrammeVariant2 != null)
            {
                return strengthProgrammeVariant2(StrengthProgrammeVariant2!);
            }
            else if (IsStrengthProgrammeVariant3 && strengthProgrammeVariant3 != null)
            {
                return strengthProgrammeVariant3(StrengthProgrammeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthProgrammeVariant1?>? strengthProgrammeVariant1 = null,

            global::System.Action<global::Terra.StrengthProgrammeVariant2?>? strengthProgrammeVariant2 = null,

            global::System.Action<string>? strengthProgrammeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthProgrammeVariant1)
            {
                strengthProgrammeVariant1?.Invoke(StrengthProgrammeVariant1!);
            }
            else if (IsStrengthProgrammeVariant2)
            {
                strengthProgrammeVariant2?.Invoke(StrengthProgrammeVariant2!);
            }
            else if (IsStrengthProgrammeVariant3)
            {
                strengthProgrammeVariant3?.Invoke(StrengthProgrammeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthProgrammeVariant1?>? strengthProgrammeVariant1 = null,
            global::System.Action<global::Terra.StrengthProgrammeVariant2?>? strengthProgrammeVariant2 = null,
            global::System.Action<string>? strengthProgrammeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthProgrammeVariant1)
            {
                strengthProgrammeVariant1?.Invoke(StrengthProgrammeVariant1!);
            }
            else if (IsStrengthProgrammeVariant2)
            {
                strengthProgrammeVariant2?.Invoke(StrengthProgrammeVariant2!);
            }
            else if (IsStrengthProgrammeVariant3)
            {
                strengthProgrammeVariant3?.Invoke(StrengthProgrammeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthProgrammeVariant1,
                typeof(global::Terra.StrengthProgrammeVariant1),
                StrengthProgrammeVariant2,
                typeof(global::Terra.StrengthProgrammeVariant2),
                StrengthProgrammeVariant3,
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
        public bool Equals(StrengthProgramme other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthProgrammeVariant1?>.Default.Equals(StrengthProgrammeVariant1, other.StrengthProgrammeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthProgrammeVariant2?>.Default.Equals(StrengthProgrammeVariant2, other.StrengthProgrammeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthProgrammeVariant3, other.StrengthProgrammeVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StrengthProgramme obj1, StrengthProgramme obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthProgramme>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StrengthProgramme obj1, StrengthProgramme obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthProgramme o && Equals(o);
        }
    }
}

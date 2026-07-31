#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// How far apart the hands are. Open enum — handle unknown values gracefully.<br/>
    /// Example: close
    /// </summary>
    public readonly partial struct StrengthGripWidth : global::System.IEquatable<StrengthGripWidth>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripWidthVariant1? StrengthGripWidthVariant1 { get; init; }
#else
        public global::Terra.StrengthGripWidthVariant1? StrengthGripWidthVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripWidthVariant1))]
#endif
        public bool IsStrengthGripWidthVariant1 => StrengthGripWidthVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthGripWidthVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripWidthVariant1? value)
        {
            value = StrengthGripWidthVariant1;
            return IsStrengthGripWidthVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthGripWidthVariant1 PickStrengthGripWidthVariant1() => IsStrengthGripWidthVariant1
            ? StrengthGripWidthVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripWidthVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripWidthVariant2? StrengthGripWidthVariant2 { get; init; }
#else
        public global::Terra.StrengthGripWidthVariant2? StrengthGripWidthVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripWidthVariant2))]
#endif
        public bool IsStrengthGripWidthVariant2 => StrengthGripWidthVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthGripWidthVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripWidthVariant2? value)
        {
            value = StrengthGripWidthVariant2;
            return IsStrengthGripWidthVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthGripWidthVariant2 PickStrengthGripWidthVariant2() => IsStrengthGripWidthVariant2
            ? StrengthGripWidthVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripWidthVariant2' but the value was {ToString()}.");

        /// <summary>
        /// The source reported a value here but it could not be resolved. Distinct from the field being absent, which means the source reported nothing at all.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StrengthGripWidthVariant3? StrengthGripWidthVariant3 { get; init; }
#else
        public global::Terra.StrengthGripWidthVariant3? StrengthGripWidthVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripWidthVariant3))]
#endif
        public bool IsStrengthGripWidthVariant3 => StrengthGripWidthVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthGripWidthVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StrengthGripWidthVariant3? value)
        {
            value = StrengthGripWidthVariant3;
            return IsStrengthGripWidthVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.StrengthGripWidthVariant3 PickStrengthGripWidthVariant3() => IsStrengthGripWidthVariant3
            ? StrengthGripWidthVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripWidthVariant3' but the value was {ToString()}.");

        /// <summary>
        /// A value Terra has added since this schema was published.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? StrengthGripWidthVariant4 { get; init; }
#else
        public string? StrengthGripWidthVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrengthGripWidthVariant4))]
#endif
        public bool IsStrengthGripWidthVariant4 => StrengthGripWidthVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStrengthGripWidthVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = StrengthGripWidthVariant4;
            return IsStrengthGripWidthVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickStrengthGripWidthVariant4() => IsStrengthGripWidthVariant4
            ? StrengthGripWidthVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StrengthGripWidthVariant4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthGripWidth(global::Terra.StrengthGripWidthVariant1 value) => new StrengthGripWidth((global::Terra.StrengthGripWidthVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthGripWidthVariant1?(StrengthGripWidth @this) => @this.StrengthGripWidthVariant1;

        /// <summary>
        /// 
        /// </summary>
        public StrengthGripWidth(global::Terra.StrengthGripWidthVariant1? value)
        {
            StrengthGripWidthVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthGripWidth FromStrengthGripWidthVariant1(global::Terra.StrengthGripWidthVariant1? value) => new StrengthGripWidth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthGripWidth(global::Terra.StrengthGripWidthVariant2 value) => new StrengthGripWidth((global::Terra.StrengthGripWidthVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthGripWidthVariant2?(StrengthGripWidth @this) => @this.StrengthGripWidthVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StrengthGripWidth(global::Terra.StrengthGripWidthVariant2? value)
        {
            StrengthGripWidthVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthGripWidth FromStrengthGripWidthVariant2(global::Terra.StrengthGripWidthVariant2? value) => new StrengthGripWidth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthGripWidth(global::Terra.StrengthGripWidthVariant3 value) => new StrengthGripWidth((global::Terra.StrengthGripWidthVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.StrengthGripWidthVariant3?(StrengthGripWidth @this) => @this.StrengthGripWidthVariant3;

        /// <summary>
        /// 
        /// </summary>
        public StrengthGripWidth(global::Terra.StrengthGripWidthVariant3? value)
        {
            StrengthGripWidthVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthGripWidth FromStrengthGripWidthVariant3(global::Terra.StrengthGripWidthVariant3? value) => new StrengthGripWidth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StrengthGripWidth(string value) => new StrengthGripWidth((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(StrengthGripWidth @this) => @this.StrengthGripWidthVariant4;

        /// <summary>
        /// 
        /// </summary>
        public StrengthGripWidth(string? value)
        {
            StrengthGripWidthVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StrengthGripWidth FromStrengthGripWidthVariant4(string? value) => new StrengthGripWidth(value);

        /// <summary>
        /// 
        /// </summary>
        public StrengthGripWidth(
            global::Terra.StrengthGripWidthVariant1? strengthGripWidthVariant1,
            global::Terra.StrengthGripWidthVariant2? strengthGripWidthVariant2,
            global::Terra.StrengthGripWidthVariant3? strengthGripWidthVariant3,
            string? strengthGripWidthVariant4
            )
        {
            StrengthGripWidthVariant1 = strengthGripWidthVariant1;
            StrengthGripWidthVariant2 = strengthGripWidthVariant2;
            StrengthGripWidthVariant3 = strengthGripWidthVariant3;
            StrengthGripWidthVariant4 = strengthGripWidthVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StrengthGripWidthVariant4 as object ??
            StrengthGripWidthVariant3 as object ??
            StrengthGripWidthVariant2 as object ??
            StrengthGripWidthVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StrengthGripWidthVariant1?.ToValueString() ??
            StrengthGripWidthVariant2?.ToValueString() ??
            StrengthGripWidthVariant3?.ToValueString() ??
            StrengthGripWidthVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStrengthGripWidthVariant1 || IsStrengthGripWidthVariant2 || IsStrengthGripWidthVariant3 || IsStrengthGripWidthVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StrengthGripWidthVariant1?, TResult>? strengthGripWidthVariant1 = null,
            global::System.Func<global::Terra.StrengthGripWidthVariant2?, TResult>? strengthGripWidthVariant2 = null,
            global::System.Func<global::Terra.StrengthGripWidthVariant3?, TResult>? strengthGripWidthVariant3 = null,
            global::System.Func<string, TResult>? strengthGripWidthVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthGripWidthVariant1 && strengthGripWidthVariant1 != null)
            {
                return strengthGripWidthVariant1(StrengthGripWidthVariant1!);
            }
            else if (IsStrengthGripWidthVariant2 && strengthGripWidthVariant2 != null)
            {
                return strengthGripWidthVariant2(StrengthGripWidthVariant2!);
            }
            else if (IsStrengthGripWidthVariant3 && strengthGripWidthVariant3 != null)
            {
                return strengthGripWidthVariant3(StrengthGripWidthVariant3!);
            }
            else if (IsStrengthGripWidthVariant4 && strengthGripWidthVariant4 != null)
            {
                return strengthGripWidthVariant4(StrengthGripWidthVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StrengthGripWidthVariant1?>? strengthGripWidthVariant1 = null,

            global::System.Action<global::Terra.StrengthGripWidthVariant2?>? strengthGripWidthVariant2 = null,

            global::System.Action<global::Terra.StrengthGripWidthVariant3?>? strengthGripWidthVariant3 = null,

            global::System.Action<string>? strengthGripWidthVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthGripWidthVariant1)
            {
                strengthGripWidthVariant1?.Invoke(StrengthGripWidthVariant1!);
            }
            else if (IsStrengthGripWidthVariant2)
            {
                strengthGripWidthVariant2?.Invoke(StrengthGripWidthVariant2!);
            }
            else if (IsStrengthGripWidthVariant3)
            {
                strengthGripWidthVariant3?.Invoke(StrengthGripWidthVariant3!);
            }
            else if (IsStrengthGripWidthVariant4)
            {
                strengthGripWidthVariant4?.Invoke(StrengthGripWidthVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StrengthGripWidthVariant1?>? strengthGripWidthVariant1 = null,
            global::System.Action<global::Terra.StrengthGripWidthVariant2?>? strengthGripWidthVariant2 = null,
            global::System.Action<global::Terra.StrengthGripWidthVariant3?>? strengthGripWidthVariant3 = null,
            global::System.Action<string>? strengthGripWidthVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStrengthGripWidthVariant1)
            {
                strengthGripWidthVariant1?.Invoke(StrengthGripWidthVariant1!);
            }
            else if (IsStrengthGripWidthVariant2)
            {
                strengthGripWidthVariant2?.Invoke(StrengthGripWidthVariant2!);
            }
            else if (IsStrengthGripWidthVariant3)
            {
                strengthGripWidthVariant3?.Invoke(StrengthGripWidthVariant3!);
            }
            else if (IsStrengthGripWidthVariant4)
            {
                strengthGripWidthVariant4?.Invoke(StrengthGripWidthVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StrengthGripWidthVariant1,
                typeof(global::Terra.StrengthGripWidthVariant1),
                StrengthGripWidthVariant2,
                typeof(global::Terra.StrengthGripWidthVariant2),
                StrengthGripWidthVariant3,
                typeof(global::Terra.StrengthGripWidthVariant3),
                StrengthGripWidthVariant4,
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
        public bool Equals(StrengthGripWidth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripWidthVariant1?>.Default.Equals(StrengthGripWidthVariant1, other.StrengthGripWidthVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripWidthVariant2?>.Default.Equals(StrengthGripWidthVariant2, other.StrengthGripWidthVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StrengthGripWidthVariant3?>.Default.Equals(StrengthGripWidthVariant3, other.StrengthGripWidthVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(StrengthGripWidthVariant4, other.StrengthGripWidthVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StrengthGripWidth obj1, StrengthGripWidth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StrengthGripWidth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StrengthGripWidth obj1, StrengthGripWidth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StrengthGripWidth o && Equals(o);
        }
    }
}

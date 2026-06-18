#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Environment a workout takes place in
    /// </summary>
    public readonly partial struct EnvironmentType : global::System.IEquatable<EnvironmentType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.EnvironmentTypeVariant1? EnvironmentTypeVariant1 { get; init; }
#else
        public global::Terra.EnvironmentTypeVariant1? EnvironmentTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentTypeVariant1))]
#endif
        public bool IsEnvironmentTypeVariant1 => EnvironmentTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.EnvironmentTypeVariant1? value)
        {
            value = EnvironmentTypeVariant1;
            return IsEnvironmentTypeVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.EnvironmentTypeVariant1 PickEnvironmentTypeVariant1() => IsEnvironmentTypeVariant1
            ? EnvironmentTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.EnvironmentTypeVariant2? EnvironmentTypeVariant2 { get; init; }
#else
        public global::Terra.EnvironmentTypeVariant2? EnvironmentTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentTypeVariant2))]
#endif
        public bool IsEnvironmentTypeVariant2 => EnvironmentTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.EnvironmentTypeVariant2? value)
        {
            value = EnvironmentTypeVariant2;
            return IsEnvironmentTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.EnvironmentTypeVariant2 PickEnvironmentTypeVariant2() => IsEnvironmentTypeVariant2
            ? EnvironmentTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.EnvironmentTypeVariant3? EnvironmentTypeVariant3 { get; init; }
#else
        public global::Terra.EnvironmentTypeVariant3? EnvironmentTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentTypeVariant3))]
#endif
        public bool IsEnvironmentTypeVariant3 => EnvironmentTypeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.EnvironmentTypeVariant3? value)
        {
            value = EnvironmentTypeVariant3;
            return IsEnvironmentTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.EnvironmentTypeVariant3 PickEnvironmentTypeVariant3() => IsEnvironmentTypeVariant3
            ? EnvironmentTypeVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentTypeVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvironmentType(global::Terra.EnvironmentTypeVariant1 value) => new EnvironmentType((global::Terra.EnvironmentTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.EnvironmentTypeVariant1?(EnvironmentType @this) => @this.EnvironmentTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentType(global::Terra.EnvironmentTypeVariant1? value)
        {
            EnvironmentTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EnvironmentType FromEnvironmentTypeVariant1(global::Terra.EnvironmentTypeVariant1? value) => new EnvironmentType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvironmentType(global::Terra.EnvironmentTypeVariant2 value) => new EnvironmentType((global::Terra.EnvironmentTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.EnvironmentTypeVariant2?(EnvironmentType @this) => @this.EnvironmentTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentType(global::Terra.EnvironmentTypeVariant2? value)
        {
            EnvironmentTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EnvironmentType FromEnvironmentTypeVariant2(global::Terra.EnvironmentTypeVariant2? value) => new EnvironmentType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EnvironmentType(global::Terra.EnvironmentTypeVariant3 value) => new EnvironmentType((global::Terra.EnvironmentTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.EnvironmentTypeVariant3?(EnvironmentType @this) => @this.EnvironmentTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentType(global::Terra.EnvironmentTypeVariant3? value)
        {
            EnvironmentTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static EnvironmentType FromEnvironmentTypeVariant3(global::Terra.EnvironmentTypeVariant3? value) => new EnvironmentType(value);

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentType(
            global::Terra.EnvironmentTypeVariant1? environmentTypeVariant1,
            global::Terra.EnvironmentTypeVariant2? environmentTypeVariant2,
            global::Terra.EnvironmentTypeVariant3? environmentTypeVariant3
            )
        {
            EnvironmentTypeVariant1 = environmentTypeVariant1;
            EnvironmentTypeVariant2 = environmentTypeVariant2;
            EnvironmentTypeVariant3 = environmentTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EnvironmentTypeVariant3 as object ??
            EnvironmentTypeVariant2 as object ??
            EnvironmentTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            EnvironmentTypeVariant1?.ToValueString() ??
            EnvironmentTypeVariant2?.ToValueString() ??
            EnvironmentTypeVariant3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnvironmentTypeVariant1 || IsEnvironmentTypeVariant2 || IsEnvironmentTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.EnvironmentTypeVariant1?, TResult>? environmentTypeVariant1 = null,
            global::System.Func<global::Terra.EnvironmentTypeVariant2?, TResult>? environmentTypeVariant2 = null,
            global::System.Func<global::Terra.EnvironmentTypeVariant3?, TResult>? environmentTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentTypeVariant1 && environmentTypeVariant1 != null)
            {
                return environmentTypeVariant1(EnvironmentTypeVariant1!);
            }
            else if (IsEnvironmentTypeVariant2 && environmentTypeVariant2 != null)
            {
                return environmentTypeVariant2(EnvironmentTypeVariant2!);
            }
            else if (IsEnvironmentTypeVariant3 && environmentTypeVariant3 != null)
            {
                return environmentTypeVariant3(EnvironmentTypeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.EnvironmentTypeVariant1?>? environmentTypeVariant1 = null,

            global::System.Action<global::Terra.EnvironmentTypeVariant2?>? environmentTypeVariant2 = null,

            global::System.Action<global::Terra.EnvironmentTypeVariant3?>? environmentTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentTypeVariant1)
            {
                environmentTypeVariant1?.Invoke(EnvironmentTypeVariant1!);
            }
            else if (IsEnvironmentTypeVariant2)
            {
                environmentTypeVariant2?.Invoke(EnvironmentTypeVariant2!);
            }
            else if (IsEnvironmentTypeVariant3)
            {
                environmentTypeVariant3?.Invoke(EnvironmentTypeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.EnvironmentTypeVariant1?>? environmentTypeVariant1 = null,
            global::System.Action<global::Terra.EnvironmentTypeVariant2?>? environmentTypeVariant2 = null,
            global::System.Action<global::Terra.EnvironmentTypeVariant3?>? environmentTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnvironmentTypeVariant1)
            {
                environmentTypeVariant1?.Invoke(EnvironmentTypeVariant1!);
            }
            else if (IsEnvironmentTypeVariant2)
            {
                environmentTypeVariant2?.Invoke(EnvironmentTypeVariant2!);
            }
            else if (IsEnvironmentTypeVariant3)
            {
                environmentTypeVariant3?.Invoke(EnvironmentTypeVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EnvironmentTypeVariant1,
                typeof(global::Terra.EnvironmentTypeVariant1),
                EnvironmentTypeVariant2,
                typeof(global::Terra.EnvironmentTypeVariant2),
                EnvironmentTypeVariant3,
                typeof(global::Terra.EnvironmentTypeVariant3),
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
        public bool Equals(EnvironmentType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.EnvironmentTypeVariant1?>.Default.Equals(EnvironmentTypeVariant1, other.EnvironmentTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.EnvironmentTypeVariant2?>.Default.Equals(EnvironmentTypeVariant2, other.EnvironmentTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.EnvironmentTypeVariant3?>.Default.Equals(EnvironmentTypeVariant3, other.EnvironmentTypeVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EnvironmentType obj1, EnvironmentType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EnvironmentType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EnvironmentType obj1, EnvironmentType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EnvironmentType o && Equals(o);
        }
    }
}

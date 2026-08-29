#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Weight display unit for strength exercises
    /// </summary>
    public readonly partial struct WeightUnit : global::System.IEquatable<WeightUnit>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WeightUnitVariant1? WeightUnitVariant1 { get; init; }
#else
        public global::Terra.WeightUnitVariant1? WeightUnitVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WeightUnitVariant1))]
#endif
        public bool IsWeightUnitVariant1 => WeightUnitVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWeightUnitVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WeightUnitVariant1? value)
        {
            value = WeightUnitVariant1;
            return IsWeightUnitVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WeightUnitVariant1 PickWeightUnitVariant1() => IsWeightUnitVariant1
            ? WeightUnitVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WeightUnitVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WeightUnitVariant2? WeightUnitVariant2 { get; init; }
#else
        public global::Terra.WeightUnitVariant2? WeightUnitVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WeightUnitVariant2))]
#endif
        public bool IsWeightUnitVariant2 => WeightUnitVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWeightUnitVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WeightUnitVariant2? value)
        {
            value = WeightUnitVariant2;
            return IsWeightUnitVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WeightUnitVariant2 PickWeightUnitVariant2() => IsWeightUnitVariant2
            ? WeightUnitVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WeightUnitVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator WeightUnit(global::Terra.WeightUnitVariant1 value) => new WeightUnit((global::Terra.WeightUnitVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WeightUnitVariant1?(WeightUnit @this) => @this.WeightUnitVariant1;

        /// <summary>
        ///
        /// </summary>
        public WeightUnit(global::Terra.WeightUnitVariant1? value)
        {
            WeightUnitVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WeightUnit FromWeightUnitVariant1(global::Terra.WeightUnitVariant1? value) => new WeightUnit(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator WeightUnit(global::Terra.WeightUnitVariant2 value) => new WeightUnit((global::Terra.WeightUnitVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WeightUnitVariant2?(WeightUnit @this) => @this.WeightUnitVariant2;

        /// <summary>
        ///
        /// </summary>
        public WeightUnit(global::Terra.WeightUnitVariant2? value)
        {
            WeightUnitVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static WeightUnit FromWeightUnitVariant2(global::Terra.WeightUnitVariant2? value) => new WeightUnit(value);

        /// <summary>
        ///
        /// </summary>
        public WeightUnit(
            global::Terra.WeightUnitVariant1? weightUnitVariant1,
            global::Terra.WeightUnitVariant2? weightUnitVariant2
            )
        {
            WeightUnitVariant1 = weightUnitVariant1;
            WeightUnitVariant2 = weightUnitVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WeightUnitVariant2 as object ??
            WeightUnitVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WeightUnitVariant1?.ToValueString() ??
            WeightUnitVariant2?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWeightUnitVariant1 || IsWeightUnitVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.WeightUnitVariant1?, TResult>? weightUnitVariant1 = null,
            global::System.Func<global::Terra.WeightUnitVariant2?, TResult>? weightUnitVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeightUnitVariant1 && weightUnitVariant1 != null)
            {
                return weightUnitVariant1(WeightUnitVariant1!);
            }
            else if (IsWeightUnitVariant2 && weightUnitVariant2 != null)
            {
                return weightUnitVariant2(WeightUnitVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.WeightUnitVariant1?>? weightUnitVariant1 = null,

            global::System.Action<global::Terra.WeightUnitVariant2?>? weightUnitVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeightUnitVariant1)
            {
                weightUnitVariant1?.Invoke(WeightUnitVariant1!);
            }
            else if (IsWeightUnitVariant2)
            {
                weightUnitVariant2?.Invoke(WeightUnitVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.WeightUnitVariant1?>? weightUnitVariant1 = null,
            global::System.Action<global::Terra.WeightUnitVariant2?>? weightUnitVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWeightUnitVariant1)
            {
                weightUnitVariant1?.Invoke(WeightUnitVariant1!);
            }
            else if (IsWeightUnitVariant2)
            {
                weightUnitVariant2?.Invoke(WeightUnitVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WeightUnitVariant1,
                typeof(global::Terra.WeightUnitVariant1),
                WeightUnitVariant2,
                typeof(global::Terra.WeightUnitVariant2),
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
        public bool Equals(WeightUnit other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.WeightUnitVariant1?>.Default.Equals(WeightUnitVariant1, other.WeightUnitVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.WeightUnitVariant2?>.Default.Equals(WeightUnitVariant2, other.WeightUnitVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(WeightUnit obj1, WeightUnit obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WeightUnit>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(WeightUnit obj1, WeightUnit obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WeightUnit o && Equals(o);
        }
    }
}

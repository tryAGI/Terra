#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Equipment control adjusted during a step (e.g. treadmill incline)
    /// </summary>
    public readonly partial struct StepControlType : global::System.IEquatable<StepControlType>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StepControlTypeVariant1? StepControlTypeVariant1 { get; init; }
#else
        public global::Terra.StepControlTypeVariant1? StepControlTypeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepControlTypeVariant1))]
#endif
        public bool IsStepControlTypeVariant1 => StepControlTypeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepControlTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StepControlTypeVariant1? value)
        {
            value = StepControlTypeVariant1;
            return IsStepControlTypeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepControlTypeVariant1 PickStepControlTypeVariant1() => IsStepControlTypeVariant1
            ? StepControlTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepControlTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.StepControlTypeVariant2? StepControlTypeVariant2 { get; init; }
#else
        public global::Terra.StepControlTypeVariant2? StepControlTypeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StepControlTypeVariant2))]
#endif
        public bool IsStepControlTypeVariant2 => StepControlTypeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStepControlTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.StepControlTypeVariant2? value)
        {
            value = StepControlTypeVariant2;
            return IsStepControlTypeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.StepControlTypeVariant2 PickStepControlTypeVariant2() => IsStepControlTypeVariant2
            ? StepControlTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StepControlTypeVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepControlType(global::Terra.StepControlTypeVariant1 value) => new StepControlType((global::Terra.StepControlTypeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StepControlTypeVariant1?(StepControlType @this) => @this.StepControlTypeVariant1;

        /// <summary>
        ///
        /// </summary>
        public StepControlType(global::Terra.StepControlTypeVariant1? value)
        {
            StepControlTypeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepControlType FromStepControlTypeVariant1(global::Terra.StepControlTypeVariant1? value) => new StepControlType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StepControlType(global::Terra.StepControlTypeVariant2 value) => new StepControlType((global::Terra.StepControlTypeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.StepControlTypeVariant2?(StepControlType @this) => @this.StepControlTypeVariant2;

        /// <summary>
        ///
        /// </summary>
        public StepControlType(global::Terra.StepControlTypeVariant2? value)
        {
            StepControlTypeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StepControlType FromStepControlTypeVariant2(global::Terra.StepControlTypeVariant2? value) => new StepControlType(value);

        /// <summary>
        ///
        /// </summary>
        public StepControlType(
            global::Terra.StepControlTypeVariant1? stepControlTypeVariant1,
            global::Terra.StepControlTypeVariant2? stepControlTypeVariant2
            )
        {
            StepControlTypeVariant1 = stepControlTypeVariant1;
            StepControlTypeVariant2 = stepControlTypeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StepControlTypeVariant2 as object ??
            StepControlTypeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StepControlTypeVariant1?.ToValueString() ??
            StepControlTypeVariant2?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStepControlTypeVariant1 || IsStepControlTypeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.StepControlTypeVariant1?, TResult>? stepControlTypeVariant1 = null,
            global::System.Func<global::Terra.StepControlTypeVariant2?, TResult>? stepControlTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepControlTypeVariant1 && stepControlTypeVariant1 != null)
            {
                return stepControlTypeVariant1(StepControlTypeVariant1!);
            }
            else if (IsStepControlTypeVariant2 && stepControlTypeVariant2 != null)
            {
                return stepControlTypeVariant2(StepControlTypeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.StepControlTypeVariant1?>? stepControlTypeVariant1 = null,

            global::System.Action<global::Terra.StepControlTypeVariant2?>? stepControlTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepControlTypeVariant1)
            {
                stepControlTypeVariant1?.Invoke(StepControlTypeVariant1!);
            }
            else if (IsStepControlTypeVariant2)
            {
                stepControlTypeVariant2?.Invoke(StepControlTypeVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.StepControlTypeVariant1?>? stepControlTypeVariant1 = null,
            global::System.Action<global::Terra.StepControlTypeVariant2?>? stepControlTypeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStepControlTypeVariant1)
            {
                stepControlTypeVariant1?.Invoke(StepControlTypeVariant1!);
            }
            else if (IsStepControlTypeVariant2)
            {
                stepControlTypeVariant2?.Invoke(StepControlTypeVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StepControlTypeVariant1,
                typeof(global::Terra.StepControlTypeVariant1),
                StepControlTypeVariant2,
                typeof(global::Terra.StepControlTypeVariant2),
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
        public bool Equals(StepControlType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.StepControlTypeVariant1?>.Default.Equals(StepControlTypeVariant1, other.StepControlTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.StepControlTypeVariant2?>.Default.Equals(StepControlTypeVariant2, other.StepControlTypeVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StepControlType obj1, StepControlType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StepControlType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StepControlType obj1, StepControlType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StepControlType o && Equals(o);
        }
    }
}

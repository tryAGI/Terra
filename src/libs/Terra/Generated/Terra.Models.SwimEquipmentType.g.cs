#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Swim equipment used during a step
    /// </summary>
    public readonly partial struct SwimEquipmentType : global::System.IEquatable<SwimEquipmentType>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimEquipmentTypeVariant1? SwimEquipmentTypeVariant1 { get; init; }
#else
        public global::Terra.SwimEquipmentTypeVariant1? SwimEquipmentTypeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimEquipmentTypeVariant1))]
#endif
        public bool IsSwimEquipmentTypeVariant1 => SwimEquipmentTypeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwimEquipmentTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimEquipmentTypeVariant1? value)
        {
            value = SwimEquipmentTypeVariant1;
            return IsSwimEquipmentTypeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant1 PickSwimEquipmentTypeVariant1() => SwimEquipmentTypeVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimEquipmentTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimEquipmentTypeVariant2? SwimEquipmentTypeVariant2 { get; init; }
#else
        public global::Terra.SwimEquipmentTypeVariant2? SwimEquipmentTypeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimEquipmentTypeVariant2))]
#endif
        public bool IsSwimEquipmentTypeVariant2 => SwimEquipmentTypeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwimEquipmentTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimEquipmentTypeVariant2? value)
        {
            value = SwimEquipmentTypeVariant2;
            return IsSwimEquipmentTypeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant2 PickSwimEquipmentTypeVariant2() => SwimEquipmentTypeVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimEquipmentTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimEquipmentTypeVariant3? SwimEquipmentTypeVariant3 { get; init; }
#else
        public global::Terra.SwimEquipmentTypeVariant3? SwimEquipmentTypeVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimEquipmentTypeVariant3))]
#endif
        public bool IsSwimEquipmentTypeVariant3 => SwimEquipmentTypeVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwimEquipmentTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimEquipmentTypeVariant3? value)
        {
            value = SwimEquipmentTypeVariant3;
            return IsSwimEquipmentTypeVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant3 PickSwimEquipmentTypeVariant3() => SwimEquipmentTypeVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimEquipmentTypeVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimEquipmentTypeVariant4? SwimEquipmentTypeVariant4 { get; init; }
#else
        public global::Terra.SwimEquipmentTypeVariant4? SwimEquipmentTypeVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimEquipmentTypeVariant4))]
#endif
        public bool IsSwimEquipmentTypeVariant4 => SwimEquipmentTypeVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwimEquipmentTypeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimEquipmentTypeVariant4? value)
        {
            value = SwimEquipmentTypeVariant4;
            return IsSwimEquipmentTypeVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant4 PickSwimEquipmentTypeVariant4() => SwimEquipmentTypeVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimEquipmentTypeVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimEquipmentTypeVariant5? SwimEquipmentTypeVariant5 { get; init; }
#else
        public global::Terra.SwimEquipmentTypeVariant5? SwimEquipmentTypeVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimEquipmentTypeVariant5))]
#endif
        public bool IsSwimEquipmentTypeVariant5 => SwimEquipmentTypeVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwimEquipmentTypeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimEquipmentTypeVariant5? value)
        {
            value = SwimEquipmentTypeVariant5;
            return IsSwimEquipmentTypeVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant5 PickSwimEquipmentTypeVariant5() => SwimEquipmentTypeVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimEquipmentTypeVariant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimEquipmentTypeVariant6? SwimEquipmentTypeVariant6 { get; init; }
#else
        public global::Terra.SwimEquipmentTypeVariant6? SwimEquipmentTypeVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimEquipmentTypeVariant6))]
#endif
        public bool IsSwimEquipmentTypeVariant6 => SwimEquipmentTypeVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSwimEquipmentTypeVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimEquipmentTypeVariant6? value)
        {
            value = SwimEquipmentTypeVariant6;
            return IsSwimEquipmentTypeVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.SwimEquipmentTypeVariant6 PickSwimEquipmentTypeVariant6() => SwimEquipmentTypeVariant6 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimEquipmentTypeVariant6' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant1 value) => new SwimEquipmentType((global::Terra.SwimEquipmentTypeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.SwimEquipmentTypeVariant1?(SwimEquipmentType @this) => @this.SwimEquipmentTypeVariant1;

        /// <summary>
        ///
        /// </summary>
        public SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant1? value)
        {
            SwimEquipmentTypeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SwimEquipmentType FromSwimEquipmentTypeVariant1(global::Terra.SwimEquipmentTypeVariant1? value) => new SwimEquipmentType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant2 value) => new SwimEquipmentType((global::Terra.SwimEquipmentTypeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.SwimEquipmentTypeVariant2?(SwimEquipmentType @this) => @this.SwimEquipmentTypeVariant2;

        /// <summary>
        ///
        /// </summary>
        public SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant2? value)
        {
            SwimEquipmentTypeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SwimEquipmentType FromSwimEquipmentTypeVariant2(global::Terra.SwimEquipmentTypeVariant2? value) => new SwimEquipmentType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant3 value) => new SwimEquipmentType((global::Terra.SwimEquipmentTypeVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.SwimEquipmentTypeVariant3?(SwimEquipmentType @this) => @this.SwimEquipmentTypeVariant3;

        /// <summary>
        ///
        /// </summary>
        public SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant3? value)
        {
            SwimEquipmentTypeVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SwimEquipmentType FromSwimEquipmentTypeVariant3(global::Terra.SwimEquipmentTypeVariant3? value) => new SwimEquipmentType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant4 value) => new SwimEquipmentType((global::Terra.SwimEquipmentTypeVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.SwimEquipmentTypeVariant4?(SwimEquipmentType @this) => @this.SwimEquipmentTypeVariant4;

        /// <summary>
        ///
        /// </summary>
        public SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant4? value)
        {
            SwimEquipmentTypeVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SwimEquipmentType FromSwimEquipmentTypeVariant4(global::Terra.SwimEquipmentTypeVariant4? value) => new SwimEquipmentType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant5 value) => new SwimEquipmentType((global::Terra.SwimEquipmentTypeVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.SwimEquipmentTypeVariant5?(SwimEquipmentType @this) => @this.SwimEquipmentTypeVariant5;

        /// <summary>
        ///
        /// </summary>
        public SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant5? value)
        {
            SwimEquipmentTypeVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SwimEquipmentType FromSwimEquipmentTypeVariant5(global::Terra.SwimEquipmentTypeVariant5? value) => new SwimEquipmentType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant6 value) => new SwimEquipmentType((global::Terra.SwimEquipmentTypeVariant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.SwimEquipmentTypeVariant6?(SwimEquipmentType @this) => @this.SwimEquipmentTypeVariant6;

        /// <summary>
        ///
        /// </summary>
        public SwimEquipmentType(global::Terra.SwimEquipmentTypeVariant6? value)
        {
            SwimEquipmentTypeVariant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SwimEquipmentType FromSwimEquipmentTypeVariant6(global::Terra.SwimEquipmentTypeVariant6? value) => new SwimEquipmentType(value);

        /// <summary>
        ///
        /// </summary>
        public SwimEquipmentType(
            global::Terra.SwimEquipmentTypeVariant1? swimEquipmentTypeVariant1,
            global::Terra.SwimEquipmentTypeVariant2? swimEquipmentTypeVariant2,
            global::Terra.SwimEquipmentTypeVariant3? swimEquipmentTypeVariant3,
            global::Terra.SwimEquipmentTypeVariant4? swimEquipmentTypeVariant4,
            global::Terra.SwimEquipmentTypeVariant5? swimEquipmentTypeVariant5,
            global::Terra.SwimEquipmentTypeVariant6? swimEquipmentTypeVariant6
            )
        {
            SwimEquipmentTypeVariant1 = swimEquipmentTypeVariant1;
            SwimEquipmentTypeVariant2 = swimEquipmentTypeVariant2;
            SwimEquipmentTypeVariant3 = swimEquipmentTypeVariant3;
            SwimEquipmentTypeVariant4 = swimEquipmentTypeVariant4;
            SwimEquipmentTypeVariant5 = swimEquipmentTypeVariant5;
            SwimEquipmentTypeVariant6 = swimEquipmentTypeVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SwimEquipmentTypeVariant6 as object ??
            SwimEquipmentTypeVariant5 as object ??
            SwimEquipmentTypeVariant4 as object ??
            SwimEquipmentTypeVariant3 as object ??
            SwimEquipmentTypeVariant2 as object ??
            SwimEquipmentTypeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SwimEquipmentTypeVariant1?.ToValueString() ??
            SwimEquipmentTypeVariant2?.ToValueString() ??
            SwimEquipmentTypeVariant3?.ToValueString() ??
            SwimEquipmentTypeVariant4?.ToValueString() ??
            SwimEquipmentTypeVariant5?.ToValueString() ??
            SwimEquipmentTypeVariant6?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSwimEquipmentTypeVariant1 || IsSwimEquipmentTypeVariant2 || IsSwimEquipmentTypeVariant3 || IsSwimEquipmentTypeVariant4 || IsSwimEquipmentTypeVariant5 || IsSwimEquipmentTypeVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.SwimEquipmentTypeVariant1?, TResult>? swimEquipmentTypeVariant1 = null,
            global::System.Func<global::Terra.SwimEquipmentTypeVariant2?, TResult>? swimEquipmentTypeVariant2 = null,
            global::System.Func<global::Terra.SwimEquipmentTypeVariant3?, TResult>? swimEquipmentTypeVariant3 = null,
            global::System.Func<global::Terra.SwimEquipmentTypeVariant4?, TResult>? swimEquipmentTypeVariant4 = null,
            global::System.Func<global::Terra.SwimEquipmentTypeVariant5?, TResult>? swimEquipmentTypeVariant5 = null,
            global::System.Func<global::Terra.SwimEquipmentTypeVariant6?, TResult>? swimEquipmentTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SwimEquipmentTypeVariant1 is { } __value0 && swimEquipmentTypeVariant1 != null)
            {
                return swimEquipmentTypeVariant1(__value0);
            }
            else if (SwimEquipmentTypeVariant2 is { } __value1 && swimEquipmentTypeVariant2 != null)
            {
                return swimEquipmentTypeVariant2(__value1);
            }
            else if (SwimEquipmentTypeVariant3 is { } __value2 && swimEquipmentTypeVariant3 != null)
            {
                return swimEquipmentTypeVariant3(__value2);
            }
            else if (SwimEquipmentTypeVariant4 is { } __value3 && swimEquipmentTypeVariant4 != null)
            {
                return swimEquipmentTypeVariant4(__value3);
            }
            else if (SwimEquipmentTypeVariant5 is { } __value4 && swimEquipmentTypeVariant5 != null)
            {
                return swimEquipmentTypeVariant5(__value4);
            }
            else if (SwimEquipmentTypeVariant6 is { } __value5 && swimEquipmentTypeVariant6 != null)
            {
                return swimEquipmentTypeVariant6(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.SwimEquipmentTypeVariant1?>? swimEquipmentTypeVariant1 = null,

            global::System.Action<global::Terra.SwimEquipmentTypeVariant2?>? swimEquipmentTypeVariant2 = null,

            global::System.Action<global::Terra.SwimEquipmentTypeVariant3?>? swimEquipmentTypeVariant3 = null,

            global::System.Action<global::Terra.SwimEquipmentTypeVariant4?>? swimEquipmentTypeVariant4 = null,

            global::System.Action<global::Terra.SwimEquipmentTypeVariant5?>? swimEquipmentTypeVariant5 = null,

            global::System.Action<global::Terra.SwimEquipmentTypeVariant6?>? swimEquipmentTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SwimEquipmentTypeVariant1 is { } __value0)
            {
                swimEquipmentTypeVariant1?.Invoke(__value0);
            }
            else if (SwimEquipmentTypeVariant2 is { } __value1)
            {
                swimEquipmentTypeVariant2?.Invoke(__value1);
            }
            else if (SwimEquipmentTypeVariant3 is { } __value2)
            {
                swimEquipmentTypeVariant3?.Invoke(__value2);
            }
            else if (SwimEquipmentTypeVariant4 is { } __value3)
            {
                swimEquipmentTypeVariant4?.Invoke(__value3);
            }
            else if (SwimEquipmentTypeVariant5 is { } __value4)
            {
                swimEquipmentTypeVariant5?.Invoke(__value4);
            }
            else if (SwimEquipmentTypeVariant6 is { } __value5)
            {
                swimEquipmentTypeVariant6?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.SwimEquipmentTypeVariant1?>? swimEquipmentTypeVariant1 = null,
            global::System.Action<global::Terra.SwimEquipmentTypeVariant2?>? swimEquipmentTypeVariant2 = null,
            global::System.Action<global::Terra.SwimEquipmentTypeVariant3?>? swimEquipmentTypeVariant3 = null,
            global::System.Action<global::Terra.SwimEquipmentTypeVariant4?>? swimEquipmentTypeVariant4 = null,
            global::System.Action<global::Terra.SwimEquipmentTypeVariant5?>? swimEquipmentTypeVariant5 = null,
            global::System.Action<global::Terra.SwimEquipmentTypeVariant6?>? swimEquipmentTypeVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SwimEquipmentTypeVariant1 is { } __value0)
            {
                swimEquipmentTypeVariant1?.Invoke(__value0);
            }
            else if (SwimEquipmentTypeVariant2 is { } __value1)
            {
                swimEquipmentTypeVariant2?.Invoke(__value1);
            }
            else if (SwimEquipmentTypeVariant3 is { } __value2)
            {
                swimEquipmentTypeVariant3?.Invoke(__value2);
            }
            else if (SwimEquipmentTypeVariant4 is { } __value3)
            {
                swimEquipmentTypeVariant4?.Invoke(__value3);
            }
            else if (SwimEquipmentTypeVariant5 is { } __value4)
            {
                swimEquipmentTypeVariant5?.Invoke(__value4);
            }
            else if (SwimEquipmentTypeVariant6 is { } __value5)
            {
                swimEquipmentTypeVariant6?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SwimEquipmentTypeVariant1,
                typeof(global::Terra.SwimEquipmentTypeVariant1),
                SwimEquipmentTypeVariant2,
                typeof(global::Terra.SwimEquipmentTypeVariant2),
                SwimEquipmentTypeVariant3,
                typeof(global::Terra.SwimEquipmentTypeVariant3),
                SwimEquipmentTypeVariant4,
                typeof(global::Terra.SwimEquipmentTypeVariant4),
                SwimEquipmentTypeVariant5,
                typeof(global::Terra.SwimEquipmentTypeVariant5),
                SwimEquipmentTypeVariant6,
                typeof(global::Terra.SwimEquipmentTypeVariant6),
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
        public bool Equals(SwimEquipmentType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimEquipmentTypeVariant1?>.Default.Equals(SwimEquipmentTypeVariant1, other.SwimEquipmentTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimEquipmentTypeVariant2?>.Default.Equals(SwimEquipmentTypeVariant2, other.SwimEquipmentTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimEquipmentTypeVariant3?>.Default.Equals(SwimEquipmentTypeVariant3, other.SwimEquipmentTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimEquipmentTypeVariant4?>.Default.Equals(SwimEquipmentTypeVariant4, other.SwimEquipmentTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimEquipmentTypeVariant5?>.Default.Equals(SwimEquipmentTypeVariant5, other.SwimEquipmentTypeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimEquipmentTypeVariant6?>.Default.Equals(SwimEquipmentTypeVariant6, other.SwimEquipmentTypeVariant6)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SwimEquipmentType obj1, SwimEquipmentType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SwimEquipmentType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SwimEquipmentType obj1, SwimEquipmentType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SwimEquipmentType o && Equals(o);
        }
    }
}

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Swim stroke for a swimming step
    /// </summary>
    public readonly partial struct SwimStrokeType : global::System.IEquatable<SwimStrokeType>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokeTypeVariant1? SwimStrokeTypeVariant1 { get; init; }
#else
        public global::Terra.SwimStrokeTypeVariant1? SwimStrokeTypeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokeTypeVariant1))]
#endif
        public bool IsSwimStrokeTypeVariant1 => SwimStrokeTypeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSwimStrokeTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimStrokeTypeVariant1? value)
        {
            value = SwimStrokeTypeVariant1;
            return IsSwimStrokeTypeVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant1 PickSwimStrokeTypeVariant1() => IsSwimStrokeTypeVariant1
            ? SwimStrokeTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimStrokeTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokeTypeVariant2? SwimStrokeTypeVariant2 { get; init; }
#else
        public global::Terra.SwimStrokeTypeVariant2? SwimStrokeTypeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokeTypeVariant2))]
#endif
        public bool IsSwimStrokeTypeVariant2 => SwimStrokeTypeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSwimStrokeTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimStrokeTypeVariant2? value)
        {
            value = SwimStrokeTypeVariant2;
            return IsSwimStrokeTypeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant2 PickSwimStrokeTypeVariant2() => IsSwimStrokeTypeVariant2
            ? SwimStrokeTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimStrokeTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokeTypeVariant3? SwimStrokeTypeVariant3 { get; init; }
#else
        public global::Terra.SwimStrokeTypeVariant3? SwimStrokeTypeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokeTypeVariant3))]
#endif
        public bool IsSwimStrokeTypeVariant3 => SwimStrokeTypeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSwimStrokeTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimStrokeTypeVariant3? value)
        {
            value = SwimStrokeTypeVariant3;
            return IsSwimStrokeTypeVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant3 PickSwimStrokeTypeVariant3() => IsSwimStrokeTypeVariant3
            ? SwimStrokeTypeVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimStrokeTypeVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokeTypeVariant4? SwimStrokeTypeVariant4 { get; init; }
#else
        public global::Terra.SwimStrokeTypeVariant4? SwimStrokeTypeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokeTypeVariant4))]
#endif
        public bool IsSwimStrokeTypeVariant4 => SwimStrokeTypeVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSwimStrokeTypeVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimStrokeTypeVariant4? value)
        {
            value = SwimStrokeTypeVariant4;
            return IsSwimStrokeTypeVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant4 PickSwimStrokeTypeVariant4() => IsSwimStrokeTypeVariant4
            ? SwimStrokeTypeVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimStrokeTypeVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokeTypeVariant5? SwimStrokeTypeVariant5 { get; init; }
#else
        public global::Terra.SwimStrokeTypeVariant5? SwimStrokeTypeVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokeTypeVariant5))]
#endif
        public bool IsSwimStrokeTypeVariant5 => SwimStrokeTypeVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSwimStrokeTypeVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimStrokeTypeVariant5? value)
        {
            value = SwimStrokeTypeVariant5;
            return IsSwimStrokeTypeVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant5 PickSwimStrokeTypeVariant5() => IsSwimStrokeTypeVariant5
            ? SwimStrokeTypeVariant5!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimStrokeTypeVariant5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokeTypeVariant6? SwimStrokeTypeVariant6 { get; init; }
#else
        public global::Terra.SwimStrokeTypeVariant6? SwimStrokeTypeVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokeTypeVariant6))]
#endif
        public bool IsSwimStrokeTypeVariant6 => SwimStrokeTypeVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSwimStrokeTypeVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimStrokeTypeVariant6? value)
        {
            value = SwimStrokeTypeVariant6;
            return IsSwimStrokeTypeVariant6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant6 PickSwimStrokeTypeVariant6() => IsSwimStrokeTypeVariant6
            ? SwimStrokeTypeVariant6!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimStrokeTypeVariant6' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.SwimStrokeTypeVariant7? SwimStrokeTypeVariant7 { get; init; }
#else
        public global::Terra.SwimStrokeTypeVariant7? SwimStrokeTypeVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SwimStrokeTypeVariant7))]
#endif
        public bool IsSwimStrokeTypeVariant7 => SwimStrokeTypeVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSwimStrokeTypeVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.SwimStrokeTypeVariant7? value)
        {
            value = SwimStrokeTypeVariant7;
            return IsSwimStrokeTypeVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Terra.SwimStrokeTypeVariant7 PickSwimStrokeTypeVariant7() => IsSwimStrokeTypeVariant7
            ? SwimStrokeTypeVariant7!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SwimStrokeTypeVariant7' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SwimStrokeType(global::Terra.SwimStrokeTypeVariant1 value) => new SwimStrokeType((global::Terra.SwimStrokeTypeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokeTypeVariant1?(SwimStrokeType @this) => @this.SwimStrokeTypeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(global::Terra.SwimStrokeTypeVariant1? value)
        {
            SwimStrokeTypeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SwimStrokeType FromSwimStrokeTypeVariant1(global::Terra.SwimStrokeTypeVariant1? value) => new SwimStrokeType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SwimStrokeType(global::Terra.SwimStrokeTypeVariant2 value) => new SwimStrokeType((global::Terra.SwimStrokeTypeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokeTypeVariant2?(SwimStrokeType @this) => @this.SwimStrokeTypeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(global::Terra.SwimStrokeTypeVariant2? value)
        {
            SwimStrokeTypeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SwimStrokeType FromSwimStrokeTypeVariant2(global::Terra.SwimStrokeTypeVariant2? value) => new SwimStrokeType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SwimStrokeType(global::Terra.SwimStrokeTypeVariant3 value) => new SwimStrokeType((global::Terra.SwimStrokeTypeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokeTypeVariant3?(SwimStrokeType @this) => @this.SwimStrokeTypeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(global::Terra.SwimStrokeTypeVariant3? value)
        {
            SwimStrokeTypeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SwimStrokeType FromSwimStrokeTypeVariant3(global::Terra.SwimStrokeTypeVariant3? value) => new SwimStrokeType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SwimStrokeType(global::Terra.SwimStrokeTypeVariant4 value) => new SwimStrokeType((global::Terra.SwimStrokeTypeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokeTypeVariant4?(SwimStrokeType @this) => @this.SwimStrokeTypeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(global::Terra.SwimStrokeTypeVariant4? value)
        {
            SwimStrokeTypeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SwimStrokeType FromSwimStrokeTypeVariant4(global::Terra.SwimStrokeTypeVariant4? value) => new SwimStrokeType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SwimStrokeType(global::Terra.SwimStrokeTypeVariant5 value) => new SwimStrokeType((global::Terra.SwimStrokeTypeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokeTypeVariant5?(SwimStrokeType @this) => @this.SwimStrokeTypeVariant5;

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(global::Terra.SwimStrokeTypeVariant5? value)
        {
            SwimStrokeTypeVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SwimStrokeType FromSwimStrokeTypeVariant5(global::Terra.SwimStrokeTypeVariant5? value) => new SwimStrokeType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SwimStrokeType(global::Terra.SwimStrokeTypeVariant6 value) => new SwimStrokeType((global::Terra.SwimStrokeTypeVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokeTypeVariant6?(SwimStrokeType @this) => @this.SwimStrokeTypeVariant6;

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(global::Terra.SwimStrokeTypeVariant6? value)
        {
            SwimStrokeTypeVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SwimStrokeType FromSwimStrokeTypeVariant6(global::Terra.SwimStrokeTypeVariant6? value) => new SwimStrokeType(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SwimStrokeType(global::Terra.SwimStrokeTypeVariant7 value) => new SwimStrokeType((global::Terra.SwimStrokeTypeVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Terra.SwimStrokeTypeVariant7?(SwimStrokeType @this) => @this.SwimStrokeTypeVariant7;

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(global::Terra.SwimStrokeTypeVariant7? value)
        {
            SwimStrokeTypeVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static SwimStrokeType FromSwimStrokeTypeVariant7(global::Terra.SwimStrokeTypeVariant7? value) => new SwimStrokeType(value);

        /// <summary>
        /// 
        /// </summary>
        public SwimStrokeType(
            global::Terra.SwimStrokeTypeVariant1? swimStrokeTypeVariant1,
            global::Terra.SwimStrokeTypeVariant2? swimStrokeTypeVariant2,
            global::Terra.SwimStrokeTypeVariant3? swimStrokeTypeVariant3,
            global::Terra.SwimStrokeTypeVariant4? swimStrokeTypeVariant4,
            global::Terra.SwimStrokeTypeVariant5? swimStrokeTypeVariant5,
            global::Terra.SwimStrokeTypeVariant6? swimStrokeTypeVariant6,
            global::Terra.SwimStrokeTypeVariant7? swimStrokeTypeVariant7
            )
        {
            SwimStrokeTypeVariant1 = swimStrokeTypeVariant1;
            SwimStrokeTypeVariant2 = swimStrokeTypeVariant2;
            SwimStrokeTypeVariant3 = swimStrokeTypeVariant3;
            SwimStrokeTypeVariant4 = swimStrokeTypeVariant4;
            SwimStrokeTypeVariant5 = swimStrokeTypeVariant5;
            SwimStrokeTypeVariant6 = swimStrokeTypeVariant6;
            SwimStrokeTypeVariant7 = swimStrokeTypeVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SwimStrokeTypeVariant7 as object ??
            SwimStrokeTypeVariant6 as object ??
            SwimStrokeTypeVariant5 as object ??
            SwimStrokeTypeVariant4 as object ??
            SwimStrokeTypeVariant3 as object ??
            SwimStrokeTypeVariant2 as object ??
            SwimStrokeTypeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SwimStrokeTypeVariant1?.ToValueString() ??
            SwimStrokeTypeVariant2?.ToValueString() ??
            SwimStrokeTypeVariant3?.ToValueString() ??
            SwimStrokeTypeVariant4?.ToValueString() ??
            SwimStrokeTypeVariant5?.ToValueString() ??
            SwimStrokeTypeVariant6?.ToValueString() ??
            SwimStrokeTypeVariant7?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSwimStrokeTypeVariant1 || IsSwimStrokeTypeVariant2 || IsSwimStrokeTypeVariant3 || IsSwimStrokeTypeVariant4 || IsSwimStrokeTypeVariant5 || IsSwimStrokeTypeVariant6 || IsSwimStrokeTypeVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.SwimStrokeTypeVariant1?, TResult>? swimStrokeTypeVariant1 = null,
            global::System.Func<global::Terra.SwimStrokeTypeVariant2?, TResult>? swimStrokeTypeVariant2 = null,
            global::System.Func<global::Terra.SwimStrokeTypeVariant3?, TResult>? swimStrokeTypeVariant3 = null,
            global::System.Func<global::Terra.SwimStrokeTypeVariant4?, TResult>? swimStrokeTypeVariant4 = null,
            global::System.Func<global::Terra.SwimStrokeTypeVariant5?, TResult>? swimStrokeTypeVariant5 = null,
            global::System.Func<global::Terra.SwimStrokeTypeVariant6?, TResult>? swimStrokeTypeVariant6 = null,
            global::System.Func<global::Terra.SwimStrokeTypeVariant7?, TResult>? swimStrokeTypeVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSwimStrokeTypeVariant1 && swimStrokeTypeVariant1 != null)
            {
                return swimStrokeTypeVariant1(SwimStrokeTypeVariant1!);
            }
            else if (IsSwimStrokeTypeVariant2 && swimStrokeTypeVariant2 != null)
            {
                return swimStrokeTypeVariant2(SwimStrokeTypeVariant2!);
            }
            else if (IsSwimStrokeTypeVariant3 && swimStrokeTypeVariant3 != null)
            {
                return swimStrokeTypeVariant3(SwimStrokeTypeVariant3!);
            }
            else if (IsSwimStrokeTypeVariant4 && swimStrokeTypeVariant4 != null)
            {
                return swimStrokeTypeVariant4(SwimStrokeTypeVariant4!);
            }
            else if (IsSwimStrokeTypeVariant5 && swimStrokeTypeVariant5 != null)
            {
                return swimStrokeTypeVariant5(SwimStrokeTypeVariant5!);
            }
            else if (IsSwimStrokeTypeVariant6 && swimStrokeTypeVariant6 != null)
            {
                return swimStrokeTypeVariant6(SwimStrokeTypeVariant6!);
            }
            else if (IsSwimStrokeTypeVariant7 && swimStrokeTypeVariant7 != null)
            {
                return swimStrokeTypeVariant7(SwimStrokeTypeVariant7!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.SwimStrokeTypeVariant1?>? swimStrokeTypeVariant1 = null,

            global::System.Action<global::Terra.SwimStrokeTypeVariant2?>? swimStrokeTypeVariant2 = null,

            global::System.Action<global::Terra.SwimStrokeTypeVariant3?>? swimStrokeTypeVariant3 = null,

            global::System.Action<global::Terra.SwimStrokeTypeVariant4?>? swimStrokeTypeVariant4 = null,

            global::System.Action<global::Terra.SwimStrokeTypeVariant5?>? swimStrokeTypeVariant5 = null,

            global::System.Action<global::Terra.SwimStrokeTypeVariant6?>? swimStrokeTypeVariant6 = null,

            global::System.Action<global::Terra.SwimStrokeTypeVariant7?>? swimStrokeTypeVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSwimStrokeTypeVariant1)
            {
                swimStrokeTypeVariant1?.Invoke(SwimStrokeTypeVariant1!);
            }
            else if (IsSwimStrokeTypeVariant2)
            {
                swimStrokeTypeVariant2?.Invoke(SwimStrokeTypeVariant2!);
            }
            else if (IsSwimStrokeTypeVariant3)
            {
                swimStrokeTypeVariant3?.Invoke(SwimStrokeTypeVariant3!);
            }
            else if (IsSwimStrokeTypeVariant4)
            {
                swimStrokeTypeVariant4?.Invoke(SwimStrokeTypeVariant4!);
            }
            else if (IsSwimStrokeTypeVariant5)
            {
                swimStrokeTypeVariant5?.Invoke(SwimStrokeTypeVariant5!);
            }
            else if (IsSwimStrokeTypeVariant6)
            {
                swimStrokeTypeVariant6?.Invoke(SwimStrokeTypeVariant6!);
            }
            else if (IsSwimStrokeTypeVariant7)
            {
                swimStrokeTypeVariant7?.Invoke(SwimStrokeTypeVariant7!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.SwimStrokeTypeVariant1?>? swimStrokeTypeVariant1 = null,
            global::System.Action<global::Terra.SwimStrokeTypeVariant2?>? swimStrokeTypeVariant2 = null,
            global::System.Action<global::Terra.SwimStrokeTypeVariant3?>? swimStrokeTypeVariant3 = null,
            global::System.Action<global::Terra.SwimStrokeTypeVariant4?>? swimStrokeTypeVariant4 = null,
            global::System.Action<global::Terra.SwimStrokeTypeVariant5?>? swimStrokeTypeVariant5 = null,
            global::System.Action<global::Terra.SwimStrokeTypeVariant6?>? swimStrokeTypeVariant6 = null,
            global::System.Action<global::Terra.SwimStrokeTypeVariant7?>? swimStrokeTypeVariant7 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSwimStrokeTypeVariant1)
            {
                swimStrokeTypeVariant1?.Invoke(SwimStrokeTypeVariant1!);
            }
            else if (IsSwimStrokeTypeVariant2)
            {
                swimStrokeTypeVariant2?.Invoke(SwimStrokeTypeVariant2!);
            }
            else if (IsSwimStrokeTypeVariant3)
            {
                swimStrokeTypeVariant3?.Invoke(SwimStrokeTypeVariant3!);
            }
            else if (IsSwimStrokeTypeVariant4)
            {
                swimStrokeTypeVariant4?.Invoke(SwimStrokeTypeVariant4!);
            }
            else if (IsSwimStrokeTypeVariant5)
            {
                swimStrokeTypeVariant5?.Invoke(SwimStrokeTypeVariant5!);
            }
            else if (IsSwimStrokeTypeVariant6)
            {
                swimStrokeTypeVariant6?.Invoke(SwimStrokeTypeVariant6!);
            }
            else if (IsSwimStrokeTypeVariant7)
            {
                swimStrokeTypeVariant7?.Invoke(SwimStrokeTypeVariant7!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SwimStrokeTypeVariant1,
                typeof(global::Terra.SwimStrokeTypeVariant1),
                SwimStrokeTypeVariant2,
                typeof(global::Terra.SwimStrokeTypeVariant2),
                SwimStrokeTypeVariant3,
                typeof(global::Terra.SwimStrokeTypeVariant3),
                SwimStrokeTypeVariant4,
                typeof(global::Terra.SwimStrokeTypeVariant4),
                SwimStrokeTypeVariant5,
                typeof(global::Terra.SwimStrokeTypeVariant5),
                SwimStrokeTypeVariant6,
                typeof(global::Terra.SwimStrokeTypeVariant6),
                SwimStrokeTypeVariant7,
                typeof(global::Terra.SwimStrokeTypeVariant7),
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
        public bool Equals(SwimStrokeType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokeTypeVariant1?>.Default.Equals(SwimStrokeTypeVariant1, other.SwimStrokeTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokeTypeVariant2?>.Default.Equals(SwimStrokeTypeVariant2, other.SwimStrokeTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokeTypeVariant3?>.Default.Equals(SwimStrokeTypeVariant3, other.SwimStrokeTypeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokeTypeVariant4?>.Default.Equals(SwimStrokeTypeVariant4, other.SwimStrokeTypeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokeTypeVariant5?>.Default.Equals(SwimStrokeTypeVariant5, other.SwimStrokeTypeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokeTypeVariant6?>.Default.Equals(SwimStrokeTypeVariant6, other.SwimStrokeTypeVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.SwimStrokeTypeVariant7?>.Default.Equals(SwimStrokeTypeVariant7, other.SwimStrokeTypeVariant7) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SwimStrokeType obj1, SwimStrokeType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SwimStrokeType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SwimStrokeType obj1, SwimStrokeType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SwimStrokeType o && Equals(o);
        }
    }
}

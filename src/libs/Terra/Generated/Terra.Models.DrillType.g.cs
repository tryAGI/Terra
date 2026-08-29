#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Swim drill type
    /// </summary>
    public readonly partial struct DrillType : global::System.IEquatable<DrillType>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.DrillTypeVariant1? DrillTypeVariant1 { get; init; }
#else
        public global::Terra.DrillTypeVariant1? DrillTypeVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DrillTypeVariant1))]
#endif
        public bool IsDrillTypeVariant1 => DrillTypeVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDrillTypeVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.DrillTypeVariant1? value)
        {
            value = DrillTypeVariant1;
            return IsDrillTypeVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrillTypeVariant1 PickDrillTypeVariant1() => IsDrillTypeVariant1
            ? DrillTypeVariant1!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DrillTypeVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.DrillTypeVariant2? DrillTypeVariant2 { get; init; }
#else
        public global::Terra.DrillTypeVariant2? DrillTypeVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DrillTypeVariant2))]
#endif
        public bool IsDrillTypeVariant2 => DrillTypeVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDrillTypeVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.DrillTypeVariant2? value)
        {
            value = DrillTypeVariant2;
            return IsDrillTypeVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrillTypeVariant2 PickDrillTypeVariant2() => IsDrillTypeVariant2
            ? DrillTypeVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DrillTypeVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.DrillTypeVariant3? DrillTypeVariant3 { get; init; }
#else
        public global::Terra.DrillTypeVariant3? DrillTypeVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DrillTypeVariant3))]
#endif
        public bool IsDrillTypeVariant3 => DrillTypeVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDrillTypeVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.DrillTypeVariant3? value)
        {
            value = DrillTypeVariant3;
            return IsDrillTypeVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.DrillTypeVariant3 PickDrillTypeVariant3() => IsDrillTypeVariant3
            ? DrillTypeVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DrillTypeVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator DrillType(global::Terra.DrillTypeVariant1 value) => new DrillType((global::Terra.DrillTypeVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.DrillTypeVariant1?(DrillType @this) => @this.DrillTypeVariant1;

        /// <summary>
        ///
        /// </summary>
        public DrillType(global::Terra.DrillTypeVariant1? value)
        {
            DrillTypeVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DrillType FromDrillTypeVariant1(global::Terra.DrillTypeVariant1? value) => new DrillType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DrillType(global::Terra.DrillTypeVariant2 value) => new DrillType((global::Terra.DrillTypeVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.DrillTypeVariant2?(DrillType @this) => @this.DrillTypeVariant2;

        /// <summary>
        ///
        /// </summary>
        public DrillType(global::Terra.DrillTypeVariant2? value)
        {
            DrillTypeVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DrillType FromDrillTypeVariant2(global::Terra.DrillTypeVariant2? value) => new DrillType(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator DrillType(global::Terra.DrillTypeVariant3 value) => new DrillType((global::Terra.DrillTypeVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.DrillTypeVariant3?(DrillType @this) => @this.DrillTypeVariant3;

        /// <summary>
        ///
        /// </summary>
        public DrillType(global::Terra.DrillTypeVariant3? value)
        {
            DrillTypeVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static DrillType FromDrillTypeVariant3(global::Terra.DrillTypeVariant3? value) => new DrillType(value);

        /// <summary>
        ///
        /// </summary>
        public DrillType(
            global::Terra.DrillTypeVariant1? drillTypeVariant1,
            global::Terra.DrillTypeVariant2? drillTypeVariant2,
            global::Terra.DrillTypeVariant3? drillTypeVariant3
            )
        {
            DrillTypeVariant1 = drillTypeVariant1;
            DrillTypeVariant2 = drillTypeVariant2;
            DrillTypeVariant3 = drillTypeVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DrillTypeVariant3 as object ??
            DrillTypeVariant2 as object ??
            DrillTypeVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            DrillTypeVariant1?.ToValueString() ??
            DrillTypeVariant2?.ToValueString() ??
            DrillTypeVariant3?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsDrillTypeVariant1 || IsDrillTypeVariant2 || IsDrillTypeVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.DrillTypeVariant1?, TResult>? drillTypeVariant1 = null,
            global::System.Func<global::Terra.DrillTypeVariant2?, TResult>? drillTypeVariant2 = null,
            global::System.Func<global::Terra.DrillTypeVariant3?, TResult>? drillTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDrillTypeVariant1 && drillTypeVariant1 != null)
            {
                return drillTypeVariant1(DrillTypeVariant1!);
            }
            else if (IsDrillTypeVariant2 && drillTypeVariant2 != null)
            {
                return drillTypeVariant2(DrillTypeVariant2!);
            }
            else if (IsDrillTypeVariant3 && drillTypeVariant3 != null)
            {
                return drillTypeVariant3(DrillTypeVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.DrillTypeVariant1?>? drillTypeVariant1 = null,

            global::System.Action<global::Terra.DrillTypeVariant2?>? drillTypeVariant2 = null,

            global::System.Action<global::Terra.DrillTypeVariant3?>? drillTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDrillTypeVariant1)
            {
                drillTypeVariant1?.Invoke(DrillTypeVariant1!);
            }
            else if (IsDrillTypeVariant2)
            {
                drillTypeVariant2?.Invoke(DrillTypeVariant2!);
            }
            else if (IsDrillTypeVariant3)
            {
                drillTypeVariant3?.Invoke(DrillTypeVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.DrillTypeVariant1?>? drillTypeVariant1 = null,
            global::System.Action<global::Terra.DrillTypeVariant2?>? drillTypeVariant2 = null,
            global::System.Action<global::Terra.DrillTypeVariant3?>? drillTypeVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDrillTypeVariant1)
            {
                drillTypeVariant1?.Invoke(DrillTypeVariant1!);
            }
            else if (IsDrillTypeVariant2)
            {
                drillTypeVariant2?.Invoke(DrillTypeVariant2!);
            }
            else if (IsDrillTypeVariant3)
            {
                drillTypeVariant3?.Invoke(DrillTypeVariant3!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                DrillTypeVariant1,
                typeof(global::Terra.DrillTypeVariant1),
                DrillTypeVariant2,
                typeof(global::Terra.DrillTypeVariant2),
                DrillTypeVariant3,
                typeof(global::Terra.DrillTypeVariant3),
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
        public bool Equals(DrillType other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.DrillTypeVariant1?>.Default.Equals(DrillTypeVariant1, other.DrillTypeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.DrillTypeVariant2?>.Default.Equals(DrillTypeVariant2, other.DrillTypeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.DrillTypeVariant3?>.Default.Equals(DrillTypeVariant3, other.DrillTypeVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(DrillType obj1, DrillType obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DrillType>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(DrillType obj1, DrillType obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DrillType o && Equals(o);
        }
    }
}

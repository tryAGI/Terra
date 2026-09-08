#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// The webhook source layer. Identical to the retrieve source layer — per-result collection date/time and region_name moved onto the shared base type, so the two cannot drift. Retained as a named type because it is published in the SDK.
    /// </summary>
    public readonly partial struct LabReportEventResultSource : global::System.IEquatable<LabReportEventResultSource>
    {
        /// <summary>
        /// The verbatim provenance layer — what the report literally printed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.LabReportResultSource? LabReportResultSource { get; init; }
#else
        public global::Terra.LabReportResultSource? LabReportResultSource { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LabReportResultSource))]
#endif
        public bool IsLabReportResultSource => LabReportResultSource != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLabReportResultSource(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.LabReportResultSource? value)
        {
            value = LabReportResultSource;
            return IsLabReportResultSource;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportResultSource PickLabReportResultSource() => IsLabReportResultSource
            ? LabReportResultSource!
            : throw new global::System.InvalidOperationException($"Expected union variant 'LabReportResultSource' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LabReportEventResultSource(global::Terra.LabReportResultSource value) => new LabReportEventResultSource((global::Terra.LabReportResultSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.LabReportResultSource?(LabReportEventResultSource @this) => @this.LabReportResultSource;

        /// <summary>
        ///
        /// </summary>
        public LabReportEventResultSource(global::Terra.LabReportResultSource? value)
        {
            LabReportResultSource = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LabReportEventResultSource FromLabReportResultSource(global::Terra.LabReportResultSource? value) => new LabReportEventResultSource(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            LabReportResultSource as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            LabReportResultSource?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLabReportResultSource;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.LabReportResultSource, TResult>? labReportResultSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabReportResultSource && labReportResultSource != null)
            {
                return labReportResultSource(LabReportResultSource!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.LabReportResultSource>? labReportResultSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabReportResultSource)
            {
                labReportResultSource?.Invoke(LabReportResultSource!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.LabReportResultSource>? labReportResultSource = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLabReportResultSource)
            {
                labReportResultSource?.Invoke(LabReportResultSource!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                LabReportResultSource,
                typeof(global::Terra.LabReportResultSource),
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
        public bool Equals(LabReportEventResultSource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.LabReportResultSource?>.Default.Equals(LabReportResultSource, other.LabReportResultSource)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LabReportEventResultSource obj1, LabReportEventResultSource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LabReportEventResultSource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LabReportEventResultSource obj1, LabReportEventResultSource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LabReportEventResultSource o && Equals(o);
        }
    }
}

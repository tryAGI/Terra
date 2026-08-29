#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct LabReportWebhook : global::System.IEquatable<LabReportWebhook>
    {
        /// <summary>
        /// Lab report completed event: a report finished processing; its normalized results are delivered under `data`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.LabReportCompletedEvent? CompletedEvent { get; init; }
#else
        public global::Terra.LabReportCompletedEvent? CompletedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CompletedEvent))]
#endif
        public bool IsCompletedEvent => CompletedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCompletedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.LabReportCompletedEvent? value)
        {
            value = CompletedEvent;
            return IsCompletedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportCompletedEvent PickCompletedEvent() => IsCompletedEvent
            ? CompletedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CompletedEvent' but the value was {ToString()}.");

        /// <summary>
        /// Lab report failed event: a report terminally failed processing; `data` carries the structured reason.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.LabReportFailedEvent? FailedEvent { get; init; }
#else
        public global::Terra.LabReportFailedEvent? FailedEvent { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FailedEvent))]
#endif
        public bool IsFailedEvent => FailedEvent != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFailedEvent(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.LabReportFailedEvent? value)
        {
            value = FailedEvent;
            return IsFailedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.LabReportFailedEvent PickFailedEvent() => IsFailedEvent
            ? FailedEvent!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FailedEvent' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator LabReportWebhook(global::Terra.LabReportCompletedEvent value) => new LabReportWebhook((global::Terra.LabReportCompletedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.LabReportCompletedEvent?(LabReportWebhook @this) => @this.CompletedEvent;

        /// <summary>
        ///
        /// </summary>
        public LabReportWebhook(global::Terra.LabReportCompletedEvent? value)
        {
            CompletedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LabReportWebhook FromCompletedEvent(global::Terra.LabReportCompletedEvent? value) => new LabReportWebhook(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator LabReportWebhook(global::Terra.LabReportFailedEvent value) => new LabReportWebhook((global::Terra.LabReportFailedEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.LabReportFailedEvent?(LabReportWebhook @this) => @this.FailedEvent;

        /// <summary>
        ///
        /// </summary>
        public LabReportWebhook(global::Terra.LabReportFailedEvent? value)
        {
            FailedEvent = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static LabReportWebhook FromFailedEvent(global::Terra.LabReportFailedEvent? value) => new LabReportWebhook(value);

        /// <summary>
        ///
        /// </summary>
        public LabReportWebhook(
            global::Terra.LabReportCompletedEvent? completedEvent,
            global::Terra.LabReportFailedEvent? failedEvent
            )
        {
            CompletedEvent = completedEvent;
            FailedEvent = failedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FailedEvent as object ??
            CompletedEvent as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CompletedEvent?.ToString() ??
            FailedEvent?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCompletedEvent && !IsFailedEvent || !IsCompletedEvent && IsFailedEvent;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.LabReportCompletedEvent, TResult>? completedEvent = null,
            global::System.Func<global::Terra.LabReportFailedEvent, TResult>? failedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletedEvent && completedEvent != null)
            {
                return completedEvent(CompletedEvent!);
            }
            else if (IsFailedEvent && failedEvent != null)
            {
                return failedEvent(FailedEvent!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.LabReportCompletedEvent>? completedEvent = null,

            global::System.Action<global::Terra.LabReportFailedEvent>? failedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletedEvent)
            {
                completedEvent?.Invoke(CompletedEvent!);
            }
            else if (IsFailedEvent)
            {
                failedEvent?.Invoke(FailedEvent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.LabReportCompletedEvent>? completedEvent = null,
            global::System.Action<global::Terra.LabReportFailedEvent>? failedEvent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompletedEvent)
            {
                completedEvent?.Invoke(CompletedEvent!);
            }
            else if (IsFailedEvent)
            {
                failedEvent?.Invoke(FailedEvent!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CompletedEvent,
                typeof(global::Terra.LabReportCompletedEvent),
                FailedEvent,
                typeof(global::Terra.LabReportFailedEvent),
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
        public bool Equals(LabReportWebhook other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.LabReportCompletedEvent?>.Default.Equals(CompletedEvent, other.CompletedEvent) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.LabReportFailedEvent?>.Default.Equals(FailedEvent, other.FailedEvent)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(LabReportWebhook obj1, LabReportWebhook obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LabReportWebhook>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(LabReportWebhook obj1, LabReportWebhook obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LabReportWebhook o && Equals(o);
        }
    }
}

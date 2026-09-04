#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Terra
{
    /// <summary>
    /// Sport of a provider-created workout: a WorkoutSport, or `unspecified` when the provider's sport has no Terra equivalent (rejected on create).
    /// </summary>
    public readonly partial struct PlannedWorkoutSport : global::System.IEquatable<PlannedWorkoutSport>
    {
        /// <summary>
        /// Sport a workout template targets. Indoor/outdoor is expressed separately via environment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.WorkoutSport? WorkoutSport { get; init; }
#else
        public global::Terra.WorkoutSport? WorkoutSport { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WorkoutSport))]
#endif
        public bool IsWorkoutSport => WorkoutSport != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWorkoutSport(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.WorkoutSport? value)
        {
            value = WorkoutSport;
            return IsWorkoutSport;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.WorkoutSport PickWorkoutSport() => IsWorkoutSport
            ? WorkoutSport!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WorkoutSport' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Terra.PlannedWorkoutSportEnum? Enum { get; init; }
#else
        public global::Terra.PlannedWorkoutSportEnum? Enum { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Terra.PlannedWorkoutSportEnum? value)
        {
            value = Enum;
            return IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Terra.PlannedWorkoutSportEnum PickEnum() => IsEnum
            ? Enum!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Enum' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PlannedWorkoutSport(global::Terra.WorkoutSport value) => new PlannedWorkoutSport((global::Terra.WorkoutSport?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.WorkoutSport?(PlannedWorkoutSport @this) => @this.WorkoutSport;

        /// <summary>
        ///
        /// </summary>
        public PlannedWorkoutSport(global::Terra.WorkoutSport? value)
        {
            WorkoutSport = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PlannedWorkoutSport FromWorkoutSport(global::Terra.WorkoutSport? value) => new PlannedWorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PlannedWorkoutSport(global::Terra.PlannedWorkoutSportEnum value) => new PlannedWorkoutSport((global::Terra.PlannedWorkoutSportEnum?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Terra.PlannedWorkoutSportEnum?(PlannedWorkoutSport @this) => @this.Enum;

        /// <summary>
        ///
        /// </summary>
        public PlannedWorkoutSport(global::Terra.PlannedWorkoutSportEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PlannedWorkoutSport FromEnum(global::Terra.PlannedWorkoutSportEnum? value) => new PlannedWorkoutSport(value);

        /// <summary>
        ///
        /// </summary>
        public PlannedWorkoutSport(
            global::Terra.WorkoutSport? workoutSport,
            global::Terra.PlannedWorkoutSportEnum? @enum
            )
        {
            WorkoutSport = workoutSport;
            Enum = @enum;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Enum as object ??
            WorkoutSport as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WorkoutSport?.ToString() ??
            Enum?.ToValueString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWorkoutSport || IsEnum;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Terra.WorkoutSport?, TResult>? workoutSport = null,
            global::System.Func<global::Terra.PlannedWorkoutSportEnum?, TResult>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutSport && workoutSport != null)
            {
                return workoutSport(WorkoutSport!);
            }
            else if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Terra.WorkoutSport?>? workoutSport = null,

            global::System.Action<global::Terra.PlannedWorkoutSportEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutSport)
            {
                workoutSport?.Invoke(WorkoutSport!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Terra.WorkoutSport?>? workoutSport = null,
            global::System.Action<global::Terra.PlannedWorkoutSportEnum?>? @enum = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWorkoutSport)
            {
                workoutSport?.Invoke(WorkoutSport!);
            }
            else if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                WorkoutSport,
                typeof(global::Terra.WorkoutSport),
                Enum,
                typeof(global::Terra.PlannedWorkoutSportEnum),
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
        public bool Equals(PlannedWorkoutSport other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Terra.WorkoutSport?>.Default.Equals(WorkoutSport, other.WorkoutSport) &&
                global::System.Collections.Generic.EqualityComparer<global::Terra.PlannedWorkoutSportEnum?>.Default.Equals(Enum, other.Enum)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PlannedWorkoutSport obj1, PlannedWorkoutSport obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlannedWorkoutSport>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PlannedWorkoutSport obj1, PlannedWorkoutSport obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlannedWorkoutSport o && Equals(o);
        }
    }
}

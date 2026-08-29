
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant145
    {
        /// <summary>
        ///
        /// </summary>
        StiffLeggedDeadlift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant145Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant145 value)
        {
            return value switch
            {
                StrengthMovementVariant145.StiffLeggedDeadlift => "stiff_legged_deadlift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant145? ToEnum(string value)
        {
            return value switch
            {
                "stiff_legged_deadlift" => StrengthMovementVariant145.StiffLeggedDeadlift,
                _ => null,
            };
        }
    }
}
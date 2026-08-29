
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant33
    {
        /// <summary>
        ///
        /// </summary>
        Deadlift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant33Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant33 value)
        {
            return value switch
            {
                StrengthMovementVariant33.Deadlift => "deadlift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant33? ToEnum(string value)
        {
            return value switch
            {
                "deadlift" => StrengthMovementVariant33.Deadlift,
                _ => null,
            };
        }
    }
}
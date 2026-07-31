
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant115
    {
        /// <summary>
        /// 
        /// </summary>
        RomanianDeadlift,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant115Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant115 value)
        {
            return value switch
            {
                StrengthMovementVariant115.RomanianDeadlift => "romanian_deadlift",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant115? ToEnum(string value)
        {
            return value switch
            {
                "romanian_deadlift" => StrengthMovementVariant115.RomanianDeadlift,
                _ => null,
            };
        }
    }
}
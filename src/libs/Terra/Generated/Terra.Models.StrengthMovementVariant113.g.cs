
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant113
    {
        /// <summary>
        ///
        /// </summary>
        ReverseCrunch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant113Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant113 value)
        {
            return value switch
            {
                StrengthMovementVariant113.ReverseCrunch => "reverse_crunch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant113? ToEnum(string value)
        {
            return value switch
            {
                "reverse_crunch" => StrengthMovementVariant113.ReverseCrunch,
                _ => null,
            };
        }
    }
}
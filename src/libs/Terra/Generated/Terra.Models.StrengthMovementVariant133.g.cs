
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant133
    {
        /// <summary>
        ///
        /// </summary>
        Slam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant133Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant133 value)
        {
            return value switch
            {
                StrengthMovementVariant133.Slam => "slam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant133? ToEnum(string value)
        {
            return value switch
            {
                "slam" => StrengthMovementVariant133.Slam,
                _ => null,
            };
        }
    }
}
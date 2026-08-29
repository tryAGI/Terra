
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant16
    {
        /// <summary>
        ///
        /// </summary>
        Burpee,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant16Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant16 value)
        {
            return value switch
            {
                StrengthMovementVariant16.Burpee => "burpee",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant16? ToEnum(string value)
        {
            return value switch
            {
                "burpee" => StrengthMovementVariant16.Burpee,
                _ => null,
            };
        }
    }
}
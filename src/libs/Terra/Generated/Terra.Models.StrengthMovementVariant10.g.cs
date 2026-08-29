
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant10
    {
        /// <summary>
        ///
        /// </summary>
        Bike,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant10Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant10 value)
        {
            return value switch
            {
                StrengthMovementVariant10.Bike => "bike",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant10? ToEnum(string value)
        {
            return value switch
            {
                "bike" => StrengthMovementVariant10.Bike,
                _ => null,
            };
        }
    }
}
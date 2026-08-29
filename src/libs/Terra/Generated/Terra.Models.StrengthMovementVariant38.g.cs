
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant38
    {
        /// <summary>
        ///
        /// </summary>
        Elliptical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant38Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant38 value)
        {
            return value switch
            {
                StrengthMovementVariant38.Elliptical => "elliptical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant38? ToEnum(string value)
        {
            return value switch
            {
                "elliptical" => StrengthMovementVariant38.Elliptical,
                _ => null,
            };
        }
    }
}
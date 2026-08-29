
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant67
    {
        /// <summary>
        ///
        /// </summary>
        Hold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant67Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant67 value)
        {
            return value switch
            {
                StrengthMovementVariant67.Hold => "hold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant67? ToEnum(string value)
        {
            return value switch
            {
                "hold" => StrengthMovementVariant67.Hold,
                _ => null,
            };
        }
    }
}
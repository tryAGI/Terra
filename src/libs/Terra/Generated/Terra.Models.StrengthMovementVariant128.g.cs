
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant128
    {
        /// <summary>
        ///
        /// </summary>
        Shuffle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant128Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant128 value)
        {
            return value switch
            {
                StrengthMovementVariant128.Shuffle => "shuffle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant128? ToEnum(string value)
        {
            return value switch
            {
                "shuffle" => StrengthMovementVariant128.Shuffle,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant28
    {
        /// <summary>
        ///
        /// </summary>
        Climb,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant28Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant28 value)
        {
            return value switch
            {
                StrengthMovementVariant28.Climb => "climb",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant28? ToEnum(string value)
        {
            return value switch
            {
                "climb" => StrengthMovementVariant28.Climb,
                _ => null,
            };
        }
    }
}
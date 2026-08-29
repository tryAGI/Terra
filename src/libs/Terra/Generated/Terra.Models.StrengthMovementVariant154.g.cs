
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant154
    {
        /// <summary>
        ///
        /// </summary>
        Throw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant154Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant154 value)
        {
            return value switch
            {
                StrengthMovementVariant154.Throw => "throw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant154? ToEnum(string value)
        {
            return value switch
            {
                "throw" => StrengthMovementVariant154.Throw,
                _ => null,
            };
        }
    }
}
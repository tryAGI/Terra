
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant21
    {
        /// <summary>
        ///
        /// </summary>
        Carry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant21Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant21 value)
        {
            return value switch
            {
                StrengthMovementVariant21.Carry => "carry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant21? ToEnum(string value)
        {
            return value switch
            {
                "carry" => StrengthMovementVariant21.Carry,
                _ => null,
            };
        }
    }
}
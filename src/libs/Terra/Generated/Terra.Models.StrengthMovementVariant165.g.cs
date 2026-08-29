
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant165
    {
        /// <summary>
        ///
        /// </summary>
        VSit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant165Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant165 value)
        {
            return value switch
            {
                StrengthMovementVariant165.VSit => "v_sit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant165? ToEnum(string value)
        {
            return value switch
            {
                "v_sit" => StrengthMovementVariant165.VSit,
                _ => null,
            };
        }
    }
}
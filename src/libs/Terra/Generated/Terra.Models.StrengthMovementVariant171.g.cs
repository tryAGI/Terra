
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant171
    {
        /// <summary>
        ///
        /// </summary>
        WindshieldWiper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant171Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant171 value)
        {
            return value switch
            {
                StrengthMovementVariant171.WindshieldWiper => "windshield_wiper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant171? ToEnum(string value)
        {
            return value switch
            {
                "windshield_wiper" => StrengthMovementVariant171.WindshieldWiper,
                _ => null,
            };
        }
    }
}
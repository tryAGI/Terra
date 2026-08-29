
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant75
    {
        /// <summary>
        ///
        /// </summary>
        JumpingJack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant75Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant75 value)
        {
            return value switch
            {
                StrengthMovementVariant75.JumpingJack => "jumping_jack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant75? ToEnum(string value)
        {
            return value switch
            {
                "jumping_jack" => StrengthMovementVariant75.JumpingJack,
                _ => null,
            };
        }
    }
}
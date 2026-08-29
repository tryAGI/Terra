
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSetTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Cooldown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSetTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSetTypeVariant2 value)
        {
            return value switch
            {
                StrengthSetTypeVariant2.Cooldown => "cooldown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSetTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "cooldown" => StrengthSetTypeVariant2.Cooldown,
                _ => null,
            };
        }
    }
}
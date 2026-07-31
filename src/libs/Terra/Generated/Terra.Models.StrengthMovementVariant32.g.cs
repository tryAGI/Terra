
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant32
    {
        /// <summary>
        /// 
        /// </summary>
        DeadBug,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant32Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant32 value)
        {
            return value switch
            {
                StrengthMovementVariant32.DeadBug => "dead_bug",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant32? ToEnum(string value)
        {
            return value switch
            {
                "dead_bug" => StrengthMovementVariant32.DeadBug,
                _ => null,
            };
        }
    }
}
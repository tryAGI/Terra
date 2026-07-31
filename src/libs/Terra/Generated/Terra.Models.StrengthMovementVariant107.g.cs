
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant107
    {
        /// <summary>
        /// 
        /// </summary>
        PullUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant107Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant107 value)
        {
            return value switch
            {
                StrengthMovementVariant107.PullUp => "pull_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant107? ToEnum(string value)
        {
            return value switch
            {
                "pull_up" => StrengthMovementVariant107.PullUp,
                _ => null,
            };
        }
    }
}
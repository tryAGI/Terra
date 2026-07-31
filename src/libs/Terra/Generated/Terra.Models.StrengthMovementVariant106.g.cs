
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant106
    {
        /// <summary>
        /// 
        /// </summary>
        PullThrough,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant106Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant106 value)
        {
            return value switch
            {
                StrengthMovementVariant106.PullThrough => "pull_through",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant106? ToEnum(string value)
        {
            return value switch
            {
                "pull_through" => StrengthMovementVariant106.PullThrough,
                _ => null,
            };
        }
    }
}
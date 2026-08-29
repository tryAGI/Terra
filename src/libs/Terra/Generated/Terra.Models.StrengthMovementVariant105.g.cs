
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant105
    {
        /// <summary>
        ///
        /// </summary>
        PullApart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant105Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant105 value)
        {
            return value switch
            {
                StrengthMovementVariant105.PullApart => "pull_apart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant105? ToEnum(string value)
        {
            return value switch
            {
                "pull_apart" => StrengthMovementVariant105.PullApart,
                _ => null,
            };
        }
    }
}
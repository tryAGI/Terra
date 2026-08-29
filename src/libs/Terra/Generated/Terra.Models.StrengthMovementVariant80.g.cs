
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant80
    {
        /// <summary>
        ///
        /// </summary>
        LatPulldown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant80Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant80 value)
        {
            return value switch
            {
                StrengthMovementVariant80.LatPulldown => "lat_pulldown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant80? ToEnum(string value)
        {
            return value switch
            {
                "lat_pulldown" => StrengthMovementVariant80.LatPulldown,
                _ => null,
            };
        }
    }
}
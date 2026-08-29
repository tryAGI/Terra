
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant162
    {
        /// <summary>
        ///
        /// </summary>
        TrunkRotation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant162Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant162 value)
        {
            return value switch
            {
                StrengthMovementVariant162.TrunkRotation => "trunk_rotation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant162? ToEnum(string value)
        {
            return value switch
            {
                "trunk_rotation" => StrengthMovementVariant162.TrunkRotation,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant159
    {
        /// <summary>
        /// 
        /// </summary>
        ToeWalk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant159Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant159 value)
        {
            return value switch
            {
                StrengthMovementVariant159.ToeWalk => "toe_walk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant159? ToEnum(string value)
        {
            return value switch
            {
                "toe_walk" => StrengthMovementVariant159.ToeWalk,
                _ => null,
            };
        }
    }
}
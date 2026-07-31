
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant58
    {
        /// <summary>
        /// 
        /// </summary>
        Hike,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant58Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant58 value)
        {
            return value switch
            {
                StrengthMovementVariant58.Hike => "hike",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant58? ToEnum(string value)
        {
            return value switch
            {
                "hike" => StrengthMovementVariant58.Hike,
                _ => null,
            };
        }
    }
}
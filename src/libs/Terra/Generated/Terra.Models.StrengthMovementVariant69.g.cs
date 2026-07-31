
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant69
    {
        /// <summary>
        /// 
        /// </summary>
        Hop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant69Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant69 value)
        {
            return value switch
            {
                StrengthMovementVariant69.Hop => "hop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant69? ToEnum(string value)
        {
            return value switch
            {
                "hop" => StrengthMovementVariant69.Hop,
                _ => null,
            };
        }
    }
}
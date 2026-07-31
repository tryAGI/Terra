
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant31
    {
        /// <summary>
        /// 
        /// </summary>
        Crunch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant31Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant31 value)
        {
            return value switch
            {
                StrengthMovementVariant31.Crunch => "crunch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant31? ToEnum(string value)
        {
            return value switch
            {
                "crunch" => StrengthMovementVariant31.Crunch,
                _ => null,
            };
        }
    }
}
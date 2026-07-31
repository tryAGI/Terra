
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant18
    {
        /// <summary>
        /// 
        /// </summary>
        ButtScoot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant18Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant18 value)
        {
            return value switch
            {
                StrengthMovementVariant18.ButtScoot => "butt_scoot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant18? ToEnum(string value)
        {
            return value switch
            {
                "butt_scoot" => StrengthMovementVariant18.ButtScoot,
                _ => null,
            };
        }
    }
}
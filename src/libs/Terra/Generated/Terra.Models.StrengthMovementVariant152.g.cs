
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant152
    {
        /// <summary>
        /// 
        /// </summary>
        Swing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant152Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant152 value)
        {
            return value switch
            {
                StrengthMovementVariant152.Swing => "swing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant152? ToEnum(string value)
        {
            return value switch
            {
                "swing" => StrengthMovementVariant152.Swing,
                _ => null,
            };
        }
    }
}
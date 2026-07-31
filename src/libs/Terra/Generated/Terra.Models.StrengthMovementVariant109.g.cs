
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant109
    {
        /// <summary>
        /// 
        /// </summary>
        Punch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant109Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant109 value)
        {
            return value switch
            {
                StrengthMovementVariant109.Punch => "punch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant109? ToEnum(string value)
        {
            return value switch
            {
                "punch" => StrengthMovementVariant109.Punch,
                _ => null,
            };
        }
    }
}
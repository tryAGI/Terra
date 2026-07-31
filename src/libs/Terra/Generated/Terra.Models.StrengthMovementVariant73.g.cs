
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant73
    {
        /// <summary>
        /// 
        /// </summary>
        Jump,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant73Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant73 value)
        {
            return value switch
            {
                StrengthMovementVariant73.Jump => "jump",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant73? ToEnum(string value)
        {
            return value switch
            {
                "jump" => StrengthMovementVariant73.Jump,
                _ => null,
            };
        }
    }
}
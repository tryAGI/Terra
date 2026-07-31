
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant170
    {
        /// <summary>
        /// 
        /// </summary>
        Windmill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant170Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant170 value)
        {
            return value switch
            {
                StrengthMovementVariant170.Windmill => "windmill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant170? ToEnum(string value)
        {
            return value switch
            {
                "windmill" => StrengthMovementVariant170.Windmill,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        AroundTheWorld,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant3 value)
        {
            return value switch
            {
                StrengthMovementVariant3.AroundTheWorld => "around_the_world",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant3? ToEnum(string value)
        {
            return value switch
            {
                "around_the_world" => StrengthMovementVariant3.AroundTheWorld,
                _ => null,
            };
        }
    }
}
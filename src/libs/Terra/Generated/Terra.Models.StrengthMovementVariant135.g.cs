
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant135
    {
        /// <summary>
        /// 
        /// </summary>
        SledPush,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant135Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant135 value)
        {
            return value switch
            {
                StrengthMovementVariant135.SledPush => "sled_push",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant135? ToEnum(string value)
        {
            return value switch
            {
                "sled_push" => StrengthMovementVariant135.SledPush,
                _ => null,
            };
        }
    }
}
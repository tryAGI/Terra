
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant46
    {
        /// <summary>
        /// 
        /// </summary>
        GluteBridge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant46Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant46 value)
        {
            return value switch
            {
                StrengthMovementVariant46.GluteBridge => "glute_bridge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant46? ToEnum(string value)
        {
            return value switch
            {
                "glute_bridge" => StrengthMovementVariant46.GluteBridge,
                _ => null,
            };
        }
    }
}
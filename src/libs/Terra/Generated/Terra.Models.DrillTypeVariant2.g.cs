
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum DrillTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Pull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DrillTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DrillTypeVariant2 value)
        {
            return value switch
            {
                DrillTypeVariant2.Pull => "pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DrillTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "pull" => DrillTypeVariant2.Pull,
                _ => null,
            };
        }
    }
}
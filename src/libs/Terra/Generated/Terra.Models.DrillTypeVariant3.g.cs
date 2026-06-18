
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum DrillTypeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Drill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DrillTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DrillTypeVariant3 value)
        {
            return value switch
            {
                DrillTypeVariant3.Drill => "drill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DrillTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "drill" => DrillTypeVariant3.Drill,
                _ => null,
            };
        }
    }
}
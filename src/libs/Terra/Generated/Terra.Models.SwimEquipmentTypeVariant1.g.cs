
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SwimEquipmentTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimEquipmentTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimEquipmentTypeVariant1 value)
        {
            return value switch
            {
                SwimEquipmentTypeVariant1.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimEquipmentTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "none" => SwimEquipmentTypeVariant1.None,
                _ => null,
            };
        }
    }
}
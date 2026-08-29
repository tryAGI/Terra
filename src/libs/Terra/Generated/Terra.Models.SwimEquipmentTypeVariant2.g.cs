
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum SwimEquipmentTypeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        SwimFins,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimEquipmentTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimEquipmentTypeVariant2 value)
        {
            return value switch
            {
                SwimEquipmentTypeVariant2.SwimFins => "swim_fins",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimEquipmentTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "swim_fins" => SwimEquipmentTypeVariant2.SwimFins,
                _ => null,
            };
        }
    }
}
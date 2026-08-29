
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum SwimEquipmentTypeVariant6
    {
        /// <summary>
        ///
        /// </summary>
        SwimSnorkel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimEquipmentTypeVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimEquipmentTypeVariant6 value)
        {
            return value switch
            {
                SwimEquipmentTypeVariant6.SwimSnorkel => "swim_snorkel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimEquipmentTypeVariant6? ToEnum(string value)
        {
            return value switch
            {
                "swim_snorkel" => SwimEquipmentTypeVariant6.SwimSnorkel,
                _ => null,
            };
        }
    }
}
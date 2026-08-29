
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum SwimEquipmentTypeVariant5
    {
        /// <summary>
        ///
        /// </summary>
        SwimPullBuoy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimEquipmentTypeVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimEquipmentTypeVariant5 value)
        {
            return value switch
            {
                SwimEquipmentTypeVariant5.SwimPullBuoy => "swim_pull_buoy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimEquipmentTypeVariant5? ToEnum(string value)
        {
            return value switch
            {
                "swim_pull_buoy" => SwimEquipmentTypeVariant5.SwimPullBuoy,
                _ => null,
            };
        }
    }
}
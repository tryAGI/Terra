
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum SwimEquipmentTypeVariant4
    {
        /// <summary>
        ///
        /// </summary>
        SwimPaddles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SwimEquipmentTypeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SwimEquipmentTypeVariant4 value)
        {
            return value switch
            {
                SwimEquipmentTypeVariant4.SwimPaddles => "swim_paddles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SwimEquipmentTypeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "swim_paddles" => SwimEquipmentTypeVariant4.SwimPaddles,
                _ => null,
            };
        }
    }
}
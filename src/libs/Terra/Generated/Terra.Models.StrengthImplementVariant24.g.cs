
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant24
    {
        /// <summary>
        ///
        /// </summary>
        WeightPlate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant24Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant24 value)
        {
            return value switch
            {
                StrengthImplementVariant24.WeightPlate => "weight_plate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant24? ToEnum(string value)
        {
            return value switch
            {
                "weight_plate" => StrengthImplementVariant24.WeightPlate,
                _ => null,
            };
        }
    }
}
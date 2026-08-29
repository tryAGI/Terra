
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WeightUnitVariant1
    {
        /// <summary>
        ///
        /// </summary>
        Kg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WeightUnitVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WeightUnitVariant1 value)
        {
            return value switch
            {
                WeightUnitVariant1.Kg => "kg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WeightUnitVariant1? ToEnum(string value)
        {
            return value switch
            {
                "kg" => WeightUnitVariant1.Kg,
                _ => null,
            };
        }
    }
}
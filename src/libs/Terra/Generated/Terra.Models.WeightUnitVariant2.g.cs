
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum WeightUnitVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Lbs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WeightUnitVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WeightUnitVariant2 value)
        {
            return value switch
            {
                WeightUnitVariant2.Lbs => "lbs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WeightUnitVariant2? ToEnum(string value)
        {
            return value switch
            {
                "lbs" => WeightUnitVariant2.Lbs,
                _ => null,
            };
        }
    }
}
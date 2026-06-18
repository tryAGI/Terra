
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum NutritionEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Nutrition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NutritionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NutritionEventType value)
        {
            return value switch
            {
                NutritionEventType.Nutrition => "nutrition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NutritionEventType? ToEnum(string value)
        {
            return value switch
            {
                "nutrition" => NutritionEventType.Nutrition,
                _ => null,
            };
        }
    }
}
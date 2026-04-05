
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum NutritionDeleteResponseStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NutritionDeleteResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NutritionDeleteResponseStatus2 value)
        {
            return value switch
            {
                NutritionDeleteResponseStatus2.Error => "error",
                NutritionDeleteResponseStatus2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NutritionDeleteResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => NutritionDeleteResponseStatus2.Error,
                "success" => NutritionDeleteResponseStatus2.Success,
                _ => null,
            };
        }
    }
}
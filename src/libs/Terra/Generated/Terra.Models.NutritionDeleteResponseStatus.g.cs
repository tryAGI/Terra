
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum NutritionDeleteResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NutritionDeleteResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NutritionDeleteResponseStatus value)
        {
            return value switch
            {
                NutritionDeleteResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NutritionDeleteResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => NutritionDeleteResponseStatus.Error,
                _ => null,
            };
        }
    }
}
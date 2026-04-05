
#nullable enable

namespace Terra
{
    /// <summary>
    /// indicates that an error happened (value is error)
    /// </summary>
    public enum NutritionWriteResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NutritionWriteResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NutritionWriteResponseStatus value)
        {
            return value switch
            {
                NutritionWriteResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NutritionWriteResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => NutritionWriteResponseStatus.Error,
                _ => null,
            };
        }
    }
}
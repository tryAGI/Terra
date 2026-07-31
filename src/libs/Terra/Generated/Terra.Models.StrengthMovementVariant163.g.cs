
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant163
    {
        /// <summary>
        /// 
        /// </summary>
        TurkishGetUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant163Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant163 value)
        {
            return value switch
            {
                StrengthMovementVariant163.TurkishGetUp => "turkish_get_up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant163? ToEnum(string value)
        {
            return value switch
            {
                "turkish_get_up" => StrengthMovementVariant163.TurkishGetUp,
                _ => null,
            };
        }
    }
}
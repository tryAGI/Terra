
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant100
    {
        /// <summary>
        /// 
        /// </summary>
        PallofPress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant100Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant100 value)
        {
            return value switch
            {
                StrengthMovementVariant100.PallofPress => "pallof_press",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant100? ToEnum(string value)
        {
            return value switch
            {
                "pallof_press" => StrengthMovementVariant100.PallofPress,
                _ => null,
            };
        }
    }
}
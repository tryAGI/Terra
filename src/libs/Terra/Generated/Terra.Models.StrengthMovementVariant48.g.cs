
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant48
    {
        /// <summary>
        /// 
        /// </summary>
        GoodMorning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant48Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant48 value)
        {
            return value switch
            {
                StrengthMovementVariant48.GoodMorning => "good_morning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant48? ToEnum(string value)
        {
            return value switch
            {
                "good_morning" => StrengthMovementVariant48.GoodMorning,
                _ => null,
            };
        }
    }
}
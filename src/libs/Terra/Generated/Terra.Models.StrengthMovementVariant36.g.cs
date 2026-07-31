
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant36
    {
        /// <summary>
        /// 
        /// </summary>
        Dip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant36Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant36 value)
        {
            return value switch
            {
                StrengthMovementVariant36.Dip => "dip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant36? ToEnum(string value)
        {
            return value switch
            {
                "dip" => StrengthMovementVariant36.Dip,
                _ => null,
            };
        }
    }
}
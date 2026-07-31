
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant146
    {
        /// <summary>
        /// 
        /// </summary>
        StomachVacuum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant146Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant146 value)
        {
            return value switch
            {
                StrengthMovementVariant146.StomachVacuum => "stomach_vacuum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant146? ToEnum(string value)
        {
            return value switch
            {
                "stomach_vacuum" => StrengthMovementVariant146.StomachVacuum,
                _ => null,
            };
        }
    }
}
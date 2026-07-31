
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant49
    {
        /// <summary>
        /// 
        /// </summary>
        Halo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant49Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant49 value)
        {
            return value switch
            {
                StrengthMovementVariant49.Halo => "halo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant49? ToEnum(string value)
        {
            return value switch
            {
                "halo" => StrengthMovementVariant49.Halo,
                _ => null,
            };
        }
    }
}
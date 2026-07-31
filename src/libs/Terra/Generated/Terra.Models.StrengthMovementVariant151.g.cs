
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant151
    {
        /// <summary>
        /// 
        /// </summary>
        Swimmer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant151Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant151 value)
        {
            return value switch
            {
                StrengthMovementVariant151.Swimmer => "swimmer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant151? ToEnum(string value)
        {
            return value switch
            {
                "swimmer" => StrengthMovementVariant151.Swimmer,
                _ => null,
            };
        }
    }
}
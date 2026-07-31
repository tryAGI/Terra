
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthStanceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Curtsy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthStanceVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthStanceVariant2 value)
        {
            return value switch
            {
                StrengthStanceVariant2.Curtsy => "curtsy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthStanceVariant2? ToEnum(string value)
        {
            return value switch
            {
                "curtsy" => StrengthStanceVariant2.Curtsy,
                _ => null,
            };
        }
    }
}
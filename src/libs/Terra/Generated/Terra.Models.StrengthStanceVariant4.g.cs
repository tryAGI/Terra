
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthStanceVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Sumo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthStanceVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthStanceVariant4 value)
        {
            return value switch
            {
                StrengthStanceVariant4.Sumo => "sumo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthStanceVariant4? ToEnum(string value)
        {
            return value switch
            {
                "sumo" => StrengthStanceVariant4.Sumo,
                _ => null,
            };
        }
    }
}
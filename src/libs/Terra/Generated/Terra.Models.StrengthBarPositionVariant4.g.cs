
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthBarPositionVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Goblet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthBarPositionVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthBarPositionVariant4 value)
        {
            return value switch
            {
                StrengthBarPositionVariant4.Goblet => "goblet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthBarPositionVariant4? ToEnum(string value)
        {
            return value switch
            {
                "goblet" => StrengthBarPositionVariant4.Goblet,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthSurfaceVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Floor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant4 value)
        {
            return value switch
            {
                StrengthSurfaceVariant4.Floor => "floor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant4? ToEnum(string value)
        {
            return value switch
            {
                "floor" => StrengthSurfaceVariant4.Floor,
                _ => null,
            };
        }
    }
}
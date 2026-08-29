
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthLoadTypeVariant4
    {
        /// <summary>
        ///
        /// </summary>
        External,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLoadTypeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLoadTypeVariant4 value)
        {
            return value switch
            {
                StrengthLoadTypeVariant4.External => "external",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLoadTypeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "external" => StrengthLoadTypeVariant4.External,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Back,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant4 value)
        {
            return value switch
            {
                StrengthTargetVariant4.Back => "back",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant4? ToEnum(string value)
        {
            return value switch
            {
                "back" => StrengthTargetVariant4.Back,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        BackExtension,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant4 value)
        {
            return value switch
            {
                StrengthMovementVariant4.BackExtension => "back_extension",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant4? ToEnum(string value)
        {
            return value switch
            {
                "back_extension" => StrengthMovementVariant4.BackExtension,
                _ => null,
            };
        }
    }
}
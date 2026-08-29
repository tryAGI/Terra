
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSetTypeVariant4
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSetTypeVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSetTypeVariant4 value)
        {
            return value switch
            {
                StrengthSetTypeVariant4.Failure => "failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSetTypeVariant4? ToEnum(string value)
        {
            return value switch
            {
                "failure" => StrengthSetTypeVariant4.Failure,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant20
    {
        /// <summary>
        ///
        /// </summary>
        Carioca,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant20Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant20 value)
        {
            return value switch
            {
                StrengthMovementVariant20.Carioca => "carioca",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant20? ToEnum(string value)
        {
            return value switch
            {
                "carioca" => StrengthMovementVariant20.Carioca,
                _ => null,
            };
        }
    }
}
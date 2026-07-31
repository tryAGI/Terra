
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant118
    {
        /// <summary>
        /// 
        /// </summary>
        RowErg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant118Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant118 value)
        {
            return value switch
            {
                StrengthMovementVariant118.RowErg => "row_erg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant118? ToEnum(string value)
        {
            return value switch
            {
                "row_erg" => StrengthMovementVariant118.RowErg,
                _ => null,
            };
        }
    }
}
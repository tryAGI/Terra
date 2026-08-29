
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant8
    {
        /// <summary>
        ///
        /// </summary>
        EzBar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant8 value)
        {
            return value switch
            {
                StrengthImplementVariant8.EzBar => "ez_bar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant8? ToEnum(string value)
        {
            return value switch
            {
                "ez_bar" => StrengthImplementVariant8.EzBar,
                _ => null,
            };
        }
    }
}
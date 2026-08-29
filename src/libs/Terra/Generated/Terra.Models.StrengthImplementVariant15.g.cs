
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthImplementVariant15
    {
        /// <summary>
        ///
        /// </summary>
        MedicineBall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthImplementVariant15Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthImplementVariant15 value)
        {
            return value switch
            {
                StrengthImplementVariant15.MedicineBall => "medicine_ball",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthImplementVariant15? ToEnum(string value)
        {
            return value switch
            {
                "medicine_ball" => StrengthImplementVariant15.MedicineBall,
                _ => null,
            };
        }
    }
}
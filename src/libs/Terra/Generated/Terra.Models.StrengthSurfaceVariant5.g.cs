
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSurfaceVariant5
    {
        /// <summary>
        ///
        /// </summary>
        FoamRoller,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant5 value)
        {
            return value switch
            {
                StrengthSurfaceVariant5.FoamRoller => "foam_roller",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant5? ToEnum(string value)
        {
            return value switch
            {
                "foam_roller" => StrengthSurfaceVariant5.FoamRoller,
                _ => null,
            };
        }
    }
}
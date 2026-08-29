
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthPositionVariant5
    {
        /// <summary>
        ///
        /// </summary>
        Forearm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthPositionVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthPositionVariant5 value)
        {
            return value switch
            {
                StrengthPositionVariant5.Forearm => "forearm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthPositionVariant5? ToEnum(string value)
        {
            return value switch
            {
                "forearm" => StrengthPositionVariant5.Forearm,
                _ => null,
            };
        }
    }
}
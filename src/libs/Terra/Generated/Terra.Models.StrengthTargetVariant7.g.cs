
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant7
    {
        /// <summary>
        ///
        /// </summary>
        Chest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant7 value)
        {
            return value switch
            {
                StrengthTargetVariant7.Chest => "chest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant7? ToEnum(string value)
        {
            return value switch
            {
                "chest" => StrengthTargetVariant7.Chest,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant27
    {
        /// <summary>
        ///
        /// </summary>
        CleanPull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant27Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant27 value)
        {
            return value switch
            {
                StrengthMovementVariant27.CleanPull => "clean_pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant27? ToEnum(string value)
        {
            return value switch
            {
                "clean_pull" => StrengthMovementVariant27.CleanPull,
                _ => null,
            };
        }
    }
}
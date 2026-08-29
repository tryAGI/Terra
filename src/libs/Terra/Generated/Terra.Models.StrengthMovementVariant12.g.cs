
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant12
    {
        /// <summary>
        ///
        /// </summary>
        BodySaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant12 value)
        {
            return value switch
            {
                StrengthMovementVariant12.BodySaw => "body_saw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant12? ToEnum(string value)
        {
            return value switch
            {
                "body_saw" => StrengthMovementVariant12.BodySaw,
                _ => null,
            };
        }
    }
}
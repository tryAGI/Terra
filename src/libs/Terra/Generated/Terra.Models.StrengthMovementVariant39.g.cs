
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant39
    {
        /// <summary>
        ///
        /// </summary>
        FacePull,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant39Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant39 value)
        {
            return value switch
            {
                StrengthMovementVariant39.FacePull => "face_pull",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant39? ToEnum(string value)
        {
            return value switch
            {
                "face_pull" => StrengthMovementVariant39.FacePull,
                _ => null,
            };
        }
    }
}
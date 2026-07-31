
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant96
    {
        /// <summary>
        /// 
        /// </summary>
        NeckFlexion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant96Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant96 value)
        {
            return value switch
            {
                StrengthMovementVariant96.NeckFlexion => "neck_flexion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant96? ToEnum(string value)
        {
            return value switch
            {
                "neck_flexion" => StrengthMovementVariant96.NeckFlexion,
                _ => null,
            };
        }
    }
}
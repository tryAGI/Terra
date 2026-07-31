
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant148
    {
        /// <summary>
        /// 
        /// </summary>
        Stretch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant148Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant148 value)
        {
            return value switch
            {
                StrengthMovementVariant148.Stretch => "stretch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant148? ToEnum(string value)
        {
            return value switch
            {
                "stretch" => StrengthMovementVariant148.Stretch,
                _ => null,
            };
        }
    }
}
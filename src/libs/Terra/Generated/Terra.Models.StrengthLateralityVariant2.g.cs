
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthLateralityVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Bilateral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthLateralityVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthLateralityVariant2 value)
        {
            return value switch
            {
                StrengthLateralityVariant2.Bilateral => "bilateral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthLateralityVariant2? ToEnum(string value)
        {
            return value switch
            {
                "bilateral" => StrengthLateralityVariant2.Bilateral,
                _ => null,
            };
        }
    }
}
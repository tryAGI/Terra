
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthSurfaceVariant8
    {
        /// <summary>
        ///
        /// </summary>
        SwissBall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant8 value)
        {
            return value switch
            {
                StrengthSurfaceVariant8.SwissBall => "swiss_ball",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant8? ToEnum(string value)
        {
            return value switch
            {
                "swiss_ball" => StrengthSurfaceVariant8.SwissBall,
                _ => null,
            };
        }
    }
}
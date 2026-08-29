
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum EnvironmentTypeVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Pool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentTypeVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentTypeVariant3 value)
        {
            return value switch
            {
                EnvironmentTypeVariant3.Pool => "pool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentTypeVariant3? ToEnum(string value)
        {
            return value switch
            {
                "pool" => EnvironmentTypeVariant3.Pool,
                _ => null,
            };
        }
    }
}
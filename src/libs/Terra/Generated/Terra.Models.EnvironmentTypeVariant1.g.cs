
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentTypeVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Indoor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentTypeVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentTypeVariant1 value)
        {
            return value switch
            {
                EnvironmentTypeVariant1.Indoor => "indoor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentTypeVariant1? ToEnum(string value)
        {
            return value switch
            {
                "indoor" => EnvironmentTypeVariant1.Indoor,
                _ => null,
            };
        }
    }
}
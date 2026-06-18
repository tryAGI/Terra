
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Outdoor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentTypeVariant2 value)
        {
            return value switch
            {
                EnvironmentTypeVariant2.Outdoor => "outdoor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "outdoor" => EnvironmentTypeVariant2.Outdoor,
                _ => null,
            };
        }
    }
}
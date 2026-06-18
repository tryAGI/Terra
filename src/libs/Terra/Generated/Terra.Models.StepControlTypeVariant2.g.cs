
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StepControlTypeVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        Resistance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepControlTypeVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepControlTypeVariant2 value)
        {
            return value switch
            {
                StepControlTypeVariant2.Resistance => "resistance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepControlTypeVariant2? ToEnum(string value)
        {
            return value switch
            {
                "resistance" => StepControlTypeVariant2.Resistance,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        HipFlexor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant14 value)
        {
            return value switch
            {
                StrengthTargetVariant14.HipFlexor => "hip_flexor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant14? ToEnum(string value)
        {
            return value switch
            {
                "hip_flexor" => StrengthTargetVariant14.HipFlexor,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthTargetVariant13
    {
        /// <summary>
        /// 
        /// </summary>
        HipAdductor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant13Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant13 value)
        {
            return value switch
            {
                StrengthTargetVariant13.HipAdductor => "hip_adductor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant13? ToEnum(string value)
        {
            return value switch
            {
                "hip_adductor" => StrengthTargetVariant13.HipAdductor,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthTargetVariant12
    {
        /// <summary>
        ///
        /// </summary>
        HipAbductor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthTargetVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthTargetVariant12 value)
        {
            return value switch
            {
                StrengthTargetVariant12.HipAbductor => "hip_abductor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthTargetVariant12? ToEnum(string value)
        {
            return value switch
            {
                "hip_abductor" => StrengthTargetVariant12.HipAbductor,
                _ => null,
            };
        }
    }
}
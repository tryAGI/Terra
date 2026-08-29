
#nullable enable

namespace Terra
{
    /// <summary>
    /// Iliopsoas and sartorius. Its own group — not part of the quadriceps.
    /// </summary>
    public enum StrengthMuscleVariant11
    {
        /// <summary>
        ///
        /// </summary>
        HipFlexor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant11 value)
        {
            return value switch
            {
                StrengthMuscleVariant11.HipFlexor => "hip_flexor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant11? ToEnum(string value)
        {
            return value switch
            {
                "hip_flexor" => StrengthMuscleVariant11.HipFlexor,
                _ => null,
            };
        }
    }
}
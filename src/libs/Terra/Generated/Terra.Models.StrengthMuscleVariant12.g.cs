
#nullable enable

namespace Terra
{
    /// <summary>
    /// Latissimus dorsi. Reported separately from `back` and `upper_back`: a pulldown and a row are different work.
    /// </summary>
    public enum StrengthMuscleVariant12
    {
        /// <summary>
        ///
        /// </summary>
        Lat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMuscleVariant12Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMuscleVariant12 value)
        {
            return value switch
            {
                StrengthMuscleVariant12.Lat => "lat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMuscleVariant12? ToEnum(string value)
        {
            return value switch
            {
                "lat" => StrengthMuscleVariant12.Lat,
                _ => null,
            };
        }
    }
}
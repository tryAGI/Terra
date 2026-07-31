
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthGripOrientationVariant4
    {
        /// <summary>
        /// 
        /// </summary>
        Overhand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthGripOrientationVariant4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthGripOrientationVariant4 value)
        {
            return value switch
            {
                StrengthGripOrientationVariant4.Overhand => "overhand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthGripOrientationVariant4? ToEnum(string value)
        {
            return value switch
            {
                "overhand" => StrengthGripOrientationVariant4.Overhand,
                _ => null,
            };
        }
    }
}
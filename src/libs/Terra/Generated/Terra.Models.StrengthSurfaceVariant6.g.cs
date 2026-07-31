
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthSurfaceVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        GluteHamMachine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSurfaceVariant6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSurfaceVariant6 value)
        {
            return value switch
            {
                StrengthSurfaceVariant6.GluteHamMachine => "glute_ham_machine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSurfaceVariant6? ToEnum(string value)
        {
            return value switch
            {
                "glute_ham_machine" => StrengthSurfaceVariant6.GluteHamMachine,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthSourceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        UserLogged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSourceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSourceVariant1 value)
        {
            return value switch
            {
                StrengthSourceVariant1.UserLogged => "user_logged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSourceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "user_logged" => StrengthSourceVariant1.UserLogged,
                _ => null,
            };
        }
    }
}
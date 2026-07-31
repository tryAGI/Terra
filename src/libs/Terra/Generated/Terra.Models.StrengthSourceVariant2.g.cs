
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthSourceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        UserLogged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthSourceVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthSourceVariant2 value)
        {
            return value switch
            {
                StrengthSourceVariant2.UserLogged => "user_logged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthSourceVariant2? ToEnum(string value)
        {
            return value switch
            {
                "user_logged" => StrengthSourceVariant2.UserLogged,
                _ => null,
            };
        }
    }
}
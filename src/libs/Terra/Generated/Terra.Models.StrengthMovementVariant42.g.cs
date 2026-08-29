
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant42
    {
        /// <summary>
        ///
        /// </summary>
        FlutterKick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant42Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant42 value)
        {
            return value switch
            {
                StrengthMovementVariant42.FlutterKick => "flutter_kick",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant42? ToEnum(string value)
        {
            return value switch
            {
                "flutter_kick" => StrengthMovementVariant42.FlutterKick,
                _ => null,
            };
        }
    }
}
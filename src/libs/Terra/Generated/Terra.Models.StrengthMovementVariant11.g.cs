
#nullable enable

namespace Terra
{
    /// <summary>
    ///
    /// </summary>
    public enum StrengthMovementVariant11
    {
        /// <summary>
        ///
        /// </summary>
        BirdDog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant11 value)
        {
            return value switch
            {
                StrengthMovementVariant11.BirdDog => "bird_dog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant11? ToEnum(string value)
        {
            return value switch
            {
                "bird_dog" => StrengthMovementVariant11.BirdDog,
                _ => null,
            };
        }
    }
}
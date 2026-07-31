
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public enum StrengthMovementVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        BearCrawl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StrengthMovementVariant7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StrengthMovementVariant7 value)
        {
            return value switch
            {
                StrengthMovementVariant7.BearCrawl => "bear_crawl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StrengthMovementVariant7? ToEnum(string value)
        {
            return value switch
            {
                "bear_crawl" => StrengthMovementVariant7.BearCrawl,
                _ => null,
            };
        }
    }
}
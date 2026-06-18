
#nullable enable

namespace Terra
{
    /// <summary>
    /// Default Value: success
    /// </summary>
    public enum IntegrationsFetchResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationsFetchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationsFetchResponseStatus value)
        {
            return value switch
            {
                IntegrationsFetchResponseStatus.Error => "error",
                IntegrationsFetchResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationsFetchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => IntegrationsFetchResponseStatus.Error,
                "success" => IntegrationsFetchResponseStatus.Success,
                _ => null,
            };
        }
    }
}
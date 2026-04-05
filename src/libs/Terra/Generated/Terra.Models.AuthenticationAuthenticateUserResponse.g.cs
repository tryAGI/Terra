
#nullable enable

namespace Terra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthenticationAuthenticateUserResponse
    {
        /// <summary>
        /// indicates that the request was successful<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Terra.JsonConverters.AuthenticationAuthenticateUserResponseStatusJsonConverter))]
        public global::Terra.AuthenticationAuthenticateUserResponseStatus? Status { get; set; }

        /// <summary>
        /// User ID for the user being created<br/>
        /// Example: 23dc2540-7139-44c6-8158-f81196e2cf2e
        /// </summary>
        /// <example>23dc2540-7139-44c6-8158-f81196e2cf2e</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// authentication URL the user must be redirected to in order to link their account<br/>
        /// Example: https://www.fitbit.com/oauth2/authorize?response_type=code&amp;client_id=23BBG9&amp;scope=settings+nutrition+sleep+heartrate+electrocardiogram+weight+respiratory_rate+oxygen_saturation+profile+temperature+cardio_fitness+activity+location&amp;state=bLqqjPie9ptwoWm6VBxHCu6JkkoWJp
        /// </summary>
        /// <example>https://www.fitbit.com/oauth2/authorize?response_type=code&amp;client_id=23BBG9&amp;scope=settings+nutrition+sleep+heartrate+electrocardiogram+weight+respiratory_rate+oxygen_saturation+profile+temperature+cardio_fitness+activity+location&amp;state=bLqqjPie9ptwoWm6VBxHCu6JkkoWJp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        public string? AuthUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationAuthenticateUserResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// indicates that the request was successful<br/>
        /// Example: success
        /// </param>
        /// <param name="userId">
        /// User ID for the user being created<br/>
        /// Example: 23dc2540-7139-44c6-8158-f81196e2cf2e
        /// </param>
        /// <param name="authUrl">
        /// authentication URL the user must be redirected to in order to link their account<br/>
        /// Example: https://www.fitbit.com/oauth2/authorize?response_type=code&amp;client_id=23BBG9&amp;scope=settings+nutrition+sleep+heartrate+electrocardiogram+weight+respiratory_rate+oxygen_saturation+profile+temperature+cardio_fitness+activity+location&amp;state=bLqqjPie9ptwoWm6VBxHCu6JkkoWJp
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthenticationAuthenticateUserResponse(
            global::Terra.AuthenticationAuthenticateUserResponseStatus? status,
            string? userId,
            string? authUrl)
        {
            this.Status = status;
            this.UserId = userId;
            this.AuthUrl = authUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationAuthenticateUserResponse" /> class.
        /// </summary>
        public AuthenticationAuthenticateUserResponse()
        {
        }
    }
}
#nullable enable

namespace Terra
{
    public partial interface IAthleteClient
    {
        /// <summary>
        /// Retrieve athlete profile<br/>
        /// Returns the user profile, such as first and last name, birth date and gender.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="toWebhook"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>> AthleteGetAsync(
            string userId,
            bool? toWebhook = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve athlete profile<br/>
        /// Returns the user profile, such as first and last name, birth date and gender.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="toWebhook"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.AutoSDKHttpResponse<global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.DataSentToWebhook>>> AthleteGetAsResponseAsync(
            string userId,
            bool? toWebhook = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Terra
{
    public partial interface IAthleteClient
    {
        /// <summary>
        /// Retrieve user profile info for a given user ID<br/>
        /// Fetches relevant profile info such as first &amp; last name, birth date etc. for a given user ID
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="toWebhook"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.AthleteCollection, global::Terra.NoDataReturned, global::Terra.DataSentToWebhook>> AthleteFetchAsync(
            string userId,
            bool? toWebhook = default,
            global::Terra.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
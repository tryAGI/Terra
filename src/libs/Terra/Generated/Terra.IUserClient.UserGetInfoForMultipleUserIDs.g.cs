#nullable enable

namespace Terra
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get information for multiple user IDs<br/>
        /// Used to query for information for multiple Terra User IDs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Terra.TerraUser>> UserGetInfoForMultipleUserIDsAsync(

            global::System.Collections.Generic.IList<string> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
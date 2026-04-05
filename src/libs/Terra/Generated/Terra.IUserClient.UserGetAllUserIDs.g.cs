#nullable enable

namespace Terra
{
    public partial interface IUserClient
    {
        /// <summary>
        /// Get all Terra User IDs<br/>
        /// Used to query for information for all Terra User IDs. Supports optional pagination via `page` and `per_page`. If `page` is not provided, it returns all users in one go (backwards compatibility).
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Terra.OneOf<global::Terra.UserGetAllUserIDsResponseVariant1, global::Terra.UserGetAllUserIDsResponseVariant2>> UserGetAllUserIDsAsync(
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
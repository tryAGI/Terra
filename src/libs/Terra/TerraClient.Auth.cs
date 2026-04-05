namespace Terra;

public sealed partial class TerraClient
{
    /// <summary>
    /// Creates a new TerraClient with dual-header authentication.<br/>
    /// Terra API requires both an API key (x-api-key header) and 
    /// a developer ID (dev-id header) for authentication.
    /// </summary>
    /// <param name="apiKey">Your Terra API key.</param>
    /// <param name="devId">Your Terra developer ID.</param>
    /// <param name="httpClient">Optional HTTP client instance.</param>
    /// <param name="baseUri">Optional base URI override.</param>
    /// <param name="disposeHttpClient">Whether to dispose the HTTP client when this client is disposed.</param>
    public TerraClient(
        string apiKey,
        string devId,
        global::System.Net.Http.HttpClient? httpClient = null,
        global::System.Uri? baseUri = null,
        bool disposeHttpClient = true) : this(apiKey, httpClient, baseUri, authorizations: null, disposeHttpClient)
    {
        devId = devId ?? throw new global::System.ArgumentNullException(nameof(devId));

        // Clear Bearer auth - Terra doesn't use Authorization header
        Authorizations.Clear();

        // Set Terra's dual-header auth on DefaultRequestHeaders so all sub-clients inherit them
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", apiKey);
        HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("dev-id", devId);
    }
}

namespace Terra.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static TerraClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("TERRA_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("TERRA_API_KEY environment variable is not found.");

        var devId =
            Environment.GetEnvironmentVariable("TERRA_DEV_ID") is { Length: > 0 } devIdValue
                ? devIdValue
                : throw new AssertInconclusiveException("TERRA_DEV_ID environment variable is not found.");

        var client = new TerraClient(apiKey, devId);

        return client;
    }
}

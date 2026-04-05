namespace Terra.IntegrationTests;

[TestClass]
public partial class Examples
{
    [TestMethod]
    public void AIFunctions()
    {
        //// Use Terra tools with any MEAI-compatible AI provider
        using var client = new TerraClient(apiKey: "test", devId: "test");
        var tools = client.AsTools();
        tools.Count.Should().BeGreaterThan(0);
    }
}

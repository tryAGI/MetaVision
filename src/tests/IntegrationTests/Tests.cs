namespace MetaVision.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static string GetApiKey()
    {
        return Environment.GetEnvironmentVariable("METAVISION_API_KEY") is { Length: > 0 } apiKeyValue
            ? apiKeyValue
            : throw new AssertInconclusiveException("METAVISION_API_KEY environment variable is not found.");
    }

    private static MetaVisionClient GetAuthenticatedClient()
    {
        return new MetaVisionClient(GetApiKey());
    }
}

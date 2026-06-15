/*
order: 10
title: Generate
slug: generate

Create a MetaVision client, validate the configured API key, and prepare a
text-to-3D generation request.
*/

namespace MetaVision.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_Generate()
    {
        var apiKey = GetApiKey();
        using var client = GetAuthenticatedClient();

        //// Validate the API key before starting a generation task. This endpoint
        //// does not spend generation credits.
        var key = await client.Keys.ValidateApiKeyAsync(apiKey);
        key.Valid.Should().BeTrue();

        //// Text-to-3D generation is asynchronous and returns a task id. The
        //// request below shows the typed payload used by
        //// `CreateTextTo3DGenerationAsync` without spending credits in tests.
        var request = new TextTo3DGenerationRequest("a futuristic spaceship");
        request.Prompt.Should().NotBeNullOrWhiteSpace();
    }
}

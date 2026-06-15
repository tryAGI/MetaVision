# Generate

Create a MetaVision client, validate the configured API key, and prepare a
text-to-3D generation request.

This example assumes `using MetaVision;` is in scope and `apiKey` contains your MetaVision API key.

```csharp
using var client = new MetaVisionClient(apiKey);

// Validate the API key before starting a generation task. This endpoint
// does not spend generation credits.
var key = await client.Keys.ValidateApiKeyAsync(apiKey);

// Text-to-3D generation is asynchronous and returns a task id. The
// request below shows the typed payload used by
// `CreateTextTo3DGenerationAsync` without spending credits in tests.
var request = new TextTo3DGenerationRequest("a futuristic spaceship");
```
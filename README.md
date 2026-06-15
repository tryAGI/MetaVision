<div class="docs-hero">
  <h1>MetaVision</h1>
  <p class="docs-hero-lead">Modern .NET SDK for MetaVision text-to-3D and image-to-3D generation, generated with AutoSDK.</p>
  <div class="docs-badge-row">
    <a href="https://www.nuget.org/packages/MetaVision/"><img alt="Nuget package" src="https://img.shields.io/nuget/vpre/MetaVision"></a>
    <a href="https://github.com/tryAGI/MetaVision/actions/workflows/dotnet.yml"><img alt="dotnet" src="https://github.com/tryAGI/MetaVision/actions/workflows/dotnet.yml/badge.svg?branch=main"></a>
    <a href="https://github.com/tryAGI/MetaVision/blob/main/LICENSE.txt"><img alt="License: MIT" src="https://img.shields.io/github/license/tryAGI/MetaVision"></a>
    <a href="https://discord.gg/Ca2xhfBf3v"><img alt="Discord" src="https://img.shields.io/discord/1115206893015662663?label=Discord&amp;logo=discord&amp;logoColor=white&amp;color=d82679"></a>
  </div>
  <div class="docs-hero-actions">
    <a href="#usage">Get started</a>
    <a href="#support">Get support</a>
  </div>
</div>

<div class="docs-feature-grid">
  <div class="docs-feature-card">
    <h3>Generated from the source spec</h3>
    <p>Built from a locally maintained OpenAPI definition based on <a href="https://metavision.click/docs">MetaVision's public API documentation</a> and <a href="https://metavision.click/.well-known/agent.json">A2A agent card</a> so the SDK stays close to the upstream API surface.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Auto-updated</h3>
    <p>Designed for fast regeneration and low-friction updates when the upstream API changes without breaking compatibility.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Modern .NET</h3>
    <p>Targets current .NET practices including nullability, trimming, NativeAOT awareness, and source-generated serialization.</p>
  </div>
  <div class="docs-feature-card">
    <h3>Docs from examples</h3>
    <p>Examples stay in sync between the README, MkDocs site, and integration tests through the AutoSDK docs pipeline.</p>
  </div>
</div>

## Usage

```csharp
using MetaVision;

using var client = new MetaVisionClient(apiKey);
```

<!-- EXAMPLES:START -->
### Generate
Create a MetaVision client, validate the configured API key, and prepare a
text-to-3D generation request.

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
<!-- EXAMPLES:END -->

## Support

<div class="docs-card-grid">
  <div class="docs-card">
    <h3>Bugs</h3>
    <p>Open an issue in <a href="https://github.com/tryAGI/MetaVision/issues">tryAGI/MetaVision</a>.</p>
  </div>
  <div class="docs-card">
    <h3>Ideas and questions</h3>
    <p>Use <a href="https://github.com/tryAGI/MetaVision/discussions">GitHub Discussions</a> for design questions and usage help.</p>
  </div>
  <div class="docs-card">
    <h3>Community</h3>
    <p>Join the <a href="https://discord.gg/Ca2xhfBf3v">tryAGI Discord</a> for broader discussion across SDKs.</p>
  </div>
</div>

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

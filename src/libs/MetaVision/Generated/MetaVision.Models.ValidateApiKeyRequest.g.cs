
#nullable enable

namespace MetaVision
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidateApiKeyRequest
    {
        /// <summary>
        /// MetaVision API key to validate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// MetaVision API key to validate.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateApiKeyRequest(
            string apiKey)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateApiKeyRequest" /> class.
        /// </summary>
        public ValidateApiKeyRequest()
        {
        }

    }
}
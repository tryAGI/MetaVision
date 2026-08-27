
#nullable enable

namespace MetaVision
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextTo3DGenerationRequest
    {
        /// <summary>
        /// Text description of the 3D model to generate.<br/>
        /// Example: a futuristic spaceship
        /// </summary>
        /// <example>a futuristic spaceship</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DGenerationRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the 3D model to generate.<br/>
        /// Example: a futuristic spaceship
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextTo3DGenerationRequest(
            string prompt)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DGenerationRequest" /> class.
        /// </summary>
        public TextTo3DGenerationRequest()
        {
        }

    }
}
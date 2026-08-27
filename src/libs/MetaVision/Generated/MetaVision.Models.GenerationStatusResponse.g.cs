
#nullable enable

namespace MetaVision
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerationStatusResponse
    {
        /// <summary>
        /// Generation task state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::MetaVision.JsonConverters.GenerationStatusJsonConverter))]
        public global::MetaVision.GenerationStatus? Status { get; set; }

        /// <summary>
        /// Completion percentage.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// Generated 3D model URL when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Preview image URL when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Generation task state.
        /// </param>
        /// <param name="progress">
        /// Completion percentage.<br/>
        /// Example: 100
        /// </param>
        /// <param name="model">
        /// Generated 3D model URL when available.
        /// </param>
        /// <param name="image">
        /// Preview image URL when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationStatusResponse(
            global::MetaVision.GenerationStatus? status,
            double? progress,
            string? model,
            string? image)
        {
            this.Status = status;
            this.Progress = progress;
            this.Model = model;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationStatusResponse" /> class.
        /// </summary>
        public GenerationStatusResponse()
        {
        }

    }
}

#nullable enable

namespace MetaVision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageTo3DGenerationRequest
    {
        /// <summary>
        /// Source image file to convert into a 3D model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Image { get; set; }

        /// <summary>
        /// Source image file to convert into a 3D model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Imagename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTo3DGenerationRequest" /> class.
        /// </summary>
        /// <param name="image">
        /// Source image file to convert into a 3D model.
        /// </param>
        /// <param name="imagename">
        /// Source image file to convert into a 3D model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageTo3DGenerationRequest(
            byte[] image,
            string imagename)
        {
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Imagename = imagename ?? throw new global::System.ArgumentNullException(nameof(imagename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageTo3DGenerationRequest" /> class.
        /// </summary>
        public ImageTo3DGenerationRequest()
        {
        }

    }
}
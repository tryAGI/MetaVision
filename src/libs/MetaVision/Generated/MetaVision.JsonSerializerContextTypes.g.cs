
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace MetaVision
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.TextTo3DGenerationRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.ImageTo3DGenerationRequest? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.GenerationTaskResponse? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.GenerationStatus? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.GenerationStatusResponse? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.ValidateApiKeyRequest? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.ValidateApiKeyResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::MetaVision.ErrorResponse? Type11 { get; set; }

    }
}
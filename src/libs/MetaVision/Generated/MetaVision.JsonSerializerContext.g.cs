
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace MetaVision
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::MetaVision.JsonConverters.GenerationStatusJsonConverter),

            typeof(global::MetaVision.JsonConverters.GenerationStatusNullableJsonConverter),

            typeof(global::MetaVision.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.TextTo3DGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.ImageTo3DGenerationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.GenerationTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.GenerationStatus), TypeInfoPropertyName = "GenerationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.GenerationStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.ValidateApiKeyRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.ValidateApiKeyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::MetaVision.ErrorResponse))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
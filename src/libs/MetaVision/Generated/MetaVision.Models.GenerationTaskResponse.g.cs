
#nullable enable

namespace MetaVision
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationTaskResponse
    {
        /// <summary>
        /// Asynchronous generation task identifier.<br/>
        /// Example: abc123-...
        /// </summary>
        /// <example>abc123-...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationTaskResponse" /> class.
        /// </summary>
        /// <param name="taskId">
        /// Asynchronous generation task identifier.<br/>
        /// Example: abc123-...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationTaskResponse(
            string taskId)
        {
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationTaskResponse" /> class.
        /// </summary>
        public GenerationTaskResponse()
        {
        }

    }
}
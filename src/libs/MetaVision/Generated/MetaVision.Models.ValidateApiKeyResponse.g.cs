
#nullable enable

namespace MetaVision
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidateApiKeyResponse
    {
        /// <summary>
        /// Whether the submitted API key is valid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        public bool? Valid { get; set; }

        /// <summary>
        /// API plan name.<br/>
        /// Example: basic
        /// </summary>
        /// <example>basic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public string? Plan { get; set; }

        /// <summary>
        /// Total credits for the current plan.<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// Credits used.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        public double? Used { get; set; }

        /// <summary>
        /// Credits remaining.<br/>
        /// Example: 45
        /// </summary>
        /// <example>45</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public double? Remaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="valid">
        /// Whether the submitted API key is valid.
        /// </param>
        /// <param name="plan">
        /// API plan name.<br/>
        /// Example: basic
        /// </param>
        /// <param name="credits">
        /// Total credits for the current plan.<br/>
        /// Example: 50
        /// </param>
        /// <param name="used">
        /// Credits used.<br/>
        /// Example: 5
        /// </param>
        /// <param name="remaining">
        /// Credits remaining.<br/>
        /// Example: 45
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateApiKeyResponse(
            bool? valid,
            string? plan,
            double? credits,
            double? used,
            double? remaining)
        {
            this.Valid = valid;
            this.Plan = plan;
            this.Credits = credits;
            this.Used = used;
            this.Remaining = remaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateApiKeyResponse" /> class.
        /// </summary>
        public ValidateApiKeyResponse()
        {
        }

    }
}
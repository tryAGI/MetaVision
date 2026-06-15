#nullable enable

namespace MetaVision
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Generate a 3D model from text<br/>
        /// Creates an asynchronous 3D generation task from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.GenerationTaskResponse> CreateTextTo3DGenerationAsync(

            global::MetaVision.TextTo3DGenerationRequest request,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from text<br/>
        /// Creates an asynchronous 3D generation task from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.AutoSDKHttpResponse<global::MetaVision.GenerationTaskResponse>> CreateTextTo3DGenerationAsResponseAsync(

            global::MetaVision.TextTo3DGenerationRequest request,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from text<br/>
        /// Creates an asynchronous 3D generation task from a text prompt.
        /// </summary>
        /// <param name="prompt">
        /// Text description of the 3D model to generate.<br/>
        /// Example: a futuristic spaceship
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.GenerationTaskResponse> CreateTextTo3DGenerationAsync(
            string prompt,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
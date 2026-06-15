#nullable enable

namespace MetaVision
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Check generation task status<br/>
        /// Gets the status, progress, and output URLs for a generation task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.GenerationStatusResponse> GetGenerationStatusAsync(
            string taskId,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check generation task status<br/>
        /// Gets the status, progress, and output URLs for a generation task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.AutoSDKHttpResponse<global::MetaVision.GenerationStatusResponse>> GetGenerationStatusAsResponseAsync(
            string taskId,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
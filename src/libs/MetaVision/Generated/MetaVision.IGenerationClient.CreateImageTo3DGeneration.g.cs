#nullable enable

namespace MetaVision
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Generate a 3D model from an image<br/>
        /// Creates an asynchronous 3D generation task from an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.GenerationTaskResponse> CreateImageTo3DGenerationAsync(

            global::MetaVision.ImageTo3DGenerationRequest request,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from an image<br/>
        /// Creates an asynchronous 3D generation task from an uploaded image.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.AutoSDKHttpResponse<global::MetaVision.GenerationTaskResponse>> CreateImageTo3DGenerationAsResponseAsync(

            global::MetaVision.ImageTo3DGenerationRequest request,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from an image<br/>
        /// Creates an asynchronous 3D generation task from an uploaded image.
        /// </summary>
        /// <param name="image">
        /// Source image file to convert into a 3D model.
        /// </param>
        /// <param name="imagename">
        /// Source image file to convert into a 3D model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.GenerationTaskResponse> CreateImageTo3DGenerationAsync(
            byte[] image,
            string imagename,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate a 3D model from an image<br/>
        /// Creates an asynchronous 3D generation task from an uploaded image.
        /// </summary>
        /// <param name="image">
        /// Source image file to convert into a 3D model.
        /// </param>
        /// <param name="imagename">
        /// Source image file to convert into a 3D model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.GenerationTaskResponse> CreateImageTo3DGenerationAsync(
            global::System.IO.Stream image,
            string imagename,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a 3D model from an image<br/>
        /// Creates an asynchronous 3D generation task from an uploaded image.
        /// </summary>
        /// <param name="image">
        /// Source image file to convert into a 3D model.
        /// </param>
        /// <param name="imagename">
        /// Source image file to convert into a 3D model.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.AutoSDKHttpResponse<global::MetaVision.GenerationTaskResponse>> CreateImageTo3DGenerationAsResponseAsync(
            global::System.IO.Stream image,
            string imagename,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
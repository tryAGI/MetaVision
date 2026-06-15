#nullable enable

namespace MetaVision
{
    public partial interface IKeysClient
    {
        /// <summary>
        /// Validate an API key<br/>
        /// Validates an API key and returns plan and credit usage details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.ValidateApiKeyResponse> ValidateApiKeyAsync(

            global::MetaVision.ValidateApiKeyRequest request,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate an API key<br/>
        /// Validates an API key and returns plan and credit usage details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::MetaVision.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.AutoSDKHttpResponse<global::MetaVision.ValidateApiKeyResponse>> ValidateApiKeyAsResponseAsync(

            global::MetaVision.ValidateApiKeyRequest request,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate an API key<br/>
        /// Validates an API key and returns plan and credit usage details.
        /// </summary>
        /// <param name="apiKey">
        /// MetaVision API key to validate.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::MetaVision.ValidateApiKeyResponse> ValidateApiKeyAsync(
            string apiKey,
            global::MetaVision.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}

#nullable enable

namespace Terra
{
    public partial class AuthenticationClient
    {


        private static readonly global::Terra.EndPointSecurityRequirement s_AuthenticationAuthenticateUserSecurityRequirement0 =
            new global::Terra.EndPointSecurityRequirement
            {
                Authorizations = new global::Terra.EndPointAuthorizationRequirement[]
                {                    new global::Terra.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Terra.EndPointSecurityRequirement[] s_AuthenticationAuthenticateUserSecurityRequirements =
            new global::Terra.EndPointSecurityRequirement[]
            {                s_AuthenticationAuthenticateUserSecurityRequirement0,
            };
        partial void PrepareAuthenticationAuthenticateUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string resource,
            global::Terra.AuthenticationAuthenticateUserRequest request);
        partial void PrepareAuthenticationAuthenticateUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string resource,
            global::Terra.AuthenticationAuthenticateUserRequest request);
        partial void ProcessAuthenticationAuthenticateUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAuthenticationAuthenticateUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate an authentication link<br/>
        /// Creates a login link that allows end users to connect their fitness tracking account
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Terra.AuthenticationAuthenticateUserResponse> AuthenticationAuthenticateUserAsync(
            string resource,

            global::Terra.AuthenticationAuthenticateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAuthenticationAuthenticateUserArguments(
                httpClient: HttpClient,
                resource: ref resource,
                request: request);


            var __authorizations = global::Terra.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AuthenticationAuthenticateUserSecurityRequirements,
                operationName: "AuthenticationAuthenticateUserAsync");

            var __pathBuilder = new global::Terra.PathBuilder(
                path: "/auth/authenticateUser",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("resource", resource) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAuthenticationAuthenticateUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                resource: resource,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAuthenticationAuthenticateUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Returned when one or more parameters is malformed - an appropriate error message will be returned
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Terra.AuthenticationAuthenticateUserResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Terra.AuthenticationAuthenticateUserResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Terra.AuthenticationAuthenticateUserResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Terra.ApiException<global::Terra.AuthenticationAuthenticateUserResponse2>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Returned when a parameter does not exist on Terra's end (e.g. resource)
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::Terra.AuthenticationAuthenticateUserResponse3? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::Terra.AuthenticationAuthenticateUserResponse3.FromJson(__content_404, JsonSerializerContext);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::Terra.AuthenticationAuthenticateUserResponse3.FromJson(__content_404, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::Terra.ApiException<global::Terra.AuthenticationAuthenticateUserResponse3>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessAuthenticationAuthenticateUserResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Terra.AuthenticationAuthenticateUserResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Terra.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Terra.AuthenticationAuthenticateUserResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Terra.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Generate an authentication link<br/>
        /// Creates a login link that allows end users to connect their fitness tracking account
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="language"></param>
        /// <param name="referenceId"></param>
        /// <param name="authSuccessRedirectUrl"></param>
        /// <param name="authFailureRedirectUrl"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Terra.AuthenticationAuthenticateUserResponse> AuthenticationAuthenticateUserAsync(
            string resource,
            string? language = default,
            string? referenceId = default,
            string? authSuccessRedirectUrl = default,
            string? authFailureRedirectUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Terra.AuthenticationAuthenticateUserRequest
            {
                Language = language,
                ReferenceId = referenceId,
                AuthSuccessRedirectUrl = authSuccessRedirectUrl,
                AuthFailureRedirectUrl = authFailureRedirectUrl,
            };

            return await AuthenticationAuthenticateUserAsync(
                resource: resource,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
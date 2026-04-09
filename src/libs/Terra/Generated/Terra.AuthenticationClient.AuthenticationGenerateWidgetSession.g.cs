
#nullable enable

namespace Terra
{
    public partial class AuthenticationClient
    {


        private static readonly global::Terra.EndPointSecurityRequirement s_AuthenticationGenerateWidgetSessionSecurityRequirement0 =
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
        private static readonly global::Terra.EndPointSecurityRequirement[] s_AuthenticationGenerateWidgetSessionSecurityRequirements =
            new global::Terra.EndPointSecurityRequirement[]
            {                s_AuthenticationGenerateWidgetSessionSecurityRequirement0,
            };
        partial void PrepareAuthenticationGenerateWidgetSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Terra.WidgetSessionParams request);
        partial void PrepareAuthenticationGenerateWidgetSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Terra.WidgetSessionParams request);
        partial void ProcessAuthenticationGenerateWidgetSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAuthenticationGenerateWidgetSessionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate an authentication link, using the Terra Authentication Widget<br/>
        /// Generates a link to redirect an end user to for them to select an integration and log in with their fitness data provider
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Terra.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateWidgetSessionResponse> AuthenticationGenerateWidgetSessionAsync(

            global::Terra.WidgetSessionParams request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAuthenticationGenerateWidgetSessionArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Terra.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AuthenticationGenerateWidgetSessionSecurityRequirements,
                operationName: "AuthenticationGenerateWidgetSessionAsync");

            var __pathBuilder = new global::Terra.PathBuilder(
                path: "/auth/generateWidgetSession",
                baseUri: HttpClient.BaseAddress);
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
            PrepareAuthenticationGenerateWidgetSessionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAuthenticationGenerateWidgetSessionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Returned when one or more parameters is malformed - an appropriate error message will be returned
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Terra.AuthenticationGenerateWidgetSessionResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Terra.AuthenticationGenerateWidgetSessionResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Terra.AuthenticationGenerateWidgetSessionResponse2.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Terra.ApiException<global::Terra.AuthenticationGenerateWidgetSessionResponse2>(
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
                ProcessAuthenticationGenerateWidgetSessionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Terra.AuthenticationGenerateWidgetSessionResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Terra.AuthenticationGenerateWidgetSessionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Generate an authentication link, using the Terra Authentication Widget<br/>
        /// Generates a link to redirect an end user to for them to select an integration and log in with their fitness data provider
        /// </summary>
        /// <param name="providers">
        /// Comma separated list of providers to display on the device selection page. This overrides your selected sources on your dashboard<br/>
        /// Example: GARMIN,FITBIT,OURA,WITHINGS,SUUNTO
        /// </param>
        /// <param name="language">
        /// Display language of the widget<br/>
        /// Example: en
        /// </param>
        /// <param name="referenceId">
        /// Identifier of the end user on your system, such as a user ID or email associated with them<br/>
        /// Example: user123@email.com
        /// </param>
        /// <param name="authSuccessRedirectUrl">
        /// URL the user is redirected to upon successful authentication<br/>
        /// Example: https://myapp.com/success
        /// </param>
        /// <param name="authFailureRedirectUrl">
        /// URL the user is redirected to upon unsuccessful authentication<br/>
        /// Example: https://myapp.com/failure
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Terra.AuthenticationGenerateWidgetSessionResponse> AuthenticationGenerateWidgetSessionAsync(
            string? providers = default,
            string? language = default,
            string? referenceId = default,
            string? authSuccessRedirectUrl = default,
            string? authFailureRedirectUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Terra.WidgetSessionParams
            {
                Providers = providers,
                Language = language,
                ReferenceId = referenceId,
                AuthSuccessRedirectUrl = authSuccessRedirectUrl,
                AuthFailureRedirectUrl = authFailureRedirectUrl,
            };

            return await AuthenticationGenerateWidgetSessionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
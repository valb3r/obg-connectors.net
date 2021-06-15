/*
 * An include file to define common attributes
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPsuAuthenticationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Login user to open-banking
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns>LoginResponse</returns>
        LoginResponse Login(Guid xRequestID, PsuAuthBody psuAuthBody);

        /// <summary>
        /// Login user to open-banking
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns>ApiResponse of LoginResponse</returns>
        ApiResponse<LoginResponse> LoginWithHttpInfo(Guid xRequestID, PsuAuthBody psuAuthBody);
        /// <summary>
        /// registration user in open-banking db
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns></returns>
        void Registration(Guid xRequestID, PsuAuthBody psuAuthBody);

        /// <summary>
        /// registration user in open-banking db
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RegistrationWithHttpInfo(Guid xRequestID, PsuAuthBody psuAuthBody);
        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one
        /// </summary>
        /// <remarks>
        /// Input is the old cookie, response is empty with a new cookie
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <returns></returns>
        void RenewalAuthorizationSessionKey(Guid xRequestID, Guid authorizationId);

        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one
        /// </summary>
        /// <remarks>
        /// Input is the old cookie, response is empty with a new cookie
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RenewalAuthorizationSessionKeyWithHttpInfo(Guid xRequestID, Guid authorizationId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPsuAuthenticationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Login user to open-banking
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LoginResponse</returns>
        System.Threading.Tasks.Task<LoginResponse> LoginAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Login user to open-banking
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LoginResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LoginResponse>> LoginWithHttpInfoAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// registration user in open-banking db
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RegistrationAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// registration user in open-banking db
        /// </summary>
        /// <remarks>
        /// TBD
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RegistrationWithHttpInfoAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one
        /// </summary>
        /// <remarks>
        /// Input is the old cookie, response is empty with a new cookie
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RenewalAuthorizationSessionKeyAsync(Guid xRequestID, Guid authorizationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one
        /// </summary>
        /// <remarks>
        /// Input is the old cookie, response is empty with a new cookie
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RenewalAuthorizationSessionKeyWithHttpInfoAsync(Guid xRequestID, Guid authorizationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPsuAuthenticationApi : IPsuAuthenticationApiSync, IPsuAuthenticationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PsuAuthenticationApi : IPsuAuthenticationApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PsuAuthenticationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PsuAuthenticationApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PsuAuthenticationApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthenticationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PsuAuthenticationApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Login user to open-banking TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns>LoginResponse</returns>
        public LoginResponse Login(Guid xRequestID, PsuAuthBody psuAuthBody)
        {
            Org.OpenAPITools.Client.ApiResponse<LoginResponse> localVarResponse = LoginWithHttpInfo(xRequestID, psuAuthBody);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Login user to open-banking TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns>ApiResponse of LoginResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<LoginResponse> LoginWithHttpInfo(Guid xRequestID, PsuAuthBody psuAuthBody)
        {
            // verify the required parameter 'psuAuthBody' is set
            if (psuAuthBody == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'psuAuthBody' when calling PsuAuthenticationApi->Login");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("X-Request-ID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xRequestID)); // header parameter
            localVarRequestOptions.Data = psuAuthBody;


            // make the HTTP request
            var localVarResponse = this.Client.Post<LoginResponse>("/v1/psu/login", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Login", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Login user to open-banking TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of LoginResponse</returns>
        public async System.Threading.Tasks.Task<LoginResponse> LoginAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<LoginResponse> localVarResponse = await LoginWithHttpInfoAsync(xRequestID, psuAuthBody, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Login user to open-banking TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (LoginResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<LoginResponse>> LoginWithHttpInfoAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'psuAuthBody' is set
            if (psuAuthBody == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'psuAuthBody' when calling PsuAuthenticationApi->Login");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("X-Request-ID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xRequestID)); // header parameter
            localVarRequestOptions.Data = psuAuthBody;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<LoginResponse>("/v1/psu/login", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Login", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// registration user in open-banking db TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns></returns>
        public void Registration(Guid xRequestID, PsuAuthBody psuAuthBody)
        {
            RegistrationWithHttpInfo(xRequestID, psuAuthBody);
        }

        /// <summary>
        /// registration user in open-banking db TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> RegistrationWithHttpInfo(Guid xRequestID, PsuAuthBody psuAuthBody)
        {
            // verify the required parameter 'psuAuthBody' is set
            if (psuAuthBody == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'psuAuthBody' when calling PsuAuthenticationApi->Registration");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("X-Request-ID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xRequestID)); // header parameter
            localVarRequestOptions.Data = psuAuthBody;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/v1/psu/register", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Registration", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// registration user in open-banking db TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RegistrationAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RegistrationWithHttpInfoAsync(xRequestID, psuAuthBody, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// registration user in open-banking db TBD
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="psuAuthBody">User credentials object</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> RegistrationWithHttpInfoAsync(Guid xRequestID, PsuAuthBody psuAuthBody, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'psuAuthBody' is set
            if (psuAuthBody == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'psuAuthBody' when calling PsuAuthenticationApi->Registration");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.HeaderParameters.Add("X-Request-ID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xRequestID)); // header parameter
            localVarRequestOptions.Data = psuAuthBody;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/v1/psu/register", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Registration", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one Input is the old cookie, response is empty with a new cookie
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <returns></returns>
        public void RenewalAuthorizationSessionKey(Guid xRequestID, Guid authorizationId)
        {
            RenewalAuthorizationSessionKeyWithHttpInfo(xRequestID, authorizationId);
        }

        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one Input is the old cookie, response is empty with a new cookie
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Org.OpenAPITools.Client.ApiResponse<Object> RenewalAuthorizationSessionKeyWithHttpInfo(Guid xRequestID, Guid authorizationId)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("authorization-id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(authorizationId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("X-Request-ID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xRequestID)); // header parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get<Object>("/v1/psu/ais/{authorization-id}/renewal-authorization-session-key", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RenewalAuthorizationSessionKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one Input is the old cookie, response is empty with a new cookie
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RenewalAuthorizationSessionKeyAsync(Guid xRequestID, Guid authorizationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RenewalAuthorizationSessionKeyWithHttpInfoAsync(xRequestID, authorizationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// the AuthorizationSessionKey is replaces with a new one Input is the old cookie, response is empty with a new cookie
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xRequestID">Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. </param>
        /// <param name="authorizationId">Authorization session ID to approve</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Object>> RenewalAuthorizationSessionKeyWithHttpInfoAsync(Guid xRequestID, Guid authorizationId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("authorization-id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(authorizationId)); // path parameter
            localVarRequestOptions.HeaderParameters.Add("X-Request-ID", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xRequestID)); // header parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Object>("/v1/psu/ais/{authorization-id}/renewal-authorization-session-key", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RenewalAuthorizationSessionKey", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
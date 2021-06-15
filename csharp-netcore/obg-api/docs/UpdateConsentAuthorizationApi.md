# Org.OpenAPITools.Api.UpdateConsentAuthorizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DenyUsingPOST**](UpdateConsentAuthorizationApi.md#denyusingpost) | **POST** /v1/consent/{auth-id}/deny | Consent authorization is denied - consent is blocked. Closes this session and redirects the PSU back to the FinTechApi or close the application window. 
[**EmbeddedUsingPOST**](UpdateConsentAuthorizationApi.md#embeddedusingpost) | **POST** /v1/consent/{auth-id}/embedded | Generic challenge response end point for updating consent session with PSU authentication data while requesting remaining challenges for the ongoing authorization process. 
[**ToAspspGrantUsingPOST**](UpdateConsentAuthorizationApi.md#toaspspgrantusingpost) | **POST** /v1/consent/{auth-id}/toAspsp/grant | Provides the ConsentAuthorisationApi with the opportunity to redirect the PSU to the ASPSP. 


<a name="denyusingpost"></a>
# **DenyUsingPOST**
> void DenyUsingPOST (string authId, Guid xRequestID, string X_XSRF_TOKEN, DenyRequest denyRequest)

Consent authorization is denied - consent is blocked. Closes this session and redirects the PSU back to the FinTechApi or close the application window. 

Closes this session and redirects the PSU back to the FinTechApi or close the application window. In any case, the session of the user will be closed and cookies will be deleted with the response to this request. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DenyUsingPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UpdateConsentAuthorizationApi(config);
            var authId = abc123;  // string | Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process. 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var X_XSRF_TOKEN = abc123.faadsf93nlas32wx;  // string | XSRF parameter used to validate a SessionCookie. The token matches the auth-id included in the requestpath and prefixing the cookie. 
            var denyRequest = new DenyRequest(); // DenyRequest | 

            try
            {
                // Consent authorization is denied - consent is blocked. Closes this session and redirects the PSU back to the FinTechApi or close the application window. 
                apiInstance.DenyUsingPOST(authId, xRequestID, X_XSRF_TOKEN, denyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateConsentAuthorizationApi.DenyUsingPOST: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authId** | **string**| Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process.  | 
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **X_XSRF_TOKEN** | **string**| XSRF parameter used to validate a SessionCookie. The token matches the auth-id included in the requestpath and prefixing the cookie.  | 
 **denyRequest** | [**DenyRequest**](DenyRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirects UserAgent back to the FinTechAPI.  |  * Location -  <br>  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |
| **401** | Access credentials absent or invalid. This happens when * Provided credential for login not matching. * Endpoin expect a session cookie but none is present. * Session cookie is present but associated stateString does not match.  As a consequence, we reset existing FinTechLoginSessionState if any.  Nevertheless we do not reset RedirectSessionCookie.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="embeddedusingpost"></a>
# **EmbeddedUsingPOST**
> ConsentAuth EmbeddedUsingPOST (string authId, Guid xRequestID, string X_XSRF_TOKEN, string redirectCode = null, PsuAuthRequest psuAuthRequest = null)

Generic challenge response end point for updating consent session with PSU authentication data while requesting remaining challenges for the ongoing authorization process. 

Update consent session with PSU auth data whereby requesting remaining challenges for the ongoing authorization process. Returns 202 if one should proceed to some other link. Link to follow is in 'Location' header. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EmbeddedUsingPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UpdateConsentAuthorizationApi(config);
            var authId = abc123;  // string | Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process. 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var X_XSRF_TOKEN = abc123.faadsf93nlas32wx;  // string | XSRF parameter used to validate a SessionCookie. The token matches the auth-id included in the requestpath and prefixing the cookie. 
            var redirectCode = faadsf93nlas32wx;  // string | Code used to retrieve a redirect session. This is generaly transported as a query parameter (optional) 
            var psuAuthRequest = new PsuAuthRequest(); // PsuAuthRequest |  (optional) 

            try
            {
                // Generic challenge response end point for updating consent session with PSU authentication data while requesting remaining challenges for the ongoing authorization process. 
                ConsentAuth result = apiInstance.EmbeddedUsingPOST(authId, xRequestID, X_XSRF_TOKEN, redirectCode, psuAuthRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateConsentAuthorizationApi.EmbeddedUsingPOST: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authId** | **string**| Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process.  | 
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **X_XSRF_TOKEN** | **string**| XSRF parameter used to validate a SessionCookie. The token matches the auth-id included in the requestpath and prefixing the cookie.  | 
 **redirectCode** | **string**| Code used to retrieve a redirect session. This is generaly transported as a query parameter | [optional] 
 **psuAuthRequest** | [**PsuAuthRequest**](PsuAuthRequest.md)|  | [optional] 

### Return type

[**ConsentAuth**](ConsentAuth.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All responses sent by the ConsentAuthorisationApi to the UI are derived from the AuthorizeResponse object.  This object presents : * The consentAuthState as a XSRF parameter used to reauthenticate the ConsentAuthSessionCookie. It can also be used if required to encrypt information stored in the corresponding ConsentAuthSessionCookie. * The AuthorizeResponse object info also contains information used to display a qualified page to the PSU  prio to eventually redirecting the PSU to the target ASPSP. * Any session, account or payment information needed to manage the authorization process is stored in both AuthorizeResponse and encrypted in the ConsentAuthSessionCookie. * The ConsentAuthSessionCookie is secure and httpOnly.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  * X-XSRF-TOKEN -  <br>  |
| **202** | All responses sent by the ConsentAuthorisationApi to the UI are derived from the AuthorizeResponse object.  This object presents : * The consentAuthState as a XSRF parameter used to reauthenticate the ConsentAuthSessionCookie. It can also be used if required to encrypt information stored in the corresponding ConsentAuthSessionCookie. * The AuthorizeResponse object info also contains information used to display a qualified page to the PSU  prio to eventually redirecting the PSU to the target ASPSP. * Any session, account or payment information needed to manage the authorization process is stored in both AuthorizeResponse and encrypted in the ConsentAuthSessionCookie. * The ConsentAuthSessionCookie is secure and httpOnly.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  * X-XSRF-TOKEN -  <br>  |
| **401** | Access credentials absent or invalid. This happens when * Provided credential for login not matching. * Endpoin expect a session cookie but none is present. * Session cookie is present but associated stateString does not match.  As a consequence, we reset existing FinTechLoginSessionState if any.  Nevertheless we do not reset RedirectSessionCookie.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toaspspgrantusingpost"></a>
# **ToAspspGrantUsingPOST**
> void ToAspspGrantUsingPOST (string authId, Guid xRequestID, string X_XSRF_TOKEN, AuthorizeRequest authorizeRequest)

Provides the ConsentAuthorisationApi with the opportunity to redirect the PSU to the ASPSP. 

Provides the ConsentAuthorisationApi with the opportunity to redirect the PSU to the ASPSP. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ToAspspGrantUsingPOSTExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UpdateConsentAuthorizationApi(config);
            var authId = abc123;  // string | Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process. 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var X_XSRF_TOKEN = abc123.faadsf93nlas32wx;  // string | XSRF parameter used to validate a SessionCookie. The token matches the auth-id included in the requestpath and prefixing the cookie. 
            var authorizeRequest = new AuthorizeRequest(); // AuthorizeRequest | 

            try
            {
                // Provides the ConsentAuthorisationApi with the opportunity to redirect the PSU to the ASPSP. 
                apiInstance.ToAspspGrantUsingPOST(authId, xRequestID, X_XSRF_TOKEN, authorizeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdateConsentAuthorizationApi.ToAspspGrantUsingPOST: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authId** | **string**| Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process.  | 
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **X_XSRF_TOKEN** | **string**| XSRF parameter used to validate a SessionCookie. The token matches the auth-id included in the requestpath and prefixing the cookie.  | 
 **authorizeRequest** | [**AuthorizeRequest**](AuthorizeRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **302** | Redirects UserAgent to the ASPSP online banking interface.  ##### Setting a RedirectCookie The redirect response to the PsuUserAgent must set a RedirectCookie. * This cookie contains information associated with this specific redirect session. * The XSRF Token used to validate this the RedirectCookie is path parameter redirectState * This RedirectCookie must have a life time equal to the expected duration of the corresponding redirect session at the target ASPSP OnlineBankingApi. * Prior to redirecting any associated SessionCookie (sharing the same auth-id) will be deleted.  |  * Location -  <br>  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |
| **401** | Access credentials absent or invalid. This happens when * Provided credential for login not matching. * Endpoin expect a session cookie but none is present. * Session cookie is present but associated stateString does not match.  As a consequence, we reset existing FinTechLoginSessionState if any.  Nevertheless we do not reset RedirectSessionCookie.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


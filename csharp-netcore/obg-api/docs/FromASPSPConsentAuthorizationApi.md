# Org.OpenAPITools.Api.FromASPSPConsentAuthorizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FromAspspNokUsingGET**](FromASPSPConsentAuthorizationApi.md#fromaspspnokusingget) | **GET** /v1/consent/{auth-id}/fromAspsp/{redirectState}/nok/{fromAspspRedirectCode} | Redirecting back from ASPSP to TPP after a failed consent authorization.
[**FromAspspOkUsingGET**](FromASPSPConsentAuthorizationApi.md#fromaspspokusingget) | **GET** /v1/consent/{auth-id}/fromAspsp/{redirectState}/ok/{fromAspspRedirectCode} | Redirecting back from ASPSP to ConsentAuthorisationApi after a successful consent authorization.


<a name="fromaspspnokusingget"></a>
# **FromAspspNokUsingGET**
> ConsentAuth FromAspspNokUsingGET (string authId, string redirectState, string fromAspspRedirectCode)

Redirecting back from ASPSP to TPP after a failed consent authorization.

Redirecting back from ASPSP to TPP after a failed consent authorization. In any case, the corresponding redirect session of the user will be closed and cookies will be deleted with the response to this request. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FromAspspNokUsingGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FromASPSPConsentAuthorizationApi(config);
            var authId = abc123;  // string | Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process. 
            var redirectState = faadsf93nlas32wx;  // string | XSRF parameter used to validate an RedirectCookie. This is generaly transported as a path parameter. 
            var fromAspspRedirectCode = faadsf93nlas32wx;  // string | Code used to retrieve a redirect session. This is generaly transported as a path parameter due to some banks limitiations (ING ASPSP) instead of being transported as query parameter

            try
            {
                // Redirecting back from ASPSP to TPP after a failed consent authorization.
                ConsentAuth result = apiInstance.FromAspspNokUsingGET(authId, redirectState, fromAspspRedirectCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FromASPSPConsentAuthorizationApi.FromAspspNokUsingGET: " + e.Message );
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
 **redirectState** | **string**| XSRF parameter used to validate an RedirectCookie. This is generaly transported as a path parameter.  | 
 **fromAspspRedirectCode** | **string**| Code used to retrieve a redirect session. This is generaly transported as a path parameter due to some banks limitiations (ING ASPSP) instead of being transported as query parameter | 

### Return type

[**ConsentAuth**](ConsentAuth.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All responses sent by the ConsentAuthorisationApi to the UI are derived from the AuthorizeResponse object.  This object presents : * The consentAuthState as a XSRF parameter used to reauthenticate the ConsentAuthSessionCookie. It can also be used if required to encrypt information stored in the corresponding ConsentAuthSessionCookie. * The AuthorizeResponse object info also contains information used to display a qualified page to the PSU  prio to eventually redirecting the PSU to the target ASPSP. * Any session, account or payment information needed to manage the authorization process is stored in both AuthorizeResponse and encrypted in the ConsentAuthSessionCookie. * The ConsentAuthSessionCookie is secure and httpOnly.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  * X-XSRF-TOKEN -  <br>  |
| **401** | Access credentials absent or invalid. This happens when * Provided credential for login not matching. * Endpoin expect a session cookie but none is present. * Session cookie is present but associated stateString does not match.  As a consequence, we reset existing FinTechLoginSessionState if any.  Nevertheless we do not reset RedirectSessionCookie.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fromaspspokusingget"></a>
# **FromAspspOkUsingGET**
> ConsentAuth FromAspspOkUsingGET (string authId, string redirectState, string fromAspspRedirectCode, string code = null)

Redirecting back from ASPSP to ConsentAuthorisationApi after a successful consent authorization.

Redirecting back from ASPSP to ConsentAuthorisationApi after a successful consent authorization. In any case, the corresponding redirect session of the user will be closed and cookies will be deleted with the response to this request.  ##### Desiging the BackRedirectURL (R<sub>6</sub>) The BackRedirectURL (OkUrl, NokUrl, etc... depending of ASPSP API) is the URL used by the ASPSP to send the PsuUserAgent back to the ConsentAuthorisationApi. Event though the structure of this URL might be constrained by the nature of the ASPSP OpenBankingApi, the BackRedirectURL must contains atleast : * A redirect-id (as a path parameter) used to isolate many redirect processes form each order. * A consentAuthState (as a path or query parameter) used to protect the TppConsentSessionCookie as a XSRF parameter. * The consentAuthState might if necessary be used to encrypt the attached ConsentAuthSessionCookie.  ##### Back-Redirecting PSU to the FinTechApi (4<sub>b</sub>) Prior to redirecting the PSU back to the FinTechApi, consent information will be stored by the ConsentAuthorisationApi in a RedirectSession as well. * The one time resulting redirectCode will be attached as a query parameter to the location URL leading back to the FinTechApi. * After verifying the FinTechRedirectSessionCookie (4<sub>b</sub>), the FinTechApi must forward this redirectCode to the token endpoint of the TppBankingAPi (4<sub>c</sub>).  * The TppBankingApi will then retrieve the RedirectSession using the redirectCode and proceed forward with the authorization process. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class FromAspspOkUsingGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FromASPSPConsentAuthorizationApi(config);
            var authId = abc123;  // string | Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process. 
            var redirectState = faadsf93nlas32wx;  // string | XSRF parameter used to validate an RedirectCookie. This is generaly transported as a path parameter. 
            var fromAspspRedirectCode = faadsf93nlas32wx;  // string | Code used to retrieve a redirect session. This is generaly transported as a path parameter due to some banks limitiations (ING ASPSP) instead of being transported as query parameter
            var code = faadsf93nlas32wx;  // string | Oauth2 code to exchange for token. (optional) 

            try
            {
                // Redirecting back from ASPSP to ConsentAuthorisationApi after a successful consent authorization.
                ConsentAuth result = apiInstance.FromAspspOkUsingGET(authId, redirectState, fromAspspRedirectCode, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FromASPSPConsentAuthorizationApi.FromAspspOkUsingGET: " + e.Message );
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
 **redirectState** | **string**| XSRF parameter used to validate an RedirectCookie. This is generaly transported as a path parameter.  | 
 **fromAspspRedirectCode** | **string**| Code used to retrieve a redirect session. This is generaly transported as a path parameter due to some banks limitiations (ING ASPSP) instead of being transported as query parameter | 
 **code** | **string**| Oauth2 code to exchange for token. | [optional] 

### Return type

[**ConsentAuth**](ConsentAuth.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All responses sent by the ConsentAuthorisationApi to the UI are derived from the AuthorizeResponse object.  This object presents : * The consentAuthState as a XSRF parameter used to reauthenticate the ConsentAuthSessionCookie. It can also be used if required to encrypt information stored in the corresponding ConsentAuthSessionCookie. * The AuthorizeResponse object info also contains information used to display a qualified page to the PSU  prio to eventually redirecting the PSU to the target ASPSP. * Any session, account or payment information needed to manage the authorization process is stored in both AuthorizeResponse and encrypted in the ConsentAuthSessionCookie. * The ConsentAuthSessionCookie is secure and httpOnly.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  * X-XSRF-TOKEN -  <br>  |
| **401** | Access credentials absent or invalid. This happens when * Provided credential for login not matching. * Endpoin expect a session cookie but none is present. * Session cookie is present but associated stateString does not match.  As a consequence, we reset existing FinTechLoginSessionState if any.  Nevertheless we do not reset RedirectSessionCookie.  |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


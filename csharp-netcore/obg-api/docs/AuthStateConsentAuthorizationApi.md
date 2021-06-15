# Org.OpenAPITools.Api.AuthStateConsentAuthorizationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthUsingGET**](AuthStateConsentAuthorizationApi.md#authusingget) | **GET** /v1/consent/{auth-id} | Redirect entry point for initiating a consent authorization process. 


<a name="authusingget"></a>
# **AuthUsingGET**
> ConsentAuth AuthUsingGET (string authId, string redirectCode = null)

Redirect entry point for initiating a consent authorization process. 

This is the <b>entry point</b> for processing a consent redirected by the TppBankingApi to this ConsentAuthorisationApi.  At this entry point, the ConsentAuthorisationApi will use the redirectCode to retrieve the RedirectSession from the TppServer. An analysis of the RedirectSession will help decide if the ConsentAuthorisationApi will proceed with an embedded approach (E<sub>1</sub>) or a redirect approach (R<sub>1</sub>). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AuthUsingGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthStateConsentAuthorizationApi(config);
            var authId = abc123;  // string | Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process. 
            var redirectCode = faadsf93nlas32wx;  // string | Code used to retrieve a redirect session. This is generaly transported as a query parameter. (optional) 

            try
            {
                // Redirect entry point for initiating a consent authorization process. 
                ConsentAuth result = apiInstance.AuthUsingGET(authId, redirectCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthStateConsentAuthorizationApi.AuthUsingGET: " + e.Message );
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
 **redirectCode** | **string**| Code used to retrieve a redirect session. This is generaly transported as a query parameter. | [optional] 

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


# Org.OpenAPITools.Api.PsuAuthenticationAndConsentApprovalApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoginForAnonymousApproval**](PsuAuthenticationAndConsentApprovalApi.md#loginforanonymousapproval) | **POST** /v1/psu/{authorization-id}/for-approval/anonymous | Login user to open-banking to perform payment (anonymous to OPBA)
[**LoginForApproval**](PsuAuthenticationAndConsentApprovalApi.md#loginforapproval) | **POST** /v1/psu/{authorization-id}/for-approval/login | Login user to open-banking


<a name="loginforanonymousapproval"></a>
# **LoginForAnonymousApproval**
> LoginResponse LoginForAnonymousApproval (Guid xRequestID, Guid authorizationId, string redirectCode)

Login user to open-banking to perform payment (anonymous to OPBA)

TBD

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginForAnonymousApprovalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PsuAuthenticationAndConsentApprovalApi(config);
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var authorizationId = new Guid(); // Guid | Authorization session ID to approve
            var redirectCode = 12345;  // string | Redirect code that acts as a password protecting FinTech requested consent specification

            try
            {
                // Login user to open-banking to perform payment (anonymous to OPBA)
                LoginResponse result = apiInstance.LoginForAnonymousApproval(xRequestID, authorizationId, redirectCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PsuAuthenticationAndConsentApprovalApi.LoginForAnonymousApproval: " + e.Message );
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
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **authorizationId** | [**Guid**](Guid.md)| Authorization session ID to approve | 
 **redirectCode** | **string**| Redirect code that acts as a password protecting FinTech requested consent specification | 

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | User logged in |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |
| **401** | Bad username or password  |  * X-Request-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loginforapproval"></a>
# **LoginForApproval**
> LoginResponse LoginForApproval (Guid xRequestID, Guid authorizationId, string redirectCode, PsuAuthBody psuAuthBody)

Login user to open-banking

TBD

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginForApprovalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PsuAuthenticationAndConsentApprovalApi(config);
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var authorizationId = new Guid(); // Guid | Authorization session ID to approve
            var redirectCode = 12345;  // string | Redirect code that acts as a password protecting FinTech requested consent specification
            var psuAuthBody = new PsuAuthBody(); // PsuAuthBody | User credentials object

            try
            {
                // Login user to open-banking
                LoginResponse result = apiInstance.LoginForApproval(xRequestID, authorizationId, redirectCode, psuAuthBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PsuAuthenticationAndConsentApprovalApi.LoginForApproval: " + e.Message );
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
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **authorizationId** | [**Guid**](Guid.md)| Authorization session ID to approve | 
 **redirectCode** | **string**| Redirect code that acts as a password protecting FinTech requested consent specification | 
 **psuAuthBody** | [**PsuAuthBody**](PsuAuthBody.md)| User credentials object | 

### Return type

[**LoginResponse**](LoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | User logged in |  * X-Request-ID -  <br>  * Set-Cookie -  <br>  |
| **401** | Bad username or password  |  * X-Request-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


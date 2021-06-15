# Org.OpenAPITools.Api.PsuAuthenticationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Login**](PsuAuthenticationApi.md#login) | **POST** /v1/psu/login | Login user to open-banking
[**Registration**](PsuAuthenticationApi.md#registration) | **POST** /v1/psu/register | registration user in open-banking db
[**RenewalAuthorizationSessionKey**](PsuAuthenticationApi.md#renewalauthorizationsessionkey) | **GET** /v1/psu/ais/{authorization-id}/renewal-authorization-session-key | the AuthorizationSessionKey is replaces with a new one


<a name="login"></a>
# **Login**
> LoginResponse Login (Guid xRequestID, PsuAuthBody psuAuthBody)

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
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PsuAuthenticationApi(config);
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var psuAuthBody = new PsuAuthBody(); // PsuAuthBody | User credentials object

            try
            {
                // Login user to open-banking
                LoginResponse result = apiInstance.Login(xRequestID, psuAuthBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PsuAuthenticationApi.Login: " + e.Message );
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

<a name="registration"></a>
# **Registration**
> void Registration (Guid xRequestID, PsuAuthBody psuAuthBody)

registration user in open-banking db

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
    public class RegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PsuAuthenticationApi(config);
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var psuAuthBody = new PsuAuthBody(); // PsuAuthBody | User credentials object

            try
            {
                // registration user in open-banking db
                apiInstance.Registration(xRequestID, psuAuthBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PsuAuthenticationApi.Registration: " + e.Message );
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
 **psuAuthBody** | [**PsuAuthBody**](PsuAuthBody.md)| User credentials object | 

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
| **201** | User created sucessfully |  * Location -  <br>  * X-Request-ID -  <br>  |
| **400** | Wrong registration parameters or user exist  |  * X-Request-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renewalauthorizationsessionkey"></a>
# **RenewalAuthorizationSessionKey**
> void RenewalAuthorizationSessionKey (Guid xRequestID, Guid authorizationId)

the AuthorizationSessionKey is replaces with a new one

Input is the old cookie, response is empty with a new cookie

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RenewalAuthorizationSessionKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PsuAuthenticationApi(config);
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var authorizationId = new Guid(); // Guid | Authorization session ID to approve

            try
            {
                // the AuthorizationSessionKey is replaces with a new one
                apiInstance.RenewalAuthorizationSessionKey(xRequestID, authorizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PsuAuthenticationApi.RenewalAuthorizationSessionKey: " + e.Message );
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

### Return type

void (empty response body)

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


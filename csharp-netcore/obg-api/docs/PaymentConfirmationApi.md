# Org.OpenAPITools.Api.PaymentConfirmationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmPayment**](PaymentConfirmationApi.md#confirmpayment) | **POST** /v1/banking/payments/{auth-id}/confirm | Issues new PSU Consent Session Token.


<a name="confirmpayment"></a>
# **ConfirmPayment**
> PsuPaymentSessionResponse ConfirmPayment (string authId, Guid xRequestID, string serviceSessionPassword, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null)

Issues new PSU Consent Session Token.

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
    public class ConfirmPaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PaymentConfirmationApi(config);
            var authId = abc123;  // string | Used to distinguish between different consent authorization processes started by the same PSU. Also included in the corresponding cookie path to limit visibility of the consent cookie to the corresponding consent process. 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var serviceSessionPassword = qwerty;  // string | Password to encrypt users' context 
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 

            try
            {
                // Issues new PSU Consent Session Token.
                PsuPaymentSessionResponse result = apiInstance.ConfirmPayment(authId, xRequestID, serviceSessionPassword, xTimestampUTC, xRequestSignature, fintechID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentConfirmationApi.ConfirmPayment: " + e.Message );
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
 **serviceSessionPassword** | **string**| Password to encrypt users&#39; context  | 
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 

### Return type

[**PsuPaymentSessionResponse**](PsuPaymentSessionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Response containing the service profile of a bank. |  * X-Request-ID -  <br>  |
| **401** | Unauthorised. Access token absent or invalid.  |  * X-Request-ID -  <br>  |
| **404** | Resource not found or path parameter is wrong.  |  * X-Request-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Org.OpenAPITools.Api.TPPBankingAPIPaymentStatusPISApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentInformation**](TPPBankingAPIPaymentStatusPISApi.md#getpaymentinformation) | **GET** /v1/banking/pis/payments/{payment-product} | Get payment information
[**GetPaymentStatus**](TPPBankingAPIPaymentStatusPISApi.md#getpaymentstatus) | **GET** /v1/banking/pis/payments/{payment-product}/status | Payment initiation status request


<a name="getpaymentinformation"></a>
# **GetPaymentInformation**
> PaymentInformationResponse GetPaymentInformation (string serviceSessionPassword, string fintechUserID, Guid xRequestID, string paymentProduct, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null, string bankID = null, Guid? serviceSessionID = null)

Get payment information

Returns the content of a payment object

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPaymentInformationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: BearerAuthOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TPPBankingAPIPaymentStatusPISApi(config);
            var serviceSessionPassword = qwerty;  // string | Password to encrypt users' context 
            var fintechUserID = 1234-0XGJK;  // string | An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user. 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var paymentProduct = paymentProduct_example;  // string | 
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 
            var bankID = 1234-0XGJK;  // string | A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  (optional) 
            var serviceSessionID = new Guid?(); // Guid? | Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  (optional) 

            try
            {
                // Get payment information
                PaymentInformationResponse result = apiInstance.GetPaymentInformation(serviceSessionPassword, fintechUserID, xRequestID, paymentProduct, xTimestampUTC, xRequestSignature, fintechID, bankID, serviceSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TPPBankingAPIPaymentStatusPISApi.GetPaymentInformation: " + e.Message );
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
 **serviceSessionPassword** | **string**| Password to encrypt users&#39; context  | 
 **fintechUserID** | **string**| An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user.  | 
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **paymentProduct** | **string**|  | 
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 
 **bankID** | **string**| A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  | [optional] 
 **serviceSessionID** | [**Guid?**](Guid?.md)| Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  | [optional] 

### Return type

[**PaymentInformationResponse**](PaymentInformationResponse.md)

### Authorization

[BearerAuthOAuth](../README.md#BearerAuthOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Request-ID -  <br>  * Service-Session-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentstatus"></a>
# **GetPaymentStatus**
> PaymentStatusResponse GetPaymentStatus (string serviceSessionPassword, string fintechUserID, Guid xRequestID, string paymentProduct, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null, string bankID = null, Guid? serviceSessionID = null)

Payment initiation status request

Check the transaction status of a payment initiation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPaymentStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: BearerAuthOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TPPBankingAPIPaymentStatusPISApi(config);
            var serviceSessionPassword = qwerty;  // string | Password to encrypt users' context 
            var fintechUserID = 1234-0XGJK;  // string | An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user. 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var paymentProduct = paymentProduct_example;  // string | 
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 
            var bankID = 1234-0XGJK;  // string | A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  (optional) 
            var serviceSessionID = new Guid?(); // Guid? | Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  (optional) 

            try
            {
                // Payment initiation status request
                PaymentStatusResponse result = apiInstance.GetPaymentStatus(serviceSessionPassword, fintechUserID, xRequestID, paymentProduct, xTimestampUTC, xRequestSignature, fintechID, bankID, serviceSessionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TPPBankingAPIPaymentStatusPISApi.GetPaymentStatus: " + e.Message );
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
 **serviceSessionPassword** | **string**| Password to encrypt users&#39; context  | 
 **fintechUserID** | **string**| An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user.  | 
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **paymentProduct** | **string**|  | 
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 
 **bankID** | **string**| A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  | [optional] 
 **serviceSessionID** | [**Guid?**](Guid?.md)| Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  | [optional] 

### Return type

[**PaymentStatusResponse**](PaymentStatusResponse.md)

### Authorization

[BearerAuthOAuth](../README.md#BearerAuthOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Request-ID -  <br>  * Service-Session-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


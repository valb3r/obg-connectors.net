# Org.OpenAPITools.Api.TPPBankingAPISinglePaymentPISApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InitiatePayment**](TPPBankingAPISinglePaymentPISApi.md#initiatepayment) | **POST** /v1/banking/pis/payments/{payment-product} | Payment initiation request


<a name="initiatepayment"></a>
# **InitiatePayment**
> PaymentInitiationResponse InitiatePayment (string serviceSessionPassword, string fintechUserID, string fintechRedirectURLOK, string fintechRedirectURLNOK, Guid xRequestID, string paymentProduct, PaymentInitiation body, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null, string bankID = null, bool? xPisPsuAuthenticationRequired = null)

Payment initiation request

This method is used to initiate a payment at the ASPSP.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InitiatePaymentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: BearerAuthOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TPPBankingAPISinglePaymentPISApi(config);
            var serviceSessionPassword = qwerty;  // string | Password to encrypt users' context 
            var fintechUserID = 1234-0XGJK;  // string | An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user. 
            var fintechRedirectURLOK = https://example.com/myservice/sf3-3r33-3535?authResult=success;  // string | 
            var fintechRedirectURLNOK = https://example.com/myservice/sf3-3r33-3535/failure;  // string | 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var paymentProduct = paymentProduct_example;  // string | 
            var body = new PaymentInitiation(); // PaymentInitiation | 
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 
            var bankID = 1234-0XGJK;  // string | A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  (optional) 
            var xPisPsuAuthenticationRequired = true;  // bool? | If false, login form to OPBA will not be displayed as there might be nothing to share for payments, so that authentication is not necessary. If absent or true - login form for payments will be displayed.  (optional)  (default to true)

            try
            {
                // Payment initiation request
                PaymentInitiationResponse result = apiInstance.InitiatePayment(serviceSessionPassword, fintechUserID, fintechRedirectURLOK, fintechRedirectURLNOK, xRequestID, paymentProduct, body, xTimestampUTC, xRequestSignature, fintechID, bankID, xPisPsuAuthenticationRequired);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TPPBankingAPISinglePaymentPISApi.InitiatePayment: " + e.Message );
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
 **fintechRedirectURLOK** | **string**|  | 
 **fintechRedirectURLNOK** | **string**|  | 
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **paymentProduct** | **string**|  | 
 **body** | [**PaymentInitiation**](PaymentInitiation.md)|  | 
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 
 **bankID** | **string**| A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  | [optional] 
 **xPisPsuAuthenticationRequired** | **bool?**| If false, login form to OPBA will not be displayed as there might be nothing to share for payments, so that authentication is not necessary. If absent or true - login form for payments will be displayed.  | [optional] [default to true]

### Return type

[**PaymentInitiationResponse**](PaymentInitiationResponse.md)

### Authorization

[BearerAuthOAuth](../README.md#BearerAuthOAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | ACCEPTED |  * X-Request-ID -  <br>  * Service-Session-ID -  <br>  * Authorization-Session-ID -  <br>  * Redirect-Code -  <br>  * Location -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


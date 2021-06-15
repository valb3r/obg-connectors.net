# Org.OpenAPITools.Api.TppBankSearchApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BankProfileGET**](TppBankSearchApi.md#bankprofileget) | **GET** /v1/banking/search/bank-profile | Request the profile of the bank identified with id (bankId).
[**BankSearchGET**](TppBankSearchApi.md#banksearchget) | **GET** /v1/banking/search/bank-search | Issues an incremental bank search request to the TppBankSearchApi.


<a name="bankprofileget"></a>
# **BankProfileGET**
> BankProfileResponse BankProfileGET (Guid xRequestID, string bankId, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null)

Request the profile of the bank identified with id (bankId).

Request the profile of the bank identified with id (bankId).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankProfileGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TppBankSearchApi(config);
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var bankId = bankId_example;  // string | Identifier of the bank to be loaded.
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 

            try
            {
                // Request the profile of the bank identified with id (bankId).
                BankProfileResponse result = apiInstance.BankProfileGET(xRequestID, bankId, xTimestampUTC, xRequestSignature, fintechID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TppBankSearchApi.BankProfileGET: " + e.Message );
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
 **bankId** | **string**| Identifier of the bank to be loaded. | 
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 

### Return type

[**BankProfileResponse**](BankProfileResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="banksearchget"></a>
# **BankSearchGET**
> BankSearchResponse BankSearchGET (Guid xRequestID, string keyword, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null, int? start = null, int? max = null)

Issues an incremental bank search request to the TppBankSearchApi.

Issues an incremental bank search request to the TppBankSearchApi.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BankSearchGETExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TppBankSearchApi(config);
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var keyword = keyword_example;  // string | The bank search input string
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 
            var start = 56;  // int? | The index of the first result (optional) 
            var max = 56;  // int? | The max number of entries to return with the response. (optional) 

            try
            {
                // Issues an incremental bank search request to the TppBankSearchApi.
                BankSearchResponse result = apiInstance.BankSearchGET(xRequestID, keyword, xTimestampUTC, xRequestSignature, fintechID, start, max);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TppBankSearchApi.BankSearchGET: " + e.Message );
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
 **keyword** | **string**| The bank search input string | 
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 
 **start** | **int?**| The index of the first result | [optional] 
 **max** | **int?**| The max number of entries to return with the response. | [optional] 

### Return type

[**BankSearchResponse**](BankSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of a bank search. |  * X-Request-ID -  <br>  |
| **401** | Unauthorised. Access token absent or invalid.  |  * X-Request-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


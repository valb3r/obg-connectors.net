# Org.OpenAPITools.Api.TPPBankingAPIAccountInformationServiceAISApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccounts**](TPPBankingAPIAccountInformationServiceAISApi.md#getaccounts) | **GET** /v1/banking/ais/accounts | Provides list of available accounts
[**GetTransactions**](TPPBankingAPIAccountInformationServiceAISApi.md#gettransactions) | **GET** /v1/banking/ais/accounts/{account-id}/transactions | Provides list of transactions by given account
[**GetTransactionsWithoutAccountId**](TPPBankingAPIAccountInformationServiceAISApi.md#gettransactionswithoutaccountid) | **GET** /v1/banking/ais/transactions | Provides consent for accounts and transactions


<a name="getaccounts"></a>
# **GetAccounts**
> AccountList GetAccounts (string serviceSessionPassword, string fintechUserID, string fintechRedirectURLOK, string fintechRedirectURLNOK, Guid xRequestID, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null, string bankID = null, Guid? serviceSessionID = null, bool? withBalance = null, bool? online = null)

Provides list of available accounts

Read the identifiers of the available payment accounts. It is assumed that a consent of the PSU to this access is already given and stored on the TPP system. The addressed list of accounts depends then on the PSU and Consent information, stored respectively the OAuth2 access token. Returns all identifiers of the accounts, to which an account access has been granted to by the PSU. In addition, relevant information about the accounts and hyperlinks to corresponding account information resources are provided if a related consent has been already granted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: BearerAuthOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TPPBankingAPIAccountInformationServiceAISApi(config);
            var serviceSessionPassword = qwerty;  // string | Password to encrypt users' context 
            var fintechUserID = 1234-0XGJK;  // string | An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user. 
            var fintechRedirectURLOK = https://example.com/myservice/sf3-3r33-3535?authResult=success;  // string | 
            var fintechRedirectURLNOK = https://example.com/myservice/sf3-3r33-3535/failure;  // string | 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 
            var bankID = 1234-0XGJK;  // string | A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  (optional) 
            var serviceSessionID = new Guid?(); // Guid? | Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  (optional) 
            var withBalance = true;  // bool? | For list of accounts this query param defines to not only look for the accounts, but for the balances too.  (optional) 
            var online = false;  // bool? | Makes possible to request actual data and update cache if cache is used by protocol implementation.  (optional)  (default to true)

            try
            {
                // Provides list of available accounts
                AccountList result = apiInstance.GetAccounts(serviceSessionPassword, fintechUserID, fintechRedirectURLOK, fintechRedirectURLNOK, xRequestID, xTimestampUTC, xRequestSignature, fintechID, bankID, serviceSessionID, withBalance, online);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TPPBankingAPIAccountInformationServiceAISApi.GetAccounts: " + e.Message );
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
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 
 **bankID** | **string**| A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  | [optional] 
 **serviceSessionID** | [**Guid?**](Guid?.md)| Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  | [optional] 
 **withBalance** | **bool?**| For list of accounts this query param defines to not only look for the accounts, but for the balances too.  | [optional] 
 **online** | **bool?**| Makes possible to request actual data and update cache if cache is used by protocol implementation.  | [optional] [default to true]

### Return type

[**AccountList**](AccountList.md)

### Authorization

[BearerAuthOAuth](../README.md#BearerAuthOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Request-ID -  <br>  |
| **202** | User authorisation session mandated. Agent shall redirect the user to the Authorisation URI provided in response using &#39;Location&#39; header. This is soft redirection, so that FinTech should inform user about redirection.  |  * Location -  <br>  * X-Request-ID -  <br>  |
| **401** | Unauthorised. Access token absent or invalid.  |  * X-Request-ID -  <br>  |
| **410** | The headerfield tells what exactly was wrong.  |  * X-ERROR-CODE -  <br>  |
| **429** | The headerfield tells what exactly was wrong.  |  * X-ERROR-CODE -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> TransactionsResponse GetTransactions (string accountId, string serviceSessionPassword, string fintechUserID, string fintechRedirectURLOK, string fintechRedirectURLNOK, Guid xRequestID, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null, string bankID = null, Guid? serviceSessionID = null, DateTime? dateFrom = null, DateTime? dateTo = null, string entryReferenceFrom = null, string bookingStatus = null, bool? deltaList = null, bool? online = null)

Provides list of transactions by given account

returns list of transactions for specified account resource ID in case Service-Session-ID is provided and saved consent on tpp by it found. Otherwise initiates creation of new consent

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: BearerAuthOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TPPBankingAPIAccountInformationServiceAISApi(config);
            var accountId = accountId_example;  // string | 
            var serviceSessionPassword = qwerty;  // string | Password to encrypt users' context 
            var fintechUserID = 1234-0XGJK;  // string | An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user. 
            var fintechRedirectURLOK = https://example.com/myservice/sf3-3r33-3535?authResult=success;  // string | 
            var fintechRedirectURLNOK = https://example.com/myservice/sf3-3r33-3535/failure;  // string | 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 
            var bankID = 1234-0XGJK;  // string | A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  (optional) 
            var serviceSessionID = new Guid?(); // Guid? | Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  (optional) 
            var dateFrom = 2013-10-20;  // DateTime? | Conditional: Starting date (inclusive the date dateFrom) of the transaction list, mandated if no delta access is required.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  (optional) 
            var dateTo = 2013-10-20;  // DateTime? | End date (inclusive the data dateTo) of the transaction list, default is \"now\" if not given.  Might be ignored if a delta function is used.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  (optional) 
            var entryReferenceFrom = entryReferenceFrom_example;  // string | This data attribute is indicating that the AISP is in favour to get all transactions after the transaction with identification entryReferenceFrom alternatively to the above defined period. This is a implementation of a delta access. If this data element is contained, the entries \"dateFrom\" and \"dateTo\" might be ignored by the ASPSP if a delta report is supported.  Optional if supported by API provider.  (optional) 
            var bookingStatus = bookingStatus_example;  // string | Permitted codes are   * \"booked\",   * \"pending\" and   * \"both\" To support the \"pending\" and \"both\" feature is optional for the ASPSP, Error code if not supported in the online banking frontend Default is \"booked\"  (optional) 
            var deltaList = true;  // bool? | This data attribute is indicating that the AISP is in favour to get all transactions after the last report access for this PSU on the addressed account. This is another implementation of a delta access-report.  This delta indicator might be rejected by the ASPSP if this function is not supported.  Optional if supported by API provider  (optional) 
            var online = false;  // bool? | Makes possible to request actual data and update cache if cache is used by protocol implementation.  (optional)  (default to true)

            try
            {
                // Provides list of transactions by given account
                TransactionsResponse result = apiInstance.GetTransactions(accountId, serviceSessionPassword, fintechUserID, fintechRedirectURLOK, fintechRedirectURLNOK, xRequestID, xTimestampUTC, xRequestSignature, fintechID, bankID, serviceSessionID, dateFrom, dateTo, entryReferenceFrom, bookingStatus, deltaList, online);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TPPBankingAPIAccountInformationServiceAISApi.GetTransactions: " + e.Message );
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
 **accountId** | **string**|  | 
 **serviceSessionPassword** | **string**| Password to encrypt users&#39; context  | 
 **fintechUserID** | **string**| An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user.  | 
 **fintechRedirectURLOK** | **string**|  | 
 **fintechRedirectURLNOK** | **string**|  | 
 **xRequestID** | [**Guid**](Guid.md)| Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well.  | 
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 
 **bankID** | **string**| A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  | [optional] 
 **serviceSessionID** | [**Guid?**](Guid?.md)| Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  | [optional] 
 **dateFrom** | **DateTime?**| Conditional: Starting date (inclusive the date dateFrom) of the transaction list, mandated if no delta access is required.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  | [optional] 
 **dateTo** | **DateTime?**| End date (inclusive the data dateTo) of the transaction list, default is \&quot;now\&quot; if not given.  Might be ignored if a delta function is used.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  | [optional] 
 **entryReferenceFrom** | **string**| This data attribute is indicating that the AISP is in favour to get all transactions after the transaction with identification entryReferenceFrom alternatively to the above defined period. This is a implementation of a delta access. If this data element is contained, the entries \&quot;dateFrom\&quot; and \&quot;dateTo\&quot; might be ignored by the ASPSP if a delta report is supported.  Optional if supported by API provider.  | [optional] 
 **bookingStatus** | **string**| Permitted codes are   * \&quot;booked\&quot;,   * \&quot;pending\&quot; and   * \&quot;both\&quot; To support the \&quot;pending\&quot; and \&quot;both\&quot; feature is optional for the ASPSP, Error code if not supported in the online banking frontend Default is \&quot;booked\&quot;  | [optional] 
 **deltaList** | **bool?**| This data attribute is indicating that the AISP is in favour to get all transactions after the last report access for this PSU on the addressed account. This is another implementation of a delta access-report.  This delta indicator might be rejected by the ASPSP if this function is not supported.  Optional if supported by API provider  | [optional] 
 **online** | **bool?**| Makes possible to request actual data and update cache if cache is used by protocol implementation.  | [optional] [default to true]

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[BearerAuthOAuth](../README.md#BearerAuthOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Request-ID -  <br>  |
| **202** | User authorisation session mandated. Agent shall redirect the user to the Authorisation URI provided in response using &#39;Location&#39; header. This is soft redirection, so that FinTech should inform user about redirection.  |  * Location -  <br>  * X-Request-ID -  <br>  |
| **401** | Unauthorised. Access token absent or invalid.  |  * X-Request-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionswithoutaccountid"></a>
# **GetTransactionsWithoutAccountId**
> TransactionsResponse GetTransactionsWithoutAccountId (string serviceSessionPassword, string fintechUserID, string fintechRedirectURLOK, string fintechRedirectURLNOK, Guid xRequestID, string xTimestampUTC = null, string xRequestSignature = null, string fintechID = null, string bankID = null, Guid? serviceSessionID = null, DateTime? dateFrom = null, DateTime? dateTo = null, string entryReferenceFrom = null, string bookingStatus = null, bool? deltaList = null)

Provides consent for accounts and transactions

This method initiates creation of consent which then can be used for getting either accounts or transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTransactionsWithoutAccountIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure Bearer token for authorization: BearerAuthOAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TPPBankingAPIAccountInformationServiceAISApi(config);
            var serviceSessionPassword = qwerty;  // string | Password to encrypt users' context 
            var fintechUserID = 1234-0XGJK;  // string | An End-User identifier, known by FinTech, that unique for each physical person. To be provided by FinTech with every request in order to validate the mapping of service request to the particular user. 
            var fintechRedirectURLOK = https://example.com/myservice/sf3-3r33-3535?authResult=success;  // string | 
            var fintechRedirectURLNOK = https://example.com/myservice/sf3-3r33-3535/failure;  // string | 
            var xRequestID = new Guid(); // Guid | Unique ID that identifies this request through common workflow. Shall be contained in HTTP Response as well. 
            var xTimestampUTC = 2020-04-14T08:46:33.629Z;  // string | The timestamp of the operation.  (optional) 
            var xRequestSignature = xRequestSignature_example;  // string | A signature of the request by the TPP fintech.  (optional) 
            var fintechID = fintech_123;  // string | Unique ID that identifies fintech.  (optional) 
            var bankID = 1234-0XGJK;  // string | A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  (optional) 
            var serviceSessionID = new Guid?(); // Guid? | Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  (optional) 
            var dateFrom = 2013-10-20;  // DateTime? | Conditional: Starting date (inclusive the date dateFrom) of the transaction list, mandated if no delta access is required.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  (optional) 
            var dateTo = 2013-10-20;  // DateTime? | End date (inclusive the data dateTo) of the transaction list, default is \"now\" if not given.  Might be ignored if a delta function is used.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  (optional) 
            var entryReferenceFrom = entryReferenceFrom_example;  // string | This data attribute is indicating that the AISP is in favour to get all transactions after the transaction with identification entryReferenceFrom alternatively to the above defined period. This is a implementation of a delta access. If this data element is contained, the entries \"dateFrom\" and \"dateTo\" might be ignored by the ASPSP if a delta report is supported.  Optional if supported by API provider.  (optional) 
            var bookingStatus = bookingStatus_example;  // string | Permitted codes are   * \"booked\",   * \"pending\" and   * \"both\" To support the \"pending\" and \"both\" feature is optional for the ASPSP, Error code if not supported in the online banking frontend Default is \"booked\"  (optional) 
            var deltaList = true;  // bool? | This data attribute is indicating that the AISP is in favour to get all transactions after the last report access for this PSU on the addressed account. This is another implementation of a delta access-report.  This delta indicator might be rejected by the ASPSP if this function is not supported.  Optional if supported by API provider  (optional) 

            try
            {
                // Provides consent for accounts and transactions
                TransactionsResponse result = apiInstance.GetTransactionsWithoutAccountId(serviceSessionPassword, fintechUserID, fintechRedirectURLOK, fintechRedirectURLNOK, xRequestID, xTimestampUTC, xRequestSignature, fintechID, bankID, serviceSessionID, dateFrom, dateTo, entryReferenceFrom, bookingStatus, deltaList);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TPPBankingAPIAccountInformationServiceAISApi.GetTransactionsWithoutAccountId: " + e.Message );
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
 **xTimestampUTC** | **string**| The timestamp of the operation.  | [optional] 
 **xRequestSignature** | **string**| A signature of the request by the TPP fintech.  | [optional] 
 **fintechID** | **string**| Unique ID that identifies fintech.  | [optional] 
 **bankID** | **string**| A bank identifier, provided by TPP Bank Search API. To be provided by FinTech only if PsuConsentSession is missing.  | [optional] 
 **serviceSessionID** | [**Guid?**](Guid?.md)| Unique ID that identifies service session. Can be used for batch processing to correlate input and output.  | [optional] 
 **dateFrom** | **DateTime?**| Conditional: Starting date (inclusive the date dateFrom) of the transaction list, mandated if no delta access is required.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  | [optional] 
 **dateTo** | **DateTime?**| End date (inclusive the data dateTo) of the transaction list, default is \&quot;now\&quot; if not given.  Might be ignored if a delta function is used.  For booked transactions, the relevant date is the booking date.  For pending transactions, the relevant date is the entry date, which may not be transparent neither in this API nor other channels of the ASPSP.  | [optional] 
 **entryReferenceFrom** | **string**| This data attribute is indicating that the AISP is in favour to get all transactions after the transaction with identification entryReferenceFrom alternatively to the above defined period. This is a implementation of a delta access. If this data element is contained, the entries \&quot;dateFrom\&quot; and \&quot;dateTo\&quot; might be ignored by the ASPSP if a delta report is supported.  Optional if supported by API provider.  | [optional] 
 **bookingStatus** | **string**| Permitted codes are   * \&quot;booked\&quot;,   * \&quot;pending\&quot; and   * \&quot;both\&quot; To support the \&quot;pending\&quot; and \&quot;both\&quot; feature is optional for the ASPSP, Error code if not supported in the online banking frontend Default is \&quot;booked\&quot;  | [optional] 
 **deltaList** | **bool?**| This data attribute is indicating that the AISP is in favour to get all transactions after the last report access for this PSU on the addressed account. This is another implementation of a delta access-report.  This delta indicator might be rejected by the ASPSP if this function is not supported.  Optional if supported by API provider  | [optional] 

### Return type

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[BearerAuthOAuth](../README.md#BearerAuthOAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * X-Request-ID -  <br>  |
| **202** | User authorisation session mandated. Agent shall redirect the user to the Authorisation URI provided in response using &#39;Location&#39; header. This is soft redirection, so that FinTech should inform user about redirection.  |  * Location -  <br>  * X-Request-ID -  <br>  |
| **401** | Unauthorised. Access token absent or invalid.  |  * X-Request-ID -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


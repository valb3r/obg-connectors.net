# Org.OpenAPITools.Model.ConsentAuth
Transport object for consent API request response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** |  | [optional] 
**Violations** | [**List&lt;AuthViolation&gt;**](AuthViolation.md) |  | [optional] 
**Accounts** | [**List&lt;AccountDetails&gt;**](AccountDetails.md) |  | [optional] 
**AuthMessageTemplate** | **string** |  | [optional] 
**AuthenticationMethodId** | **string** | An identification provided by the ASPSP for the later identification of the authentication method selection. | [optional] 
**BulkPayment** | [**BulkPayment**](BulkPayment.md) |  | [optional] 
**Consent** | [**AisConsentRequest**](AisConsentRequest.md) |  | [optional] 
**BankName** | **string** | Name of current bank | [optional] 
**FintechName** | **string** | Name of current fintech | [optional] 
**ConsentAuthState** | **string** | This is the CSRF-State String of the ConsentAuthorisationApi. It is a transient reference of the consent request. It encodes a key that is used to encrypt information stored in the corresponding ConsentAuthSessionCookie. | [optional] 
**PeriodicPayment** | [**PeriodicPayment**](PeriodicPayment.md) |  | [optional] 
**PsuCorporateId** | **string** |  | [optional] 
**PsuId** | **string** |  | [optional] 
**ScaMethods** | [**List&lt;ScaUserData&gt;**](ScaUserData.md) | List of sca methods for selection if necessary. | [optional] 
**ScaStatus** | **ScaStatus** |  | [optional] 
**SinglePayment** | [**SinglePayment**](SinglePayment.md) |  | [optional] 
**ChallengeData** | [**ChallengeData**](ChallengeData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


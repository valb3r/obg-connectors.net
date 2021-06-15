# Org.OpenAPITools.Model.AisConsentRequest
Ais consent request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Access** | [**AisAccountAccessInfo**](AisAccountAccessInfo.md) |  | 
**FrequencyPerDay** | **int** | Maximum frequency for an access per day. For a once-off access, this attribute is set to 1 | 
**RecurringIndicator** | **bool** | &#39;true&#39;, if the consent is for recurring access to the account data , &#39;false&#39;, if the consent is for one access to the account data | 
**ValidUntil** | **DateTime** | Consent&#x60;s expiration date. The content is the local ASPSP date in ISODate Format | 
**CombinedServiceIndicator** | **bool** | &#39;true&#39;, if the consent is i.e. account list and then payment &#39;false&#39;, if the consent is for one access to the account data | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Org.OpenAPITools.Model.PaymentStatusResponse
Body of the response for a successful payment initiation status request in case of an JSON based endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionStatus** | **string** | The transaction status | 
**FundsAvailable** | **bool** | Equals true if sufficient funds are available at the time of the request, false otherwise. | [optional] 
**PsuMessage** | **string** | Text to be displayed to the PSU. | [optional] 
**CreatedAt** | **DateTime** | Payment creation time according to OpenBanking database | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


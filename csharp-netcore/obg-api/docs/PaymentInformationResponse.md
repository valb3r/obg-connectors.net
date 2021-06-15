# Org.OpenAPITools.Model.PaymentInformationResponse
Generic JSON response body consistion of the corresponding payment initation JSON body together with an optional transaction status field. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndToEndIdentification** | **string** |  | [optional] 
**DebtorAccount** | [**AccountReference1**](AccountReference1.md) |  | 
**InstructedAmount** | [**Amount1**](Amount1.md) |  | 
**CreditorAccount** | [**AccountReference1**](AccountReference1.md) |  | 
**CreditorAgent** | **string** | BICFI  | [optional] 
**CreditorName** | **string** | Creditor Name. | 
**CreditorAddress** | [**Address1**](Address1.md) |  | [optional] 
**RemittanceInformationUnstructured** | **string** | Unstructured remittance information.  | [optional] 
**TransactionStatus** | **string** | The transaction status | [optional] 
**CreatedAt** | **DateTime** | Payment creation time according to OpenBanking database | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


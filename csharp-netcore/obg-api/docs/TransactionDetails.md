# Org.OpenAPITools.Model.TransactionDetails
Transaction details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | the Transaction Id can be used as access-ID in the API, where more details on an transaction is offered. If this data attribute is provided this shows that the AIS can get access on more details about this transaction using the Get transaction details request.  | [optional] 
**EntryReference** | **string** | Is the identification of the transaction as used e.g. for reference for deltafunction on application level. The same identification as for example used within camt.05x messages.  | [optional] 
**EndToEndId** | **string** | Unique end to end identity. | [optional] 
**MandateId** | **string** | Identification of Mandates, e.g. a SEPA Mandate ID. | [optional] 
**CheckId** | **string** | Identification of a Cheque. | [optional] 
**CreditorId** | **string** | Identification of Creditors, e.g. a SEPA Creditor ID. | [optional] 
**BookingDate** | **DateTime** | The date when an entry is posted to an account on the ASPSPs books.  | [optional] 
**ValueDate** | **DateTime** | The Date at which assets become available to the account owner in case of a credit. | [optional] 
**TransactionAmount** | [**Amount1**](Amount1.md) |  | 
**CurrencyExchange** | [**List&lt;ReportExchangeRate&gt;**](ReportExchangeRate.md) | Array of exchange rates. | [optional] 
**CreditorName** | **string** | Creditor Name. | [optional] 
**CreditorAccount** | [**AccountReference1**](AccountReference1.md) |  | [optional] 
**UltimateCreditor** | **string** | Ultimate Creditor. | [optional] 
**DebtorName** | **string** | Debtor Name. | [optional] 
**DebtorAccount** | [**AccountReference1**](AccountReference1.md) |  | [optional] 
**UltimateDebtor** | **string** | Ultimate Debtor. | [optional] 
**RemittanceInformationUnstructured** | **string** | Unstructured remittance information.  | [optional] 
**RemittanceInformationStructured** | **string** | Reference as contained in the structured remittance reference structure (without the surrounding XML structure).  Different from other places the content is containt in plain form not in form of a structered field.  | [optional] 
**AdditionalInformation** | **string** | Might be used by the ASPSP to transport additional transaction related information to the PSU.  | [optional] 
**PurposeCode** | [**PurposeCode**](PurposeCode.md) |  | [optional] 
**BankTransactionCode** | **string** | Bank transaction code as used by the ASPSP and using the sub elements of this structured code defined by ISO 20022.  This code type is concatenating the three ISO20022 Codes   * Domain Code,   * Family Code, and   * SubFamiliy Code by hyphens, resulting in �DomainCode�-�FamilyCode�-�SubFamilyCode�.  | [optional] 
**ProprietaryBankTransactionCode** | **string** | Proprietary bank transaction code as used within a community or within an ASPSP e.g. for MT94x based transaction reports.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


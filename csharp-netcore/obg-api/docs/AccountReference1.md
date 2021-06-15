# Org.OpenAPITools.Model.AccountReference1
Reference to an account by either:   * IBAN, of a payment accounts, or   * BBAN, for payment accounts if there is no IBAN, or   * the Primary Account Number (PAN) of a card, can be tokenised by the ASPSP due to PCI DSS requirements, or   * the Primary Account Number (PAN) of a card in a masked form, or   * an alias to access a payment account via a registered mobile phone number (MSISDN). 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Iban** | **string** | International bank account number ISO 31616. | [optional] 
**Bban** | **string** | Basic Bank Account Number (BBAN) Identifier.  This data element can be used in the body of the Consent request.   Message for retrieving Account access Consent from this Account. This   data elements is used for payment Accounts which have no IBAN.   ISO20022: Basic Bank Account Number (BBAN).    Identifier used nationally by financial institutions, i.e., in individual countries,   generally as part of a National Account Numbering Scheme(s),   which uniquely identifies the account of a customer.  | [optional] 
**Pan** | **string** | Primary Account Number according to ISO/IEC 7812.  | [optional] 
**MaskedPan** | **string** | Masked Primary Account Number.  | [optional] 
**Msisdn** | **string** | Mobile phone number. | [optional] 
**Currency** | **string** | ISO 4217 Alpha 3 currency code.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


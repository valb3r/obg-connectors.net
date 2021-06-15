# Org.OpenAPITools.Model.DenyRequest
Consent authorization denied descriptor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsentAuth** | [**ConsentAuth**](ConsentAuth.md) |  | [optional] 
**BackToFinTech** | **bool** | Will indicate if PSU wants to be sent back to FinTechApi. | [optional] 
**ExitPage** | **string** | In case there is no redirect back to TPP desired, exit page can be specified by ConsentAuthorisationApi | [optional] 
**ForgetConsent** | **bool** | Set to true if consent object shall be forgotten or frozen. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


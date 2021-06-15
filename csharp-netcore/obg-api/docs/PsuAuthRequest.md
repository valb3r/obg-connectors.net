# Org.OpenAPITools.Model.PsuAuthRequest
Contains information used to legitimate a request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConsentAuth** | [**ConsentAuth**](ConsentAuth.md) |  | [optional] 
**ScaAuthenticationData** | **Dictionary&lt;string, string&gt;** | SCA authentication data, depending on the chosen authentication method. If the data is binary, then it is base64 encoded. | 
**Extras** | **Dictionary&lt;string, string&gt;** | ASPSP customary authorization parameters required to i.e. initiate consent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


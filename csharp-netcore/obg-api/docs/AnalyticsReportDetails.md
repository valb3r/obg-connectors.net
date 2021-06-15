# Org.OpenAPITools.Model.AnalyticsReportDetails
JSON based analytics report. This account report contains transaction categorization result. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionId** | **string** | The id of transaction this analytics result refers to. | [optional] 
**MainCategory** | **string** | Main category of the booking. | [optional] 
**SubCategory** | **string** | Sub category of the booking. | [optional] 
**Specification** | **string** | Specification of the booking. | [optional] 
**OtherAccount** | **string** | Related account. | [optional] 
**Logo** | **string** | Logo. | [optional] 
**Homepage** | **string** | Homepage. | [optional] 
**Hotline** | **string** | Hotline. | [optional] 
**Email** | **string** | Email. | [optional] 
**Custom** | **Dictionary&lt;string, string&gt;** | Custom information about analyzed transaction. | [optional] 
**UsedRules** | **List&lt;string&gt;** | Rules that were used to analyze. | [optional] 
**NextBookingDate** | **DateTime** | Classification next booking date. | [optional] 
**Cycle** | **string** | Classification cycle result. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


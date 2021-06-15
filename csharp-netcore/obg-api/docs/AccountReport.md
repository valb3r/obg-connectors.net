# Org.OpenAPITools.Model.AccountReport
JSON based account report. This account report contains transactions resulting from the query parameters.  'booked' shall be contained if bookingStatus parameter is set to \"booked\" or \"both\".  'pending' is not contained if the bookingStatus parameter is set to \"booked\". 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Booked** | [**List&lt;TransactionDetails&gt;**](TransactionDetails.md) | Array of transaction details. | [optional] 
**Pending** | [**List&lt;TransactionDetails&gt;**](TransactionDetails.md) | Array of transaction details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


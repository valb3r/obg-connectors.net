/*
 * An include file to define common attributes
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// PeriodicPayment
    /// </summary>
    [DataContract(Name = "PeriodicPayment")]
    public partial class PeriodicPayment : IEquatable<PeriodicPayment>, IValidatableObject
    {
        /// <summary>
        /// Defines Frequency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            /// <summary>
            /// Enum Daily for value: Daily
            /// </summary>
            [EnumMember(Value = "Daily")]
            Daily = 1,

            /// <summary>
            /// Enum Weekly for value: Weekly
            /// </summary>
            [EnumMember(Value = "Weekly")]
            Weekly = 2,

            /// <summary>
            /// Enum EveryTwoWeeks for value: EveryTwoWeeks
            /// </summary>
            [EnumMember(Value = "EveryTwoWeeks")]
            EveryTwoWeeks = 3,

            /// <summary>
            /// Enum Monthly for value: Monthly
            /// </summary>
            [EnumMember(Value = "Monthly")]
            Monthly = 4,

            /// <summary>
            /// Enum EveryTwoMonths for value: EveryTwoMonths
            /// </summary>
            [EnumMember(Value = "EveryTwoMonths")]
            EveryTwoMonths = 5,

            /// <summary>
            /// Enum Quarterly for value: Quarterly
            /// </summary>
            [EnumMember(Value = "Quarterly")]
            Quarterly = 6,

            /// <summary>
            /// Enum SemiAnnual for value: SemiAnnual
            /// </summary>
            [EnumMember(Value = "SemiAnnual")]
            SemiAnnual = 7,

            /// <summary>
            /// Enum Annual for value: Annual
            /// </summary>
            [EnumMember(Value = "Annual")]
            Annual = 8

        }


        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodicPayment" /> class.
        /// </summary>
        /// <param name="paymentData">paymentData.</param>
        /// <param name="dayOfExecution">dayOfExecution.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="executionRule">executionRule.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="startDate">startDate.</param>
        public PeriodicPayment(SinglePayment paymentData = default(SinglePayment), int dayOfExecution = default(int), DateTime endDate = default(DateTime), string executionRule = default(string), FrequencyEnum? frequency = default(FrequencyEnum?), DateTime startDate = default(DateTime))
        {
            this.PaymentData = paymentData;
            this.DayOfExecution = dayOfExecution;
            this.EndDate = endDate;
            this.ExecutionRule = executionRule;
            this.Frequency = frequency;
            this.StartDate = startDate;
        }

        /// <summary>
        /// Gets or Sets PaymentData
        /// </summary>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public SinglePayment PaymentData { get; set; }

        /// <summary>
        /// Gets or Sets DayOfExecution
        /// </summary>
        [DataMember(Name = "dayOfExecution", EmitDefaultValue = false)]
        public int DayOfExecution { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or Sets ExecutionRule
        /// </summary>
        [DataMember(Name = "executionRule", EmitDefaultValue = false)]
        public string ExecutionRule { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PeriodicPayment {\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  DayOfExecution: ").Append(DayOfExecution).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExecutionRule: ").Append(ExecutionRule).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PeriodicPayment);
        }

        /// <summary>
        /// Returns true if PeriodicPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of PeriodicPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeriodicPayment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) && 
                (
                    this.DayOfExecution == input.DayOfExecution ||
                    this.DayOfExecution.Equals(input.DayOfExecution)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.ExecutionRule == input.ExecutionRule ||
                    (this.ExecutionRule != null &&
                    this.ExecutionRule.Equals(input.ExecutionRule))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PaymentData != null)
                    hashCode = hashCode * 59 + this.PaymentData.GetHashCode();
                hashCode = hashCode * 59 + this.DayOfExecution.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.ExecutionRule != null)
                    hashCode = hashCode * 59 + this.ExecutionRule.GetHashCode();
                hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

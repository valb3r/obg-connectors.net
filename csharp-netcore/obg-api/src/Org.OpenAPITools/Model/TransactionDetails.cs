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
    /// Transaction details.
    /// </summary>
    [DataContract(Name = "transactionDetails")]
    public partial class TransactionDetails : IEquatable<TransactionDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetails" /> class.
        /// </summary>
        /// <param name="transactionId">the Transaction Id can be used as access-ID in the API, where more details on an transaction is offered. If this data attribute is provided this shows that the AIS can get access on more details about this transaction using the Get transaction details request. .</param>
        /// <param name="entryReference">Is the identification of the transaction as used e.g. for reference for deltafunction on application level. The same identification as for example used within camt.05x messages. .</param>
        /// <param name="endToEndId">Unique end to end identity..</param>
        /// <param name="mandateId">Identification of Mandates, e.g. a SEPA Mandate ID..</param>
        /// <param name="checkId">Identification of a Cheque..</param>
        /// <param name="creditorId">Identification of Creditors, e.g. a SEPA Creditor ID..</param>
        /// <param name="bookingDate">The date when an entry is posted to an account on the ASPSPs books. .</param>
        /// <param name="valueDate">The Date at which assets become available to the account owner in case of a credit..</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="currencyExchange">Array of exchange rates..</param>
        /// <param name="creditorName">Creditor Name..</param>
        /// <param name="creditorAccount">creditorAccount.</param>
        /// <param name="ultimateCreditor">Ultimate Creditor..</param>
        /// <param name="debtorName">Debtor Name..</param>
        /// <param name="debtorAccount">debtorAccount.</param>
        /// <param name="ultimateDebtor">Ultimate Debtor..</param>
        /// <param name="remittanceInformationUnstructured">Unstructured remittance information. .</param>
        /// <param name="remittanceInformationStructured">Reference as contained in the structured remittance reference structure (without the surrounding XML structure).  Different from other places the content is containt in plain form not in form of a structered field. .</param>
        /// <param name="additionalInformation">Might be used by the ASPSP to transport additional transaction related information to the PSU. .</param>
        /// <param name="purposeCode">purposeCode.</param>
        /// <param name="bankTransactionCode">Bank transaction code as used by the ASPSP and using the sub elements of this structured code defined by ISO 20022.  This code type is concatenating the three ISO20022 Codes   * Domain Code,   * Family Code, and   * SubFamiliy Code by hyphens, resulting in ???DomainCode???-???FamilyCode???-???SubFamilyCode???. .</param>
        /// <param name="proprietaryBankTransactionCode">Proprietary bank transaction code as used within a community or within an ASPSP e.g. for MT94x based transaction reports. .</param>
        public TransactionDetails(string transactionId = default(string), string entryReference = default(string), string endToEndId = default(string), string mandateId = default(string), string checkId = default(string), string creditorId = default(string), DateTime bookingDate = default(DateTime), DateTime valueDate = default(DateTime), Amount1 transactionAmount = default(Amount1), List<ReportExchangeRate> currencyExchange = default(List<ReportExchangeRate>), string creditorName = default(string), AccountReference1 creditorAccount = default(AccountReference1), string ultimateCreditor = default(string), string debtorName = default(string), AccountReference1 debtorAccount = default(AccountReference1), string ultimateDebtor = default(string), string remittanceInformationUnstructured = default(string), string remittanceInformationStructured = default(string), string additionalInformation = default(string), PurposeCode purposeCode = default(PurposeCode), string bankTransactionCode = default(string), string proprietaryBankTransactionCode = default(string))
        {
            // to ensure "transactionAmount" is required (not null)
            this.TransactionAmount = transactionAmount ?? throw new ArgumentNullException("transactionAmount is a required property for TransactionDetails and cannot be null");
            this.TransactionId = transactionId;
            this.EntryReference = entryReference;
            this.EndToEndId = endToEndId;
            this.MandateId = mandateId;
            this.CheckId = checkId;
            this.CreditorId = creditorId;
            this.BookingDate = bookingDate;
            this.ValueDate = valueDate;
            this.CurrencyExchange = currencyExchange;
            this.CreditorName = creditorName;
            this.CreditorAccount = creditorAccount;
            this.UltimateCreditor = ultimateCreditor;
            this.DebtorName = debtorName;
            this.DebtorAccount = debtorAccount;
            this.UltimateDebtor = ultimateDebtor;
            this.RemittanceInformationUnstructured = remittanceInformationUnstructured;
            this.RemittanceInformationStructured = remittanceInformationStructured;
            this.AdditionalInformation = additionalInformation;
            this.PurposeCode = purposeCode;
            this.BankTransactionCode = bankTransactionCode;
            this.ProprietaryBankTransactionCode = proprietaryBankTransactionCode;
        }

        /// <summary>
        /// the Transaction Id can be used as access-ID in the API, where more details on an transaction is offered. If this data attribute is provided this shows that the AIS can get access on more details about this transaction using the Get transaction details request. 
        /// </summary>
        /// <value>the Transaction Id can be used as access-ID in the API, where more details on an transaction is offered. If this data attribute is provided this shows that the AIS can get access on more details about this transaction using the Get transaction details request. </value>
        [DataMember(Name = "transactionId", EmitDefaultValue = false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Is the identification of the transaction as used e.g. for reference for deltafunction on application level. The same identification as for example used within camt.05x messages. 
        /// </summary>
        /// <value>Is the identification of the transaction as used e.g. for reference for deltafunction on application level. The same identification as for example used within camt.05x messages. </value>
        [DataMember(Name = "entryReference", EmitDefaultValue = false)]
        public string EntryReference { get; set; }

        /// <summary>
        /// Unique end to end identity.
        /// </summary>
        /// <value>Unique end to end identity.</value>
        [DataMember(Name = "endToEndId", EmitDefaultValue = false)]
        public string EndToEndId { get; set; }

        /// <summary>
        /// Identification of Mandates, e.g. a SEPA Mandate ID.
        /// </summary>
        /// <value>Identification of Mandates, e.g. a SEPA Mandate ID.</value>
        [DataMember(Name = "mandateId", EmitDefaultValue = false)]
        public string MandateId { get; set; }

        /// <summary>
        /// Identification of a Cheque.
        /// </summary>
        /// <value>Identification of a Cheque.</value>
        [DataMember(Name = "checkId", EmitDefaultValue = false)]
        public string CheckId { get; set; }

        /// <summary>
        /// Identification of Creditors, e.g. a SEPA Creditor ID.
        /// </summary>
        /// <value>Identification of Creditors, e.g. a SEPA Creditor ID.</value>
        [DataMember(Name = "creditorId", EmitDefaultValue = false)]
        public string CreditorId { get; set; }

        /// <summary>
        /// The date when an entry is posted to an account on the ASPSPs books. 
        /// </summary>
        /// <value>The date when an entry is posted to an account on the ASPSPs books. </value>
        [DataMember(Name = "bookingDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BookingDate { get; set; }

        /// <summary>
        /// The Date at which assets become available to the account owner in case of a credit.
        /// </summary>
        /// <value>The Date at which assets become available to the account owner in case of a credit.</value>
        [DataMember(Name = "valueDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAmount
        /// </summary>
        [DataMember(Name = "transactionAmount", IsRequired = true, EmitDefaultValue = false)]
        public Amount1 TransactionAmount { get; set; }

        /// <summary>
        /// Array of exchange rates.
        /// </summary>
        /// <value>Array of exchange rates.</value>
        [DataMember(Name = "currencyExchange", EmitDefaultValue = false)]
        public List<ReportExchangeRate> CurrencyExchange { get; set; }

        /// <summary>
        /// Creditor Name.
        /// </summary>
        /// <value>Creditor Name.</value>
        [DataMember(Name = "creditorName", EmitDefaultValue = false)]
        public string CreditorName { get; set; }

        /// <summary>
        /// Gets or Sets CreditorAccount
        /// </summary>
        [DataMember(Name = "creditorAccount", EmitDefaultValue = false)]
        public AccountReference1 CreditorAccount { get; set; }

        /// <summary>
        /// Ultimate Creditor.
        /// </summary>
        /// <value>Ultimate Creditor.</value>
        [DataMember(Name = "ultimateCreditor", EmitDefaultValue = false)]
        public string UltimateCreditor { get; set; }

        /// <summary>
        /// Debtor Name.
        /// </summary>
        /// <value>Debtor Name.</value>
        [DataMember(Name = "debtorName", EmitDefaultValue = false)]
        public string DebtorName { get; set; }

        /// <summary>
        /// Gets or Sets DebtorAccount
        /// </summary>
        [DataMember(Name = "debtorAccount", EmitDefaultValue = false)]
        public AccountReference1 DebtorAccount { get; set; }

        /// <summary>
        /// Ultimate Debtor.
        /// </summary>
        /// <value>Ultimate Debtor.</value>
        [DataMember(Name = "ultimateDebtor", EmitDefaultValue = false)]
        public string UltimateDebtor { get; set; }

        /// <summary>
        /// Unstructured remittance information. 
        /// </summary>
        /// <value>Unstructured remittance information. </value>
        [DataMember(Name = "remittanceInformationUnstructured", EmitDefaultValue = false)]
        public string RemittanceInformationUnstructured { get; set; }

        /// <summary>
        /// Reference as contained in the structured remittance reference structure (without the surrounding XML structure).  Different from other places the content is containt in plain form not in form of a structered field. 
        /// </summary>
        /// <value>Reference as contained in the structured remittance reference structure (without the surrounding XML structure).  Different from other places the content is containt in plain form not in form of a structered field. </value>
        [DataMember(Name = "remittanceInformationStructured", EmitDefaultValue = false)]
        public string RemittanceInformationStructured { get; set; }

        /// <summary>
        /// Might be used by the ASPSP to transport additional transaction related information to the PSU. 
        /// </summary>
        /// <value>Might be used by the ASPSP to transport additional transaction related information to the PSU. </value>
        [DataMember(Name = "additionalInformation", EmitDefaultValue = false)]
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or Sets PurposeCode
        /// </summary>
        [DataMember(Name = "purposeCode", EmitDefaultValue = false)]
        public PurposeCode PurposeCode { get; set; }

        /// <summary>
        /// Bank transaction code as used by the ASPSP and using the sub elements of this structured code defined by ISO 20022.  This code type is concatenating the three ISO20022 Codes   * Domain Code,   * Family Code, and   * SubFamiliy Code by hyphens, resulting in ???DomainCode???-???FamilyCode???-???SubFamilyCode???. 
        /// </summary>
        /// <value>Bank transaction code as used by the ASPSP and using the sub elements of this structured code defined by ISO 20022.  This code type is concatenating the three ISO20022 Codes   * Domain Code,   * Family Code, and   * SubFamiliy Code by hyphens, resulting in ???DomainCode???-???FamilyCode???-???SubFamilyCode???. </value>
        [DataMember(Name = "bankTransactionCode", EmitDefaultValue = false)]
        public string BankTransactionCode { get; set; }

        /// <summary>
        /// Proprietary bank transaction code as used within a community or within an ASPSP e.g. for MT94x based transaction reports. 
        /// </summary>
        /// <value>Proprietary bank transaction code as used within a community or within an ASPSP e.g. for MT94x based transaction reports. </value>
        [DataMember(Name = "proprietaryBankTransactionCode", EmitDefaultValue = false)]
        public string ProprietaryBankTransactionCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionDetails {\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  EntryReference: ").Append(EntryReference).Append("\n");
            sb.Append("  EndToEndId: ").Append(EndToEndId).Append("\n");
            sb.Append("  MandateId: ").Append(MandateId).Append("\n");
            sb.Append("  CheckId: ").Append(CheckId).Append("\n");
            sb.Append("  CreditorId: ").Append(CreditorId).Append("\n");
            sb.Append("  BookingDate: ").Append(BookingDate).Append("\n");
            sb.Append("  ValueDate: ").Append(ValueDate).Append("\n");
            sb.Append("  TransactionAmount: ").Append(TransactionAmount).Append("\n");
            sb.Append("  CurrencyExchange: ").Append(CurrencyExchange).Append("\n");
            sb.Append("  CreditorName: ").Append(CreditorName).Append("\n");
            sb.Append("  CreditorAccount: ").Append(CreditorAccount).Append("\n");
            sb.Append("  UltimateCreditor: ").Append(UltimateCreditor).Append("\n");
            sb.Append("  DebtorName: ").Append(DebtorName).Append("\n");
            sb.Append("  DebtorAccount: ").Append(DebtorAccount).Append("\n");
            sb.Append("  UltimateDebtor: ").Append(UltimateDebtor).Append("\n");
            sb.Append("  RemittanceInformationUnstructured: ").Append(RemittanceInformationUnstructured).Append("\n");
            sb.Append("  RemittanceInformationStructured: ").Append(RemittanceInformationStructured).Append("\n");
            sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
            sb.Append("  PurposeCode: ").Append(PurposeCode).Append("\n");
            sb.Append("  BankTransactionCode: ").Append(BankTransactionCode).Append("\n");
            sb.Append("  ProprietaryBankTransactionCode: ").Append(ProprietaryBankTransactionCode).Append("\n");
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
            return this.Equals(input as TransactionDetails);
        }

        /// <summary>
        /// Returns true if TransactionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.EntryReference == input.EntryReference ||
                    (this.EntryReference != null &&
                    this.EntryReference.Equals(input.EntryReference))
                ) && 
                (
                    this.EndToEndId == input.EndToEndId ||
                    (this.EndToEndId != null &&
                    this.EndToEndId.Equals(input.EndToEndId))
                ) && 
                (
                    this.MandateId == input.MandateId ||
                    (this.MandateId != null &&
                    this.MandateId.Equals(input.MandateId))
                ) && 
                (
                    this.CheckId == input.CheckId ||
                    (this.CheckId != null &&
                    this.CheckId.Equals(input.CheckId))
                ) && 
                (
                    this.CreditorId == input.CreditorId ||
                    (this.CreditorId != null &&
                    this.CreditorId.Equals(input.CreditorId))
                ) && 
                (
                    this.BookingDate == input.BookingDate ||
                    (this.BookingDate != null &&
                    this.BookingDate.Equals(input.BookingDate))
                ) && 
                (
                    this.ValueDate == input.ValueDate ||
                    (this.ValueDate != null &&
                    this.ValueDate.Equals(input.ValueDate))
                ) && 
                (
                    this.TransactionAmount == input.TransactionAmount ||
                    (this.TransactionAmount != null &&
                    this.TransactionAmount.Equals(input.TransactionAmount))
                ) && 
                (
                    this.CurrencyExchange == input.CurrencyExchange ||
                    this.CurrencyExchange != null &&
                    input.CurrencyExchange != null &&
                    this.CurrencyExchange.SequenceEqual(input.CurrencyExchange)
                ) && 
                (
                    this.CreditorName == input.CreditorName ||
                    (this.CreditorName != null &&
                    this.CreditorName.Equals(input.CreditorName))
                ) && 
                (
                    this.CreditorAccount == input.CreditorAccount ||
                    (this.CreditorAccount != null &&
                    this.CreditorAccount.Equals(input.CreditorAccount))
                ) && 
                (
                    this.UltimateCreditor == input.UltimateCreditor ||
                    (this.UltimateCreditor != null &&
                    this.UltimateCreditor.Equals(input.UltimateCreditor))
                ) && 
                (
                    this.DebtorName == input.DebtorName ||
                    (this.DebtorName != null &&
                    this.DebtorName.Equals(input.DebtorName))
                ) && 
                (
                    this.DebtorAccount == input.DebtorAccount ||
                    (this.DebtorAccount != null &&
                    this.DebtorAccount.Equals(input.DebtorAccount))
                ) && 
                (
                    this.UltimateDebtor == input.UltimateDebtor ||
                    (this.UltimateDebtor != null &&
                    this.UltimateDebtor.Equals(input.UltimateDebtor))
                ) && 
                (
                    this.RemittanceInformationUnstructured == input.RemittanceInformationUnstructured ||
                    (this.RemittanceInformationUnstructured != null &&
                    this.RemittanceInformationUnstructured.Equals(input.RemittanceInformationUnstructured))
                ) && 
                (
                    this.RemittanceInformationStructured == input.RemittanceInformationStructured ||
                    (this.RemittanceInformationStructured != null &&
                    this.RemittanceInformationStructured.Equals(input.RemittanceInformationStructured))
                ) && 
                (
                    this.AdditionalInformation == input.AdditionalInformation ||
                    (this.AdditionalInformation != null &&
                    this.AdditionalInformation.Equals(input.AdditionalInformation))
                ) && 
                (
                    this.PurposeCode == input.PurposeCode ||
                    (this.PurposeCode != null &&
                    this.PurposeCode.Equals(input.PurposeCode))
                ) && 
                (
                    this.BankTransactionCode == input.BankTransactionCode ||
                    (this.BankTransactionCode != null &&
                    this.BankTransactionCode.Equals(input.BankTransactionCode))
                ) && 
                (
                    this.ProprietaryBankTransactionCode == input.ProprietaryBankTransactionCode ||
                    (this.ProprietaryBankTransactionCode != null &&
                    this.ProprietaryBankTransactionCode.Equals(input.ProprietaryBankTransactionCode))
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
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.EntryReference != null)
                    hashCode = hashCode * 59 + this.EntryReference.GetHashCode();
                if (this.EndToEndId != null)
                    hashCode = hashCode * 59 + this.EndToEndId.GetHashCode();
                if (this.MandateId != null)
                    hashCode = hashCode * 59 + this.MandateId.GetHashCode();
                if (this.CheckId != null)
                    hashCode = hashCode * 59 + this.CheckId.GetHashCode();
                if (this.CreditorId != null)
                    hashCode = hashCode * 59 + this.CreditorId.GetHashCode();
                if (this.BookingDate != null)
                    hashCode = hashCode * 59 + this.BookingDate.GetHashCode();
                if (this.ValueDate != null)
                    hashCode = hashCode * 59 + this.ValueDate.GetHashCode();
                if (this.TransactionAmount != null)
                    hashCode = hashCode * 59 + this.TransactionAmount.GetHashCode();
                if (this.CurrencyExchange != null)
                    hashCode = hashCode * 59 + this.CurrencyExchange.GetHashCode();
                if (this.CreditorName != null)
                    hashCode = hashCode * 59 + this.CreditorName.GetHashCode();
                if (this.CreditorAccount != null)
                    hashCode = hashCode * 59 + this.CreditorAccount.GetHashCode();
                if (this.UltimateCreditor != null)
                    hashCode = hashCode * 59 + this.UltimateCreditor.GetHashCode();
                if (this.DebtorName != null)
                    hashCode = hashCode * 59 + this.DebtorName.GetHashCode();
                if (this.DebtorAccount != null)
                    hashCode = hashCode * 59 + this.DebtorAccount.GetHashCode();
                if (this.UltimateDebtor != null)
                    hashCode = hashCode * 59 + this.UltimateDebtor.GetHashCode();
                if (this.RemittanceInformationUnstructured != null)
                    hashCode = hashCode * 59 + this.RemittanceInformationUnstructured.GetHashCode();
                if (this.RemittanceInformationStructured != null)
                    hashCode = hashCode * 59 + this.RemittanceInformationStructured.GetHashCode();
                if (this.AdditionalInformation != null)
                    hashCode = hashCode * 59 + this.AdditionalInformation.GetHashCode();
                if (this.PurposeCode != null)
                    hashCode = hashCode * 59 + this.PurposeCode.GetHashCode();
                if (this.BankTransactionCode != null)
                    hashCode = hashCode * 59 + this.BankTransactionCode.GetHashCode();
                if (this.ProprietaryBankTransactionCode != null)
                    hashCode = hashCode * 59 + this.ProprietaryBankTransactionCode.GetHashCode();
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
            // EntryReference (string) maxLength
            if(this.EntryReference != null && this.EntryReference.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntryReference, length must be less than 35.", new [] { "EntryReference" });
            }

            // EndToEndId (string) maxLength
            if(this.EndToEndId != null && this.EndToEndId.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EndToEndId, length must be less than 35.", new [] { "EndToEndId" });
            }

            // MandateId (string) maxLength
            if(this.MandateId != null && this.MandateId.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MandateId, length must be less than 35.", new [] { "MandateId" });
            }

            // CheckId (string) maxLength
            if(this.CheckId != null && this.CheckId.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CheckId, length must be less than 35.", new [] { "CheckId" });
            }

            // CreditorId (string) maxLength
            if(this.CreditorId != null && this.CreditorId.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreditorId, length must be less than 35.", new [] { "CreditorId" });
            }

            // CreditorName (string) maxLength
            if(this.CreditorName != null && this.CreditorName.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CreditorName, length must be less than 70.", new [] { "CreditorName" });
            }

            // UltimateCreditor (string) maxLength
            if(this.UltimateCreditor != null && this.UltimateCreditor.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UltimateCreditor, length must be less than 70.", new [] { "UltimateCreditor" });
            }

            // DebtorName (string) maxLength
            if(this.DebtorName != null && this.DebtorName.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DebtorName, length must be less than 70.", new [] { "DebtorName" });
            }

            // UltimateDebtor (string) maxLength
            if(this.UltimateDebtor != null && this.UltimateDebtor.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UltimateDebtor, length must be less than 70.", new [] { "UltimateDebtor" });
            }

            // RemittanceInformationUnstructured (string) maxLength
            if(this.RemittanceInformationUnstructured != null && this.RemittanceInformationUnstructured.Length > 140)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RemittanceInformationUnstructured, length must be less than 140.", new [] { "RemittanceInformationUnstructured" });
            }

            // RemittanceInformationStructured (string) maxLength
            if(this.RemittanceInformationStructured != null && this.RemittanceInformationStructured.Length > 140)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RemittanceInformationStructured, length must be less than 140.", new [] { "RemittanceInformationStructured" });
            }

            // AdditionalInformation (string) maxLength
            if(this.AdditionalInformation != null && this.AdditionalInformation.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdditionalInformation, length must be less than 512.", new [] { "AdditionalInformation" });
            }

            // ProprietaryBankTransactionCode (string) maxLength
            if(this.ProprietaryBankTransactionCode != null && this.ProprietaryBankTransactionCode.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProprietaryBankTransactionCode, length must be less than 35.", new [] { "ProprietaryBankTransactionCode" });
            }

            yield break;
        }
    }

}

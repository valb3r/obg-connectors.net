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
    /// Transport object for consent API request response
    /// </summary>
    [DataContract(Name = "ConsentAuth")]
    public partial class ConsentAuth : IEquatable<ConsentAuth>, IValidatableObject
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum LISTACCOUNTS for value: LIST_ACCOUNTS
            /// </summary>
            [EnumMember(Value = "LIST_ACCOUNTS")]
            LISTACCOUNTS = 1,

            /// <summary>
            /// Enum LISTTRANSACTIONS for value: LIST_TRANSACTIONS
            /// </summary>
            [EnumMember(Value = "LIST_TRANSACTIONS")]
            LISTTRANSACTIONS = 2,

            /// <summary>
            /// Enum INITIATEPAYMENT for value: INITIATE_PAYMENT
            /// </summary>
            [EnumMember(Value = "INITIATE_PAYMENT")]
            INITIATEPAYMENT = 3

        }


        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }

        /// <summary>
        /// Gets or Sets ScaStatus
        /// </summary>
        [DataMember(Name = "scaStatus", EmitDefaultValue = false)]
        public ScaStatus? ScaStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentAuth" /> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="violations">violations.</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="authMessageTemplate">authMessageTemplate.</param>
        /// <param name="authenticationMethodId">An identification provided by the ASPSP for the later identification of the authentication method selection..</param>
        /// <param name="bulkPayment">bulkPayment.</param>
        /// <param name="consent">consent.</param>
        /// <param name="bankName">Name of current bank.</param>
        /// <param name="fintechName">Name of current fintech.</param>
        /// <param name="consentAuthState">This is the CSRF-State String of the ConsentAuthorisationApi. It is a transient reference of the consent request. It encodes a key that is used to encrypt information stored in the corresponding ConsentAuthSessionCookie..</param>
        /// <param name="periodicPayment">periodicPayment.</param>
        /// <param name="psuCorporateId">psuCorporateId.</param>
        /// <param name="psuId">psuId.</param>
        /// <param name="scaMethods">List of sca methods for selection if necessary..</param>
        /// <param name="scaStatus">scaStatus.</param>
        /// <param name="singlePayment">singlePayment.</param>
        /// <param name="challengeData">challengeData.</param>
        public ConsentAuth(ActionEnum? action = default(ActionEnum?), List<AuthViolation> violations = default(List<AuthViolation>), List<AccountDetails> accounts = default(List<AccountDetails>), string authMessageTemplate = default(string), string authenticationMethodId = default(string), BulkPayment bulkPayment = default(BulkPayment), AisConsentRequest consent = default(AisConsentRequest), string bankName = default(string), string fintechName = default(string), string consentAuthState = default(string), PeriodicPayment periodicPayment = default(PeriodicPayment), string psuCorporateId = default(string), string psuId = default(string), List<ScaUserData> scaMethods = default(List<ScaUserData>), ScaStatus? scaStatus = default(ScaStatus?), SinglePayment singlePayment = default(SinglePayment), ChallengeData challengeData = default(ChallengeData))
        {
            this.Action = action;
            this.Violations = violations;
            this.Accounts = accounts;
            this.AuthMessageTemplate = authMessageTemplate;
            this.AuthenticationMethodId = authenticationMethodId;
            this.BulkPayment = bulkPayment;
            this.Consent = consent;
            this.BankName = bankName;
            this.FintechName = fintechName;
            this.ConsentAuthState = consentAuthState;
            this.PeriodicPayment = periodicPayment;
            this.PsuCorporateId = psuCorporateId;
            this.PsuId = psuId;
            this.ScaMethods = scaMethods;
            this.ScaStatus = scaStatus;
            this.SinglePayment = singlePayment;
            this.ChallengeData = challengeData;
        }

        /// <summary>
        /// Gets or Sets Violations
        /// </summary>
        [DataMember(Name = "violations", EmitDefaultValue = false)]
        public List<AuthViolation> Violations { get; set; }

        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name = "accounts", EmitDefaultValue = false)]
        public List<AccountDetails> Accounts { get; set; }

        /// <summary>
        /// Gets or Sets AuthMessageTemplate
        /// </summary>
        [DataMember(Name = "authMessageTemplate", EmitDefaultValue = false)]
        public string AuthMessageTemplate { get; set; }

        /// <summary>
        /// An identification provided by the ASPSP for the later identification of the authentication method selection.
        /// </summary>
        /// <value>An identification provided by the ASPSP for the later identification of the authentication method selection.</value>
        [DataMember(Name = "authenticationMethodId", EmitDefaultValue = false)]
        public string AuthenticationMethodId { get; set; }

        /// <summary>
        /// Gets or Sets BulkPayment
        /// </summary>
        [DataMember(Name = "bulkPayment", EmitDefaultValue = false)]
        public BulkPayment BulkPayment { get; set; }

        /// <summary>
        /// Gets or Sets Consent
        /// </summary>
        [DataMember(Name = "consent", EmitDefaultValue = false)]
        public AisConsentRequest Consent { get; set; }

        /// <summary>
        /// Name of current bank
        /// </summary>
        /// <value>Name of current bank</value>
        [DataMember(Name = "bankName", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// Name of current fintech
        /// </summary>
        /// <value>Name of current fintech</value>
        [DataMember(Name = "fintechName", EmitDefaultValue = false)]
        public string FintechName { get; set; }

        /// <summary>
        /// This is the CSRF-State String of the ConsentAuthorisationApi. It is a transient reference of the consent request. It encodes a key that is used to encrypt information stored in the corresponding ConsentAuthSessionCookie.
        /// </summary>
        /// <value>This is the CSRF-State String of the ConsentAuthorisationApi. It is a transient reference of the consent request. It encodes a key that is used to encrypt information stored in the corresponding ConsentAuthSessionCookie.</value>
        [DataMember(Name = "consentAuthState", EmitDefaultValue = false)]
        public string ConsentAuthState { get; set; }

        /// <summary>
        /// Gets or Sets PeriodicPayment
        /// </summary>
        [DataMember(Name = "periodicPayment", EmitDefaultValue = false)]
        public PeriodicPayment PeriodicPayment { get; set; }

        /// <summary>
        /// Gets or Sets PsuCorporateId
        /// </summary>
        [DataMember(Name = "psuCorporateId", EmitDefaultValue = false)]
        public string PsuCorporateId { get; set; }

        /// <summary>
        /// Gets or Sets PsuId
        /// </summary>
        [DataMember(Name = "psuId", EmitDefaultValue = false)]
        public string PsuId { get; set; }

        /// <summary>
        /// List of sca methods for selection if necessary.
        /// </summary>
        /// <value>List of sca methods for selection if necessary.</value>
        [DataMember(Name = "scaMethods", EmitDefaultValue = false)]
        public List<ScaUserData> ScaMethods { get; set; }

        /// <summary>
        /// Gets or Sets SinglePayment
        /// </summary>
        [DataMember(Name = "singlePayment", EmitDefaultValue = false)]
        public SinglePayment SinglePayment { get; set; }

        /// <summary>
        /// Gets or Sets ChallengeData
        /// </summary>
        [DataMember(Name = "challengeData", EmitDefaultValue = false)]
        public ChallengeData ChallengeData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConsentAuth {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Violations: ").Append(Violations).Append("\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  AuthMessageTemplate: ").Append(AuthMessageTemplate).Append("\n");
            sb.Append("  AuthenticationMethodId: ").Append(AuthenticationMethodId).Append("\n");
            sb.Append("  BulkPayment: ").Append(BulkPayment).Append("\n");
            sb.Append("  Consent: ").Append(Consent).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  FintechName: ").Append(FintechName).Append("\n");
            sb.Append("  ConsentAuthState: ").Append(ConsentAuthState).Append("\n");
            sb.Append("  PeriodicPayment: ").Append(PeriodicPayment).Append("\n");
            sb.Append("  PsuCorporateId: ").Append(PsuCorporateId).Append("\n");
            sb.Append("  PsuId: ").Append(PsuId).Append("\n");
            sb.Append("  ScaMethods: ").Append(ScaMethods).Append("\n");
            sb.Append("  ScaStatus: ").Append(ScaStatus).Append("\n");
            sb.Append("  SinglePayment: ").Append(SinglePayment).Append("\n");
            sb.Append("  ChallengeData: ").Append(ChallengeData).Append("\n");
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
            return this.Equals(input as ConsentAuth);
        }

        /// <summary>
        /// Returns true if ConsentAuth instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsentAuth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsentAuth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.Violations == input.Violations ||
                    this.Violations != null &&
                    input.Violations != null &&
                    this.Violations.SequenceEqual(input.Violations)
                ) && 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.AuthMessageTemplate == input.AuthMessageTemplate ||
                    (this.AuthMessageTemplate != null &&
                    this.AuthMessageTemplate.Equals(input.AuthMessageTemplate))
                ) && 
                (
                    this.AuthenticationMethodId == input.AuthenticationMethodId ||
                    (this.AuthenticationMethodId != null &&
                    this.AuthenticationMethodId.Equals(input.AuthenticationMethodId))
                ) && 
                (
                    this.BulkPayment == input.BulkPayment ||
                    (this.BulkPayment != null &&
                    this.BulkPayment.Equals(input.BulkPayment))
                ) && 
                (
                    this.Consent == input.Consent ||
                    (this.Consent != null &&
                    this.Consent.Equals(input.Consent))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.FintechName == input.FintechName ||
                    (this.FintechName != null &&
                    this.FintechName.Equals(input.FintechName))
                ) && 
                (
                    this.ConsentAuthState == input.ConsentAuthState ||
                    (this.ConsentAuthState != null &&
                    this.ConsentAuthState.Equals(input.ConsentAuthState))
                ) && 
                (
                    this.PeriodicPayment == input.PeriodicPayment ||
                    (this.PeriodicPayment != null &&
                    this.PeriodicPayment.Equals(input.PeriodicPayment))
                ) && 
                (
                    this.PsuCorporateId == input.PsuCorporateId ||
                    (this.PsuCorporateId != null &&
                    this.PsuCorporateId.Equals(input.PsuCorporateId))
                ) && 
                (
                    this.PsuId == input.PsuId ||
                    (this.PsuId != null &&
                    this.PsuId.Equals(input.PsuId))
                ) && 
                (
                    this.ScaMethods == input.ScaMethods ||
                    this.ScaMethods != null &&
                    input.ScaMethods != null &&
                    this.ScaMethods.SequenceEqual(input.ScaMethods)
                ) && 
                (
                    this.ScaStatus == input.ScaStatus ||
                    this.ScaStatus.Equals(input.ScaStatus)
                ) && 
                (
                    this.SinglePayment == input.SinglePayment ||
                    (this.SinglePayment != null &&
                    this.SinglePayment.Equals(input.SinglePayment))
                ) && 
                (
                    this.ChallengeData == input.ChallengeData ||
                    (this.ChallengeData != null &&
                    this.ChallengeData.Equals(input.ChallengeData))
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Violations != null)
                    hashCode = hashCode * 59 + this.Violations.GetHashCode();
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.AuthMessageTemplate != null)
                    hashCode = hashCode * 59 + this.AuthMessageTemplate.GetHashCode();
                if (this.AuthenticationMethodId != null)
                    hashCode = hashCode * 59 + this.AuthenticationMethodId.GetHashCode();
                if (this.BulkPayment != null)
                    hashCode = hashCode * 59 + this.BulkPayment.GetHashCode();
                if (this.Consent != null)
                    hashCode = hashCode * 59 + this.Consent.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.FintechName != null)
                    hashCode = hashCode * 59 + this.FintechName.GetHashCode();
                if (this.ConsentAuthState != null)
                    hashCode = hashCode * 59 + this.ConsentAuthState.GetHashCode();
                if (this.PeriodicPayment != null)
                    hashCode = hashCode * 59 + this.PeriodicPayment.GetHashCode();
                if (this.PsuCorporateId != null)
                    hashCode = hashCode * 59 + this.PsuCorporateId.GetHashCode();
                if (this.PsuId != null)
                    hashCode = hashCode * 59 + this.PsuId.GetHashCode();
                if (this.ScaMethods != null)
                    hashCode = hashCode * 59 + this.ScaMethods.GetHashCode();
                hashCode = hashCode * 59 + this.ScaStatus.GetHashCode();
                if (this.SinglePayment != null)
                    hashCode = hashCode * 59 + this.SinglePayment.GetHashCode();
                if (this.ChallengeData != null)
                    hashCode = hashCode * 59 + this.ChallengeData.GetHashCode();
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

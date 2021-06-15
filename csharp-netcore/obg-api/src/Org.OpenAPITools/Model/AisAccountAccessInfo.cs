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
    /// Ais account access information
    /// </summary>
    [DataContract(Name = "AisAccountAccessInfo")]
    public partial class AisAccountAccessInfo : IEquatable<AisAccountAccessInfo>, IValidatableObject
    {
        /// <summary>
        /// Consent on all accounts, balances and transactions of psu
        /// </summary>
        /// <value>Consent on all accounts, balances and transactions of psu</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AllPsd2Enum
        {
            /// <summary>
            /// Enum ACCOUNTS for value: ALL_ACCOUNTS
            /// </summary>
            [EnumMember(Value = "ALL_ACCOUNTS")]
            ACCOUNTS = 1,

            /// <summary>
            /// Enum ACCOUNTSWITHBALANCES for value: ALL_ACCOUNTS_WITH_BALANCES
            /// </summary>
            [EnumMember(Value = "ALL_ACCOUNTS_WITH_BALANCES")]
            ACCOUNTSWITHBALANCES = 2

        }


        /// <summary>
        /// Consent on all accounts, balances and transactions of psu
        /// </summary>
        /// <value>Consent on all accounts, balances and transactions of psu</value>
        [DataMember(Name = "allPsd2", EmitDefaultValue = false)]
        public AllPsd2Enum? AllPsd2 { get; set; }
        /// <summary>
        /// Consent on all available accounts of psu
        /// </summary>
        /// <value>Consent on all available accounts of psu</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AvailableAccountsEnum
        {
            /// <summary>
            /// Enum ACCOUNTS for value: ALL_ACCOUNTS
            /// </summary>
            [EnumMember(Value = "ALL_ACCOUNTS")]
            ACCOUNTS = 1,

            /// <summary>
            /// Enum ACCOUNTSWITHBALANCES for value: ALL_ACCOUNTS_WITH_BALANCES
            /// </summary>
            [EnumMember(Value = "ALL_ACCOUNTS_WITH_BALANCES")]
            ACCOUNTSWITHBALANCES = 2

        }


        /// <summary>
        /// Consent on all available accounts of psu
        /// </summary>
        /// <value>Consent on all available accounts of psu</value>
        [DataMember(Name = "availableAccounts", EmitDefaultValue = false)]
        public AvailableAccountsEnum? AvailableAccounts { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AisAccountAccessInfo" /> class.
        /// </summary>
        /// <param name="accounts">Access to accounts.</param>
        /// <param name="allPsd2">Consent on all accounts, balances and transactions of psu.</param>
        /// <param name="availableAccounts">Consent on all available accounts of psu.</param>
        /// <param name="balances">Access to balances.</param>
        /// <param name="transactions">Access to transactions.</param>
        public AisAccountAccessInfo(List<AccountReference> accounts = default(List<AccountReference>), AllPsd2Enum? allPsd2 = default(AllPsd2Enum?), AvailableAccountsEnum? availableAccounts = default(AvailableAccountsEnum?), List<AccountReference> balances = default(List<AccountReference>), List<AccountReference> transactions = default(List<AccountReference>))
        {
            this.Accounts = accounts;
            this.AllPsd2 = allPsd2;
            this.AvailableAccounts = availableAccounts;
            this.Balances = balances;
            this.Transactions = transactions;
        }

        /// <summary>
        /// Access to accounts
        /// </summary>
        /// <value>Access to accounts</value>
        [DataMember(Name = "accounts", EmitDefaultValue = false)]
        public List<AccountReference> Accounts { get; set; }

        /// <summary>
        /// Access to balances
        /// </summary>
        /// <value>Access to balances</value>
        [DataMember(Name = "balances", EmitDefaultValue = false)]
        public List<AccountReference> Balances { get; set; }

        /// <summary>
        /// Access to transactions
        /// </summary>
        /// <value>Access to transactions</value>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<AccountReference> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AisAccountAccessInfo {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  AllPsd2: ").Append(AllPsd2).Append("\n");
            sb.Append("  AvailableAccounts: ").Append(AvailableAccounts).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as AisAccountAccessInfo);
        }

        /// <summary>
        /// Returns true if AisAccountAccessInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AisAccountAccessInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AisAccountAccessInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.AllPsd2 == input.AllPsd2 ||
                    this.AllPsd2.Equals(input.AllPsd2)
                ) && 
                (
                    this.AvailableAccounts == input.AvailableAccounts ||
                    this.AvailableAccounts.Equals(input.AvailableAccounts)
                ) && 
                (
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
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
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                hashCode = hashCode * 59 + this.AllPsd2.GetHashCode();
                hashCode = hashCode * 59 + this.AvailableAccounts.GetHashCode();
                if (this.Balances != null)
                    hashCode = hashCode * 59 + this.Balances.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
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

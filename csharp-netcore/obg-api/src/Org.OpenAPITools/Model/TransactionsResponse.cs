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
    /// Body of the JSON response for a successful read transaction list request. This account report contains transactions resulting from the query parameters. 
    /// </summary>
    [DataContract(Name = "transactionsResponse")]
    public partial class TransactionsResponse : IEquatable<TransactionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsResponse" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="transactions">transactions.</param>
        public TransactionsResponse(AccountReference1 account = default(AccountReference1), AccountReport transactions = default(AccountReport))
        {
            this.Account = account;
            this.Transactions = transactions;
        }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public AccountReference1 Account { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public AccountReport Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionsResponse {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(input as TransactionsResponse);
        }

        /// <summary>
        /// Returns true if TransactionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    (this.Transactions != null &&
                    this.Transactions.Equals(input.Transactions))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
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

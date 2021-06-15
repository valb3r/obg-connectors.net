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
    /// Reference to an account by either:   * IBAN, of a payment accounts, or   * BBAN, for payment accounts if there is no IBAN, or   * the Primary Account Number (PAN) of a card, can be tokenised by the ASPSP due to PCI DSS requirements, or   * the Primary Account Number (PAN) of a card in a masked form, or   * an alias to access a payment account via a registered mobile phone number (MSISDN). 
    /// </summary>
    [DataContract(Name = "accountReference_1")]
    public partial class AccountReference1 : IEquatable<AccountReference1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountReference1" /> class.
        /// </summary>
        /// <param name="iban">International bank account number ISO 31616..</param>
        /// <param name="bban">Basic Bank Account Number (BBAN) Identifier.  This data element can be used in the body of the Consent request.   Message for retrieving Account access Consent from this Account. This   data elements is used for payment Accounts which have no IBAN.   ISO20022: Basic Bank Account Number (BBAN).    Identifier used nationally by financial institutions, i.e., in individual countries,   generally as part of a National Account Numbering Scheme(s),   which uniquely identifies the account of a customer. .</param>
        /// <param name="pan">Primary Account Number according to ISO/IEC 7812. .</param>
        /// <param name="maskedPan">Masked Primary Account Number. .</param>
        /// <param name="msisdn">Mobile phone number..</param>
        /// <param name="currency">ISO 4217 Alpha 3 currency code. .</param>
        public AccountReference1(string iban = default(string), string bban = default(string), string pan = default(string), string maskedPan = default(string), string msisdn = default(string), string currency = default(string))
        {
            this.Iban = iban;
            this.Bban = bban;
            this.Pan = pan;
            this.MaskedPan = maskedPan;
            this.Msisdn = msisdn;
            this.Currency = currency;
        }

        /// <summary>
        /// International bank account number ISO 31616.
        /// </summary>
        /// <value>International bank account number ISO 31616.</value>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// Basic Bank Account Number (BBAN) Identifier.  This data element can be used in the body of the Consent request.   Message for retrieving Account access Consent from this Account. This   data elements is used for payment Accounts which have no IBAN.   ISO20022: Basic Bank Account Number (BBAN).    Identifier used nationally by financial institutions, i.e., in individual countries,   generally as part of a National Account Numbering Scheme(s),   which uniquely identifies the account of a customer. 
        /// </summary>
        /// <value>Basic Bank Account Number (BBAN) Identifier.  This data element can be used in the body of the Consent request.   Message for retrieving Account access Consent from this Account. This   data elements is used for payment Accounts which have no IBAN.   ISO20022: Basic Bank Account Number (BBAN).    Identifier used nationally by financial institutions, i.e., in individual countries,   generally as part of a National Account Numbering Scheme(s),   which uniquely identifies the account of a customer. </value>
        [DataMember(Name = "bban", EmitDefaultValue = false)]
        public string Bban { get; set; }

        /// <summary>
        /// Primary Account Number according to ISO/IEC 7812. 
        /// </summary>
        /// <value>Primary Account Number according to ISO/IEC 7812. </value>
        [DataMember(Name = "pan", EmitDefaultValue = false)]
        public string Pan { get; set; }

        /// <summary>
        /// Masked Primary Account Number. 
        /// </summary>
        /// <value>Masked Primary Account Number. </value>
        [DataMember(Name = "maskedPan", EmitDefaultValue = false)]
        public string MaskedPan { get; set; }

        /// <summary>
        /// Mobile phone number.
        /// </summary>
        /// <value>Mobile phone number.</value>
        [DataMember(Name = "msisdn", EmitDefaultValue = false)]
        public string Msisdn { get; set; }

        /// <summary>
        /// ISO 4217 Alpha 3 currency code. 
        /// </summary>
        /// <value>ISO 4217 Alpha 3 currency code. </value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountReference1 {\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Bban: ").Append(Bban).Append("\n");
            sb.Append("  Pan: ").Append(Pan).Append("\n");
            sb.Append("  MaskedPan: ").Append(MaskedPan).Append("\n");
            sb.Append("  Msisdn: ").Append(Msisdn).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as AccountReference1);
        }

        /// <summary>
        /// Returns true if AccountReference1 instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountReference1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountReference1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.Bban == input.Bban ||
                    (this.Bban != null &&
                    this.Bban.Equals(input.Bban))
                ) && 
                (
                    this.Pan == input.Pan ||
                    (this.Pan != null &&
                    this.Pan.Equals(input.Pan))
                ) && 
                (
                    this.MaskedPan == input.MaskedPan ||
                    (this.MaskedPan != null &&
                    this.MaskedPan.Equals(input.MaskedPan))
                ) && 
                (
                    this.Msisdn == input.Msisdn ||
                    (this.Msisdn != null &&
                    this.Msisdn.Equals(input.Msisdn))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
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
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.Bban != null)
                    hashCode = hashCode * 59 + this.Bban.GetHashCode();
                if (this.Pan != null)
                    hashCode = hashCode * 59 + this.Pan.GetHashCode();
                if (this.MaskedPan != null)
                    hashCode = hashCode * 59 + this.MaskedPan.GetHashCode();
                if (this.Msisdn != null)
                    hashCode = hashCode * 59 + this.Msisdn.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
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
            // Iban (string) pattern
            Regex regexIban = new Regex(@"[A-Z]{2,2}[0-9]{2,2}[a-zA-Z0-9]{1,30}", RegexOptions.CultureInvariant);
            if (false == regexIban.Match(this.Iban).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Iban, must match a pattern of " + regexIban, new [] { "Iban" });
            }

            // Bban (string) pattern
            Regex regexBban = new Regex(@"[a-zA-Z0-9]{1,30}", RegexOptions.CultureInvariant);
            if (false == regexBban.Match(this.Bban).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bban, must match a pattern of " + regexBban, new [] { "Bban" });
            }

            // Pan (string) maxLength
            if(this.Pan != null && this.Pan.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pan, length must be less than 35.", new [] { "Pan" });
            }

            // MaskedPan (string) maxLength
            if(this.MaskedPan != null && this.MaskedPan.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaskedPan, length must be less than 35.", new [] { "MaskedPan" });
            }

            // Msisdn (string) maxLength
            if(this.Msisdn != null && this.Msisdn.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Msisdn, length must be less than 35.", new [] { "Msisdn" });
            }

            // Currency (string) pattern
            Regex regexCurrency = new Regex(@"[A-Z]{3}", RegexOptions.CultureInvariant);
            if (false == regexCurrency.Match(this.Currency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, must match a pattern of " + regexCurrency, new [] { "Currency" });
            }

            yield break;
        }
    }

}
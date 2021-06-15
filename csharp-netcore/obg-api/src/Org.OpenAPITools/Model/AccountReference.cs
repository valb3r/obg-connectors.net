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
    /// AccountReference
    /// </summary>
    [DataContract(Name = "AccountReference")]
    public partial class AccountReference : IEquatable<AccountReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountReference" /> class.
        /// </summary>
        /// <param name="bban">bban.</param>
        /// <param name="currency">currency.</param>
        /// <param name="iban">iban.</param>
        /// <param name="maskedPan">maskedPan.</param>
        /// <param name="msisdn">msisdn.</param>
        /// <param name="pan">pan.</param>
        public AccountReference(string bban = default(string), string currency = default(string), string iban = default(string), string maskedPan = default(string), string msisdn = default(string), string pan = default(string))
        {
            this.Bban = bban;
            this.Currency = currency;
            this.Iban = iban;
            this.MaskedPan = maskedPan;
            this.Msisdn = msisdn;
            this.Pan = pan;
        }

        /// <summary>
        /// Gets or Sets Bban
        /// </summary>
        [DataMember(Name = "bban", EmitDefaultValue = false)]
        public string Bban { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets MaskedPan
        /// </summary>
        [DataMember(Name = "maskedPan", EmitDefaultValue = false)]
        public string MaskedPan { get; set; }

        /// <summary>
        /// Gets or Sets Msisdn
        /// </summary>
        [DataMember(Name = "msisdn", EmitDefaultValue = false)]
        public string Msisdn { get; set; }

        /// <summary>
        /// Gets or Sets Pan
        /// </summary>
        [DataMember(Name = "pan", EmitDefaultValue = false)]
        public string Pan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountReference {\n");
            sb.Append("  Bban: ").Append(Bban).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  MaskedPan: ").Append(MaskedPan).Append("\n");
            sb.Append("  Msisdn: ").Append(Msisdn).Append("\n");
            sb.Append("  Pan: ").Append(Pan).Append("\n");
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
            return this.Equals(input as AccountReference);
        }

        /// <summary>
        /// Returns true if AccountReference instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bban == input.Bban ||
                    (this.Bban != null &&
                    this.Bban.Equals(input.Bban))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
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
                    this.Pan == input.Pan ||
                    (this.Pan != null &&
                    this.Pan.Equals(input.Pan))
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
                if (this.Bban != null)
                    hashCode = hashCode * 59 + this.Bban.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.MaskedPan != null)
                    hashCode = hashCode * 59 + this.MaskedPan.GetHashCode();
                if (this.Msisdn != null)
                    hashCode = hashCode * 59 + this.Msisdn.GetHashCode();
                if (this.Pan != null)
                    hashCode = hashCode * 59 + this.Pan.GetHashCode();
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

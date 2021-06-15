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
    /// Contains information used to legitimate a request.
    /// </summary>
    [DataContract(Name = "PsuAuthRequest")]
    public partial class PsuAuthRequest : IEquatable<PsuAuthRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PsuAuthRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthRequest" /> class.
        /// </summary>
        /// <param name="consentAuth">consentAuth.</param>
        /// <param name="scaAuthenticationData">SCA authentication data, depending on the chosen authentication method. If the data is binary, then it is base64 encoded. (required).</param>
        /// <param name="extras">ASPSP customary authorization parameters required to i.e. initiate consent..</param>
        public PsuAuthRequest(ConsentAuth consentAuth = default(ConsentAuth), Dictionary<string, string> scaAuthenticationData = default(Dictionary<string, string>), Dictionary<string, string> extras = default(Dictionary<string, string>))
        {
            // to ensure "scaAuthenticationData" is required (not null)
            this.ScaAuthenticationData = scaAuthenticationData ?? throw new ArgumentNullException("scaAuthenticationData is a required property for PsuAuthRequest and cannot be null");
            this.ConsentAuth = consentAuth;
            this.Extras = extras;
        }

        /// <summary>
        /// Gets or Sets ConsentAuth
        /// </summary>
        [DataMember(Name = "consentAuth", EmitDefaultValue = false)]
        public ConsentAuth ConsentAuth { get; set; }

        /// <summary>
        /// SCA authentication data, depending on the chosen authentication method. If the data is binary, then it is base64 encoded.
        /// </summary>
        /// <value>SCA authentication data, depending on the chosen authentication method. If the data is binary, then it is base64 encoded.</value>
        [DataMember(Name = "scaAuthenticationData", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, string> ScaAuthenticationData { get; set; }

        /// <summary>
        /// ASPSP customary authorization parameters required to i.e. initiate consent.
        /// </summary>
        /// <value>ASPSP customary authorization parameters required to i.e. initiate consent.</value>
        [DataMember(Name = "extras", EmitDefaultValue = false)]
        public Dictionary<string, string> Extras { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PsuAuthRequest {\n");
            sb.Append("  ConsentAuth: ").Append(ConsentAuth).Append("\n");
            sb.Append("  ScaAuthenticationData: ").Append(ScaAuthenticationData).Append("\n");
            sb.Append("  Extras: ").Append(Extras).Append("\n");
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
            return this.Equals(input as PsuAuthRequest);
        }

        /// <summary>
        /// Returns true if PsuAuthRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PsuAuthRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PsuAuthRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsentAuth == input.ConsentAuth ||
                    (this.ConsentAuth != null &&
                    this.ConsentAuth.Equals(input.ConsentAuth))
                ) && 
                (
                    this.ScaAuthenticationData == input.ScaAuthenticationData ||
                    this.ScaAuthenticationData != null &&
                    input.ScaAuthenticationData != null &&
                    this.ScaAuthenticationData.SequenceEqual(input.ScaAuthenticationData)
                ) && 
                (
                    this.Extras == input.Extras ||
                    this.Extras != null &&
                    input.Extras != null &&
                    this.Extras.SequenceEqual(input.Extras)
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
                if (this.ConsentAuth != null)
                    hashCode = hashCode * 59 + this.ConsentAuth.GetHashCode();
                if (this.ScaAuthenticationData != null)
                    hashCode = hashCode * 59 + this.ScaAuthenticationData.GetHashCode();
                if (this.Extras != null)
                    hashCode = hashCode * 59 + this.Extras.GetHashCode();
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

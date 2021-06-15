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
    /// PsuAuthBody
    /// </summary>
    [DataContract(Name = "PsuAuthBody")]
    public partial class PsuAuthBody : IEquatable<PsuAuthBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PsuAuthBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PsuAuthBody" /> class.
        /// </summary>
        /// <param name="login">login (required).</param>
        /// <param name="password">password (required).</param>
        public PsuAuthBody(string login = default(string), string password = default(string))
        {
            // to ensure "login" is required (not null)
            this.Login = login ?? throw new ArgumentNullException("login is a required property for PsuAuthBody and cannot be null");
            // to ensure "password" is required (not null)
            this.Password = password ?? throw new ArgumentNullException("password is a required property for PsuAuthBody and cannot be null");
        }

        /// <summary>
        /// Gets or Sets Login
        /// </summary>
        [DataMember(Name = "login", IsRequired = true, EmitDefaultValue = false)]
        public string Login { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", IsRequired = true, EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PsuAuthBody {\n");
            sb.Append("  Login: ").Append(Login).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(input as PsuAuthBody);
        }

        /// <summary>
        /// Returns true if PsuAuthBody instances are equal
        /// </summary>
        /// <param name="input">Instance of PsuAuthBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PsuAuthBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Login == input.Login ||
                    (this.Login != null &&
                    this.Login.Equals(input.Login))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                if (this.Login != null)
                    hashCode = hashCode * 59 + this.Login.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
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
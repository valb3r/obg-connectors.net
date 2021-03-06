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
    /// The sca status. Used to manage the consent authorization flows.
    /// </summary>
    /// <value>The sca status. Used to manage the consent authorization flows.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ScaStatus
    {
        /// <summary>
        /// Enum Received for value: received
        /// </summary>
        [EnumMember(Value = "received")]
        Received = 1,

        /// <summary>
        /// Enum PsuIdentified for value: psuIdentified
        /// </summary>
        [EnumMember(Value = "psuIdentified")]
        PsuIdentified = 2,

        /// <summary>
        /// Enum PsuAuthenticated for value: psuAuthenticated
        /// </summary>
        [EnumMember(Value = "psuAuthenticated")]
        PsuAuthenticated = 3,

        /// <summary>
        /// Enum ScaMethodSelected for value: scaMethodSelected
        /// </summary>
        [EnumMember(Value = "scaMethodSelected")]
        ScaMethodSelected = 4,

        /// <summary>
        /// Enum Started for value: started
        /// </summary>
        [EnumMember(Value = "started")]
        Started = 5,

        /// <summary>
        /// Enum Finalised for value: finalised
        /// </summary>
        [EnumMember(Value = "finalised")]
        Finalised = 6,

        /// <summary>
        /// Enum Failed for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed = 7,

        /// <summary>
        /// Enum Exempted for value: exempted
        /// </summary>
        [EnumMember(Value = "exempted")]
        Exempted = 8

    }

}

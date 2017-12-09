/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// Whether to the tax amount should be additional to or included in to the [CatalogItem](#type-catalogitem) price.
    /// </summary>
    /// <value>Whether to the tax amount should be additional to or included in to the [CatalogItem](#type-catalogitem) price.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxInclusionType
    {
        
        /// <summary>
        /// Enum ADDITIVE for "ADDITIVE"
        /// </summary>
        [EnumMember(Value = "ADDITIVE")]
        ADDITIVE,
        
        /// <summary>
        /// Enum INCLUSIVE for "INCLUSIVE"
        /// </summary>
        [EnumMember(Value = "INCLUSIVE")]
        INCLUSIVE
    }

}

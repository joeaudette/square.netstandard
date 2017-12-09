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
    /// Indicates whether the price of a [CatalogItemVariation](#type-catalogitemvariation) should be entered manually at the time of sale.
    /// </summary>
    /// <value>Indicates whether the price of a [CatalogItemVariation](#type-catalogitemvariation) should be entered manually at the time of sale.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CatalogPricingType
    {
        
        /// <summary>
        /// Enum FIXEDPRICING for "FIXED_PRICING"
        /// </summary>
        [EnumMember(Value = "FIXED_PRICING")]
        FIXEDPRICING,
        
        /// <summary>
        /// Enum VARIABLEPRICING for "VARIABLE_PRICING"
        /// </summary>
        [EnumMember(Value = "VARIABLE_PRICING")]
        VARIABLEPRICING
    }

}

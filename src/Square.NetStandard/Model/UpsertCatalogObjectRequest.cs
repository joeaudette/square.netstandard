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
    /// 
    /// </summary>
    [DataContract]
    public partial class UpsertCatalogObjectRequest :  IEquatable<UpsertCatalogObjectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertCatalogObjectRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpsertCatalogObjectRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertCatalogObjectRequest" /> class.
        /// </summary>
        /// <param name="IdempotencyKey">A value you specify that uniquely identifies this request among all your requests. A common way to create a valid idempotency key is to use a Universally unique identifier (UUID).  If you&#39;re unsure whether a particular request was successful, you can reattempt it with the same idempotency key without worrying about creating duplicate objects.  See [Idempotency keys](#idempotencykeys) for more information. (required).</param>
        /// <param name="_Object">A [CatalogObject](#type-catalogobject) to be created or updated. The object&#39;s &#x60;is_deleted&#x60; field must not be set to &#x60;true&#x60;. When creating a new object, the object&#39;s ID must either start with a &#x60;#&#x60; character or be left blank. In either case it will be replaced with a server-generated ID. (required).</param>
        public UpsertCatalogObjectRequest(string IdempotencyKey = default(string), CatalogObject _Object = default(CatalogObject))
        {
            // to ensure "IdempotencyKey" is required (not null)
            if (IdempotencyKey == null)
            {
                throw new InvalidDataException("IdempotencyKey is a required property for UpsertCatalogObjectRequest and cannot be null");
            }
            else
            {
                this.IdempotencyKey = IdempotencyKey;
            }
            // to ensure "_Object" is required (not null)
            if (_Object == null)
            {
                throw new InvalidDataException("_Object is a required property for UpsertCatalogObjectRequest and cannot be null");
            }
            else
            {
                this._Object = _Object;
            }
        }
        
        /// <summary>
        /// A value you specify that uniquely identifies this request among all your requests. A common way to create a valid idempotency key is to use a Universally unique identifier (UUID).  If you&#39;re unsure whether a particular request was successful, you can reattempt it with the same idempotency key without worrying about creating duplicate objects.  See [Idempotency keys](#idempotencykeys) for more information.
        /// </summary>
        /// <value>A value you specify that uniquely identifies this request among all your requests. A common way to create a valid idempotency key is to use a Universally unique identifier (UUID).  If you&#39;re unsure whether a particular request was successful, you can reattempt it with the same idempotency key without worrying about creating duplicate objects.  See [Idempotency keys](#idempotencykeys) for more information.</value>
        [DataMember(Name="idempotency_key", EmitDefaultValue=false)]
        public string IdempotencyKey { get; set; }
        /// <summary>
        /// A [CatalogObject](#type-catalogobject) to be created or updated. The object&#39;s &#x60;is_deleted&#x60; field must not be set to &#x60;true&#x60;. When creating a new object, the object&#39;s ID must either start with a &#x60;#&#x60; character or be left blank. In either case it will be replaced with a server-generated ID.
        /// </summary>
        /// <value>A [CatalogObject](#type-catalogobject) to be created or updated. The object&#39;s &#x60;is_deleted&#x60; field must not be set to &#x60;true&#x60;. When creating a new object, the object&#39;s ID must either start with a &#x60;#&#x60; character or be left blank. In either case it will be replaced with a server-generated ID.</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public CatalogObject _Object { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpsertCatalogObjectRequest {\n");
            sb.Append("  IdempotencyKey: ").Append(IdempotencyKey).Append("\n");
            sb.Append("  _Object: ").Append(_Object).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UpsertCatalogObjectRequest);
        }

        /// <summary>
        /// Returns true if UpsertCatalogObjectRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of UpsertCatalogObjectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpsertCatalogObjectRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdempotencyKey == other.IdempotencyKey ||
                    this.IdempotencyKey != null &&
                    this.IdempotencyKey.Equals(other.IdempotencyKey)
                ) && 
                (
                    this._Object == other._Object ||
                    this._Object != null &&
                    this._Object.Equals(other._Object)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.IdempotencyKey != null)
                    hash = hash * 59 + this.IdempotencyKey.GetHashCode();
                if (this._Object != null)
                    hash = hash * 59 + this._Object.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // IdempotencyKey (string) minLength
            if(this.IdempotencyKey != null && this.IdempotencyKey.Length < 1)
            {
                yield return new ValidationResult("Invalid value for IdempotencyKey, length must be greater than 1.", new [] { "IdempotencyKey" });
            }

            yield break;
        }
    }

}

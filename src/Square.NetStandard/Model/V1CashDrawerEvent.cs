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
    /// V1CashDrawerEvent
    /// </summary>
    [DataContract]
    public partial class V1CashDrawerEvent :  IEquatable<V1CashDrawerEvent>, IValidatableObject
    {
        /// <summary>
        /// The type of event that occurred.
        /// </summary>
        /// <value>The type of event that occurred.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum NOSALE for "NO_SALE"
            /// </summary>
            [EnumMember(Value = "NO_SALE")]
            NOSALE,
            
            /// <summary>
            /// Enum CASHTENDERPAYMENT for "CASH_TENDER_PAYMENT"
            /// </summary>
            [EnumMember(Value = "CASH_TENDER_PAYMENT")]
            CASHTENDERPAYMENT,
            
            /// <summary>
            /// Enum OTHERTENDERPAYMENT for "OTHER_TENDER_PAYMENT"
            /// </summary>
            [EnumMember(Value = "OTHER_TENDER_PAYMENT")]
            OTHERTENDERPAYMENT,
            
            /// <summary>
            /// Enum CASHTENDERCANCELEDPAYMENT for "CASH_TENDER_CANCELED_PAYMENT"
            /// </summary>
            [EnumMember(Value = "CASH_TENDER_CANCELED_PAYMENT")]
            CASHTENDERCANCELEDPAYMENT,
            
            /// <summary>
            /// Enum OTHERTENDERCANCELEDPAYMENT for "OTHER_TENDER_CANCELED_PAYMENT"
            /// </summary>
            [EnumMember(Value = "OTHER_TENDER_CANCELED_PAYMENT")]
            OTHERTENDERCANCELEDPAYMENT,
            
            /// <summary>
            /// Enum CASHTENDERREFUND for "CASH_TENDER_REFUND"
            /// </summary>
            [EnumMember(Value = "CASH_TENDER_REFUND")]
            CASHTENDERREFUND,
            
            /// <summary>
            /// Enum OTHERTENDERREFUND for "OTHER_TENDER_REFUND"
            /// </summary>
            [EnumMember(Value = "OTHER_TENDER_REFUND")]
            OTHERTENDERREFUND,
            
            /// <summary>
            /// Enum PAIDIN for "PAID_IN"
            /// </summary>
            [EnumMember(Value = "PAID_IN")]
            PAIDIN,
            
            /// <summary>
            /// Enum PAIDOUT for "PAID_OUT"
            /// </summary>
            [EnumMember(Value = "PAID_OUT")]
            PAIDOUT
        }

        /// <summary>
        /// The type of event that occurred.
        /// </summary>
        /// <value>The type of event that occurred.</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1CashDrawerEvent" /> class.
        /// </summary>
        /// <param name="Id">The event&#39;s unique ID..</param>
        /// <param name="EmployeeId">The ID of the employee that created the event..</param>
        /// <param name="EventType">The type of event that occurred..</param>
        /// <param name="EventMoney">The amount of money that was added to or removed from the cash drawer because of the event. This value can be positive (for added money) or negative (for removed money)..</param>
        /// <param name="CreatedAt">The time when the event occurred, in ISO 8601 format..</param>
        /// <param name="Description">An optional description of the event, entered by the employee that created it..</param>
        public V1CashDrawerEvent(string Id = default(string), string EmployeeId = default(string), EventTypeEnum? EventType = default(EventTypeEnum?), V1Money EventMoney = default(V1Money), string CreatedAt = default(string), string Description = default(string))
        {
            this.Id = Id;
            this.EmployeeId = EmployeeId;
            this.EventType = EventType;
            this.EventMoney = EventMoney;
            this.CreatedAt = CreatedAt;
            this.Description = Description;
        }
        
        /// <summary>
        /// The event&#39;s unique ID.
        /// </summary>
        /// <value>The event&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The ID of the employee that created the event.
        /// </summary>
        /// <value>The ID of the employee that created the event.</value>
        [DataMember(Name="employee_id", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// The amount of money that was added to or removed from the cash drawer because of the event. This value can be positive (for added money) or negative (for removed money).
        /// </summary>
        /// <value>The amount of money that was added to or removed from the cash drawer because of the event. This value can be positive (for added money) or negative (for removed money).</value>
        [DataMember(Name="event_money", EmitDefaultValue=false)]
        public V1Money EventMoney { get; set; }
        /// <summary>
        /// The time when the event occurred, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the event occurred, in ISO 8601 format.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// An optional description of the event, entered by the employee that created it.
        /// </summary>
        /// <value>An optional description of the event, entered by the employee that created it.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1CashDrawerEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  EventMoney: ").Append(EventMoney).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as V1CashDrawerEvent);
        }

        /// <summary>
        /// Returns true if V1CashDrawerEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of V1CashDrawerEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1CashDrawerEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) && 
                (
                    this.EventMoney == other.EventMoney ||
                    this.EventMoney != null &&
                    this.EventMoney.Equals(other.EventMoney)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                if (this.EventMoney != null)
                    hash = hash * 59 + this.EventMoney.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

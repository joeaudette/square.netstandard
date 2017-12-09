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
    /// V1CashDrawerShift
    /// </summary>
    [DataContract]
    public partial class V1CashDrawerShift :  IEquatable<V1CashDrawerShift>, IValidatableObject
    {
        /// <summary>
        /// The shift's current state.
        /// </summary>
        /// <value>The shift's current state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            
            /// <summary>
            /// Enum OPEN for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN,
            
            /// <summary>
            /// Enum ENDED for "ENDED"
            /// </summary>
            [EnumMember(Value = "ENDED")]
            ENDED,
            
            /// <summary>
            /// Enum CLOSED for "CLOSED"
            /// </summary>
            [EnumMember(Value = "CLOSED")]
            CLOSED
        }

        /// <summary>
        /// The shift's current state.
        /// </summary>
        /// <value>The shift's current state.</value>
        [DataMember(Name="event_type", EmitDefaultValue=false)]
        public EventTypeEnum? EventType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1CashDrawerShift" /> class.
        /// </summary>
        /// <param name="Id">The shift&#39;s unique ID..</param>
        /// <param name="EventType">The shift&#39;s current state..</param>
        /// <param name="OpenedAt">The time when the shift began, in ISO 8601 format..</param>
        /// <param name="EndedAt">The time when the shift ended, in ISO 8601 format..</param>
        /// <param name="ClosedAt">The time when the shift was closed, in ISO 8601 format..</param>
        /// <param name="EmployeeIds">The IDs of all employees that were logged into Square Register at some point during the cash drawer shift..</param>
        /// <param name="OpeningEmployeeId">The ID of the employee that started the cash drawer shift..</param>
        /// <param name="EndingEmployeeId">The ID of the employee that ended the cash drawer shift..</param>
        /// <param name="ClosingEmployeeId">The ID of the employee that closed the cash drawer shift by auditing the cash drawer&#39;s contents..</param>
        /// <param name="Description">The time when the timecard was created, in ISO 8601 format..</param>
        /// <param name="StartingCashMoney">The amount of money in the cash drawer at the start of the shift..</param>
        /// <param name="CashPaymentMoney">The amount of money added to the cash drawer from cash payments..</param>
        /// <param name="CashRefundsMoney">The amount of money removed from the cash drawer from cash refunds. This value is always negative or zero..</param>
        /// <param name="CashPaidInMoney">The amount of money added to the cash drawer for reasons other than cash payments..</param>
        /// <param name="CashPaidOutMoney">The amount of money removed from the cash drawer for reasons other than cash refunds..</param>
        /// <param name="ExpectedCashMoney">The amount of money that should be in the cash drawer at the end of the shift, based on the shift&#39;s other money amounts..</param>
        /// <param name="ClosedCashMoney">The amount of money found in the cash drawer at the end of the shift by an auditing employee..</param>
        /// <param name="Device">The device running Square Register that was connected to the cash drawer..</param>
        /// <param name="Events">All of the events (payments, refunds, and so on) that involved the cash drawer during the shift..</param>
        public V1CashDrawerShift(string Id = default(string), EventTypeEnum? EventType = default(EventTypeEnum?), string OpenedAt = default(string), bool? EndedAt = default(bool?), string ClosedAt = default(string), List<string> EmployeeIds = default(List<string>), string OpeningEmployeeId = default(string), string EndingEmployeeId = default(string), string ClosingEmployeeId = default(string), string Description = default(string), V1Money StartingCashMoney = default(V1Money), V1Money CashPaymentMoney = default(V1Money), V1Money CashRefundsMoney = default(V1Money), V1Money CashPaidInMoney = default(V1Money), V1Money CashPaidOutMoney = default(V1Money), V1Money ExpectedCashMoney = default(V1Money), V1Money ClosedCashMoney = default(V1Money), Device Device = default(Device), List<V1CashDrawerEvent> Events = default(List<V1CashDrawerEvent>))
        {
            this.Id = Id;
            this.EventType = EventType;
            this.OpenedAt = OpenedAt;
            this.EndedAt = EndedAt;
            this.ClosedAt = ClosedAt;
            this.EmployeeIds = EmployeeIds;
            this.OpeningEmployeeId = OpeningEmployeeId;
            this.EndingEmployeeId = EndingEmployeeId;
            this.ClosingEmployeeId = ClosingEmployeeId;
            this.Description = Description;
            this.StartingCashMoney = StartingCashMoney;
            this.CashPaymentMoney = CashPaymentMoney;
            this.CashRefundsMoney = CashRefundsMoney;
            this.CashPaidInMoney = CashPaidInMoney;
            this.CashPaidOutMoney = CashPaidOutMoney;
            this.ExpectedCashMoney = ExpectedCashMoney;
            this.ClosedCashMoney = ClosedCashMoney;
            this.Device = Device;
            this.Events = Events;
        }
        
        /// <summary>
        /// The shift&#39;s unique ID.
        /// </summary>
        /// <value>The shift&#39;s unique ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// The time when the shift began, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the shift began, in ISO 8601 format.</value>
        [DataMember(Name="opened_at", EmitDefaultValue=false)]
        public string OpenedAt { get; set; }
        /// <summary>
        /// The time when the shift ended, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the shift ended, in ISO 8601 format.</value>
        [DataMember(Name="ended_at", EmitDefaultValue=false)]
        public bool? EndedAt { get; set; }
        /// <summary>
        /// The time when the shift was closed, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the shift was closed, in ISO 8601 format.</value>
        [DataMember(Name="closed_at", EmitDefaultValue=false)]
        public string ClosedAt { get; set; }
        /// <summary>
        /// The IDs of all employees that were logged into Square Register at some point during the cash drawer shift.
        /// </summary>
        /// <value>The IDs of all employees that were logged into Square Register at some point during the cash drawer shift.</value>
        [DataMember(Name="employee_ids", EmitDefaultValue=false)]
        public List<string> EmployeeIds { get; set; }
        /// <summary>
        /// The ID of the employee that started the cash drawer shift.
        /// </summary>
        /// <value>The ID of the employee that started the cash drawer shift.</value>
        [DataMember(Name="opening_employee_id", EmitDefaultValue=false)]
        public string OpeningEmployeeId { get; set; }
        /// <summary>
        /// The ID of the employee that ended the cash drawer shift.
        /// </summary>
        /// <value>The ID of the employee that ended the cash drawer shift.</value>
        [DataMember(Name="ending_employee_id", EmitDefaultValue=false)]
        public string EndingEmployeeId { get; set; }
        /// <summary>
        /// The ID of the employee that closed the cash drawer shift by auditing the cash drawer&#39;s contents.
        /// </summary>
        /// <value>The ID of the employee that closed the cash drawer shift by auditing the cash drawer&#39;s contents.</value>
        [DataMember(Name="closing_employee_id", EmitDefaultValue=false)]
        public string ClosingEmployeeId { get; set; }
        /// <summary>
        /// The time when the timecard was created, in ISO 8601 format.
        /// </summary>
        /// <value>The time when the timecard was created, in ISO 8601 format.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// The amount of money in the cash drawer at the start of the shift.
        /// </summary>
        /// <value>The amount of money in the cash drawer at the start of the shift.</value>
        [DataMember(Name="starting_cash_money", EmitDefaultValue=false)]
        public V1Money StartingCashMoney { get; set; }
        /// <summary>
        /// The amount of money added to the cash drawer from cash payments.
        /// </summary>
        /// <value>The amount of money added to the cash drawer from cash payments.</value>
        [DataMember(Name="cash_payment_money", EmitDefaultValue=false)]
        public V1Money CashPaymentMoney { get; set; }
        /// <summary>
        /// The amount of money removed from the cash drawer from cash refunds. This value is always negative or zero.
        /// </summary>
        /// <value>The amount of money removed from the cash drawer from cash refunds. This value is always negative or zero.</value>
        [DataMember(Name="cash_refunds_money", EmitDefaultValue=false)]
        public V1Money CashRefundsMoney { get; set; }
        /// <summary>
        /// The amount of money added to the cash drawer for reasons other than cash payments.
        /// </summary>
        /// <value>The amount of money added to the cash drawer for reasons other than cash payments.</value>
        [DataMember(Name="cash_paid_in_money", EmitDefaultValue=false)]
        public V1Money CashPaidInMoney { get; set; }
        /// <summary>
        /// The amount of money removed from the cash drawer for reasons other than cash refunds.
        /// </summary>
        /// <value>The amount of money removed from the cash drawer for reasons other than cash refunds.</value>
        [DataMember(Name="cash_paid_out_money", EmitDefaultValue=false)]
        public V1Money CashPaidOutMoney { get; set; }
        /// <summary>
        /// The amount of money that should be in the cash drawer at the end of the shift, based on the shift&#39;s other money amounts.
        /// </summary>
        /// <value>The amount of money that should be in the cash drawer at the end of the shift, based on the shift&#39;s other money amounts.</value>
        [DataMember(Name="expected_cash_money", EmitDefaultValue=false)]
        public V1Money ExpectedCashMoney { get; set; }
        /// <summary>
        /// The amount of money found in the cash drawer at the end of the shift by an auditing employee.
        /// </summary>
        /// <value>The amount of money found in the cash drawer at the end of the shift by an auditing employee.</value>
        [DataMember(Name="closed_cash_money", EmitDefaultValue=false)]
        public V1Money ClosedCashMoney { get; set; }
        /// <summary>
        /// The device running Square Register that was connected to the cash drawer.
        /// </summary>
        /// <value>The device running Square Register that was connected to the cash drawer.</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public Device Device { get; set; }
        /// <summary>
        /// All of the events (payments, refunds, and so on) that involved the cash drawer during the shift.
        /// </summary>
        /// <value>All of the events (payments, refunds, and so on) that involved the cash drawer during the shift.</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<V1CashDrawerEvent> Events { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class V1CashDrawerShift {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  OpenedAt: ").Append(OpenedAt).Append("\n");
            sb.Append("  EndedAt: ").Append(EndedAt).Append("\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  EmployeeIds: ").Append(EmployeeIds).Append("\n");
            sb.Append("  OpeningEmployeeId: ").Append(OpeningEmployeeId).Append("\n");
            sb.Append("  EndingEmployeeId: ").Append(EndingEmployeeId).Append("\n");
            sb.Append("  ClosingEmployeeId: ").Append(ClosingEmployeeId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartingCashMoney: ").Append(StartingCashMoney).Append("\n");
            sb.Append("  CashPaymentMoney: ").Append(CashPaymentMoney).Append("\n");
            sb.Append("  CashRefundsMoney: ").Append(CashRefundsMoney).Append("\n");
            sb.Append("  CashPaidInMoney: ").Append(CashPaidInMoney).Append("\n");
            sb.Append("  CashPaidOutMoney: ").Append(CashPaidOutMoney).Append("\n");
            sb.Append("  ExpectedCashMoney: ").Append(ExpectedCashMoney).Append("\n");
            sb.Append("  ClosedCashMoney: ").Append(ClosedCashMoney).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(obj as V1CashDrawerShift);
        }

        /// <summary>
        /// Returns true if V1CashDrawerShift instances are equal
        /// </summary>
        /// <param name="other">Instance of V1CashDrawerShift to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(V1CashDrawerShift other)
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
                    this.EventType == other.EventType ||
                    this.EventType != null &&
                    this.EventType.Equals(other.EventType)
                ) && 
                (
                    this.OpenedAt == other.OpenedAt ||
                    this.OpenedAt != null &&
                    this.OpenedAt.Equals(other.OpenedAt)
                ) && 
                (
                    this.EndedAt == other.EndedAt ||
                    this.EndedAt != null &&
                    this.EndedAt.Equals(other.EndedAt)
                ) && 
                (
                    this.ClosedAt == other.ClosedAt ||
                    this.ClosedAt != null &&
                    this.ClosedAt.Equals(other.ClosedAt)
                ) && 
                (
                    this.EmployeeIds == other.EmployeeIds ||
                    this.EmployeeIds != null &&
                    this.EmployeeIds.SequenceEqual(other.EmployeeIds)
                ) && 
                (
                    this.OpeningEmployeeId == other.OpeningEmployeeId ||
                    this.OpeningEmployeeId != null &&
                    this.OpeningEmployeeId.Equals(other.OpeningEmployeeId)
                ) && 
                (
                    this.EndingEmployeeId == other.EndingEmployeeId ||
                    this.EndingEmployeeId != null &&
                    this.EndingEmployeeId.Equals(other.EndingEmployeeId)
                ) && 
                (
                    this.ClosingEmployeeId == other.ClosingEmployeeId ||
                    this.ClosingEmployeeId != null &&
                    this.ClosingEmployeeId.Equals(other.ClosingEmployeeId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.StartingCashMoney == other.StartingCashMoney ||
                    this.StartingCashMoney != null &&
                    this.StartingCashMoney.Equals(other.StartingCashMoney)
                ) && 
                (
                    this.CashPaymentMoney == other.CashPaymentMoney ||
                    this.CashPaymentMoney != null &&
                    this.CashPaymentMoney.Equals(other.CashPaymentMoney)
                ) && 
                (
                    this.CashRefundsMoney == other.CashRefundsMoney ||
                    this.CashRefundsMoney != null &&
                    this.CashRefundsMoney.Equals(other.CashRefundsMoney)
                ) && 
                (
                    this.CashPaidInMoney == other.CashPaidInMoney ||
                    this.CashPaidInMoney != null &&
                    this.CashPaidInMoney.Equals(other.CashPaidInMoney)
                ) && 
                (
                    this.CashPaidOutMoney == other.CashPaidOutMoney ||
                    this.CashPaidOutMoney != null &&
                    this.CashPaidOutMoney.Equals(other.CashPaidOutMoney)
                ) && 
                (
                    this.ExpectedCashMoney == other.ExpectedCashMoney ||
                    this.ExpectedCashMoney != null &&
                    this.ExpectedCashMoney.Equals(other.ExpectedCashMoney)
                ) && 
                (
                    this.ClosedCashMoney == other.ClosedCashMoney ||
                    this.ClosedCashMoney != null &&
                    this.ClosedCashMoney.Equals(other.ClosedCashMoney)
                ) && 
                (
                    this.Device == other.Device ||
                    this.Device != null &&
                    this.Device.Equals(other.Device)
                ) && 
                (
                    this.Events == other.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(other.Events)
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
                if (this.EventType != null)
                    hash = hash * 59 + this.EventType.GetHashCode();
                if (this.OpenedAt != null)
                    hash = hash * 59 + this.OpenedAt.GetHashCode();
                if (this.EndedAt != null)
                    hash = hash * 59 + this.EndedAt.GetHashCode();
                if (this.ClosedAt != null)
                    hash = hash * 59 + this.ClosedAt.GetHashCode();
                if (this.EmployeeIds != null)
                    hash = hash * 59 + this.EmployeeIds.GetHashCode();
                if (this.OpeningEmployeeId != null)
                    hash = hash * 59 + this.OpeningEmployeeId.GetHashCode();
                if (this.EndingEmployeeId != null)
                    hash = hash * 59 + this.EndingEmployeeId.GetHashCode();
                if (this.ClosingEmployeeId != null)
                    hash = hash * 59 + this.ClosingEmployeeId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.StartingCashMoney != null)
                    hash = hash * 59 + this.StartingCashMoney.GetHashCode();
                if (this.CashPaymentMoney != null)
                    hash = hash * 59 + this.CashPaymentMoney.GetHashCode();
                if (this.CashRefundsMoney != null)
                    hash = hash * 59 + this.CashRefundsMoney.GetHashCode();
                if (this.CashPaidInMoney != null)
                    hash = hash * 59 + this.CashPaidInMoney.GetHashCode();
                if (this.CashPaidOutMoney != null)
                    hash = hash * 59 + this.CashPaidOutMoney.GetHashCode();
                if (this.ExpectedCashMoney != null)
                    hash = hash * 59 + this.ExpectedCashMoney.GetHashCode();
                if (this.ClosedCashMoney != null)
                    hash = hash * 59 + this.ClosedCashMoney.GetHashCode();
                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();
                if (this.Events != null)
                    hash = hash * 59 + this.Events.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}

/* 
 * Algod REST API.
 *
 * API Endpoint for AlgoD Operations.
 *
 * OpenAPI spec version: 0.0.1
 * Contact: contact@algorand.com
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
using SwaggerDateConverter = Algorand.Client.SwaggerDateConverter;

namespace Algorand.Algod.Model
{
    /// <summary>
    /// Supply represents the current supply of MicroAlgos in the system
    /// </summary>
    [DataContract]
        public partial class Supply :  IEquatable<Supply>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Supply" /> class.
        /// </summary>
        /// <param name="onlineMoney">OnlineMoney (required).</param>
        /// <param name="round">Round (required).</param>
        /// <param name="totalMoney">TotalMoney (required).</param>
        public Supply(ulong? onlineMoney = default(ulong?), ulong? round = default(ulong?), ulong? totalMoney = default(ulong?))
        {
            // to ensure "onlineMoney" is required (not null)
            if (onlineMoney == null)
            {
                throw new InvalidDataException("onlineMoney is a required property for Supply and cannot be null");
            }
            else
            {
                this.OnlineMoney = onlineMoney;
            }
            // to ensure "round" is required (not null)
            if (round == null)
            {
                throw new InvalidDataException("round is a required property for Supply and cannot be null");
            }
            else
            {
                this.Round = round;
            }
            // to ensure "totalMoney" is required (not null)
            if (totalMoney == null)
            {
                throw new InvalidDataException("totalMoney is a required property for Supply and cannot be null");
            }
            else
            {
                this.TotalMoney = totalMoney;
            }
        }
        
        /// <summary>
        /// OnlineMoney
        /// </summary>
        /// <value>OnlineMoney</value>
        [DataMember(Name="onlineMoney", EmitDefaultValue=false)]
        public ulong? OnlineMoney { get; set; }

        /// <summary>
        /// Round
        /// </summary>
        /// <value>Round</value>
        [DataMember(Name="round", EmitDefaultValue=false)]
        public ulong? Round { get; set; }

        /// <summary>
        /// TotalMoney
        /// </summary>
        /// <value>TotalMoney</value>
        [DataMember(Name="totalMoney", EmitDefaultValue=false)]
        public ulong? TotalMoney { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Supply {\n");
            sb.Append("  OnlineMoney: ").Append(OnlineMoney).Append("\n");
            sb.Append("  Round: ").Append(Round).Append("\n");
            sb.Append("  TotalMoney: ").Append(TotalMoney).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Supply);
        }

        /// <summary>
        /// Returns true if Supply instances are equal
        /// </summary>
        /// <param name="input">Instance of Supply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Supply input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OnlineMoney == input.OnlineMoney ||
                    (this.OnlineMoney != null &&
                    this.OnlineMoney.Equals(input.OnlineMoney))
                ) && 
                (
                    this.Round == input.Round ||
                    (this.Round != null &&
                    this.Round.Equals(input.Round))
                ) && 
                (
                    this.TotalMoney == input.TotalMoney ||
                    (this.TotalMoney != null &&
                    this.TotalMoney.Equals(input.TotalMoney))
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
                if (this.OnlineMoney != null)
                    hashCode = hashCode * 59 + this.OnlineMoney.GetHashCode();
                if (this.Round != null)
                    hashCode = hashCode * 59 + this.Round.GetHashCode();
                if (this.TotalMoney != null)
                    hashCode = hashCode * 59 + this.TotalMoney.GetHashCode();
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

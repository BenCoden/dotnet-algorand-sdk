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
    /// AssetTransferTransactionType contains the additional fields for an asset transfer transaction
    /// </summary>
    [DataContract]
        public partial class AssetTransferTransactionType :  IEquatable<AssetTransferTransactionType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetTransferTransactionType" /> class.
        /// </summary>
        /// <param name="amt">Amount is the amount being transferred. (required).</param>
        /// <param name="closeto">CloseTo is the destination for remaining funds (if closing)..</param>
        /// <param name="id">AssetID is the asset being configured (or empty if creating) (required).</param>
        /// <param name="rcv">Receiver is the recipient account. (required).</param>
        /// <param name="snd">Sender is the source account (if using clawback)..</param>
        public AssetTransferTransactionType(ulong? amt = default(ulong?), string closeto = default(string), ulong? id = default(ulong?), string rcv = default(string), string snd = default(string))
        {
            // to ensure "amt" is required (not null)
            if (amt == null)
            {
                throw new InvalidDataException("amt is a required property for AssetTransferTransactionType and cannot be null");
            }
            else
            {
                this.Amt = amt;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AssetTransferTransactionType and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "rcv" is required (not null)
            if (rcv == null)
            {
                throw new InvalidDataException("rcv is a required property for AssetTransferTransactionType and cannot be null");
            }
            else
            {
                this.Rcv = rcv;
            }
            this.Closeto = closeto;
            this.Snd = snd;
        }
        
        /// <summary>
        /// Amount is the amount being transferred.
        /// </summary>
        /// <value>Amount is the amount being transferred.</value>
        [DataMember(Name="amt", EmitDefaultValue=false)]
        public ulong? Amt { get; set; }

        /// <summary>
        /// CloseTo is the destination for remaining funds (if closing).
        /// </summary>
        /// <value>CloseTo is the destination for remaining funds (if closing).</value>
        [DataMember(Name="closeto", EmitDefaultValue=false)]
        public string Closeto { get; set; }

        /// <summary>
        /// AssetID is the asset being configured (or empty if creating)
        /// </summary>
        /// <value>AssetID is the asset being configured (or empty if creating)</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public ulong? Id { get; set; }

        /// <summary>
        /// Receiver is the recipient account.
        /// </summary>
        /// <value>Receiver is the recipient account.</value>
        [DataMember(Name="rcv", EmitDefaultValue=false)]
        public string Rcv { get; set; }

        /// <summary>
        /// Sender is the source account (if using clawback).
        /// </summary>
        /// <value>Sender is the source account (if using clawback).</value>
        [DataMember(Name="snd", EmitDefaultValue=false)]
        public string Snd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetTransferTransactionType {\n");
            sb.Append("  Amt: ").Append(Amt).Append("\n");
            sb.Append("  Closeto: ").Append(Closeto).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Rcv: ").Append(Rcv).Append("\n");
            sb.Append("  Snd: ").Append(Snd).Append("\n");
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
            return this.Equals(input as AssetTransferTransactionType);
        }

        /// <summary>
        /// Returns true if AssetTransferTransactionType instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetTransferTransactionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetTransferTransactionType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amt == input.Amt ||
                    (this.Amt != null &&
                    this.Amt.Equals(input.Amt))
                ) && 
                (
                    this.Closeto == input.Closeto ||
                    (this.Closeto != null &&
                    this.Closeto.Equals(input.Closeto))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Rcv == input.Rcv ||
                    (this.Rcv != null &&
                    this.Rcv.Equals(input.Rcv))
                ) && 
                (
                    this.Snd == input.Snd ||
                    (this.Snd != null &&
                    this.Snd.Equals(input.Snd))
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
                if (this.Amt != null)
                    hashCode = hashCode * 59 + this.Amt.GetHashCode();
                if (this.Closeto != null)
                    hashCode = hashCode * 59 + this.Closeto.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Rcv != null)
                    hashCode = hashCode * 59 + this.Rcv.GetHashCode();
                if (this.Snd != null)
                    hashCode = hashCode * 59 + this.Snd.GetHashCode();
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

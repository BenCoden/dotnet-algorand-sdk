/* 
 * Indexer
 *
 * Algorand ledger analytics API.
 *
 * OpenAPI spec version: 2.0
 * 
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

namespace Algorand.V2.Model
{
    /// <summary>
    /// Fields relating to voting for a protocol upgrade.
    /// </summary>
    [DataContract]
        public partial class BlockUpgradeVote :  IEquatable<BlockUpgradeVote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockUpgradeVote" /> class.
        /// </summary>
        /// <param name="upgradeApprove">\\[upgradeyes\\] Indicates a yes vote for the current proposal..</param>
        /// <param name="upgradeDelay">\\[upgradedelay\\] Indicates the time between acceptance and execution..</param>
        /// <param name="upgradePropose">\\[upgradeprop\\] Indicates a proposed upgrade..</param>
        public BlockUpgradeVote(bool? upgradeApprove = default(bool?), long? upgradeDelay = default, string upgradePropose = default(string))
        {
            this.UpgradeApprove = upgradeApprove;
            this.UpgradeDelay = upgradeDelay;
            this.UpgradePropose = upgradePropose;
        }
        
        /// <summary>
        /// \\[upgradeyes\\] Indicates a yes vote for the current proposal.
        /// </summary>
        /// <value>\\[upgradeyes\\] Indicates a yes vote for the current proposal.</value>
        [DataMember(Name="upgrade-approve", EmitDefaultValue=false)]
        public bool? UpgradeApprove { get; set; }

        /// <summary>
        /// \\[upgradedelay\\] Indicates the time between acceptance and execution.
        /// </summary>
        /// <value>\\[upgradedelay\\] Indicates the time between acceptance and execution.</value>
        [DataMember(Name="upgrade-delay", EmitDefaultValue=false)]
        public long? UpgradeDelay { get; set; }

        /// <summary>
        /// \\[upgradeprop\\] Indicates a proposed upgrade.
        /// </summary>
        /// <value>\\[upgradeprop\\] Indicates a proposed upgrade.</value>
        [DataMember(Name="upgrade-propose", EmitDefaultValue=false)]
        public string UpgradePropose { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BlockUpgradeVote {\n");
            sb.Append("  UpgradeApprove: ").Append(UpgradeApprove).Append("\n");
            sb.Append("  UpgradeDelay: ").Append(UpgradeDelay).Append("\n");
            sb.Append("  UpgradePropose: ").Append(UpgradePropose).Append("\n");
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
            return this.Equals(input as BlockUpgradeVote);
        }

        /// <summary>
        /// Returns true if BlockUpgradeVote instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockUpgradeVote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockUpgradeVote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UpgradeApprove == input.UpgradeApprove ||
                    (this.UpgradeApprove != null &&
                    this.UpgradeApprove.Equals(input.UpgradeApprove))
                ) && 
                (
                    this.UpgradeDelay == input.UpgradeDelay ||
                    (this.UpgradeDelay != null &&
                    this.UpgradeDelay.Equals(input.UpgradeDelay))
                ) && 
                (
                    this.UpgradePropose == input.UpgradePropose ||
                    (this.UpgradePropose != null &&
                    this.UpgradePropose.Equals(input.UpgradePropose))
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
                if (this.UpgradeApprove != null)
                    hashCode = hashCode * 59 + this.UpgradeApprove.GetHashCode();
                if (this.UpgradeDelay != null)
                    hashCode = hashCode * 59 + this.UpgradeDelay.GetHashCode();
                if (this.UpgradePropose != null)
                    hashCode = hashCode * 59 + this.UpgradePropose.GetHashCode();
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

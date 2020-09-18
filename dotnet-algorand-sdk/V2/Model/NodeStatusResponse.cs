/* 
 * Algod REST API.
 *
 * API endpoint for algod operations.
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

namespace Algorand.V2.Model
{
    /// <summary>
    /// NodeStatus contains the information about a node status
    /// </summary>
    [DataContract]
    public partial class NodeStatusResponse :  IEquatable<NodeStatusResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NodeStatusResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusResponse" /> class.
        /// </summary>
        /// <param name="catchupTime">CatchupTime in nanoseconds (required).</param>
        /// <param name="lastRound">LastRound indicates the last round seen (required).</param>
        /// <param name="lastVersion">LastVersion indicates the last consensus version supported (required).</param>
        /// <param name="nextVersion">NextVersion of consensus protocol to use (required).</param>
        /// <param name="nextVersionRound">NextVersionRound is the round at which the next consensus version will apply (required).</param>
        /// <param name="nextVersionSupported">NextVersionSupported indicates whether the next consensus version is supported by this node (required).</param>
        /// <param name="stoppedAtUnsupportedRound">StoppedAtUnsupportedRound indicates that the node does not support the new rounds and has stopped making progress (required).</param>
        /// <param name="timeSinceLastRound">TimeSinceLastRound in nanoseconds (required).</param>
        /// <param name="lastCatchpoint">The last catchpoint seen by the node.</param>
        /// <param name="catchpoint">The current catchpoint that is being caught up to.</param>
        /// <param name="catchpointTotalAccounts">The total number of accounts included in the current catchpoint.</param>
        /// <param name="catchpointProcessedAccounts">The number of account from the current catchpoint that have been processed so far as part of the catchup.</param>
        /// <param name="catchpointTotalBlocks">The total number of blocks that are required to complete the current catchpoint catchup.</param>
        /// <param name="catchpointAcquiredBlocks">The number of blocks that have already been obtained by the node as part of the catchup.</param>
        public NodeStatusResponse(long? catchupTime = default, long? lastRound = default, string lastVersion = default(string), string nextVersion = default(string), long? nextVersionRound = default, bool? nextVersionSupported = default(bool?), bool? stoppedAtUnsupportedRound = default(bool?), long? timeSinceLastRound = default, string lastCatchpoint = default(string), string catchpoint = default(string), long? catchpointTotalAccounts = default, long? catchpointProcessedAccounts = default, long? catchpointTotalBlocks = default, long? catchpointAcquiredBlocks = default)
        {
            // to ensure "catchupTime" is required (not null)
            if (catchupTime == null)
            {
                throw new InvalidDataException("catchupTime is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.CatchupTime = catchupTime;
            }
            // to ensure "lastRound" is required (not null)
            if (lastRound == null)
            {
                throw new InvalidDataException("lastRound is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.LastRound = lastRound;
            }
            // to ensure "lastVersion" is required (not null)
            if (lastVersion == null)
            {
                throw new InvalidDataException("lastVersion is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.LastVersion = lastVersion;
            }
            // to ensure "nextVersion" is required (not null)
            if (nextVersion == null)
            {
                throw new InvalidDataException("nextVersion is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.NextVersion = nextVersion;
            }
            // to ensure "nextVersionRound" is required (not null)
            if (nextVersionRound == null)
            {
                throw new InvalidDataException("nextVersionRound is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.NextVersionRound = nextVersionRound;
            }
            // to ensure "nextVersionSupported" is required (not null)
            if (nextVersionSupported == null)
            {
                throw new InvalidDataException("nextVersionSupported is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.NextVersionSupported = nextVersionSupported;
            }
            // to ensure "stoppedAtUnsupportedRound" is required (not null)
            if (stoppedAtUnsupportedRound == null)
            {
                throw new InvalidDataException("stoppedAtUnsupportedRound is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.StoppedAtUnsupportedRound = stoppedAtUnsupportedRound;
            }
            // to ensure "timeSinceLastRound" is required (not null)
            if (timeSinceLastRound == null)
            {
                throw new InvalidDataException("timeSinceLastRound is a required property for NodeStatusResponse and cannot be null");
            }
            else
            {
                this.TimeSinceLastRound = timeSinceLastRound;
            }
            this.LastCatchpoint = lastCatchpoint;
            this.Catchpoint = catchpoint;
            this.CatchpointTotalAccounts = catchpointTotalAccounts;
            this.CatchpointProcessedAccounts = catchpointProcessedAccounts;
            this.CatchpointTotalBlocks = catchpointTotalBlocks;
            this.CatchpointAcquiredBlocks = catchpointAcquiredBlocks;
        }
        
        /// <summary>
        /// CatchupTime in nanoseconds
        /// </summary>
        /// <value>CatchupTime in nanoseconds</value>
        [DataMember(Name="catchup-time", EmitDefaultValue=false)]
        public long? CatchupTime { get; set; }

        /// <summary>
        /// LastRound indicates the last round seen
        /// </summary>
        /// <value>LastRound indicates the last round seen</value>
        [DataMember(Name="last-round", EmitDefaultValue=false)]
        public long? LastRound { get; set; }

        /// <summary>
        /// LastVersion indicates the last consensus version supported
        /// </summary>
        /// <value>LastVersion indicates the last consensus version supported</value>
        [DataMember(Name="last-version", EmitDefaultValue=false)]
        public string LastVersion { get; set; }

        /// <summary>
        /// NextVersion of consensus protocol to use
        /// </summary>
        /// <value>NextVersion of consensus protocol to use</value>
        [DataMember(Name="next-version", EmitDefaultValue=false)]
        public string NextVersion { get; set; }

        /// <summary>
        /// NextVersionRound is the round at which the next consensus version will apply
        /// </summary>
        /// <value>NextVersionRound is the round at which the next consensus version will apply</value>
        [DataMember(Name="next-version-round", EmitDefaultValue=false)]
        public long? NextVersionRound { get; set; }

        /// <summary>
        /// NextVersionSupported indicates whether the next consensus version is supported by this node
        /// </summary>
        /// <value>NextVersionSupported indicates whether the next consensus version is supported by this node</value>
        [DataMember(Name="next-version-supported", EmitDefaultValue=false)]
        public bool? NextVersionSupported { get; set; }

        /// <summary>
        /// StoppedAtUnsupportedRound indicates that the node does not support the new rounds and has stopped making progress
        /// </summary>
        /// <value>StoppedAtUnsupportedRound indicates that the node does not support the new rounds and has stopped making progress</value>
        [DataMember(Name="stopped-at-unsupported-round", EmitDefaultValue=false)]
        public bool? StoppedAtUnsupportedRound { get; set; }

        /// <summary>
        /// TimeSinceLastRound in nanoseconds
        /// </summary>
        /// <value>TimeSinceLastRound in nanoseconds</value>
        [DataMember(Name="time-since-last-round", EmitDefaultValue=false)]
        public long? TimeSinceLastRound { get; set; }

        /// <summary>
        /// The last catchpoint seen by the node
        /// </summary>
        /// <value>The last catchpoint seen by the node</value>
        [DataMember(Name="last-catchpoint", EmitDefaultValue=false)]
        public string LastCatchpoint { get; set; }

        /// <summary>
        /// The current catchpoint that is being caught up to
        /// </summary>
        /// <value>The current catchpoint that is being caught up to</value>
        [DataMember(Name="catchpoint", EmitDefaultValue=false)]
        public string Catchpoint { get; set; }

        /// <summary>
        /// The total number of accounts included in the current catchpoint
        /// </summary>
        /// <value>The total number of accounts included in the current catchpoint</value>
        [DataMember(Name="catchpoint-total-accounts", EmitDefaultValue=false)]
        public long? CatchpointTotalAccounts { get; set; }

        /// <summary>
        /// The number of account from the current catchpoint that have been processed so far as part of the catchup
        /// </summary>
        /// <value>The number of account from the current catchpoint that have been processed so far as part of the catchup</value>
        [DataMember(Name="catchpoint-processed-accounts", EmitDefaultValue=false)]
        public long? CatchpointProcessedAccounts { get; set; }

        /// <summary>
        /// The total number of blocks that are required to complete the current catchpoint catchup
        /// </summary>
        /// <value>The total number of blocks that are required to complete the current catchpoint catchup</value>
        [DataMember(Name="catchpoint-total-blocks", EmitDefaultValue=false)]
        public long? CatchpointTotalBlocks { get; set; }

        /// <summary>
        /// The number of blocks that have already been obtained by the node as part of the catchup
        /// </summary>
        /// <value>The number of blocks that have already been obtained by the node as part of the catchup</value>
        [DataMember(Name="catchpoint-acquired-blocks", EmitDefaultValue=false)]
        public long? CatchpointAcquiredBlocks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeStatusResponse {\n");
            sb.Append("  CatchupTime: ").Append(CatchupTime).Append("\n");
            sb.Append("  LastRound: ").Append(LastRound).Append("\n");
            sb.Append("  LastVersion: ").Append(LastVersion).Append("\n");
            sb.Append("  NextVersion: ").Append(NextVersion).Append("\n");
            sb.Append("  NextVersionRound: ").Append(NextVersionRound).Append("\n");
            sb.Append("  NextVersionSupported: ").Append(NextVersionSupported).Append("\n");
            sb.Append("  StoppedAtUnsupportedRound: ").Append(StoppedAtUnsupportedRound).Append("\n");
            sb.Append("  TimeSinceLastRound: ").Append(TimeSinceLastRound).Append("\n");
            sb.Append("  LastCatchpoint: ").Append(LastCatchpoint).Append("\n");
            sb.Append("  Catchpoint: ").Append(Catchpoint).Append("\n");
            sb.Append("  CatchpointTotalAccounts: ").Append(CatchpointTotalAccounts).Append("\n");
            sb.Append("  CatchpointProcessedAccounts: ").Append(CatchpointProcessedAccounts).Append("\n");
            sb.Append("  CatchpointTotalBlocks: ").Append(CatchpointTotalBlocks).Append("\n");
            sb.Append("  CatchpointAcquiredBlocks: ").Append(CatchpointAcquiredBlocks).Append("\n");
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
            return this.Equals(input as NodeStatusResponse);
        }

        /// <summary>
        /// Returns true if NodeStatusResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of NodeStatusResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodeStatusResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatchupTime == input.CatchupTime ||
                    (this.CatchupTime != null &&
                    this.CatchupTime.Equals(input.CatchupTime))
                ) && 
                (
                    this.LastRound == input.LastRound ||
                    (this.LastRound != null &&
                    this.LastRound.Equals(input.LastRound))
                ) && 
                (
                    this.LastVersion == input.LastVersion ||
                    (this.LastVersion != null &&
                    this.LastVersion.Equals(input.LastVersion))
                ) && 
                (
                    this.NextVersion == input.NextVersion ||
                    (this.NextVersion != null &&
                    this.NextVersion.Equals(input.NextVersion))
                ) && 
                (
                    this.NextVersionRound == input.NextVersionRound ||
                    (this.NextVersionRound != null &&
                    this.NextVersionRound.Equals(input.NextVersionRound))
                ) && 
                (
                    this.NextVersionSupported == input.NextVersionSupported ||
                    (this.NextVersionSupported != null &&
                    this.NextVersionSupported.Equals(input.NextVersionSupported))
                ) && 
                (
                    this.StoppedAtUnsupportedRound == input.StoppedAtUnsupportedRound ||
                    (this.StoppedAtUnsupportedRound != null &&
                    this.StoppedAtUnsupportedRound.Equals(input.StoppedAtUnsupportedRound))
                ) && 
                (
                    this.TimeSinceLastRound == input.TimeSinceLastRound ||
                    (this.TimeSinceLastRound != null &&
                    this.TimeSinceLastRound.Equals(input.TimeSinceLastRound))
                ) && 
                (
                    this.LastCatchpoint == input.LastCatchpoint ||
                    (this.LastCatchpoint != null &&
                    this.LastCatchpoint.Equals(input.LastCatchpoint))
                ) && 
                (
                    this.Catchpoint == input.Catchpoint ||
                    (this.Catchpoint != null &&
                    this.Catchpoint.Equals(input.Catchpoint))
                ) && 
                (
                    this.CatchpointTotalAccounts == input.CatchpointTotalAccounts ||
                    (this.CatchpointTotalAccounts != null &&
                    this.CatchpointTotalAccounts.Equals(input.CatchpointTotalAccounts))
                ) && 
                (
                    this.CatchpointProcessedAccounts == input.CatchpointProcessedAccounts ||
                    (this.CatchpointProcessedAccounts != null &&
                    this.CatchpointProcessedAccounts.Equals(input.CatchpointProcessedAccounts))
                ) && 
                (
                    this.CatchpointTotalBlocks == input.CatchpointTotalBlocks ||
                    (this.CatchpointTotalBlocks != null &&
                    this.CatchpointTotalBlocks.Equals(input.CatchpointTotalBlocks))
                ) && 
                (
                    this.CatchpointAcquiredBlocks == input.CatchpointAcquiredBlocks ||
                    (this.CatchpointAcquiredBlocks != null &&
                    this.CatchpointAcquiredBlocks.Equals(input.CatchpointAcquiredBlocks))
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
                if (this.CatchupTime != null)
                    hashCode = hashCode * 59 + this.CatchupTime.GetHashCode();
                if (this.LastRound != null)
                    hashCode = hashCode * 59 + this.LastRound.GetHashCode();
                if (this.LastVersion != null)
                    hashCode = hashCode * 59 + this.LastVersion.GetHashCode();
                if (this.NextVersion != null)
                    hashCode = hashCode * 59 + this.NextVersion.GetHashCode();
                if (this.NextVersionRound != null)
                    hashCode = hashCode * 59 + this.NextVersionRound.GetHashCode();
                if (this.NextVersionSupported != null)
                    hashCode = hashCode * 59 + this.NextVersionSupported.GetHashCode();
                if (this.StoppedAtUnsupportedRound != null)
                    hashCode = hashCode * 59 + this.StoppedAtUnsupportedRound.GetHashCode();
                if (this.TimeSinceLastRound != null)
                    hashCode = hashCode * 59 + this.TimeSinceLastRound.GetHashCode();
                if (this.LastCatchpoint != null)
                    hashCode = hashCode * 59 + this.LastCatchpoint.GetHashCode();
                if (this.Catchpoint != null)
                    hashCode = hashCode * 59 + this.Catchpoint.GetHashCode();
                if (this.CatchpointTotalAccounts != null)
                    hashCode = hashCode * 59 + this.CatchpointTotalAccounts.GetHashCode();
                if (this.CatchpointProcessedAccounts != null)
                    hashCode = hashCode * 59 + this.CatchpointProcessedAccounts.GetHashCode();
                if (this.CatchpointTotalBlocks != null)
                    hashCode = hashCode * 59 + this.CatchpointTotalBlocks.GetHashCode();
                if (this.CatchpointAcquiredBlocks != null)
                    hashCode = hashCode * 59 + this.CatchpointAcquiredBlocks.GetHashCode();
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

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
using SwaggerDateConverter = Algorand.V2.Indexer.Client.SwaggerDateConverter;

namespace Algorand.V2.Indexer.Model
{
    /// <summary>
    /// InlineResponse200
    /// </summary>
    [DataContract]
        public partial class InlineResponse200 :  IEquatable<InlineResponse200>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse200" /> class.
        /// </summary>
        /// <param name="accounts">accounts (required).</param>
        /// <param name="currentRound">Round at which the results were computed. (required).</param>
        /// <param name="nextToken">Used for pagination, when making another request provide this token with the next parameter..</param>
        public InlineResponse200(List<Account> accounts = default(List<Account>), int? currentRound = default(int?), string nextToken = default(string))
        {
            // to ensure "accounts" is required (not null)
            if (accounts == null)
            {
                throw new InvalidDataException("accounts is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.Accounts = accounts;
            }
            // to ensure "currentRound" is required (not null)
            if (currentRound == null)
            {
                throw new InvalidDataException("currentRound is a required property for InlineResponse200 and cannot be null");
            }
            else
            {
                this.CurrentRound = currentRound;
            }
            this.NextToken = nextToken;
        }
        
        /// <summary>
        /// Gets or Sets Accounts
        /// </summary>
        [DataMember(Name="accounts", EmitDefaultValue=false)]
        public List<Account> Accounts { get; set; }

        /// <summary>
        /// Round at which the results were computed.
        /// </summary>
        /// <value>Round at which the results were computed.</value>
        [DataMember(Name="current-round", EmitDefaultValue=false)]
        public int? CurrentRound { get; set; }

        /// <summary>
        /// Used for pagination, when making another request provide this token with the next parameter.
        /// </summary>
        /// <value>Used for pagination, when making another request provide this token with the next parameter.</value>
        [DataMember(Name="next-token", EmitDefaultValue=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse200 {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  CurrentRound: ").Append(CurrentRound).Append("\n");
            sb.Append("  NextToken: ").Append(NextToken).Append("\n");
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
            return this.Equals(input as InlineResponse200);
        }

        /// <summary>
        /// Returns true if InlineResponse200 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse200 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse200 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.CurrentRound == input.CurrentRound ||
                    (this.CurrentRound != null &&
                    this.CurrentRound.Equals(input.CurrentRound))
                ) && 
                (
                    this.NextToken == input.NextToken ||
                    (this.NextToken != null &&
                    this.NextToken.Equals(input.NextToken))
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
                if (this.Accounts != null)
                    hashCode = hashCode * 59 + this.Accounts.GetHashCode();
                if (this.CurrentRound != null)
                    hashCode = hashCode * 59 + this.CurrentRound.GetHashCode();
                if (this.NextToken != null)
                    hashCode = hashCode * 59 + this.NextToken.GetHashCode();
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
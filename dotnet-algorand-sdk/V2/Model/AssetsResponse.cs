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
    /// AssetsResponse
    /// </summary>
    [DataContract]
        public partial class AssetsResponse :  IEquatable<AssetsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetsResponse" /> class.
        /// </summary>
        /// <param name="assets">assets (required).</param>
        /// <param name="currentRound">Round at which the results were computed. (required).</param>
        /// <param name="nextToken">Used for pagination, when making another request provide this token with the next parameter..</param>
        public AssetsResponse(List<Asset> assets = default(List<Asset>), long? currentRound = default, string nextToken = default(string))
        {
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new InvalidDataException("assets is a required property for AssetsResponse and cannot be null");
            }
            else
            {
                this.Assets = assets;
            }
            // to ensure "currentRound" is required (not null)
            if (currentRound == null)
            {
                throw new InvalidDataException("currentRound is a required property for AssetsResponse and cannot be null");
            }
            else
            {
                this.CurrentRound = currentRound;
            }
            this.NextToken = nextToken;
        }
        
        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name="assets", EmitDefaultValue=false)]
        public List<Asset> Assets { get; set; }

        /// <summary>
        /// Round at which the results were computed.
        /// </summary>
        /// <value>Round at which the results were computed.</value>
        [DataMember(Name="current-round", EmitDefaultValue=false)]
        public long? CurrentRound { get; set; }

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
            sb.Append("class AssetsResponse {\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
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
            return this.Equals(input as AssetsResponse);
        }

        /// <summary>
        /// Returns true if AssetsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AssetsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssetsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Assets == input.Assets ||
                    this.Assets != null &&
                    input.Assets != null &&
                    this.Assets.SequenceEqual(input.Assets)
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
                if (this.Assets != null)
                    hashCode = hashCode * 59 + this.Assets.GetHashCode();
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

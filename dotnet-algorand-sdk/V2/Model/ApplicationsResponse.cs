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
    /// ApplicationsResponse
    /// </summary>
    [DataContract]
        public partial class ApplicationsResponse :  IEquatable<ApplicationsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsResponse" /> class.
        /// </summary>
        /// <param name="applications">applications (required).</param>
        /// <param name="currentRound">Round at which the results were computed. (required).</param>
        /// <param name="nextToken">Used for pagination, when making another request provide this token with the next parameter..</param>
        public ApplicationsResponse(List<Application> applications = default(List<Application>), long? currentRound = default, string nextToken = default(string))
        {
            // to ensure "applications" is required (not null)
            if (applications == null)
            {
                throw new InvalidDataException("applications is a required property for ApplicationsResponse and cannot be null");
            }
            else
            {
                this.Applications = applications;
            }
            // to ensure "currentRound" is required (not null)
            if (currentRound == null)
            {
                throw new InvalidDataException("currentRound is a required property for ApplicationsResponse and cannot be null");
            }
            else
            {
                this.CurrentRound = currentRound;
            }
            this.NextToken = nextToken;
        }
        
        /// <summary>
        /// Gets or Sets Applications
        /// </summary>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public List<Application> Applications { get; set; }

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
            sb.Append("class ApplicationsResponse {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
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
            return this.Equals(input as ApplicationsResponse);
        }

        /// <summary>
        /// Returns true if ApplicationsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applications == input.Applications ||
                    this.Applications != null &&
                    input.Applications != null &&
                    this.Applications.SequenceEqual(input.Applications)
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
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
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

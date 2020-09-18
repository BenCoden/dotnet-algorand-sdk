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
    /// Specifies both the unique identifier and the parameters for an asset
    /// </summary>
    [DataContract]
    public partial class Asset :  IEquatable<Asset>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Asset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="index">unique asset identifier (required).</param>
        /// <param name="_params">_params (required).</param>
        public Asset(long? index = default, AssetParams _params = default(AssetParams))
        {
            // to ensure "index" is required (not null)
            if (index == null)
            {
                throw new InvalidDataException("index is a required property for Asset and cannot be null");
            }
            else
            {
                this.Index = index;
            }
            // to ensure "_params" is required (not null)
            if (_params == null)
            {
                throw new InvalidDataException("_params is a required property for Asset and cannot be null");
            }
            else
            {
                this.Params = _params;
            }
        }
        
        /// <summary>
        /// unique asset identifier
        /// </summary>
        /// <value>unique asset identifier</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public long? Index { get; set; }

        /// <summary>
        /// Gets or Sets Params
        /// </summary>
        [DataMember(Name="params", EmitDefaultValue=false)]
        public AssetParams Params { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
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
            return this.Equals(input as Asset);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="input">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Index == input.Index ||
                    (this.Index != null &&
                    this.Index.Equals(input.Index))
                ) && 
                (
                    this.Params == input.Params ||
                    (this.Params != null &&
                    this.Params.Equals(input.Params))
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
                if (this.Index != null)
                    hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
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

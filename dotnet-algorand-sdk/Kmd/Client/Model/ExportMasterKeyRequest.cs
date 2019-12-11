/* 
 * for KMD HTTP API
 *
 * API for KMD (Key Management Daemon)
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
using SwaggerDateConverter = Algorand.Kmd.Client.SwaggerDateConverter;

namespace Algorand.Kmd.Client.Model
{
    /// <summary>
    /// APIV1POSTMasterKeyExportRequest is the request for &#x60;POST /v1/master_key/export&#x60;
    /// </summary>
    [DataContract]
        public partial class ExportMasterKeyRequest :  IEquatable<ExportMasterKeyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportMasterKeyRequest" /> class.
        /// </summary>
        /// <param name="walletHandleToken">walletHandleToken.</param>
        /// <param name="walletPassword">walletPassword.</param>
        public ExportMasterKeyRequest(string walletHandleToken = default(string), string walletPassword = default(string))
        {
            this.WalletHandleToken = walletHandleToken;
            this.WalletPassword = walletPassword;
        }
        
        /// <summary>
        /// Gets or Sets WalletHandleToken
        /// </summary>
        [DataMember(Name="wallet_handle_token", EmitDefaultValue=false)]
        public string WalletHandleToken { get; set; }

        /// <summary>
        /// Gets or Sets WalletPassword
        /// </summary>
        [DataMember(Name="wallet_password", EmitDefaultValue=false)]
        public string WalletPassword { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportMasterKeyRequest {\n");
            sb.Append("  WalletHandleToken: ").Append(WalletHandleToken).Append("\n");
            sb.Append("  WalletPassword: ").Append(WalletPassword).Append("\n");
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
            return this.Equals(input as ExportMasterKeyRequest);
        }

        /// <summary>
        /// Returns true if ExportMasterKeyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportMasterKeyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportMasterKeyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WalletHandleToken == input.WalletHandleToken ||
                    (this.WalletHandleToken != null &&
                    this.WalletHandleToken.Equals(input.WalletHandleToken))
                ) && 
                (
                    this.WalletPassword == input.WalletPassword ||
                    (this.WalletPassword != null &&
                    this.WalletPassword.Equals(input.WalletPassword))
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
                if (this.WalletHandleToken != null)
                    hashCode = hashCode * 59 + this.WalletHandleToken.GetHashCode();
                if (this.WalletPassword != null)
                    hashCode = hashCode * 59 + this.WalletPassword.GetHashCode();
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

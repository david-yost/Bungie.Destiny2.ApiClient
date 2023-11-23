/*
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.18.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ApplicationsApiUsage
    /// </summary>
    [DataContract(Name = "Applications.ApiUsage")]
    public partial class ApplicationsApiUsage : IEquatable<ApplicationsApiUsage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationsApiUsage" /> class.
        /// </summary>
        /// <param name="apiCalls">Counts for on API calls made for the time range..</param>
        /// <param name="throttledRequests">Instances of blocked requests or requests that crossed the warn threshold during the time range..</param>
        public ApplicationsApiUsage(List<ApplicationsSeries> apiCalls = default(List<ApplicationsSeries>), List<ApplicationsSeries> throttledRequests = default(List<ApplicationsSeries>))
        {
            this.ApiCalls = apiCalls;
            this.ThrottledRequests = throttledRequests;
        }

        /// <summary>
        /// Counts for on API calls made for the time range.
        /// </summary>
        /// <value>Counts for on API calls made for the time range.</value>
        [DataMember(Name = "apiCalls", EmitDefaultValue = false)]
        public List<ApplicationsSeries> ApiCalls { get; set; }

        /// <summary>
        /// Instances of blocked requests or requests that crossed the warn threshold during the time range.
        /// </summary>
        /// <value>Instances of blocked requests or requests that crossed the warn threshold during the time range.</value>
        [DataMember(Name = "throttledRequests", EmitDefaultValue = false)]
        public List<ApplicationsSeries> ThrottledRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationsApiUsage {\n");
            sb.Append("  ApiCalls: ").Append(ApiCalls).Append("\n");
            sb.Append("  ThrottledRequests: ").Append(ThrottledRequests).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplicationsApiUsage);
        }

        /// <summary>
        /// Returns true if ApplicationsApiUsage instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationsApiUsage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationsApiUsage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiCalls == input.ApiCalls ||
                    this.ApiCalls != null &&
                    input.ApiCalls != null &&
                    this.ApiCalls.SequenceEqual(input.ApiCalls)
                ) && 
                (
                    this.ThrottledRequests == input.ThrottledRequests ||
                    this.ThrottledRequests != null &&
                    input.ThrottledRequests != null &&
                    this.ThrottledRequests.SequenceEqual(input.ThrottledRequests)
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
                if (this.ApiCalls != null)
                {
                    hashCode = (hashCode * 59) + this.ApiCalls.GetHashCode();
                }
                if (this.ThrottledRequests != null)
                {
                    hashCode = (hashCode * 59) + this.ThrottledRequests.GetHashCode();
                }
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

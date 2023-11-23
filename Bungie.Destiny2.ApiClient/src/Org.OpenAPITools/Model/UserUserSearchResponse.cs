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
    /// UserUserSearchResponse
    /// </summary>
    [DataContract(Name = "User.UserSearchResponse")]
    public partial class UserUserSearchResponse : IEquatable<UserUserSearchResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUserSearchResponse" /> class.
        /// </summary>
        /// <param name="searchResults">searchResults.</param>
        /// <param name="page">page.</param>
        /// <param name="hasMore">hasMore.</param>
        public UserUserSearchResponse(List<UserUserSearchResponseDetail> searchResults = default(List<UserUserSearchResponseDetail>), int page = default(int), bool hasMore = default(bool))
        {
            this.SearchResults = searchResults;
            this.Page = page;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Gets or Sets SearchResults
        /// </summary>
        [DataMember(Name = "searchResults", EmitDefaultValue = false)]
        public List<UserUserSearchResponseDetail> SearchResults { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name = "hasMore", EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserUserSearchResponse {\n");
            sb.Append("  SearchResults: ").Append(SearchResults).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
            return this.Equals(input as UserUserSearchResponse);
        }

        /// <summary>
        /// Returns true if UserUserSearchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUserSearchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUserSearchResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SearchResults == input.SearchResults ||
                    this.SearchResults != null &&
                    input.SearchResults != null &&
                    this.SearchResults.SequenceEqual(input.SearchResults)
                ) && 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    this.HasMore.Equals(input.HasMore)
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
                if (this.SearchResults != null)
                {
                    hashCode = (hashCode * 59) + this.SearchResults.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.HasMore.GetHashCode();
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
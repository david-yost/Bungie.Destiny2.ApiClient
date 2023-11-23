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
    /// The results of a search for Destiny content. This will be improved on over time, I&#39;ve been doing some experimenting to see what might be useful.
    /// </summary>
    [DataContract(Name = "Destiny.Definitions.DestinyEntitySearchResult")]
    public partial class DestinyDefinitionsDestinyEntitySearchResult : IEquatable<DestinyDefinitionsDestinyEntitySearchResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyEntitySearchResult" /> class.
        /// </summary>
        /// <param name="suggestedWords">A list of suggested words that might make for better search results, based on the text searched for..</param>
        /// <param name="results">results.</param>
        public DestinyDefinitionsDestinyEntitySearchResult(List<string> suggestedWords = default(List<string>), SearchResultOfDestinyEntitySearchResultItem results = default(SearchResultOfDestinyEntitySearchResultItem))
        {
            this.SuggestedWords = suggestedWords;
            this.Results = results;
        }

        /// <summary>
        /// A list of suggested words that might make for better search results, based on the text searched for.
        /// </summary>
        /// <value>A list of suggested words that might make for better search results, based on the text searched for.</value>
        [DataMember(Name = "suggestedWords", EmitDefaultValue = false)]
        public List<string> SuggestedWords { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public SearchResultOfDestinyEntitySearchResultItem Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyEntitySearchResult {\n");
            sb.Append("  SuggestedWords: ").Append(SuggestedWords).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyEntitySearchResult);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyEntitySearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyEntitySearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyEntitySearchResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SuggestedWords == input.SuggestedWords ||
                    this.SuggestedWords != null &&
                    input.SuggestedWords != null &&
                    this.SuggestedWords.SequenceEqual(input.SuggestedWords)
                ) && 
                (
                    this.Results == input.Results ||
                    (this.Results != null &&
                    this.Results.Equals(input.Results))
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
                if (this.SuggestedWords != null)
                {
                    hashCode = (hashCode * 59) + this.SuggestedWords.GetHashCode();
                }
                if (this.Results != null)
                {
                    hashCode = (hashCode * 59) + this.Results.GetHashCode();
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

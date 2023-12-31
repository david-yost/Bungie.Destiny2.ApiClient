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
    /// TrendingTrendingEntryCommunityCreation
    /// </summary>
    [DataContract(Name = "Trending.TrendingEntryCommunityCreation")]
    public partial class TrendingTrendingEntryCommunityCreation : IEquatable<TrendingTrendingEntryCommunityCreation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrendingTrendingEntryCommunityCreation" /> class.
        /// </summary>
        /// <param name="media">media.</param>
        /// <param name="title">title.</param>
        /// <param name="author">author.</param>
        /// <param name="authorMembershipId">authorMembershipId.</param>
        /// <param name="postId">postId.</param>
        /// <param name="body">body.</param>
        /// <param name="upvotes">upvotes.</param>
        public TrendingTrendingEntryCommunityCreation(string media = default(string), string title = default(string), string author = default(string), long authorMembershipId = default(long), long postId = default(long), string body = default(string), int upvotes = default(int))
        {
            this.Media = media;
            this.Title = title;
            this.Author = author;
            this.AuthorMembershipId = authorMembershipId;
            this.PostId = postId;
            this.Body = body;
            this.Upvotes = upvotes;
        }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name = "media", EmitDefaultValue = false)]
        public string Media { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets AuthorMembershipId
        /// </summary>
        [DataMember(Name = "authorMembershipId", EmitDefaultValue = false)]
        public long AuthorMembershipId { get; set; }

        /// <summary>
        /// Gets or Sets PostId
        /// </summary>
        [DataMember(Name = "postId", EmitDefaultValue = false)]
        public long PostId { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Upvotes
        /// </summary>
        [DataMember(Name = "upvotes", EmitDefaultValue = false)]
        public int Upvotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrendingTrendingEntryCommunityCreation {\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  AuthorMembershipId: ").Append(AuthorMembershipId).Append("\n");
            sb.Append("  PostId: ").Append(PostId).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Upvotes: ").Append(Upvotes).Append("\n");
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
            return this.Equals(input as TrendingTrendingEntryCommunityCreation);
        }

        /// <summary>
        /// Returns true if TrendingTrendingEntryCommunityCreation instances are equal
        /// </summary>
        /// <param name="input">Instance of TrendingTrendingEntryCommunityCreation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrendingTrendingEntryCommunityCreation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.AuthorMembershipId == input.AuthorMembershipId ||
                    this.AuthorMembershipId.Equals(input.AuthorMembershipId)
                ) && 
                (
                    this.PostId == input.PostId ||
                    this.PostId.Equals(input.PostId)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Upvotes == input.Upvotes ||
                    this.Upvotes.Equals(input.Upvotes)
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
                if (this.Media != null)
                {
                    hashCode = (hashCode * 59) + this.Media.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Author != null)
                {
                    hashCode = (hashCode * 59) + this.Author.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AuthorMembershipId.GetHashCode();
                hashCode = (hashCode * 59) + this.PostId.GetHashCode();
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Upvotes.GetHashCode();
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

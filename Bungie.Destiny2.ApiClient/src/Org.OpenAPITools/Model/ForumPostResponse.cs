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
    /// ForumPostResponse
    /// </summary>
    [DataContract(Name = "Forum.PostResponse")]
    public partial class ForumPostResponse : IEquatable<ForumPostResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumPostResponse" /> class.
        /// </summary>
        /// <param name="lastReplyTimestamp">lastReplyTimestamp.</param>
        /// <param name="isPinned">isPinned.</param>
        /// <param name="urlMediaType">urlMediaType.</param>
        /// <param name="thumbnail">thumbnail.</param>
        /// <param name="popularity">popularity.</param>
        /// <param name="isActive">isActive.</param>
        /// <param name="isAnnouncement">isAnnouncement.</param>
        /// <param name="userRating">userRating.</param>
        /// <param name="userHasRated">userHasRated.</param>
        /// <param name="userHasMutedPost">userHasMutedPost.</param>
        /// <param name="latestReplyPostId">latestReplyPostId.</param>
        /// <param name="latestReplyAuthorId">latestReplyAuthorId.</param>
        /// <param name="ignoreStatus">ignoreStatus.</param>
        /// <param name="locale">locale.</param>
        public ForumPostResponse(DateTime lastReplyTimestamp = default(DateTime), bool isPinned = default(bool), int urlMediaType = default(int), string thumbnail = default(string), int popularity = default(int), bool isActive = default(bool), bool isAnnouncement = default(bool), int userRating = default(int), bool userHasRated = default(bool), bool userHasMutedPost = default(bool), long latestReplyPostId = default(long), long latestReplyAuthorId = default(long), IgnoresIgnoreResponse ignoreStatus = default(IgnoresIgnoreResponse), string locale = default(string))
        {
            this.LastReplyTimestamp = lastReplyTimestamp;
            this.IsPinned = isPinned;
            this.UrlMediaType = urlMediaType;
            this.Thumbnail = thumbnail;
            this.Popularity = popularity;
            this.IsActive = isActive;
            this.IsAnnouncement = isAnnouncement;
            this.UserRating = userRating;
            this.UserHasRated = userHasRated;
            this.UserHasMutedPost = userHasMutedPost;
            this.LatestReplyPostId = latestReplyPostId;
            this.LatestReplyAuthorId = latestReplyAuthorId;
            this.IgnoreStatus = ignoreStatus;
            this.Locale = locale;
        }

        /// <summary>
        /// Gets or Sets LastReplyTimestamp
        /// </summary>
        [DataMember(Name = "lastReplyTimestamp", EmitDefaultValue = false)]
        public DateTime LastReplyTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets IsPinned
        /// </summary>
        [DataMember(Name = "IsPinned", EmitDefaultValue = true)]
        public bool IsPinned { get; set; }

        /// <summary>
        /// Gets or Sets UrlMediaType
        /// </summary>
        [DataMember(Name = "urlMediaType", EmitDefaultValue = false)]
        public int UrlMediaType { get; set; }

        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// Gets or Sets Popularity
        /// </summary>
        [DataMember(Name = "popularity", EmitDefaultValue = false)]
        public int Popularity { get; set; }

        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name = "isActive", EmitDefaultValue = true)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets IsAnnouncement
        /// </summary>
        [DataMember(Name = "isAnnouncement", EmitDefaultValue = true)]
        public bool IsAnnouncement { get; set; }

        /// <summary>
        /// Gets or Sets UserRating
        /// </summary>
        [DataMember(Name = "userRating", EmitDefaultValue = false)]
        public int UserRating { get; set; }

        /// <summary>
        /// Gets or Sets UserHasRated
        /// </summary>
        [DataMember(Name = "userHasRated", EmitDefaultValue = true)]
        public bool UserHasRated { get; set; }

        /// <summary>
        /// Gets or Sets UserHasMutedPost
        /// </summary>
        [DataMember(Name = "userHasMutedPost", EmitDefaultValue = true)]
        public bool UserHasMutedPost { get; set; }

        /// <summary>
        /// Gets or Sets LatestReplyPostId
        /// </summary>
        [DataMember(Name = "latestReplyPostId", EmitDefaultValue = false)]
        public long LatestReplyPostId { get; set; }

        /// <summary>
        /// Gets or Sets LatestReplyAuthorId
        /// </summary>
        [DataMember(Name = "latestReplyAuthorId", EmitDefaultValue = false)]
        public long LatestReplyAuthorId { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreStatus
        /// </summary>
        [DataMember(Name = "ignoreStatus", EmitDefaultValue = false)]
        public IgnoresIgnoreResponse IgnoreStatus { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForumPostResponse {\n");
            sb.Append("  LastReplyTimestamp: ").Append(LastReplyTimestamp).Append("\n");
            sb.Append("  IsPinned: ").Append(IsPinned).Append("\n");
            sb.Append("  UrlMediaType: ").Append(UrlMediaType).Append("\n");
            sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  Popularity: ").Append(Popularity).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  IsAnnouncement: ").Append(IsAnnouncement).Append("\n");
            sb.Append("  UserRating: ").Append(UserRating).Append("\n");
            sb.Append("  UserHasRated: ").Append(UserHasRated).Append("\n");
            sb.Append("  UserHasMutedPost: ").Append(UserHasMutedPost).Append("\n");
            sb.Append("  LatestReplyPostId: ").Append(LatestReplyPostId).Append("\n");
            sb.Append("  LatestReplyAuthorId: ").Append(LatestReplyAuthorId).Append("\n");
            sb.Append("  IgnoreStatus: ").Append(IgnoreStatus).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
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
            return this.Equals(input as ForumPostResponse);
        }

        /// <summary>
        /// Returns true if ForumPostResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ForumPostResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForumPostResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LastReplyTimestamp == input.LastReplyTimestamp ||
                    (this.LastReplyTimestamp != null &&
                    this.LastReplyTimestamp.Equals(input.LastReplyTimestamp))
                ) && 
                (
                    this.IsPinned == input.IsPinned ||
                    this.IsPinned.Equals(input.IsPinned)
                ) && 
                (
                    this.UrlMediaType == input.UrlMediaType ||
                    this.UrlMediaType.Equals(input.UrlMediaType)
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.Popularity == input.Popularity ||
                    this.Popularity.Equals(input.Popularity)
                ) && 
                (
                    this.IsActive == input.IsActive ||
                    this.IsActive.Equals(input.IsActive)
                ) && 
                (
                    this.IsAnnouncement == input.IsAnnouncement ||
                    this.IsAnnouncement.Equals(input.IsAnnouncement)
                ) && 
                (
                    this.UserRating == input.UserRating ||
                    this.UserRating.Equals(input.UserRating)
                ) && 
                (
                    this.UserHasRated == input.UserHasRated ||
                    this.UserHasRated.Equals(input.UserHasRated)
                ) && 
                (
                    this.UserHasMutedPost == input.UserHasMutedPost ||
                    this.UserHasMutedPost.Equals(input.UserHasMutedPost)
                ) && 
                (
                    this.LatestReplyPostId == input.LatestReplyPostId ||
                    this.LatestReplyPostId.Equals(input.LatestReplyPostId)
                ) && 
                (
                    this.LatestReplyAuthorId == input.LatestReplyAuthorId ||
                    this.LatestReplyAuthorId.Equals(input.LatestReplyAuthorId)
                ) && 
                (
                    this.IgnoreStatus == input.IgnoreStatus ||
                    (this.IgnoreStatus != null &&
                    this.IgnoreStatus.Equals(input.IgnoreStatus))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
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
                if (this.LastReplyTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.LastReplyTimestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsPinned.GetHashCode();
                hashCode = (hashCode * 59) + this.UrlMediaType.GetHashCode();
                if (this.Thumbnail != null)
                {
                    hashCode = (hashCode * 59) + this.Thumbnail.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Popularity.GetHashCode();
                hashCode = (hashCode * 59) + this.IsActive.GetHashCode();
                hashCode = (hashCode * 59) + this.IsAnnouncement.GetHashCode();
                hashCode = (hashCode * 59) + this.UserRating.GetHashCode();
                hashCode = (hashCode * 59) + this.UserHasRated.GetHashCode();
                hashCode = (hashCode * 59) + this.UserHasMutedPost.GetHashCode();
                hashCode = (hashCode * 59) + this.LatestReplyPostId.GetHashCode();
                hashCode = (hashCode * 59) + this.LatestReplyAuthorId.GetHashCode();
                if (this.IgnoreStatus != null)
                {
                    hashCode = (hashCode * 59) + this.IgnoreStatus.GetHashCode();
                }
                if (this.Locale != null)
                {
                    hashCode = (hashCode * 59) + this.Locale.GetHashCode();
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

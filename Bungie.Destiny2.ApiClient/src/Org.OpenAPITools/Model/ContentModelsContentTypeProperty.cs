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
    /// ContentModelsContentTypeProperty
    /// </summary>
    [DataContract(Name = "Content.Models.ContentTypeProperty")]
    public partial class ContentModelsContentTypeProperty : IEquatable<ContentModelsContentTypeProperty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentModelsContentTypeProperty" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="rootPropertyName">rootPropertyName.</param>
        /// <param name="readableName">readableName.</param>
        /// <param name="value">value.</param>
        /// <param name="propertyDescription">propertyDescription.</param>
        /// <param name="localizable">localizable.</param>
        /// <param name="fallback">fallback.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="order">order.</param>
        /// <param name="visible">visible.</param>
        /// <param name="isTitle">isTitle.</param>
        /// <param name="required">required.</param>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="maxByteLength">maxByteLength.</param>
        /// <param name="maxFileSize">maxFileSize.</param>
        /// <param name="regexp">regexp.</param>
        /// <param name="validateAs">validateAs.</param>
        /// <param name="rssAttribute">rssAttribute.</param>
        /// <param name="visibleDependency">visibleDependency.</param>
        /// <param name="visibleOn">visibleOn.</param>
        /// <param name="datatype">datatype.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="childProperties">childProperties.</param>
        /// <param name="contentTypeAllowed">contentTypeAllowed.</param>
        /// <param name="bindToProperty">bindToProperty.</param>
        /// <param name="boundRegex">boundRegex.</param>
        /// <param name="representationSelection">representationSelection.</param>
        /// <param name="defaultValues">defaultValues.</param>
        /// <param name="isExternalAllowed">isExternalAllowed.</param>
        /// <param name="propertySection">propertySection.</param>
        /// <param name="weight">weight.</param>
        /// <param name="entitytype">entitytype.</param>
        /// <param name="isCombo">isCombo.</param>
        /// <param name="suppressProperty">suppressProperty.</param>
        /// <param name="legalContentTypes">legalContentTypes.</param>
        /// <param name="representationValidationString">representationValidationString.</param>
        /// <param name="minWidth">minWidth.</param>
        /// <param name="maxWidth">maxWidth.</param>
        /// <param name="minHeight">minHeight.</param>
        /// <param name="maxHeight">maxHeight.</param>
        /// <param name="isVideo">isVideo.</param>
        /// <param name="isImage">isImage.</param>
        public ContentModelsContentTypeProperty(string name = default(string), string rootPropertyName = default(string), string readableName = default(string), string value = default(string), string propertyDescription = default(string), bool localizable = default(bool), bool fallback = default(bool), bool enabled = default(bool), int order = default(int), bool visible = default(bool), bool isTitle = default(bool), bool required = default(bool), int maxLength = default(int), int maxByteLength = default(int), int maxFileSize = default(int), string regexp = default(string), string validateAs = default(string), string rssAttribute = default(string), string visibleDependency = default(string), string visibleOn = default(string), int datatype = default(int), Dictionary<string, string> attributes = default(Dictionary<string, string>), List<ContentModelsContentTypeProperty> childProperties = default(List<ContentModelsContentTypeProperty>), string contentTypeAllowed = default(string), string bindToProperty = default(string), string boundRegex = default(string), Dictionary<string, string> representationSelection = default(Dictionary<string, string>), List<ContentModelsContentTypeDefaultValue> defaultValues = default(List<ContentModelsContentTypeDefaultValue>), bool isExternalAllowed = default(bool), string propertySection = default(string), int weight = default(int), string entitytype = default(string), bool isCombo = default(bool), bool suppressProperty = default(bool), List<string> legalContentTypes = default(List<string>), string representationValidationString = default(string), int minWidth = default(int), int maxWidth = default(int), int minHeight = default(int), int maxHeight = default(int), bool isVideo = default(bool), bool isImage = default(bool))
        {
            this.Name = name;
            this.RootPropertyName = rootPropertyName;
            this.ReadableName = readableName;
            this.Value = value;
            this.PropertyDescription = propertyDescription;
            this.Localizable = localizable;
            this.Fallback = fallback;
            this.Enabled = enabled;
            this.Order = order;
            this.Visible = visible;
            this.IsTitle = isTitle;
            this.Required = required;
            this.MaxLength = maxLength;
            this.MaxByteLength = maxByteLength;
            this.MaxFileSize = maxFileSize;
            this.Regexp = regexp;
            this.ValidateAs = validateAs;
            this.RssAttribute = rssAttribute;
            this.VisibleDependency = visibleDependency;
            this.VisibleOn = visibleOn;
            this.Datatype = datatype;
            this.Attributes = attributes;
            this.ChildProperties = childProperties;
            this.ContentTypeAllowed = contentTypeAllowed;
            this.BindToProperty = bindToProperty;
            this.BoundRegex = boundRegex;
            this.RepresentationSelection = representationSelection;
            this.DefaultValues = defaultValues;
            this.IsExternalAllowed = isExternalAllowed;
            this.PropertySection = propertySection;
            this.Weight = weight;
            this.Entitytype = entitytype;
            this.IsCombo = isCombo;
            this.SuppressProperty = suppressProperty;
            this.LegalContentTypes = legalContentTypes;
            this.RepresentationValidationString = representationValidationString;
            this.MinWidth = minWidth;
            this.MaxWidth = maxWidth;
            this.MinHeight = minHeight;
            this.MaxHeight = maxHeight;
            this.IsVideo = isVideo;
            this.IsImage = isImage;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RootPropertyName
        /// </summary>
        [DataMember(Name = "rootPropertyName", EmitDefaultValue = false)]
        public string RootPropertyName { get; set; }

        /// <summary>
        /// Gets or Sets ReadableName
        /// </summary>
        [DataMember(Name = "readableName", EmitDefaultValue = false)]
        public string ReadableName { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets PropertyDescription
        /// </summary>
        [DataMember(Name = "propertyDescription", EmitDefaultValue = false)]
        public string PropertyDescription { get; set; }

        /// <summary>
        /// Gets or Sets Localizable
        /// </summary>
        [DataMember(Name = "localizable", EmitDefaultValue = true)]
        public bool Localizable { get; set; }

        /// <summary>
        /// Gets or Sets Fallback
        /// </summary>
        [DataMember(Name = "fallback", EmitDefaultValue = true)]
        public bool Fallback { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// Gets or Sets IsTitle
        /// </summary>
        [DataMember(Name = "isTitle", EmitDefaultValue = true)]
        public bool IsTitle { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets MaxByteLength
        /// </summary>
        [DataMember(Name = "maxByteLength", EmitDefaultValue = false)]
        public int MaxByteLength { get; set; }

        /// <summary>
        /// Gets or Sets MaxFileSize
        /// </summary>
        [DataMember(Name = "maxFileSize", EmitDefaultValue = false)]
        public int MaxFileSize { get; set; }

        /// <summary>
        /// Gets or Sets Regexp
        /// </summary>
        [DataMember(Name = "regexp", EmitDefaultValue = false)]
        public string Regexp { get; set; }

        /// <summary>
        /// Gets or Sets ValidateAs
        /// </summary>
        [DataMember(Name = "validateAs", EmitDefaultValue = false)]
        public string ValidateAs { get; set; }

        /// <summary>
        /// Gets or Sets RssAttribute
        /// </summary>
        [DataMember(Name = "rssAttribute", EmitDefaultValue = false)]
        public string RssAttribute { get; set; }

        /// <summary>
        /// Gets or Sets VisibleDependency
        /// </summary>
        [DataMember(Name = "visibleDependency", EmitDefaultValue = false)]
        public string VisibleDependency { get; set; }

        /// <summary>
        /// Gets or Sets VisibleOn
        /// </summary>
        [DataMember(Name = "visibleOn", EmitDefaultValue = false)]
        public string VisibleOn { get; set; }

        /// <summary>
        /// Gets or Sets Datatype
        /// </summary>
        [DataMember(Name = "datatype", EmitDefaultValue = false)]
        public int Datatype { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name = "attributes", EmitDefaultValue = false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets ChildProperties
        /// </summary>
        [DataMember(Name = "childProperties", EmitDefaultValue = false)]
        public List<ContentModelsContentTypeProperty> ChildProperties { get; set; }

        /// <summary>
        /// Gets or Sets ContentTypeAllowed
        /// </summary>
        [DataMember(Name = "contentTypeAllowed", EmitDefaultValue = false)]
        public string ContentTypeAllowed { get; set; }

        /// <summary>
        /// Gets or Sets BindToProperty
        /// </summary>
        [DataMember(Name = "bindToProperty", EmitDefaultValue = false)]
        public string BindToProperty { get; set; }

        /// <summary>
        /// Gets or Sets BoundRegex
        /// </summary>
        [DataMember(Name = "boundRegex", EmitDefaultValue = false)]
        public string BoundRegex { get; set; }

        /// <summary>
        /// Gets or Sets RepresentationSelection
        /// </summary>
        [DataMember(Name = "representationSelection", EmitDefaultValue = false)]
        public Dictionary<string, string> RepresentationSelection { get; set; }

        /// <summary>
        /// Gets or Sets DefaultValues
        /// </summary>
        [DataMember(Name = "defaultValues", EmitDefaultValue = false)]
        public List<ContentModelsContentTypeDefaultValue> DefaultValues { get; set; }

        /// <summary>
        /// Gets or Sets IsExternalAllowed
        /// </summary>
        [DataMember(Name = "isExternalAllowed", EmitDefaultValue = true)]
        public bool IsExternalAllowed { get; set; }

        /// <summary>
        /// Gets or Sets PropertySection
        /// </summary>
        [DataMember(Name = "propertySection", EmitDefaultValue = false)]
        public string PropertySection { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public int Weight { get; set; }

        /// <summary>
        /// Gets or Sets Entitytype
        /// </summary>
        [DataMember(Name = "entitytype", EmitDefaultValue = false)]
        public string Entitytype { get; set; }

        /// <summary>
        /// Gets or Sets IsCombo
        /// </summary>
        [DataMember(Name = "isCombo", EmitDefaultValue = true)]
        public bool IsCombo { get; set; }

        /// <summary>
        /// Gets or Sets SuppressProperty
        /// </summary>
        [DataMember(Name = "suppressProperty", EmitDefaultValue = true)]
        public bool SuppressProperty { get; set; }

        /// <summary>
        /// Gets or Sets LegalContentTypes
        /// </summary>
        [DataMember(Name = "legalContentTypes", EmitDefaultValue = false)]
        public List<string> LegalContentTypes { get; set; }

        /// <summary>
        /// Gets or Sets RepresentationValidationString
        /// </summary>
        [DataMember(Name = "representationValidationString", EmitDefaultValue = false)]
        public string RepresentationValidationString { get; set; }

        /// <summary>
        /// Gets or Sets MinWidth
        /// </summary>
        [DataMember(Name = "minWidth", EmitDefaultValue = false)]
        public int MinWidth { get; set; }

        /// <summary>
        /// Gets or Sets MaxWidth
        /// </summary>
        [DataMember(Name = "maxWidth", EmitDefaultValue = false)]
        public int MaxWidth { get; set; }

        /// <summary>
        /// Gets or Sets MinHeight
        /// </summary>
        [DataMember(Name = "minHeight", EmitDefaultValue = false)]
        public int MinHeight { get; set; }

        /// <summary>
        /// Gets or Sets MaxHeight
        /// </summary>
        [DataMember(Name = "maxHeight", EmitDefaultValue = false)]
        public int MaxHeight { get; set; }

        /// <summary>
        /// Gets or Sets IsVideo
        /// </summary>
        [DataMember(Name = "isVideo", EmitDefaultValue = true)]
        public bool IsVideo { get; set; }

        /// <summary>
        /// Gets or Sets IsImage
        /// </summary>
        [DataMember(Name = "isImage", EmitDefaultValue = true)]
        public bool IsImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContentModelsContentTypeProperty {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RootPropertyName: ").Append(RootPropertyName).Append("\n");
            sb.Append("  ReadableName: ").Append(ReadableName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  PropertyDescription: ").Append(PropertyDescription).Append("\n");
            sb.Append("  Localizable: ").Append(Localizable).Append("\n");
            sb.Append("  Fallback: ").Append(Fallback).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  IsTitle: ").Append(IsTitle).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MaxByteLength: ").Append(MaxByteLength).Append("\n");
            sb.Append("  MaxFileSize: ").Append(MaxFileSize).Append("\n");
            sb.Append("  Regexp: ").Append(Regexp).Append("\n");
            sb.Append("  ValidateAs: ").Append(ValidateAs).Append("\n");
            sb.Append("  RssAttribute: ").Append(RssAttribute).Append("\n");
            sb.Append("  VisibleDependency: ").Append(VisibleDependency).Append("\n");
            sb.Append("  VisibleOn: ").Append(VisibleOn).Append("\n");
            sb.Append("  Datatype: ").Append(Datatype).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ChildProperties: ").Append(ChildProperties).Append("\n");
            sb.Append("  ContentTypeAllowed: ").Append(ContentTypeAllowed).Append("\n");
            sb.Append("  BindToProperty: ").Append(BindToProperty).Append("\n");
            sb.Append("  BoundRegex: ").Append(BoundRegex).Append("\n");
            sb.Append("  RepresentationSelection: ").Append(RepresentationSelection).Append("\n");
            sb.Append("  DefaultValues: ").Append(DefaultValues).Append("\n");
            sb.Append("  IsExternalAllowed: ").Append(IsExternalAllowed).Append("\n");
            sb.Append("  PropertySection: ").Append(PropertySection).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Entitytype: ").Append(Entitytype).Append("\n");
            sb.Append("  IsCombo: ").Append(IsCombo).Append("\n");
            sb.Append("  SuppressProperty: ").Append(SuppressProperty).Append("\n");
            sb.Append("  LegalContentTypes: ").Append(LegalContentTypes).Append("\n");
            sb.Append("  RepresentationValidationString: ").Append(RepresentationValidationString).Append("\n");
            sb.Append("  MinWidth: ").Append(MinWidth).Append("\n");
            sb.Append("  MaxWidth: ").Append(MaxWidth).Append("\n");
            sb.Append("  MinHeight: ").Append(MinHeight).Append("\n");
            sb.Append("  MaxHeight: ").Append(MaxHeight).Append("\n");
            sb.Append("  IsVideo: ").Append(IsVideo).Append("\n");
            sb.Append("  IsImage: ").Append(IsImage).Append("\n");
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
            return this.Equals(input as ContentModelsContentTypeProperty);
        }

        /// <summary>
        /// Returns true if ContentModelsContentTypeProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of ContentModelsContentTypeProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentModelsContentTypeProperty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RootPropertyName == input.RootPropertyName ||
                    (this.RootPropertyName != null &&
                    this.RootPropertyName.Equals(input.RootPropertyName))
                ) && 
                (
                    this.ReadableName == input.ReadableName ||
                    (this.ReadableName != null &&
                    this.ReadableName.Equals(input.ReadableName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.PropertyDescription == input.PropertyDescription ||
                    (this.PropertyDescription != null &&
                    this.PropertyDescription.Equals(input.PropertyDescription))
                ) && 
                (
                    this.Localizable == input.Localizable ||
                    this.Localizable.Equals(input.Localizable)
                ) && 
                (
                    this.Fallback == input.Fallback ||
                    this.Fallback.Equals(input.Fallback)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Visible == input.Visible ||
                    this.Visible.Equals(input.Visible)
                ) && 
                (
                    this.IsTitle == input.IsTitle ||
                    this.IsTitle.Equals(input.IsTitle)
                ) && 
                (
                    this.Required == input.Required ||
                    this.Required.Equals(input.Required)
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    this.MaxLength.Equals(input.MaxLength)
                ) && 
                (
                    this.MaxByteLength == input.MaxByteLength ||
                    this.MaxByteLength.Equals(input.MaxByteLength)
                ) && 
                (
                    this.MaxFileSize == input.MaxFileSize ||
                    this.MaxFileSize.Equals(input.MaxFileSize)
                ) && 
                (
                    this.Regexp == input.Regexp ||
                    (this.Regexp != null &&
                    this.Regexp.Equals(input.Regexp))
                ) && 
                (
                    this.ValidateAs == input.ValidateAs ||
                    (this.ValidateAs != null &&
                    this.ValidateAs.Equals(input.ValidateAs))
                ) && 
                (
                    this.RssAttribute == input.RssAttribute ||
                    (this.RssAttribute != null &&
                    this.RssAttribute.Equals(input.RssAttribute))
                ) && 
                (
                    this.VisibleDependency == input.VisibleDependency ||
                    (this.VisibleDependency != null &&
                    this.VisibleDependency.Equals(input.VisibleDependency))
                ) && 
                (
                    this.VisibleOn == input.VisibleOn ||
                    (this.VisibleOn != null &&
                    this.VisibleOn.Equals(input.VisibleOn))
                ) && 
                (
                    this.Datatype == input.Datatype ||
                    this.Datatype.Equals(input.Datatype)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    input.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.ChildProperties == input.ChildProperties ||
                    this.ChildProperties != null &&
                    input.ChildProperties != null &&
                    this.ChildProperties.SequenceEqual(input.ChildProperties)
                ) && 
                (
                    this.ContentTypeAllowed == input.ContentTypeAllowed ||
                    (this.ContentTypeAllowed != null &&
                    this.ContentTypeAllowed.Equals(input.ContentTypeAllowed))
                ) && 
                (
                    this.BindToProperty == input.BindToProperty ||
                    (this.BindToProperty != null &&
                    this.BindToProperty.Equals(input.BindToProperty))
                ) && 
                (
                    this.BoundRegex == input.BoundRegex ||
                    (this.BoundRegex != null &&
                    this.BoundRegex.Equals(input.BoundRegex))
                ) && 
                (
                    this.RepresentationSelection == input.RepresentationSelection ||
                    this.RepresentationSelection != null &&
                    input.RepresentationSelection != null &&
                    this.RepresentationSelection.SequenceEqual(input.RepresentationSelection)
                ) && 
                (
                    this.DefaultValues == input.DefaultValues ||
                    this.DefaultValues != null &&
                    input.DefaultValues != null &&
                    this.DefaultValues.SequenceEqual(input.DefaultValues)
                ) && 
                (
                    this.IsExternalAllowed == input.IsExternalAllowed ||
                    this.IsExternalAllowed.Equals(input.IsExternalAllowed)
                ) && 
                (
                    this.PropertySection == input.PropertySection ||
                    (this.PropertySection != null &&
                    this.PropertySection.Equals(input.PropertySection))
                ) && 
                (
                    this.Weight == input.Weight ||
                    this.Weight.Equals(input.Weight)
                ) && 
                (
                    this.Entitytype == input.Entitytype ||
                    (this.Entitytype != null &&
                    this.Entitytype.Equals(input.Entitytype))
                ) && 
                (
                    this.IsCombo == input.IsCombo ||
                    this.IsCombo.Equals(input.IsCombo)
                ) && 
                (
                    this.SuppressProperty == input.SuppressProperty ||
                    this.SuppressProperty.Equals(input.SuppressProperty)
                ) && 
                (
                    this.LegalContentTypes == input.LegalContentTypes ||
                    this.LegalContentTypes != null &&
                    input.LegalContentTypes != null &&
                    this.LegalContentTypes.SequenceEqual(input.LegalContentTypes)
                ) && 
                (
                    this.RepresentationValidationString == input.RepresentationValidationString ||
                    (this.RepresentationValidationString != null &&
                    this.RepresentationValidationString.Equals(input.RepresentationValidationString))
                ) && 
                (
                    this.MinWidth == input.MinWidth ||
                    this.MinWidth.Equals(input.MinWidth)
                ) && 
                (
                    this.MaxWidth == input.MaxWidth ||
                    this.MaxWidth.Equals(input.MaxWidth)
                ) && 
                (
                    this.MinHeight == input.MinHeight ||
                    this.MinHeight.Equals(input.MinHeight)
                ) && 
                (
                    this.MaxHeight == input.MaxHeight ||
                    this.MaxHeight.Equals(input.MaxHeight)
                ) && 
                (
                    this.IsVideo == input.IsVideo ||
                    this.IsVideo.Equals(input.IsVideo)
                ) && 
                (
                    this.IsImage == input.IsImage ||
                    this.IsImage.Equals(input.IsImage)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RootPropertyName != null)
                {
                    hashCode = (hashCode * 59) + this.RootPropertyName.GetHashCode();
                }
                if (this.ReadableName != null)
                {
                    hashCode = (hashCode * 59) + this.ReadableName.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.PropertyDescription != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyDescription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Localizable.GetHashCode();
                hashCode = (hashCode * 59) + this.Fallback.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
                hashCode = (hashCode * 59) + this.Visible.GetHashCode();
                hashCode = (hashCode * 59) + this.IsTitle.GetHashCode();
                hashCode = (hashCode * 59) + this.Required.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxLength.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxByteLength.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxFileSize.GetHashCode();
                if (this.Regexp != null)
                {
                    hashCode = (hashCode * 59) + this.Regexp.GetHashCode();
                }
                if (this.ValidateAs != null)
                {
                    hashCode = (hashCode * 59) + this.ValidateAs.GetHashCode();
                }
                if (this.RssAttribute != null)
                {
                    hashCode = (hashCode * 59) + this.RssAttribute.GetHashCode();
                }
                if (this.VisibleDependency != null)
                {
                    hashCode = (hashCode * 59) + this.VisibleDependency.GetHashCode();
                }
                if (this.VisibleOn != null)
                {
                    hashCode = (hashCode * 59) + this.VisibleOn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Datatype.GetHashCode();
                if (this.Attributes != null)
                {
                    hashCode = (hashCode * 59) + this.Attributes.GetHashCode();
                }
                if (this.ChildProperties != null)
                {
                    hashCode = (hashCode * 59) + this.ChildProperties.GetHashCode();
                }
                if (this.ContentTypeAllowed != null)
                {
                    hashCode = (hashCode * 59) + this.ContentTypeAllowed.GetHashCode();
                }
                if (this.BindToProperty != null)
                {
                    hashCode = (hashCode * 59) + this.BindToProperty.GetHashCode();
                }
                if (this.BoundRegex != null)
                {
                    hashCode = (hashCode * 59) + this.BoundRegex.GetHashCode();
                }
                if (this.RepresentationSelection != null)
                {
                    hashCode = (hashCode * 59) + this.RepresentationSelection.GetHashCode();
                }
                if (this.DefaultValues != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultValues.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsExternalAllowed.GetHashCode();
                if (this.PropertySection != null)
                {
                    hashCode = (hashCode * 59) + this.PropertySection.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Weight.GetHashCode();
                if (this.Entitytype != null)
                {
                    hashCode = (hashCode * 59) + this.Entitytype.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsCombo.GetHashCode();
                hashCode = (hashCode * 59) + this.SuppressProperty.GetHashCode();
                if (this.LegalContentTypes != null)
                {
                    hashCode = (hashCode * 59) + this.LegalContentTypes.GetHashCode();
                }
                if (this.RepresentationValidationString != null)
                {
                    hashCode = (hashCode * 59) + this.RepresentationValidationString.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinWidth.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxWidth.GetHashCode();
                hashCode = (hashCode * 59) + this.MinHeight.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxHeight.GetHashCode();
                hashCode = (hashCode * 59) + this.IsVideo.GetHashCode();
                hashCode = (hashCode * 59) + this.IsImage.GetHashCode();
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

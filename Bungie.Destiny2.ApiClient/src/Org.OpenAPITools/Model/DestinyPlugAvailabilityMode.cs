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
    /// This enum determines whether the plug is available to be inserted.  - Normal means that all existing rules for plug insertion apply.  - UnavailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket does NOT match the plug category.  - AvailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket DOES match the plug category.  For category matching, use the plug&#39;s \&quot;plugCategoryIdentifier\&quot; property, comparing it to
    /// </summary>
    /// <value>This enum determines whether the plug is available to be inserted.  - Normal means that all existing rules for plug insertion apply.  - UnavailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket does NOT match the plug category.  - AvailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket DOES match the plug category.  For category matching, use the plug&#39;s \&quot;plugCategoryIdentifier\&quot; property, comparing it to</value>
    public enum DestinyPlugAvailabilityMode
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        NUMBER_2 = 2
    }

}
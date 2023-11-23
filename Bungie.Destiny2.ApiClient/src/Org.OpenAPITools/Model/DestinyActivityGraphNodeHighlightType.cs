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
    /// The various known UI styles in which an item can be highlighted. It&#39;ll be up to you to determine what you want to show based on this highlighting, BNet doesn&#39;t have any assets that correspond to these states. And yeah, RiseOfIron and Comet have their own special highlight states. Don&#39;t ask me, I can&#39;t imagine they&#39;re still used.
    /// </summary>
    /// <value>The various known UI styles in which an item can be highlighted. It&#39;ll be up to you to determine what you want to show based on this highlighting, BNet doesn&#39;t have any assets that correspond to these states. And yeah, RiseOfIron and Comet have their own special highlight states. Don&#39;t ask me, I can&#39;t imagine they&#39;re still used.</value>
    public enum DestinyActivityGraphNodeHighlightType
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
        NUMBER_2 = 2,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        NUMBER_3 = 3,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        NUMBER_4 = 4
    }

}

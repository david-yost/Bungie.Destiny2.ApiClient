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
    /// The possible states of Destiny Profile Records. IMPORTANT: Any given item can theoretically have many of these states simultaneously: as a result, this was altered to be a flags enumeration/bitmask for v3.2.0.
    /// </summary>
    /// <value>The possible states of Destiny Profile Records. IMPORTANT: Any given item can theoretically have many of these states simultaneously: as a result, this was altered to be a flags enumeration/bitmask for v3.2.0.</value>
    public enum DestinyDestinyVendorItemState
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
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        NUMBER_4 = 4,

        /// <summary>
        /// Enum NUMBER_8 for value: 8
        /// </summary>
        NUMBER_8 = 8,

        /// <summary>
        /// Enum NUMBER_16 for value: 16
        /// </summary>
        NUMBER_16 = 16,

        /// <summary>
        /// Enum NUMBER_32 for value: 32
        /// </summary>
        NUMBER_32 = 32,

        /// <summary>
        /// Enum NUMBER_64 for value: 64
        /// </summary>
        NUMBER_64 = 64,

        /// <summary>
        /// Enum NUMBER_128 for value: 128
        /// </summary>
        NUMBER_128 = 128,

        /// <summary>
        /// Enum NUMBER_256 for value: 256
        /// </summary>
        NUMBER_256 = 256,

        /// <summary>
        /// Enum NUMBER_512 for value: 512
        /// </summary>
        NUMBER_512 = 512,

        /// <summary>
        /// Enum NUMBER_1024 for value: 1024
        /// </summary>
        NUMBER_1024 = 1024,

        /// <summary>
        /// Enum NUMBER_2048 for value: 2048
        /// </summary>
        NUMBER_2048 = 2048,

        /// <summary>
        /// Enum NUMBER_4096 for value: 4096
        /// </summary>
        NUMBER_4096 = 4096,

        /// <summary>
        /// Enum NUMBER_8192 for value: 8192
        /// </summary>
        NUMBER_8192 = 8192,

        /// <summary>
        /// Enum NUMBER_16384 for value: 16384
        /// </summary>
        NUMBER_16384 = 16384,

        /// <summary>
        /// Enum NUMBER_32768 for value: 32768
        /// </summary>
        NUMBER_32768 = 32768,

        /// <summary>
        /// Enum NUMBER_65536 for value: 65536
        /// </summary>
        NUMBER_65536 = 65536,

        /// <summary>
        /// Enum NUMBER_131072 for value: 131072
        /// </summary>
        NUMBER_131072 = 131072,

        /// <summary>
        /// Enum NUMBER_262144 for value: 262144
        /// </summary>
        NUMBER_262144 = 262144,

        /// <summary>
        /// Enum NUMBER_524288 for value: 524288
        /// </summary>
        NUMBER_524288 = 524288,

        /// <summary>
        /// Enum NUMBER_1048576 for value: 1048576
        /// </summary>
        NUMBER_1048576 = 1048576
    }

}

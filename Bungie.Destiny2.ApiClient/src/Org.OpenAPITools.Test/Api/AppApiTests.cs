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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing AppApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AppApiTests : IDisposable
    {
        private AppApi instance;

        public AppApiTests()
        {
            instance = new AppApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AppApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AppApi
            //Assert.IsType<AppApi>(instance);
        }

        /// <summary>
        /// Test AppGetApplicationApiUsage
        /// </summary>
        [Fact]
        public void AppGetApplicationApiUsageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int applicationId = null;
            //DateTime? end = null;
            //DateTime? start = null;
            //var response = instance.AppGetApplicationApiUsage(applicationId, end, start);
            //Assert.IsType<AppGetApplicationApiUsage200Response>(response);
        }

        /// <summary>
        /// Test AppGetBungieApplications
        /// </summary>
        [Fact]
        public void AppGetBungieApplicationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AppGetBungieApplications();
            //Assert.IsType<AppGetBungieApplications200Response>(response);
        }
    }
}

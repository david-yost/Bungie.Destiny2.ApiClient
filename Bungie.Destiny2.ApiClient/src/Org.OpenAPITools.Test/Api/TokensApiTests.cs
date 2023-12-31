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
    ///  Class for testing TokensApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TokensApiTests : IDisposable
    {
        private TokensApi instance;

        public TokensApiTests()
        {
            instance = new TokensApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TokensApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TokensApi
            //Assert.IsType<TokensApi>(instance);
        }

        /// <summary>
        /// Test TokensApplyMissingPartnerOffersWithoutClaim
        /// </summary>
        [Fact]
        public void TokensApplyMissingPartnerOffersWithoutClaimTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int partnerApplicationId = null;
            //long targetBnetMembershipId = null;
            //var response = instance.TokensApplyMissingPartnerOffersWithoutClaim(partnerApplicationId, targetBnetMembershipId);
            //Assert.IsType<GroupV2GetUserClanInviteSetting200Response>(response);
        }

        /// <summary>
        /// Test TokensClaimPartnerOffer
        /// </summary>
        [Fact]
        public void TokensClaimPartnerOfferTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TokensPartnerOfferClaimRequest tokensPartnerOfferClaimRequest = null;
            //var response = instance.TokensClaimPartnerOffer(tokensPartnerOfferClaimRequest);
            //Assert.IsType<GroupV2GetUserClanInviteSetting200Response>(response);
        }

        /// <summary>
        /// Test TokensForceDropsRepair
        /// </summary>
        [Fact]
        public void TokensForceDropsRepairTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TokensForceDropsRepair();
            //Assert.IsType<GroupV2GetUserClanInviteSetting200Response>(response);
        }

        /// <summary>
        /// Test TokensGetBungieRewardsForPlatformUser
        /// </summary>
        [Fact]
        public void TokensGetBungieRewardsForPlatformUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long membershipId = null;
            //int membershipType = null;
            //var response = instance.TokensGetBungieRewardsForPlatformUser(membershipId, membershipType);
            //Assert.IsType<TokensGetBungieRewardsForUser200Response>(response);
        }

        /// <summary>
        /// Test TokensGetBungieRewardsForUser
        /// </summary>
        [Fact]
        public void TokensGetBungieRewardsForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long membershipId = null;
            //var response = instance.TokensGetBungieRewardsForUser(membershipId);
            //Assert.IsType<TokensGetBungieRewardsForUser200Response>(response);
        }

        /// <summary>
        /// Test TokensGetBungieRewardsList
        /// </summary>
        [Fact]
        public void TokensGetBungieRewardsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TokensGetBungieRewardsList();
            //Assert.IsType<TokensGetBungieRewardsForUser200Response>(response);
        }

        /// <summary>
        /// Test TokensGetPartnerOfferSkuHistory
        /// </summary>
        [Fact]
        public void TokensGetPartnerOfferSkuHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int partnerApplicationId = null;
            //long targetBnetMembershipId = null;
            //var response = instance.TokensGetPartnerOfferSkuHistory(partnerApplicationId, targetBnetMembershipId);
            //Assert.IsType<TokensGetPartnerOfferSkuHistory200Response>(response);
        }

        /// <summary>
        /// Test TokensGetPartnerRewardHistory
        /// </summary>
        [Fact]
        public void TokensGetPartnerRewardHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int partnerApplicationId = null;
            //long targetBnetMembershipId = null;
            //var response = instance.TokensGetPartnerRewardHistory(partnerApplicationId, targetBnetMembershipId);
            //Assert.IsType<TokensGetPartnerRewardHistory200Response>(response);
        }
    }
}

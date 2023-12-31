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
    ///  Class for testing GroupV2Api
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupV2ApiTests : IDisposable
    {
        private GroupV2Api instance;

        public GroupV2ApiTests()
        {
            instance = new GroupV2Api();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupV2Api
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GroupV2Api
            //Assert.IsType<GroupV2Api>(instance);
        }

        /// <summary>
        /// Test GroupV2AbdicateFoundership
        /// </summary>
        [Fact]
        public void GroupV2AbdicateFoundershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long founderIdNew = null;
            //long groupId = null;
            //int membershipType = null;
            //var response = instance.GroupV2AbdicateFoundership(founderIdNew, groupId, membershipType);
            //Assert.IsType<GroupV2GetUserClanInviteSetting200Response>(response);
        }

        /// <summary>
        /// Test GroupV2AddOptionalConversation
        /// </summary>
        [Fact]
        public void GroupV2AddOptionalConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2GroupOptionalConversationAddRequest groupsV2GroupOptionalConversationAddRequest = null;
            //var response = instance.GroupV2AddOptionalConversation(groupId, groupsV2GroupOptionalConversationAddRequest);
            //Assert.IsType<ForumGetTopicForContent200Response>(response);
        }

        /// <summary>
        /// Test GroupV2ApproveAllPending
        /// </summary>
        [Fact]
        public void GroupV2ApproveAllPendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest = null;
            //var response = instance.GroupV2ApproveAllPending(groupId, groupsV2GroupApplicationRequest);
            //Assert.IsType<GroupV2ApproveAllPending200Response>(response);
        }

        /// <summary>
        /// Test GroupV2ApprovePending
        /// </summary>
        [Fact]
        public void GroupV2ApprovePendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //long membershipId = null;
            //int membershipType = null;
            //GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest = null;
            //var response = instance.GroupV2ApprovePending(groupId, membershipId, membershipType, groupsV2GroupApplicationRequest);
            //Assert.IsType<GroupV2GetUserClanInviteSetting200Response>(response);
        }

        /// <summary>
        /// Test GroupV2ApprovePendingForList
        /// </summary>
        [Fact]
        public void GroupV2ApprovePendingForListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2GroupApplicationListRequest groupsV2GroupApplicationListRequest = null;
            //var response = instance.GroupV2ApprovePendingForList(groupId, groupsV2GroupApplicationListRequest);
            //Assert.IsType<GroupV2ApproveAllPending200Response>(response);
        }

        /// <summary>
        /// Test GroupV2BanMember
        /// </summary>
        [Fact]
        public void GroupV2BanMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //long membershipId = null;
            //int membershipType = null;
            //GroupsV2GroupBanRequest groupsV2GroupBanRequest = null;
            //var response = instance.GroupV2BanMember(groupId, membershipId, membershipType, groupsV2GroupBanRequest);
            //Assert.IsType<GroupV2EditGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2DenyAllPending
        /// </summary>
        [Fact]
        public void GroupV2DenyAllPendingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest = null;
            //var response = instance.GroupV2DenyAllPending(groupId, groupsV2GroupApplicationRequest);
            //Assert.IsType<GroupV2ApproveAllPending200Response>(response);
        }

        /// <summary>
        /// Test GroupV2DenyPendingForList
        /// </summary>
        [Fact]
        public void GroupV2DenyPendingForListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2GroupApplicationListRequest groupsV2GroupApplicationListRequest = null;
            //var response = instance.GroupV2DenyPendingForList(groupId, groupsV2GroupApplicationListRequest);
            //Assert.IsType<GroupV2ApproveAllPending200Response>(response);
        }

        /// <summary>
        /// Test GroupV2EditClanBanner
        /// </summary>
        [Fact]
        public void GroupV2EditClanBannerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2ClanBanner groupsV2ClanBanner = null;
            //var response = instance.GroupV2EditClanBanner(groupId, groupsV2ClanBanner);
            //Assert.IsType<GroupV2EditGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2EditFounderOptions
        /// </summary>
        [Fact]
        public void GroupV2EditFounderOptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2GroupOptionsEditAction groupsV2GroupOptionsEditAction = null;
            //var response = instance.GroupV2EditFounderOptions(groupId, groupsV2GroupOptionsEditAction);
            //Assert.IsType<GroupV2EditGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2EditGroup
        /// </summary>
        [Fact]
        public void GroupV2EditGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //GroupsV2GroupEditAction groupsV2GroupEditAction = null;
            //var response = instance.GroupV2EditGroup(groupId, groupsV2GroupEditAction);
            //Assert.IsType<GroupV2EditGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2EditGroupMembership
        /// </summary>
        [Fact]
        public void GroupV2EditGroupMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //long membershipId = null;
            //int membershipType = null;
            //int memberType = null;
            //var response = instance.GroupV2EditGroupMembership(groupId, membershipId, membershipType, memberType);
            //Assert.IsType<GroupV2EditGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2EditOptionalConversation
        /// </summary>
        [Fact]
        public void GroupV2EditOptionalConversationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long conversationId = null;
            //long groupId = null;
            //GroupsV2GroupOptionalConversationEditRequest groupsV2GroupOptionalConversationEditRequest = null;
            //var response = instance.GroupV2EditOptionalConversation(conversationId, groupId, groupsV2GroupOptionalConversationEditRequest);
            //Assert.IsType<ForumGetTopicForContent200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetAdminsAndFounderOfGroup
        /// </summary>
        [Fact]
        public void GroupV2GetAdminsAndFounderOfGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int currentpage = null;
            //long groupId = null;
            //var response = instance.GroupV2GetAdminsAndFounderOfGroup(currentpage, groupId);
            //Assert.IsType<GroupV2GetMembersOfGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetAvailableAvatars
        /// </summary>
        [Fact]
        public void GroupV2GetAvailableAvatarsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GroupV2GetAvailableAvatars();
            //Assert.IsType<GroupV2GetAvailableAvatars200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetAvailableThemes
        /// </summary>
        [Fact]
        public void GroupV2GetAvailableThemesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GroupV2GetAvailableThemes();
            //Assert.IsType<GroupV2GetAvailableThemes200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetBannedMembersOfGroup
        /// </summary>
        [Fact]
        public void GroupV2GetBannedMembersOfGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int currentpage = null;
            //long groupId = null;
            //var response = instance.GroupV2GetBannedMembersOfGroup(currentpage, groupId);
            //Assert.IsType<GroupV2GetBannedMembersOfGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetGroup
        /// </summary>
        [Fact]
        public void GroupV2GetGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //var response = instance.GroupV2GetGroup(groupId);
            //Assert.IsType<GroupV2GetGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetGroupByName
        /// </summary>
        [Fact]
        public void GroupV2GetGroupByNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string groupName = null;
            //int groupType = null;
            //var response = instance.GroupV2GetGroupByName(groupName, groupType);
            //Assert.IsType<GroupV2GetGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetGroupByNameV2
        /// </summary>
        [Fact]
        public void GroupV2GetGroupByNameV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupsV2GroupNameSearchRequest groupsV2GroupNameSearchRequest = null;
            //var response = instance.GroupV2GetGroupByNameV2(groupsV2GroupNameSearchRequest);
            //Assert.IsType<GroupV2GetGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetGroupOptionalConversations
        /// </summary>
        [Fact]
        public void GroupV2GetGroupOptionalConversationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //var response = instance.GroupV2GetGroupOptionalConversations(groupId);
            //Assert.IsType<GroupV2GetGroupOptionalConversations200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetGroupsForMember
        /// </summary>
        [Fact]
        public void GroupV2GetGroupsForMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int filter = null;
            //int groupType = null;
            //long membershipId = null;
            //int membershipType = null;
            //var response = instance.GroupV2GetGroupsForMember(filter, groupType, membershipId, membershipType);
            //Assert.IsType<GroupV2GetGroupsForMember200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetInvitedIndividuals
        /// </summary>
        [Fact]
        public void GroupV2GetInvitedIndividualsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int currentpage = null;
            //long groupId = null;
            //var response = instance.GroupV2GetInvitedIndividuals(currentpage, groupId);
            //Assert.IsType<GroupV2GetPendingMemberships200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetMembersOfGroup
        /// </summary>
        [Fact]
        public void GroupV2GetMembersOfGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int currentpage = null;
            //long groupId = null;
            //int? memberType = null;
            //string? nameSearch = null;
            //var response = instance.GroupV2GetMembersOfGroup(currentpage, groupId, memberType, nameSearch);
            //Assert.IsType<GroupV2GetMembersOfGroup200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetPendingMemberships
        /// </summary>
        [Fact]
        public void GroupV2GetPendingMembershipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int currentpage = null;
            //long groupId = null;
            //var response = instance.GroupV2GetPendingMemberships(currentpage, groupId);
            //Assert.IsType<GroupV2GetPendingMemberships200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetPotentialGroupsForMember
        /// </summary>
        [Fact]
        public void GroupV2GetPotentialGroupsForMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int filter = null;
            //int groupType = null;
            //long membershipId = null;
            //int membershipType = null;
            //var response = instance.GroupV2GetPotentialGroupsForMember(filter, groupType, membershipId, membershipType);
            //Assert.IsType<GroupV2GetPotentialGroupsForMember200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetRecommendedGroups
        /// </summary>
        [Fact]
        public void GroupV2GetRecommendedGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int createDateRange = null;
            //int groupType = null;
            //var response = instance.GroupV2GetRecommendedGroups(createDateRange, groupType);
            //Assert.IsType<GroupV2GetRecommendedGroups200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GetUserClanInviteSetting
        /// </summary>
        [Fact]
        public void GroupV2GetUserClanInviteSettingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int mType = null;
            //var response = instance.GroupV2GetUserClanInviteSetting(mType);
            //Assert.IsType<GroupV2GetUserClanInviteSetting200Response>(response);
        }

        /// <summary>
        /// Test GroupV2GroupSearch
        /// </summary>
        [Fact]
        public void GroupV2GroupSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GroupsV2GroupQuery groupsV2GroupQuery = null;
            //var response = instance.GroupV2GroupSearch(groupsV2GroupQuery);
            //Assert.IsType<GroupV2GroupSearch200Response>(response);
        }

        /// <summary>
        /// Test GroupV2IndividualGroupInvite
        /// </summary>
        [Fact]
        public void GroupV2IndividualGroupInviteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //long membershipId = null;
            //int membershipType = null;
            //GroupsV2GroupApplicationRequest groupsV2GroupApplicationRequest = null;
            //var response = instance.GroupV2IndividualGroupInvite(groupId, membershipId, membershipType, groupsV2GroupApplicationRequest);
            //Assert.IsType<GroupV2IndividualGroupInvite200Response>(response);
        }

        /// <summary>
        /// Test GroupV2IndividualGroupInviteCancel
        /// </summary>
        [Fact]
        public void GroupV2IndividualGroupInviteCancelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //long membershipId = null;
            //int membershipType = null;
            //var response = instance.GroupV2IndividualGroupInviteCancel(groupId, membershipId, membershipType);
            //Assert.IsType<GroupV2IndividualGroupInvite200Response>(response);
        }

        /// <summary>
        /// Test GroupV2KickMember
        /// </summary>
        [Fact]
        public void GroupV2KickMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //long membershipId = null;
            //int membershipType = null;
            //var response = instance.GroupV2KickMember(groupId, membershipId, membershipType);
            //Assert.IsType<GroupV2KickMember200Response>(response);
        }

        /// <summary>
        /// Test GroupV2RecoverGroupForFounder
        /// </summary>
        [Fact]
        public void GroupV2RecoverGroupForFounderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int groupType = null;
            //long membershipId = null;
            //int membershipType = null;
            //var response = instance.GroupV2RecoverGroupForFounder(groupType, membershipId, membershipType);
            //Assert.IsType<GroupV2RecoverGroupForFounder200Response>(response);
        }

        /// <summary>
        /// Test GroupV2UnbanMember
        /// </summary>
        [Fact]
        public void GroupV2UnbanMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long groupId = null;
            //long membershipId = null;
            //int membershipType = null;
            //var response = instance.GroupV2UnbanMember(groupId, membershipId, membershipType);
            //Assert.IsType<GroupV2EditGroup200Response>(response);
        }
    }
}

#region GPL Licence

/*
    Tribal Browser: A web browser that allows you to share your personal sites and 
    interact with your Tribe, bypassing search engines and ICANN.
    Copyright (C) 2012 Darren Udaiyan, Frugal Disruptive ltd, darren@frugaldisruptive.com

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program - See LICENCE.TXT in the root directory.  
    If not, see http://www.gnu.org/licenses/.
    */

#endregion

namespace TribalHelper
{
    public static class StringProvider
    {
        #region frmBrowser

        public static string sBack = "Back";
        public static string sForward = "Foward";
        public static string sLoad = "Load Url";
        public static string sAdd = "Add Page";
        public static string sRemove = "Remove Current Page";
        public static string sTools = "Tools - Click on this to open up the power of Tribe Browser";
        public static string sTribeSite = "Click on the site link to go to the page. It's as simple as that :)";
        public static string sUrl = @"Enter your site here - no need to type http:\\ .";
        public static string sPleaseLogin = "You need to log in first.";

        #endregion

        #region frmInsertTribe

        public static string sTribeCreated = "Your Tribe has been created. You are also the first member so now go add some links to it.";
        public static string sTribeExists = "This Tribe already exists. Please choose another name.";
        public static string sTribeBlank = "The Tribe Name or Description cannot be blank.";
        
        #endregion

        #region frmTribeMemberDetails

        public static string sTribeMemberCreated = "Your account has been created. Now join a Tribe.";
        public static string sTribeMemberAmended = "Your details have been saved.";
        public static string sTribeMemberExists = "This username already exists. Please choose another name.";
        public static string sPasswordMismatch = "Passwords do not match";

        #endregion

        #region frmJoinTribe

        public static string sTribeNameBlank = "Please select a Tribe.";
        public static string sTribeJoined = "Tribe joined! You are now officially a member of: ";

        #endregion

        #region frmLogin

        public static string sCorrect = "Correct";
        public static string sInCorrect = "Incorrect";
        public static string sNotTribalElder = "You must be a Tribal Elder";
        public static string sEnterUserName = "Please enter your username";
        public static string sNoEmail = "Unfortunately there is no associated email with this user name - please email: info@frugaldisruptive.com for help.";
        public static string sForgotPssSubj = "Information for Tribal Browser";
        public static string sForgotPssMssg = "The information you require is: ";
        public static string sUsernameNotFound = "This user doesn't exist.";

        #endregion

        #region frmInsertTribeLinks

        public static string sTribeLinkExists = "This site already exists for this Tribe. Please choose another site name";
        public static string sTribeLinkSaved = "Tribe link saved.";
        public static string sTribeLinkBlank = "You need to provide a Site name.";
        public static string sTribeLinkUrlBad = "The Url or IP address doesn't point to a website";
        public static string sTribeSiteUrlNull = "The Site name or the Url cannot be blank.";
        public static string sConfirmDeleteTribeSite = "Are you sure you want to delete site: ";
        public static string slblMySites = "My Sites/Links to share with my Tribe: ";

        #endregion

        #region frmDetailsSites

        public static string sTribeDetailsSaved = "Your Tribe details have been saved.";

        #endregion

        #region frmAddFavourite

        public static string sTribeSiteDscNull = "The Site name and description cannot be blank.";
        public static string sTribeFavouriteExists = "You have already got a favourite site with this name:";
        public static string sTribeFavouriteAdded = "Your favourite site has been saved.";

        #endregion

        #region frmChat

        public static string sJoinChat = " has joined the conversation.";
        public static string sEndChat = " has left the conversation.";
        public static string sChatCleared = "The chat history for this tribe has been cleared.";

        #endregion

        #region  frmDeleteTribeMember

        public static string sConfirmDeleteTribeMember = "Are you sure you want to Tribe member: ";

        #endregion

        #region frmBlockTribeLinks

        public static string sConfirmDeleteTribeBlockSite = "Are you sure you want to delete the blocked site: ";
        public static string sTribeBlockLinkSaved = "The Tribe Block link has been saved. TribeMembers will no longer be able to access this link.";

        #endregion

        #region Misc

        public static string sFavourites = @"'s Favourite: ";
        public static string sClearDatabase = "Are you sure you want to clear the database - all records will be lost.";
        public static string sCleared = "All records cleared.";
        public static string sEmailServerNotSetup = "Sending emails is disabled. The email server code has not been implemented - we basically need to setup a mail server.";

        #endregion
    }
}

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

using System;
using MongoDB.Bson;
using System.Drawing;
using MongoDB.Bson.Serialization.Attributes;

namespace TribalHelper
{
    #region Class Tribe

    public class Tribe
    {
        public ObjectId Id { get; set; }
        public string TbNm { get; set; }
        public string Dsc { get; set; }
        public string UsrNm { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + TbNm.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(Object obj)
        {
            Tribe oObject = obj as Tribe;
            return oObject != null && oObject.TbNm == this.TbNm;
        }
    }

    #endregion

    #region Class TribeMember

    public class TribeMember
    {
        public ObjectId Id { get; set; }
        public string UsrNm { get; set; }
        public string Pss { get; set; }
        public string TbNm { get; set; }
        public string LgIn { get; set; }
        public string Ml { get; set; }
    }

    #endregion

    #region Static Class mTribeMember

    public static class mTribeMember
    {
        public static string UsrNm { get; set; }
        public static string TbNm { get; set; }
        public static bool LgIn { get; set; }
        public static string DefaultTbNm = "frugaldisruptive";
    }

    #endregion

    #region Class TribeLinks

    public class TribeLinks
    {
        public ObjectId Id { get; set; }
        public string St { get; set; }
        public string Url { get; set; }
        public string Dsc { get; set; }
        public string UsrNm { get; set; }
        public string TbNm { get; set; }
        public string Fav { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + St.GetHashCode();
                hash = hash * 23 + Url.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(Object obj)
        {
            TribeLinks oObject = obj as TribeLinks;
            return oObject != null && oObject.St == this.St
                && oObject.Url == this.Url;
        }
    }

    #endregion

    #region Class TribeChat

    public class TribeChat
    {
        public ObjectId Id { get; set; }
        public string UsrNm { get; set; }
        public string TbNm { get; set; }
        public string Msg { get; set; }
        public DateTime dt { get; set; }
    }

    #endregion

    #region Class TribeBlock

    public class TribeBlock
    {
        public ObjectId Id { get; set; }
        public string TbNm { get; set; }
        public string Url { get; set; }
    }

    #endregion

    #region Class TribeProfiles

    public class TribeProfile
    {
        public ObjectId Id { get; set; }
        public string PfNm { get; set; }
        public string PfAbt { get; set; }
        public Bitmap PfImg { get; set; }
        public string UsrNm { get; set; }
    }

    public class TribeProfileComment
    {
        public ObjectId Id { get; set; }
        public string PfNm { get; set; }
        public string PfCmt { get; set; }
        public DateTime dt { get; set; }
    }

    #endregion

}

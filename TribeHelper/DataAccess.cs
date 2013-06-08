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

using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.ComponentModel;
using System;

namespace TribalHelper
{
    public class DataAccess
    {
        #region Member variables

        // The connection string is open and publicized. This is just a test bed database – ideally you'll set-up your own. 
        // Try not to fill it up too much – we periodically do a clean out :)
        private const string m_sConn = "mongodb://FDTribalBrowser:UnitedTheWorld23@ds055397.mongolab.com:55397/tribalbrowser";
        private readonly MongoDatabase m_oDatabase;

        private readonly MongoCollection<Tribe> m_colTribes;
        private readonly MongoCollection<TribeMember> m_colTribeMembers;
        private readonly MongoCollection<TribeLinks> m_colTribeLinks;
        private readonly MongoCollection<TribeChat> m_colTribeChat;
        private readonly MongoCollection<TribeBlock> m_colTribeBlock;

        #endregion

        #region Constructors/ Initialisers

        public DataAccess()
        {
            MongoClient oClient = new MongoClient(m_sConn);
            MongoServer oServer = oClient.GetServer();
            m_oDatabase = oServer.GetDatabase("tribalbrowser");
            m_colTribes = m_oDatabase.GetCollection<Tribe>("Tribes");
            m_colTribeMembers = m_oDatabase.GetCollection<TribeMember>("TribeMembers");
            m_colTribeLinks = m_oDatabase.GetCollection<TribeLinks>("TribeLinks");
            m_colTribeChat = m_oDatabase.GetCollection<TribeChat>("TribeChat");
            m_colTribeBlock = m_oDatabase.GetCollection<TribeBlock>("TribeBlock");
            if (mTribeMember.TbNm == null) mTribeMember.TbNm = mTribeMember.DefaultTbNm;
        }

        #endregion

        #region Public Methods

        #region Insert

        public void InsertTribe(string sTbNm, string sDsc, string sUsrNm)
        {
            var oTb = new Tribe
            {
                TbNm = sTbNm.ToLower(),
                UsrNm = sUsrNm,
                Dsc = sDsc.ToLower()
            };
            m_colTribes.Insert(oTb);
        }

        public void InsertTribeMember(string sUsrNm, string sPss, string sTbNm, string sMl)
        {
            var oTM = new TribeMember
            {
                UsrNm = sUsrNm,
                Pss = sPss,
                TbNm = sTbNm.ToLower(),
                Ml = sMl.ToLower()
            };
            m_colTribeMembers.Insert(oTM);
            mTribeMember.TbNm = sTbNm;
        }

        public void InsertTribeLink(string sSt, string sUrl, string sDsc, string sTbNm, string sUsrNm, string sFav = Favourite.False)
        {
            var oTL = new TribeLinks
            {
                St = sSt.ToLower(),
                Dsc = sDsc.ToLower(),
                TbNm = sTbNm.ToLower(),
                UsrNm = sUsrNm,
                Url = sUrl.ToLower(),
                Fav = sFav
            };
            m_colTribeLinks.Insert(oTL);
        }

        public void InsertTribeChat(string sUsrNm, string sTbNm, string sMsg, DateTime odt)
        {
            var oTC = new TribeChat
            {
                UsrNm = sUsrNm,
                TbNm = sTbNm.ToLower(),
                Msg = sMsg,
                dt = odt
            };
            m_colTribeChat.Insert(oTC);
        }

        public void InsertTribeBlock(string sTbNm, string sUrl)
        {
            var oTB = new TribeBlock
            {
                TbNm = sTbNm.ToLower(),
                Url = sUrl.ToLower()
            };
            m_colTribeBlock.Insert(oTB);
        }
        #endregion

        #region Find

        public TribeMember FindTribeMember()
        {
            var query = Query<TribeMember>.EQ(e => e.UsrNm, mTribeMember.UsrNm);
            return m_colTribeMembers.FindOne(query);
        }

        public List<TribeMember> FindAllTribeMembers()
        {
            return m_colTribeMembers.FindAll().ToList();
        }

        public List<TribeMember> FindOneTribeMember(string sUsrNm)
        {
            var query = Query<TribeMember>.EQ(e => e.UsrNm, sUsrNm);
            return m_colTribeMembers.Find(query).ToList();
        }

        public TribeMember FindTribeMember(string sUsrNm)
        {
            var query = Query<TribeMember>.EQ(e => e.UsrNm, sUsrNm);
            return m_colTribeMembers.FindOne(query);
        }

        public Tribe FindTribe(string sTbNm)
        {
            var query = Query<Tribe>.EQ(e => e.TbNm, sTbNm.ToLower());
            return m_colTribes.FindOne(query);
        }

        public List<Tribe> FindAllMyTribes(string sUsrNm)
        {
            var query = Query<Tribe>.EQ(e => e.UsrNm, sUsrNm);
            return m_colTribes.Find(query).ToList();
        }

        public List<Tribe> FindAllTribes()
        {
            return m_colTribes.FindAll().ToList();
        }

        public List<Tribe> FindTribeAndTop20(string sTbNm)
        {
            HashSet<Tribe> oTribes = new HashSet<Tribe>();
            if (FindTribe(sTbNm) != null) oTribes.Add(FindTribe(sTbNm));
            oTribes.UnionWith(FindTribeLike(sTbNm));
            oTribes.UnionWith(FindTop20Tribes());
            return oTribes.ToList();
        }

        public bool TribeExists(string sTbNm)
        {
            var query = Query<Tribe>.EQ(e => e.TbNm, sTbNm.ToLower());
            return m_colTribes.Find(query).Any();
        }

        public List<Tribe> FindTop20Tribes()
        {
            SortByBuilder sbb = new SortByBuilder();
            sbb.Descending("_id");
            return m_colTribes.FindAll().SetSortOrder(sbb).SetLimit(50).ToList();
        }

        public List<Tribe> FindTribeLike(string sTbNm)
        {
            var query = Query.Matches("TbNm", new BsonRegularExpression(sTbNm + "*", "i"));
            return m_colTribes.FindAs<Tribe>(query).ToList();
        }

        public bool TribeMemberExists(string sUsrNm)
        {
            var query = Query<TribeMember>.EQ(e => e.UsrNm, sUsrNm);
            return m_colTribeMembers.Find(query).Any();
        }

        public List<TribeLinks> FindAllTribeLinks(string sTbNm)
        {
            var query = Query<TribeLinks>.EQ(e => e.TbNm, sTbNm.ToLower());
            return m_colTribeLinks.Find(query).ToList();
        }

        public BindingList<TribeLinks> FindAllTribeLinks()
        {
            return new BindingList<TribeLinks>(m_colTribeLinks.FindAll().ToList());
        }

        public BindingList<TribeLinks> FindAllMyTribeLinks(string sUsrNm, string sTbNm)
        {
            var query = Query<TribeLinks>.Where(e => e.UsrNm == sUsrNm && e.TbNm == sTbNm.ToLower());
            return new BindingList<TribeLinks>(m_colTribeLinks.Find(query).ToList());
        }

        public BindingList<TribeLinks> FindAllMyFavouriteLinks(string sUsrNm, string sTbNm)
        {
            var query = Query<TribeLinks>.Where(e => e.UsrNm == sUsrNm && e.TbNm == sTbNm.ToLower() && e.Fav == Favourite.True);
            return new BindingList<TribeLinks>(m_colTribeLinks.Find(query).ToList());
        }

        public List<TribeLinks> FindTribeLinksAndTop20(string sSt, string sTbNm)
        {
            HashSet<TribeLinks> oTribeLinks = new HashSet<TribeLinks>();
            if (FindTribeLink(sSt, sTbNm) != null) oTribeLinks.Add(FindTribeLink(sSt, sTbNm));
            oTribeLinks.UnionWith(FindTribeLinkLike(sSt, sTbNm));
            oTribeLinks.UnionWith(FindTop20TribeLinks(sTbNm));
            return oTribeLinks.ToList();
        }

        public TribeLinks FindTribeLink(string sSt, string sTbNm)
        {
            var query = Query<TribeLinks>.Where(e => e.St == sSt.ToLower() && e.TbNm == sTbNm.ToLower());
            return m_colTribeLinks.FindOne(query);
        }

        public List<TribeLinks> FindTribeLinkLike(string sSt, string sTbNm)
        {
            var query = Query<TribeLinks>.Where(e => e.St.Contains(sSt.ToLower()) && e.TbNm == sTbNm.ToLower());
            return m_colTribeLinks.Find(query).ToList();
        }

        public bool TribeLinkExists(string sSt, string sTbNm)
        {
            var query = Query<TribeLinks>.Where(e => e.St == sSt.ToLower() && e.TbNm == sTbNm.ToLower());
            return m_colTribeLinks.Find(query).Any();
        }

        public bool TribeFavouriteExists(string sSt, string sTbNm, string sUsrNm)
        {
            var query = Query<TribeLinks>.Where(e => e.St == sSt.ToLower() && e.TbNm == sTbNm.ToLower() && e.UsrNm == sUsrNm);
            return m_colTribeLinks.Find(query).Any();
        }

        public List<TribeLinks> FindTop20TribeLinks(string sTbNm)
        {
            SortByBuilder sbb = new SortByBuilder();
            sbb.Descending("_id");
            var query = Query<TribeLinks>.EQ(e => e.TbNm, sTbNm.ToLower());
            return m_colTribeLinks.Find(query).SetSortOrder(sbb).SetLimit(50).ToList().ToList();
        }

        public List<TribeChat> FindTop50TribeChat(string sTbNm)
        {
            SortByBuilder sbb = new SortByBuilder();
            sbb.Ascending("dt");
            var query = Query<TribeChat>.EQ(e => e.TbNm, sTbNm.ToLower());
            return m_colTribeChat.Find(query).SetSortOrder(sbb).SetLimit(50).ToList().ToList();
        }

        public BindingList<TribeBlock> FindTribeBlocks(string sTbNm)
        {
            var query = Query<TribeBlock>.EQ(e => e.TbNm, sTbNm.ToLower());
            return new BindingList<TribeBlock>(m_colTribeBlock.Find(query).ToList());
        }

        public BindingList<TribeBlock> FindAllTribeBlocks()
        {
            return new BindingList<TribeBlock>(m_colTribeBlock.FindAll().ToList());
        }

        #endregion

        #region Save

        public void SaveTribeDesc(string sDsc)
        {
            Tribe oTribe = new Tribe
                {
                    Dsc = sDsc.ToLower()
                };
            m_colTribes.Save(oTribe);
        }

        public void SaveTribeLinkDetails(string sUrl, string sDsc, string sTbNm, string sUsrNm)
        {
            TribeLinks oTribeLinks = new TribeLinks
                {
                    Url = sUrl.ToLower(),
                    Dsc = sDsc.ToLower(),
                    TbNm = sTbNm.ToLower(),
                    UsrNm = sUsrNm
                };
            m_colTribeLinks.Save(oTribeLinks);
        }

        public void SaveTribeMemberDetails(string sPss, string sTbNm)
        {
            TribeMember oTribeMember = new TribeMember
                {
                    Pss = sPss,
                    TbNm = sTbNm.ToLower()
                };
            m_colTribeMembers.Save(oTribeMember);
        }

        #endregion

        #region Update

        public void UpdateTribeMemberTribe(string sTbNm)
        {
            var query = Query<TribeMember>.EQ(e => e.UsrNm, mTribeMember.UsrNm);
            var update = Update<TribeMember>.Set(e => e.TbNm, sTbNm.ToLower());
            m_colTribeMembers.Update(query, update);
            mTribeMember.TbNm = sTbNm;
        }

        public void UpdateTribeMemberPasswdEmail(string sPss, string sMl)
        {
            var query = Query<TribeMember>.EQ(e => e.UsrNm, mTribeMember.UsrNm);
            var update = Update<TribeMember>.Set(e => e.Pss, sPss)
                                            .Set(e => e.Ml, sMl);
            m_colTribeMembers.Update(query, update);
        }

        public void UpdateTribeLink(string sSt, string sUrl, string sDsc, string sTbNm, string sUsrNm)
        {
            var query = Query<TribeLinks>.Where(e => e.St == sSt && e.TbNm == sTbNm);
            var update = Update<TribeLinks>.Set(e => e.St, sSt.ToLower())
                                           .Set(e => e.Url, sUrl.ToLower())
                                           .Set(e => e.Dsc, sDsc.ToLower())
                                           .Set(e => e.TbNm, sTbNm.ToLower());
            m_colTribeLinks.Update(query, update);
        }

        public void UpdateTribeLink(ObjectId oId, string sSt, string sUrl, string sDsc, string sTbNm, string sUsrNm)
        {
            var query = Query<TribeLinks>.Where(e => e.Id == oId);
            var update = Update<TribeLinks>.Set(e => e.St, sSt.ToLower())
                                           .Set(e => e.Url, sUrl.ToLower())
                                           .Set(e => e.Dsc, sDsc.ToLower())
                                           .Set(e => e.TbNm, sTbNm.ToLower());
            m_colTribeLinks.Update(query, update);
        }

        public void UpdateTribe(string sPrevTbNm, string sDsc)
        {
            var query = Query<Tribe>.Where(e => e.TbNm == sPrevTbNm);
            var update = Update<Tribe>.Set(e => e.TbNm, sPrevTbNm.ToLower())
                                           .Set(e => e.Dsc, sDsc.ToLower());
            m_colTribes.Update(query, update);
        }

        public void UpdateTribeBlock(string sTbNm, string sUrl)
        {
            var query = Query<TribeBlock>.Where(e => e.TbNm == sTbNm);
            var update = Update<TribeBlock>.Set(e => e.Url, sUrl.ToLower());
            m_colTribeBlock.Update(query, update);
        }

        public void UpdateTribeBlock(ObjectId oId, string sTbNm, string sUrl)
        {
            var query = Query<TribeBlock>.Where(e => e.Id == oId);
            var update = Update<TribeBlock>.Set(e => e.TbNm, sTbNm.ToLower())
                                           .Set(e => e.Url, sUrl.ToLower());
            m_colTribeBlock.Update(query, update);
        }

        #endregion

        #region Delete

        public void DeleteTribeLinks(string sSt, string sTbNm)
        {
            var query = Query<TribeLinks>.Where(e => e.St == sSt && e.TbNm == sTbNm);
            m_colTribeLinks.Remove(query);
        }

        public void DeleteTribeLinks(ObjectId oId)
        {
            var query = Query<TribeLinks>.Where(e => e.Id == oId);
            m_colTribeLinks.Remove(query);
        }

        public void DeleteTribeChat(string sTbNm)
        {
            var query = Query<TribeChat>.Where(e => e.TbNm == sTbNm);
            m_colTribeChat.Remove(query);
        }

        public void DeleteTribeMember(string sUsrNm)
        {
            var query = Query<TribeMember>.Where(e => e.UsrNm == sUsrNm);
            m_colTribeMembers.Remove(query);
        }

        public void DeleteTribeMember(ObjectId oId)
        {
            var query = Query<TribeMember>.Where(e => e.Id == oId);
            m_colTribeMembers.Remove(query);
        }

        public void ClearDatabase()
        {
            m_colTribeBlock.RemoveAll();
            m_colTribeChat.RemoveAll();
            m_colTribeLinks.RemoveAll();
            m_colTribeMembers.RemoveAll();
            m_colTribes.RemoveAll();
        }

        #endregion

        #region misc

        public void Login()
        {
            var query = Query<TribeMember>.EQ(e => e.UsrNm, mTribeMember.UsrNm);
            mTribeMember.LgIn = true;
            var update = Update<TribeMember>.Set(e => e.LgIn, mTribeMember.LgIn.ToString());
            m_colTribeMembers.Update(query, update);
            _SetmTribeMember();
        }

        public bool PasswordCorrect(string sUsrNm, string sPss)
        {
            var query = Query<TribeMember>.Where(e => e.UsrNm == sUsrNm && e.Pss == sPss);
            return m_colTribeMembers.Find(query).Any();
        }


        private void _SetmTribeMember()
        {
            TribeMember oTribeMember = FindTribeMember();
            mTribeMember.UsrNm = oTribeMember.UsrNm;
            mTribeMember.TbNm = oTribeMember.TbNm;
            TribeMisc.SaveUserInfo(mTribeMember.TbNm);
        }

        #endregion

        #endregion
    }
}

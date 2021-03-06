﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFForMSsql
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CLNContext : DbContext
    {
        public CLNContext()
            : base("name=CLNContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CLN_AlertComment> CLN_AlertComment { get; set; }
        public virtual DbSet<CLN_Comment> CLN_Comment { get; set; }
        public virtual DbSet<CLN_Email> CLN_Email { get; set; }
        public virtual DbSet<CLN_Favorite> CLN_Favorite { get; set; }
        public virtual DbSet<CLN_Friend> CLN_Friend { get; set; }
        public virtual DbSet<CLN_Group> CLN_Group { get; set; }
        public virtual DbSet<CLN_GroupDiscuss> CLN_GroupDiscuss { get; set; }
        public virtual DbSet<CLN_GroupMember> CLN_GroupMember { get; set; }
        public virtual DbSet<CLN_JieQiaHistory> CLN_JieQiaHistory { get; set; }
        public virtual DbSet<CLN_ProjectType1> CLN_ProjectType1 { get; set; }
        public virtual DbSet<CLN_ProjectType2> CLN_ProjectType2 { get; set; }
        public virtual DbSet<CLN_Remark> CLN_Remark { get; set; }
        public virtual DbSet<CLN_RemarkShop> CLN_RemarkShop { get; set; }
        public virtual DbSet<CLN_Resource> CLN_Resource { get; set; }
        public virtual DbSet<CLN_ResourceFiles> CLN_ResourceFiles { get; set; }
        public virtual DbSet<CLN_UserAuthorze> CLN_UserAuthorze { get; set; }
        public virtual DbSet<NT_AccountLog> NT_AccountLog { get; set; }
        public virtual DbSet<NT_Activity> NT_Activity { get; set; }
        public virtual DbSet<NT_ActivityComment> NT_ActivityComment { get; set; }
        public virtual DbSet<NT_Admin> NT_Admin { get; set; }
        public virtual DbSet<NT_AdminLog> NT_AdminLog { get; set; }
        public virtual DbSet<NT_Album> NT_Album { get; set; }
        public virtual DbSet<NT_APP_ProjectDocking> NT_APP_ProjectDocking { get; set; }
        public virtual DbSet<NT_APP_ProjectDocking_Comment> NT_APP_ProjectDocking_Comment { get; set; }
        public virtual DbSet<NT_APP_ProjectDocking_Files> NT_APP_ProjectDocking_Files { get; set; }
        public virtual DbSet<NT_APP_Webtool> NT_APP_Webtool { get; set; }
        public virtual DbSet<NT_Blog> NT_Blog { get; set; }
        public virtual DbSet<NT_BlogComment> NT_BlogComment { get; set; }
        public virtual DbSet<NT_BlogConcern> NT_BlogConcern { get; set; }
        public virtual DbSet<NT_BlogDraft> NT_BlogDraft { get; set; }
        public virtual DbSet<NT_Board> NT_Board { get; set; }
        public virtual DbSet<NT_CardDrawText> NT_CardDrawText { get; set; }
        public virtual DbSet<NT_CardTemplate> NT_CardTemplate { get; set; }
        public virtual DbSet<NT_ClnMessage> NT_ClnMessage { get; set; }
        public virtual DbSet<NT_ClnMsgAdvLink> NT_ClnMsgAdvLink { get; set; }
        public virtual DbSet<NT_Company> NT_Company { get; set; }
        public virtual DbSet<NT_CurrencyPresent> NT_CurrencyPresent { get; set; }
        public virtual DbSet<NT_Dict_Area> NT_Dict_Area { get; set; }
        public virtual DbSet<NT_Dict_Language> NT_Dict_Language { get; set; }
        public virtual DbSet<NT_Dict_Service> NT_Dict_Service { get; set; }
        public virtual DbSet<NT_Dict_Vocation> NT_Dict_Vocation { get; set; }
        public virtual DbSet<NT_DocumentType> NT_DocumentType { get; set; }
        public virtual DbSet<NT_FeedBack> NT_FeedBack { get; set; }
        public virtual DbSet<NT_FeedBackComment> NT_FeedBackComment { get; set; }
        public virtual DbSet<NT_FeedBackConcern> NT_FeedBackConcern { get; set; }
        public virtual DbSet<NT_ForwardEmailBody> NT_ForwardEmailBody { get; set; }
        public virtual DbSet<NT_Friend> NT_Friend { get; set; }
        public virtual DbSet<NT_FriendDesc> NT_FriendDesc { get; set; }
        public virtual DbSet<NT_FriendInvite> NT_FriendInvite { get; set; }
        public virtual DbSet<NT_GroupCompany> NT_GroupCompany { get; set; }
        public virtual DbSet<NT_GroupCooperation> NT_GroupCooperation { get; set; }
        public virtual DbSet<NT_GroupMsg> NT_GroupMsg { get; set; }
        public virtual DbSet<NT_GroupMsgRead> NT_GroupMsgRead { get; set; }
        public virtual DbSet<NT_Inbox> NT_Inbox { get; set; }
        public virtual DbSet<NT_Information> NT_Information { get; set; }
        public virtual DbSet<NT_InformationComment> NT_InformationComment { get; set; }
        public virtual DbSet<NT_LeadMan> NT_LeadMan { get; set; }
        public virtual DbSet<NT_LeaveWord> NT_LeaveWord { get; set; }
        public virtual DbSet<NT_Letter> NT_Letter { get; set; }
        public virtual DbSet<NT_MarketEmail> NT_MarketEmail { get; set; }
        public virtual DbSet<NT_MarketMobile> NT_MarketMobile { get; set; }
        public virtual DbSet<NT_MarketSell> NT_MarketSell { get; set; }
        public virtual DbSet<NT_MarketSellExchange> NT_MarketSellExchange { get; set; }
        public virtual DbSet<NT_NewsLetterEmail> NT_NewsLetterEmail { get; set; }
        public virtual DbSet<NT_NewsLetterMobile> NT_NewsLetterMobile { get; set; }
        public virtual DbSet<NT_Notepad> NT_Notepad { get; set; }
        public virtual DbSet<NT_Notice> NT_Notice { get; set; }
        public virtual DbSet<NT_OnlineUser> NT_OnlineUser { get; set; }
        public virtual DbSet<NT_Order> NT_Order { get; set; }
        public virtual DbSet<NT_OrderDets> NT_OrderDets { get; set; }
        public virtual DbSet<NT_Outbox> NT_Outbox { get; set; }
        public virtual DbSet<NT_OutFriend> NT_OutFriend { get; set; }
        public virtual DbSet<NT_OutFriendFile> NT_OutFriendFile { get; set; }
        public virtual DbSet<NT_OutFriendSell> NT_OutFriendSell { get; set; }
        public virtual DbSet<NT_OutFriendSellExchange> NT_OutFriendSellExchange { get; set; }
        public virtual DbSet<NT_Photo> NT_Photo { get; set; }
        public virtual DbSet<NT_PhotoComment> NT_PhotoComment { get; set; }
        public virtual DbSet<NT_PhotoConcern> NT_PhotoConcern { get; set; }
        public virtual DbSet<NT_Recruit> NT_Recruit { get; set; }
        public virtual DbSet<NT_RecruitComment> NT_RecruitComment { get; set; }
        public virtual DbSet<NT_Request> NT_Request { get; set; }
        public virtual DbSet<NT_Resource> NT_Resource { get; set; }
        public virtual DbSet<NT_ResourceComment> NT_ResourceComment { get; set; }
        public virtual DbSet<NT_ResourceConcern> NT_ResourceConcern { get; set; }
        public virtual DbSet<NT_RetrievePwd> NT_RetrievePwd { get; set; }
        public virtual DbSet<NT_Shop> NT_Shop { get; set; }
        public virtual DbSet<NT_ShopFiles> NT_ShopFiles { get; set; }
        public virtual DbSet<NT_SmtpMailPool> NT_SmtpMailPool { get; set; }
        public virtual DbSet<NT_SpaceTemplate> NT_SpaceTemplate { get; set; }
        public virtual DbSet<NT_SX> NT_SX { get; set; }
        public virtual DbSet<NT_SX_MD5> NT_SX_MD5 { get; set; }
        public virtual DbSet<NT_SysNotepad> NT_SysNotepad { get; set; }
        public virtual DbSet<Nt_ToVote> Nt_ToVote { get; set; }
        public virtual DbSet<NT_User> NT_User { get; set; }
        public virtual DbSet<NT_UserInfo> NT_UserInfo { get; set; }
        public virtual DbSet<NT_UserLog> NT_UserLog { get; set; }
        public virtual DbSet<NT_UserPointHistory> NT_UserPointHistory { get; set; }
        public virtual DbSet<NT_UserProps> NT_UserProps { get; set; }
        public virtual DbSet<NT_Visit> NT_Visit { get; set; }
        public virtual DbSet<NTV_FriendDetail> NTV_FriendDetail { get; set; }
        public virtual DbSet<tb_Order> tb_Order { get; set; }
        public virtual DbSet<NT_ActivityConcern> NT_ActivityConcern { get; set; }
        public virtual DbSet<NT_CommentScore> NT_CommentScore { get; set; }
        public virtual DbSet<NT_EmailNotify> NT_EmailNotify { get; set; }
        public virtual DbSet<NT_InformationConcern> NT_InformationConcern { get; set; }
        public virtual DbSet<NT_InformationScore> NT_InformationScore { get; set; }
        public virtual DbSet<NT_MarketData> NT_MarketData { get; set; }
        public virtual DbSet<NT_MarketFax> NT_MarketFax { get; set; }
        public virtual DbSet<NT_MarketSellLog> NT_MarketSellLog { get; set; }
        public virtual DbSet<NT_OutFriendFileContent> NT_OutFriendFileContent { get; set; }
        public virtual DbSet<NT_OutFriendSellLog> NT_OutFriendSellLog { get; set; }
        public virtual DbSet<NT_RecruitConcern> NT_RecruitConcern { get; set; }
        public virtual DbSet<NT_ShopConcern> NT_ShopConcern { get; set; }
        public virtual DbSet<NT_ShopFilesDownlog> NT_ShopFilesDownlog { get; set; }
        public virtual DbSet<NT_ShopOrder> NT_ShopOrder { get; set; }
        public virtual DbSet<NT_ShopScore> NT_ShopScore { get; set; }
        public virtual DbSet<NT_UserLoginExt> NT_UserLoginExt { get; set; }
        public virtual DbSet<NT_UserSetting> NT_UserSetting { get; set; }
        public virtual DbSet<NT_Visitor> NT_Visitor { get; set; }
        public virtual DbSet<NTV_FriendDetailStat> NTV_FriendDetailStat { get; set; }
        public virtual DbSet<Opensocial_activity_media_items> Opensocial_activity_media_items { get; set; }
        public virtual DbSet<tb_errorlog> tb_errorlog { get; set; }
        public virtual DbSet<V_CLN_Comment> V_CLN_Comment { get; set; }
    }
}

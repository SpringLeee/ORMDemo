//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CLN_Favorite
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public int ServiceId { get; set; }
        public System.DateTime Adddate { get; set; }
    }
}
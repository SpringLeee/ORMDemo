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
    
    public partial class NT_UserLoginExt
    {
        public int UserID { get; set; }
        public string SinaWBUID { get; set; }
        public string SinaName { get; set; }
        public string SinaToken { get; set; }
        public string SinaAccessToken { get; set; }
        public string SinaRefreshToken { get; set; }
        public System.DateTime SinaUpdateTime { get; set; }
        public System.DateTime SinaExpiresTime { get; set; }
        public string QQUID { get; set; }
        public string QQName { get; set; }
        public string QQToken { get; set; }
        public string QQAccessToken { get; set; }
        public string QQRefreshToken { get; set; }
        public System.DateTime QQUpdateTime { get; set; }
        public System.DateTime QQExpiresTime { get; set; }
    }
}
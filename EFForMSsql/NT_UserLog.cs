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
    
    public partial class NT_UserLog
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ActionType { get; set; }
        public System.DateTime LogTime { get; set; }
        public string LogIP { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public Nullable<int> CorrespondInfo { get; set; }
        public bool IsLock { get; set; }
        public bool IsDel { get; set; }
        public Nullable<int> CorreUserID { get; set; }
    }
}
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
    
    public partial class NT_FeedBackComment
    {
        public int ID { get; set; }
        public int AskID { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        public System.DateTime PostTime { get; set; }
        public string PostIP { get; set; }
        public bool IsLock { get; set; }
    }
}

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
    
    public partial class NT_FriendDesc
    {
        public int ID { get; set; }
        public int Modifier { get; set; }
        public int Affirmant { get; set; }
        public int DescType { get; set; }
        public int Reply { get; set; }
        public Nullable<int> DescStartYear { get; set; }
        public Nullable<int> DescEndYear { get; set; }
        public Nullable<bool> DescIsKnow { get; set; }
        public string DescText { get; set; }
    }
}
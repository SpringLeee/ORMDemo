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
    
    public partial class NT_MarketFax
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FaxCount { get; set; }
        public int Flag { get; set; }
        public bool isDel { get; set; }
        public System.DateTime AddTime { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}

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
    
    public partial class tb_Order
    {
        public int ID { get; set; }
        public string OrderNO { get; set; }
        public int UserID { get; set; }
        public int OrderType { get; set; }
        public decimal TotalMoneyCNY { get; set; }
        public Nullable<decimal> PayMoneyCNY { get; set; }
        public Nullable<decimal> RealPayMoneyCNY { get; set; }
        public System.DateTime Addtime { get; set; }
        public System.DateTime PayTime { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
        public int PayType { get; set; }
        public int OrderStatus { get; set; }
    }
}

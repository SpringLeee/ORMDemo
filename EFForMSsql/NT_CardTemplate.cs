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
    
    public partial class NT_CardTemplate
    {
        public int ID { get; set; }
        public string AbsPathFace { get; set; }
        public string AbsPathBack { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool Enable { get; set; }
        public System.DateTime AddTime { get; set; }
        public string Title { get; set; }
        public string TitleEN { get; set; }
        public string Remark { get; set; }
        public string RemarkEN { get; set; }
        public int BarcodeHeight { get; set; }
        public int BarcodeWidth { get; set; }
        public int BarcodeX { get; set; }
        public int BarcodeY { get; set; }
    }
}

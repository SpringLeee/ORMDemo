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
    
    public partial class CLN_ResourceFiles
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public int ResourceID { get; set; }
        public int UserId { get; set; }
        public int FileSize { get; set; }
        public int DownloadCount { get; set; }
        public System.DateTime UploadTime { get; set; }
        public string FileType { get; set; }
        public string MIME { get; set; }
        public string AbsPath { get; set; }
    }
}

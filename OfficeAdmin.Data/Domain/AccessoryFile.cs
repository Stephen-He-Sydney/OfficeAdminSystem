using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class AccessoryFile
    {
        [Key]
        public int AccessoryFileID { get; set; }
        public string AccessoryName { get; set; }
        public int AccessorySize { get; set; }
        public DateTime CreateDate { get; set; }
        public string AccessoryFilePath { get; set; }
        public int FileID { get; set; }
        public int AccessoryFileTypeID { get; set; }

        // Foreign keys
        public virtual File File { get; set; }
        public virtual FileType FileType { get; set; }
    }
}

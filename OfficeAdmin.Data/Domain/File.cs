using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class File
    {
        public File() 
        {
            this.AccessoryFiles = new HashSet<AccessoryFile>();
        }

        [Key]
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string Remark { get; set; }
        public string FileOwner { get; set; }
        public DateTime CreateDate { get; set; }
        public int ParentID { get; set; }
        public string FilePath { get; set; }
        public bool IsDeleted { get; set; }
        public int FileTypeID { get; set; }

        // Foreign keys
        public virtual FileType FileType { get; set; } 
     
        //Current primay key as others' FK
        public virtual ICollection<AccessoryFile> AccessoryFiles { get; set; }
    }
}

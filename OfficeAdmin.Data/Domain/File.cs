using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [MaxLength(200)]
        [Index("IX_FileOwner", IsUnique = false)]
        public string FileOwner { get; set; }

        [Index("IX_CreateDate", IsUnique = false)]
        public DateTime CreateDate { get; set; }

        [Index("IX_ParentID", IsUnique = false)]
        public int ParentID { get; set; }

        public string FilePath { get; set; }

        public bool IsDeleted { get; set; }

        [Index("IX_FileTypeID", IsUnique = false)]
        public int FileTypeID { get; set; }

        // Foreign keys
        public virtual FileType FileType { get; set; } 
     
        //Current primay key as others' FK
        public virtual ICollection<AccessoryFile> AccessoryFiles { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeAdmin.Data.Domain
{
    public class AccessoryFile
    {
        [Key]
        public int AccessoryFileID { get; set; }

        public string AccessoryName { get; set; }

        public int AccessorySize { get; set; }

        [Index("IX_CreateDate", IsUnique = false)]
        public DateTime CreateDate { get; set; }

        public string AccessoryFilePath { get; set; }

        [Index("IX_FileID", IsUnique = false)]
        public int FileID { get; set; }

        [Index("IX_AccessoryFileTypeID", IsUnique = false)]
        public int AccessoryFileTypeID { get; set; }

        // Foreign keys
        public virtual File File { get; set; }

        public virtual FileType FileType { get; set; }
    }
}

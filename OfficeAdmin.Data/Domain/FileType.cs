using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class FileType
    {
        public FileType()
        {
            this.AccessoryFiles = new HashSet<AccessoryFile>();
            this.Files = new HashSet<File>();
        }

        [Key]
        public int FileTypeID { get; set; }
        public string FileTypeName { get; set; }
        public string FileTypeImage { get; set; }
        public string FileTypeExtension { get; set; }

        //Current primay key as others' FK
        public virtual ICollection<AccessoryFile> AccessoryFiles { get; set; }
        public virtual ICollection<File> Files { get; set; }
    }
}

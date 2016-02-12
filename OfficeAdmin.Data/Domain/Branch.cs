using System;
using System.ComponentModel.DataAnnotations;

namespace OfficeAdmin.Data.Domain
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        public string BranchName { get; set; }

        public string BranchShortName { get; set; }
    }
}

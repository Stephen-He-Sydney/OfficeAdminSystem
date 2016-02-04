using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OfficeAdmin.Data
{
    public class OfficeAdminContextCustomInitializer : IDatabaseInitializer<OfficeAdminContext>
    {
        public void InitializeDatabase(OfficeAdminContext context)
        {
            if (!context.Database.Exists())
            {
                context.Database.Create();
            }
        }
    }
}

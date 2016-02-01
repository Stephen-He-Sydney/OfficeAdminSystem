using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeAdmin.Data.Domain;

namespace OfficeAdmin.Service.Login
{
    public interface ILoginService
    {
        IQueryable<UserInfo> GetAll();
    }
}

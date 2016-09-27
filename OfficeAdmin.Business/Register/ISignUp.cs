using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeAdmin.Data.Domain;

namespace OfficeAdmin.Business.Register
{
    public interface ISignUp
    {
        bool IsUsernameExisted(string username);
        bool IsCreateValidPassword(string password);
        void AddNewUser(UserInfo userInfo);
    }
}

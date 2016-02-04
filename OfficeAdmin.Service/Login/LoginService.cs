using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeAdmin.Data.Domain;
using OfficeAdmin.Repository;

namespace OfficeAdmin.Service.Login
{
    public class LoginService:ILoginService
    {
        private IRepository<UserInfo> _userRepository;

        public LoginService(IRepository<UserInfo> userRepository)
        {
            _userRepository = userRepository;
        }

        public IQueryable<UserInfo> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}

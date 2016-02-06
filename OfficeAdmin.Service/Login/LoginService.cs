using System.Linq;
using OfficeAdmin.Data.Domain;
using OfficeAdmin.Repository;
using OfficeAdmin.Service.Models;

namespace OfficeAdmin.Service.Login
{
    public class LoginService : ILoginService
    {
        private IRepository<UserInfo> _userRepository;

        public LoginService(IRepository<UserInfo> userRepository)
        {
            _userRepository = userRepository;
        }

        public UserInfo IsCurrentLoginValid(LoginServiceModel loginServiceModel)
        {
            // search linq for user login
            //要code first设username为唯一键

            return _userRepository.GetAll()
                                  .SingleOrDefault(p => p.UserName == loginServiceModel.Username
                                                     && p.Password == loginServiceModel.Password);

        }
    }
}

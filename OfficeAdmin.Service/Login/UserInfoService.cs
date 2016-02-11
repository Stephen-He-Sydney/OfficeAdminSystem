using System.Linq;
using OfficeAdmin.Data.Domain;
using OfficeAdmin.Repository;
using OfficeAdmin.Service.Models;
using OfficeAdmin.Service.Helpers;

namespace OfficeAdmin.Service.Login
{
    public class UserInfoService : IUserInfoService
    {
        private IRepository<UserInfo> _userRepository;

        public UserInfoService(IRepository<UserInfo> userRepository)
        {
            _userRepository = userRepository;
        }

        public bool IsCurrentLoginValid(LoginServiceModel loginServiceModel)
        {
            // search linq for user login
            //要code first设username为唯一键

            UserInfo currUser = _userRepository.GetAll()
                                         .SingleOrDefault(p => p.UserName == loginServiceModel.Username);

            if (currUser == null) return false;
            else
            {
                string hashPwd = Sha256Helper.GetHashBySha256(currUser.Salt + loginServiceModel.Password);
                if (hashPwd == currUser.Password)
                {
                    return true;
                }
                return false;
            }
        }
    }
}

using System.Linq;
using OfficeAdmin.Data.Domain;
using OfficeAdmin.Data.Repository;

namespace OfficeAdmin.Service.Users
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IRepository<UserInfo> _userRepository;

        public UserInfoService(IRepository<UserInfo> userRepository)
        {
            _userRepository = userRepository;
        }

        public UserInfo GetUserInfoByUserName(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                return _userRepository.SearchFor(p => p.UserName == username).FirstOrDefault();
            }
            return null;
        }

        public UserInfo GetUserInfoByLogin(string username, string password)
        {
            if (!string.IsNullOrEmpty(username))
            {
                return _userRepository.SearchFor(p => p.UserName == username && p.Password == password).FirstOrDefault();
            }
            return null;
        }

        public UserInfo GetUserInfoByUserId(int id)
        {
            return _userRepository.SearchFor(p => p.UserID == id).FirstOrDefault();
        }

        public void AddUserInfo(UserInfo userInfo)
        {
            _userRepository.InsertAsync(userInfo);
        }

        public void UpdateUserInfo(UserInfo userInfo)
        {
            _userRepository.EditAsync(userInfo);
        }

        public void RemoveUserInfo(UserInfo userInfo)
        {
            _userRepository.DeleteAsync(userInfo);
        }

        //public bool IsCurrentLoginValid(LoginServiceModel loginServiceModel)
        //{
        //    // search linq for user login
        //    //要code first设username为唯一键

        //    UserInfo currUser = _userRepository.GetAll()
        //                                 .SingleOrDefault(p => p.UserName == loginServiceModel.Username);

        //    if (currUser == null) return false;
        //    else
        //    {
        //        string hashPwd = Sha256Helper.GetHashBySha256(currUser.Salt + loginServiceModel.Password);
        //        if (hashPwd == currUser.Password)
        //        {
        //            return true;
        //        }
        //        return false;
        //    }
        //}
    }
}

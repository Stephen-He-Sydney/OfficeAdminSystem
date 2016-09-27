using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeAdmin.Service.Users;
using OfficeAdmin.Data.Domain;

namespace OfficeAdmin.Business.Register
{
    public class SignIn : ISignIn
    {
        private readonly IUserInfoService _userInfoService;
        //private readonly IUserInfoService _userInfoService;
        //private readonly IUserInfoService _userInfoService;
        //private readonly IUserInfoService _userInfoService;
        public SignIn(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }

        public bool IsUsernameExisted(string username)
        {
            UserInfo userInfo = _userInfoService.GetUserInfoByUserName(username);
            return userInfo == null ? false : true;
        }

        public bool IsCreateValidPassword(string password)
        {
            if (password.Length > 6 && password.Contains("")) return true;
            else return false;
        }

        public void AddNewUser(UserInfo userInfo)
        {
            if (_userInfoService.GetUserInfoByLogin(userInfo.UserName, userInfo.Password) == null)
                _userInfoService.AddUserInfo(userInfo);
        }
    }
}

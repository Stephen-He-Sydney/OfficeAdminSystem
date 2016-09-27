using OfficeAdmin.Data.Domain;

namespace OfficeAdmin.Service.Users
{
    public interface IUserInfoService
    {
        UserInfo GetUserInfoByUserName(string username);
        UserInfo GetUserInfoByLogin(string username, string password);
        UserInfo GetUserInfoByUserId(int id);
        void AddUserInfo(UserInfo userInfo);
        void UpdateUserInfo(UserInfo userInfo);
        void RemoveUserInfo(UserInfo userInfo);
    }
}

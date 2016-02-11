using OfficeAdmin.Data.Domain;
using OfficeAdmin.Service.Models;

namespace OfficeAdmin.Service.Login
{
    public interface IUserInfoService
    {
        bool IsCurrentLoginValid(LoginServiceModel loginServiceModel);
    }
}

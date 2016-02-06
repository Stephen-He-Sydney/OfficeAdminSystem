using OfficeAdmin.Data.Domain;
using OfficeAdmin.Service.Models;

namespace OfficeAdmin.Service.Login
{
    public interface ILoginService
    {
        UserInfo IsCurrentLoginValid(LoginServiceModel loginServiceModel);
    }
}

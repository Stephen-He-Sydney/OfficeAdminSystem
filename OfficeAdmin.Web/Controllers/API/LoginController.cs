using System.Net.Http;
using System.Web.Http;
using OfficeAdmin.Web.Models;
using OfficeAdmin.Service.Login;
using OfficeAdmin.Service.Models;
using System.Net;

namespace OfficeAdmin.Web.Controllers.API
{
    [RoutePrefix("api")]
    public class LoginController : ApiController
    {
        private ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        [Route("login")]
        public HttpResponseMessage IsCurrentLoginValid(LoginModel loginModel)
        {
            LoginServiceModel loginServiceModel = new LoginServiceModel()
            {
                Username = loginModel.Username,
                Password = loginModel.Password
            };

            if (_loginService.IsCurrentLoginValid(loginServiceModel) == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, false);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
        }
    }
}
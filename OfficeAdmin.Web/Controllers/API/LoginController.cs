using System.Net.Http;
using System.Web.Http;
using OfficeAdmin.Web.Models;
using OfficeAdmin.Service.Login;
//using OfficeAdmin.Service.Models;
using System.Net;

namespace OfficeAdmin.Web.Controllers.API
{
    [RoutePrefix("api")]
    public class LoginController : ApiController
    {
        private IUserInfoService _loginService;
        // To define business domain, access more service layers 

        public LoginController(IUserInfoService loginService)
        {
            _loginService = loginService;
        }

        //[HttpPost]
        //[Route("login")]
        //public HttpResponseMessage IsCurrentLoginValid(LoginModel loginModel)
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, _loginService.IsCurrentLoginValid(loginServiceModel));
        //}
    }
}
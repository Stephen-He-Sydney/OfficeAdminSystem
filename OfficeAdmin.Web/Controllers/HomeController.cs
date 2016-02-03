using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OfficeAdmin.Service.Login;

namespace OfficeAdmin.Web.Controllers
{
    public class HomeController : Controller
    {
        private ILoginService _loginService;

        public HomeController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public ActionResult Index()
        {
            var a = _loginService.GetAll().ToList(); 

            return View();
        }
    }
}
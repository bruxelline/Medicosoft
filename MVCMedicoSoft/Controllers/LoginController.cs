using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMedicoSoft.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        [HttpGet]
        public ActionResult Forms()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Forms(string txtLogin, string txtPassword)
        {
            return View();
        }
	}
}
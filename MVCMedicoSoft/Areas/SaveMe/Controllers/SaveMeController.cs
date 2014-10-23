using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;

namespace MVCMedicoSoft.Areas.SaveMe
{
    public class SaveMeController : Controller
    {
        //
        // GET: /SaveMe/SaveMe/
         [HttpGet]
        public ActionResult Rescue()
        {
            return View();
        }

         [HttpPost]
         public ActionResult ResponseRescue(string numRegNational)
         {
             return View();
             /*
             Personne p = Personne.getInfo(this.NumRegNational);
             if (p == null)
             {
                 ViewBag.Error = "Try Again!!!";
                 return View();
             }
             else
             {
                 //1 - stocker en session le login de l'utilisateur
                 MySession.numRegNational =p.numRegNational;
              

                 //2 - rediriger vers SaveMe/Index
                 //return View();
                 return RedirectToRoute(
                 new { controller = "SaveMe", action = "Rescue" });
             }
              */
         }
	}
}
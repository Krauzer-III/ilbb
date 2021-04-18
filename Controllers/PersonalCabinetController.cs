using ATOM.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATOM.Controllers
{
    public class PersonalCabinetController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            string idauthorizedUser = User.Identity.GetUserId();
            var user = db.Users.FirstOrDefault(t => t.Id == idauthorizedUser);
            try
            {
                if (db.Improver.FirstOrDefault(imp => imp.Email == user.UserName) != null)
                {
                    return RedirectToAction("ImproverCabinet");
                }
                if (db.Employers.FirstOrDefault(imp => imp.Email == user.UserName) != null)
                {
                    return RedirectToAction("EmployerCabinet");
                }
            }
            catch {
                return RedirectToAction("Zaglushka");
            }
            return RedirectToAction("Zaglushka");


        }
        // GET: PersonalCabinet
        public ActionResult EmployerCabinet()
        {
            return View();
        }

        public ActionResult ImproverCabinet()
        {
            return View();
        }

        public ActionResult VladykaCabinet()
        {

            return View();
        }
        
        public ActionResult Zaglushka()
        {

            return View();
        }
    }
}
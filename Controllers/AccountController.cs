using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoundWaveOfficial.Models;

namespace SoundWaveOfficial.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Membership model)
        {
            return View();
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(tbl_Registration1 model)
        {
            using(var context =new SoundWaveOfficialEntities1())
            {
                context.tbl_Registration1.Add(model);
                context.SaveChanges();

            }
            return RedirectToAction("Login");
        }
    }
}
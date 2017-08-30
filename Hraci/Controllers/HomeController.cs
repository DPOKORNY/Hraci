using Hraci.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hraci.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           /* RoleManager<IdentityRole> spravceRoli = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new IdentityDbContext()));
            spravceRoli.Create(new IdentityRole("admin"));
            UserManager<ApplicationUser> spravceUzivatelu = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            ApplicationUser uzivatel = spravceUzivatelu.FindByEmail("baty@seznam.cz");
            spravceUzivatelu.AddToRole(uzivatel.Id, "admin");
            */
            return View();
        }

        

        public ActionResult Contact()
        {
            ViewBag.Message = "Naše kontaktní stránka.";

            return View();
        }

        public ActionResult Soupiska()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

       public ActionResult AjaxRequest()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class ProfileController : Controller
    {
        //
        // GET: /Profile/

        public ActionResult Index()
        {
            ViewBag.Title = "profile Managment";
            ViewBag.Message = "Profile Management Page";
            return View();
           
        }

        public ActionResult Profile()
        {
            ViewBag.Title = "My Profile";
         
            return View();
        }

        public String ProfileEdit()
        {
            
            return "Edit Profile Here";
        }

    }
}

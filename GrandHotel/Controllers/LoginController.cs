using GrandHotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrandHotel.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login (Accesso a)
        {
            Accesso accesso =db.getAccessoByUsername()
        }
    }
}
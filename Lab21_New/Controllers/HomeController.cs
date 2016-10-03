using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab21_New.Models;

namespace Lab21_New.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RegForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RegForm(RegistrationResponse registrationResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", registrationResponse);
            } else
            {
                return View();
            }
        }
    }
}
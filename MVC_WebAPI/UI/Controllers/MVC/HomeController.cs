using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi_exam.Models;

namespace WebApi_exam.Controllers.MVC
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ArgListForFind model = new ArgListForFind();
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
using DataLayer.DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace WebApi_exam.Controllers.MVC
{
    public class HomeController : Controller
    {

        RentDBModel context = new RentDBModel();
        

        public ActionResult Index()
        {
            ArgListForFind model = new ArgListForFind();
            return View(model);
            
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public string Search(ObjForSearch obj)
        {
            return string.Format("id - {0} str - {1}", obj.Id, obj.Str);            
        }


    }
}